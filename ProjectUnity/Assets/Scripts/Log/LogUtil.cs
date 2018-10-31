
using System.Collections;
using System.Collections.Generic;
#if !SLUA_STANDALONE
using UnityEngine;
#endif
public static class LogUtil
{
    public enum LogLevel
    {
        None,
        Info,
        Warn,
        Error,
        Exeception,
        Abort,
    }

    public static LogLevel loglevel = LogLevel.Info;
    private static object lockobj = new object();

    public static void Log(string str, params object[] args)
    {
        str = string.Format(str, args);
		SLua.Logger.Log (str);
    }

    public static void LogWarning(string str, params object[] args)
    {
        str = string.Format(str, args);
		SLua.Logger.LogWarning(str);
    }

    public static void LogError(string str, params object[] args)
    {
        str = string.Format(str, args);
		SLua.Logger.LogError(str);
    }

    public static void LogException(System.Exception ex, Object context = null)
    {
		SLua.Logger.LogException(ex, context);
    }

    class LogMessage
    {
        public LogType type;
        public string str;
    }
    static List<LogMessage> sCachedLogList = new List<LogMessage>();

    static void LogCallback(string condition, string stackTrace, LogType type)
    {
        if(type == LogType.Log)
        {
            ProcessLog(type, condition);
        }  
        else if(type == LogType.Warning)
        {
            ProcessLog(type, condition);
        }
        else
        {
            ProcessLog(type, condition);
            ProcessLog(type, stackTrace);
        }
    }

    static void ProcessLog(LogType type,string str)
    {
        lock (lockobj)
        {
            if (sCachedLogList.Count > 0)
            {
                List<LogMessage> sTempLogList = new List<LogMessage>(sCachedLogList);
                foreach (var log in sTempLogList)
                {
                    if (!ReportLog(log.type, log.str))
                    {
                        CacheLog(type, str);
                        return;
                    }
                }
                sCachedLogList.Clear();
            }

            if (!ReportLog(type, str))
            {
                CacheLog(type, str);
            }
            else
            {
                sCachedLogList.Clear();
            }
        }
    }

    static bool ReportLog(LogType type,string str)
    {
		if (!SLua.LuaSvr.inited || null == SLua.LuaSvr.mainState)
			return false;
		SLua.LuaState l = SLua.LuaSvr.mainState;
        if (null == l)
            return false;
        SLua.LuaFunction func = l.getFunction("OnUnityLog");
        if (null != func)
        {
            func.call(new object[] { type, str });
            func.Dispose();
            return true;
        }
        return false;
    }
    static void CacheLog(LogType type,string str)
    {
        sCachedLogList.Add(new LogMessage{ type = type, str = str });
    }

    public static void AttachUnityLogHandle()
    {
#if !SLUA_STANDALONE
		Application.logMessageReceived += LogCallback;
#else
		SLua.Logger.logMessageReceived += LogCallback;
#endif
    }
    public static void DetachUnityLogHandle()
    {
#if !SLUA_STANDALONE
		Application.logMessageReceived -= LogCallback;
#else
		SLua.Logger.logMessageReceived -= LogCallback;
#endif
    }

}
