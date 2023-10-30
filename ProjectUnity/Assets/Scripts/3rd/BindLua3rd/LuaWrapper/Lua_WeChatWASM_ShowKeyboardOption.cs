//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_ShowKeyboardOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.ShowKeyboardOption o;
			o=new WeChatWASM.ShowKeyboardOption();
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
	static public int get_confirmHold(IntPtr l) {
		try {
			WeChatWASM.ShowKeyboardOption self=(WeChatWASM.ShowKeyboardOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.confirmHold);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_confirmHold(IntPtr l) {
		try {
			WeChatWASM.ShowKeyboardOption self=(WeChatWASM.ShowKeyboardOption)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.confirmHold=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_confirmType(IntPtr l) {
		try {
			WeChatWASM.ShowKeyboardOption self=(WeChatWASM.ShowKeyboardOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.confirmType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_confirmType(IntPtr l) {
		try {
			WeChatWASM.ShowKeyboardOption self=(WeChatWASM.ShowKeyboardOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.confirmType=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_defaultValue(IntPtr l) {
		try {
			WeChatWASM.ShowKeyboardOption self=(WeChatWASM.ShowKeyboardOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.defaultValue);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_defaultValue(IntPtr l) {
		try {
			WeChatWASM.ShowKeyboardOption self=(WeChatWASM.ShowKeyboardOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.defaultValue=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_maxLength(IntPtr l) {
		try {
			WeChatWASM.ShowKeyboardOption self=(WeChatWASM.ShowKeyboardOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.maxLength);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_maxLength(IntPtr l) {
		try {
			WeChatWASM.ShowKeyboardOption self=(WeChatWASM.ShowKeyboardOption)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.maxLength=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_multiple(IntPtr l) {
		try {
			WeChatWASM.ShowKeyboardOption self=(WeChatWASM.ShowKeyboardOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.multiple);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_multiple(IntPtr l) {
		try {
			WeChatWASM.ShowKeyboardOption self=(WeChatWASM.ShowKeyboardOption)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.multiple=v;
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
			WeChatWASM.ShowKeyboardOption self=(WeChatWASM.ShowKeyboardOption)checkSelf(l);
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
			WeChatWASM.ShowKeyboardOption self=(WeChatWASM.ShowKeyboardOption)checkSelf(l);
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
	static public int set_success(IntPtr l) {
		try {
			WeChatWASM.ShowKeyboardOption self=(WeChatWASM.ShowKeyboardOption)checkSelf(l);
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
		getTypeTable(l,"WeChatWASM.ShowKeyboardOption");
		addMember(l,"confirmHold",get_confirmHold,set_confirmHold,true);
		addMember(l,"confirmType",get_confirmType,set_confirmType,true);
		addMember(l,"defaultValue",get_defaultValue,set_defaultValue,true);
		addMember(l,"maxLength",get_maxLength,set_maxLength,true);
		addMember(l,"multiple",get_multiple,set_multiple,true);
		addMember(l,"complete",null,set_complete,true);
		addMember(l,"fail",null,set_fail,true);
		addMember(l,"success",null,set_success,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.ShowKeyboardOption));
	}
}
