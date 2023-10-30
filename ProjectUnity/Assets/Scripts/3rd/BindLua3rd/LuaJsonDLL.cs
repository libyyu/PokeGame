using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System;

namespace SLua
{
    public class LuaJsonDLL
    {

        const string LUADLL = LuaDLL.LUADLL;

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int luaopen_cjson(IntPtr luaState);

        [SLua.Lua3rdDLL.LualibReg("cjson")]
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        public static int luaL_opencjson(IntPtr l)
        {
            return luaopen_cjson(l);
        }

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int luaopen_cjson_safe(IntPtr luaState);

        [SLua.Lua3rdDLL.LualibReg("cjson.safe")]
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        public static int luaL_opencjson_safe(IntPtr l)
        {
            return luaopen_cjson_safe(l);
        }

        //public static void reg(Dictionary<string, LuaCSFunction> DLLRegFuncs)
        //{
        //    DLLRegFuncs.Add("cjson", luaL_opencjson);
        //    DLLRegFuncs.Add("cjson.safe", luaL_opencjson_safe);
        //}
    }
}
