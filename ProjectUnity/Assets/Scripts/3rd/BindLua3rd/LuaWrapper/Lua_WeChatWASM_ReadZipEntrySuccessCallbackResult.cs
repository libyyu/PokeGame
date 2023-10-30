//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_ReadZipEntrySuccessCallbackResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.ReadZipEntrySuccessCallbackResult o;
			o=new WeChatWASM.ReadZipEntrySuccessCallbackResult();
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
	static public int get_entries(IntPtr l) {
		try {
			WeChatWASM.ReadZipEntrySuccessCallbackResult self=(WeChatWASM.ReadZipEntrySuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.entries);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_entries(IntPtr l) {
		try {
			WeChatWASM.ReadZipEntrySuccessCallbackResult self=(WeChatWASM.ReadZipEntrySuccessCallbackResult)checkSelf(l);
			WeChatWASM.EntriesResult v;
			checkType(l,2,out v);
			self.entries=v;
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
			WeChatWASM.ReadZipEntrySuccessCallbackResult self=(WeChatWASM.ReadZipEntrySuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.ReadZipEntrySuccessCallbackResult self=(WeChatWASM.ReadZipEntrySuccessCallbackResult)checkSelf(l);
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
		getTypeTable(l,"WeChatWASM.ReadZipEntrySuccessCallbackResult");
		addMember(l,"entries",get_entries,set_entries,true);
		addMember(l,"errMsg",get_errMsg,set_errMsg,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.ReadZipEntrySuccessCallbackResult));
	}
}
