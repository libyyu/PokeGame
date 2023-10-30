//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_GetUserGameLiveDetailsSuccessCallbackOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.GetUserGameLiveDetailsSuccessCallbackOption o;
			o=new WeChatWASM.GetUserGameLiveDetailsSuccessCallbackOption();
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
	static public int get_encryptedData(IntPtr l) {
		try {
			WeChatWASM.GetUserGameLiveDetailsSuccessCallbackOption self=(WeChatWASM.GetUserGameLiveDetailsSuccessCallbackOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.encryptedData);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_encryptedData(IntPtr l) {
		try {
			WeChatWASM.GetUserGameLiveDetailsSuccessCallbackOption self=(WeChatWASM.GetUserGameLiveDetailsSuccessCallbackOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.encryptedData=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_iv(IntPtr l) {
		try {
			WeChatWASM.GetUserGameLiveDetailsSuccessCallbackOption self=(WeChatWASM.GetUserGameLiveDetailsSuccessCallbackOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.iv);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_iv(IntPtr l) {
		try {
			WeChatWASM.GetUserGameLiveDetailsSuccessCallbackOption self=(WeChatWASM.GetUserGameLiveDetailsSuccessCallbackOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.iv=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_cloudID(IntPtr l) {
		try {
			WeChatWASM.GetUserGameLiveDetailsSuccessCallbackOption self=(WeChatWASM.GetUserGameLiveDetailsSuccessCallbackOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.cloudID);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_cloudID(IntPtr l) {
		try {
			WeChatWASM.GetUserGameLiveDetailsSuccessCallbackOption self=(WeChatWASM.GetUserGameLiveDetailsSuccessCallbackOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.cloudID=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_feedIdList(IntPtr l) {
		try {
			WeChatWASM.GetUserGameLiveDetailsSuccessCallbackOption self=(WeChatWASM.GetUserGameLiveDetailsSuccessCallbackOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.feedIdList);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_feedIdList(IntPtr l) {
		try {
			WeChatWASM.GetUserGameLiveDetailsSuccessCallbackOption self=(WeChatWASM.GetUserGameLiveDetailsSuccessCallbackOption)checkSelf(l);
			System.String[] v;
			checkArray(l,2,out v);
			self.feedIdList=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_errMsg(IntPtr l) {
		try {
			WeChatWASM.GetUserGameLiveDetailsSuccessCallbackOption self=(WeChatWASM.GetUserGameLiveDetailsSuccessCallbackOption)checkSelf(l);
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
			WeChatWASM.GetUserGameLiveDetailsSuccessCallbackOption self=(WeChatWASM.GetUserGameLiveDetailsSuccessCallbackOption)checkSelf(l);
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
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.GetUserGameLiveDetailsSuccessCallbackOption");
		addMember(l,"encryptedData",get_encryptedData,set_encryptedData,true);
		addMember(l,"iv",get_iv,set_iv,true);
		addMember(l,"cloudID",get_cloudID,set_cloudID,true);
		addMember(l,"feedIdList",get_feedIdList,set_feedIdList,true);
		addMember(l,"errMsg",get_errMsg,set_errMsg,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.GetUserGameLiveDetailsSuccessCallbackOption));
	}
}
