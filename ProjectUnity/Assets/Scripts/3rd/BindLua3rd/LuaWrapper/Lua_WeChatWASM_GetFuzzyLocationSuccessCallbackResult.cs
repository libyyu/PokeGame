﻿//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_GetFuzzyLocationSuccessCallbackResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.GetFuzzyLocationSuccessCallbackResult o;
			o=new WeChatWASM.GetFuzzyLocationSuccessCallbackResult();
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
	static public int get_latitude(IntPtr l) {
		try {
			WeChatWASM.GetFuzzyLocationSuccessCallbackResult self=(WeChatWASM.GetFuzzyLocationSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.latitude);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_latitude(IntPtr l) {
		try {
			WeChatWASM.GetFuzzyLocationSuccessCallbackResult self=(WeChatWASM.GetFuzzyLocationSuccessCallbackResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.latitude=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_longitude(IntPtr l) {
		try {
			WeChatWASM.GetFuzzyLocationSuccessCallbackResult self=(WeChatWASM.GetFuzzyLocationSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.longitude);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_longitude(IntPtr l) {
		try {
			WeChatWASM.GetFuzzyLocationSuccessCallbackResult self=(WeChatWASM.GetFuzzyLocationSuccessCallbackResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.longitude=v;
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
			WeChatWASM.GetFuzzyLocationSuccessCallbackResult self=(WeChatWASM.GetFuzzyLocationSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.GetFuzzyLocationSuccessCallbackResult self=(WeChatWASM.GetFuzzyLocationSuccessCallbackResult)checkSelf(l);
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
		getTypeTable(l,"WeChatWASM.GetFuzzyLocationSuccessCallbackResult");
		addMember(l,"latitude",get_latitude,set_latitude,true);
		addMember(l,"longitude",get_longitude,set_longitude,true);
		addMember(l,"errMsg",get_errMsg,set_errMsg,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.GetFuzzyLocationSuccessCallbackResult));
	}
}