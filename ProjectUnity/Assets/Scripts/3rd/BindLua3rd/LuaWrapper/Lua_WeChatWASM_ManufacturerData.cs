//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_ManufacturerData : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.ManufacturerData o;
			o=new WeChatWASM.ManufacturerData();
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
	static public int get_manufacturerId(IntPtr l) {
		try {
			WeChatWASM.ManufacturerData self=(WeChatWASM.ManufacturerData)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.manufacturerId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_manufacturerId(IntPtr l) {
		try {
			WeChatWASM.ManufacturerData self=(WeChatWASM.ManufacturerData)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.manufacturerId=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_manufacturerSpecificData(IntPtr l) {
		try {
			WeChatWASM.ManufacturerData self=(WeChatWASM.ManufacturerData)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.manufacturerSpecificData);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_manufacturerSpecificData(IntPtr l) {
		try {
			WeChatWASM.ManufacturerData self=(WeChatWASM.ManufacturerData)checkSelf(l);
			System.Byte[] v;
			checkArray(l,2,out v);
			self.manufacturerSpecificData=v;
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
			WeChatWASM.ManufacturerData self=(WeChatWASM.ManufacturerData)checkSelf(l);
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
			WeChatWASM.ManufacturerData self=(WeChatWASM.ManufacturerData)checkSelf(l);
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
		getTypeTable(l,"WeChatWASM.ManufacturerData");
		addMember(l,"manufacturerId",get_manufacturerId,set_manufacturerId,true);
		addMember(l,"manufacturerSpecificData",get_manufacturerSpecificData,set_manufacturerSpecificData,true);
		addMember(l,"arrayBufferLength",get_arrayBufferLength,set_arrayBufferLength,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.ManufacturerData));
	}
}
