//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXCustomAd : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXCustomAd o;
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			WeChatWASM.CustomStyle a2 = default(WeChatWASM.CustomStyle);
			checkValueType(l,3,out a2);
			o=new WeChatWASM.WXCustomAd(a1,a2);
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
			WeChatWASM.WXCustomAd self=(WeChatWASM.WXCustomAd)checkSelf(l);
			self.OnCloseCallback();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnHideCallback(IntPtr l) {
		try {
			WeChatWASM.WXCustomAd self=(WeChatWASM.WXCustomAd)checkSelf(l);
			self.OnHideCallback();
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
			WeChatWASM.WXCustomAd self=(WeChatWASM.WXCustomAd)checkSelf(l);
			System.Action a1 = default(System.Action);
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
	static public int OnHide(IntPtr l) {
		try {
			WeChatWASM.WXCustomAd self=(WeChatWASM.WXCustomAd)checkSelf(l);
			System.Action a1 = default(System.Action);
			checkDelegate(l,2,out a1);
			self.OnHide(a1);
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
			WeChatWASM.WXCustomAd self=(WeChatWASM.WXCustomAd)checkSelf(l);
			System.Action a1 = default(System.Action);
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
	static public int OffHide(IntPtr l) {
		try {
			WeChatWASM.WXCustomAd self=(WeChatWASM.WXCustomAd)checkSelf(l);
			System.Action a1 = default(System.Action);
			checkDelegate(l,2,out a1);
			self.OffHide(a1);
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
			WeChatWASM.WXCustomAd self=(WeChatWASM.WXCustomAd)checkSelf(l);
			System.Action<WeChatWASM.WXTextResponse> a1 = default(System.Action<WeChatWASM.WXTextResponse>);
			checkDelegate(l,2,out a1);
			System.Action<WeChatWASM.WXTextResponse> a2 = default(System.Action<WeChatWASM.WXTextResponse>);
			checkDelegate(l,3,out a2);
			self.Hide(a1,a2);
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
			WeChatWASM.WXCustomAd self=(WeChatWASM.WXCustomAd)checkSelf(l);
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
			WeChatWASM.WXCustomAd self=(WeChatWASM.WXCustomAd)checkSelf(l);
			WeChatWASM.WXAdCustomStyle v;
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
	static public int set_onCloseAction(IntPtr l) {
		try {
			WeChatWASM.WXCustomAd self=(WeChatWASM.WXCustomAd)checkSelf(l);
			System.Action v;
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_onHideAction(IntPtr l) {
		try {
			WeChatWASM.WXCustomAd self=(WeChatWASM.WXCustomAd)checkSelf(l);
			System.Action v;
			int op=checkDelegate(l,2,out v);
			if(op==0) self.onHideAction=v;
			else if(op==1) self.onHideAction+=v;
			else if(op==2) self.onHideAction-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXCustomAd");
		addMember(l,OnCloseCallback);
		addMember(l,OnHideCallback);
		addMember(l,OnClose);
		addMember(l,OnHide);
		addMember(l,OffClose);
		addMember(l,OffHide);
		addMember(l,Hide);
		addMember(l,"style",get_style,set_style,true);
		addMember(l,"onCloseAction",null,set_onCloseAction,true);
		addMember(l,"onHideAction",null,set_onHideAction,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXCustomAd),typeof(WeChatWASM.WXBaseAd));
	}
}
