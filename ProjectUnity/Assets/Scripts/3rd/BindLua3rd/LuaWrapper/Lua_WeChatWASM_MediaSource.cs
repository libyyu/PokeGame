//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_MediaSource : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.MediaSource o;
			o=new WeChatWASM.MediaSource();
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
	static public int get_url(IntPtr l) {
		try {
			WeChatWASM.MediaSource self=(WeChatWASM.MediaSource)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.url);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_url(IntPtr l) {
		try {
			WeChatWASM.MediaSource self=(WeChatWASM.MediaSource)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.url=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_poster(IntPtr l) {
		try {
			WeChatWASM.MediaSource self=(WeChatWASM.MediaSource)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.poster);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_poster(IntPtr l) {
		try {
			WeChatWASM.MediaSource self=(WeChatWASM.MediaSource)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.poster=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_type(IntPtr l) {
		try {
			WeChatWASM.MediaSource self=(WeChatWASM.MediaSource)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.type);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_type(IntPtr l) {
		try {
			WeChatWASM.MediaSource self=(WeChatWASM.MediaSource)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.type=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.MediaSource");
		addMember(l,"url",get_url,set_url,true);
		addMember(l,"poster",get_poster,set_poster,true);
		addMember(l,"type",get_type,set_type,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.MediaSource));
	}
}
