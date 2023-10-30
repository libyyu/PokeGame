//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_OpenSettingSuccessCallbackResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.OpenSettingSuccessCallbackResult o;
			o=new WeChatWASM.OpenSettingSuccessCallbackResult();
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
	static public int get_authSetting(IntPtr l) {
		try {
			WeChatWASM.OpenSettingSuccessCallbackResult self=(WeChatWASM.OpenSettingSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.authSetting);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_authSetting(IntPtr l) {
		try {
			WeChatWASM.OpenSettingSuccessCallbackResult self=(WeChatWASM.OpenSettingSuccessCallbackResult)checkSelf(l);
			WeChatWASM.AuthSetting v;
			checkType(l,2,out v);
			self.authSetting=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_subscriptionsSetting(IntPtr l) {
		try {
			WeChatWASM.OpenSettingSuccessCallbackResult self=(WeChatWASM.OpenSettingSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.subscriptionsSetting);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_subscriptionsSetting(IntPtr l) {
		try {
			WeChatWASM.OpenSettingSuccessCallbackResult self=(WeChatWASM.OpenSettingSuccessCallbackResult)checkSelf(l);
			WeChatWASM.SubscriptionsSetting v;
			checkType(l,2,out v);
			self.subscriptionsSetting=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_errMsg(IntPtr l) {
		try {
			WeChatWASM.OpenSettingSuccessCallbackResult self=(WeChatWASM.OpenSettingSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.OpenSettingSuccessCallbackResult self=(WeChatWASM.OpenSettingSuccessCallbackResult)checkSelf(l);
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
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.OpenSettingSuccessCallbackResult");
		addMember(l,"authSetting",get_authSetting,set_authSetting,true);
		addMember(l,"subscriptionsSetting",get_subscriptionsSetting,set_subscriptionsSetting,true);
		addMember(l,"errMsg",get_errMsg,set_errMsg,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.OpenSettingSuccessCallbackResult));
	}
}
