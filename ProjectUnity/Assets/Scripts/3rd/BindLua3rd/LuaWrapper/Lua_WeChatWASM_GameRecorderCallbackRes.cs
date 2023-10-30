//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_GameRecorderCallbackRes : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.GameRecorderCallbackRes o;
			o=new WeChatWASM.GameRecorderCallbackRes();
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
	static public int get_currentTime(IntPtr l) {
		try {
			WeChatWASM.GameRecorderCallbackRes self=(WeChatWASM.GameRecorderCallbackRes)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.currentTime);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_currentTime(IntPtr l) {
		try {
			WeChatWASM.GameRecorderCallbackRes self=(WeChatWASM.GameRecorderCallbackRes)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.currentTime=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_code(IntPtr l) {
		try {
			WeChatWASM.GameRecorderCallbackRes self=(WeChatWASM.GameRecorderCallbackRes)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.code);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_code(IntPtr l) {
		try {
			WeChatWASM.GameRecorderCallbackRes self=(WeChatWASM.GameRecorderCallbackRes)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.code=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_message(IntPtr l) {
		try {
			WeChatWASM.GameRecorderCallbackRes self=(WeChatWASM.GameRecorderCallbackRes)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.message);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_message(IntPtr l) {
		try {
			WeChatWASM.GameRecorderCallbackRes self=(WeChatWASM.GameRecorderCallbackRes)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.message=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_duration(IntPtr l) {
		try {
			WeChatWASM.GameRecorderCallbackRes self=(WeChatWASM.GameRecorderCallbackRes)checkSelf(l);
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
			WeChatWASM.GameRecorderCallbackRes self=(WeChatWASM.GameRecorderCallbackRes)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.duration=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.GameRecorderCallbackRes");
		addMember(l,"currentTime",get_currentTime,set_currentTime,true);
		addMember(l,"code",get_code,set_code,true);
		addMember(l,"message",get_message,set_message,true);
		addMember(l,"duration",get_duration,set_duration,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.GameRecorderCallbackRes));
	}
}
