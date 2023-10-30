//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_ChooseMediaSuccessCallbackResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.ChooseMediaSuccessCallbackResult o;
			o=new WeChatWASM.ChooseMediaSuccessCallbackResult();
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
	static public int get_tempFiles(IntPtr l) {
		try {
			WeChatWASM.ChooseMediaSuccessCallbackResult self=(WeChatWASM.ChooseMediaSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.tempFiles);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_tempFiles(IntPtr l) {
		try {
			WeChatWASM.ChooseMediaSuccessCallbackResult self=(WeChatWASM.ChooseMediaSuccessCallbackResult)checkSelf(l);
			WeChatWASM.MediaFile[] v;
			checkArray(l,2,out v);
			self.tempFiles=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_type(IntPtr l) {
		try {
			WeChatWASM.ChooseMediaSuccessCallbackResult self=(WeChatWASM.ChooseMediaSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.type);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_type(IntPtr l) {
		try {
			WeChatWASM.ChooseMediaSuccessCallbackResult self=(WeChatWASM.ChooseMediaSuccessCallbackResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.type=v;
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
			WeChatWASM.ChooseMediaSuccessCallbackResult self=(WeChatWASM.ChooseMediaSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.ChooseMediaSuccessCallbackResult self=(WeChatWASM.ChooseMediaSuccessCallbackResult)checkSelf(l);
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
		getTypeTable(l,"WeChatWASM.ChooseMediaSuccessCallbackResult");
		addMember(l,"tempFiles",get_tempFiles,set_tempFiles,true);
		addMember(l,"type",get_type,set_type,true);
		addMember(l,"errMsg",get_errMsg,set_errMsg,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.ChooseMediaSuccessCallbackResult));
	}
}
