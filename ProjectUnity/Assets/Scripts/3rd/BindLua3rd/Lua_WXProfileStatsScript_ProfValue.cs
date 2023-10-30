#if UNITY_WEBGL && !UNITY_EDITOR
//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WXProfileStatsScript_ProfValue : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WXProfileStatsScript.ProfValue o;
			o=new WXProfileStatsScript.ProfValue();
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
	static public int get_current(IntPtr l) {
		try {
			WXProfileStatsScript.ProfValue self=(WXProfileStatsScript.ProfValue)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.current);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_current(IntPtr l) {
		try {
			WXProfileStatsScript.ProfValue self=(WXProfileStatsScript.ProfValue)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.current=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_max(IntPtr l) {
		try {
			WXProfileStatsScript.ProfValue self=(WXProfileStatsScript.ProfValue)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.max);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_max(IntPtr l) {
		try {
			WXProfileStatsScript.ProfValue self=(WXProfileStatsScript.ProfValue)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.max=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_min(IntPtr l) {
		try {
			WXProfileStatsScript.ProfValue self=(WXProfileStatsScript.ProfValue)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.min);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_min(IntPtr l) {
		try {
			WXProfileStatsScript.ProfValue self=(WXProfileStatsScript.ProfValue)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.min=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WXProfileStatsScript.ProfValue");
		addMember(l,"current",get_current,set_current,true);
		addMember(l,"max",get_max,set_max,true);
		addMember(l,"min",get_min,set_min,true);
		createTypeMetatable(l,constructor, typeof(WXProfileStatsScript.ProfValue));
	}
}
#endif