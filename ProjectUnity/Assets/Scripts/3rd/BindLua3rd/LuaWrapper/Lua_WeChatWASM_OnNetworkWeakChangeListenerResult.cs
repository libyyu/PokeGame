//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_OnNetworkWeakChangeListenerResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.OnNetworkWeakChangeListenerResult o;
			o=new WeChatWASM.OnNetworkWeakChangeListenerResult();
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
	static public int get_networkType(IntPtr l) {
		try {
			WeChatWASM.OnNetworkWeakChangeListenerResult self=(WeChatWASM.OnNetworkWeakChangeListenerResult)checkSelf(l);
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
			WeChatWASM.OnNetworkWeakChangeListenerResult self=(WeChatWASM.OnNetworkWeakChangeListenerResult)checkSelf(l);
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_weakNet(IntPtr l) {
		try {
			WeChatWASM.OnNetworkWeakChangeListenerResult self=(WeChatWASM.OnNetworkWeakChangeListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.weakNet);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_weakNet(IntPtr l) {
		try {
			WeChatWASM.OnNetworkWeakChangeListenerResult self=(WeChatWASM.OnNetworkWeakChangeListenerResult)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.weakNet=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.OnNetworkWeakChangeListenerResult");
		addMember(l,"networkType",get_networkType,set_networkType,true);
		addMember(l,"weakNet",get_weakNet,set_weakNet,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.OnNetworkWeakChangeListenerResult));
	}
}
