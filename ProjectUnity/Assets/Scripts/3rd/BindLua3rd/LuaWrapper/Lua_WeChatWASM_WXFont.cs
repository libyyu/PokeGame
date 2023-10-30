//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXFont : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXFont o;
			o=new WeChatWASM.WXFont();
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
	static public int GetFontData_s(IntPtr l) {
		try {
			WeChatWASM.GetFontParam a1 = default(WeChatWASM.GetFontParam);
			checkType(l,1,out a1);
			WeChatWASM.WXFont.GetFontData(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int HandleGetFontRawDataCallback_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			WeChatWASM.WXFont.HandleGetFontRawDataCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXFont");
		addMember(l,GetFontData_s);
		addMember(l,HandleGetFontRawDataCallback_s);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXFont));
	}
}
