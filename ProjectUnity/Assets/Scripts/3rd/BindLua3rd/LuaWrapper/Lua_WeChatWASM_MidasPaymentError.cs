//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_MidasPaymentError : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.MidasPaymentError o;
			o=new WeChatWASM.MidasPaymentError();
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
			WeChatWASM.MidasPaymentError self=(WeChatWASM.MidasPaymentError)checkSelf(l);
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
			WeChatWASM.MidasPaymentError self=(WeChatWASM.MidasPaymentError)checkSelf(l);
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
	static public int get_errCode(IntPtr l) {
		try {
			WeChatWASM.MidasPaymentError self=(WeChatWASM.MidasPaymentError)checkSelf(l);
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
			WeChatWASM.MidasPaymentError self=(WeChatWASM.MidasPaymentError)checkSelf(l);
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
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.MidasPaymentError");
		addMember(l,"errMsg",get_errMsg,set_errMsg,true);
		addMember(l,"errCode",get_errCode,set_errCode,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.MidasPaymentError));
	}
}
