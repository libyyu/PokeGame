﻿//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_FstatSyncOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.FstatSyncOption o;
			o=new WeChatWASM.FstatSyncOption();
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
	static public int get_fd(IntPtr l) {
		try {
			WeChatWASM.FstatSyncOption self=(WeChatWASM.FstatSyncOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.fd);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_fd(IntPtr l) {
		try {
			WeChatWASM.FstatSyncOption self=(WeChatWASM.FstatSyncOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.fd=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.FstatSyncOption");
		addMember(l,"fd",get_fd,set_fd,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.FstatSyncOption));
	}
}
