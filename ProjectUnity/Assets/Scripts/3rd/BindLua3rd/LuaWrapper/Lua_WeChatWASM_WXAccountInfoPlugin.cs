//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXAccountInfoPlugin : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXAccountInfoPlugin o;
			o=new WeChatWASM.WXAccountInfoPlugin();
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
	static public int get_appId(IntPtr l) {
		try {
			WeChatWASM.WXAccountInfoPlugin self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.appId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_appId(IntPtr l) {
		try {
			WeChatWASM.WXAccountInfoPlugin self;
			checkValueType(l,1,out self);
			System.String v;
			checkType(l,2,out v);
			self.appId=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_version(IntPtr l) {
		try {
			WeChatWASM.WXAccountInfoPlugin self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.version);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_version(IntPtr l) {
		try {
			WeChatWASM.WXAccountInfoPlugin self;
			checkValueType(l,1,out self);
			System.String v;
			checkType(l,2,out v);
			self.version=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXAccountInfoPlugin");
		addMember(l,"appId",get_appId,set_appId,true);
		addMember(l,"version",get_version,set_version,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXAccountInfoPlugin),typeof(System.ValueType));
	}
}
