//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_OnWindowResizeListenerResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.OnWindowResizeListenerResult o;
			o=new WeChatWASM.OnWindowResizeListenerResult();
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
	static public int get_windowHeight(IntPtr l) {
		try {
			WeChatWASM.OnWindowResizeListenerResult self=(WeChatWASM.OnWindowResizeListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.windowHeight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_windowHeight(IntPtr l) {
		try {
			WeChatWASM.OnWindowResizeListenerResult self=(WeChatWASM.OnWindowResizeListenerResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.windowHeight=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_windowWidth(IntPtr l) {
		try {
			WeChatWASM.OnWindowResizeListenerResult self=(WeChatWASM.OnWindowResizeListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.windowWidth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_windowWidth(IntPtr l) {
		try {
			WeChatWASM.OnWindowResizeListenerResult self=(WeChatWASM.OnWindowResizeListenerResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.windowWidth=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.OnWindowResizeListenerResult");
		addMember(l,"windowHeight",get_windowHeight,set_windowHeight,true);
		addMember(l,"windowWidth",get_windowWidth,set_windowWidth,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.OnWindowResizeListenerResult));
	}
}
