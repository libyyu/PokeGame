//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_RenameOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.RenameOption o;
			o=new WeChatWASM.RenameOption();
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
	static public int get_newPath(IntPtr l) {
		try {
			WeChatWASM.RenameOption self=(WeChatWASM.RenameOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.newPath);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_newPath(IntPtr l) {
		try {
			WeChatWASM.RenameOption self=(WeChatWASM.RenameOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.newPath=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_oldPath(IntPtr l) {
		try {
			WeChatWASM.RenameOption self=(WeChatWASM.RenameOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.oldPath);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_oldPath(IntPtr l) {
		try {
			WeChatWASM.RenameOption self=(WeChatWASM.RenameOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.oldPath=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.RenameOption");
		addMember(l,"newPath",get_newPath,set_newPath,true);
		addMember(l,"oldPath",get_oldPath,set_oldPath,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.RenameOption));
	}
}
