//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXAccountInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXAccountInfo o;
			o=new WeChatWASM.WXAccountInfo();
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
			WeChatWASM.WXAccountInfo self=(WeChatWASM.WXAccountInfo)checkSelf(l);
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
			WeChatWASM.WXAccountInfo self=(WeChatWASM.WXAccountInfo)checkSelf(l);
			WeChatWASM.WXAccountInfoMiniProgram v;
			checkValueType(l,2,out v);
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
	static public int get_miniProgramRaw(IntPtr l) {
		try {
			WeChatWASM.WXAccountInfo self=(WeChatWASM.WXAccountInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.miniProgramRaw);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_miniProgramRaw(IntPtr l) {
		try {
			WeChatWASM.WXAccountInfo self=(WeChatWASM.WXAccountInfo)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.miniProgramRaw=v;
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
			WeChatWASM.WXAccountInfo self=(WeChatWASM.WXAccountInfo)checkSelf(l);
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
			WeChatWASM.WXAccountInfo self=(WeChatWASM.WXAccountInfo)checkSelf(l);
			WeChatWASM.WXAccountInfoPlugin v;
			checkValueType(l,2,out v);
			self.plugin=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_pluginRaw(IntPtr l) {
		try {
			WeChatWASM.WXAccountInfo self=(WeChatWASM.WXAccountInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.pluginRaw);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_pluginRaw(IntPtr l) {
		try {
			WeChatWASM.WXAccountInfo self=(WeChatWASM.WXAccountInfo)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.pluginRaw=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXAccountInfo");
		addMember(l,"miniProgram",get_miniProgram,set_miniProgram,true);
		addMember(l,"miniProgramRaw",get_miniProgramRaw,set_miniProgramRaw,true);
		addMember(l,"plugin",get_plugin,set_plugin,true);
		addMember(l,"pluginRaw",get_pluginRaw,set_pluginRaw,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXAccountInfo),typeof(WeChatWASM.WXBaseResponse));
	}
}
