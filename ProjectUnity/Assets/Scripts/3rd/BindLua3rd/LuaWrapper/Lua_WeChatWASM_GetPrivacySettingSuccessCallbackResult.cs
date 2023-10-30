//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_GetPrivacySettingSuccessCallbackResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.GetPrivacySettingSuccessCallbackResult o;
			o=new WeChatWASM.GetPrivacySettingSuccessCallbackResult();
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
	static public int get_needAuthorization(IntPtr l) {
		try {
			WeChatWASM.GetPrivacySettingSuccessCallbackResult self=(WeChatWASM.GetPrivacySettingSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.needAuthorization);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_needAuthorization(IntPtr l) {
		try {
			WeChatWASM.GetPrivacySettingSuccessCallbackResult self=(WeChatWASM.GetPrivacySettingSuccessCallbackResult)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.needAuthorization=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_privacyContractName(IntPtr l) {
		try {
			WeChatWASM.GetPrivacySettingSuccessCallbackResult self=(WeChatWASM.GetPrivacySettingSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.privacyContractName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_privacyContractName(IntPtr l) {
		try {
			WeChatWASM.GetPrivacySettingSuccessCallbackResult self=(WeChatWASM.GetPrivacySettingSuccessCallbackResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.privacyContractName=v;
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
			WeChatWASM.GetPrivacySettingSuccessCallbackResult self=(WeChatWASM.GetPrivacySettingSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.GetPrivacySettingSuccessCallbackResult self=(WeChatWASM.GetPrivacySettingSuccessCallbackResult)checkSelf(l);
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
		getTypeTable(l,"WeChatWASM.GetPrivacySettingSuccessCallbackResult");
		addMember(l,"needAuthorization",get_needAuthorization,set_needAuthorization,true);
		addMember(l,"privacyContractName",get_privacyContractName,set_privacyContractName,true);
		addMember(l,"errMsg",get_errMsg,set_errMsg,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.GetPrivacySettingSuccessCallbackResult));
	}
}
