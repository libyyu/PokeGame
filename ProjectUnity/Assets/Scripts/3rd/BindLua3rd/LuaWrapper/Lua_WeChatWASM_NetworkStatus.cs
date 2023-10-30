//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_NetworkStatus : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.NetworkStatus o;
			o=new WeChatWASM.NetworkStatus();
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
			WeChatWASM.NetworkStatus self=(WeChatWASM.NetworkStatus)checkSelf(l);
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
			WeChatWASM.NetworkStatus self=(WeChatWASM.NetworkStatus)checkSelf(l);
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
			WeChatWASM.NetworkStatus self=(WeChatWASM.NetworkStatus)checkSelf(l);
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
			WeChatWASM.NetworkStatus self=(WeChatWASM.NetworkStatus)checkSelf(l);
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
		getTypeTable(l,"WeChatWASM.NetworkStatus");
		addMember(l,"isConnected",get_isConnected,set_isConnected,true);
		addMember(l,"networkType",get_networkType,set_networkType,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.NetworkStatus));
	}
}
