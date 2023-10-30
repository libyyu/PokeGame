//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXUploadTask : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXUploadTask o;
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			o=new WeChatWASM.WXUploadTask(a1);
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
			WeChatWASM.WXUploadTask self=(WeChatWASM.WXUploadTask)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.Abort(a1);
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
			WeChatWASM.WXUploadTask self=(WeChatWASM.WXUploadTask)checkSelf(l);
			System.Action<WeChatWASM.OnHeadersReceivedCallbackResult> a1 = default(System.Action<WeChatWASM.OnHeadersReceivedCallbackResult>);
			checkDelegate(l,2,out a1);
			self.OffHeadersReceived(a1);
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
			WeChatWASM.WXUploadTask self=(WeChatWASM.WXUploadTask)checkSelf(l);
			System.Action<WeChatWASM.UploadTaskOnProgressUpdateCallbackResult> a1 = default(System.Action<WeChatWASM.UploadTaskOnProgressUpdateCallbackResult>);
			checkDelegate(l,2,out a1);
			self.OffProgressUpdate(a1);
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
			WeChatWASM.WXUploadTask self=(WeChatWASM.WXUploadTask)checkSelf(l);
			System.Action<WeChatWASM.OnHeadersReceivedCallbackResult> a1 = default(System.Action<WeChatWASM.OnHeadersReceivedCallbackResult>);
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
			WeChatWASM.WXUploadTask self=(WeChatWASM.WXUploadTask)checkSelf(l);
			System.Action<WeChatWASM.UploadTaskOnProgressUpdateCallbackResult> a1 = default(System.Action<WeChatWASM.UploadTaskOnProgressUpdateCallbackResult>);
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
			pushValue(l,WeChatWASM.WXUploadTask.OnHeadersReceivedActionList);
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
			System.Collections.Generic.Dictionary<System.String,System.Action<WeChatWASM.OnHeadersReceivedCallbackResult>> v;
			checkType(l,2,out v);
			WeChatWASM.WXUploadTask.OnHeadersReceivedActionList=v;
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
			pushValue(l,WeChatWASM.WXUploadTask.OnProgressUpdateActionList);
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
			System.Collections.Generic.Dictionary<System.String,System.Action<WeChatWASM.UploadTaskOnProgressUpdateCallbackResult>> v;
			checkType(l,2,out v);
			WeChatWASM.WXUploadTask.OnProgressUpdateActionList=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXUploadTask");
		addMember(l,Abort);
		addMember(l,OffHeadersReceived);
		addMember(l,OffProgressUpdate);
		addMember(l,OnHeadersReceived);
		addMember(l,OnProgressUpdate);
		addMember(l,"OnHeadersReceivedActionList",get_OnHeadersReceivedActionList,set_OnHeadersReceivedActionList,false);
		addMember(l,"OnProgressUpdateActionList",get_OnProgressUpdateActionList,set_OnProgressUpdateActionList,false);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXUploadTask));
	}
}
