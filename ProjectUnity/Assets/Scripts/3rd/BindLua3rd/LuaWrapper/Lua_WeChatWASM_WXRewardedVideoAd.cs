//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXRewardedVideoAd : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXRewardedVideoAd o;
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			o=new WeChatWASM.WXRewardedVideoAd(a1);
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
	static public int OnCloseCallback(IntPtr l) {
		try {
			WeChatWASM.WXRewardedVideoAd self=(WeChatWASM.WXRewardedVideoAd)checkSelf(l);
			WeChatWASM.WXRewardedVideoAdOnCloseResponse a1 = default(WeChatWASM.WXRewardedVideoAdOnCloseResponse);
			checkType(l,2,out a1);
			self.OnCloseCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Load(IntPtr l) {
		try {
			WeChatWASM.WXRewardedVideoAd self=(WeChatWASM.WXRewardedVideoAd)checkSelf(l);
			System.Action<WeChatWASM.WXTextResponse> a1 = default(System.Action<WeChatWASM.WXTextResponse>);
			checkDelegate(l,2,out a1);
			System.Action<WeChatWASM.WXADErrorResponse> a2 = default(System.Action<WeChatWASM.WXADErrorResponse>);
			checkDelegate(l,3,out a2);
			self.Load(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnClose(IntPtr l) {
		try {
			WeChatWASM.WXRewardedVideoAd self=(WeChatWASM.WXRewardedVideoAd)checkSelf(l);
			System.Action<WeChatWASM.WXRewardedVideoAdOnCloseResponse> a1 = default(System.Action<WeChatWASM.WXRewardedVideoAdOnCloseResponse>);
			checkDelegate(l,2,out a1);
			self.OnClose(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffClose(IntPtr l) {
		try {
			WeChatWASM.WXRewardedVideoAd self=(WeChatWASM.WXRewardedVideoAd)checkSelf(l);
			System.Action<WeChatWASM.WXRewardedVideoAdOnCloseResponse> a1 = default(System.Action<WeChatWASM.WXRewardedVideoAdOnCloseResponse>);
			checkDelegate(l,2,out a1);
			self.OffClose(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReportShareBehavior(IntPtr l) {
		try {
			WeChatWASM.WXRewardedVideoAd self=(WeChatWASM.WXRewardedVideoAd)checkSelf(l);
			WeChatWASM.RequestAdReportShareBehaviorParam a1 = default(WeChatWASM.RequestAdReportShareBehaviorParam);
			checkType(l,2,out a1);
			var ret=self.ReportShareBehavior(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_onCloseAction(IntPtr l) {
		try {
			WeChatWASM.WXRewardedVideoAd self=(WeChatWASM.WXRewardedVideoAd)checkSelf(l);
			System.Action<WeChatWASM.WXRewardedVideoAdOnCloseResponse> v;
			int op=checkDelegate(l,2,out v);
			if(op==0) self.onCloseAction=v;
			else if(op==1) self.onCloseAction+=v;
			else if(op==2) self.onCloseAction-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXRewardedVideoAd");
		addMember(l,OnCloseCallback);
		addMember(l,Load);
		addMember(l,OnClose);
		addMember(l,OffClose);
		addMember(l,ReportShareBehavior);
		addMember(l,"onCloseAction",null,set_onCloseAction,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXRewardedVideoAd),typeof(WeChatWASM.WXBaseAd));
	}
}
