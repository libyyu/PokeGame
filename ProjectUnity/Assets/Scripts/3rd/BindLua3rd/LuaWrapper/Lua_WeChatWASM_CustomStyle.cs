//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_CustomStyle : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.CustomStyle o;
			o=new WeChatWASM.CustomStyle();
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
			WeChatWASM.CustomStyle self;
			checkValueType(l,1,out self);
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
			WeChatWASM.CustomStyle self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.left=v;
			setBack(l,self);
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
			WeChatWASM.CustomStyle self;
			checkValueType(l,1,out self);
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
			WeChatWASM.CustomStyle self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.top=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.CustomStyle");
		addMember(l,"left",get_left,set_left,true);
		addMember(l,"top",get_top,set_top,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.CustomStyle),typeof(System.ValueType));
	}
}
