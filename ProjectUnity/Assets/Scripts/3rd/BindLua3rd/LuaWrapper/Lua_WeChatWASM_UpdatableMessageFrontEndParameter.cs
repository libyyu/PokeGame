﻿//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_UpdatableMessageFrontEndParameter : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.UpdatableMessageFrontEndParameter o;
			o=new WeChatWASM.UpdatableMessageFrontEndParameter();
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
	static public int get_name(IntPtr l) {
		try {
			WeChatWASM.UpdatableMessageFrontEndParameter self=(WeChatWASM.UpdatableMessageFrontEndParameter)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.name);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_name(IntPtr l) {
		try {
			WeChatWASM.UpdatableMessageFrontEndParameter self=(WeChatWASM.UpdatableMessageFrontEndParameter)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.name=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_value(IntPtr l) {
		try {
			WeChatWASM.UpdatableMessageFrontEndParameter self=(WeChatWASM.UpdatableMessageFrontEndParameter)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.value);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_value(IntPtr l) {
		try {
			WeChatWASM.UpdatableMessageFrontEndParameter self=(WeChatWASM.UpdatableMessageFrontEndParameter)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.value=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.UpdatableMessageFrontEndParameter");
		addMember(l,"name",get_name,set_name,true);
		addMember(l,"value",get_value,set_value,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.UpdatableMessageFrontEndParameter));
	}
}
