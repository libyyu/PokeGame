//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_GetLocalIPAddressSuccessCallbackResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.GetLocalIPAddressSuccessCallbackResult o;
			o=new WeChatWASM.GetLocalIPAddressSuccessCallbackResult();
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
			WeChatWASM.GetLocalIPAddressSuccessCallbackResult self=(WeChatWASM.GetLocalIPAddressSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.GetLocalIPAddressSuccessCallbackResult self=(WeChatWASM.GetLocalIPAddressSuccessCallbackResult)checkSelf(l);
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
	static public int get_localip(IntPtr l) {
		try {
			WeChatWASM.GetLocalIPAddressSuccessCallbackResult self=(WeChatWASM.GetLocalIPAddressSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.localip);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_localip(IntPtr l) {
		try {
			WeChatWASM.GetLocalIPAddressSuccessCallbackResult self=(WeChatWASM.GetLocalIPAddressSuccessCallbackResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.localip=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_netmask(IntPtr l) {
		try {
			WeChatWASM.GetLocalIPAddressSuccessCallbackResult self=(WeChatWASM.GetLocalIPAddressSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.netmask);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_netmask(IntPtr l) {
		try {
			WeChatWASM.GetLocalIPAddressSuccessCallbackResult self=(WeChatWASM.GetLocalIPAddressSuccessCallbackResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.netmask=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.GetLocalIPAddressSuccessCallbackResult");
		addMember(l,"errMsg",get_errMsg,set_errMsg,true);
		addMember(l,"localip",get_localip,set_localip,true);
		addMember(l,"netmask",get_netmask,set_netmask,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.GetLocalIPAddressSuccessCallbackResult));
	}
}
