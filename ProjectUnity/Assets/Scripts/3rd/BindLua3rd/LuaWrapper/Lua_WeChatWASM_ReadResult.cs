//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_ReadResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.ReadResult o;
			o=new WeChatWASM.ReadResult();
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
	static public int get_arrayBuffer(IntPtr l) {
		try {
			WeChatWASM.ReadResult self=(WeChatWASM.ReadResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.arrayBuffer);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_arrayBuffer(IntPtr l) {
		try {
			WeChatWASM.ReadResult self=(WeChatWASM.ReadResult)checkSelf(l);
			System.Byte[] v;
			checkArray(l,2,out v);
			self.arrayBuffer=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_arrayBufferLength(IntPtr l) {
		try {
			WeChatWASM.ReadResult self=(WeChatWASM.ReadResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.arrayBufferLength);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_arrayBufferLength(IntPtr l) {
		try {
			WeChatWASM.ReadResult self=(WeChatWASM.ReadResult)checkSelf(l);
			System.Nullable<System.Int32> v;
			checkNullable(l,2,out v);
			self.arrayBufferLength=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_bytesRead(IntPtr l) {
		try {
			WeChatWASM.ReadResult self=(WeChatWASM.ReadResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.bytesRead);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_bytesRead(IntPtr l) {
		try {
			WeChatWASM.ReadResult self=(WeChatWASM.ReadResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.bytesRead=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.ReadResult");
		addMember(l,"arrayBuffer",get_arrayBuffer,set_arrayBuffer,true);
		addMember(l,"arrayBufferLength",get_arrayBufferLength,set_arrayBufferLength,true);
		addMember(l,"bytesRead",get_bytesRead,set_bytesRead,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.ReadResult));
	}
}
