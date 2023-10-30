//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_SystemSetting : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.SystemSetting o;
			o=new WeChatWASM.SystemSetting();
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
	static public int get_bluetoothEnabled(IntPtr l) {
		try {
			WeChatWASM.SystemSetting self=(WeChatWASM.SystemSetting)checkSelf(l);
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
			WeChatWASM.SystemSetting self=(WeChatWASM.SystemSetting)checkSelf(l);
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
	static public int get_deviceOrientation(IntPtr l) {
		try {
			WeChatWASM.SystemSetting self=(WeChatWASM.SystemSetting)checkSelf(l);
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
			WeChatWASM.SystemSetting self=(WeChatWASM.SystemSetting)checkSelf(l);
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
	static public int get_locationEnabled(IntPtr l) {
		try {
			WeChatWASM.SystemSetting self=(WeChatWASM.SystemSetting)checkSelf(l);
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
			WeChatWASM.SystemSetting self=(WeChatWASM.SystemSetting)checkSelf(l);
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
	static public int get_wifiEnabled(IntPtr l) {
		try {
			WeChatWASM.SystemSetting self=(WeChatWASM.SystemSetting)checkSelf(l);
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
			WeChatWASM.SystemSetting self=(WeChatWASM.SystemSetting)checkSelf(l);
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
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.SystemSetting");
		addMember(l,"bluetoothEnabled",get_bluetoothEnabled,set_bluetoothEnabled,true);
		addMember(l,"deviceOrientation",get_deviceOrientation,set_deviceOrientation,true);
		addMember(l,"locationEnabled",get_locationEnabled,set_locationEnabled,true);
		addMember(l,"wifiEnabled",get_wifiEnabled,set_wifiEnabled,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.SystemSetting));
	}
}
