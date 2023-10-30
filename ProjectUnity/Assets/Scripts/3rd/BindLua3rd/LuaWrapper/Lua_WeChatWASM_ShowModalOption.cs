//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_ShowModalOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.ShowModalOption o;
			o=new WeChatWASM.ShowModalOption();
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
	static public int get_cancelColor(IntPtr l) {
		try {
			WeChatWASM.ShowModalOption self=(WeChatWASM.ShowModalOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.cancelColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_cancelColor(IntPtr l) {
		try {
			WeChatWASM.ShowModalOption self=(WeChatWASM.ShowModalOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.cancelColor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_cancelText(IntPtr l) {
		try {
			WeChatWASM.ShowModalOption self=(WeChatWASM.ShowModalOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.cancelText);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_cancelText(IntPtr l) {
		try {
			WeChatWASM.ShowModalOption self=(WeChatWASM.ShowModalOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.cancelText=v;
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
			WeChatWASM.ShowModalOption self=(WeChatWASM.ShowModalOption)checkSelf(l);
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
	static public int get_confirmColor(IntPtr l) {
		try {
			WeChatWASM.ShowModalOption self=(WeChatWASM.ShowModalOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.confirmColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_confirmColor(IntPtr l) {
		try {
			WeChatWASM.ShowModalOption self=(WeChatWASM.ShowModalOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.confirmColor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_confirmText(IntPtr l) {
		try {
			WeChatWASM.ShowModalOption self=(WeChatWASM.ShowModalOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.confirmText);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_confirmText(IntPtr l) {
		try {
			WeChatWASM.ShowModalOption self=(WeChatWASM.ShowModalOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.confirmText=v;
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
			WeChatWASM.ShowModalOption self=(WeChatWASM.ShowModalOption)checkSelf(l);
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
			WeChatWASM.ShowModalOption self=(WeChatWASM.ShowModalOption)checkSelf(l);
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
	static public int get_editable(IntPtr l) {
		try {
			WeChatWASM.ShowModalOption self=(WeChatWASM.ShowModalOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.editable);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_editable(IntPtr l) {
		try {
			WeChatWASM.ShowModalOption self=(WeChatWASM.ShowModalOption)checkSelf(l);
			System.Nullable<System.Boolean> v;
			checkNullable(l,2,out v);
			self.editable=v;
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
			WeChatWASM.ShowModalOption self=(WeChatWASM.ShowModalOption)checkSelf(l);
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
	static public int get_placeholderText(IntPtr l) {
		try {
			WeChatWASM.ShowModalOption self=(WeChatWASM.ShowModalOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.placeholderText);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_placeholderText(IntPtr l) {
		try {
			WeChatWASM.ShowModalOption self=(WeChatWASM.ShowModalOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.placeholderText=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_showCancel(IntPtr l) {
		try {
			WeChatWASM.ShowModalOption self=(WeChatWASM.ShowModalOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.showCancel);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_showCancel(IntPtr l) {
		try {
			WeChatWASM.ShowModalOption self=(WeChatWASM.ShowModalOption)checkSelf(l);
			System.Nullable<System.Boolean> v;
			checkNullable(l,2,out v);
			self.showCancel=v;
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
			WeChatWASM.ShowModalOption self=(WeChatWASM.ShowModalOption)checkSelf(l);
			System.Action<WeChatWASM.ShowModalSuccessCallbackResult> v;
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
	static public int get_title(IntPtr l) {
		try {
			WeChatWASM.ShowModalOption self=(WeChatWASM.ShowModalOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.title);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_title(IntPtr l) {
		try {
			WeChatWASM.ShowModalOption self=(WeChatWASM.ShowModalOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.title=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.ShowModalOption");
		addMember(l,"cancelColor",get_cancelColor,set_cancelColor,true);
		addMember(l,"cancelText",get_cancelText,set_cancelText,true);
		addMember(l,"complete",null,set_complete,true);
		addMember(l,"confirmColor",get_confirmColor,set_confirmColor,true);
		addMember(l,"confirmText",get_confirmText,set_confirmText,true);
		addMember(l,"content",get_content,set_content,true);
		addMember(l,"editable",get_editable,set_editable,true);
		addMember(l,"fail",null,set_fail,true);
		addMember(l,"placeholderText",get_placeholderText,set_placeholderText,true);
		addMember(l,"showCancel",get_showCancel,set_showCancel,true);
		addMember(l,"success",null,set_success,true);
		addMember(l,"title",get_title,set_title,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.ShowModalOption));
	}
}
