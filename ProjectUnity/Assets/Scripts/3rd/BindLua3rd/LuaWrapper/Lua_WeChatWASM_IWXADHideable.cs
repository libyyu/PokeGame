//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_IWXADHideable : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnHideCallback(IntPtr l) {
		try {
			WeChatWASM.IWXADHideable self=(WeChatWASM.IWXADHideable)checkSelf(l);
			self.OnHideCallback();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.IWXADHideable");
		addMember(l,OnHideCallback);
		createTypeMetatable(l,null, typeof(WeChatWASM.IWXADHideable));
	}
}
