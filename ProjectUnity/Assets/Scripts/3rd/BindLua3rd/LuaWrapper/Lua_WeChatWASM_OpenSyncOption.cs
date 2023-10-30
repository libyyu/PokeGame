//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_OpenSyncOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.OpenSyncOption o;
			o=new WeChatWASM.OpenSyncOption();
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
	static public int get_filePath(IntPtr l) {
		try {
			WeChatWASM.OpenSyncOption self=(WeChatWASM.OpenSyncOption)checkSelf(l);
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
			WeChatWASM.OpenSyncOption self=(WeChatWASM.OpenSyncOption)checkSelf(l);
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
	static public int get_flag(IntPtr l) {
		try {
			WeChatWASM.OpenSyncOption self=(WeChatWASM.OpenSyncOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.flag);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_flag(IntPtr l) {
		try {
			WeChatWASM.OpenSyncOption self=(WeChatWASM.OpenSyncOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.flag=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.OpenSyncOption");
		addMember(l,"filePath",get_filePath,set_filePath,true);
		addMember(l,"flag",get_flag,set_flag,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.OpenSyncOption));
	}
}
