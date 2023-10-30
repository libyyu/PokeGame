//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_DownloadFileOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.DownloadFileOption o;
			o=new WeChatWASM.DownloadFileOption();
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
	static public int get_url(IntPtr l) {
		try {
			WeChatWASM.DownloadFileOption self=(WeChatWASM.DownloadFileOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.url);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_url(IntPtr l) {
		try {
			WeChatWASM.DownloadFileOption self=(WeChatWASM.DownloadFileOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.url=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_complete(IntPtr l) {
		try {
			WeChatWASM.DownloadFileOption self=(WeChatWASM.DownloadFileOption)checkSelf(l);
			System.Action<WeChatWASM.GeneralCallbackResult> v;
			int op=checkDelegate(l,2,out v);
			if(op==0) self.complete=v;
			else if(op==1) self.complete+=v;
			else if(op==2) self.complete-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_fail(IntPtr l) {
		try {
			WeChatWASM.DownloadFileOption self=(WeChatWASM.DownloadFileOption)checkSelf(l);
			System.Action<WeChatWASM.GeneralCallbackResult> v;
			int op=checkDelegate(l,2,out v);
			if(op==0) self.fail=v;
			else if(op==1) self.fail+=v;
			else if(op==2) self.fail-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_filePath(IntPtr l) {
		try {
			WeChatWASM.DownloadFileOption self=(WeChatWASM.DownloadFileOption)checkSelf(l);
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
			WeChatWASM.DownloadFileOption self=(WeChatWASM.DownloadFileOption)checkSelf(l);
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
	static public int get_header(IntPtr l) {
		try {
			WeChatWASM.DownloadFileOption self=(WeChatWASM.DownloadFileOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.header);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_header(IntPtr l) {
		try {
			WeChatWASM.DownloadFileOption self=(WeChatWASM.DownloadFileOption)checkSelf(l);
			System.Collections.Generic.Dictionary<System.String,System.String> v;
			checkType(l,2,out v);
			self.header=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_success(IntPtr l) {
		try {
			WeChatWASM.DownloadFileOption self=(WeChatWASM.DownloadFileOption)checkSelf(l);
			System.Action<WeChatWASM.DownloadFileSuccessCallbackResult> v;
			int op=checkDelegate(l,2,out v);
			if(op==0) self.success=v;
			else if(op==1) self.success+=v;
			else if(op==2) self.success-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_timeout(IntPtr l) {
		try {
			WeChatWASM.DownloadFileOption self=(WeChatWASM.DownloadFileOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.timeout);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_timeout(IntPtr l) {
		try {
			WeChatWASM.DownloadFileOption self=(WeChatWASM.DownloadFileOption)checkSelf(l);
			System.Nullable<System.Double> v;
			checkNullable(l,2,out v);
			self.timeout=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.DownloadFileOption");
		addMember(l,"url",get_url,set_url,true);
		addMember(l,"complete",null,set_complete,true);
		addMember(l,"fail",null,set_fail,true);
		addMember(l,"filePath",get_filePath,set_filePath,true);
		addMember(l,"header",get_header,set_header,true);
		addMember(l,"success",null,set_success,true);
		addMember(l,"timeout",get_timeout,set_timeout,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.DownloadFileOption));
	}
}
