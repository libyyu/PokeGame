//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXRewardedVideoAdOnCloseResponse : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXRewardedVideoAdOnCloseResponse o;
			o=new WeChatWASM.WXRewardedVideoAdOnCloseResponse();
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
	static public int get_isEnded(IntPtr l) {
		try {
			WeChatWASM.WXRewardedVideoAdOnCloseResponse self=(WeChatWASM.WXRewardedVideoAdOnCloseResponse)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isEnded);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_isEnded(IntPtr l) {
		try {
			WeChatWASM.WXRewardedVideoAdOnCloseResponse self=(WeChatWASM.WXRewardedVideoAdOnCloseResponse)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.isEnded=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXRewardedVideoAdOnCloseResponse");
		addMember(l,"isEnded",get_isEnded,set_isEnded,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXRewardedVideoAdOnCloseResponse),typeof(WeChatWASM.WXBaseResponse));
	}
}
