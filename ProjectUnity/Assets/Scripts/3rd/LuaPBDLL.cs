using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System;

namespace SLua
{
    public class LuaPBDLL
    {

        const string LUADLL = LuaDLL.LUADLL;

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int luaopen_pb(IntPtr luaState);

        [SLua.Lua3rdDLL.LualibReg("pb")]
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        public static int luaL_openpb(IntPtr l)
        {
            return luaopen_pb(l);
        }

        //public static void reg(Dictionary<string, LuaCSFunction> DLLRegFuncs)
        //{
        //    DLLRegFuncs.Add("pb", luaL_openpb);
        //}
    }
}
