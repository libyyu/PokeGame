//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_GetBatteryInfoSuccessCallbackResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.GetBatteryInfoSuccessCallbackResult o;
			o=new WeChatWASM.GetBatteryInfoSuccessCallbackResult();
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
			WeChatWASM.GetBatteryInfoSuccessCallbackResult self=(WeChatWASM.GetBatteryInfoSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.GetBatteryInfoSuccessCallbackResult self=(WeChatWASM.GetBatteryInfoSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.GetBatteryInfoSuccessCallbackResult self=(WeChatWASM.GetBatteryInfoSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.GetBatteryInfoSuccessCallbackResult self=(WeChatWASM.GetBatteryInfoSuccessCallbackResult)checkSelf(l);
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_errMsg(IntPtr l) {
		try {
			WeChatWASM.GetBatteryInfoSuccessCallbackResult self=(WeChatWASM.GetBatteryInfoSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.errMsg);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_errMsg(IntPtr l) {
		try {
			WeChatWASM.GetBatteryInfoSuccessCallbackResult self=(WeChatWASM.GetBatteryInfoSuccessCallbackResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.errMsg=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.GetBatteryInfoSuccessCallbackResult");
		addMember(l,"isCharging",get_isCharging,set_isCharging,true);
		addMember(l,"level",get_level,set_level,true);
		addMember(l,"errMsg",get_errMsg,set_errMsg,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.GetBatteryInfoSuccessCallbackResult));
	}
}
