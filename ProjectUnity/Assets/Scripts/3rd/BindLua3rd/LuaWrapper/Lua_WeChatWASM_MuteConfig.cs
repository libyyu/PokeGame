//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_MuteConfig : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.MuteConfig o;
			o=new WeChatWASM.MuteConfig();
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
	static public int get_muteEarphone(IntPtr l) {
		try {
			WeChatWASM.MuteConfig self=(WeChatWASM.MuteConfig)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.muteEarphone);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_muteEarphone(IntPtr l) {
		try {
			WeChatWASM.MuteConfig self=(WeChatWASM.MuteConfig)checkSelf(l);
			System.Nullable<System.Boolean> v;
			checkNullable(l,2,out v);
			self.muteEarphone=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_muteMicrophone(IntPtr l) {
		try {
			WeChatWASM.MuteConfig self=(WeChatWASM.MuteConfig)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.muteMicrophone);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_muteMicrophone(IntPtr l) {
		try {
			WeChatWASM.MuteConfig self=(WeChatWASM.MuteConfig)checkSelf(l);
			System.Nullable<System.Boolean> v;
			checkNullable(l,2,out v);
			self.muteMicrophone=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.MuteConfig");
		addMember(l,"muteEarphone",get_muteEarphone,set_muteEarphone,true);
		addMember(l,"muteMicrophone",get_muteMicrophone,set_muteMicrophone,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.MuteConfig));
	}
}
