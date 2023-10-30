//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_OnBLEMTUChangeListenerResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.OnBLEMTUChangeListenerResult o;
			o=new WeChatWASM.OnBLEMTUChangeListenerResult();
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
	static public int get_deviceId(IntPtr l) {
		try {
			WeChatWASM.OnBLEMTUChangeListenerResult self=(WeChatWASM.OnBLEMTUChangeListenerResult)checkSelf(l);
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
			WeChatWASM.OnBLEMTUChangeListenerResult self=(WeChatWASM.OnBLEMTUChangeListenerResult)checkSelf(l);
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
	static public int get_mtu(IntPtr l) {
		try {
			WeChatWASM.OnBLEMTUChangeListenerResult self=(WeChatWASM.OnBLEMTUChangeListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.mtu);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_mtu(IntPtr l) {
		try {
			WeChatWASM.OnBLEMTUChangeListenerResult self=(WeChatWASM.OnBLEMTUChangeListenerResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.mtu=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.OnBLEMTUChangeListenerResult");
		addMember(l,"deviceId",get_deviceId,set_deviceId,true);
		addMember(l,"mtu",get_mtu,set_mtu,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.OnBLEMTUChangeListenerResult));
	}
}
