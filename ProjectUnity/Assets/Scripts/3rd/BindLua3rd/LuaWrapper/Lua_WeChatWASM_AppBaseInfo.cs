//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_AppBaseInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.AppBaseInfo o;
			o=new WeChatWASM.AppBaseInfo();
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
	static public int get_SDKVersion(IntPtr l) {
		try {
			WeChatWASM.AppBaseInfo self=(WeChatWASM.AppBaseInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.SDKVersion);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_SDKVersion(IntPtr l) {
		try {
			WeChatWASM.AppBaseInfo self=(WeChatWASM.AppBaseInfo)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.SDKVersion=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_enableDebug(IntPtr l) {
		try {
			WeChatWASM.AppBaseInfo self=(WeChatWASM.AppBaseInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.enableDebug);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_enableDebug(IntPtr l) {
		try {
			WeChatWASM.AppBaseInfo self=(WeChatWASM.AppBaseInfo)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.enableDebug=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_host(IntPtr l) {
		try {
			WeChatWASM.AppBaseInfo self=(WeChatWASM.AppBaseInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.host);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_host(IntPtr l) {
		try {
			WeChatWASM.AppBaseInfo self=(WeChatWASM.AppBaseInfo)checkSelf(l);
			WeChatWASM.AppBaseInfoHost v;
			checkType(l,2,out v);
			self.host=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_language(IntPtr l) {
		try {
			WeChatWASM.AppBaseInfo self=(WeChatWASM.AppBaseInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.language);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_language(IntPtr l) {
		try {
			WeChatWASM.AppBaseInfo self=(WeChatWASM.AppBaseInfo)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.language=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_version(IntPtr l) {
		try {
			WeChatWASM.AppBaseInfo self=(WeChatWASM.AppBaseInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.version);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_version(IntPtr l) {
		try {
			WeChatWASM.AppBaseInfo self=(WeChatWASM.AppBaseInfo)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.version=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_theme(IntPtr l) {
		try {
			WeChatWASM.AppBaseInfo self=(WeChatWASM.AppBaseInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.theme);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_theme(IntPtr l) {
		try {
			WeChatWASM.AppBaseInfo self=(WeChatWASM.AppBaseInfo)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.theme=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.AppBaseInfo");
		addMember(l,"SDKVersion",get_SDKVersion,set_SDKVersion,true);
		addMember(l,"enableDebug",get_enableDebug,set_enableDebug,true);
		addMember(l,"host",get_host,set_host,true);
		addMember(l,"language",get_language,set_language,true);
		addMember(l,"version",get_version,set_version,true);
		addMember(l,"theme",get_theme,set_theme,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.AppBaseInfo));
	}
}
