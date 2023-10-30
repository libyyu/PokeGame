//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_LaunchOptionsGame : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.LaunchOptionsGame o;
			o=new WeChatWASM.LaunchOptionsGame();
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
			WeChatWASM.LaunchOptionsGame self=(WeChatWASM.LaunchOptionsGame)checkSelf(l);
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
			WeChatWASM.LaunchOptionsGame self=(WeChatWASM.LaunchOptionsGame)checkSelf(l);
			System.Collections.Generic.Dictionary<System.String,System.String> v;
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
	static public int get_referrerInfo(IntPtr l) {
		try {
			WeChatWASM.LaunchOptionsGame self=(WeChatWASM.LaunchOptionsGame)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.referrerInfo);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_referrerInfo(IntPtr l) {
		try {
			WeChatWASM.LaunchOptionsGame self=(WeChatWASM.LaunchOptionsGame)checkSelf(l);
			WeChatWASM.EnterOptionsGameReferrerInfo v;
			checkType(l,2,out v);
			self.referrerInfo=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_scene(IntPtr l) {
		try {
			WeChatWASM.LaunchOptionsGame self=(WeChatWASM.LaunchOptionsGame)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.scene);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_scene(IntPtr l) {
		try {
			WeChatWASM.LaunchOptionsGame self=(WeChatWASM.LaunchOptionsGame)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.scene=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_chatType(IntPtr l) {
		try {
			WeChatWASM.LaunchOptionsGame self=(WeChatWASM.LaunchOptionsGame)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.chatType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_chatType(IntPtr l) {
		try {
			WeChatWASM.LaunchOptionsGame self=(WeChatWASM.LaunchOptionsGame)checkSelf(l);
			System.Nullable<System.Double> v;
			checkNullable(l,2,out v);
			self.chatType=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_shareTicket(IntPtr l) {
		try {
			WeChatWASM.LaunchOptionsGame self=(WeChatWASM.LaunchOptionsGame)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.shareTicket);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_shareTicket(IntPtr l) {
		try {
			WeChatWASM.LaunchOptionsGame self=(WeChatWASM.LaunchOptionsGame)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.shareTicket=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.LaunchOptionsGame");
		addMember(l,"query",get_query,set_query,true);
		addMember(l,"referrerInfo",get_referrerInfo,set_referrerInfo,true);
		addMember(l,"scene",get_scene,set_scene,true);
		addMember(l,"chatType",get_chatType,set_chatType,true);
		addMember(l,"shareTicket",get_shareTicket,set_shareTicket,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.LaunchOptionsGame));
	}
}
