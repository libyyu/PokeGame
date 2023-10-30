//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_OnMouseDownListenerResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.OnMouseDownListenerResult o;
			o=new WeChatWASM.OnMouseDownListenerResult();
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
	static public int get_button(IntPtr l) {
		try {
			WeChatWASM.OnMouseDownListenerResult self=(WeChatWASM.OnMouseDownListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.button);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_button(IntPtr l) {
		try {
			WeChatWASM.OnMouseDownListenerResult self=(WeChatWASM.OnMouseDownListenerResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.button=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_timeStamp(IntPtr l) {
		try {
			WeChatWASM.OnMouseDownListenerResult self=(WeChatWASM.OnMouseDownListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.timeStamp);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_timeStamp(IntPtr l) {
		try {
			WeChatWASM.OnMouseDownListenerResult self=(WeChatWASM.OnMouseDownListenerResult)checkSelf(l);
			System.Int64 v;
			checkType(l,2,out v);
			self.timeStamp=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_x(IntPtr l) {
		try {
			WeChatWASM.OnMouseDownListenerResult self=(WeChatWASM.OnMouseDownListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.x);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_x(IntPtr l) {
		try {
			WeChatWASM.OnMouseDownListenerResult self=(WeChatWASM.OnMouseDownListenerResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.x=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_y(IntPtr l) {
		try {
			WeChatWASM.OnMouseDownListenerResult self=(WeChatWASM.OnMouseDownListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.y);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_y(IntPtr l) {
		try {
			WeChatWASM.OnMouseDownListenerResult self=(WeChatWASM.OnMouseDownListenerResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.y=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.OnMouseDownListenerResult");
		addMember(l,"button",get_button,set_button,true);
		addMember(l,"timeStamp",get_timeStamp,set_timeStamp,true);
		addMember(l,"x",get_x,set_x,true);
		addMember(l,"y",get_y,set_y,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.OnMouseDownListenerResult));
	}
}
