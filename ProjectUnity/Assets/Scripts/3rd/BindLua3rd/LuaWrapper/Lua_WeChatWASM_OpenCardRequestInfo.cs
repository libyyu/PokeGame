//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_OpenCardRequestInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.OpenCardRequestInfo o;
			o=new WeChatWASM.OpenCardRequestInfo();
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
	static public int get_cardId(IntPtr l) {
		try {
			WeChatWASM.OpenCardRequestInfo self=(WeChatWASM.OpenCardRequestInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.cardId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_cardId(IntPtr l) {
		try {
			WeChatWASM.OpenCardRequestInfo self=(WeChatWASM.OpenCardRequestInfo)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.cardId=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_code(IntPtr l) {
		try {
			WeChatWASM.OpenCardRequestInfo self=(WeChatWASM.OpenCardRequestInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.code);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_code(IntPtr l) {
		try {
			WeChatWASM.OpenCardRequestInfo self=(WeChatWASM.OpenCardRequestInfo)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.code=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.OpenCardRequestInfo");
		addMember(l,"cardId",get_cardId,set_cardId,true);
		addMember(l,"code",get_code,set_code,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.OpenCardRequestInfo));
	}
}
