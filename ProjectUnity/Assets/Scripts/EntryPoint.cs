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
    public static float CurTime;
    public static float DeltaTime;
    FTimerList m_TimerList = new FTimerList();
    FTimerList m_LateTimerList = new FTimerList();
    public int GetGlobalTimerCount() { return m_TimerList.GetEnableCount(); }
    public int GetGlobalLateTimerCount() { return m_LateTimerList.GetEnableCount(); }

    public string EntryLuaScript = string.Empty;
    public LogUtil.LogLevel logLevel = LogUtil.LogLevel.Info;
 
    private LuaSvr lua = null;

    public LuaState LuaState
    {
        get
        {
            if (lua == null || !LuaSvr.inited) return null;
            return LuaSvr.mainState;
        }
    }

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
#if UNITY_WEBGL && !UNITY_EDITOR
            FResourceLoader.Instance.LoadABundleAsync("lua", (AssetBundle ab) => {
                lua.start(EntryLuaScript);
            });
#else
            lua.start(EntryLuaScript);
#endif
        });        
    }
		
    byte[] loadLuaFile(string f)
    {
        string name = f;
        if (name.EndsWith(".lua"))
        {
            name = f.Substring(0, name.Length - (".lua").Length);
        }
        else if (name.EndsWith(".lua.bytes"))
        {
            name = f.Substring(0, name.Length - (".lua.bytes").Length);
        }
        name = name.Replace('.', '/');
        name += ".lua";
#if !UNITY_EDITOR
        name += ".bytes";
#endif
        try
        {
            return FResourceLoader.Instance.ReadFileBytes("lua", name);
        }
        catch(Exception e)
        {
            return null;
        }
    }

    protected override void Awake()
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        LogUtil.Log(string.Format("isRunEnvWX: {0}, {1}", WebCommon.isRunEnvWX(), WebCommon.get_streamingAssetsUrl()));
#endif
        base.Awake();
        //FResourceLoader.Instance.Init();
        RunApp();
    }
#if TEST_EASYSOCKET
    SuperSocket.ClientEngine.FTestSuperSocket testSocket;
#endif
	//FConsole.FSocketServer srv;
    // Use this for initialization
    void Start () 
    {
        FTimerList.RegisterTimerList(m_TimerList, gameObject);
        FTimerList.RegisterTimerList(m_LateTimerList, gameObject);

#if TEST_EASYSOCKET
        testSocket = new SuperSocket.ClientEngine.FTestSuperSocket();
        testSocket.ConnectTo("127.0.0.1", 3001);
#endif

        //srv = new FConsole.FSocketServer ();
        //srv.CreateAndListen ();
    }

    // Update is called once per frame
    void Update () 
    {
        if (!LuaSvr.inited || null == LuaSvr.mainState)
            return;

        CurTime = Time.time;
        DeltaTime = Time.deltaTime;
        m_TimerList.Tick();

        LuaState l = LuaSvr.mainState;
        LuaFunction func = l.getFunction("TickGame");
        if (null != func)
        {
            func.call(Time.deltaTime);
            func.Dispose();
        }
    }

    void LateUpdate()
    {
        if (!LuaSvr.inited || null == LuaSvr.mainState)
            return;
        LuaState l = LuaSvr.mainState;
        LuaFunction func = l.getFunction("LateTickGame");
        if (null != func)
        {
            func.call();
            func.Dispose();
        }
        m_LateTimerList.Tick();
    }

    void Cleanup()
    {
        m_TimerList.Clear();
        m_LateTimerList.Clear();
        LogUtil.DetachUnityLogHandle();
#if !UNITY_EDITOR
        if (null != lua) { lua.Close(); lua = null; }
#endif
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
        try
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
        catch (Exception e) 
        {
            LogUtil.LogException(e);
        }
    }

    void OnApplicationQuit()
    {
        try
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
        catch (Exception e) { }
    }

    public int AddTimer(float ttl, bool bOnce, int cb, int cbparam, bool bLateUpdate)
    {
        if (bLateUpdate)
        {
            return m_LateTimerList.AddTimer(ttl, bOnce, cb, cbparam);
        }
        else
        {
            return m_TimerList.AddTimer(ttl, bOnce, cb, cbparam);
        }
    }

    public void RemoveTimer(int id)
    {
        m_TimerList.RemoveTimer(id);
        m_LateTimerList.RemoveTimer(id);
    }

    public void ResetTimer(int id)
    {
        m_TimerList.ResetTimer(id);
        m_LateTimerList.ResetTimer(id);
    }
}
