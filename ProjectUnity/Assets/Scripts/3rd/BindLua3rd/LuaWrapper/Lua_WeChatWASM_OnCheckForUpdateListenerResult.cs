//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_OnCheckForUpdateListenerResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.OnCheckForUpdateListenerResult o;
			o=new WeChatWASM.OnCheckForUpdateListenerResult();
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
	static public int get_hasUpdate(IntPtr l) {
		try {
			WeChatWASM.OnCheckForUpdateListenerResult self=(WeChatWASM.OnCheckForUpdateListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.hasUpdate);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_hasUpdate(IntPtr l) {
		try {
			WeChatWASM.OnCheckForUpdateListenerResult self=(WeChatWASM.OnCheckForUpdateListenerResult)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.hasUpdate=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.OnCheckForUpdateListenerResult");
		addMember(l,"hasUpdate",get_hasUpdate,set_hasUpdate,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.OnCheckForUpdateListenerResult));
	}
}
