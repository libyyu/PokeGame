using SLua;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
    /// 基础读取路径
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
    /// 资源存放根路径
    /// </summary>
    public string AssetRootPath
    {
        get
        {
#if UNITY_ANDROID
			return Application.persistentDataPath + "/assets"; //该目录有读写权限
#elif UNITY_IPHONE
            return Application.temporaryCachePath + "/assets"; //该目录有读写权限
#else
            return Application.dataPath + "/../../Output";
#endif
        }
    }

#if  !UNITY_WEBGL && !UNITY_EDITOR
    /// <summary>
    /// 下载资源存放路径
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
    /// 调试资源存放路径
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

    public string AssetBundleManifestName
    {
        get
        {
#if UNITY_WEBGL && !UNITY_EDITOR
            return WebCommon.get_AssetBundleManifestName();
#else
            return GameUtil.ManifestName;
#endif
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
#if UNITY_WEBGL && !UNITY_EDITOR
    Dictionary<string, string> m_BundleNameToHashBundleName = new Dictionary<string, string>();
    Dictionary<string, string> m_HashBundleNameToBundleName = new Dictionary<string, string>();
#endif

    string FixABName(string abName)
    {
        string outName = abName.ToLower();
        if (outName.StartsWith('/')) outName = outName.Substring(1);
        if (!outName.StartsWith("assets/")) outName = "assets/" + outName;
        if (!outName.EndsWith(GameUtil.BundleExt)) outName = outName + GameUtil.BundleExt;
        return outName;
    }

#if UNITY_WEBGL && !UNITY_EDITOR
    string TransformABNameToHashABName(string abFullName)
    {
 
        if(abFullName.EndsWith(GameUtil.BundleExt))
        {
            string hashABName;
            string noHashABName;
            if (m_BundleNameToHashBundleName.TryGetValue(abFullName, out hashABName) && m_HashBundleNameToBundleName.TryGetValue(hashABName, out noHashABName) && noHashABName == abFullName)
            {
                return hashABName;
            }
        }
        return abFullName;
    }

    string TransformHashABNameToABName(string abHashedFullName)
    {
        if (abHashedFullName.EndsWith(GameUtil.BundleExt))
        {
            string hashABName;
            string noHashABName;
            if (m_HashBundleNameToBundleName.TryGetValue(abHashedFullName, out noHashABName) && m_BundleNameToHashBundleName.TryGetValue(noHashABName, out hashABName) && hashABName == abHashedFullName)
            {
                return noHashABName;
            }
        }
        return abHashedFullName;
    }
#endif

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

        LogUtil.Log(string.Format("AssetBundleManifestName:{0}", AssetBundleManifestName));
        LoadAsset<AssetBundleManifest>(AssetBundleManifestName, new string[] { "AssetBundleManifest" }, delegate (UObject[] objs) {
            if (objs.Length > 0)
            {
                LogUtil.Log("AssetBundleManifest Load Finished.");
                m_AssetBundleManifest = objs[0] as AssetBundleManifest;
                m_AllManifest = m_AssetBundleManifest.GetAllAssetBundles();
                m_Dependencies.Clear();
#if UNITY_WEBGL && !UNITY_EDITOR
                m_BundleNameToHashBundleName.Clear();
                m_HashBundleNameToBundleName.Clear();
                foreach (var bundleName in m_AllManifest)
                {
                    var hash = m_AssetBundleManifest.GetAssetBundleHash(bundleName);
                    var bundleNameNoHash = bundleName.Replace("_" + hash, "");
                    m_BundleNameToHashBundleName.Add(bundleNameNoHash, bundleName);
                    m_HashBundleNameToBundleName.Add(bundleName, bundleNameNoHash);
                }
#endif

                foreach (var bundleName in m_AllManifest)
                {
                    string[] dependencies = m_AssetBundleManifest.GetAllDependencies(bundleName);
#if UNITY_WEBGL && !UNITY_EDITOR
                    string abName = TransformHashABNameToABName(bundleName);
                    List<string> fixedDepends = new List<string>();
                    foreach (string dependency in dependencies) 
                    {
                        fixedDepends.Add(TransformHashABNameToABName(dependency));
                    }
                    m_Dependencies.Add(abName, fixedDepends.ToArray());
#else
                    m_Dependencies.Add(bundleName, dependencies);
#endif
                }
            }
            else
            {
                LogUtil.LogWarning("AssetBundleManifest Load Finished but no AssetBundleManifest. " + AssetBundleManifestName);
            }
            if (onInitCallback != null) onInitCallback();
        });
    }

    void LoadAsset<T>(string abName, string[] assetNames, Action<UObject[]> action = null) where T : UObject
    {
        if (typeof(T) != typeof(AssetBundleManifest))
        {
            abName = FixABName(abName);

            string[] dependencies = null;
            if (m_Dependencies.TryGetValue(abName, out dependencies))
            {
                string result = string.Join("\n  ", dependencies);
                LogUtil.Log(string.Format("LoadAsset: {0} \n  {1}", abName, result));
            }
        }
        mh_.StartCoroutine(LoadAssetHelper<T>(abName, assetNames, action, true));
    }

    IEnumerator LoadAssetHelper<T>(string abName, string[] assetNames, Action<UObject[]> action = null, bool bRecordLog = false) where T : UObject
    {
        ReturnTuple<Boolean, UObject[]> LoadResult = new ReturnTuple<Boolean, UObject[]>();
        LoadAssetRequest request = new LoadAssetRequest();
        request.assetType = typeof(T);
        request.assetNames = assetNames;
        request.onAction = (UObject[] objs) => 
        {
            LoadResult.value_1 = objs;
            LoadResult.value_0 = true;
        };

        List<LoadAssetRequest> requests = null;
        if (!m_LoadRequests.TryGetValue(abName, out requests))
        {
            requests = new List<LoadAssetRequest>();
            requests.Add(request);
            m_LoadRequests.Add(abName, requests);
            mh_.StartCoroutine(OnLoadAsset<T>(abName, bRecordLog));
        }
        else
        {
            requests.Add(request);
        }

        while(!LoadResult.value_0) yield return null;
        if (action != null) action(LoadResult.value_1);

        yield break;
    }

    IEnumerator OnLoadAsset<T>(string abName, bool bRecordLog = false) where T : UObject
    {
        AssetBundleInfo bundleInfo = GetLoadedAssetBundle(abName);
        if (bundleInfo == null)
        {
            yield return mh_.StartCoroutine(OnLoadAssetBundle<T>(abName));

            bundleInfo = GetLoadedAssetBundle(abName);
            if (bundleInfo == null)
            {
                m_LoadRequests.Remove(abName);
                LogUtil.LogWarning("OnLoadAsset Failed --->>> " + abName);
                yield break;
            }
            else
            {
                if(bRecordLog)
                    LogUtil.Log("OnLoadAsset Success --->>> " + abName);
            }
        }

        List<LoadAssetRequest> list = null;
        if (!m_LoadRequests.TryGetValue(abName, out list))
        {
            m_LoadRequests.Remove(abName);
            LogUtil.LogWarning(string.Format("OnLoadAsset m_LoadRequests：{0} is empty", abName));
            yield break;
        }
        
        if (bRecordLog) 
            LogUtil.LogWarning(string.Format("OnLoadAsset m_LoadRequests：{0} num is {1}", abName, list.Count));

        for (int i = 0; i < list.Count; i++)
        {
            string[] assetNames = list[i].assetNames;
            List<UObject> result = new List<UObject>();

            AssetBundle ab = bundleInfo.m_AssetBundle;

            if(abName.Contains("player_cc"))
            {
                LogUtil.LogWarning(string.Format("player_cc ：sb {0} action {1}", ab, list[i].onAction));
            }

            if (assetNames == null || assetNames.Length == 0)
            {
                result.Add(ab);
            }
            else
            {
                //场景数据
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

    IEnumerator OnLoadAssetBundleInner<T>(System.Uri uri, string abName, Action<bool> action) where T : UObject
    {
        //LogUtil.Log(string.Format("try load asset {0}", abName));
        bool isManifest = typeof(T) == typeof(AssetBundleManifest);
        if (!isManifest)
        {
            if (m_AssetBundleManifest != null)
            {
                string[] dependencies = null;
                if (m_Dependencies.TryGetValue(abName, out dependencies))
                {
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
                            //LogUtil.Log(string.Format("try load dep asset {0}", depName));
                            yield return mh_.StartCoroutine(LoadAssetHelper<T>(depName, null));
                        }
                    }
                }
            }
        }

        float beginTime = Time.realtimeSinceStartup;
        UnityWebRequest request = UnityWebRequestAssetBundle.GetAssetBundle(uri);
        if(isManifest) request.SetRequestHeader("Cache-Control", "no-cache");
        yield return request.SendWebRequest();

        if(request.result == UnityWebRequest.Result.Success)
        {
            //LogUtil.Log(string.Format("success load asset {0}, cost time: {1}", abName, Time.realtimeSinceStartup-beginTime));
            AssetBundle assetBundle = DownloadHandlerAssetBundle.GetContent(request);
            if (assetBundle != null)
            {
                m_LoadedAssetBundles.Add(abName, new AssetBundleInfo(assetBundle));
            }

            if (action != null) action(true);
        }
        else
        {
            LogUtil.LogWarning(string.Format("load asset field. {0}", uri.ToString()));
            LogUtil.LogWarning(request.error);
            if (action != null) action(false);
        }
    }

    IEnumerator OnLoadAssetBundle<T>(string abName) where T : UObject
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        string abNameHashed = TransformABNameToHashABName(abName);
        var streamingAssetsUrl = Application.streamingAssetsPath;
        if(WebCommon.isRunEnvWX())
            streamingAssetsUrl = WebCommon.get_streamingAssetsUrl();
        System.Uri uri = null;
        if (typeof(T) == typeof(AssetBundleManifest))
        {
            var sep = "?";
            if(abNameHashed.Contains('?')) sep = "&";
            uri = new System.Uri(streamingAssetsUrl + "/" + abNameHashed + sep + "t_=" + DateTime.Now.ToString("yyyyMMddHHmmssffff"));
        }
        else
        {
            uri = new System.Uri(streamingAssetsUrl + "/" + abNameHashed);
        }
        yield return OnLoadAssetBundleInner<T>(uri, abName, null);
#else
        bool bLoaded = false;
        for(int i=0; i< SearchPaths.Length && !bLoaded; ++i)
        {
            string assetRPath = SearchPaths[i];
            var uri = new System.Uri(assetRPath + "/" + GameUtil.ManifestName + "/" + abName);
            yield return OnLoadAssetBundleInner<T>(uri, abName, (bool succeed) => 
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
    /// 此函数交给外部卸载专用，自己调整是否需要彻底清除AB
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
    }

    void UnloadAssetBundleInternal(string abName, bool isThorough)
    {
        AssetBundleInfo bundle = GetLoadedAssetBundle(abName);
        if (bundle == null) return;

        if (--bundle.m_ReferencedCount <= 0)
        {
            if (m_LoadRequests.ContainsKey(abName))
            {
                return;     //如果当前AB处于Async Loading过程中，卸载会崩溃，只减去引用计数即可
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

    public static FResourceLoader inst
    {
        get { return Instance; }
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