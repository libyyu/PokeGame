//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXLogManager : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXLogManager o;
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			WeChatWASM.GetLogManagerOption a2 = default(WeChatWASM.GetLogManagerOption);
			checkType(l,3,out a2);
			o=new WeChatWASM.WXLogManager(a1,a2);
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
	static public int Debug(IntPtr l) {
		try {
			WeChatWASM.WXLogManager self=(WeChatWASM.WXLogManager)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.Debug(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Info(IntPtr l) {
		try {
			WeChatWASM.WXLogManager self=(WeChatWASM.WXLogManager)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.Info(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Log(IntPtr l) {
		try {
			WeChatWASM.WXLogManager self=(WeChatWASM.WXLogManager)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.Log(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Warn(IntPtr l) {
		try {
			WeChatWASM.WXLogManager self=(WeChatWASM.WXLogManager)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.Warn(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXLogManager");
		addMember(l,Debug);
		addMember(l,Info);
		addMember(l,Log);
		addMember(l,Warn);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXLogManager));
	}
}
