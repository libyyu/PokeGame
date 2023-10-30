//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_OnStopCallbackResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.OnStopCallbackResult o;
			o=new WeChatWASM.OnStopCallbackResult();
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
	static public int get_duration(IntPtr l) {
		try {
			WeChatWASM.OnStopCallbackResult self=(WeChatWASM.OnStopCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.duration);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_duration(IntPtr l) {
		try {
			WeChatWASM.OnStopCallbackResult self=(WeChatWASM.OnStopCallbackResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.duration=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_fileSize(IntPtr l) {
		try {
			WeChatWASM.OnStopCallbackResult self=(WeChatWASM.OnStopCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.fileSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_fileSize(IntPtr l) {
		try {
			WeChatWASM.OnStopCallbackResult self=(WeChatWASM.OnStopCallbackResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.fileSize=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_tempFilePath(IntPtr l) {
		try {
			WeChatWASM.OnStopCallbackResult self=(WeChatWASM.OnStopCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.tempFilePath);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_tempFilePath(IntPtr l) {
		try {
			WeChatWASM.OnStopCallbackResult self=(WeChatWASM.OnStopCallbackResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.tempFilePath=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.OnStopCallbackResult");
		addMember(l,"duration",get_duration,set_duration,true);
		addMember(l,"fileSize",get_fileSize,set_fileSize,true);
		addMember(l,"tempFilePath",get_tempFilePath,set_tempFilePath,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.OnStopCallbackResult));
	}
}
