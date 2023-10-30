//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_GameLiveInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.GameLiveInfo o;
			o=new WeChatWASM.GameLiveInfo();
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
	static public int get_streamerOpenId(IntPtr l) {
		try {
			WeChatWASM.GameLiveInfo self=(WeChatWASM.GameLiveInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.streamerOpenId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_streamerOpenId(IntPtr l) {
		try {
			WeChatWASM.GameLiveInfo self=(WeChatWASM.GameLiveInfo)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.streamerOpenId=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_feedId(IntPtr l) {
		try {
			WeChatWASM.GameLiveInfo self=(WeChatWASM.GameLiveInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.feedId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_feedId(IntPtr l) {
		try {
			WeChatWASM.GameLiveInfo self=(WeChatWASM.GameLiveInfo)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.feedId=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.GameLiveInfo");
		addMember(l,"streamerOpenId",get_streamerOpenId,set_streamerOpenId,true);
		addMember(l,"feedId",get_feedId,set_feedId,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.GameLiveInfo));
	}
}
