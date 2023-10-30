//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_BluetoothDeviceInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.BluetoothDeviceInfo o;
			o=new WeChatWASM.BluetoothDeviceInfo();
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
	static public int get_deviceId(IntPtr l) {
		try {
			WeChatWASM.BluetoothDeviceInfo self=(WeChatWASM.BluetoothDeviceInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.deviceId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_deviceId(IntPtr l) {
		try {
			WeChatWASM.BluetoothDeviceInfo self=(WeChatWASM.BluetoothDeviceInfo)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.deviceId=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_name(IntPtr l) {
		try {
			WeChatWASM.BluetoothDeviceInfo self=(WeChatWASM.BluetoothDeviceInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.name);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_name(IntPtr l) {
		try {
			WeChatWASM.BluetoothDeviceInfo self=(WeChatWASM.BluetoothDeviceInfo)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.name=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.BluetoothDeviceInfo");
		addMember(l,"deviceId",get_deviceId,set_deviceId,true);
		addMember(l,"name",get_name,set_name,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.BluetoothDeviceInfo));
	}
}
