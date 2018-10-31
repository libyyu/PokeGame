/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。

插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using System;
using UnityEngine;
using BestHTTP;
using BestHTTP.WebSocket;

public class WebSocketSample : MonoBehaviour
{
    #region Private Fields

    /// <summary>
    /// The WebSocket address to connect
    /// </summary>
    string address = "ws://echo.websocket.org";

    /// <summary>
    /// Default text to send
    /// </summary>
    string msgToSend = "Hello World!";

    /// <summary>
    /// Debug text to draw on the gui
    /// </summary>
    string Text = string.Empty;

    /// <summary>
    /// Saved WebSocket instance
    /// </summary>
    WebSocket webSocket;

    /// <summary>
    /// GUI scroll position
    /// </summary>
    Vector2 scrollPos;

    #endregion

    #region Unity Events

    void OnDestroy()
    {
        if (webSocket != null)
            webSocket.Close();
    }

    void OnGUI()
    {
        GUIHelper.DrawArea(GUIHelper.ClientArea, true, () =>
            {
                scrollPos = GUILayout.BeginScrollView(scrollPos);
                    GUILayout.Label(Text);
                GUILayout.EndScrollView();

                GUILayout.Space(5);

                GUILayout.FlexibleSpace();

                address = GUILayout.TextField(address);

                if (webSocket == null && GUILayout.Button("Open Web Socket"))
                {
                    // Create the WebSocket instance
                    webSocket = new WebSocket(new Uri(address));

                    if (HTTPManager.Proxy != null)
                        webSocket.InternalRequest.Proxy = new HTTPProxy(HTTPManager.Proxy.Address, HTTPManager.Proxy.Credentials, false);

                    // Subscribe to the WS events
                    webSocket.OnOpen += OnOpen;
                    webSocket.OnMessage += OnMessageReceived;
                    webSocket.OnClosed += OnClosed;
                    webSocket.OnError += OnError;

                    // Start connecting to the server
                    webSocket.Open();

                    Text += "Opening Web Socket...\n";
                }

                if (webSocket != null && webSocket.IsOpen)
                {
                    GUILayout.Space(10);

                    GUILayout.BeginHorizontal();
                        msgToSend = GUILayout.TextField(msgToSend);

                        if (GUILayout.Button("Send", GUILayout.MaxWidth(70)))
                        {
                            Text += "Sending message...\n";

                            // Send message to the server
                            webSocket.Send(msgToSend);
                        }
                    GUILayout.EndHorizontal();

                    GUILayout.Space(10);

                    if (GUILayout.Button("Close"))
                    {
                        // Close the connection
                        webSocket.Close(1000, "Bye!");
                    }
                }
            });
    }

    #endregion

    #region WebSocket Event Handlers

    /// <summary>
    /// Called when the web socket is open, and we are ready to send and receive data
    /// </summary>
    void OnOpen(WebSocket ws)
    {
        Text += string.Format("-WebSocket Open!\n");
    }

    /// <summary>
    /// Called when we received a text message from the server
    /// </summary>
    void OnMessageReceived(WebSocket ws, string message)
    {
        Text += string.Format("-Message received: {0}\n", message);
    }

    /// <summary>
    /// Called when the web socket closed
    /// </summary>
    void OnClosed(WebSocket ws, UInt16 code, string message)
    {
        Text += string.Format("-WebSocket closed! Code: {0} Message: {1}\n", code, message);
        webSocket = null;
    }

    /// <summary>
    /// Called when an error occured on client side
    /// </summary>
    void OnError(WebSocket ws, Exception ex)
    {
        string errorMsg = string.Empty;
        if (ws.InternalRequest.Response != null)
            errorMsg = string.Format("Status Code from Server: {0} and Message: {1}", ws.InternalRequest.Response.StatusCode, ws.InternalRequest.Response.Message);

        Text += string.Format("-An error occured: {0}\n", (ex != null ? ex.Message : "Unknown Error " + errorMsg));

        webSocket = null;
    }

    #endregion
}
