//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_RequestMidasPaymentFailCallbackErr : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.RequestMidasPaymentFailCallbackErr o;
			o=new WeChatWASM.RequestMidasPaymentFailCallbackErr();
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
	static public int get_errCode(IntPtr l) {
		try {
			WeChatWASM.RequestMidasPaymentFailCallbackErr self=(WeChatWASM.RequestMidasPaymentFailCallbackErr)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.errCode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_errCode(IntPtr l) {
		try {
			WeChatWASM.RequestMidasPaymentFailCallbackErr self=(WeChatWASM.RequestMidasPaymentFailCallbackErr)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.errCode=v;
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
			WeChatWASM.RequestMidasPaymentFailCallbackErr self=(WeChatWASM.RequestMidasPaymentFailCallbackErr)checkSelf(l);
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
			WeChatWASM.RequestMidasPaymentFailCallbackErr self=(WeChatWASM.RequestMidasPaymentFailCallbackErr)checkSelf(l);
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
		getTypeTable(l,"WeChatWASM.RequestMidasPaymentFailCallbackErr");
		addMember(l,"errCode",get_errCode,set_errCode,true);
		addMember(l,"errMsg",get_errMsg,set_errMsg,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.RequestMidasPaymentFailCallbackErr));
	}
}
