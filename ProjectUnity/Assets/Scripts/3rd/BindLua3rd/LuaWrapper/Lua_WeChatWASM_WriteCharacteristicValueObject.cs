//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WriteCharacteristicValueObject : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WriteCharacteristicValueObject o;
			o=new WeChatWASM.WriteCharacteristicValueObject();
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
			WeChatWASM.WriteCharacteristicValueObject self=(WeChatWASM.WriteCharacteristicValueObject)checkSelf(l);
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
			WeChatWASM.WriteCharacteristicValueObject self=(WeChatWASM.WriteCharacteristicValueObject)checkSelf(l);
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
	static public int get_needNotify(IntPtr l) {
		try {
			WeChatWASM.WriteCharacteristicValueObject self=(WeChatWASM.WriteCharacteristicValueObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.needNotify);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_needNotify(IntPtr l) {
		try {
			WeChatWASM.WriteCharacteristicValueObject self=(WeChatWASM.WriteCharacteristicValueObject)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.needNotify=v;
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
			WeChatWASM.WriteCharacteristicValueObject self=(WeChatWASM.WriteCharacteristicValueObject)checkSelf(l);
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
			WeChatWASM.WriteCharacteristicValueObject self=(WeChatWASM.WriteCharacteristicValueObject)checkSelf(l);
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
			WeChatWASM.WriteCharacteristicValueObject self=(WeChatWASM.WriteCharacteristicValueObject)checkSelf(l);
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
			WeChatWASM.WriteCharacteristicValueObject self=(WeChatWASM.WriteCharacteristicValueObject)checkSelf(l);
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
			WeChatWASM.WriteCharacteristicValueObject self=(WeChatWASM.WriteCharacteristicValueObject)checkSelf(l);
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
			WeChatWASM.WriteCharacteristicValueObject self=(WeChatWASM.WriteCharacteristicValueObject)checkSelf(l);
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_callbackId(IntPtr l) {
		try {
			WeChatWASM.WriteCharacteristicValueObject self=(WeChatWASM.WriteCharacteristicValueObject)checkSelf(l);
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
			WeChatWASM.WriteCharacteristicValueObject self=(WeChatWASM.WriteCharacteristicValueObject)checkSelf(l);
			System.Nullable<System.Double> v;
			checkNullable(l,2,out v);
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
	static public int set_complete(IntPtr l) {
		try {
			WeChatWASM.WriteCharacteristicValueObject self=(WeChatWASM.WriteCharacteristicValueObject)checkSelf(l);
			System.Action<WeChatWASM.GeneralCallbackResult> v;
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
			WeChatWASM.WriteCharacteristicValueObject self=(WeChatWASM.WriteCharacteristicValueObject)checkSelf(l);
			System.Action<WeChatWASM.GeneralCallbackResult> v;
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
			WeChatWASM.WriteCharacteristicValueObject self=(WeChatWASM.WriteCharacteristicValueObject)checkSelf(l);
			System.Action<WeChatWASM.GeneralCallbackResult> v;
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
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WriteCharacteristicValueObject");
		addMember(l,"characteristicId",get_characteristicId,set_characteristicId,true);
		addMember(l,"needNotify",get_needNotify,set_needNotify,true);
		addMember(l,"serviceId",get_serviceId,set_serviceId,true);
		addMember(l,"value",get_value,set_value,true);
		addMember(l,"arrayBufferLength",get_arrayBufferLength,set_arrayBufferLength,true);
		addMember(l,"callbackId",get_callbackId,set_callbackId,true);
		addMember(l,"complete",null,set_complete,true);
		addMember(l,"fail",null,set_fail,true);
		addMember(l,"success",null,set_success,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WriteCharacteristicValueObject));
	}
}
