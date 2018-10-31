
using System.Collections;
using System.IO;
#if !SLUA_STANDALONE
using UnityEngine;
#endif

public class LogFile {

    const string LogFileName = "gamelog.log";
    const string ErrorFlag = "has_error";

    private static LogFile s_instance = null;
    public static LogFile Instance {
        get
        {
            if (s_instance == null)
                s_instance = new LogFile();

            return s_instance;
        }
    }

    string LogPath
    {
		get { return Path.Combine(GameUtil.CachePath, "logs"); }
    }
    string BackupPath
    {
		get { return Path.Combine(GameUtil.CachePath, "logs/backup"); }
    }

    public void Backup()
    {
		if(File.Exists(Path.Combine(LogPath, LogFileName)))
        {
			GameUtil.CreateDirectoryForFile(Path.Combine(BackupPath, LogFileName));
			File.Copy(Path.Combine(LogPath, LogFileName), Path.Combine(BackupPath, LogFileName), true);
        }
    }

    public void Init()
    {
        Backup();
#if !SLUA_STANDALONE
        Application.logMessageReceived += LogCallback;
#else
		SLua.Logger.logMessageReceived += LogCallback;
#endif
		if (File.Exists(Path.Combine(LogPath, LogFileName)))
			File.Delete(Path.Combine(LogPath, LogFileName));
		if (File.Exists(Path.Combine(LogPath, ErrorFlag)))
			File.Delete(Path.Combine(LogPath, ErrorFlag));

		if (File.Exists(Path.Combine(BackupPath, LogFileName)))
			File.Delete(Path.Combine(BackupPath, LogFileName));
		if (File.Exists(Path.Combine(BackupPath, ErrorFlag)))
			File.Delete(Path.Combine(BackupPath, ErrorFlag));

		GameUtil.CreateDirectoryForFile(Path.Combine(LogPath, LogFileName));
		GameUtil.CreateDirectoryForFile(Path.Combine(BackupPath, LogFileName));
        
		using (File.Create(Path.Combine(LogPath, LogFileName)))
        {

        }
        LogUtil.Log("LogPath:" + LogPath);
    }

    public void UnInit()
    {
#if !SLUA_STANDALONE
		Application.logMessageReceived -= LogCallback;
#else
		SLua.Logger.logMessageReceived -= LogCallback;
#endif
    }

    void LogCallback(string condition, string stackTrace, LogType type)
    {
        switch(type)
        {
            case LogType.Error:
				if (!File.Exists(Path.Combine(LogPath, LogFileName)))
                {
					using (StreamWriter sw = File.CreateText(Path.Combine(LogPath, LogFileName)))
                    {
						sw.WriteLine (GetTimeStamp ());
                        sw.WriteLine(string.Format("{0}:{1}",condition, stackTrace));
                        sw.Flush();
                    }
                }
                WriteToFile(string.Format("[error]{0}:{1}",condition, stackTrace));
                break;
            case LogType.Exception:
				if (!File.Exists(Path.Combine(LogPath, LogFileName)))
                {
					using (StreamWriter sw = File.CreateText(Path.Combine(LogPath, LogFileName)))
                    {
						sw.WriteLine (GetTimeStamp ());
                        sw.WriteLine(string.Format("{0}:{1}", condition, stackTrace));
                        sw.Flush();
                    }
                }
                WriteToFile(string.Format("[exception]{0}:{1}", condition, stackTrace));
                break;
            case LogType.Assert:
                WriteToFile(string.Format("[assert]{0}", condition));
                break;
            case LogType.Log:
                WriteToFile(string.Format("[info]{0}", condition));
                break;
            case LogType.Warning:
                WriteToFile(string.Format("[warning]{0}", condition));
                break;
        }
    }

    void WriteToFile(string message)
    {
		using (StreamWriter sw = File.AppendText(Path.Combine(LogPath, LogFileName)))
        {
			sw.WriteLine(GetTimeStamp() + "-" + message);
            sw.Flush();
        }
    }

	string GetTimeStamp()
	{
		return "[" + System.DateTime.Now.ToString ("yyyyMMddHHmmss") + "]";
	}
}
	