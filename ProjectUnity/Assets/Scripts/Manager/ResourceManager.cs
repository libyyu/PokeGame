using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UObject = UnityEngine.Object;
using SLua;

namespace FGame
{
	public class AssetBundleInfo {
		public AssetBundle m_AssetBundle;
		public int m_ReferencedCount;

		public AssetBundleInfo(AssetBundle assetBundle) {
			m_AssetBundle = assetBundle;
			m_ReferencedCount = 0;
		}
	}

	[CustomLuaClass]
	public class ResourceManager : MonoBehaviour
	{
		static ResourceManager l_instance;
		string m_BaseDownloadingURL = "";
		string m_UpdateDownloadURL = "";
		string m_SepDownloadURL = "";
		bool   m_EnableSepFile = true;
		string m_ManifestName = "StreamingAssets";
		string m_ExtName = ".assetbundle";
		string[] m_AllManifest = null;
		AssetBundleManifest m_AssetBundleManifest = null;
		Dictionary<string, string[]> m_Dependencies = new Dictionary<string, string[]>();
		Dictionary<string, AssetBundleInfo> m_LoadedAssetBundles = new Dictionary<string, AssetBundleInfo>();
		Dictionary<string, List<LoadAssetRequest>> m_LoadRequests = new Dictionary<string, List<LoadAssetRequest>>();

		class LoadAssetRequest {
			public Type assetType;
			public string[] assetNames;
			public Action<UObject[]> onAction;
		}

		public string BaseDownloadingURL
		{
			get { return m_BaseDownloadingURL; }
			set { m_BaseDownloadingURL = value; }
		}

		public string UpdateDownloadURL
		{
			get { return m_UpdateDownloadURL; }
			set { m_UpdateDownloadURL = value; }
		}

		public string SepDownloadURL
		{
			get { return m_SepDownloadURL; }
			set { m_SepDownloadURL = value; }
		}

		public bool EnableSepFile
		{
			get { return m_EnableSepFile; }
			set { m_EnableSepFile = value; }
		}

		public string BundleExt
		{
			get { return m_ExtName; }
			set { m_ExtName = value; }
		}

		public string ManifestName
		{
			get { return m_ManifestName; }
			set { m_ManifestName = value; }
		}

		public static ResourceManager Instance
		{
			get {
				if (l_instance == null) {
					l_instance = new GameObject ("ResourceManager").AddComponent<ResourceManager> ();
				}
				return l_instance;
			}
		}

		[DoNotToLua]
		public void LoadAsset(string abName, string[] assetNames, Action<UObject[]> action)
		{
			Initialize (() => {
				LoadAsset<UObject> (abName, assetNames, action);
			});
		}

        [DoNotToLua]
        public void LoadBundle(string abName, Action<AssetBundle> action)
        {
            Initialize(() => {
                LoadAsset<UObject>(abName, null, (UObject[] objs)=>
                {
                    action(objs[0] as AssetBundle);
                });
            });
        }

        public void LoadAsset(string abName, string[] assetNames, LuaFunction func)
		{
			LoadAsset(abName, assetNames, (UObject[] objs) =>
			{
					func.call(objs);
					func.Dispose();
			});
		}

        public void LoadBundle(string abName, LuaFunction func)
        {
            LoadBundle(abName, (AssetBundle ab) =>
            {
                func.call(ab);
                func.Dispose();
            });
        }
			
		// Load AssetBundleManifest.
		void Initialize(Action onInitCallback) {
			LoadAsset<AssetBundleManifest>(ManifestName, new string[] { "AssetBundleManifest" }, delegate(UObject[] objs) {
				if (objs.Length > 0) {
					m_AssetBundleManifest = objs[0] as AssetBundleManifest;
					m_AllManifest = m_AssetBundleManifest.GetAllAssetBundles();
				}
				if (onInitCallback != null) onInitCallback();
			});
		}

		/// <summary>
		/// 载入素材
		/// </summary>
		void LoadAsset<T>(string abName, string[] assetNames, Action<UObject[]> action = null) where T : UObject {
			if (typeof(T) != typeof(AssetBundleManifest)) {
				abName = abName.ToLower ();
				abName = abName + BundleExt;
			}
			LoadAssetRequest request = new LoadAssetRequest();
			request.assetType = typeof(T);
			request.assetNames = assetNames;
			request.onAction = action;

			List<LoadAssetRequest> requests = null;
			if (!m_LoadRequests.TryGetValue(abName, out requests)) {
				requests = new List<LoadAssetRequest>();
				requests.Add(request);
				m_LoadRequests.Add(abName, requests);
				StartCoroutine(OnLoadAsset<T>(abName));
			} else {
				requests.Add(request);
			}
		}

