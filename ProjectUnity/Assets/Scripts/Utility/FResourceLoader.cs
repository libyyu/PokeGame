using DG.Tweening.Plugins.Core.PathCore;
using SLua;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.Networking;
using UObject = UnityEngine.Object;


public abstract class IAssetLoader
{
    protected string FixAssetPath(string assetPath)
    {
        string outName = assetPath.ToLower();
        if (outName.StartsWith('/')) outName = outName.Substring(1);
        if(!outName.StartsWith("assets/"))
        {
            return "assets/" + outName;
        }
        return assetPath;
    }
    protected IAssetLoader() { }
    public UObject LoadAsset(string bundleName, string assetPath) 
    {
        UObject[] objs = LoadAssetImpl(bundleName, (assetPath != null ? new string[] { assetPath } : null));
        if (objs != null && objs.Length > 0) return objs[0];
        return null;
    }

    public UObject[] LoadAsset(string bundleName, string[] assetsPath)
    {
        return LoadAssetImpl(bundleName, assetsPath);
    }


    protected virtual UObject[] LoadAssetImpl(string bundleName, string[] assetsPath) { return null; }

    public void LoadAssetAsync(string bundleName, string assetPath, Action<UObject> callback) 
    { 
        LoadAssetAsyncImpl(bundleName, (assetPath != null ? new string[] { assetPath } : null), (UObject[] objs)=>
        {
            if (callback != null)
            {
                if (objs != null && objs.Length > 0)
                    callback(objs[0]);
                else
                    callback(null);
            }
        }); 
    }

    public void LoadAssetAsync(string bundleName, string[] assetsPath, Action<UObject[]> callback)
    {
        LoadAssetAsyncImpl(bundleName, assetsPath, callback);
    }

    protected virtual void LoadAssetAsyncImpl(string bundleName, string[] assetsPath, Action<UObject[]> callback) { }

    public virtual void UnloadAssetBundle(string abName, bool isThorough = false) { }

    public byte[] ReadFileBytes(string abName, string filePath) { return ReadFileBytesImpl(abName, filePath); }

    protected virtual byte[] ReadFileBytesImpl(string abName, string filePath) { return null; }


}
#if UNITY_EDITOR
public class UnityEditorResourceLoader : IAssetLoader
{
    private MonoBehaviour mh_;
    public UnityEditorResourceLoader(MonoBehaviour mh)
    {
        mh_ = mh;
    }
    protected override UObject[] LoadAssetImpl(string bundleName, string[] assetsPath) 
    {
        List<UObject> objs = new List<UObject>();
        foreach(string assetPath in assetsPath)
        {
            UObject obj = UnityEditor.AssetDatabase.LoadAssetAtPath(FixAssetPath(assetPath), typeof(UObject));
            objs.Add(obj);
        }
        
        return objs.ToArray();
    }

    protected override void LoadAssetAsyncImpl(string bundleName, string[] assestPath, Action<UObject[]> callback) 
    {
        UObject[] objs = LoadAssetImpl(bundleName, assestPath);
        if (callback != null) callback(objs);
    }

    protected override byte[] ReadFileBytesImpl(string abName, string filePath)
    {
        if (System.IO.Path.IsPathRooted(filePath))
        {
            if (File.Exists(filePath))
            {
                FileStream fs = File.Open(filePath, FileMode.Open);
                long length = fs.Length;
                byte[] bytes = new byte[length];
                fs.Read(bytes, 0, bytes.Length);
                fs.Close();

                return bytes;
            }
            return null;
        }
        string fpath = FixAssetPath(filePath);
        if (System.IO.File.Exists(fpath))
        {
            return System.IO.File.ReadAllBytes(fpath);
        }

        string[] SearchPaths = new string[] { Application.dataPath + "/../../Output" };
        for (int i = 0; i < SearchPaths.Length; ++i)
        {
            fpath = System.IO.Path.Join(SearchPaths[i], abName, filePath);
            if (File.Exists(fpath))
            {
                LogUtil.Log("found : " + fpath);
                FileStream fs = File.Open(fpath, FileMode.Open);
                long length = fs.Length;
                byte[] bytes = new byte[length];
                fs.Read(bytes, 0, bytes.Length);
                fs.Close();

                return bytes;
            }
        }
        return null;
    }
}
#endif

