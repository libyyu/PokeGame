

using BestHTTP;
using SLua;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

[CustomLuaClass]
public class GameUtil
{
	const string STREAMASSET_DIR = "StreamingAssets";
	const string LUA_DIR = "Lua";
	const string SEP_PCK_DIR = "pck";
	const string CACHE_DIR = "Cache";

    public static string MakePathForWWW(string path)
    {
        if (path.IndexOf("://") == -1)
        {
#if UNITY_EDITOR || UNITY_STANDALONE_WIN || UNITY_STANDALONE_OSX
            return "file:///" + path;
#else
            return "file://" + path;
#endif
        }
        else
            return path;
    }

	public static string MakePathFromWWW(string path)
	{
		if (path.IndexOf("://") != -1)
		{
#if UNITY_EDITOR || UNITY_STANDALONE_WIN || UNITY_STANDALONE_OSX
			string head = "file:///";
			return path.Substring(head.Length,path.Length-head.Length);
#else
			string head = "file://";
			return path.Substring(head.Length,path.Length-head.Length);
#endif
		}
		else
			return path;
	}

    public static string MakePathForLua(string name)
    {
        string lowerName = name.ToLower();
        if (lowerName.EndsWith(".lua"))
        {
            int index = name.LastIndexOf('.');
            name = name.Substring(0, index);
        }
        name = name.Replace('.', '/');
        name += ".lua";
		//如果资源分离文件存在，则使用该文件
		if (CanSepAssets && Directory.Exists (SepLuaPath)) {
			if (File.Exists (Path.Combine (SepLuaPath, name)))
				return Path.Combine (SepLuaPath, name);
		} 
		//如果更新文件存在
		else {
			if(File.Exists(Path.Combine(LuaPath, name)))
				return Path.Combine(LuaPath, name);
		}
        //从resbase中读取
		return Path.Combine(BaseStreamAssetPath+"/res_base/" + LUA_DIR, name);
    }

	//资源主目录
    private static string assetRoot;
    public static string AssetRoot
    {
        get
        {
            if (!string.IsNullOrEmpty(assetRoot))
                return assetRoot;
#if UNITY_EDITOR && !USE_ZIPASSETS
			return Application.dataPath +  "/../../Output";
#elif UNITY_ANDROID
			return Application.persistentDataPath + "/assets"; //该目录有读写权限
#else
            return Application.temporaryCachePath + "/assets"; //该目录有读写权限
#endif
        }
        set
        {
            assetRoot = value;
        }
    }
	//资源路径
    public static string AssetPath
    {
        get
        {
			return AssetRoot + "/" + STREAMASSET_DIR;
        }
    }
	//Lua路径
    private static string luaPath;
    public static string LuaPath
    {
        get
        {
            if (!string.IsNullOrEmpty(luaPath))
                return luaPath;
			return AssetRoot + "/" + LUA_DIR;
        }
        set
        {
            luaPath = value;
        }
    }
	//资源分离相关
	private static bool canSepAssets;
	public static bool CanSepAssets
	{
		get { return canSepAssets; }
		set { canSepAssets = value; }
	}
	
    //分离目录
    public static string SepPath 
    {
        get {
#if UNITY_EDITOR
			return Application.dataPath + "/../../" + SEP_PCK_DIR;
#elif UNITY_ANDROID
			return Application.persistentDataPath + "/" + SEP_PCK_DIR;
#else
			return Application.temporaryCachePath + "/" + SEP_PCK_DIR;
#endif
        }
    }

    public static string SepAssetPath
    {
		get { return SepPath + "/" + STREAMASSET_DIR; }
    }
    public static string SepLuaPath
    {
		get { return SepPath + "/" + LUA_DIR; }
    }
	//缓存相关
    public static string CachePath
    {
        get
        {
#if UNITY_EDITOR && !USE_ZIPASSETS
			return Application.dataPath+ "/../" + CACHE_DIR;
#else
			return Application.temporaryCachePath;
#endif
        }
    }

	public static string BaseStreamAssetPath
	{
		get
		{
#if UNITY_ANDROID
			return "jar:file://" + Application.dataPath + "!/assets";
#elif UNITY_IPHONE
			return Application.dataPath + "/Raw";
#else
			return Application.streamingAssetsPath;
#endif
		}
	}

