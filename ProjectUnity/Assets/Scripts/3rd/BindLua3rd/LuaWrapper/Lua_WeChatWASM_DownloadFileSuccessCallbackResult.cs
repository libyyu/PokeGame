//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_DownloadFileSuccessCallbackResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.DownloadFileSuccessCallbackResult o;
			o=new WeChatWASM.DownloadFileSuccessCallbackResult();
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
	static public int get_filePath(IntPtr l) {
		try {
			WeChatWASM.DownloadFileSuccessCallbackResult self=(WeChatWASM.DownloadFileSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.filePath);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_filePath(IntPtr l) {
		try {
			WeChatWASM.DownloadFileSuccessCallbackResult self=(WeChatWASM.DownloadFileSuccessCallbackResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.filePath=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_profile(IntPtr l) {
		try {
			WeChatWASM.DownloadFileSuccessCallbackResult self=(WeChatWASM.DownloadFileSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.profile);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_profile(IntPtr l) {
		try {
			WeChatWASM.DownloadFileSuccessCallbackResult self=(WeChatWASM.DownloadFileSuccessCallbackResult)checkSelf(l);
			WeChatWASM.RequestProfile v;
			checkType(l,2,out v);
			self.profile=v;
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
			WeChatWASM.DownloadFileSuccessCallbackResult self=(WeChatWASM.DownloadFileSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.DownloadFileSuccessCallbackResult self=(WeChatWASM.DownloadFileSuccessCallbackResult)checkSelf(l);
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
	static public int get_tempFilePath(IntPtr l) {
		try {
			WeChatWASM.DownloadFileSuccessCallbackResult self=(WeChatWASM.DownloadFileSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.tempFilePath);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_tempFilePath(IntPtr l) {
		try {
			WeChatWASM.DownloadFileSuccessCallbackResult self=(WeChatWASM.DownloadFileSuccessCallbackResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.tempFilePath=v;
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
			WeChatWASM.DownloadFileSuccessCallbackResult self=(WeChatWASM.DownloadFileSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.DownloadFileSuccessCallbackResult self=(WeChatWASM.DownloadFileSuccessCallbackResult)checkSelf(l);
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
		getTypeTable(l,"WeChatWASM.DownloadFileSuccessCallbackResult");
		addMember(l,"filePath",get_filePath,set_filePath,true);
		addMember(l,"profile",get_profile,set_profile,true);
		addMember(l,"statusCode",get_statusCode,set_statusCode,true);
		addMember(l,"tempFilePath",get_tempFilePath,set_tempFilePath,true);
		addMember(l,"errMsg",get_errMsg,set_errMsg,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.DownloadFileSuccessCallbackResult));
	}
}