public class UnityAssetBundleLoader : IAssetLoader
{
    private MonoBehaviour mh_;
    public UnityAssetBundleLoader(MonoBehaviour mh)
    {
        mh_ = mh;
    }

    /// <summary>
    /// ������ȡ·��
    /// </summary>
    public string BaseStreamAssetPath
    {
        get
        {
#if UNITY_ANDROID
			return "jar:file://" + Application.dataPath + "!/assets";
#elif UNITY_IPHONE
			return Application.dataPath + "/Raw";
#elif UNITY_WEBGL && !UNITY_EDITOR
            if(WebCommon.isRunEnvWX())
            {
                return WebCommon.get_streamingAssetsUrl();
            }
            return Application.streamingAssetsPath;
#else
            return Application.streamingAssetsPath;
#endif
        }
    }

    /// <summary>
    /// ��Դ��Ÿ�·��
    /// </summary>
    public string AssetRootPath
    {
        get
        {
#if UNITY_ANDROID
			return Application.persistentDataPath + "/assets"; //��Ŀ¼�ж�дȨ��
#elif UNITY_IPHONE
            return Application.temporaryCachePath + "/assets"; //��Ŀ¼�ж�дȨ��
#else
            return Application.dataPath + "/../../Output";
#endif
        }
    }

#if  !UNITY_WEBGL && !UNITY_EDITOR
    /// <summary>
    /// ������Դ���·��
    /// </summary>
    public string PatchesAssetPath
    {
        get
        {
            return AssetRootPath + "/patches";
        }
    }
#endif

#if !UNITY_WEBGL && !UNITY_EDITOR
    /// <summary>
    /// ������Դ���·��
    /// </summary>
    public string PckAssetPath
    {
        get
        {
            return AssetRootPath + "/pck";
        }
    }
#endif

    public string[] SearchPaths
    {
        get
        {
            return new string[] {
#if !UNITY_WEBGL && !UNITY_EDITOR
                PckAssetPath,
#endif
#if  !UNITY_WEBGL && !UNITY_EDITOR
                PatchesAssetPath,
#endif
                AssetRootPath,
                BaseStreamAssetPath,
            };
        }
    }


    class AssetBundleInfo
    {
        public AssetBundle m_AssetBundle;
        public int m_ReferencedCount;

        public AssetBundleInfo(AssetBundle assetBundle)
        {
            m_AssetBundle = assetBundle;
            m_ReferencedCount = 0;
        }
    }
    class LoadAssetRequest
    {
        public Type assetType;
        public string[] assetNames;
        public Action<UObject[]> onAction;
    }

    string[] m_AllManifest = null;
    AssetBundleManifest m_AssetBundleManifest = null;
    Dictionary<string, string[]> m_Dependencies = new Dictionary<string, string[]>();
    Dictionary<string, AssetBundleInfo> m_LoadedAssetBundles = new Dictionary<string, AssetBundleInfo>();
    Dictionary<string, List<LoadAssetRequest>> m_LoadRequests = new Dictionary<string, List<LoadAssetRequest>>();

    string FixABName(string abName)
    {
        string outName = abName.ToLower();
        if (outName.StartsWith('/')) outName = outName.Substring(1);
        if (!outName.StartsWith("assets/")) outName = "assets/" + outName;
        if (!outName.EndsWith(GameUtil.BundleExt)) outName = outName + GameUtil.BundleExt;
        return outName;
    }
    AssetBundleInfo GetLoadedAssetBundle(string abName)
    {
        AssetBundleInfo bundle = null;
        m_LoadedAssetBundles.TryGetValue(abName, out bundle);
        if (bundle == null) return null;

        // No dependencies are recorded, only the bundle itself is required.
        string[] dependencies = null;
        if (!m_Dependencies.TryGetValue(abName, out dependencies))
            return bundle;

        // Make sure all dependencies are loaded
        foreach (var dependency in dependencies)
        {
            AssetBundleInfo dependentBundle;
            m_LoadedAssetBundles.TryGetValue(dependency, out dependentBundle);
            if (dependentBundle == null)
            {
                LogUtil.LogWarning(string.Format("Load Dependency {0}@{1} is Failed.", dependency, abName));
                //return null;
            }
        }
        return bundle;
    }

