//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_SetBLEMTUSuccessCallbackResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.SetBLEMTUSuccessCallbackResult o;
			o=new WeChatWASM.SetBLEMTUSuccessCallbackResult();
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
	static public int get_mtu(IntPtr l) {
		try {
			WeChatWASM.SetBLEMTUSuccessCallbackResult self=(WeChatWASM.SetBLEMTUSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.mtu);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_mtu(IntPtr l) {
		try {
			WeChatWASM.SetBLEMTUSuccessCallbackResult self=(WeChatWASM.SetBLEMTUSuccessCallbackResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.mtu=v;
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
			WeChatWASM.SetBLEMTUSuccessCallbackResult self=(WeChatWASM.SetBLEMTUSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.SetBLEMTUSuccessCallbackResult self=(WeChatWASM.SetBLEMTUSuccessCallbackResult)checkSelf(l);
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
		getTypeTable(l,"WeChatWASM.SetBLEMTUSuccessCallbackResult");
		addMember(l,"mtu",get_mtu,set_mtu,true);
		addMember(l,"errMsg",get_errMsg,set_errMsg,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.SetBLEMTUSuccessCallbackResult));
	}
}
