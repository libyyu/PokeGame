//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_StartBluetoothDevicesDiscoveryOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.StartBluetoothDevicesDiscoveryOption o;
			o=new WeChatWASM.StartBluetoothDevicesDiscoveryOption();
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
	static public int get_allowDuplicatesKey(IntPtr l) {
		try {
			WeChatWASM.StartBluetoothDevicesDiscoveryOption self=(WeChatWASM.StartBluetoothDevicesDiscoveryOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.allowDuplicatesKey);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_allowDuplicatesKey(IntPtr l) {
		try {
			WeChatWASM.StartBluetoothDevicesDiscoveryOption self=(WeChatWASM.StartBluetoothDevicesDiscoveryOption)checkSelf(l);
			System.Nullable<System.Boolean> v;
			checkNullable(l,2,out v);
			self.allowDuplicatesKey=v;
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
			WeChatWASM.StartBluetoothDevicesDiscoveryOption self=(WeChatWASM.StartBluetoothDevicesDiscoveryOption)checkSelf(l);
			System.Action<WeChatWASM.BluetoothError> v;
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
			WeChatWASM.StartBluetoothDevicesDiscoveryOption self=(WeChatWASM.StartBluetoothDevicesDiscoveryOption)checkSelf(l);
			System.Action<WeChatWASM.BluetoothError> v;
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
	static public int get_interval(IntPtr l) {
		try {
			WeChatWASM.StartBluetoothDevicesDiscoveryOption self=(WeChatWASM.StartBluetoothDevicesDiscoveryOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.interval);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_interval(IntPtr l) {
		try {
			WeChatWASM.StartBluetoothDevicesDiscoveryOption self=(WeChatWASM.StartBluetoothDevicesDiscoveryOption)checkSelf(l);
			System.Nullable<System.Double> v;
			checkNullable(l,2,out v);
			self.interval=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_powerLevel(IntPtr l) {
		try {
			WeChatWASM.StartBluetoothDevicesDiscoveryOption self=(WeChatWASM.StartBluetoothDevicesDiscoveryOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.powerLevel);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_powerLevel(IntPtr l) {
		try {
			WeChatWASM.StartBluetoothDevicesDiscoveryOption self=(WeChatWASM.StartBluetoothDevicesDiscoveryOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.powerLevel=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_services(IntPtr l) {
		try {
			WeChatWASM.StartBluetoothDevicesDiscoveryOption self=(WeChatWASM.StartBluetoothDevicesDiscoveryOption)checkSelf(l);
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
			WeChatWASM.StartBluetoothDevicesDiscoveryOption self=(WeChatWASM.StartBluetoothDevicesDiscoveryOption)checkSelf(l);
			System.String[] v;
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
	static public int set_success(IntPtr l) {
		try {
			WeChatWASM.StartBluetoothDevicesDiscoveryOption self=(WeChatWASM.StartBluetoothDevicesDiscoveryOption)checkSelf(l);
			System.Action<WeChatWASM.BluetoothError> v;
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
		getTypeTable(l,"WeChatWASM.StartBluetoothDevicesDiscoveryOption");
		addMember(l,"allowDuplicatesKey",get_allowDuplicatesKey,set_allowDuplicatesKey,true);
		addMember(l,"complete",null,set_complete,true);
		addMember(l,"fail",null,set_fail,true);
		addMember(l,"interval",get_interval,set_interval,true);
		addMember(l,"powerLevel",get_powerLevel,set_powerLevel,true);
		addMember(l,"services",get_services,set_services,true);
		addMember(l,"success",null,set_success,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.StartBluetoothDevicesDiscoveryOption));
	}
}
