//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_EnterOptionsGameReferrerInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.EnterOptionsGameReferrerInfo o;
			o=new WeChatWASM.EnterOptionsGameReferrerInfo();
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
	static public int get_appId(IntPtr l) {
		try {
			WeChatWASM.EnterOptionsGameReferrerInfo self=(WeChatWASM.EnterOptionsGameReferrerInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.appId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_appId(IntPtr l) {
		try {
			WeChatWASM.EnterOptionsGameReferrerInfo self=(WeChatWASM.EnterOptionsGameReferrerInfo)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.appId=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_extraData(IntPtr l) {
		try {
			WeChatWASM.EnterOptionsGameReferrerInfo self=(WeChatWASM.EnterOptionsGameReferrerInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.extraData);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_extraData(IntPtr l) {
		try {
			WeChatWASM.EnterOptionsGameReferrerInfo self=(WeChatWASM.EnterOptionsGameReferrerInfo)checkSelf(l);
			System.Collections.Generic.Dictionary<System.String,System.String> v;
			checkType(l,2,out v);
			self.extraData=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_gameLiveInfo(IntPtr l) {
		try {
			WeChatWASM.EnterOptionsGameReferrerInfo self=(WeChatWASM.EnterOptionsGameReferrerInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.gameLiveInfo);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_gameLiveInfo(IntPtr l) {
		try {
			WeChatWASM.EnterOptionsGameReferrerInfo self=(WeChatWASM.EnterOptionsGameReferrerInfo)checkSelf(l);
			WeChatWASM.GameLiveInfo v;
			checkType(l,2,out v);
			self.gameLiveInfo=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.EnterOptionsGameReferrerInfo");
		addMember(l,"appId",get_appId,set_appId,true);
		addMember(l,"extraData",get_extraData,set_extraData,true);
		addMember(l,"gameLiveInfo",get_gameLiveInfo,set_gameLiveInfo,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.EnterOptionsGameReferrerInfo));
	}
}
