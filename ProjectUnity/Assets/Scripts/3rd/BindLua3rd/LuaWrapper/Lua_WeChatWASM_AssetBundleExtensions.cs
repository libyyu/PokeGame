//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_AssetBundleExtensions : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WXUnload_s(IntPtr l) {
		try {
			UnityEngine.AssetBundle a1 = default(UnityEngine.AssetBundle);
			checkType(l,1,out a1);
			System.Boolean a2 = default(System.Boolean);
			checkType(l,2,out a2);
			WeChatWASM.AssetBundleExtensions.WXUnload(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.AssetBundleExtensions");
		addMember(l,WXUnload_s);
		createTypeMetatable(l,null, typeof(WeChatWASM.AssetBundleExtensions));
	}
}
