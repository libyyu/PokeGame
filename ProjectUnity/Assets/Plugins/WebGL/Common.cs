#if UNITY_WEBGL && !UNITY_EDITOR
using UnityEngine;
using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;

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


    [DllImport("__Internal")]
    private static extern IntPtr getStreamingAssetsBackupUrls();

    [DllImport("__Internal")]
    private static extern void freeStringArrayInJS(IntPtr buffer);
    
	[Serializable]
    private class Wrapper<T>
    {
        public T[] array;
    }
	private static string WrapArray(string jsonString)
    {
        return "{\"array\":" + jsonString + "}";
    }

    private static string[] streamingAssetsBackupUrlsArray = null;

    public static string[] get_streamingAssetsBackupUrls()
	{
		if (streamingAssetsBackupUrlsArray == null)
		{
			IntPtr jsonPtr = getStreamingAssetsBackupUrls();

			string jsonString = Marshal.PtrToStringUTF8(jsonPtr);
            streamingAssetsBackupUrlsArray = JsonUtility.FromJson<Wrapper<string>>(WrapArray(jsonString)).array;

			freeStringArrayInJS(jsonPtr);
		}

		return streamingAssetsBackupUrlsArray;
    }

	[DllImport("__Internal")]
	protected static extern string getStreamingAssetsDebugUrl();

	static string _streamingAssetsDebugUrl = null;
	public static string get_streamingAssetsDebugUrl()
	{
		if(_streamingAssetsDebugUrl == null)
			_streamingAssetsDebugUrl = getStreamingAssetsDebugUrl();

		if(string.IsNullOrEmpty(_streamingAssetsDebugUrl)){
			return Application.streamingAssetsPath;
		}

		return _streamingAssetsDebugUrl;
	}

	public static string get_streamingAssetsMainUrl()
	{
		bool debug = isDebugMode();
		if (debug)
			return get_streamingAssetsDebugUrl();
		else
			return get_streamingAssetsUrl();

    }

	static Dictionary<string, string> querys = null;

    public static bool isDebugMode()
    {
		if (querys == null)
		{
            querys = new Dictionary<string, string>();
            var url = Application.absoluteURL;
			var query = new System.Uri(url).Query;
			query = query.TrimStart('?');
			// ½âÎö URL ²ÎÊý
			string[] parameters = query.Split('&');
			foreach (string parameter in parameters)
			{
				string[] keyValue = parameter.Split('=');
				string key = keyValue[0];
				string val = keyValue[1];
				if(querys.ContainsKey(key))
					querys[key] = val;
				else 
					querys.Add(key, val);
			}
		}

		string value;
		querys.TryGetValue("debug", out value);

        return value == "1";
    }
}

#endif