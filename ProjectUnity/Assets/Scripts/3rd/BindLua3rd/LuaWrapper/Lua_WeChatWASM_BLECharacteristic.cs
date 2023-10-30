//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_BLECharacteristic : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.BLECharacteristic o;
			o=new WeChatWASM.BLECharacteristic();
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
	static public int get_properties(IntPtr l) {
		try {
			WeChatWASM.BLECharacteristic self=(WeChatWASM.BLECharacteristic)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.properties);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_properties(IntPtr l) {
		try {
			WeChatWASM.BLECharacteristic self=(WeChatWASM.BLECharacteristic)checkSelf(l);
			WeChatWASM.BLECharacteristicProperties v;
			checkType(l,2,out v);
			self.properties=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_uuid(IntPtr l) {
		try {
			WeChatWASM.BLECharacteristic self=(WeChatWASM.BLECharacteristic)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.uuid);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_uuid(IntPtr l) {
		try {
			WeChatWASM.BLECharacteristic self=(WeChatWASM.BLECharacteristic)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.uuid=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.BLECharacteristic");
		addMember(l,"properties",get_properties,set_properties,true);
		addMember(l,"uuid",get_uuid,set_uuid,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.BLECharacteristic));
	}
}
