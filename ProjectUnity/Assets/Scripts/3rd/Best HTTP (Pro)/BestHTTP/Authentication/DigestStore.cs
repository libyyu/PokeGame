/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。

插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BestHTTP.Authentication
{
    /// <summary>
    /// Stores and manages already received digest infos.
    /// </summary>
    internal static class DigestStore
    {
        private static Dictionary<string, Digest> Digests = new Dictionary<string, Digest>();
        private static object Locker = new object();

        public static Digest Get(Uri uri)
        {
            lock (Locker)
            {
                Digest digest = null;
                if (Digests.TryGetValue(uri.Host, out digest))
                    if (!digest.IsUriProtected(uri))
                        return null;
                return digest;
            }
        }

        /// <summary>
        /// It will retrive or create a new Digest for the given Uri.
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        public static Digest GetOrCreate(Uri uri)
        {
            lock (Locker)
            {
                Digest digest = null;
                if (!Digests.TryGetValue(uri.Host, out digest))
                    Digests.Add(uri.Host, digest = new Digest(uri));
                return digest;
            }
        }

        public static void Remove(Uri uri)
        {
            lock(Locker)
                Digests.Remove(uri.Host);
        }
    }
}
