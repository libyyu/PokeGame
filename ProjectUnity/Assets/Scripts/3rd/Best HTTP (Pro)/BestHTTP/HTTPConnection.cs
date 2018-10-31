/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。

插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

#if !NETFX_CORE
// http://www.dzhang.com/blog/2012/08/29/synchronization-in-async-csharp-methods
//#define LOCK_ON_FILE
#endif

using System;
using System.Collections.Generic;
using System.IO;
#if (!UNITY_WP8 && !UNITY_WINRT && !UNITY_METRO) || UNITY_EDITOR
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
#endif
using System.Text;
using System.Threading;
using BestHTTP.Caching;

using TcpClient = SocketEx.TcpClient;
using BestHTTP.Extensions;
using BestHTTP.Authentication;
using Org.BouncyCastle.Crypto.Tls;
using BestHTTP.Cookies;

#if NETFX_CORE
using System.Threading.Tasks;
using Windows.Networking.Sockets;

//Disable CD4014: Because this call is not awaited, execution of the current method continues before the call is completed. Consider applying the 'await' operator to the result of the call.
#pragma warning disable 4014
#endif

namespace BestHTTP
{
    /// <summary>
    /// Represents and manages a connection to a server.
    /// </summary>
    internal sealed class HTTPConnection : IDisposable
    {
        private enum RetryCauses
        {
            /// <summary>
            /// The request processed without any special case.
            /// </summary>
            None,

            /// <summary>
            /// If the server closed the connection while we sending a request we should reconnect and send the request again. But we will try it once.
            /// </summary>
            Reconnect,

            /// <summary>
            /// We need an another try with Authorization header set.
            /// </summary>
            Authenticate,

            /// <summary>
            /// The proxy needs authentication.
            /// </summary>
            ProxyAuthenticate,
        }

        #region Public Properties

        /// <summary>
        /// The address of the server that this connection is bound to.
        /// </summary>
        internal string ServerAddress { get; private set; }

        /// <summary>
        /// The state of this connection.
        /// </summary>
        internal HTTPConnectionStates State { get; private set; }

        /// <summary>
        /// It's true if this connection is available to process a HTTPRequest.
        /// </summary>
        internal bool IsFree { get { return State == HTTPConnectionStates.Free; } }

        /// <summary>
        /// If the State is HTTPConnectionStates.Processing, then it holds a HTTPRequest instance. Otherwise it's null.
        /// </summary>
        internal HTTPRequest CurrentRequest { get; private set; }

        internal bool IsRemovable { get { return IsFree && (DateTime.UtcNow - LastProcessTime) > HTTPManager.MaxConnectionIdleTime; } }

        /// <summary>
        /// When we start to process the current request. It's set after the connection is estabilished.
        /// </summary>
        internal DateTime StartTime { get; private set; }

        /// <summary>
        /// When this connection timed out.
        /// </summary>
        internal DateTime TimedOutStart { get; private set; }

        internal HTTPProxy Proxy { get; private set; }
        internal bool HasProxy { get { return Proxy != null; } }
        internal Uri LastProcessedUri { get; private set; }

        #endregion

        #region Private Properties

        private TcpClient Client;
        private Stream Stream;
        private DateTime LastProcessTime;

        #endregion

        internal HTTPConnection(string serverAddress)
        {
            this.ServerAddress = serverAddress;
            this.State = HTTPConnectionStates.Initial;
            this.LastProcessTime = DateTime.UtcNow;
        }

        internal void Process(HTTPRequest request)
        {
            if (State == HTTPConnectionStates.Processing)
                throw new Exception("Connection already processing a request!");

            StartTime = DateTime.MaxValue;
            State = HTTPConnectionStates.Processing;

            CurrentRequest = request;
#if NETFX_CORE
            Windows.System.Threading.ThreadPool.RunAsync(ThreadFunc);
#else
            //ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadFunc));
            new Thread(ThreadFunc).Start();
#endif
        }

        internal void Recycle()
        {
            State = HTTPConnectionStates.Free;
            CurrentRequest = null;
        }

        #region Request Processing Implementation

