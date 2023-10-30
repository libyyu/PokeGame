//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_RmdirParam : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.RmdirParam o;
			o=new WeChatWASM.RmdirParam();
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
	static public int get_dirPath(IntPtr l) {
		try {
			WeChatWASM.RmdirParam self=(WeChatWASM.RmdirParam)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.dirPath);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_dirPath(IntPtr l) {
		try {
			WeChatWASM.RmdirParam self=(WeChatWASM.RmdirParam)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.dirPath=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_recursive(IntPtr l) {
		try {
			WeChatWASM.RmdirParam self=(WeChatWASM.RmdirParam)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.recursive);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_recursive(IntPtr l) {
		try {
			WeChatWASM.RmdirParam self=(WeChatWASM.RmdirParam)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.recursive=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.RmdirParam");
		addMember(l,"dirPath",get_dirPath,set_dirPath,true);
		addMember(l,"recursive",get_recursive,set_recursive,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.RmdirParam));
	}
}