    //资源分离文件是否存在
    public static bool IsSepFileExist(string f, out string filename)
    {
        string fn = f.ToLower();
		if (File.Exists(Path.Combine(SepPath, fn)))
        {
			filename = Path.Combine(SepPath,fn);
            return true;
        }
        else
        {
            filename = null;
            return false;
        }
    }

    public static void CreateDirectory(string dir)
    {
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }
    }
    public static void CreateDirectoryForFile(string filepath)
    {
        Directory.CreateDirectory(Path.GetDirectoryName(filepath));
    }
    public static bool IsDirectoryExist(string dir)
    {
        return Directory.Exists(dir);
    }

    public static string RapFilePath(string fullname)
    {
        return fullname.Replace('\\', '/');
    }

    public static string GetFilePath(string fullname)
    {
        String temp = RapFilePath(fullname);

        int nPos = temp.LastIndexOf('/');
        if (nPos != -1)
        {
            return temp.Substring(0, nPos);
        }
        else
            return temp;
    }
    public static string FileName(string fullname)
    {
        String temp = RapFilePath(fullname);

        int nPos = temp.LastIndexOf('/');
        if (nPos != -1)
        {
            return temp.Substring(nPos + 1);
        }
        else
            return temp;
    }
    public static string FileNameWithoutExt(string fullname)
    {
        string fname = FileName(fullname);
        int nPos = fname.LastIndexOf('.');
        if (nPos != -1)
        {
            return fname.Substring(0, nPos);
        }
        else
            return fname;
    }
    static bool ContainsFileExt(string[] filters, string ext)
    {
        for (int i = 0; i < filters.Length; ++i)
        {
            if (filters[i].Equals(ext))
                return true;
        }
        return false;
    }

    [DoNotToLua]
    public static void Recursive(ref List<string> files, string path, string[] filters)
    {
        try
        {
            string[] names = Directory.GetFiles(path);
            string[] dirs = Directory.GetDirectories(path);
            foreach (string filename in names)
            {
                string ext = Path.GetExtension(filename);
                if (filters != null && ContainsFileExt(filters, ext)) continue;
                files.Add(filename.Replace('\\', '/'));
            }
            foreach (string dir in dirs)
            {
                Recursive(ref files, dir, filters);
            }
        }
        catch (Exception e)
        {
            LogUtil.LogWarning(e.Message);
        }
    }

    public static List<string> RecursiveFiles(string path, string[] filters)
    {
        List<string> ret = new List<string>();
        Recursive(ref ret, path, filters);
        return ret;
    }

    public static string ToHexString(byte[] bytes, string sep = ",")
    {
        string byteStr = string.Empty;
        if (bytes != null && bytes.Length > 0)
        {
            int nPos = 0;
            foreach (var item in bytes)
            {
                nPos++;
                byteStr += string.Format("{0:X2}", item);
                if (nPos < bytes.Length)
                    byteStr += sep;
            }
        }
        return byteStr;
    }

    public static string ToBytesString(byte[] bytes, string sep = ",")
    {
        string byteStr = string.Empty;
        if (bytes != null && bytes.Length > 0)
        {
            int nPos = 0;
            foreach (var item in bytes)
            {
                nPos++;
                byteStr += item.ToString();
                if (nPos < bytes.Length)
                    byteStr += sep;
            }
        }
        return byteStr;
    }

    static IEnumerator _ansy_open_file_(string path, System.Action<bool, object> cb)
    {
        WWW www = new WWW(path);
        yield return www;
        if (www.isDone)
        {
            cb(true, www);
        }
        else
        {
            cb(false, www.error);
        }
    }
	
	//异步读取文件，比如Android包文件
    public static void AnsyOpenFile(string filePath, LuaFunction cb)
    {
        string filename = MakePathForWWW(filePath);
        EntryPoint.Instance.StartCoroutine(_ansy_open_file_(filename, (success, o) =>
        {
            cb.call(success, o);
            cb.Dispose();
        }));
    }
		
	public static bool IsAssetFileExists(string filePath)
	{
#if UNITY_ANDROID
        if (filePath.IndexOf("://") != -1)
        {
            //调用android接口
            return false;
        }
        else
#endif
        {
            string path = GameUtil.MakePathFromWWW(filePath);
            return File.Exists(path);
        }
	}

    public static byte[] ReadAssetFile(string filePath)
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        
#endif

#if UNITY_ANDROID
        if (filePath.IndexOf("://") != -1)
        {
            //调用android接口
            return null;
        }
        else
