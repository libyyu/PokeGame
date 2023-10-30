//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_AppBaseInfoHost : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.AppBaseInfoHost o;
			o=new WeChatWASM.AppBaseInfoHost();
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
	static public int get_appId(IntPtr l) {
		try {
			WeChatWASM.AppBaseInfoHost self=(WeChatWASM.AppBaseInfoHost)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.appId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_appId(IntPtr l) {
		try {
			WeChatWASM.AppBaseInfoHost self=(WeChatWASM.AppBaseInfoHost)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.appId=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.AppBaseInfoHost");
		addMember(l,"appId",get_appId,set_appId,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.AppBaseInfoHost));
	}
}
