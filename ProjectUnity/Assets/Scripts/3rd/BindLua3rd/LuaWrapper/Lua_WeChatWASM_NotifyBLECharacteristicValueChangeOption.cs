//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_NotifyBLECharacteristicValueChangeOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.NotifyBLECharacteristicValueChangeOption o;
			o=new WeChatWASM.NotifyBLECharacteristicValueChangeOption();
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
	static public int get_characteristicId(IntPtr l) {
		try {
			WeChatWASM.NotifyBLECharacteristicValueChangeOption self=(WeChatWASM.NotifyBLECharacteristicValueChangeOption)checkSelf(l);
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
			WeChatWASM.NotifyBLECharacteristicValueChangeOption self=(WeChatWASM.NotifyBLECharacteristicValueChangeOption)checkSelf(l);
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
	static public int get_deviceId(IntPtr l) {
		try {
			WeChatWASM.NotifyBLECharacteristicValueChangeOption self=(WeChatWASM.NotifyBLECharacteristicValueChangeOption)checkSelf(l);
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
			WeChatWASM.NotifyBLECharacteristicValueChangeOption self=(WeChatWASM.NotifyBLECharacteristicValueChangeOption)checkSelf(l);
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
	static public int get_serviceId(IntPtr l) {
		try {
			WeChatWASM.NotifyBLECharacteristicValueChangeOption self=(WeChatWASM.NotifyBLECharacteristicValueChangeOption)checkSelf(l);
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
			WeChatWASM.NotifyBLECharacteristicValueChangeOption self=(WeChatWASM.NotifyBLECharacteristicValueChangeOption)checkSelf(l);
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
	static public int get_state(IntPtr l) {
		try {
			WeChatWASM.NotifyBLECharacteristicValueChangeOption self=(WeChatWASM.NotifyBLECharacteristicValueChangeOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.state);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_state(IntPtr l) {
		try {
			WeChatWASM.NotifyBLECharacteristicValueChangeOption self=(WeChatWASM.NotifyBLECharacteristicValueChangeOption)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.state=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_complete(IntPtr l) {
		try {
			WeChatWASM.NotifyBLECharacteristicValueChangeOption self=(WeChatWASM.NotifyBLECharacteristicValueChangeOption)checkSelf(l);
			System.Action<WeChatWASM.BluetoothError> v;
			int op=checkDelegate(l,2,out v);
			if(op==0) self.complete=v;
			else if(op==1) self.complete+=v;
			else if(op==2) self.complete-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_fail(IntPtr l) {
		try {
			WeChatWASM.NotifyBLECharacteristicValueChangeOption self=(WeChatWASM.NotifyBLECharacteristicValueChangeOption)checkSelf(l);
			System.Action<WeChatWASM.BluetoothError> v;
			int op=checkDelegate(l,2,out v);
			if(op==0) self.fail=v;
			else if(op==1) self.fail+=v;
			else if(op==2) self.fail-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_success(IntPtr l) {
		try {
			WeChatWASM.NotifyBLECharacteristicValueChangeOption self=(WeChatWASM.NotifyBLECharacteristicValueChangeOption)checkSelf(l);
			System.Action<WeChatWASM.BluetoothError> v;
			int op=checkDelegate(l,2,out v);
			if(op==0) self.success=v;
			else if(op==1) self.success+=v;
			else if(op==2) self.success-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_type(IntPtr l) {
		try {
			WeChatWASM.NotifyBLECharacteristicValueChangeOption self=(WeChatWASM.NotifyBLECharacteristicValueChangeOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.type);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_type(IntPtr l) {
		try {
			WeChatWASM.NotifyBLECharacteristicValueChangeOption self=(WeChatWASM.NotifyBLECharacteristicValueChangeOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.type=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.NotifyBLECharacteristicValueChangeOption");
		addMember(l,"characteristicId",get_characteristicId,set_characteristicId,true);
		addMember(l,"deviceId",get_deviceId,set_deviceId,true);
		addMember(l,"serviceId",get_serviceId,set_serviceId,true);
		addMember(l,"state",get_state,set_state,true);
		addMember(l,"complete",null,set_complete,true);
		addMember(l,"fail",null,set_fail,true);
		addMember(l,"success",null,set_success,true);
		addMember(l,"type",get_type,set_type,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.NotifyBLECharacteristicValueChangeOption));
	}
}
