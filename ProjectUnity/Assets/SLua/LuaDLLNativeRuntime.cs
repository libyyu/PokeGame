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
        public static byte[] StringToAnsi(string str)
        {
            Encoding encoding = Encoding.UTF8;
            int count = encoding.GetByteCount(str);
            byte[] buffer = new byte[count + 1];
            encoding.GetBytes(str, 0, str.Length, buffer, 0);

            //Byte[] buffer = System.Text.Encoding.Default.GetBytes(str);
            return buffer;
        }
        public static string AnsiToString(byte[] buffer)
        {
            Encoding encoding = Encoding.UTF8;
            return encoding.GetString(buffer);
        }

#if (UNITY_IPHONE) && !UNITY_EDITOR
		const string FileSystemDLL = "__Internal";
#else
        const string FileSystemDLL = "FileSystem";
#endif
        public static void Establish(IntPtr L)
        {
            exp_EstablishAnyLog(On_FLib_AnyLog);
            //L_SetupLuaState(L);
        }

        public static void UnEstablish()
        {
            exp_UnEstablishAnyLog();
            //L_CleanupLuaState();
        }

        delegate void FLib_AnyLog_Delegate(LogType logType, string message);

        [DllImport(FileSystemDLL, CallingConvention = CallingConvention.Cdecl)]
        extern static void exp_EstablishAnyLog(FLib_AnyLog_Delegate func);

        [DllImport(FileSystemDLL, CallingConvention = CallingConvention.Cdecl)]
        extern static void exp_UnEstablishAnyLog();

        [AOT.MonoPInvokeCallback(typeof(FLib_AnyLog_Delegate))]
        private static void On_FLib_AnyLog(LogType logType, string message)
        {
            switch (logType)
            {
                case LogType.Log:
                    Logger.Log("[" + FileSystemDLL + "]" + message);
                    break;
                case LogType.Warning:
                    Logger.LogWarning("[" + FileSystemDLL + "]" + message);
                    break;
                case LogType.Error:
                    Logger.LogError("[" + FileSystemDLL + "]" + message);
                    break;
                case LogType.Exception:
                    Logger.LogException(new Exception("[" + FileSystemDLL + "]" + message));
                    break;
                case LogType.Assert:
                    Logger.LogError("[" + FileSystemDLL + "]" + message);
                    break;
            }
        }

        [DllImport(FileSystemDLL, CallingConvention = CallingConvention.Cdecl)]
        public extern static void exp_InitAllLayer();

        [DllImport(FileSystemDLL, CallingConvention = CallingConvention.Cdecl)]
        public extern static void exp_UnInitAllLayer();

        [DllImport(FileSystemDLL, CallingConvention = CallingConvention.Cdecl)]
        public extern static void exp_InitLayer(int layer);

        [DllImport(FileSystemDLL, CallingConvention = CallingConvention.Cdecl)]
        public extern static void exp_UnInitLayer(int layer);

        [DllImport(FileSystemDLL, CallingConvention = CallingConvention.Cdecl)]
        extern static int exp_AddFilePackageLayer([MarshalAs(UnmanagedType.LPArray)] byte[] szPath, int mode, bool breadonly);

        public static int AddFilePackageLayer(string szPath, int mode, bool isReadonly)
        {
            LogUtil.Log("AddFilePackageLayer {0} {1}", szPath, mode);
            return exp_AddFilePackageLayer(StringToAnsi(szPath), mode, isReadonly);
        }

        [DllImport(FileSystemDLL, CallingConvention = CallingConvention.Cdecl)]
        extern static bool exp_ReadFileBuffer([MarshalAs(UnmanagedType.LPArray)] byte[] szPath, out IntPtr pData, out int nLength);

        public static bool ReadFileBuffer(string szPath, out IntPtr pData, out int nLength)
        {
            return exp_ReadFileBuffer(StringToAnsi(szPath), out pData, out nLength);
        }

        public static byte[] ReadFileAllBytes(string path)
        {
            IntPtr pFileData = IntPtr.Zero;
            byte[] result = null;
            try
            {
                int nLength;
                if (!ReadFileBuffer(path, out pFileData, out nLength))
                    return null;

                result = new byte[nLength];
                Marshal.Copy(pFileData, result, 0, nLength);
            }
            finally
            {
                exp_ReleaseFileBuffer(pFileData);
            }
            return result;
        }

        [DllImport(FileSystemDLL, CallingConvention = CallingConvention.Cdecl)]
        public extern static void exp_ReleaseFileBuffer(IntPtr pData);

        [DllImport(FileSystemDLL, CallingConvention = CallingConvention.Cdecl)]
        public extern static void exp_ReleaseBuffer(IntPtr pData);

        [DllImport(FileSystemDLL, CallingConvention = CallingConvention.Cdecl)]
        extern static bool exp_FileExists([MarshalAs(UnmanagedType.LPArray)] byte[] szPath, out IntPtr pRealPath, out int nLength, out int Flag);

        static bool FileExists(string szPath, out IntPtr pRealPath, out int nLength, out int Flag)
        {
            return exp_FileExists(StringToAnsi(szPath), out pRealPath, out nLength, out Flag);
        }

        public static bool FileExists(string szPath, out string RealPath, out int Flag)
        {
            Flag = -1;
            RealPath = null;
            IntPtr pRealPath = IntPtr.Zero;
            int nLength;
            bool ret = exp_FileExists(StringToAnsi(szPath), out pRealPath, out nLength, out Flag);
            if (ret) 
            {
                byte[] result = new byte[nLength];
                Marshal.Copy(pRealPath, result, 0, nLength);
                RealPath = AnsiToString(result);
            }

            return ret;
        }

        public static bool FileExists(string szPath)
        {
            IntPtr pRealPath = IntPtr.Zero;
            int nLength;
            int Flag = -1;
            return exp_FileExists(StringToAnsi(szPath), out pRealPath, out nLength, out Flag);
        }
    }
}
