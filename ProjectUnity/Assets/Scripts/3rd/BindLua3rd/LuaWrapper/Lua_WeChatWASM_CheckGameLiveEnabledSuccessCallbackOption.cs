//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_CheckGameLiveEnabledSuccessCallbackOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.CheckGameLiveEnabledSuccessCallbackOption o;
			o=new WeChatWASM.CheckGameLiveEnabledSuccessCallbackOption();
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
	static public int get_errMsg(IntPtr l) {
		try {
			WeChatWASM.CheckGameLiveEnabledSuccessCallbackOption self=(WeChatWASM.CheckGameLiveEnabledSuccessCallbackOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.errMsg);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_errMsg(IntPtr l) {
		try {
			WeChatWASM.CheckGameLiveEnabledSuccessCallbackOption self=(WeChatWASM.CheckGameLiveEnabledSuccessCallbackOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.errMsg=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_isEnabled(IntPtr l) {
		try {
			WeChatWASM.CheckGameLiveEnabledSuccessCallbackOption self=(WeChatWASM.CheckGameLiveEnabledSuccessCallbackOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isEnabled);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_isEnabled(IntPtr l) {
		try {
			WeChatWASM.CheckGameLiveEnabledSuccessCallbackOption self=(WeChatWASM.CheckGameLiveEnabledSuccessCallbackOption)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.isEnabled=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.CheckGameLiveEnabledSuccessCallbackOption");
		addMember(l,"errMsg",get_errMsg,set_errMsg,true);
		addMember(l,"isEnabled",get_isEnabled,set_isEnabled,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.CheckGameLiveEnabledSuccessCallbackOption));
	}
}
