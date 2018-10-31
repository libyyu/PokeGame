/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。

插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using System;
using BestHTTP.Authentication;

namespace BestHTTP
{
    public sealed class HTTPProxy
    {
        public Uri Address { get; set; }
        public Credentials Credentials { get; set; }

        public bool IsTransparent { get; set; }

        /// <summary>
        /// Some non-transparent proxies are except only the path and query of the request uri. Default value is true.
        /// </summary>
        public bool SendWholeUri { get; set; }

        public HTTPProxy()
            :this(null, null, false)
        {}


        public HTTPProxy(Uri address)
            :this(address, null, false)
        {}

        public HTTPProxy(Uri address, Credentials credentials)
            :this(address, credentials, false)
        {
            SendWholeUri = true;
        }

        public HTTPProxy(Uri address, Credentials credentials, bool isTransparent)
        {
            this.Address = address;
            this.Credentials = credentials;
            this.IsTransparent = isTransparent;
        }
    }
}
