//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXJSCallback : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXJSCallback o;
			o=new WeChatWASM.WXJSCallback();
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
			WeChatWASM.WXJSCallback self=(WeChatWASM.WXJSCallback)checkSelf(l);
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
			WeChatWASM.WXJSCallback self=(WeChatWASM.WXJSCallback)checkSelf(l);
			System.String v;
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
	static public int get_type(IntPtr l) {
		try {
			WeChatWASM.WXJSCallback self=(WeChatWASM.WXJSCallback)checkSelf(l);
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
			WeChatWASM.WXJSCallback self=(WeChatWASM.WXJSCallback)checkSelf(l);
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_res(IntPtr l) {
		try {
			WeChatWASM.WXJSCallback self=(WeChatWASM.WXJSCallback)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.res);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_res(IntPtr l) {
		try {
			WeChatWASM.WXJSCallback self=(WeChatWASM.WXJSCallback)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.res=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXJSCallback");
		addMember(l,"callbackId",get_callbackId,set_callbackId,true);
		addMember(l,"type",get_type,set_type,true);
		addMember(l,"res",get_res,set_res,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXJSCallback));
	}
}
