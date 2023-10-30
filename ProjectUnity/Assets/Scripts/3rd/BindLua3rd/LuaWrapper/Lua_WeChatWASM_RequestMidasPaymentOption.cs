//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_RequestMidasPaymentOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.RequestMidasPaymentOption o;
			o=new WeChatWASM.RequestMidasPaymentOption();
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
	static public int get_currencyType(IntPtr l) {
		try {
			WeChatWASM.RequestMidasPaymentOption self=(WeChatWASM.RequestMidasPaymentOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.currencyType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_currencyType(IntPtr l) {
		try {
			WeChatWASM.RequestMidasPaymentOption self=(WeChatWASM.RequestMidasPaymentOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.currencyType=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_mode(IntPtr l) {
		try {
			WeChatWASM.RequestMidasPaymentOption self=(WeChatWASM.RequestMidasPaymentOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.mode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_mode(IntPtr l) {
		try {
			WeChatWASM.RequestMidasPaymentOption self=(WeChatWASM.RequestMidasPaymentOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.mode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_offerId(IntPtr l) {
		try {
			WeChatWASM.RequestMidasPaymentOption self=(WeChatWASM.RequestMidasPaymentOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.offerId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_offerId(IntPtr l) {
		try {
			WeChatWASM.RequestMidasPaymentOption self=(WeChatWASM.RequestMidasPaymentOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.offerId=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_outTradeNo(IntPtr l) {
		try {
			WeChatWASM.RequestMidasPaymentOption self=(WeChatWASM.RequestMidasPaymentOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.outTradeNo);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_outTradeNo(IntPtr l) {
		try {
			WeChatWASM.RequestMidasPaymentOption self=(WeChatWASM.RequestMidasPaymentOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.outTradeNo=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_buyQuantity(IntPtr l) {
		try {
			WeChatWASM.RequestMidasPaymentOption self=(WeChatWASM.RequestMidasPaymentOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.buyQuantity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_buyQuantity(IntPtr l) {
		try {
			WeChatWASM.RequestMidasPaymentOption self=(WeChatWASM.RequestMidasPaymentOption)checkSelf(l);
			System.Nullable<System.Double> v;
			checkNullable(l,2,out v);
			self.buyQuantity=v;
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
			WeChatWASM.RequestMidasPaymentOption self=(WeChatWASM.RequestMidasPaymentOption)checkSelf(l);
			System.Action<WeChatWASM.MidasPaymentError> v;
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
	static public int get_env(IntPtr l) {
		try {
			WeChatWASM.RequestMidasPaymentOption self=(WeChatWASM.RequestMidasPaymentOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.env);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_env(IntPtr l) {
		try {
			WeChatWASM.RequestMidasPaymentOption self=(WeChatWASM.RequestMidasPaymentOption)checkSelf(l);
			System.Nullable<System.Double> v;
			checkNullable(l,2,out v);
			self.env=v;
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
			WeChatWASM.RequestMidasPaymentOption self=(WeChatWASM.RequestMidasPaymentOption)checkSelf(l);
			System.Action<WeChatWASM.RequestMidasPaymentFailCallbackErr> v;
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
	static public int get_platform(IntPtr l) {
		try {
			WeChatWASM.RequestMidasPaymentOption self=(WeChatWASM.RequestMidasPaymentOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.platform);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_platform(IntPtr l) {
		try {
			WeChatWASM.RequestMidasPaymentOption self=(WeChatWASM.RequestMidasPaymentOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.platform=v;
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
			WeChatWASM.RequestMidasPaymentOption self=(WeChatWASM.RequestMidasPaymentOption)checkSelf(l);
			System.Action<WeChatWASM.RequestMidasPaymentSuccessCallbackResult> v;
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_zoneId(IntPtr l) {
		try {
			WeChatWASM.RequestMidasPaymentOption self=(WeChatWASM.RequestMidasPaymentOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.zoneId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_zoneId(IntPtr l) {
		try {
			WeChatWASM.RequestMidasPaymentOption self=(WeChatWASM.RequestMidasPaymentOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.zoneId=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.RequestMidasPaymentOption");
		addMember(l,"currencyType",get_currencyType,set_currencyType,true);
		addMember(l,"mode",get_mode,set_mode,true);
		addMember(l,"offerId",get_offerId,set_offerId,true);
		addMember(l,"outTradeNo",get_outTradeNo,set_outTradeNo,true);
		addMember(l,"buyQuantity",get_buyQuantity,set_buyQuantity,true);
		addMember(l,"complete",null,set_complete,true);
		addMember(l,"env",get_env,set_env,true);
		addMember(l,"fail",null,set_fail,true);
		addMember(l,"platform",get_platform,set_platform,true);
		addMember(l,"success",null,set_success,true);
		addMember(l,"zoneId",get_zoneId,set_zoneId,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.RequestMidasPaymentOption));
	}
}
