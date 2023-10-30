//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_GetBLEDeviceServicesSuccessCallbackResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.GetBLEDeviceServicesSuccessCallbackResult o;
			o=new WeChatWASM.GetBLEDeviceServicesSuccessCallbackResult();
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
	static public int get_services(IntPtr l) {
		try {
			WeChatWASM.GetBLEDeviceServicesSuccessCallbackResult self=(WeChatWASM.GetBLEDeviceServicesSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.services);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_services(IntPtr l) {
		try {
			WeChatWASM.GetBLEDeviceServicesSuccessCallbackResult self=(WeChatWASM.GetBLEDeviceServicesSuccessCallbackResult)checkSelf(l);
			WeChatWASM.BLEService[] v;
			checkArray(l,2,out v);
			self.services=v;
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
			WeChatWASM.GetBLEDeviceServicesSuccessCallbackResult self=(WeChatWASM.GetBLEDeviceServicesSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.GetBLEDeviceServicesSuccessCallbackResult self=(WeChatWASM.GetBLEDeviceServicesSuccessCallbackResult)checkSelf(l);
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
		getTypeTable(l,"WeChatWASM.GetBLEDeviceServicesSuccessCallbackResult");
		addMember(l,"services",get_services,set_services,true);
		addMember(l,"errMsg",get_errMsg,set_errMsg,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.GetBLEDeviceServicesSuccessCallbackResult));
	}
}
