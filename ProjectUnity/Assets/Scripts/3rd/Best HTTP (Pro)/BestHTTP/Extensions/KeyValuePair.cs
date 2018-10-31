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
using System.Linq;
using System.Text;

namespace BestHTTP.Extensions
{
    /// <summary>
    /// Used in string parsers. Its Value is optional.
    /// </summary>
    public sealed class KeyValuePair
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public KeyValuePair(string key)
        {
            this.Key = key;
        }

        public override string ToString()
        {
            if (!string.IsNullOrEmpty(Value))
                return String.Concat(Key, '=', Value);
            else
                return Key;
        }
    }
}
