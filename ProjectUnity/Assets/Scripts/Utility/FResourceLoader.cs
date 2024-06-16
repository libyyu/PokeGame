using SLua;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.Networking;
using WeChatWASM;
using UObject = UnityEngine.Object;


public abstract class IAssetLoader
{
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
            UObject obj = UnityEditor.AssetDatabase.LoadAssetAtPath(GameUtil.FixAssetPath(assetPath), typeof(UObject));
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
        string fpath = GameUtil.FixAssetPath(filePath);
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
            return GameUtil.ManifestName;
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
            abName = GameUtil.FixABName(abName);

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

        if (bRecordLog)
        {
            AssetBundleInfo bundleInfo = GetLoadedAssetBundle(abName);
            if(bundleInfo == null || bundleInfo.m_AssetBundle == null)
                LogUtil.Log("LoadAsset Failed --->>> " + abName);
        }

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
                LogUtil.LogWarning("OnLoadAsset Failed --->>> " + abName);
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
        
        for (int i = 0; i < list.Count; i++)
        {
            string[] assetNames = list[i].assetNames;
            List<UObject> result = new List<UObject>();

            if (bundleInfo != null)
            {
                AssetBundle ab = bundleInfo.m_AssetBundle;

                //if (abName.Contains("player_cc"))
                //{
                //    LogUtil.LogWarning(string.Format("player_cc ：sb {0} action {1}", ab, list[i].onAction));
                //}

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
            }

            if (list[i].onAction != null)
            {
                list[i].onAction(result.ToArray());
                list[i].onAction = null;
            }
            if (bundleInfo != null)
            {
                bundleInfo.m_ReferencedCount++;
            }
        }
        m_LoadRequests.Remove(abName);
    }

    IEnumerator OnLoadAssetBundleInner<T>(System.Uri uri, string abName, Action<bool> action) where T : UObject
    {
        //LogUtil.Log(string.Format("try load asset {0}", abName));
#if UNITY_WEBGL && !UNITY_EDITOR
        string abNameHashed = TransformABNameToHashABName(abName);
        string abNameHashedNoPath = abNameHashed;
        int pos = abNameHashed.LastIndexOf("/");
        if (pos != -1)
        {
            abNameHashedNoPath = abNameHashed.Substring(pos+1);
        }

        string assetBundleCachedPath = Path.Combine(Application.persistentDataPath, abNameHashedNoPath);
#endif


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

            ReturnTuple<bool> LoadCacheResult = new ReturnTuple<bool>();
#if UNITY_WEBGL && !UNITY_EDITOR
            yield return OnLoadABFromCache(abName, uri, assetBundleCachedPath, LoadCacheResult);
#else
            yield return OnLoadABFromCache(abName, uri, null, LoadCacheResult);
#endif
            if(LoadCacheResult.value_0)
            {
                if (action != null) action(true);
                yield break;
            }
        }

        float beginTime = Time.realtimeSinceStartup;
        UnityWebRequest request = UnityWebRequest.Get(uri);
        if(isManifest) request.SetRequestHeader("Cache-Control", "no-cache");
        yield return request.SendWebRequest();

        if(request.result == UnityWebRequest.Result.Success)
        {
            byte[] bundleData = request.downloadHandler.data;
            AssetBundle assetBundle = AssetBundle.LoadFromMemory(bundleData);
            //LogUtil.Log(string.Format("success load asset {0}, cost time: {1}", abName, Time.realtimeSinceStartup-beginTime));
            //AssetBundle assetBundle = DownloadHandlerAssetBundle.GetContent(request);
            if (assetBundle != null)
            {
                m_LoadedAssetBundles.Add(abName, new AssetBundleInfo(assetBundle));
#if UNITY_WEBGL && !UNITY_EDITOR
                try
                {
                    // 将字节内容写入目标文件
                    File.WriteAllBytes(assetBundleCachedPath, bundleData);
                    LogUtil.Log(string.Format("save assetbundle to cache {0}", assetBundleCachedPath));
                }
                catch(Exception e)
                {
                    LogUtil.LogWarning(string.Format("save assetbundle to cache. {0} {1}", assetBundleCachedPath, e.ToString()));
                }
#endif

                if (action != null) action(true);
                yield break;
            }

            if (action != null) action(false);
            yield break;
        }
        else
        {
            LogUtil.LogWarning(string.Format("load asset field. {0}", uri.ToString()));
            LogUtil.LogWarning(request.error);
            if (action != null) action(false);
        }
    }

    IEnumerator OnLoadABFromCache(string abName, System.Uri uri, string assetBundleCachedPath, ReturnTuple<Boolean> LoadResult)
    {
        LoadResult.value_0 = false;
        // Load AssetBundle from cache
        UnityWebRequest request = UnityWebRequestAssetBundle.GetAssetBundle(uri);
        yield return request.SendWebRequest();
        if (request.result == UnityWebRequest.Result.Success)
        {
            AssetBundle assetBundle = DownloadHandlerAssetBundle.GetContent(request);
            if (assetBundle != null)
            {
                m_LoadedAssetBundles.Add(abName, new AssetBundleInfo(assetBundle));
                LogUtil.Log(string.Format("load asset from cache. {0}", uri.ToString()));
                LoadResult.value_0 = true;
                yield break;
            }
        }

        if (!string.IsNullOrEmpty(assetBundleCachedPath) && File.Exists(assetBundleCachedPath))
        {
            // 加载 AssetBundle
            AssetBundleCreateRequest bundleRequest = AssetBundle.LoadFromFileAsync(assetBundleCachedPath);
            yield return bundleRequest;

            AssetBundle assetBundle = bundleRequest.assetBundle;
            if (assetBundle != null)
            {
                m_LoadedAssetBundles.Add(abName, new AssetBundleInfo(assetBundle));
                LogUtil.Log(string.Format("load asset from cache. {0}", assetBundleCachedPath));
                LoadResult.value_0 = true;
                yield break;
            }
            else
            {
                LogUtil.LogWarning(string.Format("load assetbundle from cache failed. {0}", assetBundleCachedPath));
            }
        }
    }

    IEnumerator OnLoadAssetBundle<T>(string abName) where T : UObject
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        string abNameHashed = TransformABNameToHashABName(abName);
        var streamingAssetsUrl = WebCommon.get_streamingAssetsMainUrl();

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

        ReturnTuple<Boolean> LoadABResult = new ReturnTuple<Boolean>();
        yield return OnLoadAssetBundleInner<T>(uri, abName, (bool succeed) =>
        {
            if (succeed) LoadABResult.value_0 = true;
        });

        if (!LoadABResult.value_0)
        {
            string[] backupUrls = WebCommon.get_streamingAssetsBackupUrls();
            if (backupUrls != null && backupUrls.Length > 0)
            {
                LogUtil.LogWarning(string.Format("backupUrls. {0}", backupUrls.Length));
                for (int i = 0; i < backupUrls.Length && !LoadABResult.value_0; ++i)
                {
                    LogUtil.LogWarning(string.Format("backup url. {0}", backupUrls[i]));
                    if (typeof(T) == typeof(AssetBundleManifest))
                    {
                        var sep = "?";
                        if (abNameHashed.Contains('?')) sep = "&";
                        uri = new System.Uri(backupUrls[i] + "/" + abNameHashed + sep + "t_=" + DateTime.Now.ToString("yyyyMMddHHmmssffff"));
                    }
                    else
                    {
                        uri = new System.Uri(backupUrls[i] + "/" + abNameHashed);
                    }
                    yield return OnLoadAssetBundleInner<T>(uri, abName, (bool succeed) =>
                    {
                        if (succeed) LoadABResult.value_0 = true;
                    });

                    if (LoadABResult.value_0) break;
                }
            }
            else
                LogUtil.LogWarning(string.Format("backupUrls empty"));
        }

        //try read from cache
        if (typeof(T) == typeof(AssetBundleManifest))
        {
            AssetBundleInfo bundleInfo = GetLoadedAssetBundle(abName);
            if (bundleInfo == null)
            {
                string abNameHashedNoPath = abNameHashed;
                int pos = abNameHashed.LastIndexOf("/");
                if (pos != -1)
                {
                    abNameHashedNoPath = abNameHashed.Substring(pos + 1);
                }

                string assetBundleCachedPath = Path.Combine(Application.persistentDataPath, abNameHashedNoPath);

                ReturnTuple<bool> LoadCacheResult = new ReturnTuple<bool>();
                yield return OnLoadABFromCache(abName, uri, assetBundleCachedPath, LoadCacheResult);
                if(LoadCacheResult.value_0)
                {
                    yield break;
                }

                string[] backupUrls = WebCommon.get_streamingAssetsBackupUrls();
                if (backupUrls != null && backupUrls.Length > 0)
                {
                    for (int i = 0; i < backupUrls.Length && !LoadABResult.value_0; ++i)
                    {
                        if (typeof(T) == typeof(AssetBundleManifest))
                        {
                            var sep = "?";
                            if (abNameHashed.Contains('?')) sep = "&";
                            uri = new System.Uri(backupUrls[i] + "/" + abNameHashed + sep + "t_=" + DateTime.Now.ToString("yyyyMMddHHmmssffff"));
                        }
                        else
                        {
                            uri = new System.Uri(backupUrls[i] + "/" + abNameHashed);
                        }

                        yield return OnLoadABFromCache(abName, uri, assetBundleCachedPath, LoadCacheResult);
                        if (LoadCacheResult.value_0)
                        {
                            yield break;
                        }
                    }
                }
            }
        }
