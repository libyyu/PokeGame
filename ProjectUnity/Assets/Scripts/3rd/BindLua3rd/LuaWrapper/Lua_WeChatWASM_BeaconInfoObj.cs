//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_BeaconInfoObj : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.BeaconInfoObj o;
			o=new WeChatWASM.BeaconInfoObj();
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
	static public int get_major(IntPtr l) {
		try {
			WeChatWASM.BeaconInfoObj self=(WeChatWASM.BeaconInfoObj)checkSelf(l);
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
			WeChatWASM.BeaconInfoObj self=(WeChatWASM.BeaconInfoObj)checkSelf(l);
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
			WeChatWASM.BeaconInfoObj self=(WeChatWASM.BeaconInfoObj)checkSelf(l);
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
			WeChatWASM.BeaconInfoObj self=(WeChatWASM.BeaconInfoObj)checkSelf(l);
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
	static public int get_uuid(IntPtr l) {
		try {
			WeChatWASM.BeaconInfoObj self=(WeChatWASM.BeaconInfoObj)checkSelf(l);
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
			WeChatWASM.BeaconInfoObj self=(WeChatWASM.BeaconInfoObj)checkSelf(l);
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_measuredPower(IntPtr l) {
		try {
			WeChatWASM.BeaconInfoObj self=(WeChatWASM.BeaconInfoObj)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.measuredPower);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_measuredPower(IntPtr l) {
		try {
			WeChatWASM.BeaconInfoObj self=(WeChatWASM.BeaconInfoObj)checkSelf(l);
			System.Nullable<System.Double> v;
			checkNullable(l,2,out v);
			self.measuredPower=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.BeaconInfoObj");
		addMember(l,"major",get_major,set_major,true);
		addMember(l,"minor",get_minor,set_minor,true);
		addMember(l,"uuid",get_uuid,set_uuid,true);
		addMember(l,"measuredPower",get_measuredPower,set_measuredPower,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.BeaconInfoObj));
	}
}
