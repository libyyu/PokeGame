//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_AuthPrivateMessageSuccessCallbackResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.AuthPrivateMessageSuccessCallbackResult o;
			o=new WeChatWASM.AuthPrivateMessageSuccessCallbackResult();
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
			WeChatWASM.AuthPrivateMessageSuccessCallbackResult self=(WeChatWASM.AuthPrivateMessageSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.AuthPrivateMessageSuccessCallbackResult self=(WeChatWASM.AuthPrivateMessageSuccessCallbackResult)checkSelf(l);
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
	static public int get_errMsg(IntPtr l) {
		try {
			WeChatWASM.AuthPrivateMessageSuccessCallbackResult self=(WeChatWASM.AuthPrivateMessageSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.AuthPrivateMessageSuccessCallbackResult self=(WeChatWASM.AuthPrivateMessageSuccessCallbackResult)checkSelf(l);
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_iv(IntPtr l) {
		try {
			WeChatWASM.AuthPrivateMessageSuccessCallbackResult self=(WeChatWASM.AuthPrivateMessageSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.AuthPrivateMessageSuccessCallbackResult self=(WeChatWASM.AuthPrivateMessageSuccessCallbackResult)checkSelf(l);
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
	static public int get_valid(IntPtr l) {
		try {
			WeChatWASM.AuthPrivateMessageSuccessCallbackResult self=(WeChatWASM.AuthPrivateMessageSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.valid);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_valid(IntPtr l) {
		try {
			WeChatWASM.AuthPrivateMessageSuccessCallbackResult self=(WeChatWASM.AuthPrivateMessageSuccessCallbackResult)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.valid=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.AuthPrivateMessageSuccessCallbackResult");
		addMember(l,"encryptedData",get_encryptedData,set_encryptedData,true);
		addMember(l,"errMsg",get_errMsg,set_errMsg,true);
		addMember(l,"iv",get_iv,set_iv,true);
		addMember(l,"valid",get_valid,set_valid,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.AuthPrivateMessageSuccessCallbackResult));
	}
}
