//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_BlueToothDevice : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.BlueToothDevice o;
			o=new WeChatWASM.BlueToothDevice();
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
			WeChatWASM.BlueToothDevice self=(WeChatWASM.BlueToothDevice)checkSelf(l);
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
			WeChatWASM.BlueToothDevice self=(WeChatWASM.BlueToothDevice)checkSelf(l);
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
	static public int get_advertisData(IntPtr l) {
		try {
			WeChatWASM.BlueToothDevice self=(WeChatWASM.BlueToothDevice)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.advertisData);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_advertisData(IntPtr l) {
		try {
			WeChatWASM.BlueToothDevice self=(WeChatWASM.BlueToothDevice)checkSelf(l);
			System.Byte[] v;
			checkArray(l,2,out v);
			self.advertisData=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_arrayBufferLength(IntPtr l) {
		try {
			WeChatWASM.BlueToothDevice self=(WeChatWASM.BlueToothDevice)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.arrayBufferLength);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_arrayBufferLength(IntPtr l) {
		try {
			WeChatWASM.BlueToothDevice self=(WeChatWASM.BlueToothDevice)checkSelf(l);
			System.Nullable<System.Int32> v;
			checkNullable(l,2,out v);
			self.arrayBufferLength=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_advertisServiceUUIDs(IntPtr l) {
		try {
			WeChatWASM.BlueToothDevice self=(WeChatWASM.BlueToothDevice)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.advertisServiceUUIDs);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_advertisServiceUUIDs(IntPtr l) {
		try {
			WeChatWASM.BlueToothDevice self=(WeChatWASM.BlueToothDevice)checkSelf(l);
			System.String[] v;
			checkArray(l,2,out v);
			self.advertisServiceUUIDs=v;
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
			WeChatWASM.BlueToothDevice self=(WeChatWASM.BlueToothDevice)checkSelf(l);
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
			WeChatWASM.BlueToothDevice self=(WeChatWASM.BlueToothDevice)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
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
	static public int get_deviceId(IntPtr l) {
		try {
			WeChatWASM.BlueToothDevice self=(WeChatWASM.BlueToothDevice)checkSelf(l);
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
			WeChatWASM.BlueToothDevice self=(WeChatWASM.BlueToothDevice)checkSelf(l);
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
	static public int get_localName(IntPtr l) {
		try {
			WeChatWASM.BlueToothDevice self=(WeChatWASM.BlueToothDevice)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.localName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_localName(IntPtr l) {
		try {
			WeChatWASM.BlueToothDevice self=(WeChatWASM.BlueToothDevice)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.localName=v;
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
			WeChatWASM.BlueToothDevice self=(WeChatWASM.BlueToothDevice)checkSelf(l);
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
			WeChatWASM.BlueToothDevice self=(WeChatWASM.BlueToothDevice)checkSelf(l);
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_serviceData(IntPtr l) {
		try {
			WeChatWASM.BlueToothDevice self=(WeChatWASM.BlueToothDevice)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.serviceData);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_serviceData(IntPtr l) {
		try {
			WeChatWASM.BlueToothDevice self=(WeChatWASM.BlueToothDevice)checkSelf(l);
			System.Collections.Generic.Dictionary<System.String,System.String> v;
			checkType(l,2,out v);
			self.serviceData=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.BlueToothDevice");
		addMember(l,"RSSI",get_RSSI,set_RSSI,true);
		addMember(l,"advertisData",get_advertisData,set_advertisData,true);
		addMember(l,"arrayBufferLength",get_arrayBufferLength,set_arrayBufferLength,true);
		addMember(l,"advertisServiceUUIDs",get_advertisServiceUUIDs,set_advertisServiceUUIDs,true);
		addMember(l,"connectable",get_connectable,set_connectable,true);
		addMember(l,"deviceId",get_deviceId,set_deviceId,true);
		addMember(l,"localName",get_localName,set_localName,true);
		addMember(l,"name",get_name,set_name,true);
		addMember(l,"serviceData",get_serviceData,set_serviceData,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.BlueToothDevice));
	}
}
