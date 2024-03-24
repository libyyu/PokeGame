#if UNITY_WEBGL && !UNITY_EDITOR
using UnityEngine;
using System.Runtime.InteropServices;

public class WebCommon
{
	[DllImport("__Internal")]
	public static extern void logToWeb(string str);

	[DllImport("__Internal")]
	public static extern bool isRunEnvWX();

	[DllImport("__Internal")]
	protected static extern string getStreamingAssetsUrl();

	static string _streamingAssetsUrl = null;
	public static string get_streamingAssetsUrl()
	{
		if(_streamingAssetsUrl == null)
			_streamingAssetsUrl = getStreamingAssetsUrl();

		if(string.IsNullOrEmpty(_streamingAssetsUrl)){
			return Application.streamingAssetsPath;
		}

		return _streamingAssetsUrl;
	}

	[DllImport("__Internal")]
	protected static extern string getAssetBundleManifestName();

	static string _AssetBundleManifestName = null;
	public static string get_AssetBundleManifestName()
	{
		if(_AssetBundleManifestName == null)
			_AssetBundleManifestName = getAssetBundleManifestName();

		if(string.IsNullOrEmpty(_AssetBundleManifestName)){
			return "StreamingAssets";
		}

		return _AssetBundleManifestName;
	}

	[DllImport("__Internal")]
	public static extern string callJSMethod(string method, string jsonParams);
}

#endif