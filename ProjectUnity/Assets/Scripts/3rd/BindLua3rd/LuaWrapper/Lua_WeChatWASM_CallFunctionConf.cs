//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_CallFunctionConf : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.CallFunctionConf o;
			o=new WeChatWASM.CallFunctionConf();
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
	static public int get_env(IntPtr l) {
		try {
			WeChatWASM.CallFunctionConf self=(WeChatWASM.CallFunctionConf)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.env);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_env(IntPtr l) {
		try {
			WeChatWASM.CallFunctionConf self=(WeChatWASM.CallFunctionConf)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.env=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.CallFunctionConf");
		addMember(l,"env",get_env,set_env,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.CallFunctionConf));
	}
}
