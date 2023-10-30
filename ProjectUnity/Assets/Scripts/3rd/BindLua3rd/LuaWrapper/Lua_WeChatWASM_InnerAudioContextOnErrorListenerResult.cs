//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_InnerAudioContextOnErrorListenerResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.InnerAudioContextOnErrorListenerResult o;
			o=new WeChatWASM.InnerAudioContextOnErrorListenerResult();
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
	static public int get_errCode(IntPtr l) {
		try {
			WeChatWASM.InnerAudioContextOnErrorListenerResult self=(WeChatWASM.InnerAudioContextOnErrorListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.errCode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_errCode(IntPtr l) {
		try {
			WeChatWASM.InnerAudioContextOnErrorListenerResult self=(WeChatWASM.InnerAudioContextOnErrorListenerResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.errCode=v;
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
			WeChatWASM.InnerAudioContextOnErrorListenerResult self=(WeChatWASM.InnerAudioContextOnErrorListenerResult)checkSelf(l);
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
			WeChatWASM.InnerAudioContextOnErrorListenerResult self=(WeChatWASM.InnerAudioContextOnErrorListenerResult)checkSelf(l);
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
		getTypeTable(l,"WeChatWASM.InnerAudioContextOnErrorListenerResult");
		addMember(l,"errCode",get_errCode,set_errCode,true);
		addMember(l,"errMsg",get_errMsg,set_errMsg,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.InnerAudioContextOnErrorListenerResult));
	}
}
