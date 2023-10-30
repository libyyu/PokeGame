//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_ReaddirOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.ReaddirOption o;
			o=new WeChatWASM.ReaddirOption();
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
			WeChatWASM.ReaddirOption self=(WeChatWASM.ReaddirOption)checkSelf(l);
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
			WeChatWASM.ReaddirOption self=(WeChatWASM.ReaddirOption)checkSelf(l);
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
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.ReaddirOption");
		addMember(l,"dirPath",get_dirPath,set_dirPath,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.ReaddirOption));
	}
}
