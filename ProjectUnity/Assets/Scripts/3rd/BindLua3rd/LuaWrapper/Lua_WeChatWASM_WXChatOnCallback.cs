﻿//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXChatOnCallback : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXChatOnCallback o;
			o=new WeChatWASM.WXChatOnCallback();
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
	static public int get_eventType(IntPtr l) {
		try {
			WeChatWASM.WXChatOnCallback self=(WeChatWASM.WXChatOnCallback)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.eventType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_eventType(IntPtr l) {
		try {
			WeChatWASM.WXChatOnCallback self=(WeChatWASM.WXChatOnCallback)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.eventType=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_result(IntPtr l) {
		try {
			WeChatWASM.WXChatOnCallback self=(WeChatWASM.WXChatOnCallback)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.result);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_result(IntPtr l) {
		try {
			WeChatWASM.WXChatOnCallback self=(WeChatWASM.WXChatOnCallback)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.result=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXChatOnCallback");
		addMember(l,"eventType",get_eventType,set_eventType,true);
		addMember(l,"result",get_result,set_result,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXChatOnCallback));
	}
}
