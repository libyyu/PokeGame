//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_GetBatteryInfoSyncResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.GetBatteryInfoSyncResult o;
			o=new WeChatWASM.GetBatteryInfoSyncResult();
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
	static public int get_isCharging(IntPtr l) {
		try {
			WeChatWASM.GetBatteryInfoSyncResult self=(WeChatWASM.GetBatteryInfoSyncResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isCharging);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_isCharging(IntPtr l) {
		try {
			WeChatWASM.GetBatteryInfoSyncResult self=(WeChatWASM.GetBatteryInfoSyncResult)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.isCharging=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_level(IntPtr l) {
		try {
			WeChatWASM.GetBatteryInfoSyncResult self=(WeChatWASM.GetBatteryInfoSyncResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.level);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_level(IntPtr l) {
		try {
			WeChatWASM.GetBatteryInfoSyncResult self=(WeChatWASM.GetBatteryInfoSyncResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.level=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.GetBatteryInfoSyncResult");
		addMember(l,"isCharging",get_isCharging,set_isCharging,true);
		addMember(l,"level",get_level,set_level,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.GetBatteryInfoSyncResult));
	}
}
