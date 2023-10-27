using UnityEngine;
using System.Collections;
using SLua;
using System.IO;
using FGame;
using System;
using System.Collections.Generic;
using UnityEngine.Networking;

public class EntryPoint : PersistentSingleton<EntryPoint>
{
    public string EntryLuaScript = string.Empty;
    public LogUtil.LogLevel logLevel = LogUtil.LogLevel.Info;
 
    private LuaSvr lua = null;

    IEnumerator onReStart(Action cb)
    {
        yield return new WaitForEndOfFrame();
        if (null != cb)
            cb();
        yield return new WaitForEndOfFrame();
        Cleanup();
        yield return new WaitForEndOfFrame();
        if (null != lua)
        { lua.Close(); lua = null; }
        yield return new WaitForEndOfFrame();
        DG.Tweening.DOTween.KillAll(true);
        DG.Tweening.DOTween.ClearCachedTweens();
        DG.Tweening.DOTween.Clear(true);
        yield return new WaitForEndOfFrame();
        GameObject[] allObj = Transform.FindObjectsOfType<GameObject>();
        for (int i=0;i<allObj.Length;++i)
        {
            if(allObj[i] != gameObject)
            {
                GameObject.Destroy(allObj[i]);
            }
        }
        yield return new WaitForEndOfFrame();
        RunApp();
    }

    public void ReStart(Action cb)
    {
        StartCoroutine(onReStart(cb));
    }

    void RunApp()
    {
        SetupEnvironment();
		SetupPath();
        SetupLua();
    }

    void SetupEnvironment()
    {
        LogUtil.loglevel = logLevel;
        LogUtil.AttachUnityLogHandle();
        LogFile.Instance.Init();        
    }

    void SetupPath()
    {
        LogUtil.Log("streamingAssetsPath:" + Application.streamingAssetsPath);
        LogUtil.Log("dataPath:" + Application.dataPath);
		LogUtil.Log("resBasePath:" + GameUtil.BaseStreamAssetPath);
        LogUtil.Log("AssetRoot:" + GameUtil.AssetRoot);
        LogUtil.Log("AssetsPath:" + GameUtil.AssetPath);
        LogUtil.Log("LuaPath:" + GameUtil.LuaPath);
        LogUtil.Log("PckPath:" + GameUtil.SepPath);
		LogUtil.Log("TempPath:" + Application.temporaryCachePath);
    }

    void SetupLua()
    {
        lua = new LuaSvr();
		lua.SetLoader (loadLuaFile);
        lua.init(null, () =>
        {
            if (string.IsNullOrEmpty(EntryLuaScript))
                return;

            ResourceManager.Instance.LoadBundle("lua", (AssetBundle ab) => {
                lua.start(EntryLuaScript);
            });
        });        
    }
		
    byte[] loadLuaFile(string f)
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        string name = f;
        if (name.EndsWith(".lua"))
        {
            int index = f.LastIndexOf('.');
            name = f.Substring(0, index);
        }
        name = name.Replace('.', '/');
        name += ".lua";
        
        string bundlename = ResourceManager.Instance.FixABName("lua");
        AssetBundleInfo abInfo = ResourceManager.Instance.GetLoadedAssetBundle(bundlename);
        if (abInfo == null || abInfo.m_AssetBundle == null) {
            LogUtil.LogWarning(string.Format("bundle '{0}' not found.", bundlename));
            return null;
        }

//#if UNITY_4_6 || UNITY_4_7
//        TextAsset luaCode = abInfo.m_AssetBundle.Load(name, typeof(TextAsset)) as TextAsset;
//#else
        TextAsset luaCode = abInfo.m_AssetBundle.LoadAsset<TextAsset>("Assets/Lua/" + name + ".bytes");
//#endif

        if (luaCode != null)
        {
            byte[] buffer = luaCode.bytes;
            Resources.UnloadAsset(luaCode);
            return buffer;
        }
        else
        {
            LogUtil.LogWarning(string.Format("lua file '{0}' not found.", "Assets/Lua/" + name));
        }

        return null;
#else
        string luafilepath = GameUtil.MakePathForLua(f);
        try
        {
            return GameUtil.ReadAssetFile(luafilepath);
        }
        catch (Exception)
        {
            return null;
        }
#endif
    }

    protected override void Awake()
    {
        base.Awake();
        RunApp();
    }
#if TEST_EASYSOCKET
    SuperSocket.ClientEngine.FTestSuperSocket testSocket;
#endif
	//FConsole.FSocketServer srv;
    // Use this for initialization
    void Start () {
#if TEST_EASYSOCKET
        testSocket = new SuperSocket.ClientEngine.FTestSuperSocket();
        testSocket.ConnectTo("127.0.0.1", 3001);
#endif

		//srv = new FConsole.FSocketServer ();
		//srv.CreateAndListen ();
    }

    // Update is called once per frame
    void Update () {
		
	}

    void Cleanup()
    {
        LogUtil.DetachUnityLogHandle();
        LogFile.Instance.UnInit();
    }

    protected override void OnDestroy()
    {
		//srv.Close ();
        Cleanup();
        base.OnDestroy();
    }

    void OnApplicationPause()
    {
		if (!LuaSvr.inited || null == LuaSvr.mainState)
            return;
		LuaState l = LuaSvr.mainState;
        LuaFunction func = l.getFunction("OnApplicationPause");
        if (null != func)
        {
            func.call();
            func.Dispose();
        }
        else
        {
            //LogUtil.Log("OnApplicationPause");
        }
    }

    void OnApplicationQuit()
    {
		if (!LuaSvr.inited || null == LuaSvr.mainState)
			return;
		LuaState l = LuaSvr.mainState;
        LuaFunction func = l.getFunction("OnApplicationQuit");
        if (null != func)
        {
            func.call();
            func.Dispose();
        }
        else
        {
            //LogUtil.Log("OnApplicationQuit");
        }
    }

    void InitLuaBundle(Action onComplete)
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        StartCoroutine(_AddBundle("lua/lua.unity3d", onComplete));
#endif
    }

    IEnumerator _AddBundle(string bundleName, Action onComplete)
    {
        yield return 0;
        var uri = new System.Uri(Path.Combine(Application.streamingAssetsPath, bundleName));
        UnityWebRequest request = UnityWebRequest.Get(uri);
        yield return request.SendWebRequest();
        if (request.result == UnityWebRequest.Result.ConnectionError || request.result == UnityWebRequest.Result.ProtocolError)
        {
            LogUtil.LogError(request.error);
        }
        else
        {
            AssetBundle ab = AssetBundle.LoadFromMemory(request.downloadHandler.data);
            //loader.AddBundle(bundleName, ab);
        }

        onComplete.Invoke();
    }
}
