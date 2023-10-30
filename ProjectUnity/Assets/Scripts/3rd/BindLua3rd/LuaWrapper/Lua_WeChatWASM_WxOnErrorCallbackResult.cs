//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WxOnErrorCallbackResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WxOnErrorCallbackResult o;
			o=new WeChatWASM.WxOnErrorCallbackResult();
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
	static public int get_message(IntPtr l) {
		try {
			WeChatWASM.WxOnErrorCallbackResult self=(WeChatWASM.WxOnErrorCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.message);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_message(IntPtr l) {
		try {
			WeChatWASM.WxOnErrorCallbackResult self=(WeChatWASM.WxOnErrorCallbackResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.message=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_stack(IntPtr l) {
		try {
			WeChatWASM.WxOnErrorCallbackResult self=(WeChatWASM.WxOnErrorCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.stack);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_stack(IntPtr l) {
		try {
			WeChatWASM.WxOnErrorCallbackResult self=(WeChatWASM.WxOnErrorCallbackResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.stack=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WxOnErrorCallbackResult");
		addMember(l,"message",get_message,set_message,true);
		addMember(l,"stack",get_stack,set_stack,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WxOnErrorCallbackResult));
	}
}
