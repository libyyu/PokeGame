﻿//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_GetUserInfoSuccessCallbackResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.GetUserInfoSuccessCallbackResult o;
			o=new WeChatWASM.GetUserInfoSuccessCallbackResult();
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
	static public int get_cloudID(IntPtr l) {
		try {
			WeChatWASM.GetUserInfoSuccessCallbackResult self=(WeChatWASM.GetUserInfoSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.GetUserInfoSuccessCallbackResult self=(WeChatWASM.GetUserInfoSuccessCallbackResult)checkSelf(l);
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
	static public int get_encryptedData(IntPtr l) {
		try {
			WeChatWASM.GetUserInfoSuccessCallbackResult self=(WeChatWASM.GetUserInfoSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.GetUserInfoSuccessCallbackResult self=(WeChatWASM.GetUserInfoSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.GetUserInfoSuccessCallbackResult self=(WeChatWASM.GetUserInfoSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.GetUserInfoSuccessCallbackResult self=(WeChatWASM.GetUserInfoSuccessCallbackResult)checkSelf(l);
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
	static public int get_rawData(IntPtr l) {
		try {
			WeChatWASM.GetUserInfoSuccessCallbackResult self=(WeChatWASM.GetUserInfoSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rawData);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_rawData(IntPtr l) {
		try {
			WeChatWASM.GetUserInfoSuccessCallbackResult self=(WeChatWASM.GetUserInfoSuccessCallbackResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.rawData=v;
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
			WeChatWASM.GetUserInfoSuccessCallbackResult self=(WeChatWASM.GetUserInfoSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.GetUserInfoSuccessCallbackResult self=(WeChatWASM.GetUserInfoSuccessCallbackResult)checkSelf(l);
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
	static public int get_userInfo(IntPtr l) {
		try {
			WeChatWASM.GetUserInfoSuccessCallbackResult self=(WeChatWASM.GetUserInfoSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.userInfo);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_userInfo(IntPtr l) {
		try {
			WeChatWASM.GetUserInfoSuccessCallbackResult self=(WeChatWASM.GetUserInfoSuccessCallbackResult)checkSelf(l);
			WeChatWASM.UserInfo v;
			checkType(l,2,out v);
			self.userInfo=v;
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
			WeChatWASM.GetUserInfoSuccessCallbackResult self=(WeChatWASM.GetUserInfoSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.GetUserInfoSuccessCallbackResult self=(WeChatWASM.GetUserInfoSuccessCallbackResult)checkSelf(l);
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
		getTypeTable(l,"WeChatWASM.GetUserInfoSuccessCallbackResult");
		addMember(l,"cloudID",get_cloudID,set_cloudID,true);
		addMember(l,"encryptedData",get_encryptedData,set_encryptedData,true);
		addMember(l,"iv",get_iv,set_iv,true);
		addMember(l,"rawData",get_rawData,set_rawData,true);
		addMember(l,"signature",get_signature,set_signature,true);
		addMember(l,"userInfo",get_userInfo,set_userInfo,true);
		addMember(l,"errMsg",get_errMsg,set_errMsg,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.GetUserInfoSuccessCallbackResult));
	}
}
