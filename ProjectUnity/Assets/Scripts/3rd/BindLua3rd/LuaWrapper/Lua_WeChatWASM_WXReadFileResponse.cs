//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXReadFileResponse : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXReadFileResponse o;
			o=new WeChatWASM.WXReadFileResponse();
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
	static public int get_binData(IntPtr l) {
		try {
			WeChatWASM.WXReadFileResponse self=(WeChatWASM.WXReadFileResponse)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.binData);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_binData(IntPtr l) {
		try {
			WeChatWASM.WXReadFileResponse self=(WeChatWASM.WXReadFileResponse)checkSelf(l);
			System.Byte[] v;
			checkArray(l,2,out v);
			self.binData=v;
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
			WeChatWASM.WXReadFileResponse self=(WeChatWASM.WXReadFileResponse)checkSelf(l);
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
			WeChatWASM.WXReadFileResponse self=(WeChatWASM.WXReadFileResponse)checkSelf(l);
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
	static public int get_stringData(IntPtr l) {
		try {
			WeChatWASM.WXReadFileResponse self=(WeChatWASM.WXReadFileResponse)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.stringData);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_stringData(IntPtr l) {
		try {
			WeChatWASM.WXReadFileResponse self=(WeChatWASM.WXReadFileResponse)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.stringData=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXReadFileResponse");
		addMember(l,"binData",get_binData,set_binData,true);
		addMember(l,"arrayBufferLength",get_arrayBufferLength,set_arrayBufferLength,true);
		addMember(l,"stringData",get_stringData,set_stringData,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXReadFileResponse),typeof(WeChatWASM.WXBaseResponse));
	}
}
