//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXADLoadResponse : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXADLoadResponse o;
			o=new WeChatWASM.WXADLoadResponse();
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
	static public int get_rewardValue(IntPtr l) {
		try {
			WeChatWASM.WXADLoadResponse self=(WeChatWASM.WXADLoadResponse)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rewardValue);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_rewardValue(IntPtr l) {
		try {
			WeChatWASM.WXADLoadResponse self=(WeChatWASM.WXADLoadResponse)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.rewardValue=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_shareValue(IntPtr l) {
		try {
			WeChatWASM.WXADLoadResponse self=(WeChatWASM.WXADLoadResponse)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.shareValue);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_shareValue(IntPtr l) {
		try {
			WeChatWASM.WXADLoadResponse self=(WeChatWASM.WXADLoadResponse)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.shareValue=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXADLoadResponse");
		addMember(l,"rewardValue",get_rewardValue,set_rewardValue,true);
		addMember(l,"shareValue",get_shareValue,set_shareValue,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXADLoadResponse),typeof(WeChatWASM.WXBaseResponse));
	}
}
