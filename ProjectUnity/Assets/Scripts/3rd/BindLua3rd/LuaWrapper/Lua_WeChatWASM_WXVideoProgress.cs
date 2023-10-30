//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXVideoProgress : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXVideoProgress o;
			o=new WeChatWASM.WXVideoProgress();
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
	static public int get_duration(IntPtr l) {
		try {
			WeChatWASM.WXVideoProgress self=(WeChatWASM.WXVideoProgress)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.duration);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_duration(IntPtr l) {
		try {
			WeChatWASM.WXVideoProgress self=(WeChatWASM.WXVideoProgress)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.duration=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_buffered(IntPtr l) {
		try {
			WeChatWASM.WXVideoProgress self=(WeChatWASM.WXVideoProgress)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.buffered);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_buffered(IntPtr l) {
		try {
			WeChatWASM.WXVideoProgress self=(WeChatWASM.WXVideoProgress)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.buffered=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXVideoProgress");
		addMember(l,"duration",get_duration,set_duration,true);
		addMember(l,"buffered",get_buffered,set_buffered,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXVideoProgress));
	}
}
