//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_RequestFailCallbackErr : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.RequestFailCallbackErr o;
			o=new WeChatWASM.RequestFailCallbackErr();
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
	static public int get_errMsg(IntPtr l) {
		try {
			WeChatWASM.RequestFailCallbackErr self=(WeChatWASM.RequestFailCallbackErr)checkSelf(l);
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
			WeChatWASM.RequestFailCallbackErr self=(WeChatWASM.RequestFailCallbackErr)checkSelf(l);
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_errno(IntPtr l) {
		try {
			WeChatWASM.RequestFailCallbackErr self=(WeChatWASM.RequestFailCallbackErr)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.errno);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_errno(IntPtr l) {
		try {
			WeChatWASM.RequestFailCallbackErr self=(WeChatWASM.RequestFailCallbackErr)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.errno=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.RequestFailCallbackErr");
		addMember(l,"errMsg",get_errMsg,set_errMsg,true);
		addMember(l,"errno",get_errno,set_errno,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.RequestFailCallbackErr));
	}
}
