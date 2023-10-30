//Auto Generate By LuaInterface, Do Not Edit!
#if UNITY_WEBGL && !UNITY_EDITOR
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WX : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WX o;
			o=new WeChatWASM.WX();
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
	static public int AddCard_s(IntPtr l) {
		try {
			WeChatWASM.AddCardOption a1 = default(WeChatWASM.AddCardOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.AddCard(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AuthPrivateMessage_s(IntPtr l) {
		try {
			WeChatWASM.AuthPrivateMessageOption a1 = default(WeChatWASM.AuthPrivateMessageOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.AuthPrivateMessage(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Authorize_s(IntPtr l) {
		try {
			WeChatWASM.AuthorizeOption a1 = default(WeChatWASM.AuthorizeOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.Authorize(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CheckIsAddedToMyMiniProgram_s(IntPtr l) {
		try {
			WeChatWASM.CheckIsAddedToMyMiniProgramOption a1 = default(WeChatWASM.CheckIsAddedToMyMiniProgramOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.CheckIsAddedToMyMiniProgram(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CheckSession_s(IntPtr l) {
		try {
			WeChatWASM.CheckSessionOption a1 = default(WeChatWASM.CheckSessionOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.CheckSession(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ChooseImage_s(IntPtr l) {
		try {
			WeChatWASM.ChooseImageOption a1 = default(WeChatWASM.ChooseImageOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.ChooseImage(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ChooseMedia_s(IntPtr l) {
		try {
			WeChatWASM.ChooseMediaOption a1 = default(WeChatWASM.ChooseMediaOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.ChooseMedia(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ChooseMessageFile_s(IntPtr l) {
		try {
			WeChatWASM.ChooseMessageFileOption a1 = default(WeChatWASM.ChooseMessageFileOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.ChooseMessageFile(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CloseBLEConnection_s(IntPtr l) {
		try {
			WeChatWASM.CloseBLEConnectionOption a1 = default(WeChatWASM.CloseBLEConnectionOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.CloseBLEConnection(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CloseBluetoothAdapter_s(IntPtr l) {
		try {
			WeChatWASM.CloseBluetoothAdapterOption a1 = default(WeChatWASM.CloseBluetoothAdapterOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.CloseBluetoothAdapter(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CompressImage_s(IntPtr l) {
		try {
			WeChatWASM.CompressImageOption a1 = default(WeChatWASM.CompressImageOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.CompressImage(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CreateBLEConnection_s(IntPtr l) {
		try {
			WeChatWASM.CreateBLEConnectionOption a1 = default(WeChatWASM.CreateBLEConnectionOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.CreateBLEConnection(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CreateBLEPeripheralServer_s(IntPtr l) {
		try {
			WeChatWASM.CreateBLEPeripheralServerOption a1 = default(WeChatWASM.CreateBLEPeripheralServerOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.CreateBLEPeripheralServer(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ExitMiniProgram_s(IntPtr l) {
		try {
			WeChatWASM.ExitMiniProgramOption a1 = default(WeChatWASM.ExitMiniProgramOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.ExitMiniProgram(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ExitVoIPChat_s(IntPtr l) {
		try {
			WeChatWASM.ExitVoIPChatOption a1 = default(WeChatWASM.ExitVoIPChatOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.ExitVoIPChat(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int FaceDetect_s(IntPtr l) {
		try {
			WeChatWASM.FaceDetectOption a1 = default(WeChatWASM.FaceDetectOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.FaceDetect(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetAvailableAudioSources_s(IntPtr l) {
		try {
			WeChatWASM.GetAvailableAudioSourcesOption a1 = default(WeChatWASM.GetAvailableAudioSourcesOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.GetAvailableAudioSources(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBLEDeviceCharacteristics_s(IntPtr l) {
		try {
			WeChatWASM.GetBLEDeviceCharacteristicsOption a1 = default(WeChatWASM.GetBLEDeviceCharacteristicsOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.GetBLEDeviceCharacteristics(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBLEDeviceRSSI_s(IntPtr l) {
		try {
			WeChatWASM.GetBLEDeviceRSSIOption a1 = default(WeChatWASM.GetBLEDeviceRSSIOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.GetBLEDeviceRSSI(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBLEDeviceServices_s(IntPtr l) {
		try {
			WeChatWASM.GetBLEDeviceServicesOption a1 = default(WeChatWASM.GetBLEDeviceServicesOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.GetBLEDeviceServices(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBLEMTU_s(IntPtr l) {
		try {
			WeChatWASM.GetBLEMTUOption a1 = default(WeChatWASM.GetBLEMTUOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.GetBLEMTU(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBackgroundFetchData_s(IntPtr l) {
		try {
			WeChatWASM.GetBackgroundFetchDataOption a1 = default(WeChatWASM.GetBackgroundFetchDataOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.GetBackgroundFetchData(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBackgroundFetchToken_s(IntPtr l) {
		try {
			WeChatWASM.GetBackgroundFetchTokenOption a1 = default(WeChatWASM.GetBackgroundFetchTokenOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.GetBackgroundFetchToken(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBatteryInfo_s(IntPtr l) {
		try {
			WeChatWASM.GetBatteryInfoOption a1 = default(WeChatWASM.GetBatteryInfoOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.GetBatteryInfo(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBeacons_s(IntPtr l) {
		try {
			WeChatWASM.GetBeaconsOption a1 = default(WeChatWASM.GetBeaconsOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.GetBeacons(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBluetoothAdapterState_s(IntPtr l) {
		try {
			WeChatWASM.GetBluetoothAdapterStateOption a1 = default(WeChatWASM.GetBluetoothAdapterStateOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.GetBluetoothAdapterState(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBluetoothDevices_s(IntPtr l) {
		try {
			WeChatWASM.GetBluetoothDevicesOption a1 = default(WeChatWASM.GetBluetoothDevicesOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.GetBluetoothDevices(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetChannelsLiveInfo_s(IntPtr l) {
		try {
			WeChatWASM.GetChannelsLiveInfoOption a1 = default(WeChatWASM.GetChannelsLiveInfoOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.GetChannelsLiveInfo(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetChannelsLiveNoticeInfo_s(IntPtr l) {
		try {
			WeChatWASM.GetChannelsLiveNoticeInfoOption a1 = default(WeChatWASM.GetChannelsLiveNoticeInfoOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.GetChannelsLiveNoticeInfo(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetClipboardData_s(IntPtr l) {
		try {
			WeChatWASM.GetClipboardDataOption a1 = default(WeChatWASM.GetClipboardDataOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.GetClipboardData(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetConnectedBluetoothDevices_s(IntPtr l) {
		try {
			WeChatWASM.GetConnectedBluetoothDevicesOption a1 = default(WeChatWASM.GetConnectedBluetoothDevicesOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.GetConnectedBluetoothDevices(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetExtConfig_s(IntPtr l) {
		try {
			WeChatWASM.GetExtConfigOption a1 = default(WeChatWASM.GetExtConfigOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.GetExtConfig(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetFuzzyLocation_s(IntPtr l) {
		try {
			WeChatWASM.GetFuzzyLocationOption a1 = default(WeChatWASM.GetFuzzyLocationOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.GetFuzzyLocation(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetGameClubData_s(IntPtr l) {
		try {
			WeChatWASM.GetGameClubDataOption a1 = default(WeChatWASM.GetGameClubDataOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.GetGameClubData(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetGroupEnterInfo_s(IntPtr l) {
		try {
			WeChatWASM.GetGroupEnterInfoOption a1 = default(WeChatWASM.GetGroupEnterInfoOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.GetGroupEnterInfo(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetInferenceEnvInfo_s(IntPtr l) {
		try {
			WeChatWASM.GetInferenceEnvInfoOption a1 = default(WeChatWASM.GetInferenceEnvInfoOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.GetInferenceEnvInfo(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetLocalIPAddress_s(IntPtr l) {
		try {
			WeChatWASM.GetLocalIPAddressOption a1 = default(WeChatWASM.GetLocalIPAddressOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.GetLocalIPAddress(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetLocation_s(IntPtr l) {
		try {
			WeChatWASM.GetLocationOption a1 = default(WeChatWASM.GetLocationOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.GetLocation(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetNetworkType_s(IntPtr l) {
		try {
			WeChatWASM.GetNetworkTypeOption a1 = default(WeChatWASM.GetNetworkTypeOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.GetNetworkType(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetPrivacySetting_s(IntPtr l) {
		try {
			WeChatWASM.GetPrivacySettingOption a1 = default(WeChatWASM.GetPrivacySettingOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.GetPrivacySetting(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetScreenBrightness_s(IntPtr l) {
		try {
			WeChatWASM.GetScreenBrightnessOption a1 = default(WeChatWASM.GetScreenBrightnessOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.GetScreenBrightness(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetSetting_s(IntPtr l) {
		try {
			WeChatWASM.GetSettingOption a1 = default(WeChatWASM.GetSettingOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.GetSetting(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetShareInfo_s(IntPtr l) {
		try {
			WeChatWASM.GetShareInfoOption a1 = default(WeChatWASM.GetShareInfoOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.GetShareInfo(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetStorageInfo_s(IntPtr l) {
		try {
			WeChatWASM.GetStorageInfoOption a1 = default(WeChatWASM.GetStorageInfoOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.GetStorageInfo(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetSystemInfo_s(IntPtr l) {
		try {
			WeChatWASM.GetSystemInfoOption a1 = default(WeChatWASM.GetSystemInfoOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.GetSystemInfo(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetSystemInfoAsync_s(IntPtr l) {
		try {
			WeChatWASM.GetSystemInfoAsyncOption a1 = default(WeChatWASM.GetSystemInfoAsyncOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.GetSystemInfoAsync(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetUserInfo_s(IntPtr l) {
		try {
			WeChatWASM.GetUserInfoOption a1 = default(WeChatWASM.GetUserInfoOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.GetUserInfo(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetUserInteractiveStorage_s(IntPtr l) {
		try {
			WeChatWASM.GetUserInteractiveStorageOption a1 = default(WeChatWASM.GetUserInteractiveStorageOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.GetUserInteractiveStorage(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetWeRunData_s(IntPtr l) {
		try {
			WeChatWASM.GetWeRunDataOption a1 = default(WeChatWASM.GetWeRunDataOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.GetWeRunData(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int HideKeyboard_s(IntPtr l) {
		try {
			WeChatWASM.HideKeyboardOption a1 = default(WeChatWASM.HideKeyboardOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.HideKeyboard(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int HideLoading_s(IntPtr l) {
		try {
			WeChatWASM.HideLoadingOption a1 = default(WeChatWASM.HideLoadingOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.HideLoading(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int HideShareMenu_s(IntPtr l) {
		try {
			WeChatWASM.HideShareMenuOption a1 = default(WeChatWASM.HideShareMenuOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.HideShareMenu(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int HideToast_s(IntPtr l) {
		try {
			WeChatWASM.HideToastOption a1 = default(WeChatWASM.HideToastOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.HideToast(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int InitFaceDetect_s(IntPtr l) {
		try {
			WeChatWASM.InitFaceDetectOption a1 = default(WeChatWASM.InitFaceDetectOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.InitFaceDetect(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IsBluetoothDevicePaired_s(IntPtr l) {
		try {
			WeChatWASM.IsBluetoothDevicePairedOption a1 = default(WeChatWASM.IsBluetoothDevicePairedOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.IsBluetoothDevicePaired(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int JoinVoIPChat_s(IntPtr l) {
		try {
			WeChatWASM.JoinVoIPChatOption a1 = default(WeChatWASM.JoinVoIPChatOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.JoinVoIPChat(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Login_s(IntPtr l) {
		try {
			WeChatWASM.LoginOption a1 = default(WeChatWASM.LoginOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.Login(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int MakeBluetoothPair_s(IntPtr l) {
		try {
			WeChatWASM.MakeBluetoothPairOption a1 = default(WeChatWASM.MakeBluetoothPairOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.MakeBluetoothPair(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int NavigateToMiniProgram_s(IntPtr l) {
		try {
			WeChatWASM.NavigateToMiniProgramOption a1 = default(WeChatWASM.NavigateToMiniProgramOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.NavigateToMiniProgram(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int NotifyBLECharacteristicValueChange_s(IntPtr l) {
		try {
			WeChatWASM.NotifyBLECharacteristicValueChangeOption a1 = default(WeChatWASM.NotifyBLECharacteristicValueChangeOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.NotifyBLECharacteristicValueChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenAppAuthorizeSetting_s(IntPtr l) {
		try {
			WeChatWASM.OpenAppAuthorizeSettingOption a1 = default(WeChatWASM.OpenAppAuthorizeSettingOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.OpenAppAuthorizeSetting(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenBluetoothAdapter_s(IntPtr l) {
		try {
			WeChatWASM.OpenBluetoothAdapterOption a1 = default(WeChatWASM.OpenBluetoothAdapterOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.OpenBluetoothAdapter(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenCard_s(IntPtr l) {
		try {
			WeChatWASM.OpenCardOption a1 = default(WeChatWASM.OpenCardOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.OpenCard(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenChannelsActivity_s(IntPtr l) {
		try {
			WeChatWASM.OpenChannelsActivityOption a1 = default(WeChatWASM.OpenChannelsActivityOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.OpenChannelsActivity(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenChannelsEvent_s(IntPtr l) {
		try {
			WeChatWASM.OpenChannelsEventOption a1 = default(WeChatWASM.OpenChannelsEventOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.OpenChannelsEvent(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenChannelsLive_s(IntPtr l) {
		try {
			WeChatWASM.OpenChannelsLiveOption a1 = default(WeChatWASM.OpenChannelsLiveOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.OpenChannelsLive(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenChannelsUserProfile_s(IntPtr l) {
		try {
			WeChatWASM.OpenChannelsUserProfileOption a1 = default(WeChatWASM.OpenChannelsUserProfileOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.OpenChannelsUserProfile(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenCustomerServiceChat_s(IntPtr l) {
		try {
			WeChatWASM.OpenCustomerServiceChatOption a1 = default(WeChatWASM.OpenCustomerServiceChatOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.OpenCustomerServiceChat(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenCustomerServiceConversation_s(IntPtr l) {
		try {
			WeChatWASM.OpenCustomerServiceConversationOption a1 = default(WeChatWASM.OpenCustomerServiceConversationOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.OpenCustomerServiceConversation(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenPrivacyContract_s(IntPtr l) {
		try {
			WeChatWASM.OpenPrivacyContractOption a1 = default(WeChatWASM.OpenPrivacyContractOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.OpenPrivacyContract(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenSetting_s(IntPtr l) {
		try {
			WeChatWASM.OpenSettingOption a1 = default(WeChatWASM.OpenSettingOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.OpenSetting(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenSystemBluetoothSetting_s(IntPtr l) {
		try {
			WeChatWASM.OpenSystemBluetoothSettingOption a1 = default(WeChatWASM.OpenSystemBluetoothSettingOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.OpenSystemBluetoothSetting(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int PreviewImage_s(IntPtr l) {
		try {
			WeChatWASM.PreviewImageOption a1 = default(WeChatWASM.PreviewImageOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.PreviewImage(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int PreviewMedia_s(IntPtr l) {
		try {
			WeChatWASM.PreviewMediaOption a1 = default(WeChatWASM.PreviewMediaOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.PreviewMedia(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReadBLECharacteristicValue_s(IntPtr l) {
		try {
			WeChatWASM.ReadBLECharacteristicValueOption a1 = default(WeChatWASM.ReadBLECharacteristicValueOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.ReadBLECharacteristicValue(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RemoveStorage_s(IntPtr l) {
		try {
			WeChatWASM.RemoveStorageOption a1 = default(WeChatWASM.RemoveStorageOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.RemoveStorage(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RemoveUserCloudStorage_s(IntPtr l) {
		try {
			WeChatWASM.RemoveUserCloudStorageOption a1 = default(WeChatWASM.RemoveUserCloudStorageOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.RemoveUserCloudStorage(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReportScene_s(IntPtr l) {
		try {
			WeChatWASM.ReportSceneOption a1 = default(WeChatWASM.ReportSceneOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.ReportScene(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RequestMidasFriendPayment_s(IntPtr l) {
		try {
			WeChatWASM.RequestMidasFriendPaymentOption a1 = default(WeChatWASM.RequestMidasFriendPaymentOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.RequestMidasFriendPayment(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RequestMidasPayment_s(IntPtr l) {
		try {
			WeChatWASM.RequestMidasPaymentOption a1 = default(WeChatWASM.RequestMidasPaymentOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.RequestMidasPayment(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RequestSubscribeMessage_s(IntPtr l) {
		try {
			WeChatWASM.RequestSubscribeMessageOption a1 = default(WeChatWASM.RequestSubscribeMessageOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.RequestSubscribeMessage(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RequestSubscribeSystemMessage_s(IntPtr l) {
		try {
			WeChatWASM.RequestSubscribeSystemMessageOption a1 = default(WeChatWASM.RequestSubscribeSystemMessageOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.RequestSubscribeSystemMessage(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RequirePrivacyAuthorize_s(IntPtr l) {
		try {
			WeChatWASM.RequirePrivacyAuthorizeOption a1 = default(WeChatWASM.RequirePrivacyAuthorizeOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.RequirePrivacyAuthorize(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RestartMiniProgram_s(IntPtr l) {
		try {
			WeChatWASM.RestartMiniProgramOption a1 = default(WeChatWASM.RestartMiniProgramOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.RestartMiniProgram(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SaveFileToDisk_s(IntPtr l) {
		try {
			WeChatWASM.SaveFileToDiskOption a1 = default(WeChatWASM.SaveFileToDiskOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.SaveFileToDisk(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SaveImageToPhotosAlbum_s(IntPtr l) {
		try {
			WeChatWASM.SaveImageToPhotosAlbumOption a1 = default(WeChatWASM.SaveImageToPhotosAlbumOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.SaveImageToPhotosAlbum(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ScanCode_s(IntPtr l) {
		try {
			WeChatWASM.ScanCodeOption a1 = default(WeChatWASM.ScanCodeOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.ScanCode(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetBLEMTU_s(IntPtr l) {
		try {
			WeChatWASM.SetBLEMTUOption a1 = default(WeChatWASM.SetBLEMTUOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.SetBLEMTU(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetBackgroundFetchToken_s(IntPtr l) {
		try {
			WeChatWASM.SetBackgroundFetchTokenOption a1 = default(WeChatWASM.SetBackgroundFetchTokenOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.SetBackgroundFetchToken(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetClipboardData_s(IntPtr l) {
		try {
			WeChatWASM.SetClipboardDataOption a1 = default(WeChatWASM.SetClipboardDataOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.SetClipboardData(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetDeviceOrientation_s(IntPtr l) {
		try {
			WeChatWASM.SetDeviceOrientationOption a1 = default(WeChatWASM.SetDeviceOrientationOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.SetDeviceOrientation(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetEnableDebug_s(IntPtr l) {
		try {
			WeChatWASM.SetEnableDebugOption a1 = default(WeChatWASM.SetEnableDebugOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.SetEnableDebug(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetInnerAudioOption_s(IntPtr l) {
		try {
			WeChatWASM.SetInnerAudioOption a1 = default(WeChatWASM.SetInnerAudioOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.SetInnerAudioOption(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetKeepScreenOn_s(IntPtr l) {
		try {
			WeChatWASM.SetKeepScreenOnOption a1 = default(WeChatWASM.SetKeepScreenOnOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.SetKeepScreenOn(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetMenuStyle_s(IntPtr l) {
		try {
			WeChatWASM.SetMenuStyleOption a1 = default(WeChatWASM.SetMenuStyleOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.SetMenuStyle(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetScreenBrightness_s(IntPtr l) {
		try {
			WeChatWASM.SetScreenBrightnessOption a1 = default(WeChatWASM.SetScreenBrightnessOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.SetScreenBrightness(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetStatusBarStyle_s(IntPtr l) {
		try {
			WeChatWASM.SetStatusBarStyleOption a1 = default(WeChatWASM.SetStatusBarStyleOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.SetStatusBarStyle(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetUserCloudStorage_s(IntPtr l) {
		try {
			WeChatWASM.SetUserCloudStorageOption a1 = default(WeChatWASM.SetUserCloudStorageOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.SetUserCloudStorage(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ShowActionSheet_s(IntPtr l) {
		try {
			WeChatWASM.ShowActionSheetOption a1 = default(WeChatWASM.ShowActionSheetOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.ShowActionSheet(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ShowKeyboard_s(IntPtr l) {
		try {
			WeChatWASM.ShowKeyboardOption a1 = default(WeChatWASM.ShowKeyboardOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.ShowKeyboard(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ShowLoading_s(IntPtr l) {
		try {
			WeChatWASM.ShowLoadingOption a1 = default(WeChatWASM.ShowLoadingOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.ShowLoading(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ShowModal_s(IntPtr l) {
		try {
			WeChatWASM.ShowModalOption a1 = default(WeChatWASM.ShowModalOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.ShowModal(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ShowShareImageMenu_s(IntPtr l) {
		try {
			WeChatWASM.ShowShareImageMenuOption a1 = default(WeChatWASM.ShowShareImageMenuOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.ShowShareImageMenu(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ShowShareMenu_s(IntPtr l) {
		try {
			WeChatWASM.ShowShareMenuOption a1 = default(WeChatWASM.ShowShareMenuOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.ShowShareMenu(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ShowToast_s(IntPtr l) {
		try {
			WeChatWASM.ShowToastOption a1 = default(WeChatWASM.ShowToastOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.ShowToast(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StartAccelerometer_s(IntPtr l) {
		try {
			WeChatWASM.StartAccelerometerOption a1 = default(WeChatWASM.StartAccelerometerOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.StartAccelerometer(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StartBeaconDiscovery_s(IntPtr l) {
		try {
			WeChatWASM.StartBeaconDiscoveryOption a1 = default(WeChatWASM.StartBeaconDiscoveryOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.StartBeaconDiscovery(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StartBluetoothDevicesDiscovery_s(IntPtr l) {
		try {
			WeChatWASM.StartBluetoothDevicesDiscoveryOption a1 = default(WeChatWASM.StartBluetoothDevicesDiscoveryOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.StartBluetoothDevicesDiscovery(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StartCompass_s(IntPtr l) {
		try {
			WeChatWASM.StartCompassOption a1 = default(WeChatWASM.StartCompassOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.StartCompass(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StartDeviceMotionListening_s(IntPtr l) {
		try {
			WeChatWASM.StartDeviceMotionListeningOption a1 = default(WeChatWASM.StartDeviceMotionListeningOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.StartDeviceMotionListening(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StartGyroscope_s(IntPtr l) {
		try {
			WeChatWASM.StartGyroscopeOption a1 = default(WeChatWASM.StartGyroscopeOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.StartGyroscope(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StopAccelerometer_s(IntPtr l) {
		try {
			WeChatWASM.StopAccelerometerOption a1 = default(WeChatWASM.StopAccelerometerOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.StopAccelerometer(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StopBeaconDiscovery_s(IntPtr l) {
		try {
			WeChatWASM.StopBeaconDiscoveryOption a1 = default(WeChatWASM.StopBeaconDiscoveryOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.StopBeaconDiscovery(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StopBluetoothDevicesDiscovery_s(IntPtr l) {
		try {
			WeChatWASM.StopBluetoothDevicesDiscoveryOption a1 = default(WeChatWASM.StopBluetoothDevicesDiscoveryOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.StopBluetoothDevicesDiscovery(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StopCompass_s(IntPtr l) {
		try {
			WeChatWASM.StopCompassOption a1 = default(WeChatWASM.StopCompassOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.StopCompass(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StopDeviceMotionListening_s(IntPtr l) {
		try {
			WeChatWASM.StopDeviceMotionListeningOption a1 = default(WeChatWASM.StopDeviceMotionListeningOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.StopDeviceMotionListening(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StopFaceDetect_s(IntPtr l) {
		try {
			WeChatWASM.StopFaceDetectOption a1 = default(WeChatWASM.StopFaceDetectOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.StopFaceDetect(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StopGyroscope_s(IntPtr l) {
		try {
			WeChatWASM.StopGyroscopeOption a1 = default(WeChatWASM.StopGyroscopeOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.StopGyroscope(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int UpdateKeyboard_s(IntPtr l) {
		try {
			WeChatWASM.UpdateKeyboardOption a1 = default(WeChatWASM.UpdateKeyboardOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.UpdateKeyboard(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int UpdateShareMenu_s(IntPtr l) {
		try {
			WeChatWASM.UpdateShareMenuOption a1 = default(WeChatWASM.UpdateShareMenuOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.UpdateShareMenu(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int UpdateVoIPChatMuteConfig_s(IntPtr l) {
		try {
			WeChatWASM.UpdateVoIPChatMuteConfigOption a1 = default(WeChatWASM.UpdateVoIPChatMuteConfigOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.UpdateVoIPChatMuteConfig(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int UpdateWeChatApp_s(IntPtr l) {
		try {
			WeChatWASM.UpdateWeChatAppOption a1 = default(WeChatWASM.UpdateWeChatAppOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.UpdateWeChatApp(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int VibrateLong_s(IntPtr l) {
		try {
			WeChatWASM.VibrateLongOption a1 = default(WeChatWASM.VibrateLongOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.VibrateLong(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int VibrateShort_s(IntPtr l) {
		try {
			WeChatWASM.VibrateShortOption a1 = default(WeChatWASM.VibrateShortOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.VibrateShort(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WriteBLECharacteristicValue_s(IntPtr l) {
		try {
			WeChatWASM.WriteBLECharacteristicValueOption a1 = default(WeChatWASM.WriteBLECharacteristicValueOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.WriteBLECharacteristicValue(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StartGameLive_s(IntPtr l) {
		try {
			WeChatWASM.StartGameLiveOption a1 = default(WeChatWASM.StartGameLiveOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.StartGameLive(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CheckGameLiveEnabled_s(IntPtr l) {
		try {
			WeChatWASM.CheckGameLiveEnabledOption a1 = default(WeChatWASM.CheckGameLiveEnabledOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.CheckGameLiveEnabled(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetUserCurrentGameliveInfo_s(IntPtr l) {
		try {
			WeChatWASM.GetUserCurrentGameliveInfoOption a1 = default(WeChatWASM.GetUserCurrentGameliveInfoOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.GetUserCurrentGameliveInfo(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetUserRecentGameLiveInfo_s(IntPtr l) {
		try {
			WeChatWASM.GetUserRecentGameLiveInfoOption a1 = default(WeChatWASM.GetUserRecentGameLiveInfoOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.GetUserRecentGameLiveInfo(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetUserGameLiveDetails_s(IntPtr l) {
		try {
			WeChatWASM.GetUserGameLiveDetailsOption a1 = default(WeChatWASM.GetUserGameLiveDetailsOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.GetUserGameLiveDetails(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenChannelsLiveCollection_s(IntPtr l) {
		try {
			WeChatWASM.OpenChannelsLiveCollectionOption a1 = default(WeChatWASM.OpenChannelsLiveCollectionOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.OpenChannelsLiveCollection(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenPage_s(IntPtr l) {
		try {
			WeChatWASM.OpenPageOption a1 = default(WeChatWASM.OpenPageOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.OpenPage(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RequestMidasPaymentGameItem_s(IntPtr l) {
		try {
			WeChatWASM.RequestMidasPaymentGameItemOption a1 = default(WeChatWASM.RequestMidasPaymentGameItemOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.RequestMidasPaymentGameItem(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RequestSubscribeLiveActivity_s(IntPtr l) {
		try {
			WeChatWASM.RequestSubscribeLiveActivityOption a1 = default(WeChatWASM.RequestSubscribeLiveActivityOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.RequestSubscribeLiveActivity(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OperateGameRecorderVideo_s(IntPtr l) {
		try {
			WeChatWASM.OperateGameRecorderVideoOption a1 = default(WeChatWASM.OperateGameRecorderVideoOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.OperateGameRecorderVideo(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RemoveStorageSync_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			WeChatWASM.WX.RemoveStorageSync(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReportMonitor_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			System.Double a2 = default(System.Double);
			checkType(l,2,out a2);
			WeChatWASM.WX.ReportMonitor(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReportPerformance_s(IntPtr l) {
		try {
			System.Double a1 = default(System.Double);
			checkType(l,1,out a1);
			System.Double a2 = default(System.Double);
			checkType(l,2,out a2);
			System.String a3 = default(System.String);
			checkType(l,3,out a3);
			WeChatWASM.WX.ReportPerformance(a1,a2,a3);
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
			WeChatWASM.ReportUserBehaviorBranchAnalyticsOption a1 = default(WeChatWASM.ReportUserBehaviorBranchAnalyticsOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.ReportUserBehaviorBranchAnalytics(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReserveChannelsLive_s(IntPtr l) {
		try {
			WeChatWASM.ReserveChannelsLiveOption a1 = default(WeChatWASM.ReserveChannelsLiveOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.ReserveChannelsLive(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RevokeBufferURL_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			WeChatWASM.WX.RevokeBufferURL(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetPreferredFramesPerSecond_s(IntPtr l) {
		try {
			System.Double a1 = default(System.Double);
			checkType(l,1,out a1);
			WeChatWASM.WX.SetPreferredFramesPerSecond(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ShareAppMessage_s(IntPtr l) {
		try {
			WeChatWASM.ShareAppMessageOption a1 = default(WeChatWASM.ShareAppMessageOption);
			checkType(l,1,out a1);
			WeChatWASM.WX.ShareAppMessage(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int TriggerGC_s(IntPtr l) {
		try {
			WeChatWASM.WX.TriggerGC();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnAccelerometerChange_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnAccelerometerChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnAccelerometerChangeListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnAccelerometerChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffAccelerometerChange_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnAccelerometerChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnAccelerometerChangeListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffAccelerometerChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnAudioInterruptionBegin_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.GeneralCallbackResult> a1 = default(System.Action<WeChatWASM.GeneralCallbackResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnAudioInterruptionBegin(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffAudioInterruptionBegin_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.GeneralCallbackResult> a1 = default(System.Action<WeChatWASM.GeneralCallbackResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffAudioInterruptionBegin(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnAudioInterruptionEnd_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.GeneralCallbackResult> a1 = default(System.Action<WeChatWASM.GeneralCallbackResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnAudioInterruptionEnd(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffAudioInterruptionEnd_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.GeneralCallbackResult> a1 = default(System.Action<WeChatWASM.GeneralCallbackResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffAudioInterruptionEnd(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnBLECharacteristicValueChange_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnBLECharacteristicValueChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnBLECharacteristicValueChangeListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnBLECharacteristicValueChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffBLECharacteristicValueChange_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnBLECharacteristicValueChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnBLECharacteristicValueChangeListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffBLECharacteristicValueChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnBLEConnectionStateChange_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnBLEConnectionStateChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnBLEConnectionStateChangeListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnBLEConnectionStateChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffBLEConnectionStateChange_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnBLEConnectionStateChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnBLEConnectionStateChangeListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffBLEConnectionStateChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnBLEMTUChange_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnBLEMTUChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnBLEMTUChangeListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnBLEMTUChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffBLEMTUChange_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnBLEMTUChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnBLEMTUChangeListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffBLEMTUChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnBLEPeripheralConnectionStateChanged_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnBLEPeripheralConnectionStateChangedListenerResult> a1 = default(System.Action<WeChatWASM.OnBLEPeripheralConnectionStateChangedListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnBLEPeripheralConnectionStateChanged(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffBLEPeripheralConnectionStateChanged_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnBLEPeripheralConnectionStateChangedListenerResult> a1 = default(System.Action<WeChatWASM.OnBLEPeripheralConnectionStateChangedListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffBLEPeripheralConnectionStateChanged(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnBackgroundFetchData_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnBackgroundFetchDataListenerResult> a1 = default(System.Action<WeChatWASM.OnBackgroundFetchDataListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnBackgroundFetchData(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnBeaconServiceChange_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnBeaconServiceChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnBeaconServiceChangeListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnBeaconServiceChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffBeaconServiceChange_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnBeaconServiceChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnBeaconServiceChangeListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffBeaconServiceChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnBeaconUpdate_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnBeaconUpdateListenerResult> a1 = default(System.Action<WeChatWASM.OnBeaconUpdateListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnBeaconUpdate(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffBeaconUpdate_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnBeaconUpdateListenerResult> a1 = default(System.Action<WeChatWASM.OnBeaconUpdateListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffBeaconUpdate(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnBluetoothAdapterStateChange_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnBluetoothAdapterStateChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnBluetoothAdapterStateChangeListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnBluetoothAdapterStateChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffBluetoothAdapterStateChange_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnBluetoothAdapterStateChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnBluetoothAdapterStateChangeListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffBluetoothAdapterStateChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnBluetoothDeviceFound_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnBluetoothDeviceFoundListenerResult> a1 = default(System.Action<WeChatWASM.OnBluetoothDeviceFoundListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnBluetoothDeviceFound(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffBluetoothDeviceFound_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnBluetoothDeviceFoundListenerResult> a1 = default(System.Action<WeChatWASM.OnBluetoothDeviceFoundListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffBluetoothDeviceFound(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnCompassChange_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnCompassChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnCompassChangeListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnCompassChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffCompassChange_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnCompassChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnCompassChangeListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffCompassChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnDeviceMotionChange_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnDeviceMotionChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnDeviceMotionChangeListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnDeviceMotionChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffDeviceMotionChange_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnDeviceMotionChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnDeviceMotionChangeListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffDeviceMotionChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnDeviceOrientationChange_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnDeviceOrientationChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnDeviceOrientationChangeListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnDeviceOrientationChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffDeviceOrientationChange_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnDeviceOrientationChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnDeviceOrientationChangeListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffDeviceOrientationChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnError_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.WxOnErrorCallbackResult> a1 = default(System.Action<WeChatWASM.WxOnErrorCallbackResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnError(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffError_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.WxOnErrorCallbackResult> a1 = default(System.Action<WeChatWASM.WxOnErrorCallbackResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffError(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnGyroscopeChange_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnGyroscopeChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnGyroscopeChangeListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnGyroscopeChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffGyroscopeChange_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnGyroscopeChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnGyroscopeChangeListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffGyroscopeChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnHide_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.GeneralCallbackResult> a1 = default(System.Action<WeChatWASM.GeneralCallbackResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnHide(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffHide_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.GeneralCallbackResult> a1 = default(System.Action<WeChatWASM.GeneralCallbackResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffHide(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnInteractiveStorageModified_s(IntPtr l) {
		try {
			System.Action<System.String> a1 = default(System.Action<System.String>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnInteractiveStorageModified(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffInteractiveStorageModified_s(IntPtr l) {
		try {
			System.Action<System.String> a1 = default(System.Action<System.String>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffInteractiveStorageModified(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnKeyDown_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnKeyDownListenerResult> a1 = default(System.Action<WeChatWASM.OnKeyDownListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnKeyDown(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffKeyDown_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnKeyDownListenerResult> a1 = default(System.Action<WeChatWASM.OnKeyDownListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffKeyDown(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnKeyUp_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnKeyDownListenerResult> a1 = default(System.Action<WeChatWASM.OnKeyDownListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnKeyUp(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffKeyUp_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnKeyDownListenerResult> a1 = default(System.Action<WeChatWASM.OnKeyDownListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffKeyUp(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnKeyboardComplete_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnKeyboardInputListenerResult> a1 = default(System.Action<WeChatWASM.OnKeyboardInputListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnKeyboardComplete(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffKeyboardComplete_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnKeyboardInputListenerResult> a1 = default(System.Action<WeChatWASM.OnKeyboardInputListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffKeyboardComplete(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnKeyboardConfirm_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnKeyboardInputListenerResult> a1 = default(System.Action<WeChatWASM.OnKeyboardInputListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnKeyboardConfirm(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffKeyboardConfirm_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnKeyboardInputListenerResult> a1 = default(System.Action<WeChatWASM.OnKeyboardInputListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffKeyboardConfirm(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnKeyboardHeightChange_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnKeyboardHeightChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnKeyboardHeightChangeListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnKeyboardHeightChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffKeyboardHeightChange_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnKeyboardHeightChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnKeyboardHeightChangeListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffKeyboardHeightChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnKeyboardInput_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnKeyboardInputListenerResult> a1 = default(System.Action<WeChatWASM.OnKeyboardInputListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnKeyboardInput(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffKeyboardInput_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnKeyboardInputListenerResult> a1 = default(System.Action<WeChatWASM.OnKeyboardInputListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffKeyboardInput(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnMemoryWarning_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnMemoryWarningListenerResult> a1 = default(System.Action<WeChatWASM.OnMemoryWarningListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnMemoryWarning(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffMemoryWarning_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnMemoryWarningListenerResult> a1 = default(System.Action<WeChatWASM.OnMemoryWarningListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffMemoryWarning(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnMessage_s(IntPtr l) {
		try {
			System.Action<System.String> a1 = default(System.Action<System.String>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnMessage(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnMouseDown_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnMouseDownListenerResult> a1 = default(System.Action<WeChatWASM.OnMouseDownListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnMouseDown(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffMouseDown_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnMouseDownListenerResult> a1 = default(System.Action<WeChatWASM.OnMouseDownListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffMouseDown(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnMouseMove_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnMouseMoveListenerResult> a1 = default(System.Action<WeChatWASM.OnMouseMoveListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnMouseMove(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffMouseMove_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnMouseMoveListenerResult> a1 = default(System.Action<WeChatWASM.OnMouseMoveListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffMouseMove(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnMouseUp_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnMouseDownListenerResult> a1 = default(System.Action<WeChatWASM.OnMouseDownListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnMouseUp(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffMouseUp_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnMouseDownListenerResult> a1 = default(System.Action<WeChatWASM.OnMouseDownListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffMouseUp(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnNetworkStatusChange_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnNetworkStatusChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnNetworkStatusChangeListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnNetworkStatusChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffNetworkStatusChange_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnNetworkStatusChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnNetworkStatusChangeListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffNetworkStatusChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnNetworkWeakChange_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnNetworkWeakChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnNetworkWeakChangeListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnNetworkWeakChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffNetworkWeakChange_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnNetworkWeakChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnNetworkWeakChangeListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffNetworkWeakChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnShareMessageToFriend_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnShareMessageToFriendListenerResult> a1 = default(System.Action<WeChatWASM.OnShareMessageToFriendListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnShareMessageToFriend(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnShow_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnShowListenerResult> a1 = default(System.Action<WeChatWASM.OnShowListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnShow(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffShow_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnShowListenerResult> a1 = default(System.Action<WeChatWASM.OnShowListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffShow(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnTouchCancel_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnTouchStartListenerResult> a1 = default(System.Action<WeChatWASM.OnTouchStartListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnTouchCancel(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffTouchCancel_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnTouchStartListenerResult> a1 = default(System.Action<WeChatWASM.OnTouchStartListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffTouchCancel(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnTouchEnd_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnTouchStartListenerResult> a1 = default(System.Action<WeChatWASM.OnTouchStartListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnTouchEnd(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffTouchEnd_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnTouchStartListenerResult> a1 = default(System.Action<WeChatWASM.OnTouchStartListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffTouchEnd(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnTouchMove_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnTouchStartListenerResult> a1 = default(System.Action<WeChatWASM.OnTouchStartListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnTouchMove(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffTouchMove_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnTouchStartListenerResult> a1 = default(System.Action<WeChatWASM.OnTouchStartListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffTouchMove(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnTouchStart_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnTouchStartListenerResult> a1 = default(System.Action<WeChatWASM.OnTouchStartListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnTouchStart(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffTouchStart_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnTouchStartListenerResult> a1 = default(System.Action<WeChatWASM.OnTouchStartListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffTouchStart(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnUnhandledRejection_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnUnhandledRejectionListenerResult> a1 = default(System.Action<WeChatWASM.OnUnhandledRejectionListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnUnhandledRejection(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffUnhandledRejection_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnUnhandledRejectionListenerResult> a1 = default(System.Action<WeChatWASM.OnUnhandledRejectionListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffUnhandledRejection(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnUserCaptureScreen_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.GeneralCallbackResult> a1 = default(System.Action<WeChatWASM.GeneralCallbackResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnUserCaptureScreen(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffUserCaptureScreen_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.GeneralCallbackResult> a1 = default(System.Action<WeChatWASM.GeneralCallbackResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffUserCaptureScreen(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnVoIPChatInterrupted_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnVoIPChatInterruptedListenerResult> a1 = default(System.Action<WeChatWASM.OnVoIPChatInterruptedListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnVoIPChatInterrupted(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffVoIPChatInterrupted_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnVoIPChatInterruptedListenerResult> a1 = default(System.Action<WeChatWASM.OnVoIPChatInterruptedListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffVoIPChatInterrupted(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnVoIPChatMembersChanged_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnVoIPChatMembersChangedListenerResult> a1 = default(System.Action<WeChatWASM.OnVoIPChatMembersChangedListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnVoIPChatMembersChanged(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffVoIPChatMembersChanged_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnVoIPChatMembersChangedListenerResult> a1 = default(System.Action<WeChatWASM.OnVoIPChatMembersChangedListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffVoIPChatMembersChanged(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnVoIPChatSpeakersChanged_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnVoIPChatSpeakersChangedListenerResult> a1 = default(System.Action<WeChatWASM.OnVoIPChatSpeakersChangedListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnVoIPChatSpeakersChanged(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffVoIPChatSpeakersChanged_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnVoIPChatSpeakersChangedListenerResult> a1 = default(System.Action<WeChatWASM.OnVoIPChatSpeakersChangedListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffVoIPChatSpeakersChanged(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnVoIPChatStateChanged_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnVoIPChatStateChangedListenerResult> a1 = default(System.Action<WeChatWASM.OnVoIPChatStateChangedListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnVoIPChatStateChanged(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffVoIPChatStateChanged_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnVoIPChatStateChangedListenerResult> a1 = default(System.Action<WeChatWASM.OnVoIPChatStateChangedListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffVoIPChatStateChanged(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnWheel_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnWheelListenerResult> a1 = default(System.Action<WeChatWASM.OnWheelListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnWheel(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffWheel_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnWheelListenerResult> a1 = default(System.Action<WeChatWASM.OnWheelListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffWheel(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnWindowResize_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnWindowResizeListenerResult> a1 = default(System.Action<WeChatWASM.OnWindowResizeListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnWindowResize(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffWindowResize_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnWindowResizeListenerResult> a1 = default(System.Action<WeChatWASM.OnWindowResizeListenerResult>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffWindowResize(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnAddToFavorites_s(IntPtr l) {
		try {
			System.Action<System.Action<WeChatWASM.OnAddToFavoritesListenerResult>> a1 = default(System.Action<System.Action<WeChatWASM.OnAddToFavoritesListenerResult>>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnAddToFavorites(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffAddToFavorites_s(IntPtr l) {
		try {
			System.Action<System.Action<WeChatWASM.OnAddToFavoritesListenerResult>> a1 = default(System.Action<System.Action<WeChatWASM.OnAddToFavoritesListenerResult>>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffAddToFavorites(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnCopyUrl_s(IntPtr l) {
		try {
			System.Action<System.Action<WeChatWASM.OnCopyUrlListenerResult>> a1 = default(System.Action<System.Action<WeChatWASM.OnCopyUrlListenerResult>>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnCopyUrl(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffCopyUrl_s(IntPtr l) {
		try {
			System.Action<System.Action<WeChatWASM.OnCopyUrlListenerResult>> a1 = default(System.Action<System.Action<WeChatWASM.OnCopyUrlListenerResult>>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffCopyUrl(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnHandoff_s(IntPtr l) {
		try {
			System.Action<System.Action<WeChatWASM.OnHandoffListenerResult>> a1 = default(System.Action<System.Action<WeChatWASM.OnHandoffListenerResult>>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnHandoff(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffHandoff_s(IntPtr l) {
		try {
			System.Action<System.Action<WeChatWASM.OnHandoffListenerResult>> a1 = default(System.Action<System.Action<WeChatWASM.OnHandoffListenerResult>>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffHandoff(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnShareTimeline_s(IntPtr l) {
		try {
			System.Action<System.Action<WeChatWASM.OnShareTimelineListenerResult>> a1 = default(System.Action<System.Action<WeChatWASM.OnShareTimelineListenerResult>>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnShareTimeline(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffShareTimeline_s(IntPtr l) {
		try {
			System.Action<System.Action<WeChatWASM.OnShareTimelineListenerResult>> a1 = default(System.Action<System.Action<WeChatWASM.OnShareTimelineListenerResult>>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffShareTimeline(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnGameLiveStateChange_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnGameLiveStateChangeCallbackResult,System.Action<WeChatWASM.OnGameLiveStateChangeCallbackResponse>> a1 = default(System.Action<WeChatWASM.OnGameLiveStateChangeCallbackResult,System.Action<WeChatWASM.OnGameLiveStateChangeCallbackResponse>>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OnGameLiveStateChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffGameLiveStateChange_s(IntPtr l) {
		try {
			System.Action<WeChatWASM.OnGameLiveStateChangeCallbackResult,System.Action<WeChatWASM.OnGameLiveStateChangeCallbackResponse>> a1 = default(System.Action<WeChatWASM.OnGameLiveStateChangeCallbackResult,System.Action<WeChatWASM.OnGameLiveStateChangeCallbackResponse>>);
			checkDelegate(l,1,out a1);
			WeChatWASM.WX.OffGameLiveStateChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetHandoffQuery_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			var ret=WeChatWASM.WX.SetHandoffQuery(a1);
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
	static public int GetAccountInfoSync_s(IntPtr l) {
		try {
			var ret=WeChatWASM.WX.GetAccountInfoSync();
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
	static public int GetAppAuthorizeSetting_s(IntPtr l) {
		try {
			var ret=WeChatWASM.WX.GetAppAuthorizeSetting();
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
	static public int GetAppBaseInfo_s(IntPtr l) {
		try {
			var ret=WeChatWASM.WX.GetAppBaseInfo();
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
	static public int GetBatteryInfoSync_s(IntPtr l) {
		try {
			var ret=WeChatWASM.WX.GetBatteryInfoSync();
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
	static public int GetDeviceInfo_s(IntPtr l) {
		try {
			var ret=WeChatWASM.WX.GetDeviceInfo();
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
	static public int GetEnterOptionsSync_s(IntPtr l) {
		try {
			var ret=WeChatWASM.WX.GetEnterOptionsSync();
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
	static public int GetLaunchOptionsSync_s(IntPtr l) {
		try {
			var ret=WeChatWASM.WX.GetLaunchOptionsSync();
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
	static public int GetMenuButtonBoundingClientRect_s(IntPtr l) {
		try {
			var ret=WeChatWASM.WX.GetMenuButtonBoundingClientRect();
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
	static public int GetStorageInfoSync_s(IntPtr l) {
		try {
			var ret=WeChatWASM.WX.GetStorageInfoSync();
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
	static public int GetSystemInfoSync_s(IntPtr l) {
		try {
			var ret=WeChatWASM.WX.GetSystemInfoSync();
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
	static public int GetSystemSetting_s(IntPtr l) {
		try {
			var ret=WeChatWASM.WX.GetSystemSetting();
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
	static public int GetWindowInfo_s(IntPtr l) {
		try {
			var ret=WeChatWASM.WX.GetWindowInfo();
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
	static public int CreateImageData_s(IntPtr l) {
		try {
			var ret=WeChatWASM.WX.CreateImageData();
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
	static public int CreatePath2D_s(IntPtr l) {
		try {
			var ret=WeChatWASM.WX.CreatePath2D();
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
	static public int SetCursor_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			System.Double a2 = default(System.Double);
			checkType(l,2,out a2);
			System.Double a3 = default(System.Double);
			checkType(l,3,out a3);
			var ret=WeChatWASM.WX.SetCursor(a1,a2,a3);
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
	static public int SetMessageToFriendQuery_s(IntPtr l) {
		try {
			WeChatWASM.SetMessageToFriendQueryOption a1 = default(WeChatWASM.SetMessageToFriendQueryOption);
			checkType(l,1,out a1);
			var ret=WeChatWASM.WX.SetMessageToFriendQuery(a1);
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
	static public int GetTextLineHeight_s(IntPtr l) {
		try {
			WeChatWASM.GetTextLineHeightOption a1 = default(WeChatWASM.GetTextLineHeightOption);
			checkType(l,1,out a1);
			var ret=WeChatWASM.WX.GetTextLineHeight(a1);
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
	static public int LoadFont_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			var ret=WeChatWASM.WX.LoadFont(a1);
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
	static public int GetGameLiveState_s(IntPtr l) {
		try {
			var ret=WeChatWASM.WX.GetGameLiveState();
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
	static public int DownloadFile_s(IntPtr l) {
		try {
			WeChatWASM.DownloadFileOption a1 = default(WeChatWASM.DownloadFileOption);
			checkType(l,1,out a1);
			var ret=WeChatWASM.WX.DownloadFile(a1);
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
	static public int CreateFeedbackButton_s(IntPtr l) {
		try {
			WeChatWASM.CreateOpenSettingButtonOption a1 = default(WeChatWASM.CreateOpenSettingButtonOption);
			checkType(l,1,out a1);
			var ret=WeChatWASM.WX.CreateFeedbackButton(a1);
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
	static public int GetLogManager_s(IntPtr l) {
		try {
			WeChatWASM.GetLogManagerOption a1 = default(WeChatWASM.GetLogManagerOption);
			checkType(l,1,out a1);
			var ret=WeChatWASM.WX.GetLogManager(a1);
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
	static public int GetRealtimeLogManager_s(IntPtr l) {
		try {
			var ret=WeChatWASM.WX.GetRealtimeLogManager();
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
	static public int GetUpdateManager_s(IntPtr l) {
		try {
			var ret=WeChatWASM.WX.GetUpdateManager();
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
	static public int CreateVideoDecoder_s(IntPtr l) {
		try {
			var ret=WeChatWASM.WX.CreateVideoDecoder();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WX");
		addMember(l,AddCard_s);
		addMember(l,AuthPrivateMessage_s);
		addMember(l,Authorize_s);
		addMember(l,CheckIsAddedToMyMiniProgram_s);
		addMember(l,CheckSession_s);
		addMember(l,ChooseImage_s);
		addMember(l,ChooseMedia_s);
		addMember(l,ChooseMessageFile_s);
		addMember(l,CloseBLEConnection_s);
		addMember(l,CloseBluetoothAdapter_s);
		addMember(l,CompressImage_s);
		addMember(l,CreateBLEConnection_s);
		addMember(l,CreateBLEPeripheralServer_s);
		addMember(l,ExitMiniProgram_s);
		addMember(l,ExitVoIPChat_s);
		addMember(l,FaceDetect_s);
		addMember(l,GetAvailableAudioSources_s);
		addMember(l,GetBLEDeviceCharacteristics_s);
		addMember(l,GetBLEDeviceRSSI_s);
		addMember(l,GetBLEDeviceServices_s);
		addMember(l,GetBLEMTU_s);
		addMember(l,GetBackgroundFetchData_s);
		addMember(l,GetBackgroundFetchToken_s);
		addMember(l,GetBatteryInfo_s);
		addMember(l,GetBeacons_s);
		addMember(l,GetBluetoothAdapterState_s);
		addMember(l,GetBluetoothDevices_s);
		addMember(l,GetChannelsLiveInfo_s);
		addMember(l,GetChannelsLiveNoticeInfo_s);
		addMember(l,GetClipboardData_s);
		addMember(l,GetConnectedBluetoothDevices_s);
		addMember(l,GetExtConfig_s);
		addMember(l,GetFuzzyLocation_s);
		addMember(l,GetGameClubData_s);
		addMember(l,GetGroupEnterInfo_s);
		addMember(l,GetInferenceEnvInfo_s);
		addMember(l,GetLocalIPAddress_s);
		addMember(l,GetLocation_s);
		addMember(l,GetNetworkType_s);
		addMember(l,GetPrivacySetting_s);
		addMember(l,GetScreenBrightness_s);
		addMember(l,GetSetting_s);
		addMember(l,GetShareInfo_s);
		addMember(l,GetStorageInfo_s);
		addMember(l,GetSystemInfo_s);
		addMember(l,GetSystemInfoAsync_s);
		addMember(l,GetUserInfo_s);
		addMember(l,GetUserInteractiveStorage_s);
		addMember(l,GetWeRunData_s);
		addMember(l,HideKeyboard_s);
		addMember(l,HideLoading_s);
		addMember(l,HideShareMenu_s);
		addMember(l,HideToast_s);
		addMember(l,InitFaceDetect_s);
		addMember(l,IsBluetoothDevicePaired_s);
		addMember(l,JoinVoIPChat_s);
		addMember(l,Login_s);
		addMember(l,MakeBluetoothPair_s);
		addMember(l,NavigateToMiniProgram_s);
		addMember(l,NotifyBLECharacteristicValueChange_s);
		addMember(l,OpenAppAuthorizeSetting_s);
		addMember(l,OpenBluetoothAdapter_s);
		addMember(l,OpenCard_s);
		addMember(l,OpenChannelsActivity_s);
		addMember(l,OpenChannelsEvent_s);
		addMember(l,OpenChannelsLive_s);
		addMember(l,OpenChannelsUserProfile_s);
		addMember(l,OpenCustomerServiceChat_s);
		addMember(l,OpenCustomerServiceConversation_s);
		addMember(l,OpenPrivacyContract_s);
		addMember(l,OpenSetting_s);
		addMember(l,OpenSystemBluetoothSetting_s);
		addMember(l,PreviewImage_s);
		addMember(l,PreviewMedia_s);
		addMember(l,ReadBLECharacteristicValue_s);
		addMember(l,RemoveStorage_s);
		addMember(l,RemoveUserCloudStorage_s);
		addMember(l,ReportScene_s);
		addMember(l,RequestMidasFriendPayment_s);
		addMember(l,RequestMidasPayment_s);
		addMember(l,RequestSubscribeMessage_s);
		addMember(l,RequestSubscribeSystemMessage_s);
		addMember(l,RequirePrivacyAuthorize_s);
		addMember(l,RestartMiniProgram_s);
		addMember(l,SaveFileToDisk_s);
		addMember(l,SaveImageToPhotosAlbum_s);
		addMember(l,ScanCode_s);
		addMember(l,SetBLEMTU_s);
		addMember(l,SetBackgroundFetchToken_s);
		addMember(l,SetClipboardData_s);
		addMember(l,SetDeviceOrientation_s);
		addMember(l,SetEnableDebug_s);
		addMember(l,SetInnerAudioOption_s);
		addMember(l,SetKeepScreenOn_s);
		addMember(l,SetMenuStyle_s);
		addMember(l,SetScreenBrightness_s);
		addMember(l,SetStatusBarStyle_s);
		addMember(l,SetUserCloudStorage_s);
		addMember(l,ShowActionSheet_s);
		addMember(l,ShowKeyboard_s);
		addMember(l,ShowLoading_s);
		addMember(l,ShowModal_s);
		addMember(l,ShowShareImageMenu_s);
		addMember(l,ShowShareMenu_s);
		addMember(l,ShowToast_s);
		addMember(l,StartAccelerometer_s);
		addMember(l,StartBeaconDiscovery_s);
		addMember(l,StartBluetoothDevicesDiscovery_s);
		addMember(l,StartCompass_s);
		addMember(l,StartDeviceMotionListening_s);
		addMember(l,StartGyroscope_s);
		addMember(l,StopAccelerometer_s);
		addMember(l,StopBeaconDiscovery_s);
		addMember(l,StopBluetoothDevicesDiscovery_s);
		addMember(l,StopCompass_s);
		addMember(l,StopDeviceMotionListening_s);
		addMember(l,StopFaceDetect_s);
		addMember(l,StopGyroscope_s);
		addMember(l,UpdateKeyboard_s);
		addMember(l,UpdateShareMenu_s);
		addMember(l,UpdateVoIPChatMuteConfig_s);
		addMember(l,UpdateWeChatApp_s);
		addMember(l,VibrateLong_s);
		addMember(l,VibrateShort_s);
		addMember(l,WriteBLECharacteristicValue_s);
		addMember(l,StartGameLive_s);
		addMember(l,CheckGameLiveEnabled_s);
		addMember(l,GetUserCurrentGameliveInfo_s);
		addMember(l,GetUserRecentGameLiveInfo_s);
		addMember(l,GetUserGameLiveDetails_s);
		addMember(l,OpenChannelsLiveCollection_s);
		addMember(l,OpenPage_s);
		addMember(l,RequestMidasPaymentGameItem_s);
		addMember(l,RequestSubscribeLiveActivity_s);
		addMember(l,OperateGameRecorderVideo_s);
		addMember(l,RemoveStorageSync_s);
		addMember(l,ReportMonitor_s);
		addMember(l,ReportPerformance_s);
		addMember(l,ReportUserBehaviorBranchAnalytics_s);
		addMember(l,ReserveChannelsLive_s);
		addMember(l,RevokeBufferURL_s);
		addMember(l,SetPreferredFramesPerSecond_s);
		addMember(l,ShareAppMessage_s);
		addMember(l,TriggerGC_s);
		addMember(l,OnAccelerometerChange_s);
		addMember(l,OffAccelerometerChange_s);
		addMember(l,OnAudioInterruptionBegin_s);
		addMember(l,OffAudioInterruptionBegin_s);
		addMember(l,OnAudioInterruptionEnd_s);
		addMember(l,OffAudioInterruptionEnd_s);
		addMember(l,OnBLECharacteristicValueChange_s);
		addMember(l,OffBLECharacteristicValueChange_s);
		addMember(l,OnBLEConnectionStateChange_s);
		addMember(l,OffBLEConnectionStateChange_s);
		addMember(l,OnBLEMTUChange_s);
		addMember(l,OffBLEMTUChange_s);
		addMember(l,OnBLEPeripheralConnectionStateChanged_s);
		addMember(l,OffBLEPeripheralConnectionStateChanged_s);
		addMember(l,OnBackgroundFetchData_s);
		addMember(l,OnBeaconServiceChange_s);
		addMember(l,OffBeaconServiceChange_s);
		addMember(l,OnBeaconUpdate_s);
		addMember(l,OffBeaconUpdate_s);
		addMember(l,OnBluetoothAdapterStateChange_s);
		addMember(l,OffBluetoothAdapterStateChange_s);
		addMember(l,OnBluetoothDeviceFound_s);
		addMember(l,OffBluetoothDeviceFound_s);
		addMember(l,OnCompassChange_s);
		addMember(l,OffCompassChange_s);
		addMember(l,OnDeviceMotionChange_s);
		addMember(l,OffDeviceMotionChange_s);
		addMember(l,OnDeviceOrientationChange_s);
		addMember(l,OffDeviceOrientationChange_s);
		addMember(l,OnError_s);
		addMember(l,OffError_s);
		addMember(l,OnGyroscopeChange_s);
		addMember(l,OffGyroscopeChange_s);
		addMember(l,OnHide_s);
		addMember(l,OffHide_s);
		addMember(l,OnInteractiveStorageModified_s);
		addMember(l,OffInteractiveStorageModified_s);
		addMember(l,OnKeyDown_s);
		addMember(l,OffKeyDown_s);
		addMember(l,OnKeyUp_s);
		addMember(l,OffKeyUp_s);
		addMember(l,OnKeyboardComplete_s);
		addMember(l,OffKeyboardComplete_s);
		addMember(l,OnKeyboardConfirm_s);
		addMember(l,OffKeyboardConfirm_s);
		addMember(l,OnKeyboardHeightChange_s);
		addMember(l,OffKeyboardHeightChange_s);
		addMember(l,OnKeyboardInput_s);
		addMember(l,OffKeyboardInput_s);
		addMember(l,OnMemoryWarning_s);
		addMember(l,OffMemoryWarning_s);
		addMember(l,OnMessage_s);
		addMember(l,OnMouseDown_s);
		addMember(l,OffMouseDown_s);
		addMember(l,OnMouseMove_s);
		addMember(l,OffMouseMove_s);
		addMember(l,OnMouseUp_s);
		addMember(l,OffMouseUp_s);
		addMember(l,OnNetworkStatusChange_s);
		addMember(l,OffNetworkStatusChange_s);
		addMember(l,OnNetworkWeakChange_s);
		addMember(l,OffNetworkWeakChange_s);
		addMember(l,OnShareMessageToFriend_s);
		addMember(l,OnShow_s);
		addMember(l,OffShow_s);
		addMember(l,OnTouchCancel_s);
		addMember(l,OffTouchCancel_s);
		addMember(l,OnTouchEnd_s);
		addMember(l,OffTouchEnd_s);
		addMember(l,OnTouchMove_s);
		addMember(l,OffTouchMove_s);
		addMember(l,OnTouchStart_s);
		addMember(l,OffTouchStart_s);
		addMember(l,OnUnhandledRejection_s);
		addMember(l,OffUnhandledRejection_s);
		addMember(l,OnUserCaptureScreen_s);
		addMember(l,OffUserCaptureScreen_s);
		addMember(l,OnVoIPChatInterrupted_s);
		addMember(l,OffVoIPChatInterrupted_s);
		addMember(l,OnVoIPChatMembersChanged_s);
		addMember(l,OffVoIPChatMembersChanged_s);
		addMember(l,OnVoIPChatSpeakersChanged_s);
		addMember(l,OffVoIPChatSpeakersChanged_s);
		addMember(l,OnVoIPChatStateChanged_s);
		addMember(l,OffVoIPChatStateChanged_s);
		addMember(l,OnWheel_s);
		addMember(l,OffWheel_s);
		addMember(l,OnWindowResize_s);
		addMember(l,OffWindowResize_s);
		addMember(l,OnAddToFavorites_s);
		addMember(l,OffAddToFavorites_s);
		addMember(l,OnCopyUrl_s);
		addMember(l,OffCopyUrl_s);
		addMember(l,OnHandoff_s);
		addMember(l,OffHandoff_s);
		addMember(l,OnShareTimeline_s);
		addMember(l,OffShareTimeline_s);
		addMember(l,OnGameLiveStateChange_s);
		addMember(l,OffGameLiveStateChange_s);
		addMember(l,SetHandoffQuery_s);
		addMember(l,GetAccountInfoSync_s);
		addMember(l,GetAppAuthorizeSetting_s);
		addMember(l,GetAppBaseInfo_s);
		addMember(l,GetBatteryInfoSync_s);
		addMember(l,GetDeviceInfo_s);
		addMember(l,GetEnterOptionsSync_s);
		addMember(l,GetLaunchOptionsSync_s);
		addMember(l,GetMenuButtonBoundingClientRect_s);
		addMember(l,GetStorageInfoSync_s);
		addMember(l,GetSystemInfoSync_s);
		addMember(l,GetSystemSetting_s);
		addMember(l,GetWindowInfo_s);
		addMember(l,CreateImageData_s);
		addMember(l,CreatePath2D_s);
		addMember(l,SetCursor_s);
		addMember(l,SetMessageToFriendQuery_s);
		addMember(l,GetTextLineHeight_s);
		addMember(l,LoadFont_s);
		addMember(l,GetGameLiveState_s);
		addMember(l,DownloadFile_s);
		addMember(l,CreateFeedbackButton_s);
		addMember(l,GetLogManager_s);
		addMember(l,GetRealtimeLogManager_s);
		addMember(l,GetUpdateManager_s);
		addMember(l,CreateVideoDecoder_s);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WX),typeof(WeChatWASM.WXBase));
	}
}
#endif