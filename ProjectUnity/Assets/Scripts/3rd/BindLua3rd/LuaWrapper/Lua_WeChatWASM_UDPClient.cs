//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_UDPClient : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.UDPClient o;
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			System.Int32 a2 = default(System.Int32);
			checkType(l,3,out a2);
			System.Int32 a3 = default(System.Int32);
			checkType(l,4,out a3);
			o=new WeChatWASM.UDPClient(a1,a2,a3);
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
	static public int SetCallBack(IntPtr l) {
		try {
			WeChatWASM.UDPClient self=(WeChatWASM.UDPClient)checkSelf(l);
			System.Action<System.Byte[]> a1 = default(System.Action<System.Byte[]>);
			checkDelegate(l,2,out a1);
			System.Action<System.String> a2 = default(System.Action<System.String>);
			checkDelegate(l,3,out a2);
			System.Action<System.String> a3 = default(System.Action<System.String>);
			checkDelegate(l,4,out a3);
			self.SetCallBack(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Send(IntPtr l) {
		try {
			WeChatWASM.UDPClient self=(WeChatWASM.UDPClient)checkSelf(l);
			System.Byte[] a1 = default(System.Byte[]);
			checkArray(l,2,out a1);
			System.Int32 a2 = default(System.Int32);
			checkType(l,3,out a2);
			System.Int32 a3 = default(System.Int32);
			checkType(l,4,out a3);
			self.Send(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnMessage(IntPtr l) {
		try {
			WeChatWASM.UDPClient self=(WeChatWASM.UDPClient)checkSelf(l);
			System.Byte[] a1 = default(System.Byte[]);
			checkArray(l,2,out a1);
			self.OnMessage(a1);
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
			WeChatWASM.UDPClient self=(WeChatWASM.UDPClient)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.OnClose(a1);
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
			WeChatWASM.UDPClient self=(WeChatWASM.UDPClient)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.OnError(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Destroy(IntPtr l) {
		try {
			WeChatWASM.UDPClient self=(WeChatWASM.UDPClient)checkSelf(l);
			self.Destroy();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_socketId(IntPtr l) {
		try {
			WeChatWASM.UDPClient self=(WeChatWASM.UDPClient)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.socketId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_socketId(IntPtr l) {
		try {
			WeChatWASM.UDPClient self=(WeChatWASM.UDPClient)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.socketId=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.UDPClient");
		addMember(l,SetCallBack);
		addMember(l,Send);
		addMember(l,OnMessage);
		addMember(l,OnClose);
		addMember(l,OnError);
		addMember(l,Destroy);
		addMember(l,"socketId",get_socketId,set_socketId,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.UDPClient));
	}
}
