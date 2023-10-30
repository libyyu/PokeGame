//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXStatInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXStatInfo o;
			o=new WeChatWASM.WXStatInfo();
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
	static public int get_mode(IntPtr l) {
		try {
			WeChatWASM.WXStatInfo self=(WeChatWASM.WXStatInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.mode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_mode(IntPtr l) {
		try {
			WeChatWASM.WXStatInfo self=(WeChatWASM.WXStatInfo)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.mode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_size(IntPtr l) {
		try {
			WeChatWASM.WXStatInfo self=(WeChatWASM.WXStatInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.size);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_size(IntPtr l) {
		try {
			WeChatWASM.WXStatInfo self=(WeChatWASM.WXStatInfo)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.size=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_lastAccessedTime(IntPtr l) {
		try {
			WeChatWASM.WXStatInfo self=(WeChatWASM.WXStatInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.lastAccessedTime);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_lastAccessedTime(IntPtr l) {
		try {
			WeChatWASM.WXStatInfo self=(WeChatWASM.WXStatInfo)checkSelf(l);
			System.UInt32 v;
			checkType(l,2,out v);
			self.lastAccessedTime=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_lastModifiedTime(IntPtr l) {
		try {
			WeChatWASM.WXStatInfo self=(WeChatWASM.WXStatInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.lastModifiedTime);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_lastModifiedTime(IntPtr l) {
		try {
			WeChatWASM.WXStatInfo self=(WeChatWASM.WXStatInfo)checkSelf(l);
			System.UInt32 v;
			checkType(l,2,out v);
			self.lastModifiedTime=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXStatInfo");
		addMember(l,"mode",get_mode,set_mode,true);
		addMember(l,"size",get_size,set_size,true);
		addMember(l,"lastAccessedTime",get_lastAccessedTime,set_lastAccessedTime,true);
		addMember(l,"lastModifiedTime",get_lastModifiedTime,set_lastModifiedTime,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXStatInfo));
	}
}
