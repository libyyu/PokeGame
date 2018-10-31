

using System;

namespace SLua
{
#if SLUA_STANDALONE
	internal enum LogType
	{
		Error,
		Assert,
		Warning,
		Log,
		Exception
	}
#endif

    /// <summary>
    /// A bridge between UnityEngine.Debug.LogXXX and standalone.LogXXX
    /// </summary>
    internal class Logger
    {
#if SLUA_STANDALONE
		public delegate void LogCallback (string condition, string stackTrace, LogType type);
		public static event LogCallback logMessageReceived;
#endif
        public static void Log(string msg)
        {
#if !SLUA_STANDALONE
            UnityEngine.Debug.Log(msg);
#else
            Console.WriteLine(msg);
			if(logMessageReceived != null)
				logMessageReceived(msg, "", LogType.Log);
#endif 
        }
        public static void LogError(string msg)
        {
#if !SLUA_STANDALONE
            UnityEngine.Debug.LogError(msg);
#else
            Console.WriteLine(msg);
			if(logMessageReceived != null)
				logMessageReceived(msg, "", LogType.Error);
#endif
        }

		public static void LogWarning(string msg)
		{
#if !SLUA_STANDALONE
			UnityEngine.Debug.LogWarning(msg);
#else
            Console.WriteLine(msg);
			if(logMessageReceived != null)
				logMessageReceived(msg, "", LogType.Warning);
#endif
		}

		public static void LogException(System.Exception ex, UnityEngine.Object context = null)
		{
#if !SLUA_STANDALONE
			if (null == context)
				UnityEngine.Debug.LogException(ex);
			else
				UnityEngine.Debug.LogException(ex, context);
#else
			if(null == context)
				Console.WriteLine("Exception:" + ex.Message);
			else
				Console.WriteLine("Exception:" + ex.Message + ", " + context.ToString());

			if(logMessageReceived != null)
				logMessageReceived(ex.Message, "", LogType.Exception);
#endif
		}


#if !SLUA_STANDALONE
		private static UnityEngine.Object FindScriptByMsg(string msg)
		{
#if UNITY_EDITOR
			string[] lines = msg.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
			for (int i = 2; i < lines.Length; i++)
			{
				int idx = lines[i].IndexOf(":");
				if (idx < 0) continue;
				string filename = lines[i].Substring(0, idx);
				idx = filename.LastIndexOf("/");
				if (idx >= 0) filename = filename.Substring(idx + 1);
				filename = filename.Trim();
				string[] guids = UnityEditor.AssetDatabase.FindAssets(filename);
				filename = filename + ".txt";
				for (int j = 0; j < guids.Length; j++)
				{
					string path = UnityEditor.AssetDatabase.GUIDToAssetPath(guids[j]);
					if (System.IO.Path.GetFileName(path).Equals(filename))
					{
#if UNITY_5
						return UnityEditor.AssetDatabase.LoadAssetAtPath<UnityEngine.Object>(path);				
#else
						return UnityEditor.AssetDatabase.LoadAssetAtPath(path,typeof(UnityEngine.Object));
#endif				
					}
				}
			}
#endif
			return null;
		}
#endif

#if !SLUA_STANDALONE
		static void Traceback(string msg, bool hasStacktrace = false) 
		{
#if UNITY_5
			var Type = UnityEngine.Application.GetStackTraceLogType (UnityEngine.LogType.Log);
			UnityEngine.Application.SetStackTraceLogType (UnityEngine.LogType.Log, UnityEngine.StackTraceLogType.None);
			UnityEngine.Debug.Log (msg, hasStacktrace ? FindScriptByMsg (msg) : null);
			UnityEngine.Application.SetStackTraceLogType (UnityEngine.LogType.Log, Type);
#else
			UnityEngine.Debug.Log(msg);
#endif
		}

		static void TracebackErr(string msg, bool hasStacktrace = false) 
		{
#if UNITY_5
		var Type = UnityEngine.Application.GetStackTraceLogType (UnityEngine.LogType.Error);
		UnityEngine.Application.SetStackTraceLogType (UnityEngine.LogType.Error, UnityEngine.StackTraceLogType.None);
		UnityEngine.Debug.LogError (msg, hasStacktrace ? FindScriptByMsg (msg) : null);
		UnityEngine.Application.SetStackTraceLogType (UnityEngine.LogType.Error, Type);
#else
			UnityEngine.Debug.LogError(msg);
#endif
		}
#endif

    }
}