        private
#if NETFX_CORE
            async
#endif
            void ThreadFunc(object param)
        {
            bool alreadyReconnected = false;
            bool redirected = false;

            RetryCauses cause = RetryCauses.None;

#if LOCK_ON_FILE
            object uriLock = null;
#endif

#if UNITY_WEBPLAYER
            // Right now, no caching supported in the webplayer
            if (!CurrentRequest.DisableCache)
                CurrentRequest.DisableCache = true;
#endif

            try
            {
                if (!HasProxy && CurrentRequest.HasProxy)
                    Proxy = CurrentRequest.Proxy;

                // Lock only if we will use the cached entity.
#if LOCK_ON_FILE
                if (!CurrentRequest.DisableCache)
                    Monitor.Enter(uriLock = HTTPCacheFileLock.Acquire(CurrentRequest.CurrentUri));
#endif

                // Try load the full response from an already saved cache entity. If the response 
                if (TryLoadAllFromCache())
                    return;

                if (Client != null && !Client.IsConnected())
                    Close();

                do // of while (reconnect)
                {
                    if (cause == RetryCauses.Reconnect)
                    {
                        Close();
#if NETFX_CORE
                        await Task.Delay(100);
#else
                        Thread.Sleep(100);
#endif
                    }

                    LastProcessedUri = CurrentRequest.CurrentUri;

                    cause = RetryCauses.None;

                    // Connect to the server
                    Connect();

                    if (State == HTTPConnectionStates.AbortRequested)
                        throw new Exception("AbortRequested");

                    // Setup cache control headers before we send out the request
                    if (!CurrentRequest.DisableCache)
                        HTTPCacheService.SetHeaders(CurrentRequest);

                    // Write the request to the stream
                    // sentRequest will be true if the request sent out successfully(no SocketException), so we can try read the response
                    bool sentRequest = CurrentRequest.SendOutTo(Stream);

                    // sentRequest only true if there are no exceptions during CurrentRequest.SendOutTo.
                    if (!sentRequest)
                    {
                        Close();

                        if (State == HTTPConnectionStates.TimedOut)
                            throw new Exception("AbortRequested");

                        // We will try again only once
                        if (!alreadyReconnected)
                        {
                            alreadyReconnected = true;
                            cause = RetryCauses.Reconnect;
                        }
                    }

                    // If sending out the request succeded, we will try read the response.
                    if (sentRequest)
                    {
                        bool received = Receive();

                        if (State == HTTPConnectionStates.TimedOut)
                            throw new Exception("AbortRequested");

                        if (!received && !alreadyReconnected)
                        {
                            alreadyReconnected = true;
                            cause = RetryCauses.Reconnect;
                        }

                        if (CurrentRequest.Response != null)
                        {
                            switch (CurrentRequest.Response.StatusCode)
                            {
                                // Not authorized
                                // http://www.w3.org/Protocols/rfc2616/rfc2616-sec10.html#sec10.4.2
                                case 401:
                                    {
                                        string authHeader = CurrentRequest.Response.GetFirstHeaderValue("www-authenticate");
                                        if (!string.IsNullOrEmpty(authHeader))
                                        {
                                            var digest = DigestStore.GetOrCreate(CurrentRequest.CurrentUri);
                                            digest.ParseChallange(authHeader);

                                            if (CurrentRequest.Credentials != null && digest.IsUriProtected(CurrentRequest.CurrentUri) && (!CurrentRequest.HasHeader("Authorization") || digest.Stale))
                                                cause = RetryCauses.Authenticate;
                                        }

                                        goto default;
                                    }

                                // Proxy authentication required
                                // http://www.w3.org/Protocols/rfc2616/rfc2616-sec10.html#sec10.4.8
                                case 407:
                                    {
                                        if (CurrentRequest.HasProxy)
                                        {
                                            string authHeader = CurrentRequest.Response.GetFirstHeaderValue("proxy-authenticate");
                                            if (!string.IsNullOrEmpty(authHeader))
                                            {
                                                var digest = DigestStore.GetOrCreate(CurrentRequest.Proxy.Address);
                                                digest.ParseChallange(authHeader);

                                                if (CurrentRequest.Proxy.Credentials != null && digest.IsUriProtected(CurrentRequest.Proxy.Address) && (!CurrentRequest.HasHeader("Proxy-Authorization") || digest.Stale))
                                                    cause = RetryCauses.ProxyAuthenticate;
                                            }
                                        }

                                        goto default;
                                    }

                                // Redirected
                                case 301: // http://www.w3.org/Protocols/rfc2616/rfc2616-sec10.html#sec10.3.2
                                case 302: // http://www.w3.org/Protocols/rfc2616/rfc2616-sec10.html#sec10.3.3
                                case 307: // http://www.w3.org/Protocols/rfc2616/rfc2616-sec10.html#sec10.3.8
                                case 308: // http://tools.ietf.org/html/rfc7238
                                    {
                                        if (CurrentRequest.RedirectCount >= CurrentRequest.MaxRedirects)
                                            goto default;
                                        CurrentRequest.RedirectCount++;

                                        string location = CurrentRequest.Response.GetFirstHeaderValue("location");
                                        if (!string.IsNullOrEmpty(location))
                                        {
                                            Uri redirectUri = GetRedirectUri(location);

                                            // Let the user to take some control over the redirection
                                            if (!CurrentRequest.CallOnBeforeRedirection(redirectUri))
                                            {
                                                HTTPManager.Logger.Information("HTTPConnection", "OnBeforeRedirection returned False");
                                                goto default;
                                            }

                                            // Remove the previously set Host header.
                                            CurrentRequest.RemoveHeader("Host");

                                            // Set the Referer header to the last Uri.
                                            CurrentRequest.SetHeader("Referer", CurrentRequest.CurrentUri.ToString());

                                            // Set the new Uri, the CurrentUri will return this while the IsRedirected property is true
                                            CurrentRequest.RedirectUri = redirectUri;

                                            // Discard the redirect response, we don't need it any more
                                            CurrentRequest.Response = null;

                                            redirected = CurrentRequest.IsRedirected = true;
                                        }
                                        else
                                            #if !NETFX_CORE
                                                throw new MissingFieldException(string.Format("Got redirect status({0}) without 'location' header!", CurrentRequest.Response.StatusCode.ToString()));
                                            #else
                                                throw new Exception(string.Format("Got redirect status({0}) without 'location' header!", CurrentRequest.Response.StatusCode.ToString()));
                                            #endif

                                        goto default;
                                    }

                                default:
                                    if (CurrentRequest.IsCookiesEnabled)
                                        CookieJar.Set(CurrentRequest.Response);

                                    TryStoreInCache();
                                    break;
                            }

                            // If we have a response and the server telling us that it closed the connection after the message sent to us, then 
                            //  we will colse the connection too.
                            if (CurrentRequest.Response == null ||
                                CurrentRequest.Response.HasHeaderWithValue("connection", "close") || 
                                CurrentRequest.UseAlternateSSL)
                                Close();
                        }
                    }

                } while (cause != RetryCauses.None);
            }
            catch(TimeoutException e)
            {
                CurrentRequest.Response = null;
                CurrentRequest.Exception = e;
                CurrentRequest.State = HTTPRequestStates.ConnectionTimedOut;

                Close();
            }
            catch (Exception e)
            {
                if (CurrentRequest.UseStreaming)
                    HTTPCacheService.DeleteEntity(CurrentRequest.CurrentUri);

                // Something gone bad, Response must be null!
                CurrentRequest.Response = null;

                switch(State)
                {
                    case HTTPConnectionStates.AbortRequested:
                        CurrentRequest.State = HTTPRequestStates.Aborted;
                        break;
                    case HTTPConnectionStates.TimedOut:
                        CurrentRequest.State = HTTPRequestStates.TimedOut;
                        break;
                    default:
                        CurrentRequest.Exception = e;
                        CurrentRequest.State = HTTPRequestStates.Error;                        
                        break;
                }

                Close();
            }
            finally
            {
#if LOCK_ON_FILE
                if (!CurrentRequest.DisableCache && uriLock != null)
                    Monitor.Exit(uriLock);
#endif

                // Avoid state changes. While we are in this block changing the connection's State, on Unity's main thread
                //  the HTTPManager's OnUpdate will check the connections's State and call functions that can change the inner state of
                //  the object. (Like setting the CurrentRequest to null in function Recycle() causing a NullRef exception)
                lock (HTTPManager.Locker)
                {
                    if (CurrentRequest != null && CurrentRequest.Response != null && CurrentRequest.Response.IsUpgraded)
                        State = HTTPConnectionStates.Upgraded;
                    else
                        State = redirected ? HTTPConnectionStates.Redirected : (Client == null ? HTTPConnectionStates.Closed : HTTPConnectionStates.WaitForRecycle);

                    // Change the request's state only when the whole processing finished
                    if (CurrentRequest.State == HTTPRequestStates.Processing && (State == HTTPConnectionStates.Closed || State == HTTPConnectionStates.WaitForRecycle))
                        CurrentRequest.State = HTTPRequestStates.Finished;

                    if (CurrentRequest.State == HTTPRequestStates.ConnectionTimedOut)
                        State = HTTPConnectionStates.Closed;

                    LastProcessTime = DateTime.UtcNow;
                }

                HTTPCacheService.SaveLibrary();
                CookieJar.Persist();
            }
        }

