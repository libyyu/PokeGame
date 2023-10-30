//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXCanvas : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXCanvas o;
			o=new WeChatWASM.WXCanvas();
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
	static public int ToTempFilePathSync_s(IntPtr l) {
		try {
			WeChatWASM.WXToTempFilePathSyncParam a1 = default(WeChatWASM.WXToTempFilePathSyncParam);
			checkType(l,1,out a1);
			var ret=WeChatWASM.WXCanvas.ToTempFilePathSync(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ToTempFilePath_s(IntPtr l) {
		try {
			WeChatWASM.WXToTempFilePathParam a1 = default(WeChatWASM.WXToTempFilePathParam);
			checkType(l,1,out a1);
			WeChatWASM.WXCanvas.ToTempFilePath(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXCanvas");
		addMember(l,ToTempFilePathSync_s);
		addMember(l,ToTempFilePath_s);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXCanvas));
	}
}
