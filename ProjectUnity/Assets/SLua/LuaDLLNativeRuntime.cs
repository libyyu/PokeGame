namespace SLua
{
    using System;
    using System.Runtime.InteropServices;
    using System.Reflection;
    using System.Collections;
    using System.Text;
    using System.Security;
#if !SLUA_STANDALONE
    using UnityEngine;
#endif
    public class LuaDLLNativeRuntime
    {
        const string LUADLL = LuaDLL.LUADLL;

        public static void Establish(IntPtr L)
        {
            L_EstablishAnyLog(On_SLua_AnyLog);
            L_SetupLuaState(L);
        }

        public static void UnEstablish()
        {
            L_UnEstablishAnyLog();
            L_CleanupLuaState();
        }
			
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void L_CleanupLuaState();

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void L_SetupLuaState(IntPtr luaState);

        public delegate void SLua_AnyLog_Delegate(LogType logType, string message);

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public extern static void L_EstablishAnyLog(SLua_AnyLog_Delegate func);

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public extern static void L_UnEstablishAnyLog();

        [AOT.MonoPInvokeCallback(typeof(SLua_AnyLog_Delegate))]
        private static void On_SLua_AnyLog(LogType logType, string message)
        {
            switch(logType)
            {
                case LogType.Log:
					LogUtil.Log("["+LUADLL+"]"+message);
                    break;
                case LogType.Warning:
					LogUtil.LogWarning("["+LUADLL+"]"+message);
                    break;
                case LogType.Error:
                    LogUtil.LogError("["+LUADLL+"]"+message);
                    break;
                case LogType.Exception:
					LogUtil.LogException(new Exception("["+LUADLL+"]"+message));
                    break;
                case LogType.Assert:
					LogUtil.LogError("["+LUADLL+"]"+message);
                    break;
            }
        }
    }
}
