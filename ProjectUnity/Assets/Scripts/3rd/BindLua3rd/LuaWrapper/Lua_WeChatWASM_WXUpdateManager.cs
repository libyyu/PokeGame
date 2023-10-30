//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXUpdateManager : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXUpdateManager o;
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			o=new WeChatWASM.WXUpdateManager(a1);
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
	static public int ApplyUpdate(IntPtr l) {
		try {
			WeChatWASM.WXUpdateManager self=(WeChatWASM.WXUpdateManager)checkSelf(l);
			self.ApplyUpdate();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnCheckForUpdate(IntPtr l) {
		try {
			WeChatWASM.WXUpdateManager self=(WeChatWASM.WXUpdateManager)checkSelf(l);
			System.Action<WeChatWASM.OnCheckForUpdateListenerResult> a1 = default(System.Action<WeChatWASM.OnCheckForUpdateListenerResult>);
			checkDelegate(l,2,out a1);
			self.OnCheckForUpdate(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnUpdateFailed(IntPtr l) {
		try {
			WeChatWASM.WXUpdateManager self=(WeChatWASM.WXUpdateManager)checkSelf(l);
			System.Action<WeChatWASM.GeneralCallbackResult> a1 = default(System.Action<WeChatWASM.GeneralCallbackResult>);
			checkDelegate(l,2,out a1);
			self.OnUpdateFailed(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnUpdateReady(IntPtr l) {
		try {
			WeChatWASM.WXUpdateManager self=(WeChatWASM.WXUpdateManager)checkSelf(l);
			System.Action<WeChatWASM.GeneralCallbackResult> a1 = default(System.Action<WeChatWASM.GeneralCallbackResult>);
			checkDelegate(l,2,out a1);
			self.OnUpdateReady(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_OnCheckForUpdateActionList(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,WeChatWASM.WXUpdateManager.OnCheckForUpdateActionList);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_OnCheckForUpdateActionList(IntPtr l) {
		try {
			System.Collections.Generic.Dictionary<System.String,System.Action<WeChatWASM.OnCheckForUpdateListenerResult>> v;
			checkType(l,2,out v);
			WeChatWASM.WXUpdateManager.OnCheckForUpdateActionList=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_OnUpdateFailedActionList(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,WeChatWASM.WXUpdateManager.OnUpdateFailedActionList);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_OnUpdateFailedActionList(IntPtr l) {
		try {
			System.Collections.Generic.Dictionary<System.String,System.Action<WeChatWASM.GeneralCallbackResult>> v;
			checkType(l,2,out v);
			WeChatWASM.WXUpdateManager.OnUpdateFailedActionList=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_OnUpdateReadyActionList(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,WeChatWASM.WXUpdateManager.OnUpdateReadyActionList);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_OnUpdateReadyActionList(IntPtr l) {
		try {
			System.Collections.Generic.Dictionary<System.String,System.Action<WeChatWASM.GeneralCallbackResult>> v;
			checkType(l,2,out v);
			WeChatWASM.WXUpdateManager.OnUpdateReadyActionList=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXUpdateManager");
		addMember(l,ApplyUpdate);
		addMember(l,OnCheckForUpdate);
		addMember(l,OnUpdateFailed);
		addMember(l,OnUpdateReady);
		addMember(l,"OnCheckForUpdateActionList",get_OnCheckForUpdateActionList,set_OnCheckForUpdateActionList,false);
		addMember(l,"OnUpdateFailedActionList",get_OnUpdateFailedActionList,set_OnUpdateFailedActionList,false);
		addMember(l,"OnUpdateReadyActionList",get_OnUpdateReadyActionList,set_OnUpdateReadyActionList,false);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXUpdateManager));
	}
}
