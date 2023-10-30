using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System;

namespace SLua
{
    public class LuaBitDLL
    {

        const string LUADLL = LuaDLL.LUADLL;

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int luaopen_bit(IntPtr luaState);

        [SLua.Lua3rdDLL.LualibReg("bit")]
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        public static int luaL_openbit(IntPtr l)
        {
            return luaopen_bit(l);
        }

        //public static void reg(Dictionary<string, LuaCSFunction> DLLRegFuncs)
        //{
        //    DLLRegFuncs.Add("bit", luaL_openbit);
        //}
    }
}
