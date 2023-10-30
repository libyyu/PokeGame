//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_AppAuthorizeSetting : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.AppAuthorizeSetting o;
			o=new WeChatWASM.AppAuthorizeSetting();
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
	static public int get_albumAuthorized(IntPtr l) {
		try {
			WeChatWASM.AppAuthorizeSetting self=(WeChatWASM.AppAuthorizeSetting)checkSelf(l);
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
			WeChatWASM.AppAuthorizeSetting self=(WeChatWASM.AppAuthorizeSetting)checkSelf(l);
			System.String v;
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
	static public int get_bluetoothAuthorized(IntPtr l) {
		try {
			WeChatWASM.AppAuthorizeSetting self=(WeChatWASM.AppAuthorizeSetting)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.bluetoothAuthorized);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_bluetoothAuthorized(IntPtr l) {
		try {
			WeChatWASM.AppAuthorizeSetting self=(WeChatWASM.AppAuthorizeSetting)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.bluetoothAuthorized=v;
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
			WeChatWASM.AppAuthorizeSetting self=(WeChatWASM.AppAuthorizeSetting)checkSelf(l);
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
			WeChatWASM.AppAuthorizeSetting self=(WeChatWASM.AppAuthorizeSetting)checkSelf(l);
			System.String v;
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
	static public int get_locationAuthorized(IntPtr l) {
		try {
			WeChatWASM.AppAuthorizeSetting self=(WeChatWASM.AppAuthorizeSetting)checkSelf(l);
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
			WeChatWASM.AppAuthorizeSetting self=(WeChatWASM.AppAuthorizeSetting)checkSelf(l);
			System.String v;
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
	static public int get_locationReducedAccuracy(IntPtr l) {
		try {
			WeChatWASM.AppAuthorizeSetting self=(WeChatWASM.AppAuthorizeSetting)checkSelf(l);
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
			WeChatWASM.AppAuthorizeSetting self=(WeChatWASM.AppAuthorizeSetting)checkSelf(l);
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
			WeChatWASM.AppAuthorizeSetting self=(WeChatWASM.AppAuthorizeSetting)checkSelf(l);
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
			WeChatWASM.AppAuthorizeSetting self=(WeChatWASM.AppAuthorizeSetting)checkSelf(l);
			System.String v;
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
	static public int get_notificationAlertAuthorized(IntPtr l) {
		try {
			WeChatWASM.AppAuthorizeSetting self=(WeChatWASM.AppAuthorizeSetting)checkSelf(l);
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
			WeChatWASM.AppAuthorizeSetting self=(WeChatWASM.AppAuthorizeSetting)checkSelf(l);
			System.String v;
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
			WeChatWASM.AppAuthorizeSetting self=(WeChatWASM.AppAuthorizeSetting)checkSelf(l);
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
			WeChatWASM.AppAuthorizeSetting self=(WeChatWASM.AppAuthorizeSetting)checkSelf(l);
			System.String v;
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
			WeChatWASM.AppAuthorizeSetting self=(WeChatWASM.AppAuthorizeSetting)checkSelf(l);
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
			WeChatWASM.AppAuthorizeSetting self=(WeChatWASM.AppAuthorizeSetting)checkSelf(l);
			System.String v;
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
			WeChatWASM.AppAuthorizeSetting self=(WeChatWASM.AppAuthorizeSetting)checkSelf(l);
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
			WeChatWASM.AppAuthorizeSetting self=(WeChatWASM.AppAuthorizeSetting)checkSelf(l);
			System.String v;
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
			WeChatWASM.AppAuthorizeSetting self=(WeChatWASM.AppAuthorizeSetting)checkSelf(l);
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
			WeChatWASM.AppAuthorizeSetting self=(WeChatWASM.AppAuthorizeSetting)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.phoneCalendarAuthorized=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.AppAuthorizeSetting");
		addMember(l,"albumAuthorized",get_albumAuthorized,set_albumAuthorized,true);
		addMember(l,"bluetoothAuthorized",get_bluetoothAuthorized,set_bluetoothAuthorized,true);
		addMember(l,"cameraAuthorized",get_cameraAuthorized,set_cameraAuthorized,true);
		addMember(l,"locationAuthorized",get_locationAuthorized,set_locationAuthorized,true);
		addMember(l,"locationReducedAccuracy",get_locationReducedAccuracy,set_locationReducedAccuracy,true);
		addMember(l,"microphoneAuthorized",get_microphoneAuthorized,set_microphoneAuthorized,true);
		addMember(l,"notificationAlertAuthorized",get_notificationAlertAuthorized,set_notificationAlertAuthorized,true);
		addMember(l,"notificationAuthorized",get_notificationAuthorized,set_notificationAuthorized,true);
		addMember(l,"notificationBadgeAuthorized",get_notificationBadgeAuthorized,set_notificationBadgeAuthorized,true);
		addMember(l,"notificationSoundAuthorized",get_notificationSoundAuthorized,set_notificationSoundAuthorized,true);
		addMember(l,"phoneCalendarAuthorized",get_phoneCalendarAuthorized,set_phoneCalendarAuthorized,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.AppAuthorizeSetting));
	}
}
