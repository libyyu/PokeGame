//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_OnNetworkStatusChangeListenerResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.OnNetworkStatusChangeListenerResult o;
			o=new WeChatWASM.OnNetworkStatusChangeListenerResult();
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
	static public int get_isConnected(IntPtr l) {
		try {
			WeChatWASM.OnNetworkStatusChangeListenerResult self=(WeChatWASM.OnNetworkStatusChangeListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isConnected);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_isConnected(IntPtr l) {
		try {
			WeChatWASM.OnNetworkStatusChangeListenerResult self=(WeChatWASM.OnNetworkStatusChangeListenerResult)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.isConnected=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_networkType(IntPtr l) {
		try {
			WeChatWASM.OnNetworkStatusChangeListenerResult self=(WeChatWASM.OnNetworkStatusChangeListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.networkType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_networkType(IntPtr l) {
		try {
			WeChatWASM.OnNetworkStatusChangeListenerResult self=(WeChatWASM.OnNetworkStatusChangeListenerResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.networkType=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.OnNetworkStatusChangeListenerResult");
		addMember(l,"isConnected",get_isConnected,set_isConnected,true);
		addMember(l,"networkType",get_networkType,set_networkType,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.OnNetworkStatusChangeListenerResult));
	}
}
