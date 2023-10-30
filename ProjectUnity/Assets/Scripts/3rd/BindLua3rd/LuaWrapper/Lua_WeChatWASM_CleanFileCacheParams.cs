//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_CleanFileCacheParams : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.CleanFileCacheParams o;
			o=new WeChatWASM.CleanFileCacheParams();
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
	static public int get_callbackId(IntPtr l) {
		try {
			WeChatWASM.CleanFileCacheParams self=(WeChatWASM.CleanFileCacheParams)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.callbackId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_callbackId(IntPtr l) {
		try {
			WeChatWASM.CleanFileCacheParams self=(WeChatWASM.CleanFileCacheParams)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.callbackId=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_result(IntPtr l) {
		try {
			WeChatWASM.CleanFileCacheParams self=(WeChatWASM.CleanFileCacheParams)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.result);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_result(IntPtr l) {
		try {
			WeChatWASM.CleanFileCacheParams self=(WeChatWASM.CleanFileCacheParams)checkSelf(l);
			WeChatWASM.ReleaseResult v;
			checkEnum(l,2,out v);
			self.result=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.CleanFileCacheParams");
		addMember(l,"callbackId",get_callbackId,set_callbackId,true);
		addMember(l,"result",get_result,set_result,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.CleanFileCacheParams));
	}
}
