﻿//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_UploadFileSuccessCallbackResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.UploadFileSuccessCallbackResult o;
			o=new WeChatWASM.UploadFileSuccessCallbackResult();
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
	static public int get_data(IntPtr l) {
		try {
			WeChatWASM.UploadFileSuccessCallbackResult self=(WeChatWASM.UploadFileSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.data);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_data(IntPtr l) {
		try {
			WeChatWASM.UploadFileSuccessCallbackResult self=(WeChatWASM.UploadFileSuccessCallbackResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.data=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_statusCode(IntPtr l) {
		try {
			WeChatWASM.UploadFileSuccessCallbackResult self=(WeChatWASM.UploadFileSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.statusCode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_statusCode(IntPtr l) {
		try {
			WeChatWASM.UploadFileSuccessCallbackResult self=(WeChatWASM.UploadFileSuccessCallbackResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.statusCode=v;
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
			WeChatWASM.UploadFileSuccessCallbackResult self=(WeChatWASM.UploadFileSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.UploadFileSuccessCallbackResult self=(WeChatWASM.UploadFileSuccessCallbackResult)checkSelf(l);
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
		getTypeTable(l,"WeChatWASM.UploadFileSuccessCallbackResult");
		addMember(l,"data",get_data,set_data,true);
		addMember(l,"statusCode",get_statusCode,set_statusCode,true);
		addMember(l,"errMsg",get_errMsg,set_errMsg,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.UploadFileSuccessCallbackResult));
	}
}