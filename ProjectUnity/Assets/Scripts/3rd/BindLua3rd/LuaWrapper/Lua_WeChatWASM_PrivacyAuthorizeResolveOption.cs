//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_PrivacyAuthorizeResolveOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.PrivacyAuthorizeResolveOption o;
			o=new WeChatWASM.PrivacyAuthorizeResolveOption();
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
	static public int get_eventString(IntPtr l) {
		try {
			WeChatWASM.PrivacyAuthorizeResolveOption self=(WeChatWASM.PrivacyAuthorizeResolveOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.eventString);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_eventString(IntPtr l) {
		try {
			WeChatWASM.PrivacyAuthorizeResolveOption self=(WeChatWASM.PrivacyAuthorizeResolveOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.eventString=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.PrivacyAuthorizeResolveOption");
		addMember(l,"eventString",get_eventString,set_eventString,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.PrivacyAuthorizeResolveOption));
	}
}
