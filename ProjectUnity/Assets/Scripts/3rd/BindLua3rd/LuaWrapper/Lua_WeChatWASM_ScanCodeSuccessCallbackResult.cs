//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_ScanCodeSuccessCallbackResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.ScanCodeSuccessCallbackResult o;
			o=new WeChatWASM.ScanCodeSuccessCallbackResult();
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
	static public int get_charSet(IntPtr l) {
		try {
			WeChatWASM.ScanCodeSuccessCallbackResult self=(WeChatWASM.ScanCodeSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.charSet);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_charSet(IntPtr l) {
		try {
			WeChatWASM.ScanCodeSuccessCallbackResult self=(WeChatWASM.ScanCodeSuccessCallbackResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.charSet=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_path(IntPtr l) {
		try {
			WeChatWASM.ScanCodeSuccessCallbackResult self=(WeChatWASM.ScanCodeSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.path);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_path(IntPtr l) {
		try {
			WeChatWASM.ScanCodeSuccessCallbackResult self=(WeChatWASM.ScanCodeSuccessCallbackResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.path=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_rawData(IntPtr l) {
		try {
			WeChatWASM.ScanCodeSuccessCallbackResult self=(WeChatWASM.ScanCodeSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rawData);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_rawData(IntPtr l) {
		try {
			WeChatWASM.ScanCodeSuccessCallbackResult self=(WeChatWASM.ScanCodeSuccessCallbackResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.rawData=v;
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
			WeChatWASM.ScanCodeSuccessCallbackResult self=(WeChatWASM.ScanCodeSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.result);
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
			WeChatWASM.ScanCodeSuccessCallbackResult self=(WeChatWASM.ScanCodeSuccessCallbackResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.result=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_scanType(IntPtr l) {
		try {
			WeChatWASM.ScanCodeSuccessCallbackResult self=(WeChatWASM.ScanCodeSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.scanType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_scanType(IntPtr l) {
		try {
			WeChatWASM.ScanCodeSuccessCallbackResult self=(WeChatWASM.ScanCodeSuccessCallbackResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.scanType=v;
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
			WeChatWASM.ScanCodeSuccessCallbackResult self=(WeChatWASM.ScanCodeSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.ScanCodeSuccessCallbackResult self=(WeChatWASM.ScanCodeSuccessCallbackResult)checkSelf(l);
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
		getTypeTable(l,"WeChatWASM.ScanCodeSuccessCallbackResult");
		addMember(l,"charSet",get_charSet,set_charSet,true);
		addMember(l,"path",get_path,set_path,true);
		addMember(l,"rawData",get_rawData,set_rawData,true);
		addMember(l,"result",get_result,set_result,true);
		addMember(l,"scanType",get_scanType,set_scanType,true);
		addMember(l,"errMsg",get_errMsg,set_errMsg,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.ScanCodeSuccessCallbackResult));
	}
}
