//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_OnBluetoothDeviceFoundListenerResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.OnBluetoothDeviceFoundListenerResult o;
			o=new WeChatWASM.OnBluetoothDeviceFoundListenerResult();
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
			WeChatWASM.OnBluetoothDeviceFoundListenerResult self=(WeChatWASM.OnBluetoothDeviceFoundListenerResult)checkSelf(l);
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
			WeChatWASM.OnBluetoothDeviceFoundListenerResult self=(WeChatWASM.OnBluetoothDeviceFoundListenerResult)checkSelf(l);
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
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.OnBluetoothDeviceFoundListenerResult");
		addMember(l,"devices",get_devices,set_devices,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.OnBluetoothDeviceFoundListenerResult));
	}
}
