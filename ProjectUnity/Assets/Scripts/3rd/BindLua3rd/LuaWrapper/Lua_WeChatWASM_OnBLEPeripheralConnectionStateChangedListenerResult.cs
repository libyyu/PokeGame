//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_OnBLEPeripheralConnectionStateChangedListenerResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.OnBLEPeripheralConnectionStateChangedListenerResult o;
			o=new WeChatWASM.OnBLEPeripheralConnectionStateChangedListenerResult();
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
			WeChatWASM.OnBLEPeripheralConnectionStateChangedListenerResult self=(WeChatWASM.OnBLEPeripheralConnectionStateChangedListenerResult)checkSelf(l);
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
			WeChatWASM.OnBLEPeripheralConnectionStateChangedListenerResult self=(WeChatWASM.OnBLEPeripheralConnectionStateChangedListenerResult)checkSelf(l);
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
			WeChatWASM.OnBLEPeripheralConnectionStateChangedListenerResult self=(WeChatWASM.OnBLEPeripheralConnectionStateChangedListenerResult)checkSelf(l);
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
			WeChatWASM.OnBLEPeripheralConnectionStateChangedListenerResult self=(WeChatWASM.OnBLEPeripheralConnectionStateChangedListenerResult)checkSelf(l);
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_serverId(IntPtr l) {
		try {
			WeChatWASM.OnBLEPeripheralConnectionStateChangedListenerResult self=(WeChatWASM.OnBLEPeripheralConnectionStateChangedListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.serverId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_serverId(IntPtr l) {
		try {
			WeChatWASM.OnBLEPeripheralConnectionStateChangedListenerResult self=(WeChatWASM.OnBLEPeripheralConnectionStateChangedListenerResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.serverId=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.OnBLEPeripheralConnectionStateChangedListenerResult");
		addMember(l,"connected",get_connected,set_connected,true);
		addMember(l,"deviceId",get_deviceId,set_deviceId,true);
		addMember(l,"serverId",get_serverId,set_serverId,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.OnBLEPeripheralConnectionStateChangedListenerResult));
	}
}
