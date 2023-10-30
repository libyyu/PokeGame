using SLua;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;
using static System.Collections.Specialized.BitVector32;

[CustomLuaClass]
public class GameUtil
{
    public const string BundleExt = ".ab";
    public const string ManifestName = "StreamingAssets";

    //当前是否运行在微信小游戏环境
    public static bool IsWXEnv()
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        return WebCommon.isRunEnvWX();
#else
        return false;
#endif
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
        Directory.CreateDirectory(System.IO.Path.GetDirectoryName(filepath));
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
                string ext = System.IO.Path.GetExtension(filename);
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
        UnityWebRequest request = UnityWebRequest.Get(new System.Uri(path));
        yield return request.SendWebRequest();
        if (request.result == UnityWebRequest.Result.ConnectionError || request.result == UnityWebRequest.Result.ProtocolError)
        {
            cb(false, request.error);
        }
        else
        {
            cb(true, request.downloadHandler.data);
        }
    }
	
	//异步读取文件，比如Android包文件
    public static void AnsyOpenFile(string filePath, LuaFunction cb)
    {
        EntryPoint.Instance.StartCoroutine(_ansy_open_file_(filePath, (success, o) =>
        {
            cb.call(success, o);
            cb.Dispose();
        }));
    }
		
	public static bool IsAssetFileExists(string filePath)
	{
        var url = new System.Uri(filePath);
        if (File.Exists(url.ToString()))
            return true;
        try
        {
            UnityWebRequest request = UnityWebRequest.Head(url);
            request.SendWebRequest();
            while (!request.isDone) { }
            if (request.result == UnityWebRequest.Result.ConnectionError || request.result == UnityWebRequest.Result.ProtocolError)
                return false;

            return request.responseCode == 200;
        }
        catch (System.Exception ex)
        {
            return false;
        }
    }

    public static byte[] ReadAssetFile(string filePath)
    {
        try
        {
            byte[] ret = null;
            _ansy_open_file_(filePath, (bool success, object data) =>
            {
                if (success) ret = data as byte[];
            });

            return ret;
        }
        catch (System.Exception)
        {
            return null;
        }
    }

	

    //发送HTTP请求
    public static void SendRequest(string url, string data, double t, bool bGet, LuaFunction completeHandler)
    {
        var request = new BestHTTP.HTTPRequest(new Uri(url), bGet ? BestHTTP.HTTPMethods.Get : BestHTTP.HTTPMethods.Post, (req, resp) =>
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
		
        var request = new BestHTTP.HTTPRequest(new Uri(SrcFilePath), bGet ? BestHTTP.HTTPMethods.Get : BestHTTP.HTTPMethods.Post, keepAlive, (req, resp) =>
        {
            List<byte[]> fragments = null;
            string status = "";
            switch (req.State)
            {
                case BestHTTP.HTTPRequestStates.Processing:
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
                case BestHTTP.HTTPRequestStates.Finished:
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
                case BestHTTP.HTTPRequestStates.Error:
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
                case BestHTTP.HTTPRequestStates.Aborted:
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
                case BestHTTP.HTTPRequestStates.ConnectionTimedOut:
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
                case BestHTTP.HTTPRequestStates.TimedOut:
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
		request.StreamFragmentSize = BestHTTP.HTTPResponse.MinBufferSize; //
        request.DisableCache = true; // already saving to a file, so turn off caching
        request.Send();
    }

	public static void UnZip(string zipFileName,string directory,string password = null,LuaFunction handle = null)
	{
		XSharpUnZip.UnZipDirectory(zipFileName,directory,password,(entryName,progress,streamSize,entryLength) =>{
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

	public static Dictionary<string,GameObject> TestSLua()
	{
		Dictionary<string,GameObject> a = new Dictionary<string, GameObject> ();
		a["hello"] = new GameObject("hello");
		a["hello world"] = new GameObject("hello2");
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