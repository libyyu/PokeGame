//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_ReadZipEntryOptionString : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.ReadZipEntryOptionString o;
			o=new WeChatWASM.ReadZipEntryOptionString();
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
	static public int get_entries(IntPtr l) {
		try {
			WeChatWASM.ReadZipEntryOptionString self=(WeChatWASM.ReadZipEntryOptionString)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.entries);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_entries(IntPtr l) {
		try {
			WeChatWASM.ReadZipEntryOptionString self=(WeChatWASM.ReadZipEntryOptionString)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.entries=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_filePath(IntPtr l) {
		try {
			WeChatWASM.ReadZipEntryOptionString self=(WeChatWASM.ReadZipEntryOptionString)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.filePath);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_filePath(IntPtr l) {
		try {
			WeChatWASM.ReadZipEntryOptionString self=(WeChatWASM.ReadZipEntryOptionString)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.filePath=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_encoding(IntPtr l) {
		try {
			WeChatWASM.ReadZipEntryOptionString self=(WeChatWASM.ReadZipEntryOptionString)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.encoding);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_encoding(IntPtr l) {
		try {
			WeChatWASM.ReadZipEntryOptionString self=(WeChatWASM.ReadZipEntryOptionString)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.encoding=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.ReadZipEntryOptionString");
		addMember(l,"entries",get_entries,set_entries,true);
		addMember(l,"filePath",get_filePath,set_filePath,true);
		addMember(l,"encoding",get_encoding,set_encoding,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.ReadZipEntryOptionString));
	}
}
