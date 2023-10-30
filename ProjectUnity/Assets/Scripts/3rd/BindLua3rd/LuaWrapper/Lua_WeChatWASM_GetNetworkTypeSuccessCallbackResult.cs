//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_GetNetworkTypeSuccessCallbackResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.GetNetworkTypeSuccessCallbackResult o;
			o=new WeChatWASM.GetNetworkTypeSuccessCallbackResult();
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
	static public int get_hasSystemProxy(IntPtr l) {
		try {
			WeChatWASM.GetNetworkTypeSuccessCallbackResult self=(WeChatWASM.GetNetworkTypeSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.hasSystemProxy);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_hasSystemProxy(IntPtr l) {
		try {
			WeChatWASM.GetNetworkTypeSuccessCallbackResult self=(WeChatWASM.GetNetworkTypeSuccessCallbackResult)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.hasSystemProxy=v;
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
			WeChatWASM.GetNetworkTypeSuccessCallbackResult self=(WeChatWASM.GetNetworkTypeSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.GetNetworkTypeSuccessCallbackResult self=(WeChatWASM.GetNetworkTypeSuccessCallbackResult)checkSelf(l);
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
	static public int get_signalStrength(IntPtr l) {
		try {
			WeChatWASM.GetNetworkTypeSuccessCallbackResult self=(WeChatWASM.GetNetworkTypeSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.signalStrength);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_signalStrength(IntPtr l) {
		try {
			WeChatWASM.GetNetworkTypeSuccessCallbackResult self=(WeChatWASM.GetNetworkTypeSuccessCallbackResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.signalStrength=v;
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
			WeChatWASM.GetNetworkTypeSuccessCallbackResult self=(WeChatWASM.GetNetworkTypeSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.GetNetworkTypeSuccessCallbackResult self=(WeChatWASM.GetNetworkTypeSuccessCallbackResult)checkSelf(l);
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
		getTypeTable(l,"WeChatWASM.GetNetworkTypeSuccessCallbackResult");
		addMember(l,"hasSystemProxy",get_hasSystemProxy,set_hasSystemProxy,true);
		addMember(l,"networkType",get_networkType,set_networkType,true);
		addMember(l,"signalStrength",get_signalStrength,set_signalStrength,true);
		addMember(l,"errMsg",get_errMsg,set_errMsg,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.GetNetworkTypeSuccessCallbackResult));
	}
}
