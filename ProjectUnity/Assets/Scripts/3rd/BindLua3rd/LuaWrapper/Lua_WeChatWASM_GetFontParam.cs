//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_GetFontParam : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.GetFontParam o;
			o=new WeChatWASM.GetFontParam();
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
	static public int get_fallbackUrl(IntPtr l) {
		try {
			WeChatWASM.GetFontParam self=(WeChatWASM.GetFontParam)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.fallbackUrl);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_fallbackUrl(IntPtr l) {
		try {
			WeChatWASM.GetFontParam self=(WeChatWASM.GetFontParam)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.fallbackUrl=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.GetFontParam");
		addMember(l,"fallbackUrl",get_fallbackUrl,set_fallbackUrl,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.GetFontParam));
	}
}
