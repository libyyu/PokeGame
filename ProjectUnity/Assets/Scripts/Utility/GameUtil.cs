using SLua;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

[CustomLuaClass]
public static class GameUtil
{
    public const string BundleExt = ".ab";  
    public static string ManifestName
    {
        get
        {
#if UNITY_WEBGL && !UNITY_EDITOR
            return WebCommon.get_AssetBundleManifestName();
#else
            return "StreamingAssets";
#endif
        }
    }

    static Dictionary<string, string> AssetToBundleName = new Dictionary<string, string>();
    static LuaFunction AssetToBundleNameFunc = null;

    public static string FixAssetPath(string assetPath)
    {
        if (assetPath.Length == 0) return "";
        string outName = assetPath.ToLower();
        if (outName.StartsWith('/')) outName = outName.Substring(1);
        if (!outName.StartsWith("assets/"))
        {
            return "assets/" + outName;
        }
        return assetPath;
    }

    public static string FixABName(string abName)
    {
        string outName = abName.ToLower();
        if (outName.StartsWith('/')) outName = outName.Substring(1);
        if (!outName.StartsWith("assets/")) outName = "assets/" + outName;
        if (!outName.EndsWith(BundleExt)) outName = outName + BundleExt;
        return outName;
    }

    public static string GetBundleNameByAssetName(string assetName)
    {
        assetName = FixAssetPath(assetName);
        string abName;
        if (AssetToBundleName.TryGetValue(assetName, out abName)) return abName;

        try
        {
            if (!LuaSvr.inited || null == LuaSvr.mainState)
                return null;
            LuaState l = LuaSvr.mainState;
            if(AssetToBundleNameFunc == null)
                AssetToBundleNameFunc = l.getFunction("TransformABName");
            if (null != AssetToBundleNameFunc)
            {
                abName = (string)AssetToBundleNameFunc.call(assetName);

                if(!string.IsNullOrEmpty(abName))
                {
                    AssetToBundleName.Add(assetName, abName);
                }
            }

            return abName;
        }
        catch
        {
        }

        return null;
    }

    public static bool IsEditorEnv()
    {
#if UNITY_EDITOR
        return true;
#else
        return false;
#endif
    }

    //当前是否运行在微信小游戏环境
    public static bool IsWXEnv()
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        return WebCommon.isRunEnvWX();
#else
        return false;
#endif
    }

    public static bool IsWebGLEnv()
    {
#if UNITY_WEBGL
        return true;
#else
        return false;
#endif
    }

    public static string GetStreamingAssetsUrl()
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        return WebCommon.get_streamingAssetsUrl();
#else
        return Application.streamingAssetsPath;
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
#if !UNITY_WEBGL || UNITY_EDITOR
        try
        {
            return LuaDLLNativeRuntime.FileExists(filePath);
        }
        catch (System.Exception)
        {
            return false;
        }
#else
        return File.Exists(filePath);
