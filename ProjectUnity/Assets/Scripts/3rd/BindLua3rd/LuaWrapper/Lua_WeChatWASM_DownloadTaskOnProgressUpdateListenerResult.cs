//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_DownloadTaskOnProgressUpdateListenerResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.DownloadTaskOnProgressUpdateListenerResult o;
			o=new WeChatWASM.DownloadTaskOnProgressUpdateListenerResult();
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
			WeChatWASM.DownloadTaskOnProgressUpdateListenerResult self=(WeChatWASM.DownloadTaskOnProgressUpdateListenerResult)checkSelf(l);
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
			WeChatWASM.DownloadTaskOnProgressUpdateListenerResult self=(WeChatWASM.DownloadTaskOnProgressUpdateListenerResult)checkSelf(l);
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
	static public int get_totalBytesExpectedToWrite(IntPtr l) {
		try {
			WeChatWASM.DownloadTaskOnProgressUpdateListenerResult self=(WeChatWASM.DownloadTaskOnProgressUpdateListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.totalBytesExpectedToWrite);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_totalBytesExpectedToWrite(IntPtr l) {
		try {
			WeChatWASM.DownloadTaskOnProgressUpdateListenerResult self=(WeChatWASM.DownloadTaskOnProgressUpdateListenerResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.totalBytesExpectedToWrite=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_totalBytesWritten(IntPtr l) {
		try {
			WeChatWASM.DownloadTaskOnProgressUpdateListenerResult self=(WeChatWASM.DownloadTaskOnProgressUpdateListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.totalBytesWritten);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_totalBytesWritten(IntPtr l) {
		try {
			WeChatWASM.DownloadTaskOnProgressUpdateListenerResult self=(WeChatWASM.DownloadTaskOnProgressUpdateListenerResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.totalBytesWritten=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.DownloadTaskOnProgressUpdateListenerResult");
		addMember(l,"progress",get_progress,set_progress,true);
		addMember(l,"totalBytesExpectedToWrite",get_totalBytesExpectedToWrite,set_totalBytesExpectedToWrite,true);
		addMember(l,"totalBytesWritten",get_totalBytesWritten,set_totalBytesWritten,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.DownloadTaskOnProgressUpdateListenerResult));
	}
}
