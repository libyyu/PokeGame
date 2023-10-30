//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_AdvertiseReqObj : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.AdvertiseReqObj o;
			o=new WeChatWASM.AdvertiseReqObj();
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
	static public int get_beacon(IntPtr l) {
		try {
			WeChatWASM.AdvertiseReqObj self=(WeChatWASM.AdvertiseReqObj)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.beacon);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_beacon(IntPtr l) {
		try {
			WeChatWASM.AdvertiseReqObj self=(WeChatWASM.AdvertiseReqObj)checkSelf(l);
			WeChatWASM.BeaconInfoObj v;
			checkType(l,2,out v);
			self.beacon=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_connectable(IntPtr l) {
		try {
			WeChatWASM.AdvertiseReqObj self=(WeChatWASM.AdvertiseReqObj)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.connectable);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_connectable(IntPtr l) {
		try {
			WeChatWASM.AdvertiseReqObj self=(WeChatWASM.AdvertiseReqObj)checkSelf(l);
			System.Nullable<System.Boolean> v;
			checkNullable(l,2,out v);
			self.connectable=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_deviceName(IntPtr l) {
		try {
			WeChatWASM.AdvertiseReqObj self=(WeChatWASM.AdvertiseReqObj)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.deviceName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_deviceName(IntPtr l) {
		try {
			WeChatWASM.AdvertiseReqObj self=(WeChatWASM.AdvertiseReqObj)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.deviceName=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_manufacturerData(IntPtr l) {
		try {
			WeChatWASM.AdvertiseReqObj self=(WeChatWASM.AdvertiseReqObj)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.manufacturerData);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_manufacturerData(IntPtr l) {
		try {
			WeChatWASM.AdvertiseReqObj self=(WeChatWASM.AdvertiseReqObj)checkSelf(l);
			WeChatWASM.ManufacturerData[] v;
			checkArray(l,2,out v);
			self.manufacturerData=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_serviceUuids(IntPtr l) {
		try {
			WeChatWASM.AdvertiseReqObj self=(WeChatWASM.AdvertiseReqObj)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.serviceUuids);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_serviceUuids(IntPtr l) {
		try {
			WeChatWASM.AdvertiseReqObj self=(WeChatWASM.AdvertiseReqObj)checkSelf(l);
			System.String[] v;
			checkArray(l,2,out v);
			self.serviceUuids=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.AdvertiseReqObj");
		addMember(l,"beacon",get_beacon,set_beacon,true);
		addMember(l,"connectable",get_connectable,set_connectable,true);
		addMember(l,"deviceName",get_deviceName,set_deviceName,true);
		addMember(l,"manufacturerData",get_manufacturerData,set_manufacturerData,true);
		addMember(l,"serviceUuids",get_serviceUuids,set_serviceUuids,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.AdvertiseReqObj));
	}
}
