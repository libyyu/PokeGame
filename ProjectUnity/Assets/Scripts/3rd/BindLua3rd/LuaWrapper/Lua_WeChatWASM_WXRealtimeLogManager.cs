//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXRealtimeLogManager : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXRealtimeLogManager o;
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			o=new WeChatWASM.WXRealtimeLogManager(a1);
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
	static public int AddFilterMsg(IntPtr l) {
		try {
			WeChatWASM.WXRealtimeLogManager self=(WeChatWASM.WXRealtimeLogManager)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.AddFilterMsg(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Error(IntPtr l) {
		try {
			WeChatWASM.WXRealtimeLogManager self=(WeChatWASM.WXRealtimeLogManager)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.Error(a1);
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
			WeChatWASM.WXRealtimeLogManager self=(WeChatWASM.WXRealtimeLogManager)checkSelf(l);
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
	static public int SetFilterMsg(IntPtr l) {
		try {
			WeChatWASM.WXRealtimeLogManager self=(WeChatWASM.WXRealtimeLogManager)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.SetFilterMsg(a1);
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
			WeChatWASM.WXRealtimeLogManager self=(WeChatWASM.WXRealtimeLogManager)checkSelf(l);
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
		getTypeTable(l,"WeChatWASM.WXRealtimeLogManager");
		addMember(l,AddFilterMsg);
		addMember(l,Error);
		addMember(l,Info);
		addMember(l,SetFilterMsg);
		addMember(l,Warn);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXRealtimeLogManager));
	}
}