#endif
        {
            string path = GameUtil.MakePathFromWWW(filePath);
            if(File.Exists(path))
            {
                FileStream fs = File.Open(path, FileMode.Open);
                long length = fs.Length;
                byte[] bytes = new byte[length];
                fs.Read(bytes, 0, bytes.Length);
                fs.Close();

                return bytes;
            }
            else
                return null;
        }
    }

	

    //发送HTTP请求
    public static void SendRequest(string url, string data,double t,bool bGet, LuaFunction completeHandler)
    {
        var request = new HTTPRequest(new Uri(url), bGet ? HTTPMethods.Get : HTTPMethods.Post, (req, resp) =>
        {
            if (completeHandler != null)
            {
                completeHandler.call(req, resp);  //req, resp ��Ҫ��¶��slua����
                completeHandler.Dispose();
            }
        });
        request.RawData = Encoding.UTF8.GetBytes(data);
        request.ConnectTimeout = TimeSpan.FromSeconds(t);//��ʱ
        request.Send();
    }

    //下载HTTP文件
    public static void DownLoad(string SrcFilePath, string SaveFilePath, bool bGet, bool keepAlive,object complete_param, LuaFunction progressHander, LuaFunction completeHander)
    {
		string tmpPath = SaveFilePath + ".tmp";
		if (File.Exists (tmpPath)) File.Delete (tmpPath);
		
        var request = new HTTPRequest(new Uri(SrcFilePath), bGet ? HTTPMethods.Get : HTTPMethods.Post, keepAlive, (req, resp) =>
        {
            List<byte[]> fragments = null;
            string status = "";
            switch (req.State)
            {
                case HTTPRequestStates.Processing:
                    {
                        fragments = resp.GetStreamedFragments();
                        if (fragments != null && fragments.Count > 0)
                        {
							FileStream fs = new FileStream(tmpPath, FileMode.Append);
                            foreach (byte[] data in fragments)
                                fs.Write(data, 0, data.Length);
							fs.Close();
                        }
                    }
                    break;
                case HTTPRequestStates.Finished:
                    {
                        if (resp.IsSuccess)
                        {
                        	if (progressHander != null)
				            {
				                progressHander.Dispose();
				            }
                            // Save any remaining fragments
                            fragments = resp.GetStreamedFragments();
                            if (fragments != null && fragments.Count > 0)
                            {
								FileStream fs = new FileStream(tmpPath, FileMode.Append);
                                foreach (byte[] data in fragments)
                                    fs.Write(data, 0, data.Length);
								fs.Close();
                            }
                            if(resp.IsStreamingFinished)
                            {
								if (File.Exists (SaveFilePath)) File.Delete (SaveFilePath);
								FileInfo fi = new FileInfo(tmpPath);
								fi.MoveTo(SaveFilePath);

                                status = "Streaming finished!";
                                if (completeHander != null)
                                {
                                    completeHander.call(true, req, resp, complete_param);
                                    completeHander.Dispose();
                                }
                                else
                                    LogUtil.Log(status);
                            }
                        }
                        else
                        {
                        	if (progressHander != null)
				            {
				                progressHander.Dispose();
				            }
                            status = string.Format("Request finished Successfully, but the server sent an error. Status Code: {0}-{1} Message: {2}",
                                                            resp.StatusCode,
                                                            resp.Message,
                                                            resp.DataAsText);
                            if (completeHander != null)
                            {
                                completeHander.call(false, req, resp, status);
                                completeHander.Dispose();
                            }
                            else
                                LogUtil.LogWarning(status);
                        }
                    }
                    break;
                case HTTPRequestStates.Error:
                    {
                    	if (progressHander != null)
			            {
			                progressHander.Dispose();
			            }
                        status = "Request Finished with Error! " + (req.Exception != null ? (req.Exception.Message + "\n" + req.Exception.StackTrace) : "No Exception");
                        if (completeHander != null)
                        {
                            completeHander.call(false, req, resp, status);
                            completeHander.Dispose();
                        }
                        else
                            LogUtil.LogWarning(status);
                    }
                    break;
                case HTTPRequestStates.Aborted:
                    {
                    	if (progressHander != null)
			            {
			                progressHander.Dispose();
			            }
                        status = "Request Aborted!";
                        if (completeHander != null)
                        {
                            completeHander.call(false, req, resp, status);
                            completeHander.Dispose();
                        }
                        else
                            LogUtil.LogWarning(status);

                    }
                    break;
                case HTTPRequestStates.ConnectionTimedOut:
                    {
                    	if (progressHander != null)
			            {
			                progressHander.Dispose();
			            }
                        status = "Connection Timed Out!";
                        if (completeHander != null)
                        {
                            completeHander.call(false, req, resp, status);
                            completeHander.Dispose();
                        }
                        else
                            LogUtil.LogWarning(status);
                    }
                    break;
                case HTTPRequestStates.TimedOut:
                    {
                    	if (progressHander != null)
			            {
			                progressHander.Dispose();
			            }
                        status = "Processing the request Timed Out!";
                        if (completeHander != null)
                        {
                            completeHander.call(false, req, resp, status);
                            completeHander.Dispose();
                        }
                        else
                            LogUtil.LogWarning(status);

                    }
                    break;
            }
        });
        request.OnProgress = (req, downloaded, length) =>
        {
            if (progressHander != null)
            {
                double pg = Math.Round((float)downloaded / (float)length, 2);
                progressHander.call(pg, downloaded,length);
            }
        };

		
        request.UseStreaming = true;
		request.StreamFragmentSize = HTTPResponse.MinBufferSize; //
        request.DisableCache = true; // already saving to a file, so turn off caching
        request.Send();
    }

	public static void UnZip(string zipFileName,string directory,string password = null,LuaFunction handle = null)
	{
		UnZipUtil.XSharpUnZip.UnZipDirectory(zipFileName,directory,password,(entryName,progress,streamSize,entryLength) =>{
			if(handle != null)
				handle.call(entryName,progress,streamSize,entryLength);
		});

		if (handle != null)
			handle.Dispose ();
	}

    
    public static void ReStart(LuaFunction cb)
    {
        EntryPoint.Instance.ReStart(() =>
        {
            cb.call();
            cb.Dispose();
        });
    }

    static IEnumerator _ansy_loadlevel(AsyncOperation asr, System.Action<bool> cb)
    {
        yield return asr;
        if (asr.isDone)
        {
            cb(true);
        }
        else
        {
            cb(false);
        }
    }

    public static void AnsyLoadLevel(string levelName,LuaFunction cb)
    {
        AsyncOperation asr = Application.LoadLevelAsync(levelName);
        EntryPoint.Instance.StartCoroutine(_ansy_loadlevel(asr, (success) =>
        {
            cb.call(success);
            cb.Dispose();
        }));
    }

			public static Dictionary<string,GameObject> Test()
			{
			Dictionary<string,GameObject> a = new Dictionary<string, GameObject> ();
			a ["hello"] = new GameObject("hello");
			a ["hello world"] = new GameObject("hello2");
		return a;
			}

    public static void LuaGC()
    {
		if (!LuaSvr.inited)
            return;

		LuaState luaState = LuaSvr.mainState;
        if (null == luaState)
            return;
        LuaDLL.lua_gc(luaState.L, LuaGCOptions.LUA_GCCOLLECT, 0);
    }

    public static bool IsPointerOverUIObject()
    {
        UnityEngine.EventSystems.PointerEventData eventDataCurrentPosition = new UnityEngine.EventSystems.PointerEventData(UnityEngine.EventSystems.EventSystem.current);
        eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

        List<UnityEngine.EventSystems.RaycastResult> results = new List<UnityEngine.EventSystems.RaycastResult>();
        UnityEngine.EventSystems.EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
        return results.Count > 0;
    }

    /// <summary>
    /// Cast a ray to test if screenPosition is over any UI object in canvas. This is a replacement
    /// for IsPointerOverGameObject() which does not work on Android in 4.6.0f3
    /// </summary>
    public static bool IsPointerOverUIObject(Canvas canvas, Vector2 screenPosition)
    {
        UnityEngine.EventSystems.PointerEventData eventDataCurrentPosition = new UnityEngine.EventSystems.PointerEventData(UnityEngine.EventSystems.EventSystem.current);
        eventDataCurrentPosition.position = screenPosition;

        UnityEngine.UI.GraphicRaycaster uiRaycaster = canvas.gameObject.GetComponent<UnityEngine.UI.GraphicRaycaster>();
        List<UnityEngine.EventSystems.RaycastResult> results = new List<UnityEngine.EventSystems.RaycastResult>();
        uiRaycaster.Raycast(eventDataCurrentPosition, results);
        return results.Count > 0;
    }
}