#else
        bool bLoaded = false;
        for(int i=0; i< SearchPaths.Length && !bLoaded; ++i)
        {
            string assetRPath = SearchPaths[i];
            var uri = new System.Uri(assetRPath + "/" + AssetBundleManifestName + "/" + abName);
            yield return OnLoadAssetBundleInner<T>(uri, abName, (bool succeed) => 
            {
                if (succeed) bLoaded = true;
            });

            if (bLoaded) break;
        }
#endif
    }


    protected override UObject[] LoadAssetImpl(string abName, string[] assetsPath)
    {
        abName = GameUtil.FixABName(abName);
        AssetBundleInfo bundleInfo = GetLoadedAssetBundle(abName);
        if (bundleInfo != null)
        {
            AssetBundle ab = bundleInfo.m_AssetBundle;
            if (ab != null)
            {
                List<UObject> result = new List<UObject>();
                if (assetsPath != null)
                {
                    if (assetsPath == null || assetsPath.Length == 0)
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
                            for (int j = 0; j < assetsPath.Length; j++)
                            {
                                string assetPath = assetsPath[j];
                                UObject obj = ab.LoadAsset<UObject>(GameUtil.FixAssetPath(assetPath));
                                result.Add(obj);
                            }
                        }
                    }
                }

                return result.ToArray();
            }
        }

#if UNITY_WEBGL && !UNITY_EDITOR
        LogUtil.LogError("Sync Load Not Support In WebGL");
#endif
        return null;
    }

    protected override void LoadAssetAsyncImpl(string bundleName, string[] assetsPath, Action<UObject[]> callback)
    {
        Initialize(() =>
        {
            List<string> fixedAssetsPath = new List<string>();
            foreach (var assetPath in assetsPath)
            {
                fixedAssetsPath.Add(GameUtil.FixAssetPath(assetPath));
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
        abName = GameUtil.FixABName(abName);
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
        string realABPath = GameUtil.FixABName(abName);
        string realAssetPath = GameUtil.FixAssetPath(abName + "/" + filePath);
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

        var ab = GetLoadedABundle(GameUtil.FixABName(abName));
        TextAsset textCode = ab != null ? ab.LoadAsset<TextAsset>(GameUtil.FixAssetPath(filePath)) : null;
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