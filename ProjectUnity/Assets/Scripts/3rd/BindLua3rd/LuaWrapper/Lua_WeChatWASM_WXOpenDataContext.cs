//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXOpenDataContext : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXOpenDataContext o;
			o=new WeChatWASM.WXOpenDataContext();
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
	static public int PostMessage(IntPtr l) {
		try {
			WeChatWASM.WXOpenDataContext self=(WeChatWASM.WXOpenDataContext)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.PostMessage(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXOpenDataContext");
		addMember(l,PostMessage);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXOpenDataContext));
	}
}
