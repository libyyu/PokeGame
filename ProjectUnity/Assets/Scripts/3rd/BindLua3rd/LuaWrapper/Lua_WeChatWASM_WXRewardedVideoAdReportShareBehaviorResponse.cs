//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXRewardedVideoAdReportShareBehaviorResponse : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXRewardedVideoAdReportShareBehaviorResponse o;
			o=new WeChatWASM.WXRewardedVideoAdReportShareBehaviorResponse();
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
	static public int get_success(IntPtr l) {
		try {
			WeChatWASM.WXRewardedVideoAdReportShareBehaviorResponse self=(WeChatWASM.WXRewardedVideoAdReportShareBehaviorResponse)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.success);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_success(IntPtr l) {
		try {
			WeChatWASM.WXRewardedVideoAdReportShareBehaviorResponse self=(WeChatWASM.WXRewardedVideoAdReportShareBehaviorResponse)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.success=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_message(IntPtr l) {
		try {
			WeChatWASM.WXRewardedVideoAdReportShareBehaviorResponse self=(WeChatWASM.WXRewardedVideoAdReportShareBehaviorResponse)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.message);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_message(IntPtr l) {
		try {
			WeChatWASM.WXRewardedVideoAdReportShareBehaviorResponse self=(WeChatWASM.WXRewardedVideoAdReportShareBehaviorResponse)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.message=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXRewardedVideoAdReportShareBehaviorResponse");
		addMember(l,"success",get_success,set_success,true);
		addMember(l,"message",get_message,set_message,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXRewardedVideoAdReportShareBehaviorResponse),typeof(WeChatWASM.WXBaseResponse));
	}
}
