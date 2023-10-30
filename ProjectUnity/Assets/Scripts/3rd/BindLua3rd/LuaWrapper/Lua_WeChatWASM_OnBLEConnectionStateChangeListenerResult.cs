//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_OnBLEConnectionStateChangeListenerResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.OnBLEConnectionStateChangeListenerResult o;
			o=new WeChatWASM.OnBLEConnectionStateChangeListenerResult();
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
	static public int get_connected(IntPtr l) {
		try {
			WeChatWASM.OnBLEConnectionStateChangeListenerResult self=(WeChatWASM.OnBLEConnectionStateChangeListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.connected);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_connected(IntPtr l) {
		try {
			WeChatWASM.OnBLEConnectionStateChangeListenerResult self=(WeChatWASM.OnBLEConnectionStateChangeListenerResult)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.connected=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_deviceId(IntPtr l) {
		try {
			WeChatWASM.OnBLEConnectionStateChangeListenerResult self=(WeChatWASM.OnBLEConnectionStateChangeListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.deviceId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_deviceId(IntPtr l) {
		try {
			WeChatWASM.OnBLEConnectionStateChangeListenerResult self=(WeChatWASM.OnBLEConnectionStateChangeListenerResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.deviceId=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.OnBLEConnectionStateChangeListenerResult");
		addMember(l,"connected",get_connected,set_connected,true);
		addMember(l,"deviceId",get_deviceId,set_deviceId,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.OnBLEConnectionStateChangeListenerResult));
	}
}
