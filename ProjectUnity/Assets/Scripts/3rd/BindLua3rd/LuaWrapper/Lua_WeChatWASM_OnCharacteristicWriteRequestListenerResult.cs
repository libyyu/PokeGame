//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_OnCharacteristicWriteRequestListenerResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.OnCharacteristicWriteRequestListenerResult o;
			o=new WeChatWASM.OnCharacteristicWriteRequestListenerResult();
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
			WeChatWASM.OnCharacteristicWriteRequestListenerResult self=(WeChatWASM.OnCharacteristicWriteRequestListenerResult)checkSelf(l);
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
			WeChatWASM.OnCharacteristicWriteRequestListenerResult self=(WeChatWASM.OnCharacteristicWriteRequestListenerResult)checkSelf(l);
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
			WeChatWASM.OnCharacteristicWriteRequestListenerResult self=(WeChatWASM.OnCharacteristicWriteRequestListenerResult)checkSelf(l);
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
			WeChatWASM.OnCharacteristicWriteRequestListenerResult self=(WeChatWASM.OnCharacteristicWriteRequestListenerResult)checkSelf(l);
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
			WeChatWASM.OnCharacteristicWriteRequestListenerResult self=(WeChatWASM.OnCharacteristicWriteRequestListenerResult)checkSelf(l);
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
			WeChatWASM.OnCharacteristicWriteRequestListenerResult self=(WeChatWASM.OnCharacteristicWriteRequestListenerResult)checkSelf(l);
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_value(IntPtr l) {
		try {
			WeChatWASM.OnCharacteristicWriteRequestListenerResult self=(WeChatWASM.OnCharacteristicWriteRequestListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.value);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_value(IntPtr l) {
		try {
			WeChatWASM.OnCharacteristicWriteRequestListenerResult self=(WeChatWASM.OnCharacteristicWriteRequestListenerResult)checkSelf(l);
			System.Byte[] v;
			checkArray(l,2,out v);
			self.value=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_arrayBufferLength(IntPtr l) {
		try {
			WeChatWASM.OnCharacteristicWriteRequestListenerResult self=(WeChatWASM.OnCharacteristicWriteRequestListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.arrayBufferLength);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_arrayBufferLength(IntPtr l) {
		try {
			WeChatWASM.OnCharacteristicWriteRequestListenerResult self=(WeChatWASM.OnCharacteristicWriteRequestListenerResult)checkSelf(l);
			System.Nullable<System.Int32> v;
			checkNullable(l,2,out v);
			self.arrayBufferLength=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.OnCharacteristicWriteRequestListenerResult");
		addMember(l,"callbackId",get_callbackId,set_callbackId,true);
		addMember(l,"characteristicId",get_characteristicId,set_characteristicId,true);
		addMember(l,"serviceId",get_serviceId,set_serviceId,true);
		addMember(l,"value",get_value,set_value,true);
		addMember(l,"arrayBufferLength",get_arrayBufferLength,set_arrayBufferLength,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.OnCharacteristicWriteRequestListenerResult));
	}
}
