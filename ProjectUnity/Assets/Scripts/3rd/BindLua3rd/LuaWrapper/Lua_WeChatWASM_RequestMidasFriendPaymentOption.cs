//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_RequestMidasFriendPaymentOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.RequestMidasFriendPaymentOption o;
			o=new WeChatWASM.RequestMidasFriendPaymentOption();
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
	static public int get_buyQuantity(IntPtr l) {
		try {
			WeChatWASM.RequestMidasFriendPaymentOption self=(WeChatWASM.RequestMidasFriendPaymentOption)checkSelf(l);
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
			WeChatWASM.RequestMidasFriendPaymentOption self=(WeChatWASM.RequestMidasFriendPaymentOption)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
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
	static public int get_currencyType(IntPtr l) {
		try {
			WeChatWASM.RequestMidasFriendPaymentOption self=(WeChatWASM.RequestMidasFriendPaymentOption)checkSelf(l);
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
			WeChatWASM.RequestMidasFriendPaymentOption self=(WeChatWASM.RequestMidasFriendPaymentOption)checkSelf(l);
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
	static public int get_env(IntPtr l) {
		try {
			WeChatWASM.RequestMidasFriendPaymentOption self=(WeChatWASM.RequestMidasFriendPaymentOption)checkSelf(l);
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
			WeChatWASM.RequestMidasFriendPaymentOption self=(WeChatWASM.RequestMidasFriendPaymentOption)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
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
	static public int get_mode(IntPtr l) {
		try {
			WeChatWASM.RequestMidasFriendPaymentOption self=(WeChatWASM.RequestMidasFriendPaymentOption)checkSelf(l);
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
			WeChatWASM.RequestMidasFriendPaymentOption self=(WeChatWASM.RequestMidasFriendPaymentOption)checkSelf(l);
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
	static public int get_nonceStr(IntPtr l) {
		try {
			WeChatWASM.RequestMidasFriendPaymentOption self=(WeChatWASM.RequestMidasFriendPaymentOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.nonceStr);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_nonceStr(IntPtr l) {
		try {
			WeChatWASM.RequestMidasFriendPaymentOption self=(WeChatWASM.RequestMidasFriendPaymentOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.nonceStr=v;
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
			WeChatWASM.RequestMidasFriendPaymentOption self=(WeChatWASM.RequestMidasFriendPaymentOption)checkSelf(l);
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
			WeChatWASM.RequestMidasFriendPaymentOption self=(WeChatWASM.RequestMidasFriendPaymentOption)checkSelf(l);
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
			WeChatWASM.RequestMidasFriendPaymentOption self=(WeChatWASM.RequestMidasFriendPaymentOption)checkSelf(l);
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
			WeChatWASM.RequestMidasFriendPaymentOption self=(WeChatWASM.RequestMidasFriendPaymentOption)checkSelf(l);
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
	static public int get_platform(IntPtr l) {
		try {
			WeChatWASM.RequestMidasFriendPaymentOption self=(WeChatWASM.RequestMidasFriendPaymentOption)checkSelf(l);
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
			WeChatWASM.RequestMidasFriendPaymentOption self=(WeChatWASM.RequestMidasFriendPaymentOption)checkSelf(l);
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
	static public int get_signature(IntPtr l) {
		try {
			WeChatWASM.RequestMidasFriendPaymentOption self=(WeChatWASM.RequestMidasFriendPaymentOption)checkSelf(l);
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
			WeChatWASM.RequestMidasFriendPaymentOption self=(WeChatWASM.RequestMidasFriendPaymentOption)checkSelf(l);
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
	static public int get_timeStamp(IntPtr l) {
		try {
			WeChatWASM.RequestMidasFriendPaymentOption self=(WeChatWASM.RequestMidasFriendPaymentOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.timeStamp);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_timeStamp(IntPtr l) {
		try {
			WeChatWASM.RequestMidasFriendPaymentOption self=(WeChatWASM.RequestMidasFriendPaymentOption)checkSelf(l);
			System.Int64 v;
			checkType(l,2,out v);
			self.timeStamp=v;
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
			WeChatWASM.RequestMidasFriendPaymentOption self=(WeChatWASM.RequestMidasFriendPaymentOption)checkSelf(l);
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
			WeChatWASM.RequestMidasFriendPaymentOption self=(WeChatWASM.RequestMidasFriendPaymentOption)checkSelf(l);
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_complete(IntPtr l) {
		try {
			WeChatWASM.RequestMidasFriendPaymentOption self=(WeChatWASM.RequestMidasFriendPaymentOption)checkSelf(l);
			System.Action<WeChatWASM.MidasFriendPaymentError> v;
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
			WeChatWASM.RequestMidasFriendPaymentOption self=(WeChatWASM.RequestMidasFriendPaymentOption)checkSelf(l);
			System.Action<WeChatWASM.MidasFriendPaymentError> v;
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
			WeChatWASM.RequestMidasFriendPaymentOption self=(WeChatWASM.RequestMidasFriendPaymentOption)checkSelf(l);
			System.Action<WeChatWASM.RequestMidasFriendPaymentSuccessCallbackResult> v;
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
		getTypeTable(l,"WeChatWASM.RequestMidasFriendPaymentOption");
		addMember(l,"buyQuantity",get_buyQuantity,set_buyQuantity,true);
		addMember(l,"currencyType",get_currencyType,set_currencyType,true);
		addMember(l,"env",get_env,set_env,true);
		addMember(l,"mode",get_mode,set_mode,true);
		addMember(l,"nonceStr",get_nonceStr,set_nonceStr,true);
		addMember(l,"offerId",get_offerId,set_offerId,true);
		addMember(l,"outTradeNo",get_outTradeNo,set_outTradeNo,true);
		addMember(l,"platform",get_platform,set_platform,true);
		addMember(l,"signature",get_signature,set_signature,true);
		addMember(l,"timeStamp",get_timeStamp,set_timeStamp,true);
		addMember(l,"zoneId",get_zoneId,set_zoneId,true);
		addMember(l,"complete",null,set_complete,true);
		addMember(l,"fail",null,set_fail,true);
		addMember(l,"success",null,set_success,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.RequestMidasFriendPaymentOption));
	}
}
