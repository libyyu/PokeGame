//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXDownloadTask : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXDownloadTask o;
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			WeChatWASM.DownloadFileOption a2 = default(WeChatWASM.DownloadFileOption);
			checkType(l,3,out a2);
			o=new WeChatWASM.WXDownloadTask(a1,a2);
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
	static public int Abort(IntPtr l) {
		try {
			WeChatWASM.WXDownloadTask self=(WeChatWASM.WXDownloadTask)checkSelf(l);
			self.Abort();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffHeadersReceived(IntPtr l) {
		try {
			WeChatWASM.WXDownloadTask self=(WeChatWASM.WXDownloadTask)checkSelf(l);
			self.OffHeadersReceived();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffProgressUpdate(IntPtr l) {
		try {
			WeChatWASM.WXDownloadTask self=(WeChatWASM.WXDownloadTask)checkSelf(l);
			self.OffProgressUpdate();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnHeadersReceived(IntPtr l) {
		try {
			WeChatWASM.WXDownloadTask self=(WeChatWASM.WXDownloadTask)checkSelf(l);
			System.Action<WeChatWASM.OnHeadersReceivedListenerResult> a1 = default(System.Action<WeChatWASM.OnHeadersReceivedListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnHeadersReceived(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnProgressUpdate(IntPtr l) {
		try {
			WeChatWASM.WXDownloadTask self=(WeChatWASM.WXDownloadTask)checkSelf(l);
			System.Action<WeChatWASM.DownloadTaskOnProgressUpdateListenerResult> a1 = default(System.Action<WeChatWASM.DownloadTaskOnProgressUpdateListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnProgressUpdate(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_OnHeadersReceivedActionList(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,WeChatWASM.WXDownloadTask.OnHeadersReceivedActionList);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_OnHeadersReceivedActionList(IntPtr l) {
		try {
			System.Collections.Generic.Dictionary<System.String,System.Action<WeChatWASM.OnHeadersReceivedListenerResult>> v;
			checkType(l,2,out v);
			WeChatWASM.WXDownloadTask.OnHeadersReceivedActionList=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_OnProgressUpdateActionList(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,WeChatWASM.WXDownloadTask.OnProgressUpdateActionList);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_OnProgressUpdateActionList(IntPtr l) {
		try {
			System.Collections.Generic.Dictionary<System.String,System.Action<WeChatWASM.DownloadTaskOnProgressUpdateListenerResult>> v;
			checkType(l,2,out v);
			WeChatWASM.WXDownloadTask.OnProgressUpdateActionList=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXDownloadTask");
		addMember(l,Abort);
		addMember(l,OffHeadersReceived);
		addMember(l,OffProgressUpdate);
		addMember(l,OnHeadersReceived);
		addMember(l,OnProgressUpdate);
		addMember(l,"OnHeadersReceivedActionList",get_OnHeadersReceivedActionList,set_OnHeadersReceivedActionList,false);
		addMember(l,"OnProgressUpdateActionList",get_OnProgressUpdateActionList,set_OnProgressUpdateActionList,false);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXDownloadTask));
	}
}
