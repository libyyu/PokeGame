//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXAdBaseStyle : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXAdBaseStyle o;
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			WeChatWASM.Style a2 = default(WeChatWASM.Style);
			checkValueType(l,3,out a2);
			o=new WeChatWASM.WXAdBaseStyle(a1,a2);
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
	static public int get_left(IntPtr l) {
		try {
			WeChatWASM.WXAdBaseStyle self=(WeChatWASM.WXAdBaseStyle)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.left);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_left(IntPtr l) {
		try {
			WeChatWASM.WXAdBaseStyle self=(WeChatWASM.WXAdBaseStyle)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.left=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_top(IntPtr l) {
		try {
			WeChatWASM.WXAdBaseStyle self=(WeChatWASM.WXAdBaseStyle)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.top);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_top(IntPtr l) {
		try {
			WeChatWASM.WXAdBaseStyle self=(WeChatWASM.WXAdBaseStyle)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.top=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_width(IntPtr l) {
		try {
			WeChatWASM.WXAdBaseStyle self=(WeChatWASM.WXAdBaseStyle)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.width);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_width(IntPtr l) {
		try {
			WeChatWASM.WXAdBaseStyle self=(WeChatWASM.WXAdBaseStyle)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.width=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_height(IntPtr l) {
		try {
			WeChatWASM.WXAdBaseStyle self=(WeChatWASM.WXAdBaseStyle)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.height);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_height(IntPtr l) {
		try {
			WeChatWASM.WXAdBaseStyle self=(WeChatWASM.WXAdBaseStyle)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.height=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_realHeight(IntPtr l) {
		try {
			WeChatWASM.WXAdBaseStyle self=(WeChatWASM.WXAdBaseStyle)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.realHeight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_realWidth(IntPtr l) {
		try {
			WeChatWASM.WXAdBaseStyle self=(WeChatWASM.WXAdBaseStyle)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.realWidth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXAdBaseStyle");
		addMember(l,"left",get_left,set_left,true);
		addMember(l,"top",get_top,set_top,true);
		addMember(l,"width",get_width,set_width,true);
		addMember(l,"height",get_height,set_height,true);
		addMember(l,"realHeight",get_realHeight,null,true);
		addMember(l,"realWidth",get_realWidth,null,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXAdBaseStyle));
	}
}
