//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_GetStorageInfoSyncOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.GetStorageInfoSyncOption o;
			o=new WeChatWASM.GetStorageInfoSyncOption();
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
			WeChatWASM.GetStorageInfoSyncOption self=(WeChatWASM.GetStorageInfoSyncOption)checkSelf(l);
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
			WeChatWASM.GetStorageInfoSyncOption self=(WeChatWASM.GetStorageInfoSyncOption)checkSelf(l);
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
			WeChatWASM.GetStorageInfoSyncOption self=(WeChatWASM.GetStorageInfoSyncOption)checkSelf(l);
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
			WeChatWASM.GetStorageInfoSyncOption self=(WeChatWASM.GetStorageInfoSyncOption)checkSelf(l);
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
			WeChatWASM.GetStorageInfoSyncOption self=(WeChatWASM.GetStorageInfoSyncOption)checkSelf(l);
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
			WeChatWASM.GetStorageInfoSyncOption self=(WeChatWASM.GetStorageInfoSyncOption)checkSelf(l);
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
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.GetStorageInfoSyncOption");
		addMember(l,"currentSize",get_currentSize,set_currentSize,true);
		addMember(l,"keys",get_keys,set_keys,true);
		addMember(l,"limitSize",get_limitSize,set_limitSize,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.GetStorageInfoSyncOption));
	}
}
