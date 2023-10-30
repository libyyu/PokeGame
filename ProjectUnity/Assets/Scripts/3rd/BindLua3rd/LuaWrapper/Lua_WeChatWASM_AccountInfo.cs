//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_AccountInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.AccountInfo o;
			o=new WeChatWASM.AccountInfo();
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
	static public int get_miniProgram(IntPtr l) {
		try {
			WeChatWASM.AccountInfo self=(WeChatWASM.AccountInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.miniProgram);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_miniProgram(IntPtr l) {
		try {
			WeChatWASM.AccountInfo self=(WeChatWASM.AccountInfo)checkSelf(l);
			WeChatWASM.MiniProgram v;
			checkType(l,2,out v);
			self.miniProgram=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_plugin(IntPtr l) {
		try {
			WeChatWASM.AccountInfo self=(WeChatWASM.AccountInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.plugin);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_plugin(IntPtr l) {
		try {
			WeChatWASM.AccountInfo self=(WeChatWASM.AccountInfo)checkSelf(l);
			WeChatWASM.Plugin v;
			checkType(l,2,out v);
			self.plugin=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.AccountInfo");
		addMember(l,"miniProgram",get_miniProgram,set_miniProgram,true);
		addMember(l,"plugin",get_plugin,set_plugin,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.AccountInfo));
	}
}
