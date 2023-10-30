//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_ReserveChannelsLiveOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.ReserveChannelsLiveOption o;
			o=new WeChatWASM.ReserveChannelsLiveOption();
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
	static public int get_noticeId(IntPtr l) {
		try {
			WeChatWASM.ReserveChannelsLiveOption self=(WeChatWASM.ReserveChannelsLiveOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.noticeId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_noticeId(IntPtr l) {
		try {
			WeChatWASM.ReserveChannelsLiveOption self=(WeChatWASM.ReserveChannelsLiveOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.noticeId=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.ReserveChannelsLiveOption");
		addMember(l,"noticeId",get_noticeId,set_noticeId,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.ReserveChannelsLiveOption));
	}
}
