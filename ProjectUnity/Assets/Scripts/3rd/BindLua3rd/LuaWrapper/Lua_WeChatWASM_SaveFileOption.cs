//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_SaveFileOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.SaveFileOption o;
			o=new WeChatWASM.SaveFileOption();
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
	static public int get_tempFilePath(IntPtr l) {
		try {
			WeChatWASM.SaveFileOption self=(WeChatWASM.SaveFileOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.tempFilePath);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_tempFilePath(IntPtr l) {
		try {
			WeChatWASM.SaveFileOption self=(WeChatWASM.SaveFileOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.tempFilePath=v;
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
			WeChatWASM.SaveFileOption self=(WeChatWASM.SaveFileOption)checkSelf(l);
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
			WeChatWASM.SaveFileOption self=(WeChatWASM.SaveFileOption)checkSelf(l);
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
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.SaveFileOption");
		addMember(l,"tempFilePath",get_tempFilePath,set_tempFilePath,true);
		addMember(l,"filePath",get_filePath,set_filePath,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.SaveFileOption));
	}
}
