﻿//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_AddCardRequestInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.AddCardRequestInfo o;
			o=new WeChatWASM.AddCardRequestInfo();
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
	static public int get_cardExt(IntPtr l) {
		try {
			WeChatWASM.AddCardRequestInfo self=(WeChatWASM.AddCardRequestInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.cardExt);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_cardExt(IntPtr l) {
		try {
			WeChatWASM.AddCardRequestInfo self=(WeChatWASM.AddCardRequestInfo)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.cardExt=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_cardId(IntPtr l) {
		try {
			WeChatWASM.AddCardRequestInfo self=(WeChatWASM.AddCardRequestInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.cardId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_cardId(IntPtr l) {
		try {
			WeChatWASM.AddCardRequestInfo self=(WeChatWASM.AddCardRequestInfo)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.cardId=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.AddCardRequestInfo");
		addMember(l,"cardExt",get_cardExt,set_cardExt,true);
		addMember(l,"cardId",get_cardId,set_cardId,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.AddCardRequestInfo));
	}
}
