//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_UploadTaskOnProgressUpdateCallbackResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.UploadTaskOnProgressUpdateCallbackResult o;
			o=new WeChatWASM.UploadTaskOnProgressUpdateCallbackResult();
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
	static public int get_progress(IntPtr l) {
		try {
			WeChatWASM.UploadTaskOnProgressUpdateCallbackResult self=(WeChatWASM.UploadTaskOnProgressUpdateCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.progress);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_progress(IntPtr l) {
		try {
			WeChatWASM.UploadTaskOnProgressUpdateCallbackResult self=(WeChatWASM.UploadTaskOnProgressUpdateCallbackResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.progress=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_totalBytesExpectedToSend(IntPtr l) {
		try {
			WeChatWASM.UploadTaskOnProgressUpdateCallbackResult self=(WeChatWASM.UploadTaskOnProgressUpdateCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.totalBytesExpectedToSend);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_totalBytesExpectedToSend(IntPtr l) {
		try {
			WeChatWASM.UploadTaskOnProgressUpdateCallbackResult self=(WeChatWASM.UploadTaskOnProgressUpdateCallbackResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.totalBytesExpectedToSend=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_totalBytesSent(IntPtr l) {
		try {
			WeChatWASM.UploadTaskOnProgressUpdateCallbackResult self=(WeChatWASM.UploadTaskOnProgressUpdateCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.totalBytesSent);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_totalBytesSent(IntPtr l) {
		try {
			WeChatWASM.UploadTaskOnProgressUpdateCallbackResult self=(WeChatWASM.UploadTaskOnProgressUpdateCallbackResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.totalBytesSent=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.UploadTaskOnProgressUpdateCallbackResult");
		addMember(l,"progress",get_progress,set_progress,true);
		addMember(l,"totalBytesExpectedToSend",get_totalBytesExpectedToSend,set_totalBytesExpectedToSend,true);
		addMember(l,"totalBytesSent",get_totalBytesSent,set_totalBytesSent,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.UploadTaskOnProgressUpdateCallbackResult));
	}
}
