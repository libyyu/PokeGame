//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_GetBluetoothDevicesSuccessCallbackResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.GetBluetoothDevicesSuccessCallbackResult o;
			o=new WeChatWASM.GetBluetoothDevicesSuccessCallbackResult();
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
	static public int get_devices(IntPtr l) {
		try {
			WeChatWASM.GetBluetoothDevicesSuccessCallbackResult self=(WeChatWASM.GetBluetoothDevicesSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.devices);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_devices(IntPtr l) {
		try {
			WeChatWASM.GetBluetoothDevicesSuccessCallbackResult self=(WeChatWASM.GetBluetoothDevicesSuccessCallbackResult)checkSelf(l);
			WeChatWASM.BlueToothDevice[] v;
			checkArray(l,2,out v);
			self.devices=v;
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
			WeChatWASM.GetBluetoothDevicesSuccessCallbackResult self=(WeChatWASM.GetBluetoothDevicesSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.GetBluetoothDevicesSuccessCallbackResult self=(WeChatWASM.GetBluetoothDevicesSuccessCallbackResult)checkSelf(l);
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
		getTypeTable(l,"WeChatWASM.GetBluetoothDevicesSuccessCallbackResult");
		addMember(l,"devices",get_devices,set_devices,true);
		addMember(l,"errMsg",get_errMsg,set_errMsg,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.GetBluetoothDevicesSuccessCallbackResult));
	}
}
