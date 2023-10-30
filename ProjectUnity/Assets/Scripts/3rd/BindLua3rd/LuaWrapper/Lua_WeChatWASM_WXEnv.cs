//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXEnv : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXEnv o;
			o=new WeChatWASM.WXEnv();
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
	static public int get_USER_DATA_PATH(IntPtr l) {
		try {
			WeChatWASM.WXEnv self=(WeChatWASM.WXEnv)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.USER_DATA_PATH);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXEnv");
		addMember(l,"USER_DATA_PATH",get_USER_DATA_PATH,null,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXEnv));
	}
}
