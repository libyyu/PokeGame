//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_BLEPeripheralServer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.BLEPeripheralServer o;
			o=new WeChatWASM.BLEPeripheralServer();
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
	static public int addService(IntPtr l) {
		try {
			WeChatWASM.BLEPeripheralServer self=(WeChatWASM.BLEPeripheralServer)checkSelf(l);
			WeChatWASM.AddServiceOption a1 = default(WeChatWASM.AddServiceOption);
			checkType(l,2,out a1);
			self.addService(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int offCharacteristicReadRequest(IntPtr l) {
		try {
			WeChatWASM.BLEPeripheralServer self=(WeChatWASM.BLEPeripheralServer)checkSelf(l);
			System.Action<WeChatWASM.OnCharacteristicReadRequestListenerResult> a1 = default(System.Action<WeChatWASM.OnCharacteristicReadRequestListenerResult>);
			checkDelegate(l,2,out a1);
			self.offCharacteristicReadRequest(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int offCharacteristicSubscribed(IntPtr l) {
		try {
			WeChatWASM.BLEPeripheralServer self=(WeChatWASM.BLEPeripheralServer)checkSelf(l);
			System.Action<WeChatWASM.OnCharacteristicSubscribedListenerResult> a1 = default(System.Action<WeChatWASM.OnCharacteristicSubscribedListenerResult>);
			checkDelegate(l,2,out a1);
			self.offCharacteristicSubscribed(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int offCharacteristicUnsubscribed(IntPtr l) {
		try {
			WeChatWASM.BLEPeripheralServer self=(WeChatWASM.BLEPeripheralServer)checkSelf(l);
			System.Action<WeChatWASM.OnCharacteristicSubscribedListenerResult> a1 = default(System.Action<WeChatWASM.OnCharacteristicSubscribedListenerResult>);
			checkDelegate(l,2,out a1);
			self.offCharacteristicUnsubscribed(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int offCharacteristicWriteRequest(IntPtr l) {
		try {
			WeChatWASM.BLEPeripheralServer self=(WeChatWASM.BLEPeripheralServer)checkSelf(l);
			System.Action<WeChatWASM.OnCharacteristicWriteRequestListenerResult> a1 = default(System.Action<WeChatWASM.OnCharacteristicWriteRequestListenerResult>);
			checkDelegate(l,2,out a1);
			self.offCharacteristicWriteRequest(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int onCharacteristicReadRequest(IntPtr l) {
		try {
			WeChatWASM.BLEPeripheralServer self=(WeChatWASM.BLEPeripheralServer)checkSelf(l);
			System.Action<WeChatWASM.OnCharacteristicReadRequestListenerResult> a1 = default(System.Action<WeChatWASM.OnCharacteristicReadRequestListenerResult>);
			checkDelegate(l,2,out a1);
			self.onCharacteristicReadRequest(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int onCharacteristicSubscribed(IntPtr l) {
		try {
			WeChatWASM.BLEPeripheralServer self=(WeChatWASM.BLEPeripheralServer)checkSelf(l);
			System.Action<WeChatWASM.OnCharacteristicSubscribedListenerResult> a1 = default(System.Action<WeChatWASM.OnCharacteristicSubscribedListenerResult>);
			checkDelegate(l,2,out a1);
			self.onCharacteristicSubscribed(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int onCharacteristicUnsubscribed(IntPtr l) {
		try {
			WeChatWASM.BLEPeripheralServer self=(WeChatWASM.BLEPeripheralServer)checkSelf(l);
			System.Action<WeChatWASM.OnCharacteristicSubscribedListenerResult> a1 = default(System.Action<WeChatWASM.OnCharacteristicSubscribedListenerResult>);
			checkDelegate(l,2,out a1);
			self.onCharacteristicUnsubscribed(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int onCharacteristicWriteRequest(IntPtr l) {
		try {
			WeChatWASM.BLEPeripheralServer self=(WeChatWASM.BLEPeripheralServer)checkSelf(l);
			System.Action<WeChatWASM.OnCharacteristicWriteRequestListenerResult> a1 = default(System.Action<WeChatWASM.OnCharacteristicWriteRequestListenerResult>);
			checkDelegate(l,2,out a1);
			self.onCharacteristicWriteRequest(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int removeService(IntPtr l) {
		try {
			WeChatWASM.BLEPeripheralServer self=(WeChatWASM.BLEPeripheralServer)checkSelf(l);
			WeChatWASM.RemoveServiceOption a1 = default(WeChatWASM.RemoveServiceOption);
			checkType(l,2,out a1);
			self.removeService(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int startAdvertising(IntPtr l) {
		try {
			WeChatWASM.BLEPeripheralServer self=(WeChatWASM.BLEPeripheralServer)checkSelf(l);
			WeChatWASM.StartAdvertisingObject a1 = default(WeChatWASM.StartAdvertisingObject);
			checkType(l,2,out a1);
			self.startAdvertising(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int stopAdvertising(IntPtr l) {
		try {
			WeChatWASM.BLEPeripheralServer self=(WeChatWASM.BLEPeripheralServer)checkSelf(l);
			WeChatWASM.StopAdvertisingOption a1 = default(WeChatWASM.StopAdvertisingOption);
			checkType(l,2,out a1);
			self.stopAdvertising(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int writeCharacteristicValue(IntPtr l) {
		try {
			WeChatWASM.BLEPeripheralServer self=(WeChatWASM.BLEPeripheralServer)checkSelf(l);
			WeChatWASM.WriteCharacteristicValueObject a1 = default(WeChatWASM.WriteCharacteristicValueObject);
			checkType(l,2,out a1);
			self.writeCharacteristicValue(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.BLEPeripheralServer");
		addMember(l,addService);
		addMember(l,offCharacteristicReadRequest);
		addMember(l,offCharacteristicSubscribed);
		addMember(l,offCharacteristicUnsubscribed);
		addMember(l,offCharacteristicWriteRequest);
		addMember(l,onCharacteristicReadRequest);
		addMember(l,onCharacteristicSubscribed);
		addMember(l,onCharacteristicUnsubscribed);
		addMember(l,onCharacteristicWriteRequest);
		addMember(l,removeService);
		addMember(l,startAdvertising);
		addMember(l,stopAdvertising);
		addMember(l,writeCharacteristicValue);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.BLEPeripheralServer));
	}
}
