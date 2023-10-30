//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_PreviewImageOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.PreviewImageOption o;
			o=new WeChatWASM.PreviewImageOption();
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
	static public int get_urls(IntPtr l) {
		try {
			WeChatWASM.PreviewImageOption self=(WeChatWASM.PreviewImageOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.urls);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_urls(IntPtr l) {
		try {
			WeChatWASM.PreviewImageOption self=(WeChatWASM.PreviewImageOption)checkSelf(l);
			System.String[] v;
			checkArray(l,2,out v);
			self.urls=v;
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
			WeChatWASM.PreviewImageOption self=(WeChatWASM.PreviewImageOption)checkSelf(l);
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
	static public int get_current(IntPtr l) {
		try {
			WeChatWASM.PreviewImageOption self=(WeChatWASM.PreviewImageOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.current);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_current(IntPtr l) {
		try {
			WeChatWASM.PreviewImageOption self=(WeChatWASM.PreviewImageOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.current=v;
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
			WeChatWASM.PreviewImageOption self=(WeChatWASM.PreviewImageOption)checkSelf(l);
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
	static public int get_referrerPolicy(IntPtr l) {
		try {
			WeChatWASM.PreviewImageOption self=(WeChatWASM.PreviewImageOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.referrerPolicy);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_referrerPolicy(IntPtr l) {
		try {
			WeChatWASM.PreviewImageOption self=(WeChatWASM.PreviewImageOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.referrerPolicy=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_showmenu(IntPtr l) {
		try {
			WeChatWASM.PreviewImageOption self=(WeChatWASM.PreviewImageOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.showmenu);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_showmenu(IntPtr l) {
		try {
			WeChatWASM.PreviewImageOption self=(WeChatWASM.PreviewImageOption)checkSelf(l);
			System.Nullable<System.Boolean> v;
			checkNullable(l,2,out v);
			self.showmenu=v;
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
			WeChatWASM.PreviewImageOption self=(WeChatWASM.PreviewImageOption)checkSelf(l);
			System.Action<WeChatWASM.GeneralCallbackResult> v;
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
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.PreviewImageOption");
		addMember(l,"urls",get_urls,set_urls,true);
		addMember(l,"complete",null,set_complete,true);
		addMember(l,"current",get_current,set_current,true);
		addMember(l,"fail",null,set_fail,true);
		addMember(l,"referrerPolicy",get_referrerPolicy,set_referrerPolicy,true);
		addMember(l,"showmenu",get_showmenu,set_showmenu,true);
		addMember(l,"success",null,set_success,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.PreviewImageOption));
	}
}
