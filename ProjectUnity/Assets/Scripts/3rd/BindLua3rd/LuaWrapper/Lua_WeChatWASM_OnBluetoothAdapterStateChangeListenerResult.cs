﻿//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_OnBluetoothAdapterStateChangeListenerResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.OnBluetoothAdapterStateChangeListenerResult o;
			o=new WeChatWASM.OnBluetoothAdapterStateChangeListenerResult();
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
	static public int get_available(IntPtr l) {
		try {
			WeChatWASM.OnBluetoothAdapterStateChangeListenerResult self=(WeChatWASM.OnBluetoothAdapterStateChangeListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.available);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_available(IntPtr l) {
		try {
			WeChatWASM.OnBluetoothAdapterStateChangeListenerResult self=(WeChatWASM.OnBluetoothAdapterStateChangeListenerResult)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.available=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_discovering(IntPtr l) {
		try {
			WeChatWASM.OnBluetoothAdapterStateChangeListenerResult self=(WeChatWASM.OnBluetoothAdapterStateChangeListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.discovering);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_discovering(IntPtr l) {
		try {
			WeChatWASM.OnBluetoothAdapterStateChangeListenerResult self=(WeChatWASM.OnBluetoothAdapterStateChangeListenerResult)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.discovering=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.OnBluetoothAdapterStateChangeListenerResult");
		addMember(l,"available",get_available,set_available,true);
		addMember(l,"discovering",get_discovering,set_discovering,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.OnBluetoothAdapterStateChangeListenerResult));
	}
}
