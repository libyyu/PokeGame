//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_GetStorageInfoSuccessCallbackOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.GetStorageInfoSuccessCallbackOption o;
			o=new WeChatWASM.GetStorageInfoSuccessCallbackOption();
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
	static public int get_currentSize(IntPtr l) {
		try {
			WeChatWASM.GetStorageInfoSuccessCallbackOption self=(WeChatWASM.GetStorageInfoSuccessCallbackOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.currentSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_currentSize(IntPtr l) {
		try {
			WeChatWASM.GetStorageInfoSuccessCallbackOption self=(WeChatWASM.GetStorageInfoSuccessCallbackOption)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.currentSize=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_keys(IntPtr l) {
		try {
			WeChatWASM.GetStorageInfoSuccessCallbackOption self=(WeChatWASM.GetStorageInfoSuccessCallbackOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.keys);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_keys(IntPtr l) {
		try {
			WeChatWASM.GetStorageInfoSuccessCallbackOption self=(WeChatWASM.GetStorageInfoSuccessCallbackOption)checkSelf(l);
			System.String[] v;
			checkArray(l,2,out v);
			self.keys=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_limitSize(IntPtr l) {
		try {
			WeChatWASM.GetStorageInfoSuccessCallbackOption self=(WeChatWASM.GetStorageInfoSuccessCallbackOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.limitSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_limitSize(IntPtr l) {
		try {
			WeChatWASM.GetStorageInfoSuccessCallbackOption self=(WeChatWASM.GetStorageInfoSuccessCallbackOption)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.limitSize=v;
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
			WeChatWASM.GetStorageInfoSuccessCallbackOption self=(WeChatWASM.GetStorageInfoSuccessCallbackOption)checkSelf(l);
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
			WeChatWASM.GetStorageInfoSuccessCallbackOption self=(WeChatWASM.GetStorageInfoSuccessCallbackOption)checkSelf(l);
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
		getTypeTable(l,"WeChatWASM.GetStorageInfoSuccessCallbackOption");
		addMember(l,"currentSize",get_currentSize,set_currentSize,true);
		addMember(l,"keys",get_keys,set_keys,true);
		addMember(l,"limitSize",get_limitSize,set_limitSize,true);
		addMember(l,"errMsg",get_errMsg,set_errMsg,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.GetStorageInfoSuccessCallbackOption));
	}
}