    public AssetBundle GetLoadedABundle(string abName)
    {
        AssetBundleInfo ab = GetLoadedAssetBundle(abName);
        if (ab == null) return null;

        return ab.m_AssetBundle;
    }

    void Initialize(Action onInitCallback)
    {
        if(m_AssetBundleManifest != null)
        {
            if (onInitCallback != null) onInitCallback();
            return;
        }
        LoadAsset<AssetBundleManifest>(GameUtil.ManifestName, new string[] { "AssetBundleManifest" }, delegate (UObject[] objs) {
            if (objs.Length > 0)
            {
                LogUtil.Log("AssetBundleManifest Load Finished.");
                m_AssetBundleManifest = objs[0] as AssetBundleManifest;
                m_AllManifest = m_AssetBundleManifest.GetAllAssetBundles();
            }
            else
            {
                LogUtil.LogWarning("AssetBundleManifest Load Finished but no AssetBundleManifest.");
            }
            if (onInitCallback != null) onInitCallback();
        });
    }

    void LoadAsset<T>(string abName, string[] assetNames, Action<UObject[]> action = null) where T : UObject
    {
        if (typeof(T) != typeof(AssetBundleManifest))
            abName = FixABName(abName);
        LoadAssetRequest request = new LoadAssetRequest();
        request.assetType = typeof(T);
        request.assetNames = assetNames;
        request.onAction = action;

        List<LoadAssetRequest> requests = null;
        if (!m_LoadRequests.TryGetValue(abName, out requests))
        {
            requests = new List<LoadAssetRequest>();
            requests.Add(request);
            m_LoadRequests.Add(abName, requests);
            mh_.StartCoroutine(OnLoadAsset<T>(abName));
        }
        else
        {
            requests.Add(request);
        }
    }
    IEnumerator OnLoadAsset<T>(string abName) where T : UObject
    {
        AssetBundleInfo bundleInfo = GetLoadedAssetBundle(abName);
        if (bundleInfo == null)
        {
            yield return mh_.StartCoroutine(OnLoadAssetBundle(abName, typeof(T)));

            bundleInfo = GetLoadedAssetBundle(abName);
            if (bundleInfo == null)
            {
                m_LoadRequests.Remove(abName);
                LogUtil.LogWarning("OnLoadAsset Failed --->>> " + abName);
                yield break;
            }
            else
            {
                LogUtil.Log("OnLoadAsset Success --->>> " + abName);
            }
        }

        List<LoadAssetRequest> list = null;
        if (!m_LoadRequests.TryGetValue(abName, out list))
        {
            m_LoadRequests.Remove(abName);
            yield break;
        }

        for (int i = 0; i < list.Count; i++)
        {
            string[] assetNames = list[i].assetNames;
            List<UObject> result = new List<UObject>();

            AssetBundle ab = bundleInfo.m_AssetBundle;
            if (assetNames == null || assetNames.Length == 0)
            {
                result.Add(ab);
            }
            else
            {
                //��������
                if (ab.isStreamedSceneAssetBundle)
                {
                }
                else
                {
                    for (int j = 0; j < assetNames.Length; j++)
                    {
                        string assetPath = assetNames[j];
                        AssetBundleRequest request = ab.LoadAssetAsync(assetPath, list[i].assetType);
                        yield return request;
                        result.Add(request.asset);
                    }
                }
            }

            if (list[i].onAction != null)
            {
                list[i].onAction(result.ToArray());
                list[i].onAction = null;
            }

            bundleInfo.m_ReferencedCount++;
        }
        m_LoadRequests.Remove(abName);
    }

