//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_GetBLEDeviceRSSISuccessCallbackResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.GetBLEDeviceRSSISuccessCallbackResult o;
			o=new WeChatWASM.GetBLEDeviceRSSISuccessCallbackResult();
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
	static public int get_RSSI(IntPtr l) {
		try {
			WeChatWASM.GetBLEDeviceRSSISuccessCallbackResult self=(WeChatWASM.GetBLEDeviceRSSISuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.RSSI);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_RSSI(IntPtr l) {
		try {
			WeChatWASM.GetBLEDeviceRSSISuccessCallbackResult self=(WeChatWASM.GetBLEDeviceRSSISuccessCallbackResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.RSSI=v;
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
			WeChatWASM.GetBLEDeviceRSSISuccessCallbackResult self=(WeChatWASM.GetBLEDeviceRSSISuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.GetBLEDeviceRSSISuccessCallbackResult self=(WeChatWASM.GetBLEDeviceRSSISuccessCallbackResult)checkSelf(l);
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
		getTypeTable(l,"WeChatWASM.GetBLEDeviceRSSISuccessCallbackResult");
		addMember(l,"RSSI",get_RSSI,set_RSSI,true);
		addMember(l,"errMsg",get_errMsg,set_errMsg,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.GetBLEDeviceRSSISuccessCallbackResult));
	}
}
