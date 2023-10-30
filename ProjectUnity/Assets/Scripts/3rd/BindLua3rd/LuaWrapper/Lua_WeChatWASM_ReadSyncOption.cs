//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_ReadSyncOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.ReadSyncOption o;
			o=new WeChatWASM.ReadSyncOption();
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
			WeChatWASM.ReadSyncOption self=(WeChatWASM.ReadSyncOption)checkSelf(l);
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
			WeChatWASM.ReadSyncOption self=(WeChatWASM.ReadSyncOption)checkSelf(l);
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
			WeChatWASM.ReadSyncOption self=(WeChatWASM.ReadSyncOption)checkSelf(l);
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
			WeChatWASM.ReadSyncOption self=(WeChatWASM.ReadSyncOption)checkSelf(l);
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
	static public int get_fd(IntPtr l) {
		try {
			WeChatWASM.ReadSyncOption self=(WeChatWASM.ReadSyncOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.fd);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_fd(IntPtr l) {
		try {
			WeChatWASM.ReadSyncOption self=(WeChatWASM.ReadSyncOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.fd=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_length(IntPtr l) {
		try {
			WeChatWASM.ReadSyncOption self=(WeChatWASM.ReadSyncOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.length);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_length(IntPtr l) {
		try {
			WeChatWASM.ReadSyncOption self=(WeChatWASM.ReadSyncOption)checkSelf(l);
			System.Nullable<System.Double> v;
			checkNullable(l,2,out v);
			self.length=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_offset(IntPtr l) {
		try {
			WeChatWASM.ReadSyncOption self=(WeChatWASM.ReadSyncOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.offset);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_offset(IntPtr l) {
		try {
			WeChatWASM.ReadSyncOption self=(WeChatWASM.ReadSyncOption)checkSelf(l);
			System.Nullable<System.Double> v;
			checkNullable(l,2,out v);
			self.offset=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_position(IntPtr l) {
		try {
			WeChatWASM.ReadSyncOption self=(WeChatWASM.ReadSyncOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.position);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_position(IntPtr l) {
		try {
			WeChatWASM.ReadSyncOption self=(WeChatWASM.ReadSyncOption)checkSelf(l);
			System.Nullable<System.Double> v;
			checkNullable(l,2,out v);
			self.position=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.ReadSyncOption");
		addMember(l,"arrayBuffer",get_arrayBuffer,set_arrayBuffer,true);
		addMember(l,"arrayBufferLength",get_arrayBufferLength,set_arrayBufferLength,true);
		addMember(l,"fd",get_fd,set_fd,true);
		addMember(l,"length",get_length,set_length,true);
		addMember(l,"offset",get_offset,set_offset,true);
		addMember(l,"position",get_position,set_position,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.ReadSyncOption));
	}
}
