//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_OnCharacteristicReadRequestListenerResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.OnCharacteristicReadRequestListenerResult o;
			o=new WeChatWASM.OnCharacteristicReadRequestListenerResult();
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
	static public int get_callbackId(IntPtr l) {
		try {
			WeChatWASM.OnCharacteristicReadRequestListenerResult self=(WeChatWASM.OnCharacteristicReadRequestListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.callbackId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_callbackId(IntPtr l) {
		try {
			WeChatWASM.OnCharacteristicReadRequestListenerResult self=(WeChatWASM.OnCharacteristicReadRequestListenerResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.callbackId=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_characteristicId(IntPtr l) {
		try {
			WeChatWASM.OnCharacteristicReadRequestListenerResult self=(WeChatWASM.OnCharacteristicReadRequestListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.characteristicId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_characteristicId(IntPtr l) {
		try {
			WeChatWASM.OnCharacteristicReadRequestListenerResult self=(WeChatWASM.OnCharacteristicReadRequestListenerResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.characteristicId=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_serviceId(IntPtr l) {
		try {
			WeChatWASM.OnCharacteristicReadRequestListenerResult self=(WeChatWASM.OnCharacteristicReadRequestListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.serviceId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_serviceId(IntPtr l) {
		try {
			WeChatWASM.OnCharacteristicReadRequestListenerResult self=(WeChatWASM.OnCharacteristicReadRequestListenerResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.serviceId=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.OnCharacteristicReadRequestListenerResult");
		addMember(l,"callbackId",get_callbackId,set_callbackId,true);
		addMember(l,"characteristicId",get_characteristicId,set_characteristicId,true);
		addMember(l,"serviceId",get_serviceId,set_serviceId,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.OnCharacteristicReadRequestListenerResult));
	}
}