        private void Connect()
        {
            Uri uri = CurrentRequest.HasProxy ? CurrentRequest.Proxy.Address : CurrentRequest.CurrentUri;

            if (Client == null)
                Client = new TcpClient();

            if (!Client.Connected)
            {
                Client.ConnectTimeout = CurrentRequest.ConnectTimeout;

#if NETFX_CORE
                Client.UseHTTPSProtocol = !CurrentRequest.UseAlternateSSL && HTTPProtocolFactory.IsSecureProtocol(uri);

                // On WinRT and >WP8 we use the more secure Tls12 protocol, but on WP8 only Ssl is available...
                #if UNITY_WP_8_1 || UNITY_METRO_8_1
                    Client.HTTPSProtocol = (int)SocketProtectionLevel.Tls12;
                #else
                    Client.HTTPSProtocol = (int)SocketProtectionLevel.Ssl;
                #endif
#endif
                Client.Connect(uri.Host, uri.Port);

                HTTPManager.Logger.Information("HTTPConnection", "Connected to " + uri.Host);
            }
            else
                HTTPManager.Logger.Information("HTTPConnection", "Already connected to " + uri.Host);

            lock (HTTPManager.Locker)
                StartTime = DateTime.UtcNow;

            if (Stream == null)
            {
                if (HasProxy && !Proxy.IsTransparent)
                {
                    Stream = Client.GetStream();

                    var outStream = new BinaryWriter(Stream);
                    outStream.Write(string.Format("CONNECT {0}:{1} HTTP/1.1", CurrentRequest.CurrentUri.Host, CurrentRequest.CurrentUri.Port).GetASCIIBytes());
                    outStream.Write(HTTPRequest.EOL);

                    outStream.Write(string.Format("Proxy-Connection: Keep-Alive"));
                    outStream.Write(HTTPRequest.EOL);

                    outStream.Write(string.Format("Connection: Keep-Alive"));
                    outStream.Write(HTTPRequest.EOL);

                    outStream.Write(string.Format("Host: {0}:{1}", CurrentRequest.CurrentUri.Host, CurrentRequest.CurrentUri.Port).GetASCIIBytes());
                    outStream.Write(HTTPRequest.EOL);

                    outStream.Write(HTTPRequest.EOL);
                    outStream.Flush();

                    CurrentRequest.ProxyResponse = new HTTPProxyResponse(CurrentRequest, Stream, false, false);
                    if (!CurrentRequest.ProxyResponse.Receive())
                        throw new Exception("Connection to the Proxy Server failed!");

                    // TODO: check & handle proxy status code?
                }

                // We have to use CurrentRequest.CurrentUri here, becouse uri can be a proxy uri with a different protocol
                if (HTTPProtocolFactory.IsSecureProtocol(CurrentRequest.CurrentUri))
                {
                    // On WP8 there are no Mono, so we must use the 'alternate' TlsHandlers
                    if (CurrentRequest.UseAlternateSSL)
                    {
                        var handler = new TlsClientProtocol(Client.GetStream(), new Org.BouncyCastle.Security.SecureRandom());
                        if (CurrentRequest.CustomCertificateVerifyer == null)
                            handler.Connect(new LegacyTlsClient(new AlwaysValidVerifyer()));
                        else
                            handler.Connect(new LegacyTlsClient(CurrentRequest.CustomCertificateVerifyer));
                        Stream = handler.Stream;
                    }
                    else
                    {
#if !UNITY_WP8 && !NETFX_CORE
                        SslStream sslStream = new SslStream(Client.GetStream(), false, (sender, cert, chain, errors) =>
                        {
                            return CurrentRequest.CallCustomCertificationValidator(cert, chain);
                        });

                        if (!sslStream.IsAuthenticated)
                            sslStream.AuthenticateAsClient(uri.Host);
                        Stream = sslStream;
#else
                        Stream = Client.GetStream();
#endif
                    }
                }
                else
                    Stream = Client.GetStream();
            }
        }

