//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_GetSettingSuccessCallbackResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.GetSettingSuccessCallbackResult o;
			o=new WeChatWASM.GetSettingSuccessCallbackResult();
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
			WeChatWASM.GetSettingSuccessCallbackResult self=(WeChatWASM.GetSettingSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.GetSettingSuccessCallbackResult self=(WeChatWASM.GetSettingSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.GetSettingSuccessCallbackResult self=(WeChatWASM.GetSettingSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.GetSettingSuccessCallbackResult self=(WeChatWASM.GetSettingSuccessCallbackResult)checkSelf(l);
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
	static public int get_miniprogramAuthSetting(IntPtr l) {
		try {
			WeChatWASM.GetSettingSuccessCallbackResult self=(WeChatWASM.GetSettingSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.miniprogramAuthSetting);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_miniprogramAuthSetting(IntPtr l) {
		try {
			WeChatWASM.GetSettingSuccessCallbackResult self=(WeChatWASM.GetSettingSuccessCallbackResult)checkSelf(l);
			WeChatWASM.AuthSetting v;
			checkType(l,2,out v);
			self.miniprogramAuthSetting=v;
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
			WeChatWASM.GetSettingSuccessCallbackResult self=(WeChatWASM.GetSettingSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.GetSettingSuccessCallbackResult self=(WeChatWASM.GetSettingSuccessCallbackResult)checkSelf(l);
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
		getTypeTable(l,"WeChatWASM.GetSettingSuccessCallbackResult");
		addMember(l,"authSetting",get_authSetting,set_authSetting,true);
		addMember(l,"subscriptionsSetting",get_subscriptionsSetting,set_subscriptionsSetting,true);
		addMember(l,"miniprogramAuthSetting",get_miniprogramAuthSetting,set_miniprogramAuthSetting,true);
		addMember(l,"errMsg",get_errMsg,set_errMsg,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.GetSettingSuccessCallbackResult));
	}
}
