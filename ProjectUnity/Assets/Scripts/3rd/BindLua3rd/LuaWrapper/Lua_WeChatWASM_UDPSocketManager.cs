//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_UDPSocketManager : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.UDPSocketManager o;
			o=new WeChatWASM.UDPSocketManager();
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
	static public int OnMessage(IntPtr l) {
		try {
			WeChatWASM.UDPSocketManager self=(WeChatWASM.UDPSocketManager)checkSelf(l);
			System.Int32 a1 = default(System.Int32);
			checkType(l,2,out a1);
			System.Byte[] a2 = default(System.Byte[]);
			checkArray(l,3,out a2);
			self.OnMessage(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnClose(IntPtr l) {
		try {
			WeChatWASM.UDPSocketManager self=(WeChatWASM.UDPSocketManager)checkSelf(l);
			System.Int32 a1 = default(System.Int32);
			checkType(l,2,out a1);
			System.String a2 = default(System.String);
			checkType(l,3,out a2);
			self.OnClose(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnError(IntPtr l) {
		try {
			WeChatWASM.UDPSocketManager self=(WeChatWASM.UDPSocketManager)checkSelf(l);
			System.Int32 a1 = default(System.Int32);
			checkType(l,2,out a1);
			System.String a2 = default(System.String);
			checkType(l,3,out a2);
			self.OnError(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AddClient(IntPtr l) {
		try {
			WeChatWASM.UDPSocketManager self=(WeChatWASM.UDPSocketManager)checkSelf(l);
			WeChatWASM.UDPClient a1 = default(WeChatWASM.UDPClient);
			checkType(l,2,out a1);
			self.AddClient(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DeleteClient(IntPtr l) {
		try {
			WeChatWASM.UDPSocketManager self=(WeChatWASM.UDPSocketManager)checkSelf(l);
			WeChatWASM.UDPClient a1 = default(WeChatWASM.UDPClient);
			checkType(l,2,out a1);
			self.DeleteClient(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Instance(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,WeChatWASM.UDPSocketManager.Instance);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_Instance(IntPtr l) {
		try {
			WeChatWASM.UDPSocketManager v;
			checkType(l,2,out v);
			WeChatWASM.UDPSocketManager.Instance=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.UDPSocketManager");
		addMember(l,OnMessage);
		addMember(l,OnClose);
		addMember(l,OnError);
		addMember(l,AddClient);
		addMember(l,DeleteClient);
		addMember(l,"Instance",get_Instance,set_Instance,false);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.UDPSocketManager));
	}
}