#endif
    }

    public static byte[] ReadAssetFile(string filePath)
    {
        try
        {
#if !UNITY_WEBGL || UNITY_EDITOR
            byte[] ret = LuaDLLNativeRuntime.ReadFileAllBytes(filePath);
#else
            byte[] ret =File.ReadAllBytes(filePath);
#endif
            //_ansy_open_file_(filePath, (bool success, object data) =>
            //{
            //    if (success) ret = data as byte[];
            //});

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
        if (data != null)
            request.RawData = Encoding.UTF8.GetBytes(data);
        request.UseStreaming = false;
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

    [MonoPInvokeCallback(typeof(LuaCSFunction))]
    [StaticExport]
    [UnityEngine.Scripting.Preserve]
    public static int AddGlobalTimer(IntPtr L)
    {
        float ttl = (float)LuaDLL.lua_tonumber(L, 1);
        bool bOnce = LuaDLL.lua_toboolean(L, 2);

        LuaDLL.lua_pushvalue(L, 3);
        int callbackRef = LuaDLL.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);

        int cbparam;
        if (!LuaDLL.lua_isnil(L, 4))
        {
            LuaDLL.lua_pushvalue(L, 4);
            cbparam = LuaDLL.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
        }
        else
            cbparam = LuaRefValue.LUA_NOREF;

        int id = EntryPoint.Instance.AddTimer(ttl, bOnce, callbackRef, cbparam, false);
        LuaDLL.lua_pushboolean(L, true);
        LuaDLL.lua_pushinteger(L, id);
        return 2;
    }

    [MonoPInvokeCallback(typeof(LuaCSFunction))]
    [StaticExport]
    [UnityEngine.Scripting.Preserve]
    public static int RemoveTimer(IntPtr L)
    {
        int id = LuaDLL.lua_tointeger(L, 1);
        EntryPoint.Instance.RemoveTimer(id);
        LuaDLL.lua_pushboolean(L, true);
        return 1;
    }

    [MonoPInvokeCallback(typeof(LuaCSFunction))]
    [StaticExport]
    [UnityEngine.Scripting.Preserve]
    public static int AddLateTimer(IntPtr L)
    {
        float ttl = (float)LuaDLL.lua_tonumber(L, 1);
        bool bOnce = LuaDLL.lua_toboolean(L, 2);

        LuaDLL.lua_pushvalue(L, 3);
        int callbackRef = LuaDLL.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);

        int cbparam;
        if (!LuaDLL.lua_isnil(L, 4))
        {
            LuaDLL.lua_pushvalue(L, 4);
            cbparam = LuaDLL.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
        }
        else
            cbparam = LuaRefValue.LUA_NOREF;

        int id = EntryPoint.Instance.AddTimer(ttl, bOnce, callbackRef, cbparam, true);
        LuaDLL.lua_pushboolean(L, true);
        LuaDLL.lua_pushinteger(L, id);
        return 2;
    }

    [MonoPInvokeCallback(typeof(LuaCSFunction))]
    [StaticExport]
    [UnityEngine.Scripting.Preserve]
    public static int AddObjectTimer(IntPtr L)
    {
        UnityEngine.GameObject self = (UnityEngine.GameObject)LuaObject.checkSelf(L);
        if(self == null)
        {
            LuaDLL.lua_pushboolean(L, false);
            LuaDLL.lua_pushstring(L, "can't not BindObject Timer to destroyed object");
            return 2;
        }
        FTimerListBehavior comp = self.GetComponent<FTimerListBehavior>();
        if(comp == null) comp = self.AddComponent<FTimerListBehavior>();

        float ttl = (float)LuaDLL.lua_tonumber(L, 2);
        bool bOnce = LuaDLL.lua_toboolean(L, 3);

        LuaDLL.lua_pushvalue(L, 4);
        int callbackRef = LuaDLL.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);

        int cbparam;
        if (!LuaDLL.lua_isnil(L, 5))
        {
            LuaDLL.lua_pushvalue(L, 5);
            cbparam = LuaDLL.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
        }
        else
            cbparam = LuaRefValue.LUA_NOREF;

        int id = comp.AddTimer(ttl, bOnce, callbackRef, cbparam, false);
        LuaDLL.lua_pushboolean(L, true);
        LuaDLL.lua_pushinteger(L, id);
        return 2;
    }

    [MonoPInvokeCallback(typeof(LuaCSFunction))]
    [StaticExport]
    [UnityEngine.Scripting.Preserve]
    public static int AddObjectLateTimer(IntPtr L)
    {
        UnityEngine.GameObject self = (UnityEngine.GameObject)LuaObject.checkSelf(L);
        if (self == null)
        {
            LuaDLL.lua_pushboolean(L, false);
            LuaDLL.lua_pushstring(L, "can't not BindObject Timer to destroyed object");
            return 2;
        }
        FTimerListBehavior comp = self.GetComponent<FTimerListBehavior>();
        if (comp == null) comp = self.AddComponent<FTimerListBehavior>();

        float ttl = (float)LuaDLL.lua_tonumber(L, 2);
        bool bOnce = LuaDLL.lua_toboolean(L, 3);

        LuaDLL.lua_pushvalue(L, 4);
        int callbackRef = LuaDLL.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);

        int cbparam;
        if (!LuaDLL.lua_isnil(L, 5))
        {
            LuaDLL.lua_pushvalue(L, 5);
            cbparam = LuaDLL.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
        }
        else
            cbparam = LuaRefValue.LUA_NOREF;

        int id = comp.AddTimer(ttl, bOnce, callbackRef, cbparam, true);
        LuaDLL.lua_pushboolean(L, true);
        LuaDLL.lua_pushinteger(L, id);
        return 2;
    }

    [MonoPInvokeCallback(typeof(LuaCSFunction))]
    [StaticExport]
    [UnityEngine.Scripting.Preserve]
    public static int RemoveObjectTimer(IntPtr L)
    {
        UnityEngine.GameObject self = (UnityEngine.GameObject)LuaObject.checkSelf(L);
        if (self == null)
        {
            LuaDLL.lua_pushboolean(L, false);
            LuaDLL.lua_pushstring(L, "can't not RemoveObjectTimer Timer from destroyed object");
            return 2;
        }
        FTimerListBehavior comp = self.GetComponent<FTimerListBehavior>();
        if(comp == null)
        {
            LuaDLL.lua_pushboolean(L, true);
            return 1;
        }

        int id = LuaDLL.lua_tointeger(L, 2);
        comp.RemoveTimer(id);
        LuaDLL.lua_pushboolean(L, true);
        return 1;
    }

    static IEnumerator _GetTexture(string url, Action<Texture2D> actionResult)
    {

        UnityWebRequest uwr = new UnityWebRequest(url);
        DownloadHandlerTexture downloadTexture = new DownloadHandlerTexture(true);
        uwr.downloadHandler = downloadTexture;

        yield return uwr.SendWebRequest();
        Texture2D t = null;
        if (uwr.result == UnityWebRequest.Result.Success)
        {
            t = downloadTexture.texture;
        }
        else
        {
            LogUtil.LogWarning("下载失败，请检查网络，或者下载地址是否正确 ", url);
        }

        if (actionResult != null)
        {
            actionResult(t);
        }
    }

    public static Texture2D LoadTexture2DFromFile(string path)
    {
        try
        {
            if (!File.Exists(path)) return null;

            // 创建一个Texture2D
            Texture2D texture = new Texture2D(1, 1);

            // 加载图片数据
            byte[] imageData = File.ReadAllBytes(path);

            // 将图片数据加载到Texture2D对象中
            texture.LoadImage(imageData);

            return texture;
        }
        catch(Exception e)
        {
            LogUtil.LogException(e);
            return null;
        }
    }

    static bool IsInsideRoundedCorner(int x, int y, int width, int height, float radius)
    {
        // 四个角的坐标
        Vector2 bottomLeft = new Vector2(radius, radius);
        Vector2 bottomRight = new Vector2(width - radius, radius);
        Vector2 topLeft = new Vector2(radius, height - radius);
        Vector2 topRight = new Vector2(width - radius, height - radius);

        // 检查每个角
        if (Vector2.Distance(new Vector2(x, y), bottomLeft) < radius) return true;
        if (Vector2.Distance(new Vector2(x, y), bottomRight) < radius) return true;
        if (Vector2.Distance(new Vector2(x, y), topLeft) < radius) return true;
        if (Vector2.Distance(new Vector2(x, y), topRight) < radius) return true;

        // 检查中心区域
        if (x > radius && x < width - radius && y > radius && y < height - radius) return true;

        return false;
    }

    public static Texture2D CreateRoundedTexture(Texture2D source, float radius)
    {
        int width = source.width;
        int height = source.height;
        Texture2D roundedTexture = new Texture2D(width, height);

        // 遍历每个像素，设置圆角效果
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Color originalColor = source.GetPixel(x, y);

                // 计算圆角
                if (IsInsideRoundedCorner(x, y, width, height, radius))
                {
                    roundedTexture.SetPixel(x, y, originalColor);
                }
                else
                {
                    roundedTexture.SetPixel(x, y, Color.clear);
                }
            }
        }

        roundedTexture.Apply();
        return roundedTexture;
    }

    public static void AsyncLoadTextureFromPathOrUrl(string url, LuaFunction cb)
    {
        EntryPoint.Instance.StartCoroutine(_GetTexture(url, (tex) =>
        {
            cb.call(tex);
            cb.Dispose();
        }));
    }

    public static bool SaveTextureToFile(Texture2D tex, string path)
    {
        try
        {
            CreateDirectoryForFile(path);
            Byte[] bytes = tex.EncodeToPNG();
            File.WriteAllBytes(path, bytes);
            return true;
        }
        catch (Exception e)
        {
            LogUtil.LogException(e);
            return false;
        }
    }

    public static bool SaveBytesToFile(Byte[] bytes, string path)
    {
        try
        {
            CreateDirectoryForFile(path);
            File.WriteAllBytes(path, bytes);
            return true;
        }
        catch (Exception e)
        {
            LogUtil.LogException(e);
            return false;
        }
    }

    public static bool SaveTextToFile(string text, string path)
    {
        try
        {
            CreateDirectoryForFile(path);
            File.WriteAllText(path, text);
            return true;
        }
        catch (Exception e)
        {
            LogUtil.LogException(e);
            return false;
        }
    }

    public static string ToBase64String(string originalText)
    {
        string base64Encoded = Convert.ToBase64String(Encoding.UTF8.GetBytes(originalText));
        return base64Encoded;
    }

    public static string FromBase64String(string base64Encoded)
    {
        string originalText = Encoding.UTF8.GetString(Convert.FromBase64String(base64Encoded));
        return originalText;
    }

    public static Byte[] Utf8ToUnicode(string str)
    {
        return Encoding.Unicode.GetBytes(str);
    }

    public static string UnicodeToUtf8(Byte[] bytes)
    {
        return Encoding.Unicode.GetString(bytes);
    }

    public static string CalculateMD5Hash(string input)
    {
        // 创建一个 MD5 实例
        using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
        {
            // 将输入字符串转换为字节数组
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            // 计算字节数组的 MD5 哈希值
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // 将字节数组转换为十六进制字符串
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }

            // 返回十六进制字符串
            return sb.ToString();
        }
    }

    public static string CalculateSHA256Hash(string input)
    {
        // 创建一个 SHA256 实例
        using (System.Security.Cryptography.SHA256 sha256 = System.Security.Cryptography.SHA256.Create())
        {
            // 将输入字符串转换为字节数组
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            // 计算字节数组的 SHA-256 哈希值
            byte[] hashBytes = sha256.ComputeHash(inputBytes);

            // 将字节数组转换为十六进制字符串
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }

            // 返回十六进制字符串
            return sb.ToString();
        }
    }

    public static void AsyncLoadScene(string sceneName, Action<float> loadPro = null)
    {
        EntryPoint.Instance.StartCoroutine(DoLoad(sceneName, loadPro));
    }

    static IEnumerator DoLoad(string sceneName, Action<float> loadPro)
    {
#if UNITY_5_3_OR_NEWER
        AsyncOperation op = SceneManager.LoadSceneAsync(sceneName);
#else
        AsyncOperation op = Application.LoadLevelAsync(sceneName);
#endif
        float startTime = Time.time;
        while (!op.isDone)
        {
            float value = ((Time.time - startTime) * 100f / 3f);
            if (value > 100.0f)
                value = 100.0f;
            if (loadPro != null) loadPro(value);
            yield return null;
        }
    }

    public static string CallNativeMethod(string method, string jsonParams)
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        return WebCommon.callJSMethod(method, jsonParams);
#else
        return null;
#endif

    }
}