//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_GetAvailableAudioSourcesSuccessCallbackResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.GetAvailableAudioSourcesSuccessCallbackResult o;
			o=new WeChatWASM.GetAvailableAudioSourcesSuccessCallbackResult();
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
	static public int get_audioSources(IntPtr l) {
		try {
			WeChatWASM.GetAvailableAudioSourcesSuccessCallbackResult self=(WeChatWASM.GetAvailableAudioSourcesSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.audioSources);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_audioSources(IntPtr l) {
		try {
			WeChatWASM.GetAvailableAudioSourcesSuccessCallbackResult self=(WeChatWASM.GetAvailableAudioSourcesSuccessCallbackResult)checkSelf(l);
			System.Array v;
			checkType(l,2,out v);
			self.audioSources=v;
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
			WeChatWASM.GetAvailableAudioSourcesSuccessCallbackResult self=(WeChatWASM.GetAvailableAudioSourcesSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.GetAvailableAudioSourcesSuccessCallbackResult self=(WeChatWASM.GetAvailableAudioSourcesSuccessCallbackResult)checkSelf(l);
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
		getTypeTable(l,"WeChatWASM.GetAvailableAudioSourcesSuccessCallbackResult");
		addMember(l,"audioSources",get_audioSources,set_audioSources,true);
		addMember(l,"errMsg",get_errMsg,set_errMsg,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.GetAvailableAudioSourcesSuccessCallbackResult));
	}
}