    IEnumerator OnLoadAssetBundleInner(System.Uri uri, string abName, Type type, Action<bool> action)
    {
        LogUtil.Log(string.Format("try load asset {0}", uri.ToString()));
        UnityWebRequest request = UnityWebRequest.Get(uri);
        if (type != typeof(AssetBundleManifest))
        {
            if (m_AssetBundleManifest != null)
            {
                string[] dependencies = m_AssetBundleManifest.GetAllDependencies(abName);
                if (dependencies.Length > 0)
                {
                    if(!m_Dependencies.ContainsKey(abName))
                        m_Dependencies.Add(abName, dependencies);
                    for (int i = 0; i < dependencies.Length; i++)
                    {
                        string depName = dependencies[i];
                        AssetBundleInfo bundleInfo;
                        if (m_LoadedAssetBundles.TryGetValue(depName, out bundleInfo))
                        {
                            bundleInfo.m_ReferencedCount++;
                        }
                        else if (!m_LoadRequests.ContainsKey(depName))
                        {
                            LogUtil.Log(string.Format("try load dep asset {0}", depName));
                            yield return mh_.StartCoroutine(OnLoadAssetBundle(depName, type));
                        }
                    }
                }
            }
        }
        yield return request.SendWebRequest();
        if (request.result == UnityWebRequest.Result.ConnectionError || request.result == UnityWebRequest.Result.ProtocolError)
        {
            LogUtil.LogWarning(request.error);
            if(action != null) action(false);
        }
        else
        {
            LogUtil.Log(string.Format("success load asset {0}", uri.ToString()));
            AssetBundle assetBundle = AssetBundle.LoadFromMemory(request.downloadHandler.data);
            if (assetBundle != null)
            {
                m_LoadedAssetBundles.Add(abName, new AssetBundleInfo(assetBundle));
            }

            if (action != null) action(true);
        }
    }

    IEnumerator OnLoadAssetBundle(string abName, Type type)
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        var streamingAssetsUrl = Application.streamingAssetsPath;
        if(WebCommon.isRunEnvWX())
            streamingAssetsUrl = WebCommon.get_streamingAssetsUrl();
        var uri = new System.Uri(streamingAssetsUrl + "/" + abName);
        yield return OnLoadAssetBundleInner(uri, abName, type, null);
#else
        bool bLoaded = false;
        for(int i=0; i< SearchPaths.Length && !bLoaded; ++i)
        {
            string assetRPath = SearchPaths[i];
            var uri = new System.Uri(assetRPath + "/" + GameUtil.ManifestName + "/" + abName);
            yield return OnLoadAssetBundleInner(uri, abName, type, (bool succeed) => 
            {
                if (succeed) bLoaded = true;
            });

            if (bLoaded) break;
        }
#endif
    }


    protected override UObject[] LoadAssetImpl(string bundleNamem, string[] assetsPath)
    {
        return null;
    }

    protected override void LoadAssetAsyncImpl(string bundleName, string[] assetsPath, Action<UObject[]> callback)
    {
        Initialize(() =>
        {
            List<string> fixedAssetsPath = new List<string>();
            foreach (var assetPath in assetsPath)
            {
                fixedAssetsPath.Add(FixAssetPath(assetPath));
            }
            LoadAsset<UObject>(bundleName, fixedAssetsPath.ToArray(), (UObject[] objs) =>
            {
                if (callback != null) callback(objs);
            });
        });
    }

    /// <summary>
    /// �˺��������ⲿж��ר�ã��Լ������Ƿ���Ҫ�������AB
    /// </summary>
    /// <param name="abName"></param>
    /// <param name="isThorough"></param>
    public override void UnloadAssetBundle(string abName, bool isThorough = false)
    {
        abName = FixABName(abName);
        LogUtil.Log(m_LoadedAssetBundles.Count + " assetbundle(s) in memory before unloading " + abName);
        UnloadAssetBundleInternal(abName, isThorough);
        UnloadDependencies(abName, isThorough);
        LogUtil.Log(m_LoadedAssetBundles.Count + " assetbundle(s) in memory after unloading " + abName);
    }

    void UnloadDependencies(string abName, bool isThorough)
    {
        string[] dependencies = null;
        if (!m_Dependencies.TryGetValue(abName, out dependencies))
            return;

        // Loop dependencies.
        foreach (var dependency in dependencies)
        {
            UnloadAssetBundleInternal(dependency, isThorough);
        }
        m_Dependencies.Remove(abName);
    }

    void UnloadAssetBundleInternal(string abName, bool isThorough)
    {
        AssetBundleInfo bundle = GetLoadedAssetBundle(abName);
        if (bundle == null) return;

        if (--bundle.m_ReferencedCount <= 0)
        {
            if (m_LoadRequests.ContainsKey(abName))
            {
                return;     //�����ǰAB����Async Loading�����У�ж�ػ������ֻ��ȥ���ü�������
            }
            bundle.m_AssetBundle.Unload(isThorough);
            m_LoadedAssetBundles.Remove(abName);
            LogUtil.Log(abName + " has been unloaded successfully");
        }
    }

    public void UnloadAll()
    {
        foreach(var m in m_LoadedAssetBundles)
        {
            UnloadAssetBundle(m.Key, true);
        }
    }

    protected override byte[] ReadFileBytesImpl(string abName, string filePath)
    {
        if (System.IO.Path.IsPathRooted(filePath))
        {
            if (File.Exists(filePath))
            {
                FileStream fs = File.Open(filePath, FileMode.Open);
                long length = fs.Length;
                byte[] bytes = new byte[length];
                fs.Read(bytes, 0, bytes.Length);
                fs.Close();

                return bytes;
            }
            return null;
        }
#if UNITY_WEBGL && !UNITY_EDITOR
        string realABPath = FixABName(abName);
        string realAssetPath = FixAssetPath(abName + "/" + filePath);
        var ab = GetLoadedABundle(realABPath);
        if(ab == null) LogUtil.Log("ab not loaded:" + realABPath);
        TextAsset textCode = ab != null ? ab.LoadAsset<TextAsset>(realAssetPath) : null;
        if (textCode != null)
        {
            byte[] buffer = textCode.bytes;
            Resources.UnloadAsset(textCode);
            return buffer;
        }
        else
        {
           LogUtil.Log("TextAsset not loaded:" + realAssetPath);
        }
#else
        for (int i = 0; i < SearchPaths.Length; ++i)
        {
            string fpath = System.IO.Path.Join(SearchPaths[i], abName, filePath);
            if (File.Exists(fpath))
            {
                LogUtil.Log("found : " + fpath);
                FileStream fs = File.Open(fpath, FileMode.Open);
                long length = fs.Length;
                byte[] bytes = new byte[length];
                fs.Read(bytes, 0, bytes.Length);
                fs.Close();

                return bytes;
            }
        }

        var ab = GetLoadedABundle(FixABName(abName));
        TextAsset textCode = ab != null ? ab.LoadAsset<TextAsset>(FixAssetPath(filePath)) : null;
        if (textCode != null)
        {
            byte[] buffer = textCode.bytes;
            Resources.UnloadAsset(textCode);
            return buffer;
        }
#endif

        return null;
    }
}

