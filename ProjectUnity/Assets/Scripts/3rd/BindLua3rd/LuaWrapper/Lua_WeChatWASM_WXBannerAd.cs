//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXBannerAd : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXBannerAd o;
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			WeChatWASM.Style a2 = default(WeChatWASM.Style);
			checkValueType(l,3,out a2);
			o=new WeChatWASM.WXBannerAd(a1,a2);
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
	static public int OnResizeCallback(IntPtr l) {
		try {
			WeChatWASM.WXBannerAd self=(WeChatWASM.WXBannerAd)checkSelf(l);
			WeChatWASM.WXADResizeResponse a1 = default(WeChatWASM.WXADResizeResponse);
			checkType(l,2,out a1);
			self.OnResizeCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnResize(IntPtr l) {
		try {
			WeChatWASM.WXBannerAd self=(WeChatWASM.WXBannerAd)checkSelf(l);
			System.Action<WeChatWASM.WXADResizeResponse> a1 = default(System.Action<WeChatWASM.WXADResizeResponse>);
			checkDelegate(l,2,out a1);
			self.OnResize(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffResize(IntPtr l) {
		try {
			WeChatWASM.WXBannerAd self=(WeChatWASM.WXBannerAd)checkSelf(l);
			System.Action<WeChatWASM.WXADResizeResponse> a1 = default(System.Action<WeChatWASM.WXADResizeResponse>);
			checkDelegate(l,2,out a1);
			self.OffResize(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Hide(IntPtr l) {
		try {
			WeChatWASM.WXBannerAd self=(WeChatWASM.WXBannerAd)checkSelf(l);
			self.Hide();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_style(IntPtr l) {
		try {
			WeChatWASM.WXBannerAd self=(WeChatWASM.WXBannerAd)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.style);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_style(IntPtr l) {
		try {
			WeChatWASM.WXBannerAd self=(WeChatWASM.WXBannerAd)checkSelf(l);
			WeChatWASM.WXAdBaseStyle v;
			checkType(l,2,out v);
			self.style=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_onResizeAction(IntPtr l) {
		try {
			WeChatWASM.WXBannerAd self=(WeChatWASM.WXBannerAd)checkSelf(l);
			System.Action<WeChatWASM.WXADResizeResponse> v;
			int op=checkDelegate(l,2,out v);
			if(op==0) self.onResizeAction=v;
			else if(op==1) self.onResizeAction+=v;
			else if(op==2) self.onResizeAction-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXBannerAd");
		addMember(l,OnResizeCallback);
		addMember(l,OnResize);
		addMember(l,OffResize);
		addMember(l,Hide);
		addMember(l,"style",get_style,set_style,true);
		addMember(l,"onResizeAction",null,set_onResizeAction,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXBannerAd),typeof(WeChatWASM.WXBaseAd));
	}
}
