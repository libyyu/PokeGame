//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_GameLiveState : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.GameLiveState o;
			o=new WeChatWASM.GameLiveState();
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
	static public int get_isLive(IntPtr l) {
		try {
			WeChatWASM.GameLiveState self=(WeChatWASM.GameLiveState)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isLive);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_isLive(IntPtr l) {
		try {
			WeChatWASM.GameLiveState self=(WeChatWASM.GameLiveState)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.isLive=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.GameLiveState");
		addMember(l,"isLive",get_isLive,set_isLive,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.GameLiveState));
	}
}
