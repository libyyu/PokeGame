//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_TouchEvent : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.TouchEvent o;
			o=new WeChatWASM.TouchEvent();
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
	static public int get_touches(IntPtr l) {
		try {
			WeChatWASM.TouchEvent self=(WeChatWASM.TouchEvent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.touches);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_touches(IntPtr l) {
		try {
			WeChatWASM.TouchEvent self=(WeChatWASM.TouchEvent)checkSelf(l);
			WeChatWASM.Touch[] v;
			checkArray(l,2,out v);
			self.touches=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_changedTouches(IntPtr l) {
		try {
			WeChatWASM.TouchEvent self=(WeChatWASM.TouchEvent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.changedTouches);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_changedTouches(IntPtr l) {
		try {
			WeChatWASM.TouchEvent self=(WeChatWASM.TouchEvent)checkSelf(l);
			WeChatWASM.Touch[] v;
			checkArray(l,2,out v);
			self.changedTouches=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_timeStamp(IntPtr l) {
		try {
			WeChatWASM.TouchEvent self=(WeChatWASM.TouchEvent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.timeStamp);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_timeStamp(IntPtr l) {
		try {
			WeChatWASM.TouchEvent self=(WeChatWASM.TouchEvent)checkSelf(l);
			System.Int64 v;
			checkType(l,2,out v);
			self.timeStamp=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.TouchEvent");
		addMember(l,"touches",get_touches,set_touches,true);
		addMember(l,"changedTouches",get_changedTouches,set_changedTouches,true);
		addMember(l,"timeStamp",get_timeStamp,set_timeStamp,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.TouchEvent));
	}
}
