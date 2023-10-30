//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_SetMessageToFriendQueryOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.SetMessageToFriendQueryOption o;
			o=new WeChatWASM.SetMessageToFriendQueryOption();
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
	static public int get_query(IntPtr l) {
		try {
			WeChatWASM.SetMessageToFriendQueryOption self=(WeChatWASM.SetMessageToFriendQueryOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.query);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_query(IntPtr l) {
		try {
			WeChatWASM.SetMessageToFriendQueryOption self=(WeChatWASM.SetMessageToFriendQueryOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.query=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_shareMessageToFriendScene(IntPtr l) {
		try {
			WeChatWASM.SetMessageToFriendQueryOption self=(WeChatWASM.SetMessageToFriendQueryOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.shareMessageToFriendScene);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_shareMessageToFriendScene(IntPtr l) {
		try {
			WeChatWASM.SetMessageToFriendQueryOption self=(WeChatWASM.SetMessageToFriendQueryOption)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.shareMessageToFriendScene=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.SetMessageToFriendQueryOption");
		addMember(l,"query",get_query,set_query,true);
		addMember(l,"shareMessageToFriendScene",get_shareMessageToFriendScene,set_shareMessageToFriendScene,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.SetMessageToFriendQueryOption));
	}
}
