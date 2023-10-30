//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXSDKManagerHandler_WXProfileStatsScript : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetProfileStatsDatas(IntPtr l) {
		try {
			WeChatWASM.WXSDKManagerHandler.WXProfileStatsScript self=(WeChatWASM.WXSDKManagerHandler.WXProfileStatsScript)checkSelf(l);
			var ret=self.GetProfileStatsDatas();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXSDKManagerHandler.WXProfileStatsScript");
		addMember(l,GetProfileStatsDatas);
		createTypeMetatable(l,null, typeof(WeChatWASM.WXSDKManagerHandler.WXProfileStatsScript));
	}
}
