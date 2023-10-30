//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_SystemInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.SystemInfo o;
			o=new WeChatWASM.SystemInfo();
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
	static public int get_SDKVersion(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.SDKVersion);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_SDKVersion(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.SDKVersion=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_albumAuthorized(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.albumAuthorized);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_albumAuthorized(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.albumAuthorized=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_benchmarkLevel(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.benchmarkLevel);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_benchmarkLevel(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.benchmarkLevel=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_bluetoothEnabled(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.bluetoothEnabled);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_bluetoothEnabled(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.bluetoothEnabled=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_brand(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.brand);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_brand(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.brand=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_cameraAuthorized(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.cameraAuthorized);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_cameraAuthorized(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.cameraAuthorized=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_deviceOrientation(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.deviceOrientation);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_deviceOrientation(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.deviceOrientation=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_enableDebug(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.enableDebug);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_enableDebug(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.enableDebug=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_fontSizeSetting(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.fontSizeSetting);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_fontSizeSetting(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.fontSizeSetting=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_host(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.host);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_host(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			WeChatWASM.SystemInfoHost v;
			checkType(l,2,out v);
			self.host=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_language(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.language);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_language(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.language=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_locationAuthorized(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.locationAuthorized);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_locationAuthorized(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.locationAuthorized=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_locationEnabled(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.locationEnabled);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_locationEnabled(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.locationEnabled=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_locationReducedAccuracy(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.locationReducedAccuracy);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_locationReducedAccuracy(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.locationReducedAccuracy=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_microphoneAuthorized(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.microphoneAuthorized);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_microphoneAuthorized(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.microphoneAuthorized=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_model(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.model);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_model(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.model=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_notificationAlertAuthorized(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.notificationAlertAuthorized);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_notificationAlertAuthorized(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.notificationAlertAuthorized=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_notificationAuthorized(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.notificationAuthorized);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_notificationAuthorized(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.notificationAuthorized=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_notificationBadgeAuthorized(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.notificationBadgeAuthorized);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_notificationBadgeAuthorized(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.notificationBadgeAuthorized=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_notificationSoundAuthorized(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.notificationSoundAuthorized);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_notificationSoundAuthorized(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.notificationSoundAuthorized=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_phoneCalendarAuthorized(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.phoneCalendarAuthorized);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_phoneCalendarAuthorized(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.phoneCalendarAuthorized=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_pixelRatio(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.pixelRatio);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_pixelRatio(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.pixelRatio=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_platform(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.platform);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_platform(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.platform=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_safeArea(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.safeArea);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_safeArea(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			WeChatWASM.SafeArea v;
			checkType(l,2,out v);
			self.safeArea=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_screenHeight(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.screenHeight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_screenHeight(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.screenHeight=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_screenWidth(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.screenWidth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_screenWidth(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.screenWidth=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_statusBarHeight(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.statusBarHeight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_statusBarHeight(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.statusBarHeight=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_system(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.system);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_system(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.system=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_version(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.version);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_version(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.version=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_wifiEnabled(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.wifiEnabled);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_wifiEnabled(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.wifiEnabled=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_windowHeight(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.windowHeight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_windowHeight(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.windowHeight=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_windowWidth(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.windowWidth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_windowWidth(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.windowWidth=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_theme(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.theme);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_theme(IntPtr l) {
		try {
			WeChatWASM.SystemInfo self=(WeChatWASM.SystemInfo)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.theme=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.SystemInfo");
		addMember(l,"SDKVersion",get_SDKVersion,set_SDKVersion,true);
		addMember(l,"albumAuthorized",get_albumAuthorized,set_albumAuthorized,true);
		addMember(l,"benchmarkLevel",get_benchmarkLevel,set_benchmarkLevel,true);
		addMember(l,"bluetoothEnabled",get_bluetoothEnabled,set_bluetoothEnabled,true);
		addMember(l,"brand",get_brand,set_brand,true);
		addMember(l,"cameraAuthorized",get_cameraAuthorized,set_cameraAuthorized,true);
		addMember(l,"deviceOrientation",get_deviceOrientation,set_deviceOrientation,true);
		addMember(l,"enableDebug",get_enableDebug,set_enableDebug,true);
		addMember(l,"fontSizeSetting",get_fontSizeSetting,set_fontSizeSetting,true);
		addMember(l,"host",get_host,set_host,true);
		addMember(l,"language",get_language,set_language,true);
		addMember(l,"locationAuthorized",get_locationAuthorized,set_locationAuthorized,true);
		addMember(l,"locationEnabled",get_locationEnabled,set_locationEnabled,true);
		addMember(l,"locationReducedAccuracy",get_locationReducedAccuracy,set_locationReducedAccuracy,true);
		addMember(l,"microphoneAuthorized",get_microphoneAuthorized,set_microphoneAuthorized,true);
		addMember(l,"model",get_model,set_model,true);
		addMember(l,"notificationAlertAuthorized",get_notificationAlertAuthorized,set_notificationAlertAuthorized,true);
		addMember(l,"notificationAuthorized",get_notificationAuthorized,set_notificationAuthorized,true);
		addMember(l,"notificationBadgeAuthorized",get_notificationBadgeAuthorized,set_notificationBadgeAuthorized,true);
		addMember(l,"notificationSoundAuthorized",get_notificationSoundAuthorized,set_notificationSoundAuthorized,true);
		addMember(l,"phoneCalendarAuthorized",get_phoneCalendarAuthorized,set_phoneCalendarAuthorized,true);
		addMember(l,"pixelRatio",get_pixelRatio,set_pixelRatio,true);
		addMember(l,"platform",get_platform,set_platform,true);
		addMember(l,"safeArea",get_safeArea,set_safeArea,true);
		addMember(l,"screenHeight",get_screenHeight,set_screenHeight,true);
		addMember(l,"screenWidth",get_screenWidth,set_screenWidth,true);
		addMember(l,"statusBarHeight",get_statusBarHeight,set_statusBarHeight,true);
		addMember(l,"system",get_system,set_system,true);
		addMember(l,"version",get_version,set_version,true);
		addMember(l,"wifiEnabled",get_wifiEnabled,set_wifiEnabled,true);
		addMember(l,"windowHeight",get_windowHeight,set_windowHeight,true);
		addMember(l,"windowWidth",get_windowWidth,set_windowWidth,true);
		addMember(l,"theme",get_theme,set_theme,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.SystemInfo));
	}
}
