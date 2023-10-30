//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_RequestMidasPaymentGameItemOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.RequestMidasPaymentGameItemOption o;
			o=new WeChatWASM.RequestMidasPaymentGameItemOption();
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
	static public int get_signData(IntPtr l) {
		try {
			WeChatWASM.RequestMidasPaymentGameItemOption self=(WeChatWASM.RequestMidasPaymentGameItemOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.signData);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_signData(IntPtr l) {
		try {
			WeChatWASM.RequestMidasPaymentGameItemOption self=(WeChatWASM.RequestMidasPaymentGameItemOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.signData=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_paySig(IntPtr l) {
		try {
			WeChatWASM.RequestMidasPaymentGameItemOption self=(WeChatWASM.RequestMidasPaymentGameItemOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.paySig);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_paySig(IntPtr l) {
		try {
			WeChatWASM.RequestMidasPaymentGameItemOption self=(WeChatWASM.RequestMidasPaymentGameItemOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.paySig=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_signature(IntPtr l) {
		try {
			WeChatWASM.RequestMidasPaymentGameItemOption self=(WeChatWASM.RequestMidasPaymentGameItemOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.signature);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_signature(IntPtr l) {
		try {
			WeChatWASM.RequestMidasPaymentGameItemOption self=(WeChatWASM.RequestMidasPaymentGameItemOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.signature=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_complete(IntPtr l) {
		try {
			WeChatWASM.RequestMidasPaymentGameItemOption self=(WeChatWASM.RequestMidasPaymentGameItemOption)checkSelf(l);
			System.Action<WeChatWASM.MidasPaymentGameItemError> v;
			int op=checkDelegate(l,2,out v);
			if(op==0) self.complete=v;
			else if(op==1) self.complete+=v;
			else if(op==2) self.complete-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_fail(IntPtr l) {
		try {
			WeChatWASM.RequestMidasPaymentGameItemOption self=(WeChatWASM.RequestMidasPaymentGameItemOption)checkSelf(l);
			System.Action<WeChatWASM.MidasPaymentGameItemError> v;
			int op=checkDelegate(l,2,out v);
			if(op==0) self.fail=v;
			else if(op==1) self.fail+=v;
			else if(op==2) self.fail-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_success(IntPtr l) {
		try {
			WeChatWASM.RequestMidasPaymentGameItemOption self=(WeChatWASM.RequestMidasPaymentGameItemOption)checkSelf(l);
			System.Action<WeChatWASM.GeneralCallbackResult> v;
			int op=checkDelegate(l,2,out v);
			if(op==0) self.success=v;
			else if(op==1) self.success+=v;
			else if(op==2) self.success-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.RequestMidasPaymentGameItemOption");
		addMember(l,"signData",get_signData,set_signData,true);
		addMember(l,"paySig",get_paySig,set_paySig,true);
		addMember(l,"signature",get_signature,set_signature,true);
		addMember(l,"complete",null,set_complete,true);
		addMember(l,"fail",null,set_fail,true);
		addMember(l,"success",null,set_success,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.RequestMidasPaymentGameItemOption));
	}
}
