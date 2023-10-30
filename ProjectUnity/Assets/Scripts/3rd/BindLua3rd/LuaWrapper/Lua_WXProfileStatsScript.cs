//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WXProfileStatsScript : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Awake(IntPtr l) {
		try {
			WXProfileStatsScript self=(WXProfileStatsScript)checkSelf(l);
			self.Awake();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnEnable(IntPtr l) {
		try {
			WXProfileStatsScript self=(WXProfileStatsScript)checkSelf(l);
			self.OnEnable();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnDisable(IntPtr l) {
		try {
			WXProfileStatsScript self=(WXProfileStatsScript)checkSelf(l);
			self.OnDisable();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int UpdateValue(IntPtr l) {
		try {
			WXProfileStatsScript self=(WXProfileStatsScript)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			System.Single a2 = default(System.Single);
			checkType(l,3,out a2);
			System.Text.StringBuilder a3 = default(System.Text.StringBuilder);
			checkType(l,4,out a3);
			System.String a4 = default(System.String);
			checkType(l,5,out a4);
			var ret=self.UpdateValue(a1,a2,a3,a4);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Update(IntPtr l) {
		try {
			WXProfileStatsScript self=(WXProfileStatsScript)checkSelf(l);
			self.Update();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int UpdateFps(IntPtr l) {
		try {
			WXProfileStatsScript self=(WXProfileStatsScript)checkSelf(l);
			self.UpdateFps();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnGUI(IntPtr l) {
		try {
			WXProfileStatsScript self=(WXProfileStatsScript)checkSelf(l);
			self.OnGUI();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetProfileStatsDatas(IntPtr l) {
		try {
			WXProfileStatsScript self=(WXProfileStatsScript)checkSelf(l);
			var ret=self.GetProfileStatsDatas();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WXProfileStatsScript");
		addMember(l,Awake);
		addMember(l,OnEnable);
		addMember(l,OnDisable);
		addMember(l,UpdateValue);
		addMember(l,Update);
		addMember(l,UpdateFps);
		addMember(l,OnGUI);
		addMember(l,GetProfileStatsDatas);
		createTypeMetatable(l,null, typeof(WXProfileStatsScript),typeof(UnityEngine.MonoBehaviour));
	}
}