        private bool Receive()
        {
            CurrentRequest.Response = HTTPProtocolFactory.Get(HTTPProtocolFactory.GetProtocolFromUri(CurrentRequest.CurrentUri), CurrentRequest, Stream, CurrentRequest.UseStreaming, false);

            if (!CurrentRequest.Response.Receive())
            {
                CurrentRequest.Response = null;
                return false;
            }

            // We didn't check HTTPManager.IsCachingDisabled's value on purpose. (sending out a request with conditional get then change IsCachingDisabled to true may produce undefined behavior)
            if (CurrentRequest.Response.StatusCode == 304)
            {
                int bodyLength;
                using (var cacheStream = HTTPCacheService.GetBody(CurrentRequest.CurrentUri, out bodyLength))
                {
                    if (!CurrentRequest.Response.HasHeader("content-length"))
                        CurrentRequest.Response.Headers.Add("content-length", new List<string>(1) { bodyLength.ToString() });
                    CurrentRequest.Response.IsFromCache = true;
                    CurrentRequest.Response.ReadRaw(cacheStream, bodyLength);
                }
            }

            return true;
        }

        #endregion

        #region Helper Functions

        private bool TryLoadAllFromCache()
        {
            if (CurrentRequest.DisableCache)
                return false;

            // We will try read the response from the cache, but if something happens we will fallback to the normal way.
            try
            {
                //Unless specifically constrained by a cache-control (section 14.9) directive, a caching system MAY always store a successful response (see section 13.8) as a cache entity,
                //  MAY return it without validation if it is fresh, and MAY    return it after successful validation.
                // MAY return it without validation if it is fresh!
                if (HTTPCacheService.IsCachedEntityExpiresInTheFuture(CurrentRequest))
                {
                    CurrentRequest.Response = HTTPCacheService.GetFullResponse(CurrentRequest);

                    if (CurrentRequest.Response != null)
                        return true;
                }
            }
            catch
            {
                HTTPCacheService.DeleteEntity(CurrentRequest.CurrentUri);
            }

            return false;
        }

