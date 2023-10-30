//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_CharacteristicProperties : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.CharacteristicProperties o;
			o=new WeChatWASM.CharacteristicProperties();
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
			WeChatWASM.CharacteristicProperties self=(WeChatWASM.CharacteristicProperties)checkSelf(l);
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
			WeChatWASM.CharacteristicProperties self=(WeChatWASM.CharacteristicProperties)checkSelf(l);
			System.Nullable<System.Boolean> v;
			checkNullable(l,2,out v);
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
			WeChatWASM.CharacteristicProperties self=(WeChatWASM.CharacteristicProperties)checkSelf(l);
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
			WeChatWASM.CharacteristicProperties self=(WeChatWASM.CharacteristicProperties)checkSelf(l);
			System.Nullable<System.Boolean> v;
			checkNullable(l,2,out v);
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
			WeChatWASM.CharacteristicProperties self=(WeChatWASM.CharacteristicProperties)checkSelf(l);
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
			WeChatWASM.CharacteristicProperties self=(WeChatWASM.CharacteristicProperties)checkSelf(l);
			System.Nullable<System.Boolean> v;
			checkNullable(l,2,out v);
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
			WeChatWASM.CharacteristicProperties self=(WeChatWASM.CharacteristicProperties)checkSelf(l);
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
			WeChatWASM.CharacteristicProperties self=(WeChatWASM.CharacteristicProperties)checkSelf(l);
			System.Nullable<System.Boolean> v;
			checkNullable(l,2,out v);
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
	static public int get_writeNoResponse(IntPtr l) {
		try {
			WeChatWASM.CharacteristicProperties self=(WeChatWASM.CharacteristicProperties)checkSelf(l);
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
			WeChatWASM.CharacteristicProperties self=(WeChatWASM.CharacteristicProperties)checkSelf(l);
			System.Nullable<System.Boolean> v;
			checkNullable(l,2,out v);
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
		getTypeTable(l,"WeChatWASM.CharacteristicProperties");
		addMember(l,"indicate",get_indicate,set_indicate,true);
		addMember(l,"notify",get_notify,set_notify,true);
		addMember(l,"read",get_read,set_read,true);
		addMember(l,"write",get_write,set_write,true);
		addMember(l,"writeNoResponse",get_writeNoResponse,set_writeNoResponse,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.CharacteristicProperties));
	}
}
