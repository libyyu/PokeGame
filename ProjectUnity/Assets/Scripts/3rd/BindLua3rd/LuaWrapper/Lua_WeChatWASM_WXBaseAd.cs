//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXBaseAd : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXBaseAd o;
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			o=new WeChatWASM.WXBaseAd(a1);
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
	static public int Show(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				WeChatWASM.WXBaseAd self=(WeChatWASM.WXBaseAd)checkSelf(l);
				System.Action<WeChatWASM.WXTextResponse> a1 = default(System.Action<WeChatWASM.WXTextResponse>);
				checkDelegate(l,2,out a1);
				System.Action<WeChatWASM.WXTextResponse> a2 = default(System.Action<WeChatWASM.WXTextResponse>);
				checkDelegate(l,3,out a2);
				self.Show(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==5){
				WeChatWASM.WXBaseAd self=(WeChatWASM.WXBaseAd)checkSelf(l);
				System.String a1 = default(System.String);
				checkType(l,2,out a1);
				System.String a2 = default(System.String);
				checkType(l,3,out a2);
				System.Action<WeChatWASM.WXTextResponse> a3 = default(System.Action<WeChatWASM.WXTextResponse>);
				checkDelegate(l,4,out a3);
				System.Action<WeChatWASM.WXTextResponse> a4 = default(System.Action<WeChatWASM.WXTextResponse>);
				checkDelegate(l,5,out a4);
				self.Show(a1,a2,a3,a4);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function Show to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnError(IntPtr l) {
		try {
			WeChatWASM.WXBaseAd self=(WeChatWASM.WXBaseAd)checkSelf(l);
			System.Action<WeChatWASM.WXADErrorResponse> a1 = default(System.Action<WeChatWASM.WXADErrorResponse>);
			checkDelegate(l,2,out a1);
			self.OnError(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnLoad(IntPtr l) {
		try {
			WeChatWASM.WXBaseAd self=(WeChatWASM.WXBaseAd)checkSelf(l);
			System.Action<WeChatWASM.WXADLoadResponse> a1 = default(System.Action<WeChatWASM.WXADLoadResponse>);
			checkDelegate(l,2,out a1);
			self.OnLoad(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffError(IntPtr l) {
		try {
			WeChatWASM.WXBaseAd self=(WeChatWASM.WXBaseAd)checkSelf(l);
			System.Action<WeChatWASM.WXADErrorResponse> a1 = default(System.Action<WeChatWASM.WXADErrorResponse>);
			checkDelegate(l,2,out a1);
			self.OffError(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffLoad(IntPtr l) {
		try {
			WeChatWASM.WXBaseAd self=(WeChatWASM.WXBaseAd)checkSelf(l);
			System.Action<WeChatWASM.WXADLoadResponse> a1 = default(System.Action<WeChatWASM.WXADLoadResponse>);
			checkDelegate(l,2,out a1);
			self.OffLoad(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Destroy(IntPtr l) {
		try {
			WeChatWASM.WXBaseAd self=(WeChatWASM.WXBaseAd)checkSelf(l);
			self.Destroy();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_instanceId(IntPtr l) {
		try {
			WeChatWASM.WXBaseAd self=(WeChatWASM.WXBaseAd)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.instanceId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_instanceId(IntPtr l) {
		try {
			WeChatWASM.WXBaseAd self=(WeChatWASM.WXBaseAd)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.instanceId=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Dict(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,WeChatWASM.WXBaseAd.Dict);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_Dict(IntPtr l) {
		try {
			System.Collections.Generic.Dictionary<System.String,WeChatWASM.WXBaseAd> v;
			checkType(l,2,out v);
			WeChatWASM.WXBaseAd.Dict=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_onErrorAction(IntPtr l) {
		try {
			WeChatWASM.WXBaseAd self=(WeChatWASM.WXBaseAd)checkSelf(l);
			System.Action<WeChatWASM.WXADErrorResponse> v;
			int op=checkDelegate(l,2,out v);
			if(op==0) self.onErrorAction=v;
			else if(op==1) self.onErrorAction+=v;
			else if(op==2) self.onErrorAction-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_onLoadActon(IntPtr l) {
		try {
			WeChatWASM.WXBaseAd self=(WeChatWASM.WXBaseAd)checkSelf(l);
			System.Action<WeChatWASM.WXADLoadResponse> v;
			int op=checkDelegate(l,2,out v);
			if(op==0) self.onLoadActon=v;
			else if(op==1) self.onLoadActon+=v;
			else if(op==2) self.onLoadActon-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXBaseAd");
		addMember(l,Show);
		addMember(l,OnError);
		addMember(l,OnLoad);
		addMember(l,OffError);
		addMember(l,OffLoad);
		addMember(l,Destroy);
		addMember(l,"instanceId",get_instanceId,set_instanceId,true);
		addMember(l,"Dict",get_Dict,set_Dict,false);
		addMember(l,"onErrorAction",null,set_onErrorAction,true);
		addMember(l,"onLoadActon",null,set_onLoadActon,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXBaseAd));
	}
}