        private void TryStoreInCache()
        {
            // if UseStreaming && !DisableCache then we already wrote the response to the cache
            if (!CurrentRequest.UseStreaming &&
                !CurrentRequest.DisableCache &&
                CurrentRequest.Response != null &&
                HTTPCacheService.IsCacheble(CurrentRequest.CurrentUri, CurrentRequest.MethodType, CurrentRequest.Response))
            {
                HTTPCacheService.Store(CurrentRequest.CurrentUri, CurrentRequest.MethodType, CurrentRequest.Response);
            }
        }

        private Uri GetRedirectUri(string location)
        {
            Uri result = null;
            try
            {
                result = new Uri(location);
            }
#if !NETFX_CORE
            catch (UriFormatException)
#else
            catch
#endif
            {
                // Sometimes the server sends back only the path and query component of the new uri
                var uri = CurrentRequest.Uri;
                var builder = new UriBuilder(uri.Scheme, uri.Host, uri.Port, location);
                result = builder.Uri;
            }

            return result;
        }

        internal void HandleProgressCallback()
        {
            if (CurrentRequest.OnProgress != null && CurrentRequest.DownloadProgressChanged)
            {
                try
                {
                    CurrentRequest.OnProgress(CurrentRequest, CurrentRequest.Downloaded, CurrentRequest.DownloadLength);

                }
                catch (Exception ex)
                {
                    HTTPManager.Logger.Exception("HTTPManager", "HandleProgressCallback - OnProgress", ex);
                }

                CurrentRequest.DownloadProgressChanged = false;
            }

            if (CurrentRequest.OnUploadProgress != null && CurrentRequest.UploadProgressChanged)
            {
                try
                {
                    CurrentRequest.OnUploadProgress(CurrentRequest, CurrentRequest.Uploaded, CurrentRequest.UploadLength);
                }
                catch (Exception ex)
                {
                    HTTPManager.Logger.Exception("HTTPManager", "HandleProgressCallback - OnUploadProgress", ex);
                }
                CurrentRequest.UploadProgressChanged = false;
            }
        }

        internal void HandleCallback()
        {
            try
            {
                HandleProgressCallback();

                if (State == HTTPConnectionStates.Upgraded)
                {
                    if (CurrentRequest != null && CurrentRequest.Response != null && CurrentRequest.Response.IsUpgraded)
                        CurrentRequest.UpgradeCallback();
                    State = HTTPConnectionStates.WaitForProtocolShutdown;
                }
                else
                    CurrentRequest.CallCallback();
            }
            catch(Exception ex)
            {
                HTTPManager.Logger.Exception("HTTPManager", "HandleCallback", ex);
            }
        }

        internal void Abort(HTTPConnectionStates newState)
        {
            State = newState;

            switch(State)
            {
                case HTTPConnectionStates.TimedOut: TimedOutStart = DateTime.UtcNow; break;
            }

            if (Stream != null)
                Stream.Dispose();
        }

        private void Close()
        {
            LastProcessedUri = null;
            if (Client != null)
            {
                try
                {
                    Client.Close();
                }
                catch
                {

                }
                finally
                {
                    Stream = null;
                    Client = null;
                }
            }
        }

        public void Dispose()
        {
            Close();
        }

        #endregion

    }
}
