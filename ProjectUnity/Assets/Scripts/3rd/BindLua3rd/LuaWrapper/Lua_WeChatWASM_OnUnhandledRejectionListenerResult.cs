//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_OnUnhandledRejectionListenerResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.OnUnhandledRejectionListenerResult o;
			o=new WeChatWASM.OnUnhandledRejectionListenerResult();
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
	static public int get_reason(IntPtr l) {
		try {
			WeChatWASM.OnUnhandledRejectionListenerResult self=(WeChatWASM.OnUnhandledRejectionListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.reason);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_reason(IntPtr l) {
		try {
			WeChatWASM.OnUnhandledRejectionListenerResult self=(WeChatWASM.OnUnhandledRejectionListenerResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.reason=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.OnUnhandledRejectionListenerResult");
		addMember(l,"reason",get_reason,set_reason,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.OnUnhandledRejectionListenerResult));
	}
}
