//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_IWXADCloseable : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnCloseCallback(IntPtr l) {
		try {
			WeChatWASM.IWXADCloseable self=(WeChatWASM.IWXADCloseable)checkSelf(l);
			self.OnCloseCallback();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.IWXADCloseable");
		addMember(l,OnCloseCallback);
		createTypeMetatable(l,null, typeof(WeChatWASM.IWXADCloseable));
	}
}
