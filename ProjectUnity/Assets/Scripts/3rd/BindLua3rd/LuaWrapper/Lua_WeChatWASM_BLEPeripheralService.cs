//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_BLEPeripheralService : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.BLEPeripheralService o;
			o=new WeChatWASM.BLEPeripheralService();
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
	static public int get_characteristics(IntPtr l) {
		try {
			WeChatWASM.BLEPeripheralService self=(WeChatWASM.BLEPeripheralService)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.characteristics);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_characteristics(IntPtr l) {
		try {
			WeChatWASM.BLEPeripheralService self=(WeChatWASM.BLEPeripheralService)checkSelf(l);
			WeChatWASM.Characteristic[] v;
			checkArray(l,2,out v);
			self.characteristics=v;
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
			WeChatWASM.BLEPeripheralService self=(WeChatWASM.BLEPeripheralService)checkSelf(l);
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
			WeChatWASM.BLEPeripheralService self=(WeChatWASM.BLEPeripheralService)checkSelf(l);
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
		getTypeTable(l,"WeChatWASM.BLEPeripheralService");
		addMember(l,"characteristics",get_characteristics,set_characteristics,true);
		addMember(l,"uuid",get_uuid,set_uuid,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.BLEPeripheralService));
	}
}
