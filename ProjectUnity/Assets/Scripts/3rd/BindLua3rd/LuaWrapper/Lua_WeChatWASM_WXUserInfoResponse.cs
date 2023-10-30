//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXUserInfoResponse : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXUserInfoResponse o;
			o=new WeChatWASM.WXUserInfoResponse();
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
	static public int get_errCode(IntPtr l) {
		try {
			WeChatWASM.WXUserInfoResponse self=(WeChatWASM.WXUserInfoResponse)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.errCode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_errCode(IntPtr l) {
		try {
			WeChatWASM.WXUserInfoResponse self=(WeChatWASM.WXUserInfoResponse)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.errCode=v;
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
			WeChatWASM.WXUserInfoResponse self=(WeChatWASM.WXUserInfoResponse)checkSelf(l);
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
			WeChatWASM.WXUserInfoResponse self=(WeChatWASM.WXUserInfoResponse)checkSelf(l);
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
	static public int get_encryptedData(IntPtr l) {
		try {
			WeChatWASM.WXUserInfoResponse self=(WeChatWASM.WXUserInfoResponse)checkSelf(l);
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
			WeChatWASM.WXUserInfoResponse self=(WeChatWASM.WXUserInfoResponse)checkSelf(l);
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
			WeChatWASM.WXUserInfoResponse self=(WeChatWASM.WXUserInfoResponse)checkSelf(l);
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
			WeChatWASM.WXUserInfoResponse self=(WeChatWASM.WXUserInfoResponse)checkSelf(l);
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
			WeChatWASM.WXUserInfoResponse self=(WeChatWASM.WXUserInfoResponse)checkSelf(l);
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
			WeChatWASM.WXUserInfoResponse self=(WeChatWASM.WXUserInfoResponse)checkSelf(l);
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
	static public int get_userInfo(IntPtr l) {
		try {
			WeChatWASM.WXUserInfoResponse self=(WeChatWASM.WXUserInfoResponse)checkSelf(l);
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
			WeChatWASM.WXUserInfoResponse self=(WeChatWASM.WXUserInfoResponse)checkSelf(l);
			WeChatWASM.WXUserInfo v;
			checkValueType(l,2,out v);
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
	static public int get_userInfoRaw(IntPtr l) {
		try {
			WeChatWASM.WXUserInfoResponse self=(WeChatWASM.WXUserInfoResponse)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.userInfoRaw);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_userInfoRaw(IntPtr l) {
		try {
			WeChatWASM.WXUserInfoResponse self=(WeChatWASM.WXUserInfoResponse)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.userInfoRaw=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXUserInfoResponse");
		addMember(l,"errCode",get_errCode,set_errCode,true);
		addMember(l,"signature",get_signature,set_signature,true);
		addMember(l,"encryptedData",get_encryptedData,set_encryptedData,true);
		addMember(l,"iv",get_iv,set_iv,true);
		addMember(l,"cloudID",get_cloudID,set_cloudID,true);
		addMember(l,"userInfo",get_userInfo,set_userInfo,true);
		addMember(l,"userInfoRaw",get_userInfoRaw,set_userInfoRaw,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXUserInfoResponse),typeof(WeChatWASM.WXBaseResponse));
	}
}
