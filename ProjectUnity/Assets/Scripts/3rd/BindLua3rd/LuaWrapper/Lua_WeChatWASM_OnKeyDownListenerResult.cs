//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_OnKeyDownListenerResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.OnKeyDownListenerResult o;
			o=new WeChatWASM.OnKeyDownListenerResult();
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
	static public int get_code(IntPtr l) {
		try {
			WeChatWASM.OnKeyDownListenerResult self=(WeChatWASM.OnKeyDownListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.code);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_code(IntPtr l) {
		try {
			WeChatWASM.OnKeyDownListenerResult self=(WeChatWASM.OnKeyDownListenerResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.code=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_key(IntPtr l) {
		try {
			WeChatWASM.OnKeyDownListenerResult self=(WeChatWASM.OnKeyDownListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.key);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_key(IntPtr l) {
		try {
			WeChatWASM.OnKeyDownListenerResult self=(WeChatWASM.OnKeyDownListenerResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.key=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_timeStamp(IntPtr l) {
		try {
			WeChatWASM.OnKeyDownListenerResult self=(WeChatWASM.OnKeyDownListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.timeStamp);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_timeStamp(IntPtr l) {
		try {
			WeChatWASM.OnKeyDownListenerResult self=(WeChatWASM.OnKeyDownListenerResult)checkSelf(l);
			System.Int64 v;
			checkType(l,2,out v);
			self.timeStamp=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.OnKeyDownListenerResult");
		addMember(l,"code",get_code,set_code,true);
		addMember(l,"key",get_key,set_key,true);
		addMember(l,"timeStamp",get_timeStamp,set_timeStamp,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.OnKeyDownListenerResult));
	}
}
