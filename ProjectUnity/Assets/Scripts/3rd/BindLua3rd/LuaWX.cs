#if UNITY_WEBGL && !UNITY_EDITOR
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System;

namespace SLua
{
    public class LuaWx
    {

        [SLua.Lua3rdDLL.LualibReg("WxModule")]
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        public static int luaL_openWx(IntPtr l)
        {
            LogUtil.Log("register wx module");
            Lua_WeChatWASM_WXBase.reg(l);
            Lua_WeChatWASM_WX.reg(l);
            Lua_WXProfileStatsScript.reg(l);
            Lua_WXProfileStatsScript_ProfValue.reg(l);
            Lua_WXTouchInputOverride.reg(l);

            return 0;
        }

        public static void reg(ref Dictionary<string, LuaCSFunction> DLLRegFuncs)
        {
            if(!DLLRegFuncs.ContainsKey("WxModule"))
                DLLRegFuncs.Add("WxModule", luaL_openWx);
        }
    }
}
#endif