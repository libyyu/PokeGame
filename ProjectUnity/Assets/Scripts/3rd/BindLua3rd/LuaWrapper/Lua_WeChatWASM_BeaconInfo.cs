//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_BeaconInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.BeaconInfo o;
			o=new WeChatWASM.BeaconInfo();
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
	static public int get_accuracy(IntPtr l) {
		try {
			WeChatWASM.BeaconInfo self=(WeChatWASM.BeaconInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.accuracy);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_accuracy(IntPtr l) {
		try {
			WeChatWASM.BeaconInfo self=(WeChatWASM.BeaconInfo)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.accuracy=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_major(IntPtr l) {
		try {
			WeChatWASM.BeaconInfo self=(WeChatWASM.BeaconInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.major);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_major(IntPtr l) {
		try {
			WeChatWASM.BeaconInfo self=(WeChatWASM.BeaconInfo)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.major=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_minor(IntPtr l) {
		try {
			WeChatWASM.BeaconInfo self=(WeChatWASM.BeaconInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.minor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_minor(IntPtr l) {
		try {
			WeChatWASM.BeaconInfo self=(WeChatWASM.BeaconInfo)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.minor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_proximity(IntPtr l) {
		try {
			WeChatWASM.BeaconInfo self=(WeChatWASM.BeaconInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.proximity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_proximity(IntPtr l) {
		try {
			WeChatWASM.BeaconInfo self=(WeChatWASM.BeaconInfo)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.proximity=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_rssi(IntPtr l) {
		try {
			WeChatWASM.BeaconInfo self=(WeChatWASM.BeaconInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rssi);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_rssi(IntPtr l) {
		try {
			WeChatWASM.BeaconInfo self=(WeChatWASM.BeaconInfo)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.rssi=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_uuid(IntPtr l) {
		try {
			WeChatWASM.BeaconInfo self=(WeChatWASM.BeaconInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.uuid);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_uuid(IntPtr l) {
		try {
			WeChatWASM.BeaconInfo self=(WeChatWASM.BeaconInfo)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.uuid=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.BeaconInfo");
		addMember(l,"accuracy",get_accuracy,set_accuracy,true);
		addMember(l,"major",get_major,set_major,true);
		addMember(l,"minor",get_minor,set_minor,true);
		addMember(l,"proximity",get_proximity,set_proximity,true);
		addMember(l,"rssi",get_rssi,set_rssi,true);
		addMember(l,"uuid",get_uuid,set_uuid,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.BeaconInfo));
	}
}
