//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_OnGameLiveStateChangeCallbackResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.OnGameLiveStateChangeCallbackResult o;
			o=new WeChatWASM.OnGameLiveStateChangeCallbackResult();
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
	static public int get_state(IntPtr l) {
		try {
			WeChatWASM.OnGameLiveStateChangeCallbackResult self=(WeChatWASM.OnGameLiveStateChangeCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.state);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_state(IntPtr l) {
		try {
			WeChatWASM.OnGameLiveStateChangeCallbackResult self=(WeChatWASM.OnGameLiveStateChangeCallbackResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.state=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_feedId(IntPtr l) {
		try {
			WeChatWASM.OnGameLiveStateChangeCallbackResult self=(WeChatWASM.OnGameLiveStateChangeCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.feedId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_feedId(IntPtr l) {
		try {
			WeChatWASM.OnGameLiveStateChangeCallbackResult self=(WeChatWASM.OnGameLiveStateChangeCallbackResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.feedId=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.OnGameLiveStateChangeCallbackResult");
		addMember(l,"state",get_state,set_state,true);
		addMember(l,"feedId",get_feedId,set_feedId,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.OnGameLiveStateChangeCallbackResult));
	}
}
