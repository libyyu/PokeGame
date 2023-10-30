//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_ToTempFilePathParamSuccessCallbackResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.ToTempFilePathParamSuccessCallbackResult o;
			o=new WeChatWASM.ToTempFilePathParamSuccessCallbackResult();
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
	static public int get_tempFilePath(IntPtr l) {
		try {
			WeChatWASM.ToTempFilePathParamSuccessCallbackResult self=(WeChatWASM.ToTempFilePathParamSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.tempFilePath);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_tempFilePath(IntPtr l) {
		try {
			WeChatWASM.ToTempFilePathParamSuccessCallbackResult self=(WeChatWASM.ToTempFilePathParamSuccessCallbackResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.tempFilePath=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.ToTempFilePathParamSuccessCallbackResult");
		addMember(l,"tempFilePath",get_tempFilePath,set_tempFilePath,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.ToTempFilePathParamSuccessCallbackResult),typeof(WeChatWASM.WXBaseResponse));
	}
}
