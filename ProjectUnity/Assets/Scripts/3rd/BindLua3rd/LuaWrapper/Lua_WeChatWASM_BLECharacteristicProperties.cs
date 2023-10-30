//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_BLECharacteristicProperties : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.BLECharacteristicProperties o;
			o=new WeChatWASM.BLECharacteristicProperties();
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
	static public int get_indicate(IntPtr l) {
		try {
			WeChatWASM.BLECharacteristicProperties self=(WeChatWASM.BLECharacteristicProperties)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.indicate);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_indicate(IntPtr l) {
		try {
			WeChatWASM.BLECharacteristicProperties self=(WeChatWASM.BLECharacteristicProperties)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.indicate=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_notify(IntPtr l) {
		try {
			WeChatWASM.BLECharacteristicProperties self=(WeChatWASM.BLECharacteristicProperties)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.notify);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_notify(IntPtr l) {
		try {
			WeChatWASM.BLECharacteristicProperties self=(WeChatWASM.BLECharacteristicProperties)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.notify=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_read(IntPtr l) {
		try {
			WeChatWASM.BLECharacteristicProperties self=(WeChatWASM.BLECharacteristicProperties)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.read);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_read(IntPtr l) {
		try {
			WeChatWASM.BLECharacteristicProperties self=(WeChatWASM.BLECharacteristicProperties)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.read=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_write(IntPtr l) {
		try {
			WeChatWASM.BLECharacteristicProperties self=(WeChatWASM.BLECharacteristicProperties)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.write);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_write(IntPtr l) {
		try {
			WeChatWASM.BLECharacteristicProperties self=(WeChatWASM.BLECharacteristicProperties)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.write=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_writeDefault(IntPtr l) {
		try {
			WeChatWASM.BLECharacteristicProperties self=(WeChatWASM.BLECharacteristicProperties)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.writeDefault);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_writeDefault(IntPtr l) {
		try {
			WeChatWASM.BLECharacteristicProperties self=(WeChatWASM.BLECharacteristicProperties)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.writeDefault=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_writeNoResponse(IntPtr l) {
		try {
			WeChatWASM.BLECharacteristicProperties self=(WeChatWASM.BLECharacteristicProperties)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.writeNoResponse);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_writeNoResponse(IntPtr l) {
		try {
			WeChatWASM.BLECharacteristicProperties self=(WeChatWASM.BLECharacteristicProperties)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.writeNoResponse=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.BLECharacteristicProperties");
		addMember(l,"indicate",get_indicate,set_indicate,true);
		addMember(l,"notify",get_notify,set_notify,true);
		addMember(l,"read",get_read,set_read,true);
		addMember(l,"write",get_write,set_write,true);
		addMember(l,"writeDefault",get_writeDefault,set_writeDefault,true);
		addMember(l,"writeNoResponse",get_writeNoResponse,set_writeNoResponse,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.BLECharacteristicProperties));
	}
}
