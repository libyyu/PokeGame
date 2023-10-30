//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_ReferrerInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.ReferrerInfo o;
			o=new WeChatWASM.ReferrerInfo();
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
	static public int get_appid(IntPtr l) {
		try {
			WeChatWASM.ReferrerInfo self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.appid);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_appid(IntPtr l) {
		try {
			WeChatWASM.ReferrerInfo self;
			checkValueType(l,1,out self);
			System.String v;
			checkType(l,2,out v);
			self.appid=v;
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
	static public int get_extraDataRaw(IntPtr l) {
		try {
			WeChatWASM.ReferrerInfo self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.extraDataRaw);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_extraDataRaw(IntPtr l) {
		try {
			WeChatWASM.ReferrerInfo self;
			checkValueType(l,1,out self);
			System.String v;
			checkType(l,2,out v);
			self.extraDataRaw=v;
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
		getTypeTable(l,"WeChatWASM.ReferrerInfo");
		addMember(l,"appid",get_appid,set_appid,true);
		addMember(l,"extraDataRaw",get_extraDataRaw,set_extraDataRaw,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.ReferrerInfo),typeof(System.ValueType));
	}
}
