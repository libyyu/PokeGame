﻿//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_OnHeadersReceivedCallbackResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.OnHeadersReceivedCallbackResult o;
			o=new WeChatWASM.OnHeadersReceivedCallbackResult();
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
	static public int get_header(IntPtr l) {
		try {
			WeChatWASM.OnHeadersReceivedCallbackResult self=(WeChatWASM.OnHeadersReceivedCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.header);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_header(IntPtr l) {
		try {
			WeChatWASM.OnHeadersReceivedCallbackResult self=(WeChatWASM.OnHeadersReceivedCallbackResult)checkSelf(l);
			System.Collections.Generic.Dictionary<System.String,System.String> v;
			checkType(l,2,out v);
			self.header=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.OnHeadersReceivedCallbackResult");
		addMember(l,"header",get_header,set_header,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.OnHeadersReceivedCallbackResult));
	}
}
