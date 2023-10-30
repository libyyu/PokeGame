//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_IWXAdResizable : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnResizeCallback(IntPtr l) {
		try {
			WeChatWASM.IWXAdResizable self=(WeChatWASM.IWXAdResizable)checkSelf(l);
			WeChatWASM.WXADResizeResponse a1 = default(WeChatWASM.WXADResizeResponse);
			checkType(l,2,out a1);
			self.OnResizeCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.IWXAdResizable");
		addMember(l,OnResizeCallback);
		createTypeMetatable(l,null, typeof(WeChatWASM.IWXAdResizable));
	}
}
