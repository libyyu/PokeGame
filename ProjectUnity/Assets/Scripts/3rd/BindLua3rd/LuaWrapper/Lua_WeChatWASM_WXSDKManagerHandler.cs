//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXSDKManagerHandler : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AddCardCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.AddCardCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AddCard(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.AddCardOption a1 = default(WeChatWASM.AddCardOption);
			checkType(l,2,out a1);
			self.AddCard(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AuthPrivateMessageCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.AuthPrivateMessageCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AuthPrivateMessage(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.AuthPrivateMessageOption a1 = default(WeChatWASM.AuthPrivateMessageOption);
			checkType(l,2,out a1);
			self.AuthPrivateMessage(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AuthorizeCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.AuthorizeCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Authorize(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.AuthorizeOption a1 = default(WeChatWASM.AuthorizeOption);
			checkType(l,2,out a1);
			self.Authorize(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CheckIsAddedToMyMiniProgramCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.CheckIsAddedToMyMiniProgramCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CheckIsAddedToMyMiniProgram(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.CheckIsAddedToMyMiniProgramOption a1 = default(WeChatWASM.CheckIsAddedToMyMiniProgramOption);
			checkType(l,2,out a1);
			self.CheckIsAddedToMyMiniProgram(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CheckSessionCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.CheckSessionCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CheckSession(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.CheckSessionOption a1 = default(WeChatWASM.CheckSessionOption);
			checkType(l,2,out a1);
			self.CheckSession(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ChooseImageCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.ChooseImageCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ChooseImage(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.ChooseImageOption a1 = default(WeChatWASM.ChooseImageOption);
			checkType(l,2,out a1);
			self.ChooseImage(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ChooseMediaCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.ChooseMediaCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ChooseMedia(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.ChooseMediaOption a1 = default(WeChatWASM.ChooseMediaOption);
			checkType(l,2,out a1);
			self.ChooseMedia(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ChooseMessageFileCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.ChooseMessageFileCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ChooseMessageFile(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.ChooseMessageFileOption a1 = default(WeChatWASM.ChooseMessageFileOption);
			checkType(l,2,out a1);
			self.ChooseMessageFile(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CloseBLEConnectionCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.CloseBLEConnectionCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CloseBLEConnection(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.CloseBLEConnectionOption a1 = default(WeChatWASM.CloseBLEConnectionOption);
			checkType(l,2,out a1);
			self.CloseBLEConnection(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CloseBluetoothAdapterCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.CloseBluetoothAdapterCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CloseBluetoothAdapter(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.CloseBluetoothAdapterOption a1 = default(WeChatWASM.CloseBluetoothAdapterOption);
			checkType(l,2,out a1);
			self.CloseBluetoothAdapter(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CompressImageCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.CompressImageCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CompressImage(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.CompressImageOption a1 = default(WeChatWASM.CompressImageOption);
			checkType(l,2,out a1);
			self.CompressImage(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CreateBLEConnectionCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.CreateBLEConnectionCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CreateBLEConnection(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.CreateBLEConnectionOption a1 = default(WeChatWASM.CreateBLEConnectionOption);
			checkType(l,2,out a1);
			self.CreateBLEConnection(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CreateBLEPeripheralServerCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.CreateBLEPeripheralServerCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CreateBLEPeripheralServer(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.CreateBLEPeripheralServerOption a1 = default(WeChatWASM.CreateBLEPeripheralServerOption);
			checkType(l,2,out a1);
			self.CreateBLEPeripheralServer(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ExitMiniProgramCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.ExitMiniProgramCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ExitMiniProgram(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.ExitMiniProgramOption a1 = default(WeChatWASM.ExitMiniProgramOption);
			checkType(l,2,out a1);
			self.ExitMiniProgram(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ExitVoIPChatCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.ExitVoIPChatCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ExitVoIPChat(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.ExitVoIPChatOption a1 = default(WeChatWASM.ExitVoIPChatOption);
			checkType(l,2,out a1);
			self.ExitVoIPChat(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int FaceDetectCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.FaceDetectCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int FaceDetect(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.FaceDetectOption a1 = default(WeChatWASM.FaceDetectOption);
			checkType(l,2,out a1);
			self.FaceDetect(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetAvailableAudioSourcesCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.GetAvailableAudioSourcesCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetAvailableAudioSources(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.GetAvailableAudioSourcesOption a1 = default(WeChatWASM.GetAvailableAudioSourcesOption);
			checkType(l,2,out a1);
			self.GetAvailableAudioSources(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBLEDeviceCharacteristicsCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.GetBLEDeviceCharacteristicsCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBLEDeviceCharacteristics(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.GetBLEDeviceCharacteristicsOption a1 = default(WeChatWASM.GetBLEDeviceCharacteristicsOption);
			checkType(l,2,out a1);
			self.GetBLEDeviceCharacteristics(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBLEDeviceRSSICallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.GetBLEDeviceRSSICallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBLEDeviceRSSI(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.GetBLEDeviceRSSIOption a1 = default(WeChatWASM.GetBLEDeviceRSSIOption);
			checkType(l,2,out a1);
			self.GetBLEDeviceRSSI(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBLEDeviceServicesCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.GetBLEDeviceServicesCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBLEDeviceServices(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.GetBLEDeviceServicesOption a1 = default(WeChatWASM.GetBLEDeviceServicesOption);
			checkType(l,2,out a1);
			self.GetBLEDeviceServices(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBLEMTUCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.GetBLEMTUCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBLEMTU(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.GetBLEMTUOption a1 = default(WeChatWASM.GetBLEMTUOption);
			checkType(l,2,out a1);
			self.GetBLEMTU(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBackgroundFetchDataCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.GetBackgroundFetchDataCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBackgroundFetchData(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.GetBackgroundFetchDataOption a1 = default(WeChatWASM.GetBackgroundFetchDataOption);
			checkType(l,2,out a1);
			self.GetBackgroundFetchData(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBackgroundFetchTokenCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.GetBackgroundFetchTokenCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBackgroundFetchToken(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.GetBackgroundFetchTokenOption a1 = default(WeChatWASM.GetBackgroundFetchTokenOption);
			checkType(l,2,out a1);
			self.GetBackgroundFetchToken(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBatteryInfoCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.GetBatteryInfoCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBatteryInfo(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.GetBatteryInfoOption a1 = default(WeChatWASM.GetBatteryInfoOption);
			checkType(l,2,out a1);
			self.GetBatteryInfo(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBeaconsCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.GetBeaconsCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBeacons(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.GetBeaconsOption a1 = default(WeChatWASM.GetBeaconsOption);
			checkType(l,2,out a1);
			self.GetBeacons(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBluetoothAdapterStateCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.GetBluetoothAdapterStateCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBluetoothAdapterState(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.GetBluetoothAdapterStateOption a1 = default(WeChatWASM.GetBluetoothAdapterStateOption);
			checkType(l,2,out a1);
			self.GetBluetoothAdapterState(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBluetoothDevicesCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.GetBluetoothDevicesCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBluetoothDevices(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.GetBluetoothDevicesOption a1 = default(WeChatWASM.GetBluetoothDevicesOption);
			checkType(l,2,out a1);
			self.GetBluetoothDevices(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetChannelsLiveInfoCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.GetChannelsLiveInfoCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetChannelsLiveInfo(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.GetChannelsLiveInfoOption a1 = default(WeChatWASM.GetChannelsLiveInfoOption);
			checkType(l,2,out a1);
			self.GetChannelsLiveInfo(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetChannelsLiveNoticeInfoCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.GetChannelsLiveNoticeInfoCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetChannelsLiveNoticeInfo(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.GetChannelsLiveNoticeInfoOption a1 = default(WeChatWASM.GetChannelsLiveNoticeInfoOption);
			checkType(l,2,out a1);
			self.GetChannelsLiveNoticeInfo(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetClipboardDataCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.GetClipboardDataCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetClipboardData(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.GetClipboardDataOption a1 = default(WeChatWASM.GetClipboardDataOption);
			checkType(l,2,out a1);
			self.GetClipboardData(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetConnectedBluetoothDevicesCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.GetConnectedBluetoothDevicesCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetConnectedBluetoothDevices(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.GetConnectedBluetoothDevicesOption a1 = default(WeChatWASM.GetConnectedBluetoothDevicesOption);
			checkType(l,2,out a1);
			self.GetConnectedBluetoothDevices(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetExtConfigCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.GetExtConfigCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetExtConfig(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.GetExtConfigOption a1 = default(WeChatWASM.GetExtConfigOption);
			checkType(l,2,out a1);
			self.GetExtConfig(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetFuzzyLocationCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.GetFuzzyLocationCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetFuzzyLocation(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.GetFuzzyLocationOption a1 = default(WeChatWASM.GetFuzzyLocationOption);
			checkType(l,2,out a1);
			self.GetFuzzyLocation(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetGameClubDataCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.GetGameClubDataCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetGameClubData(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.GetGameClubDataOption a1 = default(WeChatWASM.GetGameClubDataOption);
			checkType(l,2,out a1);
			self.GetGameClubData(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetGroupEnterInfoCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.GetGroupEnterInfoCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetGroupEnterInfo(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.GetGroupEnterInfoOption a1 = default(WeChatWASM.GetGroupEnterInfoOption);
			checkType(l,2,out a1);
			self.GetGroupEnterInfo(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetInferenceEnvInfoCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.GetInferenceEnvInfoCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetInferenceEnvInfo(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.GetInferenceEnvInfoOption a1 = default(WeChatWASM.GetInferenceEnvInfoOption);
			checkType(l,2,out a1);
			self.GetInferenceEnvInfo(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetLocalIPAddressCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.GetLocalIPAddressCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetLocalIPAddress(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.GetLocalIPAddressOption a1 = default(WeChatWASM.GetLocalIPAddressOption);
			checkType(l,2,out a1);
			self.GetLocalIPAddress(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetLocationCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.GetLocationCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetLocation(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.GetLocationOption a1 = default(WeChatWASM.GetLocationOption);
			checkType(l,2,out a1);
			self.GetLocation(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetNetworkTypeCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.GetNetworkTypeCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetNetworkType(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.GetNetworkTypeOption a1 = default(WeChatWASM.GetNetworkTypeOption);
			checkType(l,2,out a1);
			self.GetNetworkType(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetPrivacySettingCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.GetPrivacySettingCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetPrivacySetting(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.GetPrivacySettingOption a1 = default(WeChatWASM.GetPrivacySettingOption);
			checkType(l,2,out a1);
			self.GetPrivacySetting(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetScreenBrightnessCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.GetScreenBrightnessCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetScreenBrightness(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.GetScreenBrightnessOption a1 = default(WeChatWASM.GetScreenBrightnessOption);
			checkType(l,2,out a1);
			self.GetScreenBrightness(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetSettingCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.GetSettingCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetSetting(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.GetSettingOption a1 = default(WeChatWASM.GetSettingOption);
			checkType(l,2,out a1);
			self.GetSetting(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetShareInfoCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.GetShareInfoCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetShareInfo(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.GetShareInfoOption a1 = default(WeChatWASM.GetShareInfoOption);
			checkType(l,2,out a1);
			self.GetShareInfo(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetStorageInfoCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.GetStorageInfoCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetStorageInfo(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.GetStorageInfoOption a1 = default(WeChatWASM.GetStorageInfoOption);
			checkType(l,2,out a1);
			self.GetStorageInfo(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetSystemInfoCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.GetSystemInfoCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetSystemInfo(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.GetSystemInfoOption a1 = default(WeChatWASM.GetSystemInfoOption);
			checkType(l,2,out a1);
			self.GetSystemInfo(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetSystemInfoAsyncCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.GetSystemInfoAsyncCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetSystemInfoAsync(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.GetSystemInfoAsyncOption a1 = default(WeChatWASM.GetSystemInfoAsyncOption);
			checkType(l,2,out a1);
			self.GetSystemInfoAsync(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetUserInfoCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.GetUserInfoCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetUserInfo(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.GetUserInfoOption a1 = default(WeChatWASM.GetUserInfoOption);
			checkType(l,2,out a1);
			self.GetUserInfo(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetUserInteractiveStorageCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.GetUserInteractiveStorageCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetUserInteractiveStorage(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.GetUserInteractiveStorageOption a1 = default(WeChatWASM.GetUserInteractiveStorageOption);
			checkType(l,2,out a1);
			self.GetUserInteractiveStorage(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetWeRunDataCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.GetWeRunDataCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetWeRunData(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.GetWeRunDataOption a1 = default(WeChatWASM.GetWeRunDataOption);
			checkType(l,2,out a1);
			self.GetWeRunData(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int HideKeyboardCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.HideKeyboardCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int HideKeyboard(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.HideKeyboardOption a1 = default(WeChatWASM.HideKeyboardOption);
			checkType(l,2,out a1);
			self.HideKeyboard(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int HideLoadingCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.HideLoadingCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int HideLoading(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.HideLoadingOption a1 = default(WeChatWASM.HideLoadingOption);
			checkType(l,2,out a1);
			self.HideLoading(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int HideShareMenuCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.HideShareMenuCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int HideShareMenu(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.HideShareMenuOption a1 = default(WeChatWASM.HideShareMenuOption);
			checkType(l,2,out a1);
			self.HideShareMenu(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int HideToastCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.HideToastCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int HideToast(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.HideToastOption a1 = default(WeChatWASM.HideToastOption);
			checkType(l,2,out a1);
			self.HideToast(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int InitFaceDetectCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.InitFaceDetectCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int InitFaceDetect(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.InitFaceDetectOption a1 = default(WeChatWASM.InitFaceDetectOption);
			checkType(l,2,out a1);
			self.InitFaceDetect(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IsBluetoothDevicePairedCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.IsBluetoothDevicePairedCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IsBluetoothDevicePaired(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.IsBluetoothDevicePairedOption a1 = default(WeChatWASM.IsBluetoothDevicePairedOption);
			checkType(l,2,out a1);
			self.IsBluetoothDevicePaired(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int JoinVoIPChatCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.JoinVoIPChatCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int JoinVoIPChat(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.JoinVoIPChatOption a1 = default(WeChatWASM.JoinVoIPChatOption);
			checkType(l,2,out a1);
			self.JoinVoIPChat(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LoginCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.LoginCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Login(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.LoginOption a1 = default(WeChatWASM.LoginOption);
			checkType(l,2,out a1);
			self.Login(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int MakeBluetoothPairCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.MakeBluetoothPairCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int MakeBluetoothPair(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.MakeBluetoothPairOption a1 = default(WeChatWASM.MakeBluetoothPairOption);
			checkType(l,2,out a1);
			self.MakeBluetoothPair(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int NavigateToMiniProgramCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.NavigateToMiniProgramCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int NavigateToMiniProgram(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.NavigateToMiniProgramOption a1 = default(WeChatWASM.NavigateToMiniProgramOption);
			checkType(l,2,out a1);
			self.NavigateToMiniProgram(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int NotifyBLECharacteristicValueChangeCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.NotifyBLECharacteristicValueChangeCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int NotifyBLECharacteristicValueChange(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.NotifyBLECharacteristicValueChangeOption a1 = default(WeChatWASM.NotifyBLECharacteristicValueChangeOption);
			checkType(l,2,out a1);
			self.NotifyBLECharacteristicValueChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenAppAuthorizeSettingCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.OpenAppAuthorizeSettingCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenAppAuthorizeSetting(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.OpenAppAuthorizeSettingOption a1 = default(WeChatWASM.OpenAppAuthorizeSettingOption);
			checkType(l,2,out a1);
			self.OpenAppAuthorizeSetting(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenBluetoothAdapterCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.OpenBluetoothAdapterCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenBluetoothAdapter(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.OpenBluetoothAdapterOption a1 = default(WeChatWASM.OpenBluetoothAdapterOption);
			checkType(l,2,out a1);
			self.OpenBluetoothAdapter(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenCardCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.OpenCardCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenCard(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.OpenCardOption a1 = default(WeChatWASM.OpenCardOption);
			checkType(l,2,out a1);
			self.OpenCard(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenChannelsActivityCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.OpenChannelsActivityCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenChannelsActivity(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.OpenChannelsActivityOption a1 = default(WeChatWASM.OpenChannelsActivityOption);
			checkType(l,2,out a1);
			self.OpenChannelsActivity(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenChannelsEventCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.OpenChannelsEventCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenChannelsEvent(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.OpenChannelsEventOption a1 = default(WeChatWASM.OpenChannelsEventOption);
			checkType(l,2,out a1);
			self.OpenChannelsEvent(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenChannelsLiveCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.OpenChannelsLiveCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenChannelsLive(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.OpenChannelsLiveOption a1 = default(WeChatWASM.OpenChannelsLiveOption);
			checkType(l,2,out a1);
			self.OpenChannelsLive(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenChannelsUserProfileCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.OpenChannelsUserProfileCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenChannelsUserProfile(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.OpenChannelsUserProfileOption a1 = default(WeChatWASM.OpenChannelsUserProfileOption);
			checkType(l,2,out a1);
			self.OpenChannelsUserProfile(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenCustomerServiceChatCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.OpenCustomerServiceChatCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenCustomerServiceChat(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.OpenCustomerServiceChatOption a1 = default(WeChatWASM.OpenCustomerServiceChatOption);
			checkType(l,2,out a1);
			self.OpenCustomerServiceChat(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenCustomerServiceConversationCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.OpenCustomerServiceConversationCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenCustomerServiceConversation(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.OpenCustomerServiceConversationOption a1 = default(WeChatWASM.OpenCustomerServiceConversationOption);
			checkType(l,2,out a1);
			self.OpenCustomerServiceConversation(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenPrivacyContractCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.OpenPrivacyContractCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenPrivacyContract(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.OpenPrivacyContractOption a1 = default(WeChatWASM.OpenPrivacyContractOption);
			checkType(l,2,out a1);
			self.OpenPrivacyContract(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenSettingCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.OpenSettingCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenSetting(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.OpenSettingOption a1 = default(WeChatWASM.OpenSettingOption);
			checkType(l,2,out a1);
			self.OpenSetting(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenSystemBluetoothSettingCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.OpenSystemBluetoothSettingCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenSystemBluetoothSetting(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.OpenSystemBluetoothSettingOption a1 = default(WeChatWASM.OpenSystemBluetoothSettingOption);
			checkType(l,2,out a1);
			self.OpenSystemBluetoothSetting(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int PreviewImageCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.PreviewImageCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int PreviewImage(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.PreviewImageOption a1 = default(WeChatWASM.PreviewImageOption);
			checkType(l,2,out a1);
			self.PreviewImage(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int PreviewMediaCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.PreviewMediaCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int PreviewMedia(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.PreviewMediaOption a1 = default(WeChatWASM.PreviewMediaOption);
			checkType(l,2,out a1);
			self.PreviewMedia(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReadBLECharacteristicValueCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.ReadBLECharacteristicValueCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReadBLECharacteristicValue(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.ReadBLECharacteristicValueOption a1 = default(WeChatWASM.ReadBLECharacteristicValueOption);
			checkType(l,2,out a1);
			self.ReadBLECharacteristicValue(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RemoveStorageCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.RemoveStorageCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RemoveStorage(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.RemoveStorageOption a1 = default(WeChatWASM.RemoveStorageOption);
			checkType(l,2,out a1);
			self.RemoveStorage(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RemoveUserCloudStorageCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.RemoveUserCloudStorageCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RemoveUserCloudStorage(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.RemoveUserCloudStorageOption a1 = default(WeChatWASM.RemoveUserCloudStorageOption);
			checkType(l,2,out a1);
			self.RemoveUserCloudStorage(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReportSceneCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.ReportSceneCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReportScene(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.ReportSceneOption a1 = default(WeChatWASM.ReportSceneOption);
			checkType(l,2,out a1);
			self.ReportScene(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RequestMidasFriendPaymentCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.RequestMidasFriendPaymentCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RequestMidasFriendPayment(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.RequestMidasFriendPaymentOption a1 = default(WeChatWASM.RequestMidasFriendPaymentOption);
			checkType(l,2,out a1);
			self.RequestMidasFriendPayment(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RequestMidasPaymentCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.RequestMidasPaymentCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RequestMidasPayment(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.RequestMidasPaymentOption a1 = default(WeChatWASM.RequestMidasPaymentOption);
			checkType(l,2,out a1);
			self.RequestMidasPayment(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RequestSubscribeMessageCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.RequestSubscribeMessageCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RequestSubscribeMessage(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.RequestSubscribeMessageOption a1 = default(WeChatWASM.RequestSubscribeMessageOption);
			checkType(l,2,out a1);
			self.RequestSubscribeMessage(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RequestSubscribeSystemMessageCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.RequestSubscribeSystemMessageCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RequestSubscribeSystemMessage(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.RequestSubscribeSystemMessageOption a1 = default(WeChatWASM.RequestSubscribeSystemMessageOption);
			checkType(l,2,out a1);
			self.RequestSubscribeSystemMessage(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RequirePrivacyAuthorizeCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.RequirePrivacyAuthorizeCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RequirePrivacyAuthorize(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.RequirePrivacyAuthorizeOption a1 = default(WeChatWASM.RequirePrivacyAuthorizeOption);
			checkType(l,2,out a1);
			self.RequirePrivacyAuthorize(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RestartMiniProgramCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.RestartMiniProgramCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RestartMiniProgram(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.RestartMiniProgramOption a1 = default(WeChatWASM.RestartMiniProgramOption);
			checkType(l,2,out a1);
			self.RestartMiniProgram(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SaveFileToDiskCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.SaveFileToDiskCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SaveFileToDisk(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.SaveFileToDiskOption a1 = default(WeChatWASM.SaveFileToDiskOption);
			checkType(l,2,out a1);
			self.SaveFileToDisk(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SaveImageToPhotosAlbumCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.SaveImageToPhotosAlbumCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SaveImageToPhotosAlbum(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.SaveImageToPhotosAlbumOption a1 = default(WeChatWASM.SaveImageToPhotosAlbumOption);
			checkType(l,2,out a1);
			self.SaveImageToPhotosAlbum(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ScanCodeCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.ScanCodeCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ScanCode(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.ScanCodeOption a1 = default(WeChatWASM.ScanCodeOption);
			checkType(l,2,out a1);
			self.ScanCode(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetBLEMTUCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.SetBLEMTUCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetBLEMTU(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.SetBLEMTUOption a1 = default(WeChatWASM.SetBLEMTUOption);
			checkType(l,2,out a1);
			self.SetBLEMTU(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetBackgroundFetchTokenCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.SetBackgroundFetchTokenCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetBackgroundFetchToken(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.SetBackgroundFetchTokenOption a1 = default(WeChatWASM.SetBackgroundFetchTokenOption);
			checkType(l,2,out a1);
			self.SetBackgroundFetchToken(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetClipboardDataCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.SetClipboardDataCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetClipboardData(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.SetClipboardDataOption a1 = default(WeChatWASM.SetClipboardDataOption);
			checkType(l,2,out a1);
			self.SetClipboardData(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetDeviceOrientationCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.SetDeviceOrientationCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetDeviceOrientation(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.SetDeviceOrientationOption a1 = default(WeChatWASM.SetDeviceOrientationOption);
			checkType(l,2,out a1);
			self.SetDeviceOrientation(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetEnableDebugCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.SetEnableDebugCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetEnableDebug(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.SetEnableDebugOption a1 = default(WeChatWASM.SetEnableDebugOption);
			checkType(l,2,out a1);
			self.SetEnableDebug(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetInnerAudioOptionCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.SetInnerAudioOptionCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetInnerAudioOption(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.SetInnerAudioOption a1 = default(WeChatWASM.SetInnerAudioOption);
			checkType(l,2,out a1);
			self.SetInnerAudioOption(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetKeepScreenOnCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.SetKeepScreenOnCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetKeepScreenOn(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.SetKeepScreenOnOption a1 = default(WeChatWASM.SetKeepScreenOnOption);
			checkType(l,2,out a1);
			self.SetKeepScreenOn(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetMenuStyleCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.SetMenuStyleCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetMenuStyle(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.SetMenuStyleOption a1 = default(WeChatWASM.SetMenuStyleOption);
			checkType(l,2,out a1);
			self.SetMenuStyle(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetScreenBrightnessCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.SetScreenBrightnessCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetScreenBrightness(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.SetScreenBrightnessOption a1 = default(WeChatWASM.SetScreenBrightnessOption);
			checkType(l,2,out a1);
			self.SetScreenBrightness(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetStatusBarStyleCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.SetStatusBarStyleCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetStatusBarStyle(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.SetStatusBarStyleOption a1 = default(WeChatWASM.SetStatusBarStyleOption);
			checkType(l,2,out a1);
			self.SetStatusBarStyle(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetUserCloudStorageCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.SetUserCloudStorageCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetUserCloudStorage(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.SetUserCloudStorageOption a1 = default(WeChatWASM.SetUserCloudStorageOption);
			checkType(l,2,out a1);
			self.SetUserCloudStorage(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ShowActionSheetCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.ShowActionSheetCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ShowActionSheet(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.ShowActionSheetOption a1 = default(WeChatWASM.ShowActionSheetOption);
			checkType(l,2,out a1);
			self.ShowActionSheet(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ShowKeyboardCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.ShowKeyboardCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ShowKeyboard(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.ShowKeyboardOption a1 = default(WeChatWASM.ShowKeyboardOption);
			checkType(l,2,out a1);
			self.ShowKeyboard(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ShowLoadingCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.ShowLoadingCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ShowLoading(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.ShowLoadingOption a1 = default(WeChatWASM.ShowLoadingOption);
			checkType(l,2,out a1);
			self.ShowLoading(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ShowModalCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.ShowModalCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ShowModal(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.ShowModalOption a1 = default(WeChatWASM.ShowModalOption);
			checkType(l,2,out a1);
			self.ShowModal(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ShowShareImageMenuCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.ShowShareImageMenuCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ShowShareImageMenu(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.ShowShareImageMenuOption a1 = default(WeChatWASM.ShowShareImageMenuOption);
			checkType(l,2,out a1);
			self.ShowShareImageMenu(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ShowShareMenuCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.ShowShareMenuCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ShowShareMenu(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.ShowShareMenuOption a1 = default(WeChatWASM.ShowShareMenuOption);
			checkType(l,2,out a1);
			self.ShowShareMenu(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ShowToastCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.ShowToastCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ShowToast(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.ShowToastOption a1 = default(WeChatWASM.ShowToastOption);
			checkType(l,2,out a1);
			self.ShowToast(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StartAccelerometerCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.StartAccelerometerCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StartAccelerometer(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.StartAccelerometerOption a1 = default(WeChatWASM.StartAccelerometerOption);
			checkType(l,2,out a1);
			self.StartAccelerometer(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StartBeaconDiscoveryCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.StartBeaconDiscoveryCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StartBeaconDiscovery(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.StartBeaconDiscoveryOption a1 = default(WeChatWASM.StartBeaconDiscoveryOption);
			checkType(l,2,out a1);
			self.StartBeaconDiscovery(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StartBluetoothDevicesDiscoveryCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.StartBluetoothDevicesDiscoveryCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StartBluetoothDevicesDiscovery(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.StartBluetoothDevicesDiscoveryOption a1 = default(WeChatWASM.StartBluetoothDevicesDiscoveryOption);
			checkType(l,2,out a1);
			self.StartBluetoothDevicesDiscovery(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StartCompassCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.StartCompassCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StartCompass(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.StartCompassOption a1 = default(WeChatWASM.StartCompassOption);
			checkType(l,2,out a1);
			self.StartCompass(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StartDeviceMotionListeningCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.StartDeviceMotionListeningCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StartDeviceMotionListening(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.StartDeviceMotionListeningOption a1 = default(WeChatWASM.StartDeviceMotionListeningOption);
			checkType(l,2,out a1);
			self.StartDeviceMotionListening(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StartGyroscopeCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.StartGyroscopeCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StartGyroscope(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.StartGyroscopeOption a1 = default(WeChatWASM.StartGyroscopeOption);
			checkType(l,2,out a1);
			self.StartGyroscope(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StopAccelerometerCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.StopAccelerometerCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StopAccelerometer(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.StopAccelerometerOption a1 = default(WeChatWASM.StopAccelerometerOption);
			checkType(l,2,out a1);
			self.StopAccelerometer(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StopBeaconDiscoveryCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.StopBeaconDiscoveryCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StopBeaconDiscovery(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.StopBeaconDiscoveryOption a1 = default(WeChatWASM.StopBeaconDiscoveryOption);
			checkType(l,2,out a1);
			self.StopBeaconDiscovery(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StopBluetoothDevicesDiscoveryCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.StopBluetoothDevicesDiscoveryCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StopBluetoothDevicesDiscovery(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.StopBluetoothDevicesDiscoveryOption a1 = default(WeChatWASM.StopBluetoothDevicesDiscoveryOption);
			checkType(l,2,out a1);
			self.StopBluetoothDevicesDiscovery(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StopCompassCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.StopCompassCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StopCompass(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.StopCompassOption a1 = default(WeChatWASM.StopCompassOption);
			checkType(l,2,out a1);
			self.StopCompass(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StopDeviceMotionListeningCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.StopDeviceMotionListeningCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StopDeviceMotionListening(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.StopDeviceMotionListeningOption a1 = default(WeChatWASM.StopDeviceMotionListeningOption);
			checkType(l,2,out a1);
			self.StopDeviceMotionListening(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StopFaceDetectCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.StopFaceDetectCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StopFaceDetect(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.StopFaceDetectOption a1 = default(WeChatWASM.StopFaceDetectOption);
			checkType(l,2,out a1);
			self.StopFaceDetect(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StopGyroscopeCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.StopGyroscopeCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StopGyroscope(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.StopGyroscopeOption a1 = default(WeChatWASM.StopGyroscopeOption);
			checkType(l,2,out a1);
			self.StopGyroscope(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int UpdateKeyboardCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.UpdateKeyboardCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int UpdateKeyboard(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.UpdateKeyboardOption a1 = default(WeChatWASM.UpdateKeyboardOption);
			checkType(l,2,out a1);
			self.UpdateKeyboard(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int UpdateShareMenuCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.UpdateShareMenuCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int UpdateShareMenu(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.UpdateShareMenuOption a1 = default(WeChatWASM.UpdateShareMenuOption);
			checkType(l,2,out a1);
			self.UpdateShareMenu(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int UpdateVoIPChatMuteConfigCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.UpdateVoIPChatMuteConfigCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int UpdateVoIPChatMuteConfig(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.UpdateVoIPChatMuteConfigOption a1 = default(WeChatWASM.UpdateVoIPChatMuteConfigOption);
			checkType(l,2,out a1);
			self.UpdateVoIPChatMuteConfig(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int UpdateWeChatAppCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.UpdateWeChatAppCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int UpdateWeChatApp(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.UpdateWeChatAppOption a1 = default(WeChatWASM.UpdateWeChatAppOption);
			checkType(l,2,out a1);
			self.UpdateWeChatApp(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int VibrateLongCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.VibrateLongCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int VibrateLong(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.VibrateLongOption a1 = default(WeChatWASM.VibrateLongOption);
			checkType(l,2,out a1);
			self.VibrateLong(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int VibrateShortCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.VibrateShortCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int VibrateShort(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.VibrateShortOption a1 = default(WeChatWASM.VibrateShortOption);
			checkType(l,2,out a1);
			self.VibrateShort(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WriteBLECharacteristicValueCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.WriteBLECharacteristicValueCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WriteBLECharacteristicValue(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.WriteBLECharacteristicValueOption a1 = default(WeChatWASM.WriteBLECharacteristicValueOption);
			checkType(l,2,out a1);
			self.WriteBLECharacteristicValue(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StartGameLiveCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.StartGameLiveCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StartGameLive(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.StartGameLiveOption a1 = default(WeChatWASM.StartGameLiveOption);
			checkType(l,2,out a1);
			self.StartGameLive(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CheckGameLiveEnabledCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.CheckGameLiveEnabledCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CheckGameLiveEnabled(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.CheckGameLiveEnabledOption a1 = default(WeChatWASM.CheckGameLiveEnabledOption);
			checkType(l,2,out a1);
			self.CheckGameLiveEnabled(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetUserCurrentGameliveInfoCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.GetUserCurrentGameliveInfoCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetUserCurrentGameliveInfo(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.GetUserCurrentGameliveInfoOption a1 = default(WeChatWASM.GetUserCurrentGameliveInfoOption);
			checkType(l,2,out a1);
			self.GetUserCurrentGameliveInfo(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetUserRecentGameLiveInfoCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.GetUserRecentGameLiveInfoCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetUserRecentGameLiveInfo(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.GetUserRecentGameLiveInfoOption a1 = default(WeChatWASM.GetUserRecentGameLiveInfoOption);
			checkType(l,2,out a1);
			self.GetUserRecentGameLiveInfo(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetUserGameLiveDetailsCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.GetUserGameLiveDetailsCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetUserGameLiveDetails(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.GetUserGameLiveDetailsOption a1 = default(WeChatWASM.GetUserGameLiveDetailsOption);
			checkType(l,2,out a1);
			self.GetUserGameLiveDetails(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenChannelsLiveCollectionCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.OpenChannelsLiveCollectionCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenChannelsLiveCollection(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.OpenChannelsLiveCollectionOption a1 = default(WeChatWASM.OpenChannelsLiveCollectionOption);
			checkType(l,2,out a1);
			self.OpenChannelsLiveCollection(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenPageCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.OpenPageCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenPage(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.OpenPageOption a1 = default(WeChatWASM.OpenPageOption);
			checkType(l,2,out a1);
			self.OpenPage(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RequestMidasPaymentGameItemCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.RequestMidasPaymentGameItemCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RequestMidasPaymentGameItem(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.RequestMidasPaymentGameItemOption a1 = default(WeChatWASM.RequestMidasPaymentGameItemOption);
			checkType(l,2,out a1);
			self.RequestMidasPaymentGameItem(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RequestSubscribeLiveActivityCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.RequestSubscribeLiveActivityCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RequestSubscribeLiveActivity(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.RequestSubscribeLiveActivityOption a1 = default(WeChatWASM.RequestSubscribeLiveActivityOption);
			checkType(l,2,out a1);
			self.RequestSubscribeLiveActivity(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OperateGameRecorderVideo(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.OperateGameRecorderVideoOption a1 = default(WeChatWASM.OperateGameRecorderVideoOption);
			checkType(l,2,out a1);
			self.OperateGameRecorderVideo(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RemoveStorageSync(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.RemoveStorageSync(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReportMonitor(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			System.Double a2 = default(System.Double);
			checkType(l,3,out a2);
			self.ReportMonitor(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReportPerformance(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Double a1 = default(System.Double);
			checkType(l,2,out a1);
			System.Double a2 = default(System.Double);
			checkType(l,3,out a2);
			System.String a3 = default(System.String);
			checkType(l,4,out a3);
			self.ReportPerformance(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReportUserBehaviorBranchAnalytics(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
				WeChatWASM.ReportUserBehaviorBranchAnalyticsOption a1 = default(WeChatWASM.ReportUserBehaviorBranchAnalyticsOption);
				checkType(l,2,out a1);
				self.ReportUserBehaviorBranchAnalytics(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
				System.String a1 = default(System.String);
				checkType(l,2,out a1);
				System.String a2 = default(System.String);
				checkType(l,3,out a2);
				System.Int32 a3 = default(System.Int32);
				checkType(l,4,out a3);
				self.ReportUserBehaviorBranchAnalytics(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function ReportUserBehaviorBranchAnalytics to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReserveChannelsLive(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.ReserveChannelsLiveOption a1 = default(WeChatWASM.ReserveChannelsLiveOption);
			checkType(l,2,out a1);
			self.ReserveChannelsLive(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RevokeBufferURL(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.RevokeBufferURL(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ShareAppMessage(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.ShareAppMessageOption a1 = default(WeChatWASM.ShareAppMessageOption);
			checkType(l,2,out a1);
			self.ShareAppMessage(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int TriggerGC(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			self.TriggerGC();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnAccelerometerChangeCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnAccelerometerChangeCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnAccelerometerChange(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnAccelerometerChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnAccelerometerChangeListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnAccelerometerChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffAccelerometerChange(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnAccelerometerChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnAccelerometerChangeListenerResult>);
			checkDelegate(l,2,out a1);
			self.OffAccelerometerChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnAudioInterruptionBeginCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnAudioInterruptionBeginCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnAudioInterruptionBegin(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.GeneralCallbackResult> a1 = default(System.Action<WeChatWASM.GeneralCallbackResult>);
			checkDelegate(l,2,out a1);
			self.OnAudioInterruptionBegin(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffAudioInterruptionBegin(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.GeneralCallbackResult> a1 = default(System.Action<WeChatWASM.GeneralCallbackResult>);
			checkDelegate(l,2,out a1);
			self.OffAudioInterruptionBegin(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnAudioInterruptionEndCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnAudioInterruptionEndCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnAudioInterruptionEnd(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.GeneralCallbackResult> a1 = default(System.Action<WeChatWASM.GeneralCallbackResult>);
			checkDelegate(l,2,out a1);
			self.OnAudioInterruptionEnd(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffAudioInterruptionEnd(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.GeneralCallbackResult> a1 = default(System.Action<WeChatWASM.GeneralCallbackResult>);
			checkDelegate(l,2,out a1);
			self.OffAudioInterruptionEnd(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnBLECharacteristicValueChangeCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnBLECharacteristicValueChangeCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnBLECharacteristicValueChange(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnBLECharacteristicValueChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnBLECharacteristicValueChangeListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnBLECharacteristicValueChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffBLECharacteristicValueChange(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnBLECharacteristicValueChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnBLECharacteristicValueChangeListenerResult>);
			checkDelegate(l,2,out a1);
			self.OffBLECharacteristicValueChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnBLEConnectionStateChangeCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnBLEConnectionStateChangeCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnBLEConnectionStateChange(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnBLEConnectionStateChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnBLEConnectionStateChangeListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnBLEConnectionStateChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffBLEConnectionStateChange(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnBLEConnectionStateChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnBLEConnectionStateChangeListenerResult>);
			checkDelegate(l,2,out a1);
			self.OffBLEConnectionStateChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnBLEMTUChangeCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnBLEMTUChangeCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnBLEMTUChange(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnBLEMTUChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnBLEMTUChangeListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnBLEMTUChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffBLEMTUChange(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnBLEMTUChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnBLEMTUChangeListenerResult>);
			checkDelegate(l,2,out a1);
			self.OffBLEMTUChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnBLEPeripheralConnectionStateChangedCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnBLEPeripheralConnectionStateChangedCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnBLEPeripheralConnectionStateChanged(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnBLEPeripheralConnectionStateChangedListenerResult> a1 = default(System.Action<WeChatWASM.OnBLEPeripheralConnectionStateChangedListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnBLEPeripheralConnectionStateChanged(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffBLEPeripheralConnectionStateChanged(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnBLEPeripheralConnectionStateChangedListenerResult> a1 = default(System.Action<WeChatWASM.OnBLEPeripheralConnectionStateChangedListenerResult>);
			checkDelegate(l,2,out a1);
			self.OffBLEPeripheralConnectionStateChanged(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnBackgroundFetchDataCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnBackgroundFetchDataCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnBackgroundFetchData(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnBackgroundFetchDataListenerResult> a1 = default(System.Action<WeChatWASM.OnBackgroundFetchDataListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnBackgroundFetchData(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnBeaconServiceChangeCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnBeaconServiceChangeCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnBeaconServiceChange(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnBeaconServiceChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnBeaconServiceChangeListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnBeaconServiceChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffBeaconServiceChange(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnBeaconServiceChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnBeaconServiceChangeListenerResult>);
			checkDelegate(l,2,out a1);
			self.OffBeaconServiceChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnBeaconUpdateCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnBeaconUpdateCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnBeaconUpdate(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnBeaconUpdateListenerResult> a1 = default(System.Action<WeChatWASM.OnBeaconUpdateListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnBeaconUpdate(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffBeaconUpdate(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnBeaconUpdateListenerResult> a1 = default(System.Action<WeChatWASM.OnBeaconUpdateListenerResult>);
			checkDelegate(l,2,out a1);
			self.OffBeaconUpdate(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnBluetoothAdapterStateChangeCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnBluetoothAdapterStateChangeCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnBluetoothAdapterStateChange(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnBluetoothAdapterStateChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnBluetoothAdapterStateChangeListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnBluetoothAdapterStateChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffBluetoothAdapterStateChange(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnBluetoothAdapterStateChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnBluetoothAdapterStateChangeListenerResult>);
			checkDelegate(l,2,out a1);
			self.OffBluetoothAdapterStateChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnBluetoothDeviceFoundCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnBluetoothDeviceFoundCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnBluetoothDeviceFound(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnBluetoothDeviceFoundListenerResult> a1 = default(System.Action<WeChatWASM.OnBluetoothDeviceFoundListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnBluetoothDeviceFound(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffBluetoothDeviceFound(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnBluetoothDeviceFoundListenerResult> a1 = default(System.Action<WeChatWASM.OnBluetoothDeviceFoundListenerResult>);
			checkDelegate(l,2,out a1);
			self.OffBluetoothDeviceFound(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnCompassChangeCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnCompassChangeCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnCompassChange(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnCompassChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnCompassChangeListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnCompassChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffCompassChange(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnCompassChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnCompassChangeListenerResult>);
			checkDelegate(l,2,out a1);
			self.OffCompassChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnDeviceMotionChangeCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnDeviceMotionChangeCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnDeviceMotionChange(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnDeviceMotionChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnDeviceMotionChangeListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnDeviceMotionChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffDeviceMotionChange(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnDeviceMotionChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnDeviceMotionChangeListenerResult>);
			checkDelegate(l,2,out a1);
			self.OffDeviceMotionChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnDeviceOrientationChangeCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnDeviceOrientationChangeCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnDeviceOrientationChange(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnDeviceOrientationChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnDeviceOrientationChangeListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnDeviceOrientationChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffDeviceOrientationChange(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnDeviceOrientationChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnDeviceOrientationChangeListenerResult>);
			checkDelegate(l,2,out a1);
			self.OffDeviceOrientationChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnErrorCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnErrorCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnError(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.WxOnErrorCallbackResult> a1 = default(System.Action<WeChatWASM.WxOnErrorCallbackResult>);
			checkDelegate(l,2,out a1);
			self.OnError(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffError(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.WxOnErrorCallbackResult> a1 = default(System.Action<WeChatWASM.WxOnErrorCallbackResult>);
			checkDelegate(l,2,out a1);
			self.OffError(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnGyroscopeChangeCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnGyroscopeChangeCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnGyroscopeChange(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnGyroscopeChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnGyroscopeChangeListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnGyroscopeChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffGyroscopeChange(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnGyroscopeChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnGyroscopeChangeListenerResult>);
			checkDelegate(l,2,out a1);
			self.OffGyroscopeChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnHideCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnHideCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnHide(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.GeneralCallbackResult> a1 = default(System.Action<WeChatWASM.GeneralCallbackResult>);
			checkDelegate(l,2,out a1);
			self.OnHide(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffHide(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.GeneralCallbackResult> a1 = default(System.Action<WeChatWASM.GeneralCallbackResult>);
			checkDelegate(l,2,out a1);
			self.OffHide(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnInteractiveStorageModifiedCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnInteractiveStorageModifiedCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnInteractiveStorageModified(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<System.String> a1 = default(System.Action<System.String>);
			checkDelegate(l,2,out a1);
			self.OnInteractiveStorageModified(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffInteractiveStorageModified(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<System.String> a1 = default(System.Action<System.String>);
			checkDelegate(l,2,out a1);
			self.OffInteractiveStorageModified(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnKeyDownCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnKeyDownCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnKeyDown(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnKeyDownListenerResult> a1 = default(System.Action<WeChatWASM.OnKeyDownListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnKeyDown(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffKeyDown(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnKeyDownListenerResult> a1 = default(System.Action<WeChatWASM.OnKeyDownListenerResult>);
			checkDelegate(l,2,out a1);
			self.OffKeyDown(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnKeyUpCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnKeyUpCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnKeyUp(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnKeyDownListenerResult> a1 = default(System.Action<WeChatWASM.OnKeyDownListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnKeyUp(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffKeyUp(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnKeyDownListenerResult> a1 = default(System.Action<WeChatWASM.OnKeyDownListenerResult>);
			checkDelegate(l,2,out a1);
			self.OffKeyUp(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnKeyboardCompleteCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnKeyboardCompleteCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnKeyboardComplete(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnKeyboardInputListenerResult> a1 = default(System.Action<WeChatWASM.OnKeyboardInputListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnKeyboardComplete(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffKeyboardComplete(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnKeyboardInputListenerResult> a1 = default(System.Action<WeChatWASM.OnKeyboardInputListenerResult>);
			checkDelegate(l,2,out a1);
			self.OffKeyboardComplete(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnKeyboardConfirmCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnKeyboardConfirmCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnKeyboardConfirm(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnKeyboardInputListenerResult> a1 = default(System.Action<WeChatWASM.OnKeyboardInputListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnKeyboardConfirm(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffKeyboardConfirm(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnKeyboardInputListenerResult> a1 = default(System.Action<WeChatWASM.OnKeyboardInputListenerResult>);
			checkDelegate(l,2,out a1);
			self.OffKeyboardConfirm(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnKeyboardHeightChangeCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnKeyboardHeightChangeCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnKeyboardHeightChange(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnKeyboardHeightChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnKeyboardHeightChangeListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnKeyboardHeightChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffKeyboardHeightChange(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnKeyboardHeightChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnKeyboardHeightChangeListenerResult>);
			checkDelegate(l,2,out a1);
			self.OffKeyboardHeightChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnKeyboardInputCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnKeyboardInputCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnKeyboardInput(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnKeyboardInputListenerResult> a1 = default(System.Action<WeChatWASM.OnKeyboardInputListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnKeyboardInput(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffKeyboardInput(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnKeyboardInputListenerResult> a1 = default(System.Action<WeChatWASM.OnKeyboardInputListenerResult>);
			checkDelegate(l,2,out a1);
			self.OffKeyboardInput(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnMemoryWarningCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnMemoryWarningCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnMemoryWarning(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnMemoryWarningListenerResult> a1 = default(System.Action<WeChatWASM.OnMemoryWarningListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnMemoryWarning(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffMemoryWarning(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnMemoryWarningListenerResult> a1 = default(System.Action<WeChatWASM.OnMemoryWarningListenerResult>);
			checkDelegate(l,2,out a1);
			self.OffMemoryWarning(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnMessageCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnMessageCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnMessage(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<System.String> a1 = default(System.Action<System.String>);
			checkDelegate(l,2,out a1);
			self.OnMessage(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnMouseDownCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnMouseDownCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnMouseDown(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnMouseDownListenerResult> a1 = default(System.Action<WeChatWASM.OnMouseDownListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnMouseDown(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffMouseDown(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnMouseDownListenerResult> a1 = default(System.Action<WeChatWASM.OnMouseDownListenerResult>);
			checkDelegate(l,2,out a1);
			self.OffMouseDown(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnMouseMoveCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnMouseMoveCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnMouseMove(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnMouseMoveListenerResult> a1 = default(System.Action<WeChatWASM.OnMouseMoveListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnMouseMove(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffMouseMove(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnMouseMoveListenerResult> a1 = default(System.Action<WeChatWASM.OnMouseMoveListenerResult>);
			checkDelegate(l,2,out a1);
			self.OffMouseMove(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnMouseUpCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnMouseUpCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnMouseUp(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnMouseDownListenerResult> a1 = default(System.Action<WeChatWASM.OnMouseDownListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnMouseUp(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffMouseUp(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnMouseDownListenerResult> a1 = default(System.Action<WeChatWASM.OnMouseDownListenerResult>);
			checkDelegate(l,2,out a1);
			self.OffMouseUp(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnNetworkStatusChangeCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnNetworkStatusChangeCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnNetworkStatusChange(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnNetworkStatusChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnNetworkStatusChangeListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnNetworkStatusChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffNetworkStatusChange(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnNetworkStatusChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnNetworkStatusChangeListenerResult>);
			checkDelegate(l,2,out a1);
			self.OffNetworkStatusChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnNetworkWeakChangeCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnNetworkWeakChangeCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnNetworkWeakChange(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnNetworkWeakChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnNetworkWeakChangeListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnNetworkWeakChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffNetworkWeakChange(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnNetworkWeakChangeListenerResult> a1 = default(System.Action<WeChatWASM.OnNetworkWeakChangeListenerResult>);
			checkDelegate(l,2,out a1);
			self.OffNetworkWeakChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnShareMessageToFriendCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnShareMessageToFriendCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnShareMessageToFriend(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnShareMessageToFriendListenerResult> a1 = default(System.Action<WeChatWASM.OnShareMessageToFriendListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnShareMessageToFriend(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnShowCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnShowCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnShow(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnShowListenerResult> a1 = default(System.Action<WeChatWASM.OnShowListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnShow(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffShow(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnShowListenerResult> a1 = default(System.Action<WeChatWASM.OnShowListenerResult>);
			checkDelegate(l,2,out a1);
			self.OffShow(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnTouchCancelCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnTouchCancelCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnTouchCancel(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnTouchStartListenerResult> a1 = default(System.Action<WeChatWASM.OnTouchStartListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnTouchCancel(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffTouchCancel(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnTouchStartListenerResult> a1 = default(System.Action<WeChatWASM.OnTouchStartListenerResult>);
			checkDelegate(l,2,out a1);
			self.OffTouchCancel(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnTouchEndCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnTouchEndCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnTouchEnd(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnTouchStartListenerResult> a1 = default(System.Action<WeChatWASM.OnTouchStartListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnTouchEnd(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffTouchEnd(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnTouchStartListenerResult> a1 = default(System.Action<WeChatWASM.OnTouchStartListenerResult>);
			checkDelegate(l,2,out a1);
			self.OffTouchEnd(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnTouchMoveCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnTouchMoveCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnTouchMove(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnTouchStartListenerResult> a1 = default(System.Action<WeChatWASM.OnTouchStartListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnTouchMove(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffTouchMove(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnTouchStartListenerResult> a1 = default(System.Action<WeChatWASM.OnTouchStartListenerResult>);
			checkDelegate(l,2,out a1);
			self.OffTouchMove(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnTouchStartCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnTouchStartCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnTouchStart(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnTouchStartListenerResult> a1 = default(System.Action<WeChatWASM.OnTouchStartListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnTouchStart(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffTouchStart(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnTouchStartListenerResult> a1 = default(System.Action<WeChatWASM.OnTouchStartListenerResult>);
			checkDelegate(l,2,out a1);
			self.OffTouchStart(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnUnhandledRejectionCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnUnhandledRejectionCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnUnhandledRejection(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnUnhandledRejectionListenerResult> a1 = default(System.Action<WeChatWASM.OnUnhandledRejectionListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnUnhandledRejection(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffUnhandledRejection(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnUnhandledRejectionListenerResult> a1 = default(System.Action<WeChatWASM.OnUnhandledRejectionListenerResult>);
			checkDelegate(l,2,out a1);
			self.OffUnhandledRejection(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnUserCaptureScreenCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnUserCaptureScreenCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnUserCaptureScreen(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.GeneralCallbackResult> a1 = default(System.Action<WeChatWASM.GeneralCallbackResult>);
			checkDelegate(l,2,out a1);
			self.OnUserCaptureScreen(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffUserCaptureScreen(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.GeneralCallbackResult> a1 = default(System.Action<WeChatWASM.GeneralCallbackResult>);
			checkDelegate(l,2,out a1);
			self.OffUserCaptureScreen(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnVoIPChatInterruptedCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnVoIPChatInterruptedCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnVoIPChatInterrupted(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnVoIPChatInterruptedListenerResult> a1 = default(System.Action<WeChatWASM.OnVoIPChatInterruptedListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnVoIPChatInterrupted(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffVoIPChatInterrupted(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnVoIPChatInterruptedListenerResult> a1 = default(System.Action<WeChatWASM.OnVoIPChatInterruptedListenerResult>);
			checkDelegate(l,2,out a1);
			self.OffVoIPChatInterrupted(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnVoIPChatMembersChangedCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnVoIPChatMembersChangedCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnVoIPChatMembersChanged(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnVoIPChatMembersChangedListenerResult> a1 = default(System.Action<WeChatWASM.OnVoIPChatMembersChangedListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnVoIPChatMembersChanged(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffVoIPChatMembersChanged(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnVoIPChatMembersChangedListenerResult> a1 = default(System.Action<WeChatWASM.OnVoIPChatMembersChangedListenerResult>);
			checkDelegate(l,2,out a1);
			self.OffVoIPChatMembersChanged(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnVoIPChatSpeakersChangedCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnVoIPChatSpeakersChangedCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnVoIPChatSpeakersChanged(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnVoIPChatSpeakersChangedListenerResult> a1 = default(System.Action<WeChatWASM.OnVoIPChatSpeakersChangedListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnVoIPChatSpeakersChanged(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffVoIPChatSpeakersChanged(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnVoIPChatSpeakersChangedListenerResult> a1 = default(System.Action<WeChatWASM.OnVoIPChatSpeakersChangedListenerResult>);
			checkDelegate(l,2,out a1);
			self.OffVoIPChatSpeakersChanged(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnVoIPChatStateChangedCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnVoIPChatStateChangedCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnVoIPChatStateChanged(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnVoIPChatStateChangedListenerResult> a1 = default(System.Action<WeChatWASM.OnVoIPChatStateChangedListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnVoIPChatStateChanged(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffVoIPChatStateChanged(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnVoIPChatStateChangedListenerResult> a1 = default(System.Action<WeChatWASM.OnVoIPChatStateChangedListenerResult>);
			checkDelegate(l,2,out a1);
			self.OffVoIPChatStateChanged(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnWheelCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnWheelCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnWheel(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnWheelListenerResult> a1 = default(System.Action<WeChatWASM.OnWheelListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnWheel(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffWheel(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnWheelListenerResult> a1 = default(System.Action<WeChatWASM.OnWheelListenerResult>);
			checkDelegate(l,2,out a1);
			self.OffWheel(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnWindowResizeCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnWindowResizeCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnWindowResize(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnWindowResizeListenerResult> a1 = default(System.Action<WeChatWASM.OnWindowResizeListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnWindowResize(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffWindowResize(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnWindowResizeListenerResult> a1 = default(System.Action<WeChatWASM.OnWindowResizeListenerResult>);
			checkDelegate(l,2,out a1);
			self.OffWindowResize(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnAddToFavoritesCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnAddToFavoritesCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnAddToFavorites(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<System.Action<WeChatWASM.OnAddToFavoritesListenerResult>> a1 = default(System.Action<System.Action<WeChatWASM.OnAddToFavoritesListenerResult>>);
			checkDelegate(l,2,out a1);
			self.OnAddToFavorites(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffAddToFavorites(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<System.Action<WeChatWASM.OnAddToFavoritesListenerResult>> a1 = default(System.Action<System.Action<WeChatWASM.OnAddToFavoritesListenerResult>>);
			checkDelegate(l,2,out a1);
			self.OffAddToFavorites(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnCopyUrlCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnCopyUrlCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnCopyUrl(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<System.Action<WeChatWASM.OnCopyUrlListenerResult>> a1 = default(System.Action<System.Action<WeChatWASM.OnCopyUrlListenerResult>>);
			checkDelegate(l,2,out a1);
			self.OnCopyUrl(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffCopyUrl(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<System.Action<WeChatWASM.OnCopyUrlListenerResult>> a1 = default(System.Action<System.Action<WeChatWASM.OnCopyUrlListenerResult>>);
			checkDelegate(l,2,out a1);
			self.OffCopyUrl(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnHandoffCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnHandoffCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnHandoff(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<System.Action<WeChatWASM.OnHandoffListenerResult>> a1 = default(System.Action<System.Action<WeChatWASM.OnHandoffListenerResult>>);
			checkDelegate(l,2,out a1);
			self.OnHandoff(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffHandoff(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<System.Action<WeChatWASM.OnHandoffListenerResult>> a1 = default(System.Action<System.Action<WeChatWASM.OnHandoffListenerResult>>);
			checkDelegate(l,2,out a1);
			self.OffHandoff(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnShareTimelineCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnShareTimelineCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnShareTimeline(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<System.Action<WeChatWASM.OnShareTimelineListenerResult>> a1 = default(System.Action<System.Action<WeChatWASM.OnShareTimelineListenerResult>>);
			checkDelegate(l,2,out a1);
			self.OnShareTimeline(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffShareTimeline(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<System.Action<WeChatWASM.OnShareTimelineListenerResult>> a1 = default(System.Action<System.Action<WeChatWASM.OnShareTimelineListenerResult>>);
			checkDelegate(l,2,out a1);
			self.OffShareTimeline(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnGameLiveStateChangeCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnGameLiveStateChangeCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnGameLiveStateChange(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnGameLiveStateChangeCallbackResult,System.Action<WeChatWASM.OnGameLiveStateChangeCallbackResponse>> a1 = default(System.Action<WeChatWASM.OnGameLiveStateChangeCallbackResult,System.Action<WeChatWASM.OnGameLiveStateChangeCallbackResponse>>);
			checkDelegate(l,2,out a1);
			self.OnGameLiveStateChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffGameLiveStateChange(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.OnGameLiveStateChangeCallbackResult,System.Action<WeChatWASM.OnGameLiveStateChangeCallbackResponse>> a1 = default(System.Action<WeChatWASM.OnGameLiveStateChangeCallbackResult,System.Action<WeChatWASM.OnGameLiveStateChangeCallbackResponse>>);
			checkDelegate(l,2,out a1);
			self.OffGameLiveStateChange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetHandoffQuery(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			var ret=self.SetHandoffQuery(a1);
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
	static public int GetAccountInfoSync(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			var ret=self.GetAccountInfoSync();
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
	static public int GetAppAuthorizeSetting(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			var ret=self.GetAppAuthorizeSetting();
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
	static public int GetAppBaseInfo(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			var ret=self.GetAppBaseInfo();
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
	static public int GetBatteryInfoSync(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			var ret=self.GetBatteryInfoSync();
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
	static public int GetDeviceInfo(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			var ret=self.GetDeviceInfo();
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
	static public int GetEnterOptionsSync(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			var ret=self.GetEnterOptionsSync();
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
	static public int GetLaunchOptionsSync(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			var ret=self.GetLaunchOptionsSync();
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
	static public int GetMenuButtonBoundingClientRect(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			var ret=self.GetMenuButtonBoundingClientRect();
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
	static public int GetStorageInfoSync(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			var ret=self.GetStorageInfoSync();
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
	static public int GetSystemInfoSync(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			var ret=self.GetSystemInfoSync();
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
	static public int GetSystemSetting(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			var ret=self.GetSystemSetting();
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
	static public int GetWindowInfo(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			var ret=self.GetWindowInfo();
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
	static public int CreateImageData(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			var ret=self.CreateImageData();
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
	static public int CreatePath2D(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			var ret=self.CreatePath2D();
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
	static public int SetCursor(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			System.Double a2 = default(System.Double);
			checkType(l,3,out a2);
			System.Double a3 = default(System.Double);
			checkType(l,4,out a3);
			var ret=self.SetCursor(a1,a2,a3);
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
	static public int SetMessageToFriendQuery(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.SetMessageToFriendQueryOption a1 = default(WeChatWASM.SetMessageToFriendQueryOption);
			checkType(l,2,out a1);
			var ret=self.SetMessageToFriendQuery(a1);
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
	static public int GetTextLineHeight(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.GetTextLineHeightOption a1 = default(WeChatWASM.GetTextLineHeightOption);
			checkType(l,2,out a1);
			var ret=self.GetTextLineHeight(a1);
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
	static public int LoadFont(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			var ret=self.LoadFont(a1);
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
	static public int GetGameLiveState(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			var ret=self.GetGameLiveState();
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
	static public int DownloadFileCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.DownloadFileCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DownloadFile(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.DownloadFileOption a1 = default(WeChatWASM.DownloadFileOption);
			checkType(l,2,out a1);
			var ret=self.DownloadFile(a1);
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
	static public int CreateFeedbackButton(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.CreateOpenSettingButtonOption a1 = default(WeChatWASM.CreateOpenSettingButtonOption);
			checkType(l,2,out a1);
			var ret=self.CreateFeedbackButton(a1);
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
	static public int GetLogManager(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.GetLogManagerOption a1 = default(WeChatWASM.GetLogManagerOption);
			checkType(l,2,out a1);
			var ret=self.GetLogManager(a1);
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
	static public int GetRealtimeLogManager(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			var ret=self.GetRealtimeLogManager();
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
	static public int GetUpdateManager(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			var ret=self.GetUpdateManager();
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
	static public int CreateVideoDecoder(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			var ret=self.CreateVideoDecoder();
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
	static public int _DownloadTaskOnHeadersReceivedCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._DownloadTaskOnHeadersReceivedCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _DownloadTaskOnProgressUpdateCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._DownloadTaskOnProgressUpdateCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _FeedbackButtonOnTapCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._FeedbackButtonOnTapCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _UpdateManagerOnCheckForUpdateCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._UpdateManagerOnCheckForUpdateCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _UpdateManagerOnUpdateFailedCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._UpdateManagerOnUpdateFailedCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _UpdateManagerOnUpdateReadyCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._UpdateManagerOnUpdateReadyCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _VideoDecoderOnCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._VideoDecoderOnCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnDestroy(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			self.OnDestroy();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Inited(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Int32 a1 = default(System.Int32);
			checkType(l,2,out a1);
			self.Inited(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int TextResponseCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.TextResponseCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int TextResponseLongCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.TextResponseLongCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CloudCallFunctionResponseCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.CloudCallFunctionResponseCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int UserInfoButtonOnTapCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.UserInfoButtonOnTapCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnShareAppMessageCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			self.OnShareAppMessageCallback();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ADOnErrorCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.ADOnErrorCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ADOnLoadCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.ADOnLoadCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ADOnResizeCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.ADOnResizeCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ADOnVideoCloseCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.ADOnVideoCloseCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ADOnHideCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.ADOnHideCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ADOnCloseCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.ADOnCloseCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ADLoadErrorCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.ADLoadErrorCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnGameClubButtonCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.OnGameClubButtonCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnAudioCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.OnAudioCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WXPreDownloadAudiosCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.WXPreDownloadAudiosCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnVideoCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.OnVideoCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StatCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.StatCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int FileSystemManagerCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.FileSystemManagerCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ToTempFilePathCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.ToTempFilePathCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetFontRawDataCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.GetFontRawDataCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int InitSDK(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<System.Int32> a1 = default(System.Action<System.Int32>);
			checkDelegate(l,2,out a1);
			self.InitSDK(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StorageSetIntSync(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			System.Int32 a2 = default(System.Int32);
			checkType(l,3,out a2);
			self.StorageSetIntSync(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StorageGetIntSync(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			System.Int32 a2 = default(System.Int32);
			checkType(l,3,out a2);
			var ret=self.StorageGetIntSync(a1,a2);
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
	static public int StorageSetStringSync(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			System.String a2 = default(System.String);
			checkType(l,3,out a2);
			self.StorageSetStringSync(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StorageGetStringSync(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			System.String a2 = default(System.String);
			checkType(l,3,out a2);
			var ret=self.StorageGetStringSync(a1,a2);
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
	static public int StorageSetFloatSync(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			System.Single a2 = default(System.Single);
			checkType(l,3,out a2);
			self.StorageSetFloatSync(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StorageGetFloatSync(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			System.Single a2 = default(System.Single);
			checkType(l,3,out a2);
			var ret=self.StorageGetFloatSync(a1,a2);
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
	static public int StorageDeleteAllSync(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			self.StorageDeleteAllSync();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StorageDeleteKeySync(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.StorageDeleteKeySync(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StorageHasKeySync(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			var ret=self.StorageHasKeySync(a1);
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
	static public int CreateUserInfoButton(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Int32 a1 = default(System.Int32);
			checkType(l,2,out a1);
			System.Int32 a2 = default(System.Int32);
			checkType(l,3,out a2);
			System.Int32 a3 = default(System.Int32);
			checkType(l,4,out a3);
			System.Int32 a4 = default(System.Int32);
			checkType(l,5,out a4);
			System.String a5 = default(System.String);
			checkType(l,6,out a5);
			System.Boolean a6 = default(System.Boolean);
			checkType(l,7,out a6);
			var ret=self.CreateUserInfoButton(a1,a2,a3,a4,a5,a6);
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
	static public int OnShareAppMessage(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.WXShareAppMessageParam a1 = default(WeChatWASM.WXShareAppMessageParam);
			checkType(l,2,out a1);
			System.Action<System.Action<WeChatWASM.WXShareAppMessageParam>> a2 = default(System.Action<System.Action<WeChatWASM.WXShareAppMessageParam>>);
			checkDelegate(l,3,out a2);
			self.OnShareAppMessage(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CreateBannerAd(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.WXCreateBannerAdParam a1 = default(WeChatWASM.WXCreateBannerAdParam);
			checkType(l,2,out a1);
			var ret=self.CreateBannerAd(a1);
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
	static public int CreateFixedBottomMiddleBannerAd(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			System.Int32 a2 = default(System.Int32);
			checkType(l,3,out a2);
			System.Int32 a3 = default(System.Int32);
			checkType(l,4,out a3);
			var ret=self.CreateFixedBottomMiddleBannerAd(a1,a2,a3);
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
	static public int CreateRewardedVideoAd(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.WXCreateRewardedVideoAdParam a1 = default(WeChatWASM.WXCreateRewardedVideoAdParam);
			checkType(l,2,out a1);
			var ret=self.CreateRewardedVideoAd(a1);
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
	static public int CreateInterstitialAd(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.WXCreateInterstitialAdParam a1 = default(WeChatWASM.WXCreateInterstitialAdParam);
			checkType(l,2,out a1);
			var ret=self.CreateInterstitialAd(a1);
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
	static public int CreateCustomAd(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.WXCreateCustomAdParam a1 = default(WeChatWASM.WXCreateCustomAdParam);
			checkType(l,2,out a1);
			var ret=self.CreateCustomAd(a1);
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
	static public int ADStyleChange(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			System.String a2 = default(System.String);
			checkType(l,3,out a2);
			System.Int32 a3 = default(System.Int32);
			checkType(l,4,out a3);
			self.ADStyleChange(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ShowAd(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
				System.String a1 = default(System.String);
				checkType(l,2,out a1);
				System.String a2 = default(System.String);
				checkType(l,3,out a2);
				System.String a3 = default(System.String);
				checkType(l,4,out a3);
				self.ShowAd(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(argc==6){
				WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
				System.String a1 = default(System.String);
				checkType(l,2,out a1);
				System.String a2 = default(System.String);
				checkType(l,3,out a2);
				System.String a3 = default(System.String);
				checkType(l,4,out a3);
				System.String a4 = default(System.String);
				checkType(l,5,out a4);
				System.String a5 = default(System.String);
				checkType(l,6,out a5);
				self.ShowAd(a1,a2,a3,a4,a5);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function ShowAd to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CreateUDPSocket(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			System.Int32 a2 = default(System.Int32);
			checkType(l,3,out a2);
			System.Int32 a3 = default(System.Int32);
			checkType(l,4,out a3);
			var ret=self.CreateUDPSocket(a1,a2,a3);
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
	static public int CloseUDPSocket(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Int32 a1 = default(System.Int32);
			checkType(l,2,out a1);
			self.CloseUDPSocket(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SendUDPSocket(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Int32 a1 = default(System.Int32);
			checkType(l,2,out a1);
			System.Byte[] a2 = default(System.Byte[]);
			checkArray(l,3,out a2);
			System.Int32 a3 = default(System.Int32);
			checkType(l,4,out a3);
			System.Int32 a4 = default(System.Int32);
			checkType(l,5,out a4);
			self.SendUDPSocket(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int HideAd(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			System.String a2 = default(System.String);
			checkType(l,3,out a2);
			System.String a3 = default(System.String);
			checkType(l,4,out a3);
			self.HideAd(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ADGetStyleValue(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			System.String a2 = default(System.String);
			checkType(l,3,out a2);
			var ret=self.ADGetStyleValue(a1,a2);
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
	static public int ADDestroy(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.ADDestroy(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ADLoad(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			System.String a2 = default(System.String);
			checkType(l,3,out a2);
			System.String a3 = default(System.String);
			checkType(l,4,out a3);
			self.ADLoad(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenDataContextPostMessage(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.OpenDataContextPostMessage(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ShowOpenData(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			UnityEngine.Texture a1 = default(UnityEngine.Texture);
			checkType(l,2,out a1);
			System.Int32 a2 = default(System.Int32);
			checkType(l,3,out a2);
			System.Int32 a3 = default(System.Int32);
			checkType(l,4,out a3);
			System.Int32 a4 = default(System.Int32);
			checkType(l,5,out a4);
			System.Int32 a5 = default(System.Int32);
			checkType(l,6,out a5);
			self.ShowOpenData(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int HideOpenData(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			self.HideOpenData();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReportGameStart(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			self.ReportGameStart();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReportGameSceneError(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Int32 a1 = default(System.Int32);
			checkType(l,2,out a1);
			System.Int32 a2 = default(System.Int32);
			checkType(l,3,out a2);
			System.String a3 = default(System.String);
			checkType(l,4,out a3);
			System.String a4 = default(System.String);
			checkType(l,5,out a4);
			self.ReportGameSceneError(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WriteLog(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.WriteLog(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WriteWarn(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.WriteWarn(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int HideLoadingPage(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			self.HideLoadingPage();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int PreloadConcurrent(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Int32 a1 = default(System.Int32);
			checkType(l,2,out a1);
			self.PreloadConcurrent(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CreateInnerAudioContext(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.InnerAudioContextParam a1 = default(WeChatWASM.InnerAudioContextParam);
			checkType(l,2,out a1);
			var ret=self.CreateInnerAudioContext(a1);
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
	static public int PreDownloadAudios(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String[] a1 = default(System.String[]);
			checkArray(l,2,out a1);
			System.Action<System.Int32> a2 = default(System.Action<System.Int32>);
			checkDelegate(l,3,out a2);
			self.PreDownloadAudios(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CreateVideo(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.WXCreateVideoParam a1 = default(WeChatWASM.WXCreateVideoParam);
			checkType(l,2,out a1);
			var ret=self.CreateVideo(a1);
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
	static public int GetTotalMemorySize(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			var ret=self.GetTotalMemorySize();
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
	static public int GetTotalStackSize(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			var ret=self.GetTotalStackSize();
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
	static public int GetStaticMemorySize(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			var ret=self.GetStaticMemorySize();
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
	static public int GetDynamicMemorySize(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			var ret=self.GetDynamicMemorySize();
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
	static public int GetUsedMemorySize(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			var ret=self.GetUsedMemorySize();
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
	static public int GetUnAllocatedMemorySize(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			var ret=self.GetUnAllocatedMemorySize();
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
	static public int GetEXFrameTime(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			var ret=self.GetEXFrameTime();
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
	static public int GetBundleNumberInMemory(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			var ret=self.GetBundleNumberInMemory();
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
	static public int GetBundleNumberOnDisk(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			var ret=self.GetBundleNumberOnDisk();
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
	static public int GetBundleSizeInMemory(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			var ret=self.GetBundleSizeInMemory();
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
	static public int GetBundleSizeOnDisk(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			var ret=self.GetBundleSizeOnDisk();
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
	static public int LogUnityHeapMem(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			self.LogUnityHeapMem();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ProfilingMemoryDump(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			self.ProfilingMemoryDump();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenProfileStats(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			self.OpenProfileStats();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DumpProfileStats(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			self.DumpProfileStats();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LogManagerDebug(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.LogManagerDebug(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LogManagerInfo(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.LogManagerInfo(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LogManagerLog(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.LogManagerLog(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LogManagerWarn(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.LogManagerWarn(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IsCloudTest(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			var ret=self.IsCloudTest();
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
	static public int UncaughtException(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			self.UncaughtException();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CreateGameClubButton(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.WXCreateGameClubButtonParam a1 = default(WeChatWASM.WXCreateGameClubButtonParam);
			checkType(l,2,out a1);
			var ret=self.CreateGameClubButton(a1);
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
	static public int GameClubStyleChangeInt(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			System.String a2 = default(System.String);
			checkType(l,3,out a2);
			System.Int32 a3 = default(System.Int32);
			checkType(l,4,out a3);
			self.GameClubStyleChangeInt(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GameClubStyleChangeStr(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			System.String a2 = default(System.String);
			checkType(l,3,out a2);
			System.String a3 = default(System.String);
			checkType(l,4,out a3);
			self.GameClubStyleChangeStr(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CleanAllFileCache(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<System.Boolean> a1 = default(System.Action<System.Boolean>);
			checkDelegate(l,2,out a1);
			self.CleanAllFileCache(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CleanAllFileCacheCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.CleanAllFileCacheCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CleanFileCache(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Int32 a1 = default(System.Int32);
			checkType(l,2,out a1);
			System.Action<WeChatWASM.ReleaseResult> a2 = default(System.Action<WeChatWASM.ReleaseResult>);
			checkDelegate(l,3,out a2);
			self.CleanFileCache(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CleanFileCacheCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.CleanFileCacheCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RemoveFile(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			System.Action<System.Boolean> a2 = default(System.Action<System.Boolean>);
			checkDelegate(l,3,out a2);
			self.RemoveFile(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RemoveFileCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.RemoveFileCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetCachePath(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			var ret=self.GetCachePath(a1);
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
	static public int OnLaunchProgress(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<WeChatWASM.LaunchEvent> a1 = default(System.Action<WeChatWASM.LaunchEvent>);
			checkDelegate(l,2,out a1);
			self.OnLaunchProgress(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnLaunchProgressCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.OnLaunchProgressCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RemoveLaunchProgressCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.RemoveLaunchProgressCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetDataCDN(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.SetDataCDN(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetPreloadList(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String[] a1 = default(System.String[]);
			checkArray(l,2,out a1);
			self.SetPreloadList(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetPreferredFramesPerSecond(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Double a1 = default(System.Double);
			checkType(l,2,out a1);
			self.SetPreferredFramesPerSecond(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CreateCamera(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.CreateCameraOption a1 = default(WeChatWASM.CreateCameraOption);
			checkType(l,2,out a1);
			var ret=self.CreateCamera(a1);
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
	static public int CameraCreateCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.CameraCreateCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CameraOnAuthCancelCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.CameraOnAuthCancelCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CameraOnCameraFrameCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.CameraOnCameraFrameCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CameraOnStopCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.CameraOnStopCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetGameRecorder(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			var ret=self.GetGameRecorder();
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
	static public int _OnGameRecorderCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnGameRecorderCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetRecorderManager(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			var ret=self.GetRecorderManager();
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
	static public int _OnRecorderErrorCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnRecorderErrorCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnRecorderFrameRecordedCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnRecorderFrameRecordedCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnRecorderInterruptionBeginCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnRecorderInterruptionBeginCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnRecorderInterruptionEndCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnRecorderInterruptionEndCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnRecorderPauseCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnRecorderPauseCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnRecorderStartCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnRecorderStartCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnRecorderStopCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnRecorderStopCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnRecorderResumeCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnRecorderResumeCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int UploadFile(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.UploadFileOption a1 = default(WeChatWASM.UploadFileOption);
			checkType(l,2,out a1);
			var ret=self.UploadFile(a1);
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
	static public int UploadFileCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.UploadFileCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnHeadersReceivedCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnHeadersReceivedCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnProgressUpdateCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnProgressUpdateCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CreateMiniGameChat(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.WXChatOptions a1 = default(WeChatWASM.WXChatOptions);
			checkType(l,2,out a1);
			var ret=self.CreateMiniGameChat(a1);
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
	static public int OnWXChatCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.OnWXChatCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _OnNeedPrivacyAuthorizationCallback(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._OnNeedPrivacyAuthorizationCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnNeedPrivacyAuthorization(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			System.Action<System.String> a1 = default(System.Action<System.String>);
			checkDelegate(l,2,out a1);
			self.OnNeedPrivacyAuthorization(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int PrivacyAuthorizeResolve(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler self=(WeChatWASM.WXSDKManagerHandler)checkSelf(l);
			WeChatWASM.PrivacyAuthorizeResolveOption a1 = default(WeChatWASM.PrivacyAuthorizeResolveOption);
			checkType(l,2,out a1);
			self.PrivacyAuthorizeResolve(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetProfileStatsScript_s(IntPtr l) {
		try {
			System.Type a1 = default(System.Type);
			checkType(l,1,out a1);
			WeChatWASM.WXSDKManagerHandler.SetProfileStatsScript(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WXSetArrayBuffer_s(IntPtr l) {
		try {
			System.Byte[] a1 = default(System.Byte[]);
			checkArray(l,1,out a1);
			System.String a2 = default(System.String);
			checkType(l,2,out a2);
			var ret=WeChatWASM.WXSDKManagerHandler.WXSetArrayBuffer(a1,a2);
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
	static public int get_Instance(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,WeChatWASM.WXSDKManagerHandler.Instance);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Env(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,WeChatWASM.WXSDKManagerHandler.Env);
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
			pushValue(l,WeChatWASM.WXSDKManagerHandler.cloud);
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
			pushValue(l,WeChatWASM.WXSDKManagerHandler.PluginCachePath);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXSDKManagerHandler");
		addMember(l,AddCardCallback);
		addMember(l,AddCard);
		addMember(l,AuthPrivateMessageCallback);
		addMember(l,AuthPrivateMessage);
		addMember(l,AuthorizeCallback);
		addMember(l,Authorize);
		addMember(l,CheckIsAddedToMyMiniProgramCallback);
		addMember(l,CheckIsAddedToMyMiniProgram);
		addMember(l,CheckSessionCallback);
		addMember(l,CheckSession);
		addMember(l,ChooseImageCallback);
		addMember(l,ChooseImage);
		addMember(l,ChooseMediaCallback);
		addMember(l,ChooseMedia);
		addMember(l,ChooseMessageFileCallback);
		addMember(l,ChooseMessageFile);
		addMember(l,CloseBLEConnectionCallback);
		addMember(l,CloseBLEConnection);
		addMember(l,CloseBluetoothAdapterCallback);
		addMember(l,CloseBluetoothAdapter);
		addMember(l,CompressImageCallback);
		addMember(l,CompressImage);
		addMember(l,CreateBLEConnectionCallback);
		addMember(l,CreateBLEConnection);
		addMember(l,CreateBLEPeripheralServerCallback);
		addMember(l,CreateBLEPeripheralServer);
		addMember(l,ExitMiniProgramCallback);
		addMember(l,ExitMiniProgram);
		addMember(l,ExitVoIPChatCallback);
		addMember(l,ExitVoIPChat);
		addMember(l,FaceDetectCallback);
		addMember(l,FaceDetect);
		addMember(l,GetAvailableAudioSourcesCallback);
		addMember(l,GetAvailableAudioSources);
		addMember(l,GetBLEDeviceCharacteristicsCallback);
		addMember(l,GetBLEDeviceCharacteristics);
		addMember(l,GetBLEDeviceRSSICallback);
		addMember(l,GetBLEDeviceRSSI);
		addMember(l,GetBLEDeviceServicesCallback);
		addMember(l,GetBLEDeviceServices);
		addMember(l,GetBLEMTUCallback);
		addMember(l,GetBLEMTU);
		addMember(l,GetBackgroundFetchDataCallback);
		addMember(l,GetBackgroundFetchData);
		addMember(l,GetBackgroundFetchTokenCallback);
		addMember(l,GetBackgroundFetchToken);
		addMember(l,GetBatteryInfoCallback);
		addMember(l,GetBatteryInfo);
		addMember(l,GetBeaconsCallback);
		addMember(l,GetBeacons);
		addMember(l,GetBluetoothAdapterStateCallback);
		addMember(l,GetBluetoothAdapterState);
		addMember(l,GetBluetoothDevicesCallback);
		addMember(l,GetBluetoothDevices);
		addMember(l,GetChannelsLiveInfoCallback);
		addMember(l,GetChannelsLiveInfo);
		addMember(l,GetChannelsLiveNoticeInfoCallback);
		addMember(l,GetChannelsLiveNoticeInfo);
		addMember(l,GetClipboardDataCallback);
		addMember(l,GetClipboardData);
		addMember(l,GetConnectedBluetoothDevicesCallback);
		addMember(l,GetConnectedBluetoothDevices);
		addMember(l,GetExtConfigCallback);
		addMember(l,GetExtConfig);
		addMember(l,GetFuzzyLocationCallback);
		addMember(l,GetFuzzyLocation);
		addMember(l,GetGameClubDataCallback);
		addMember(l,GetGameClubData);
		addMember(l,GetGroupEnterInfoCallback);
		addMember(l,GetGroupEnterInfo);
		addMember(l,GetInferenceEnvInfoCallback);
		addMember(l,GetInferenceEnvInfo);
		addMember(l,GetLocalIPAddressCallback);
		addMember(l,GetLocalIPAddress);
		addMember(l,GetLocationCallback);
		addMember(l,GetLocation);
		addMember(l,GetNetworkTypeCallback);
		addMember(l,GetNetworkType);
		addMember(l,GetPrivacySettingCallback);
		addMember(l,GetPrivacySetting);
		addMember(l,GetScreenBrightnessCallback);
		addMember(l,GetScreenBrightness);
		addMember(l,GetSettingCallback);
		addMember(l,GetSetting);
		addMember(l,GetShareInfoCallback);
		addMember(l,GetShareInfo);
		addMember(l,GetStorageInfoCallback);
		addMember(l,GetStorageInfo);
		addMember(l,GetSystemInfoCallback);
		addMember(l,GetSystemInfo);
		addMember(l,GetSystemInfoAsyncCallback);
		addMember(l,GetSystemInfoAsync);
		addMember(l,GetUserInfoCallback);
		addMember(l,GetUserInfo);
		addMember(l,GetUserInteractiveStorageCallback);
		addMember(l,GetUserInteractiveStorage);
		addMember(l,GetWeRunDataCallback);
		addMember(l,GetWeRunData);
		addMember(l,HideKeyboardCallback);
		addMember(l,HideKeyboard);
		addMember(l,HideLoadingCallback);
		addMember(l,HideLoading);
		addMember(l,HideShareMenuCallback);
		addMember(l,HideShareMenu);
		addMember(l,HideToastCallback);
		addMember(l,HideToast);
		addMember(l,InitFaceDetectCallback);
		addMember(l,InitFaceDetect);
		addMember(l,IsBluetoothDevicePairedCallback);
		addMember(l,IsBluetoothDevicePaired);
		addMember(l,JoinVoIPChatCallback);
		addMember(l,JoinVoIPChat);
		addMember(l,LoginCallback);
		addMember(l,Login);
		addMember(l,MakeBluetoothPairCallback);
		addMember(l,MakeBluetoothPair);
		addMember(l,NavigateToMiniProgramCallback);
		addMember(l,NavigateToMiniProgram);
		addMember(l,NotifyBLECharacteristicValueChangeCallback);
		addMember(l,NotifyBLECharacteristicValueChange);
		addMember(l,OpenAppAuthorizeSettingCallback);
		addMember(l,OpenAppAuthorizeSetting);
		addMember(l,OpenBluetoothAdapterCallback);
		addMember(l,OpenBluetoothAdapter);
		addMember(l,OpenCardCallback);
		addMember(l,OpenCard);
		addMember(l,OpenChannelsActivityCallback);
		addMember(l,OpenChannelsActivity);
		addMember(l,OpenChannelsEventCallback);
		addMember(l,OpenChannelsEvent);
		addMember(l,OpenChannelsLiveCallback);
		addMember(l,OpenChannelsLive);
		addMember(l,OpenChannelsUserProfileCallback);
		addMember(l,OpenChannelsUserProfile);
		addMember(l,OpenCustomerServiceChatCallback);
		addMember(l,OpenCustomerServiceChat);
		addMember(l,OpenCustomerServiceConversationCallback);
		addMember(l,OpenCustomerServiceConversation);
		addMember(l,OpenPrivacyContractCallback);
		addMember(l,OpenPrivacyContract);
		addMember(l,OpenSettingCallback);
		addMember(l,OpenSetting);
		addMember(l,OpenSystemBluetoothSettingCallback);
		addMember(l,OpenSystemBluetoothSetting);
		addMember(l,PreviewImageCallback);
		addMember(l,PreviewImage);
		addMember(l,PreviewMediaCallback);
		addMember(l,PreviewMedia);
		addMember(l,ReadBLECharacteristicValueCallback);
		addMember(l,ReadBLECharacteristicValue);
		addMember(l,RemoveStorageCallback);
		addMember(l,RemoveStorage);
		addMember(l,RemoveUserCloudStorageCallback);
		addMember(l,RemoveUserCloudStorage);
		addMember(l,ReportSceneCallback);
		addMember(l,ReportScene);
		addMember(l,RequestMidasFriendPaymentCallback);
		addMember(l,RequestMidasFriendPayment);
		addMember(l,RequestMidasPaymentCallback);
		addMember(l,RequestMidasPayment);
		addMember(l,RequestSubscribeMessageCallback);
		addMember(l,RequestSubscribeMessage);
		addMember(l,RequestSubscribeSystemMessageCallback);
		addMember(l,RequestSubscribeSystemMessage);
		addMember(l,RequirePrivacyAuthorizeCallback);
		addMember(l,RequirePrivacyAuthorize);
		addMember(l,RestartMiniProgramCallback);
		addMember(l,RestartMiniProgram);
		addMember(l,SaveFileToDiskCallback);
		addMember(l,SaveFileToDisk);
		addMember(l,SaveImageToPhotosAlbumCallback);
		addMember(l,SaveImageToPhotosAlbum);
		addMember(l,ScanCodeCallback);
		addMember(l,ScanCode);
		addMember(l,SetBLEMTUCallback);
		addMember(l,SetBLEMTU);
		addMember(l,SetBackgroundFetchTokenCallback);
		addMember(l,SetBackgroundFetchToken);
		addMember(l,SetClipboardDataCallback);
		addMember(l,SetClipboardData);
		addMember(l,SetDeviceOrientationCallback);
		addMember(l,SetDeviceOrientation);
		addMember(l,SetEnableDebugCallback);
		addMember(l,SetEnableDebug);
		addMember(l,SetInnerAudioOptionCallback);
		addMember(l,SetInnerAudioOption);
		addMember(l,SetKeepScreenOnCallback);
		addMember(l,SetKeepScreenOn);
		addMember(l,SetMenuStyleCallback);
		addMember(l,SetMenuStyle);
		addMember(l,SetScreenBrightnessCallback);
		addMember(l,SetScreenBrightness);
		addMember(l,SetStatusBarStyleCallback);
		addMember(l,SetStatusBarStyle);
		addMember(l,SetUserCloudStorageCallback);
		addMember(l,SetUserCloudStorage);
		addMember(l,ShowActionSheetCallback);
		addMember(l,ShowActionSheet);
		addMember(l,ShowKeyboardCallback);
		addMember(l,ShowKeyboard);
		addMember(l,ShowLoadingCallback);
		addMember(l,ShowLoading);
		addMember(l,ShowModalCallback);
		addMember(l,ShowModal);
		addMember(l,ShowShareImageMenuCallback);
		addMember(l,ShowShareImageMenu);
		addMember(l,ShowShareMenuCallback);
		addMember(l,ShowShareMenu);
		addMember(l,ShowToastCallback);
		addMember(l,ShowToast);
		addMember(l,StartAccelerometerCallback);
		addMember(l,StartAccelerometer);
		addMember(l,StartBeaconDiscoveryCallback);
		addMember(l,StartBeaconDiscovery);
		addMember(l,StartBluetoothDevicesDiscoveryCallback);
		addMember(l,StartBluetoothDevicesDiscovery);
		addMember(l,StartCompassCallback);
		addMember(l,StartCompass);
		addMember(l,StartDeviceMotionListeningCallback);
		addMember(l,StartDeviceMotionListening);
		addMember(l,StartGyroscopeCallback);
		addMember(l,StartGyroscope);
		addMember(l,StopAccelerometerCallback);
		addMember(l,StopAccelerometer);
		addMember(l,StopBeaconDiscoveryCallback);
		addMember(l,StopBeaconDiscovery);
		addMember(l,StopBluetoothDevicesDiscoveryCallback);
		addMember(l,StopBluetoothDevicesDiscovery);
		addMember(l,StopCompassCallback);
		addMember(l,StopCompass);
		addMember(l,StopDeviceMotionListeningCallback);
		addMember(l,StopDeviceMotionListening);
		addMember(l,StopFaceDetectCallback);
		addMember(l,StopFaceDetect);
		addMember(l,StopGyroscopeCallback);
		addMember(l,StopGyroscope);
		addMember(l,UpdateKeyboardCallback);
		addMember(l,UpdateKeyboard);
		addMember(l,UpdateShareMenuCallback);
		addMember(l,UpdateShareMenu);
		addMember(l,UpdateVoIPChatMuteConfigCallback);
		addMember(l,UpdateVoIPChatMuteConfig);
		addMember(l,UpdateWeChatAppCallback);
		addMember(l,UpdateWeChatApp);
		addMember(l,VibrateLongCallback);
		addMember(l,VibrateLong);
		addMember(l,VibrateShortCallback);
		addMember(l,VibrateShort);
		addMember(l,WriteBLECharacteristicValueCallback);
		addMember(l,WriteBLECharacteristicValue);
		addMember(l,StartGameLiveCallback);
		addMember(l,StartGameLive);
		addMember(l,CheckGameLiveEnabledCallback);
		addMember(l,CheckGameLiveEnabled);
		addMember(l,GetUserCurrentGameliveInfoCallback);
		addMember(l,GetUserCurrentGameliveInfo);
		addMember(l,GetUserRecentGameLiveInfoCallback);
		addMember(l,GetUserRecentGameLiveInfo);
		addMember(l,GetUserGameLiveDetailsCallback);
		addMember(l,GetUserGameLiveDetails);
		addMember(l,OpenChannelsLiveCollectionCallback);
		addMember(l,OpenChannelsLiveCollection);
		addMember(l,OpenPageCallback);
		addMember(l,OpenPage);
		addMember(l,RequestMidasPaymentGameItemCallback);
		addMember(l,RequestMidasPaymentGameItem);
		addMember(l,RequestSubscribeLiveActivityCallback);
		addMember(l,RequestSubscribeLiveActivity);
		addMember(l,OperateGameRecorderVideo);
		addMember(l,RemoveStorageSync);
		addMember(l,ReportMonitor);
		addMember(l,ReportPerformance);
		addMember(l,ReportUserBehaviorBranchAnalytics);
		addMember(l,ReserveChannelsLive);
		addMember(l,RevokeBufferURL);
		addMember(l,ShareAppMessage);
		addMember(l,TriggerGC);
		addMember(l,_OnAccelerometerChangeCallback);
		addMember(l,OnAccelerometerChange);
		addMember(l,OffAccelerometerChange);
		addMember(l,_OnAudioInterruptionBeginCallback);
		addMember(l,OnAudioInterruptionBegin);
		addMember(l,OffAudioInterruptionBegin);
		addMember(l,_OnAudioInterruptionEndCallback);
		addMember(l,OnAudioInterruptionEnd);
		addMember(l,OffAudioInterruptionEnd);
		addMember(l,_OnBLECharacteristicValueChangeCallback);
		addMember(l,OnBLECharacteristicValueChange);
		addMember(l,OffBLECharacteristicValueChange);
		addMember(l,_OnBLEConnectionStateChangeCallback);
		addMember(l,OnBLEConnectionStateChange);
		addMember(l,OffBLEConnectionStateChange);
		addMember(l,_OnBLEMTUChangeCallback);
		addMember(l,OnBLEMTUChange);
		addMember(l,OffBLEMTUChange);
		addMember(l,_OnBLEPeripheralConnectionStateChangedCallback);
		addMember(l,OnBLEPeripheralConnectionStateChanged);
		addMember(l,OffBLEPeripheralConnectionStateChanged);
		addMember(l,_OnBackgroundFetchDataCallback);
		addMember(l,OnBackgroundFetchData);
		addMember(l,_OnBeaconServiceChangeCallback);
		addMember(l,OnBeaconServiceChange);
		addMember(l,OffBeaconServiceChange);
		addMember(l,_OnBeaconUpdateCallback);
		addMember(l,OnBeaconUpdate);
		addMember(l,OffBeaconUpdate);
		addMember(l,_OnBluetoothAdapterStateChangeCallback);
		addMember(l,OnBluetoothAdapterStateChange);
		addMember(l,OffBluetoothAdapterStateChange);
		addMember(l,_OnBluetoothDeviceFoundCallback);
		addMember(l,OnBluetoothDeviceFound);
		addMember(l,OffBluetoothDeviceFound);
		addMember(l,_OnCompassChangeCallback);
		addMember(l,OnCompassChange);
		addMember(l,OffCompassChange);
		addMember(l,_OnDeviceMotionChangeCallback);
		addMember(l,OnDeviceMotionChange);
		addMember(l,OffDeviceMotionChange);
		addMember(l,_OnDeviceOrientationChangeCallback);
		addMember(l,OnDeviceOrientationChange);
		addMember(l,OffDeviceOrientationChange);
		addMember(l,_OnErrorCallback);
		addMember(l,OnError);
		addMember(l,OffError);
		addMember(l,_OnGyroscopeChangeCallback);
		addMember(l,OnGyroscopeChange);
		addMember(l,OffGyroscopeChange);
		addMember(l,_OnHideCallback);
		addMember(l,OnHide);
		addMember(l,OffHide);
		addMember(l,_OnInteractiveStorageModifiedCallback);
		addMember(l,OnInteractiveStorageModified);
		addMember(l,OffInteractiveStorageModified);
		addMember(l,_OnKeyDownCallback);
		addMember(l,OnKeyDown);
		addMember(l,OffKeyDown);
		addMember(l,_OnKeyUpCallback);
		addMember(l,OnKeyUp);
		addMember(l,OffKeyUp);
		addMember(l,_OnKeyboardCompleteCallback);
		addMember(l,OnKeyboardComplete);
		addMember(l,OffKeyboardComplete);
		addMember(l,_OnKeyboardConfirmCallback);
		addMember(l,OnKeyboardConfirm);
		addMember(l,OffKeyboardConfirm);
		addMember(l,_OnKeyboardHeightChangeCallback);
		addMember(l,OnKeyboardHeightChange);
		addMember(l,OffKeyboardHeightChange);
		addMember(l,_OnKeyboardInputCallback);
		addMember(l,OnKeyboardInput);
		addMember(l,OffKeyboardInput);
		addMember(l,_OnMemoryWarningCallback);
		addMember(l,OnMemoryWarning);
		addMember(l,OffMemoryWarning);
		addMember(l,_OnMessageCallback);
		addMember(l,OnMessage);
		addMember(l,_OnMouseDownCallback);
		addMember(l,OnMouseDown);
		addMember(l,OffMouseDown);
		addMember(l,_OnMouseMoveCallback);
		addMember(l,OnMouseMove);
		addMember(l,OffMouseMove);
		addMember(l,_OnMouseUpCallback);
		addMember(l,OnMouseUp);
		addMember(l,OffMouseUp);
		addMember(l,_OnNetworkStatusChangeCallback);
		addMember(l,OnNetworkStatusChange);
		addMember(l,OffNetworkStatusChange);
		addMember(l,_OnNetworkWeakChangeCallback);
		addMember(l,OnNetworkWeakChange);
		addMember(l,OffNetworkWeakChange);
		addMember(l,_OnShareMessageToFriendCallback);
		addMember(l,OnShareMessageToFriend);
		addMember(l,_OnShowCallback);
		addMember(l,OnShow);
		addMember(l,OffShow);
		addMember(l,_OnTouchCancelCallback);
		addMember(l,OnTouchCancel);
		addMember(l,OffTouchCancel);
		addMember(l,_OnTouchEndCallback);
		addMember(l,OnTouchEnd);
		addMember(l,OffTouchEnd);
		addMember(l,_OnTouchMoveCallback);
		addMember(l,OnTouchMove);
		addMember(l,OffTouchMove);
		addMember(l,_OnTouchStartCallback);
		addMember(l,OnTouchStart);
		addMember(l,OffTouchStart);
		addMember(l,_OnUnhandledRejectionCallback);
		addMember(l,OnUnhandledRejection);
		addMember(l,OffUnhandledRejection);
		addMember(l,_OnUserCaptureScreenCallback);
		addMember(l,OnUserCaptureScreen);
		addMember(l,OffUserCaptureScreen);
		addMember(l,_OnVoIPChatInterruptedCallback);
		addMember(l,OnVoIPChatInterrupted);
		addMember(l,OffVoIPChatInterrupted);
		addMember(l,_OnVoIPChatMembersChangedCallback);
		addMember(l,OnVoIPChatMembersChanged);
		addMember(l,OffVoIPChatMembersChanged);
		addMember(l,_OnVoIPChatSpeakersChangedCallback);
		addMember(l,OnVoIPChatSpeakersChanged);
		addMember(l,OffVoIPChatSpeakersChanged);
		addMember(l,_OnVoIPChatStateChangedCallback);
		addMember(l,OnVoIPChatStateChanged);
		addMember(l,OffVoIPChatStateChanged);
		addMember(l,_OnWheelCallback);
		addMember(l,OnWheel);
		addMember(l,OffWheel);
		addMember(l,_OnWindowResizeCallback);
		addMember(l,OnWindowResize);
		addMember(l,OffWindowResize);
		addMember(l,_OnAddToFavoritesCallback);
		addMember(l,OnAddToFavorites);
		addMember(l,OffAddToFavorites);
		addMember(l,_OnCopyUrlCallback);
		addMember(l,OnCopyUrl);
		addMember(l,OffCopyUrl);
		addMember(l,_OnHandoffCallback);
		addMember(l,OnHandoff);
		addMember(l,OffHandoff);
		addMember(l,_OnShareTimelineCallback);
		addMember(l,OnShareTimeline);
		addMember(l,OffShareTimeline);
		addMember(l,_OnGameLiveStateChangeCallback);
		addMember(l,OnGameLiveStateChange);
		addMember(l,OffGameLiveStateChange);
		addMember(l,SetHandoffQuery);
		addMember(l,GetAccountInfoSync);
		addMember(l,GetAppAuthorizeSetting);
		addMember(l,GetAppBaseInfo);
		addMember(l,GetBatteryInfoSync);
		addMember(l,GetDeviceInfo);
		addMember(l,GetEnterOptionsSync);
		addMember(l,GetLaunchOptionsSync);
		addMember(l,GetMenuButtonBoundingClientRect);
		addMember(l,GetStorageInfoSync);
		addMember(l,GetSystemInfoSync);
		addMember(l,GetSystemSetting);
		addMember(l,GetWindowInfo);
		addMember(l,CreateImageData);
		addMember(l,CreatePath2D);
		addMember(l,SetCursor);
		addMember(l,SetMessageToFriendQuery);
		addMember(l,GetTextLineHeight);
		addMember(l,LoadFont);
		addMember(l,GetGameLiveState);
		addMember(l,DownloadFileCallback);
		addMember(l,DownloadFile);
		addMember(l,CreateFeedbackButton);
		addMember(l,GetLogManager);
		addMember(l,GetRealtimeLogManager);
		addMember(l,GetUpdateManager);
		addMember(l,CreateVideoDecoder);
		addMember(l,_DownloadTaskOnHeadersReceivedCallback);
		addMember(l,_DownloadTaskOnProgressUpdateCallback);
		addMember(l,_FeedbackButtonOnTapCallback);
		addMember(l,_UpdateManagerOnCheckForUpdateCallback);
		addMember(l,_UpdateManagerOnUpdateFailedCallback);
		addMember(l,_UpdateManagerOnUpdateReadyCallback);
		addMember(l,_VideoDecoderOnCallback);
		addMember(l,OnDestroy);
		addMember(l,Inited);
		addMember(l,TextResponseCallback);
		addMember(l,TextResponseLongCallback);
		addMember(l,CloudCallFunctionResponseCallback);
		addMember(l,UserInfoButtonOnTapCallback);
		addMember(l,OnShareAppMessageCallback);
		addMember(l,ADOnErrorCallback);
		addMember(l,ADOnLoadCallback);
		addMember(l,ADOnResizeCallback);
		addMember(l,ADOnVideoCloseCallback);
		addMember(l,ADOnHideCallback);
		addMember(l,ADOnCloseCallback);
		addMember(l,ADLoadErrorCallback);
		addMember(l,OnGameClubButtonCallback);
		addMember(l,OnAudioCallback);
		addMember(l,WXPreDownloadAudiosCallback);
		addMember(l,OnVideoCallback);
		addMember(l,StatCallback);
		addMember(l,FileSystemManagerCallback);
		addMember(l,ToTempFilePathCallback);
		addMember(l,GetFontRawDataCallback);
		addMember(l,InitSDK);
		addMember(l,StorageSetIntSync);
		addMember(l,StorageGetIntSync);
		addMember(l,StorageSetStringSync);
		addMember(l,StorageGetStringSync);
		addMember(l,StorageSetFloatSync);
		addMember(l,StorageGetFloatSync);
		addMember(l,StorageDeleteAllSync);
		addMember(l,StorageDeleteKeySync);
		addMember(l,StorageHasKeySync);
		addMember(l,CreateUserInfoButton);
		addMember(l,OnShareAppMessage);
		addMember(l,CreateBannerAd);
		addMember(l,CreateFixedBottomMiddleBannerAd);
		addMember(l,CreateRewardedVideoAd);
		addMember(l,CreateInterstitialAd);
		addMember(l,CreateCustomAd);
		addMember(l,ADStyleChange);
		addMember(l,ShowAd);
		addMember(l,CreateUDPSocket);
		addMember(l,CloseUDPSocket);
		addMember(l,SendUDPSocket);
		addMember(l,HideAd);
		addMember(l,ADGetStyleValue);
		addMember(l,ADDestroy);
		addMember(l,ADLoad);
		addMember(l,OpenDataContextPostMessage);
		addMember(l,ShowOpenData);
		addMember(l,HideOpenData);
		addMember(l,ReportGameStart);
		addMember(l,ReportGameSceneError);
		addMember(l,WriteLog);
		addMember(l,WriteWarn);
		addMember(l,HideLoadingPage);
		addMember(l,PreloadConcurrent);
		addMember(l,CreateInnerAudioContext);
		addMember(l,PreDownloadAudios);
		addMember(l,CreateVideo);
		addMember(l,GetTotalMemorySize);
		addMember(l,GetTotalStackSize);
		addMember(l,GetStaticMemorySize);
		addMember(l,GetDynamicMemorySize);
		addMember(l,GetUsedMemorySize);
		addMember(l,GetUnAllocatedMemorySize);
		addMember(l,GetEXFrameTime);
		addMember(l,GetBundleNumberInMemory);
		addMember(l,GetBundleNumberOnDisk);
		addMember(l,GetBundleSizeInMemory);
		addMember(l,GetBundleSizeOnDisk);
		addMember(l,LogUnityHeapMem);
		addMember(l,ProfilingMemoryDump);
		addMember(l,OpenProfileStats);
		addMember(l,DumpProfileStats);
		addMember(l,LogManagerDebug);
		addMember(l,LogManagerInfo);
		addMember(l,LogManagerLog);
		addMember(l,LogManagerWarn);
		addMember(l,IsCloudTest);
		addMember(l,UncaughtException);
		addMember(l,CreateGameClubButton);
		addMember(l,GameClubStyleChangeInt);
		addMember(l,GameClubStyleChangeStr);
		addMember(l,CleanAllFileCache);
		addMember(l,CleanAllFileCacheCallback);
		addMember(l,CleanFileCache);
		addMember(l,CleanFileCacheCallback);
		addMember(l,RemoveFile);
		addMember(l,RemoveFileCallback);
		addMember(l,GetCachePath);
		addMember(l,OnLaunchProgress);
		addMember(l,OnLaunchProgressCallback);
		addMember(l,RemoveLaunchProgressCallback);
		addMember(l,SetDataCDN);
		addMember(l,SetPreloadList);
		addMember(l,SetPreferredFramesPerSecond);
		addMember(l,CreateCamera);
		addMember(l,CameraCreateCallback);
		addMember(l,CameraOnAuthCancelCallback);
		addMember(l,CameraOnCameraFrameCallback);
		addMember(l,CameraOnStopCallback);
		addMember(l,GetGameRecorder);
		addMember(l,_OnGameRecorderCallback);
		addMember(l,GetRecorderManager);
		addMember(l,_OnRecorderErrorCallback);
		addMember(l,_OnRecorderFrameRecordedCallback);
		addMember(l,_OnRecorderInterruptionBeginCallback);
		addMember(l,_OnRecorderInterruptionEndCallback);
		addMember(l,_OnRecorderPauseCallback);
		addMember(l,_OnRecorderStartCallback);
		addMember(l,_OnRecorderStopCallback);
		addMember(l,_OnRecorderResumeCallback);
		addMember(l,UploadFile);
		addMember(l,UploadFileCallback);
		addMember(l,_OnHeadersReceivedCallback);
		addMember(l,_OnProgressUpdateCallback);
		addMember(l,CreateMiniGameChat);
		addMember(l,OnWXChatCallback);
		addMember(l,_OnNeedPrivacyAuthorizationCallback);
		addMember(l,OnNeedPrivacyAuthorization);
		addMember(l,PrivacyAuthorizeResolve);
		addMember(l,SetProfileStatsScript_s);
		addMember(l,WXSetArrayBuffer_s);
		addMember(l,"Instance",get_Instance,null,false);
		addMember(l,"Env",get_Env,null,false);
		addMember(l,"cloud",get_cloud,null,false);
		addMember(l,"PluginCachePath",get_PluginCachePath,null,false);
		createTypeMetatable(l,null, typeof(WeChatWASM.WXSDKManagerHandler),typeof(UnityEngine.MonoBehaviour));
	}
}
