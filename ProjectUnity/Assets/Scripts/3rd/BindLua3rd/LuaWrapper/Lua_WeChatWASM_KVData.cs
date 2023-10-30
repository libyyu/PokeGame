//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_KVData : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.KVData o;
			o=new WeChatWASM.KVData();
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
	static public int get_key(IntPtr l) {
		try {
			WeChatWASM.KVData self=(WeChatWASM.KVData)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.key);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_key(IntPtr l) {
		try {
			WeChatWASM.KVData self=(WeChatWASM.KVData)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.key=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_value(IntPtr l) {
		try {
			WeChatWASM.KVData self=(WeChatWASM.KVData)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.value);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_value(IntPtr l) {
		try {
			WeChatWASM.KVData self=(WeChatWASM.KVData)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.value=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.KVData");
		addMember(l,"key",get_key,set_key,true);
		addMember(l,"value",get_value,set_value,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.KVData));
	}
}
