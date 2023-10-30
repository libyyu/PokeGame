//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXBase : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXBase o;
			o=new WeChatWASM.WXBase();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int InitSDK_s(IntPtr l) {
		try {
			System.Action<System.Int32> a1 = default(System.Action<System.Int32>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WXBase.InitSDK(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReportGameStart_s(IntPtr l) {
		try {
			WeChatWASM.WXBase.ReportGameStart();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReportGameSceneError_s(IntPtr l) {
		try {
			System.Int32 a1 = default(System.Int32);
			checkType(l,1,out a1);
			System.Int32 a2 = default(System.Int32);
			checkType(l,2,out a2);
			System.String a3 = default(System.String);
			checkType(l,3,out a3);
			System.String a4 = default(System.String);
			checkType(l,4,out a4);
			WeChatWASM.WXBase.ReportGameSceneError(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WriteLog_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			WeChatWASM.WXBase.WriteLog(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WriteWarn_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			WeChatWASM.WXBase.WriteWarn(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int HideLoadingPage_s(IntPtr l) {
		try {
			WeChatWASM.WXBase.HideLoadingPage();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int PreloadConcurrent_s(IntPtr l) {
		try {
			System.Int32 a1 = default(System.Int32);
			checkType(l,1,out a1);
			WeChatWASM.WXBase.PreloadConcurrent(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReportUserBehaviorBranchAnalytics_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			System.String a2 = default(System.String);
			checkType(l,2,out a2);
			System.Int32 a3 = default(System.Int32);
			checkType(l,3,out a3);
			WeChatWASM.WXBase.ReportUserBehaviorBranchAnalytics(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StorageSetIntSync_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			System.Int32 a2 = default(System.Int32);
			checkType(l,2,out a2);
			WeChatWASM.WXBase.StorageSetIntSync(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StorageGetIntSync_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			System.Int32 a2 = default(System.Int32);
			checkType(l,2,out a2);
			var ret=WeChatWASM.WXBase.StorageGetIntSync(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StorageSetStringSync_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			System.String a2 = default(System.String);
			checkType(l,2,out a2);
			WeChatWASM.WXBase.StorageSetStringSync(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StorageGetStringSync_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			System.String a2 = default(System.String);
			checkType(l,2,out a2);
			var ret=WeChatWASM.WXBase.StorageGetStringSync(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StorageSetFloatSync_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			System.Single a2 = default(System.Single);
			checkType(l,2,out a2);
			WeChatWASM.WXBase.StorageSetFloatSync(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StorageGetFloatSync_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			System.Single a2 = default(System.Single);
			checkType(l,2,out a2);
			var ret=WeChatWASM.WXBase.StorageGetFloatSync(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StorageDeleteAllSync_s(IntPtr l) {
		try {
			WeChatWASM.WXBase.StorageDeleteAllSync();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StorageDeleteKeySync_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			WeChatWASM.WXBase.StorageDeleteKeySync(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StorageHasKeySync_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			var ret=WeChatWASM.WXBase.StorageHasKeySync(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CreateUserInfoButton_s(IntPtr l) {
		try {
			System.Int32 a1 = default(System.Int32);
			checkType(l,1,out a1);
			System.Int32 a2 = default(System.Int32);
			checkType(l,2,out a2);
			System.Int32 a3 = default(System.Int32);
			checkType(l,3,out a3);
			System.Int32 a4 = default(System.Int32);
			checkType(l,4,out a4);
			System.String a5 = default(System.String);
			checkType(l,5,out a5);
			System.Boolean a6 = default(System.Boolean);
			checkType(l,6,out a6);
			var ret=WeChatWASM.WXBase.CreateUserInfoButton(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnShareAppMessage_s(IntPtr l) {
		try {
			WeChatWASM.WXShareAppMessageParam a1 = default(WeChatWASM.WXShareAppMessageParam);
			checkType(l,1,out a1);
			System.Action<System.Action<WeChatWASM.WXShareAppMessageParam>> a2 = default(System.Action<System.Action<WeChatWASM.WXShareAppMessageParam>>);
			checkDelegate(l,2,out a2);
			WeChatWASM.WXBase.OnShareAppMessage(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CreateBannerAd_s(IntPtr l) {
		try {
			WeChatWASM.WXCreateBannerAdParam a1 = default(WeChatWASM.WXCreateBannerAdParam);
			checkType(l,1,out a1);
			var ret=WeChatWASM.WXBase.CreateBannerAd(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CreateFixedBottomMiddleBannerAd_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			System.Int32 a2 = default(System.Int32);
			checkType(l,2,out a2);
			System.Int32 a3 = default(System.Int32);
			checkType(l,3,out a3);
			var ret=WeChatWASM.WXBase.CreateFixedBottomMiddleBannerAd(a1,a2,a3);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CreateRewardedVideoAd_s(IntPtr l) {
		try {
			WeChatWASM.WXCreateRewardedVideoAdParam a1 = default(WeChatWASM.WXCreateRewardedVideoAdParam);
			checkType(l,1,out a1);
			var ret=WeChatWASM.WXBase.CreateRewardedVideoAd(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CreateInterstitialAd_s(IntPtr l) {
		try {
			WeChatWASM.WXCreateInterstitialAdParam a1 = default(WeChatWASM.WXCreateInterstitialAdParam);
			checkType(l,1,out a1);
			var ret=WeChatWASM.WXBase.CreateInterstitialAd(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CreateCustomAd_s(IntPtr l) {
		try {
			WeChatWASM.WXCreateCustomAdParam a1 = default(WeChatWASM.WXCreateCustomAdParam);
			checkType(l,1,out a1);
			var ret=WeChatWASM.WXBase.CreateCustomAd(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetGameRecorder_s(IntPtr l) {
		try {
			var ret=WeChatWASM.WXBase.GetGameRecorder();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CreateCamera_s(IntPtr l) {
		try {
			WeChatWASM.CreateCameraOption a1 = default(WeChatWASM.CreateCameraOption);
			checkType(l,1,out a1);
			var ret=WeChatWASM.WXBase.CreateCamera(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetRecorderManager_s(IntPtr l) {
		try {
			var ret=WeChatWASM.WXBase.GetRecorderManager();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CreateMiniGameChat_s(IntPtr l) {
		try {
			WeChatWASM.WXChatOptions a1 = default(WeChatWASM.WXChatOptions);
			checkType(l,1,out a1);
			var ret=WeChatWASM.WXBase.CreateMiniGameChat(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int UploadFile_s(IntPtr l) {
		try {
			WeChatWASM.UploadFileOption a1 = default(WeChatWASM.UploadFileOption);
			checkType(l,1,out a1);
			var ret=WeChatWASM.WXBase.UploadFile(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetFileSystemManager_s(IntPtr l) {
		try {
			var ret=WeChatWASM.WXBase.GetFileSystemManager();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetOpenDataContext_s(IntPtr l) {
		try {
			var ret=WeChatWASM.WXBase.GetOpenDataContext();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ShowOpenData_s(IntPtr l) {
		try {
			UnityEngine.Texture a1 = default(UnityEngine.Texture);
			checkType(l,1,out a1);
			System.Int32 a2 = default(System.Int32);
			checkType(l,2,out a2);
			System.Int32 a3 = default(System.Int32);
			checkType(l,3,out a3);
			System.Int32 a4 = default(System.Int32);
			checkType(l,4,out a4);
			System.Int32 a5 = default(System.Int32);
			checkType(l,5,out a5);
			WeChatWASM.WXBase.ShowOpenData(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int HideOpenData_s(IntPtr l) {
		try {
			WeChatWASM.WXBase.HideOpenData();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CreateInnerAudioContext_s(IntPtr l) {
		try {
			WeChatWASM.InnerAudioContextParam a1 = default(WeChatWASM.InnerAudioContextParam);
			checkType(l,1,out a1);
			var ret=WeChatWASM.WXBase.CreateInnerAudioContext(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int PreDownloadAudios_s(IntPtr l) {
		try {
			System.String[] a1 = default(System.String[]);
			checkArray(l,1,out a1);
			System.Action<System.Int32> a2 = default(System.Action<System.Int32>);
			checkDelegate(l,2,out a2);
			WeChatWASM.WXBase.PreDownloadAudios(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CreateVideo_s(IntPtr l) {
		try {
			WeChatWASM.WXCreateVideoParam a1 = default(WeChatWASM.WXCreateVideoParam);
			checkType(l,1,out a1);
			var ret=WeChatWASM.WXBase.CreateVideo(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTotalMemorySize_s(IntPtr l) {
		try {
			var ret=WeChatWASM.WXBase.GetTotalMemorySize();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTotalStackSize_s(IntPtr l) {
		try {
			var ret=WeChatWASM.WXBase.GetTotalStackSize();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetStaticMemorySize_s(IntPtr l) {
		try {
			var ret=WeChatWASM.WXBase.GetStaticMemorySize();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetDynamicMemorySize_s(IntPtr l) {
		try {
			var ret=WeChatWASM.WXBase.GetDynamicMemorySize();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetUsedMemorySize_s(IntPtr l) {
		try {
			var ret=WeChatWASM.WXBase.GetUsedMemorySize();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetUnAllocatedMemorySize_s(IntPtr l) {
		try {
			var ret=WeChatWASM.WXBase.GetUnAllocatedMemorySize();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LogUnityHeapMem_s(IntPtr l) {
		try {
			WeChatWASM.WXBase.LogUnityHeapMem();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBundleNumberInMemory_s(IntPtr l) {
		try {
			var ret=WeChatWASM.WXBase.GetBundleNumberInMemory();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBundleNumberOnDisk_s(IntPtr l) {
		try {
			var ret=WeChatWASM.WXBase.GetBundleNumberOnDisk();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBundleSizeInMemory_s(IntPtr l) {
		try {
			var ret=WeChatWASM.WXBase.GetBundleSizeInMemory();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBundleSizeOnDisk_s(IntPtr l) {
		try {
			var ret=WeChatWASM.WXBase.GetBundleSizeOnDisk();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenProfileStats_s(IntPtr l) {
		try {
			WeChatWASM.WXBase.OpenProfileStats();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ProfilingMemoryDump_s(IntPtr l) {
		try {
			WeChatWASM.WXBase.ProfilingMemoryDump();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LogManagerDebug_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			WeChatWASM.WXBase.LogManagerDebug(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LogManagerInfo_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			WeChatWASM.WXBase.LogManagerInfo(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LogManagerLog_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			WeChatWASM.WXBase.LogManagerLog(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LogManagerWarn_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			WeChatWASM.WXBase.LogManagerWarn(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IsCloudTest_s(IntPtr l) {
		try {
			var ret=WeChatWASM.WXBase.IsCloudTest();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CleanAllFileCache_s(IntPtr l) {
		try {
			System.Action<System.Boolean> a1 = default(System.Action<System.Boolean>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WXBase.CleanAllFileCache(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CleanFileCache_s(IntPtr l) {
		try {
			System.Int32 a1 = default(System.Int32);
			checkType(l,1,out a1);
			System.Action<WeChatWASM.ReleaseResult> a2 = default(System.Action<WeChatWASM.ReleaseResult>);
			checkDelegate(l,2,out a2);
			WeChatWASM.WXBase.CleanFileCache(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RemoveFile_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			System.Action<System.Boolean> a2 = default(System.Action<System.Boolean>);
			checkDelegate(l,2,out a2);
			WeChatWASM.WXBase.RemoveFile(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetCachePath_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			var ret=WeChatWASM.WXBase.GetCachePath(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnLaunchProgress_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.LaunchEvent> a1 = default(System.Action<WeChatWASM.LaunchEvent>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WXBase.OnLaunchProgress(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int UncaughtException_s(IntPtr l) {
		try {
			WeChatWASM.WXBase.UncaughtException();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CreateGameClubButton_s(IntPtr l) {
		try {
			WeChatWASM.WXCreateGameClubButtonParam a1 = default(WeChatWASM.WXCreateGameClubButtonParam);
			checkType(l,1,out a1);
			var ret=WeChatWASM.WXBase.CreateGameClubButton(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnNeedPrivacyAuthorization_s(IntPtr l) {
		try {
			System.Action<System.String> a1 = default(System.Action<System.String>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WXBase.OnNeedPrivacyAuthorization(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int PrivacyAuthorizeResolve_s(IntPtr l) {
		try {
			WeChatWASM.PrivacyAuthorizeResolveOption a1 = default(WeChatWASM.PrivacyAuthorizeResolveOption);
			checkType(l,1,out a1);
			WeChatWASM.WXBase.PrivacyAuthorizeResolve(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CreateUDPSocket_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			System.Int32 a2 = default(System.Int32);
			checkType(l,2,out a2);
			System.Int32 a3 = default(System.Int32);
			checkType(l,3,out a3);
			var ret=WeChatWASM.WXBase.CreateUDPSocket(a1,a2,a3);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CloseUDPSocket_s(IntPtr l) {
		try {
			System.Int32 a1 = default(System.Int32);
			checkType(l,1,out a1);
			WeChatWASM.WXBase.CloseUDPSocket(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SendUDPSocket_s(IntPtr l) {
		try {
			System.Int32 a1 = default(System.Int32);
			checkType(l,1,out a1);
			System.Byte[] a2 = default(System.Byte[]);
			checkArray(l,2,out a2);
			System.Int32 a3 = default(System.Int32);
			checkType(l,3,out a3);
			System.Int32 a4 = default(System.Int32);
			checkType(l,4,out a4);
			WeChatWASM.WXBase.SendUDPSocket(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetDataCDN_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			WeChatWASM.WXBase.SetDataCDN(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetPreloadList_s(IntPtr l) {
		try {
			System.String[] a1 = default(System.String[]);
			checkArray(l,1,out a1);
			WeChatWASM.WXBase.SetPreloadList(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetWXFont_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			System.Action<UnityEngine.Font> a2 = default(System.Action<UnityEngine.Font>);
			checkDelegate(l,2,out a2);
			WeChatWASM.WXBase.GetWXFont(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_env(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,WeChatWASM.WXBase.env);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_cloud(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,WeChatWASM.WXBase.cloud);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_PluginCachePath(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,WeChatWASM.WXBase.PluginCachePath);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXBase");
		addMember(l,InitSDK_s);
		addMember(l,ReportGameStart_s);
		addMember(l,ReportGameSceneError_s);
		addMember(l,WriteLog_s);
		addMember(l,WriteWarn_s);
		addMember(l,HideLoadingPage_s);
		addMember(l,PreloadConcurrent_s);
		addMember(l,ReportUserBehaviorBranchAnalytics_s);
		addMember(l,StorageSetIntSync_s);
		addMember(l,StorageGetIntSync_s);
		addMember(l,StorageSetStringSync_s);
		addMember(l,StorageGetStringSync_s);
		addMember(l,StorageSetFloatSync_s);
		addMember(l,StorageGetFloatSync_s);
		addMember(l,StorageDeleteAllSync_s);
		addMember(l,StorageDeleteKeySync_s);
		addMember(l,StorageHasKeySync_s);
		addMember(l,CreateUserInfoButton_s);
		addMember(l,OnShareAppMessage_s);
		addMember(l,CreateBannerAd_s);
		addMember(l,CreateFixedBottomMiddleBannerAd_s);
		addMember(l,CreateRewardedVideoAd_s);
		addMember(l,CreateInterstitialAd_s);
		addMember(l,CreateCustomAd_s);
		addMember(l,GetGameRecorder_s);
		addMember(l,CreateCamera_s);
		addMember(l,GetRecorderManager_s);
		addMember(l,CreateMiniGameChat_s);
		addMember(l,UploadFile_s);
		addMember(l,GetFileSystemManager_s);
		addMember(l,GetOpenDataContext_s);
		addMember(l,ShowOpenData_s);
		addMember(l,HideOpenData_s);
		addMember(l,CreateInnerAudioContext_s);
		addMember(l,PreDownloadAudios_s);
		addMember(l,CreateVideo_s);
		addMember(l,GetTotalMemorySize_s);
		addMember(l,GetTotalStackSize_s);
		addMember(l,GetStaticMemorySize_s);
		addMember(l,GetDynamicMemorySize_s);
		addMember(l,GetUsedMemorySize_s);
		addMember(l,GetUnAllocatedMemorySize_s);
		addMember(l,LogUnityHeapMem_s);
		addMember(l,GetBundleNumberInMemory_s);
		addMember(l,GetBundleNumberOnDisk_s);
		addMember(l,GetBundleSizeInMemory_s);
		addMember(l,GetBundleSizeOnDisk_s);
		addMember(l,OpenProfileStats_s);
		addMember(l,ProfilingMemoryDump_s);
		addMember(l,LogManagerDebug_s);
		addMember(l,LogManagerInfo_s);
		addMember(l,LogManagerLog_s);
		addMember(l,LogManagerWarn_s);
		addMember(l,IsCloudTest_s);
		addMember(l,CleanAllFileCache_s);
		addMember(l,CleanFileCache_s);
		addMember(l,RemoveFile_s);
		addMember(l,GetCachePath_s);
		addMember(l,OnLaunchProgress_s);
		addMember(l,UncaughtException_s);
		addMember(l,CreateGameClubButton_s);
		addMember(l,OnNeedPrivacyAuthorization_s);
		addMember(l,PrivacyAuthorizeResolve_s);
		addMember(l,CreateUDPSocket_s);
		addMember(l,CloseUDPSocket_s);
		addMember(l,SendUDPSocket_s);
		addMember(l,SetDataCDN_s);
		addMember(l,SetPreloadList_s);
		addMember(l,GetWXFont_s);
		addMember(l,"env",get_env,null,false);
		addMember(l,"cloud",get_cloud,null,false);
		addMember(l,"PluginCachePath",get_PluginCachePath,null,false);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXBase));
	}
}