[CustomLuaClass]
public class FResourceLoader : PersistentSingleton<FResourceLoader>
{

    IAssetLoader loader = null;
    protected override void Awake()
    {
        base.Awake();
#if UNITY_EDITOR
        loader = new UnityEditorResourceLoader(this);
#else
        loader = new UnityAssetBundleLoader(this);
#endif
    }

    public UObject LoadAsset(string bundleName, string assetPath) 
    {
        return loader.LoadAsset(bundleName, assetPath);
    }

    public void LoadAssetAsync(string bundleName, string assetPath, LuaFunction func) 
    {
        loader.LoadAssetAsync(bundleName, assetPath, (UObject obj)=> 
        {
            func.call(obj);
            func.Dispose();
        });
    }

    public void LoadAssetArrayAsync(string bundleName, string[] assetsPath, LuaFunction func)
    {
        loader.LoadAssetAsync(bundleName, assetsPath, (UObject[] objs) =>
        {
            func.call(objs);
            func.Dispose();
        });
    }

    public void LoadABundleAsync(string bundleName, LuaFunction func)
    {
        LoadABundleAsync(bundleName, (AssetBundle ab) =>
        {
            func.call(ab);
            func.Dispose();
        });
    }

    [DoNotToLua]
    public void LoadABundleAsync(string bundleName, Action<AssetBundle> func)
    {
        loader.LoadAssetAsync(bundleName, null, (UObject obj) =>
        {
            if (func != null)
            {
                AssetBundle ab = obj != null ? obj as AssetBundle : null;
                func(ab);
            }
        });
    }
    public void UnloadAssetBundle(string abName, bool isThorough = false)
    {
        loader.UnloadAssetBundle(abName, isThorough);
    }

    public byte[] ReadFileBytes(string abName, string filePath)
    {
        return loader.ReadFileBytes(abName, filePath);
    }
}