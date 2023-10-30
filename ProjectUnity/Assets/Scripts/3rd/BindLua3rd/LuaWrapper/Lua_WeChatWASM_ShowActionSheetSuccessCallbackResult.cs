//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_ShowActionSheetSuccessCallbackResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.ShowActionSheetSuccessCallbackResult o;
			o=new WeChatWASM.ShowActionSheetSuccessCallbackResult();
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
	static public int get_tapIndex(IntPtr l) {
		try {
			WeChatWASM.ShowActionSheetSuccessCallbackResult self=(WeChatWASM.ShowActionSheetSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.tapIndex);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_tapIndex(IntPtr l) {
		try {
			WeChatWASM.ShowActionSheetSuccessCallbackResult self=(WeChatWASM.ShowActionSheetSuccessCallbackResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.tapIndex=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_errMsg(IntPtr l) {
		try {
			WeChatWASM.ShowActionSheetSuccessCallbackResult self=(WeChatWASM.ShowActionSheetSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.errMsg);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_errMsg(IntPtr l) {
		try {
			WeChatWASM.ShowActionSheetSuccessCallbackResult self=(WeChatWASM.ShowActionSheetSuccessCallbackResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.errMsg=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.ShowActionSheetSuccessCallbackResult");
		addMember(l,"tapIndex",get_tapIndex,set_tapIndex,true);
		addMember(l,"errMsg",get_errMsg,set_errMsg,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.ShowActionSheetSuccessCallbackResult));
	}
}