        IEnumerator OnLoadAsset<T>(string abName) where T : UObject {
			AssetBundleInfo bundleInfo = GetLoadedAssetBundle(abName);
			if (bundleInfo == null) {
				yield return StartCoroutine(OnLoadAssetBundle(abName, typeof(T)));

				bundleInfo = GetLoadedAssetBundle(abName);
				if (bundleInfo == null) {
					m_LoadRequests.Remove(abName);
					if(ManifestName == abName)
						LogUtil.LogError("OnLoadAsset Failed --->>> " + abName);
					else
						LogUtil.LogWarning("OnLoadAsset Failed --->>> " + abName);
					yield break;
				}
			}

			List<LoadAssetRequest> list = null;
			if (!m_LoadRequests.TryGetValue(abName, out list)) {
				m_LoadRequests.Remove(abName);
				yield break;
			}

			for (int i = 0; i < list.Count; i++) {
				string[] assetNames = list[i].assetNames;
				List<UObject> result = new List<UObject>();

				AssetBundle ab = bundleInfo.m_AssetBundle;
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

				if (list[i].onAction != null) {
					list[i].onAction(result.ToArray());
					list[i].onAction = null;
				}

				bundleInfo.m_ReferencedCount++;
			}
			m_LoadRequests.Remove(abName);
		}

		IEnumerator OnLoadAssetBundle(string abName, Type type) {
			string url;
			if(EnableSepFile && File.Exists(GameUtil.MakePathFromWWW(SepDownloadURL) + "/" + abName))
				url = GameUtil.MakePathForWWW(SepDownloadURL) + "/" + abName;
			else if(File.Exists(GameUtil.MakePathFromWWW(UpdateDownloadURL + "/" + abName)))
				url = GameUtil.MakePathForWWW(UpdateDownloadURL) + "/" + abName;
			else
				url = GameUtil.MakePathForWWW(BaseDownloadingURL) + "/" + abName;
			LogUtil.Log (string.Format ("load asset {0}", url));
			WWW download = null;

			if (type == typeof(AssetBundleManifest))
				download = new WWW(url);
			else {
				string[] dependencies = m_AssetBundleManifest.GetAllDependencies(abName);
				if (dependencies.Length > 0) {
					m_Dependencies.Add(abName, dependencies);
					for (int i = 0; i < dependencies.Length; i++) {
						string depName = dependencies[i];
						AssetBundleInfo bundleInfo = null;
						if (m_LoadedAssetBundles.TryGetValue(depName, out bundleInfo)) {
							bundleInfo.m_ReferencedCount++;
						} else if (!m_LoadRequests.ContainsKey(depName)) {
							yield return StartCoroutine(OnLoadAssetBundle(depName, type));
						}
					}
				}
				download = WWW.LoadFromCacheOrDownload(url, m_AssetBundleManifest.GetAssetBundleHash(abName), 0);
			}
			yield return download;

			if(download.isDone && download.error == null){
				AssetBundle assetObj = download.assetBundle;
				if (assetObj != null) {
					m_LoadedAssetBundles.Add(abName, new AssetBundleInfo(assetObj));
				}
			}
			else if(download.error != null){
				LogUtil.LogWarning(download.error);
			}
		}

		AssetBundleInfo GetLoadedAssetBundle(string abName) {
			AssetBundleInfo bundle = null;
			m_LoadedAssetBundles.TryGetValue(abName, out bundle);
			if (bundle == null) return null;

			// No dependencies are recorded, only the bundle itself is required.
			string[] dependencies = null;
			if (!m_Dependencies.TryGetValue(abName, out dependencies))
				return bundle;

			// Make sure all dependencies are loaded
			foreach (var dependency in dependencies) {
				AssetBundleInfo dependentBundle;
				m_LoadedAssetBundles.TryGetValue(dependency, out dependentBundle);
				if (dependentBundle == null) {
					LogUtil.LogWarning (string.Format("Load Dependency {0}@{1} is Failed.", dependency, abName));
					//return null;
				}
			}
			return bundle;
		}

		/// <summary>
		/// 此函数交给外部卸载专用，自己调整是否需要彻底清除AB
		/// </summary>
		/// <param name="abName"></param>
		/// <param name="isThorough"></param>
		public void UnloadAssetBundle(string abName, bool isThorough = false) {
			if (abName != ManifestName && !abName.EndsWith (BundleExt)) {
				abName = abName.ToLower ();
				abName += BundleExt;
			}
			LogUtil.Log(m_LoadedAssetBundles.Count + " assetbundle(s) in memory before unloading " + abName);
			UnloadAssetBundleInternal(abName, isThorough);
			UnloadDependencies(abName, isThorough);
			LogUtil.Log(m_LoadedAssetBundles.Count + " assetbundle(s) in memory after unloading " + abName);
		}

		void UnloadDependencies(string abName, bool isThorough) {
			string[] dependencies = null;
			if (!m_Dependencies.TryGetValue(abName, out dependencies))
				return;

			// Loop dependencies.
			foreach (var dependency in dependencies) {
				UnloadAssetBundleInternal(dependency, isThorough);
			}
			m_Dependencies.Remove(abName);
		}

		void UnloadAssetBundleInternal(string abName, bool isThorough) {
			AssetBundleInfo bundle = GetLoadedAssetBundle(abName);
			if (bundle == null) return;

			if (--bundle.m_ReferencedCount <= 0) {
				if (m_LoadRequests.ContainsKey(abName)) {
					return;     //如果当前AB处于Async Loading过程中，卸载会崩溃，只减去引用计数即可
				}
				bundle.m_AssetBundle.Unload(isThorough);
				m_LoadedAssetBundles.Remove(abName);
				LogUtil.Log(abName + " has been unloaded successfully");
			}
		}

	}

}