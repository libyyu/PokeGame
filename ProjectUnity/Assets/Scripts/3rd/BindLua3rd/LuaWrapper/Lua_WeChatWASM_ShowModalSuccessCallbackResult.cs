//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_ShowModalSuccessCallbackResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.ShowModalSuccessCallbackResult o;
			o=new WeChatWASM.ShowModalSuccessCallbackResult();
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
	static public int get_cancel(IntPtr l) {
		try {
			WeChatWASM.ShowModalSuccessCallbackResult self=(WeChatWASM.ShowModalSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.cancel);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_cancel(IntPtr l) {
		try {
			WeChatWASM.ShowModalSuccessCallbackResult self=(WeChatWASM.ShowModalSuccessCallbackResult)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.cancel=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_confirm(IntPtr l) {
		try {
			WeChatWASM.ShowModalSuccessCallbackResult self=(WeChatWASM.ShowModalSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.confirm);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_confirm(IntPtr l) {
		try {
			WeChatWASM.ShowModalSuccessCallbackResult self=(WeChatWASM.ShowModalSuccessCallbackResult)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.confirm=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_content(IntPtr l) {
		try {
			WeChatWASM.ShowModalSuccessCallbackResult self=(WeChatWASM.ShowModalSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.content);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_content(IntPtr l) {
		try {
			WeChatWASM.ShowModalSuccessCallbackResult self=(WeChatWASM.ShowModalSuccessCallbackResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.content=v;
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
			WeChatWASM.ShowModalSuccessCallbackResult self=(WeChatWASM.ShowModalSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.ShowModalSuccessCallbackResult self=(WeChatWASM.ShowModalSuccessCallbackResult)checkSelf(l);
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
		getTypeTable(l,"WeChatWASM.ShowModalSuccessCallbackResult");
		addMember(l,"cancel",get_cancel,set_cancel,true);
		addMember(l,"confirm",get_confirm,set_confirm,true);
		addMember(l,"content",get_content,set_content,true);
		addMember(l,"errMsg",get_errMsg,set_errMsg,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.ShowModalSuccessCallbackResult));
	}
}
