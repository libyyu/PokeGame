﻿//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_StartBeaconDiscoveryOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.StartBeaconDiscoveryOption o;
			o=new WeChatWASM.StartBeaconDiscoveryOption();
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
	static public int get_uuids(IntPtr l) {
		try {
			WeChatWASM.StartBeaconDiscoveryOption self=(WeChatWASM.StartBeaconDiscoveryOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.uuids);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_uuids(IntPtr l) {
		try {
			WeChatWASM.StartBeaconDiscoveryOption self=(WeChatWASM.StartBeaconDiscoveryOption)checkSelf(l);
			System.String[] v;
			checkArray(l,2,out v);
			self.uuids=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_complete(IntPtr l) {
		try {
			WeChatWASM.StartBeaconDiscoveryOption self=(WeChatWASM.StartBeaconDiscoveryOption)checkSelf(l);
			System.Action<WeChatWASM.BeaconError> v;
			int op=checkDelegate(l,2,out v);
			if(op==0) self.complete=v;
			else if(op==1) self.complete+=v;
			else if(op==2) self.complete-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_fail(IntPtr l) {
		try {
			WeChatWASM.StartBeaconDiscoveryOption self=(WeChatWASM.StartBeaconDiscoveryOption)checkSelf(l);
			System.Action<WeChatWASM.BeaconError> v;
			int op=checkDelegate(l,2,out v);
			if(op==0) self.fail=v;
			else if(op==1) self.fail+=v;
			else if(op==2) self.fail-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_ignoreBluetoothAvailable(IntPtr l) {
		try {
			WeChatWASM.StartBeaconDiscoveryOption self=(WeChatWASM.StartBeaconDiscoveryOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.ignoreBluetoothAvailable);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_ignoreBluetoothAvailable(IntPtr l) {
		try {
			WeChatWASM.StartBeaconDiscoveryOption self=(WeChatWASM.StartBeaconDiscoveryOption)checkSelf(l);
			System.Nullable<System.Boolean> v;
			checkNullable(l,2,out v);
			self.ignoreBluetoothAvailable=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_success(IntPtr l) {
		try {
			WeChatWASM.StartBeaconDiscoveryOption self=(WeChatWASM.StartBeaconDiscoveryOption)checkSelf(l);
			System.Action<WeChatWASM.BeaconError> v;
			int op=checkDelegate(l,2,out v);
			if(op==0) self.success=v;
			else if(op==1) self.success+=v;
			else if(op==2) self.success-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.StartBeaconDiscoveryOption");
		addMember(l,"uuids",get_uuids,set_uuids,true);
		addMember(l,"complete",null,set_complete,true);
		addMember(l,"fail",null,set_fail,true);
		addMember(l,"ignoreBluetoothAvailable",get_ignoreBluetoothAvailable,set_ignoreBluetoothAvailable,true);
		addMember(l,"success",null,set_success,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.StartBeaconDiscoveryOption));
	}
}
