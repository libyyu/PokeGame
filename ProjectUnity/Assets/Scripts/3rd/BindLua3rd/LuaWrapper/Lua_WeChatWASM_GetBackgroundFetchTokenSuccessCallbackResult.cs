//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_GetBackgroundFetchTokenSuccessCallbackResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.GetBackgroundFetchTokenSuccessCallbackResult o;
			o=new WeChatWASM.GetBackgroundFetchTokenSuccessCallbackResult();
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
			WeChatWASM.GetBackgroundFetchTokenSuccessCallbackResult self=(WeChatWASM.GetBackgroundFetchTokenSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.GetBackgroundFetchTokenSuccessCallbackResult self=(WeChatWASM.GetBackgroundFetchTokenSuccessCallbackResult)checkSelf(l);
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
	static public int get_token(IntPtr l) {
		try {
			WeChatWASM.GetBackgroundFetchTokenSuccessCallbackResult self=(WeChatWASM.GetBackgroundFetchTokenSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.token);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_token(IntPtr l) {
		try {
			WeChatWASM.GetBackgroundFetchTokenSuccessCallbackResult self=(WeChatWASM.GetBackgroundFetchTokenSuccessCallbackResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.token=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.GetBackgroundFetchTokenSuccessCallbackResult");
		addMember(l,"errMsg",get_errMsg,set_errMsg,true);
		addMember(l,"token",get_token,set_token,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.GetBackgroundFetchTokenSuccessCallbackResult));
	}
}
