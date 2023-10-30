//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_OnShareMessageToFriendListenerResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.OnShareMessageToFriendListenerResult o;
			o=new WeChatWASM.OnShareMessageToFriendListenerResult();
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
			WeChatWASM.OnShareMessageToFriendListenerResult self=(WeChatWASM.OnShareMessageToFriendListenerResult)checkSelf(l);
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
			WeChatWASM.OnShareMessageToFriendListenerResult self=(WeChatWASM.OnShareMessageToFriendListenerResult)checkSelf(l);
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
	static public int get_success(IntPtr l) {
		try {
			WeChatWASM.OnShareMessageToFriendListenerResult self=(WeChatWASM.OnShareMessageToFriendListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.success);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_success(IntPtr l) {
		try {
			WeChatWASM.OnShareMessageToFriendListenerResult self=(WeChatWASM.OnShareMessageToFriendListenerResult)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.success=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.OnShareMessageToFriendListenerResult");
		addMember(l,"errMsg",get_errMsg,set_errMsg,true);
		addMember(l,"success",get_success,set_success,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.OnShareMessageToFriendListenerResult));
	}
}
