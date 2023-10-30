//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_OnBeaconUpdateListenerResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.OnBeaconUpdateListenerResult o;
			o=new WeChatWASM.OnBeaconUpdateListenerResult();
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
	static public int get_beacons(IntPtr l) {
		try {
			WeChatWASM.OnBeaconUpdateListenerResult self=(WeChatWASM.OnBeaconUpdateListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.beacons);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_beacons(IntPtr l) {
		try {
			WeChatWASM.OnBeaconUpdateListenerResult self=(WeChatWASM.OnBeaconUpdateListenerResult)checkSelf(l);
			WeChatWASM.BeaconInfo[] v;
			checkArray(l,2,out v);
			self.beacons=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.OnBeaconUpdateListenerResult");
		addMember(l,"beacons",get_beacons,set_beacons,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.OnBeaconUpdateListenerResult));
	}
}
