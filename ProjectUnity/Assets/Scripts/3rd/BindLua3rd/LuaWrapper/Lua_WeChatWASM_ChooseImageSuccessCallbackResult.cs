//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_ChooseImageSuccessCallbackResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.ChooseImageSuccessCallbackResult o;
			o=new WeChatWASM.ChooseImageSuccessCallbackResult();
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
	static public int get_tempFilePaths(IntPtr l) {
		try {
			WeChatWASM.ChooseImageSuccessCallbackResult self=(WeChatWASM.ChooseImageSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.tempFilePaths);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_tempFilePaths(IntPtr l) {
		try {
			WeChatWASM.ChooseImageSuccessCallbackResult self=(WeChatWASM.ChooseImageSuccessCallbackResult)checkSelf(l);
			System.String[] v;
			checkArray(l,2,out v);
			self.tempFilePaths=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_tempFiles(IntPtr l) {
		try {
			WeChatWASM.ChooseImageSuccessCallbackResult self=(WeChatWASM.ChooseImageSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.ChooseImageSuccessCallbackResult self=(WeChatWASM.ChooseImageSuccessCallbackResult)checkSelf(l);
			WeChatWASM.ImageFile[] v;
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
	static public int get_errMsg(IntPtr l) {
		try {
			WeChatWASM.ChooseImageSuccessCallbackResult self=(WeChatWASM.ChooseImageSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.ChooseImageSuccessCallbackResult self=(WeChatWASM.ChooseImageSuccessCallbackResult)checkSelf(l);
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
		getTypeTable(l,"WeChatWASM.ChooseImageSuccessCallbackResult");
		addMember(l,"tempFilePaths",get_tempFilePaths,set_tempFilePaths,true);
		addMember(l,"tempFiles",get_tempFiles,set_tempFiles,true);
		addMember(l,"errMsg",get_errMsg,set_errMsg,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.ChooseImageSuccessCallbackResult));
	}
}
