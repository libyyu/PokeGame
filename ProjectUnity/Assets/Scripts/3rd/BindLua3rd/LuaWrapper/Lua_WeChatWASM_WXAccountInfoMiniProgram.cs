//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXAccountInfoMiniProgram : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXAccountInfoMiniProgram o;
			o=new WeChatWASM.WXAccountInfoMiniProgram();
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
	static public int get_appId(IntPtr l) {
		try {
			WeChatWASM.WXAccountInfoMiniProgram self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.appId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_appId(IntPtr l) {
		try {
			WeChatWASM.WXAccountInfoMiniProgram self;
			checkValueType(l,1,out self);
			System.String v;
			checkType(l,2,out v);
			self.appId=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_envVersion(IntPtr l) {
		try {
			WeChatWASM.WXAccountInfoMiniProgram self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.envVersion);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_envVersion(IntPtr l) {
		try {
			WeChatWASM.WXAccountInfoMiniProgram self;
			checkValueType(l,1,out self);
			System.String v;
			checkType(l,2,out v);
			self.envVersion=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXAccountInfoMiniProgram");
		addMember(l,"appId",get_appId,set_appId,true);
		addMember(l,"envVersion",get_envVersion,set_envVersion,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXAccountInfoMiniProgram),typeof(System.ValueType));
	}
}
