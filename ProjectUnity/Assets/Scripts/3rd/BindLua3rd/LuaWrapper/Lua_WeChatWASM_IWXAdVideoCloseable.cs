//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_IWXAdVideoCloseable : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnCloseCallback(IntPtr l) {
		try {
			WeChatWASM.IWXAdVideoCloseable self=(WeChatWASM.IWXAdVideoCloseable)checkSelf(l);
			WeChatWASM.WXRewardedVideoAdOnCloseResponse a1 = default(WeChatWASM.WXRewardedVideoAdOnCloseResponse);
			checkType(l,2,out a1);
			self.OnCloseCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.IWXAdVideoCloseable");
		addMember(l,OnCloseCallback);
		createTypeMetatable(l,null, typeof(WeChatWASM.IWXAdVideoCloseable));
	}
}
