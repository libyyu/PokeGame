//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXVideoCallback : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXVideoCallback o;
			o=new WeChatWASM.WXVideoCallback();
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
	static public int get_position(IntPtr l) {
		try {
			WeChatWASM.WXVideoCallback self=(WeChatWASM.WXVideoCallback)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.position);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_position(IntPtr l) {
		try {
			WeChatWASM.WXVideoCallback self=(WeChatWASM.WXVideoCallback)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.position=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_duration(IntPtr l) {
		try {
			WeChatWASM.WXVideoCallback self=(WeChatWASM.WXVideoCallback)checkSelf(l);
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
			WeChatWASM.WXVideoCallback self=(WeChatWASM.WXVideoCallback)checkSelf(l);
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
			WeChatWASM.WXVideoCallback self=(WeChatWASM.WXVideoCallback)checkSelf(l);
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
			WeChatWASM.WXVideoCallback self=(WeChatWASM.WXVideoCallback)checkSelf(l);
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
		getTypeTable(l,"WeChatWASM.WXVideoCallback");
		addMember(l,"position",get_position,set_position,true);
		addMember(l,"duration",get_duration,set_duration,true);
		addMember(l,"buffered",get_buffered,set_buffered,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXVideoCallback),typeof(WeChatWASM.WXTextResponse));
	}
}
