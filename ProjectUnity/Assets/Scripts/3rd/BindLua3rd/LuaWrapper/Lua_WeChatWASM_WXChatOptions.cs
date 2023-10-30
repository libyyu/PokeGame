//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXChatOptions : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXChatOptions o;
			o=new WeChatWASM.WXChatOptions();
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
	static public int get_x(IntPtr l) {
		try {
			WeChatWASM.WXChatOptions self=(WeChatWASM.WXChatOptions)checkSelf(l);
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
			WeChatWASM.WXChatOptions self=(WeChatWASM.WXChatOptions)checkSelf(l);
			System.Nullable<System.Int32> v;
			checkNullable(l,2,out v);
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
			WeChatWASM.WXChatOptions self=(WeChatWASM.WXChatOptions)checkSelf(l);
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
			WeChatWASM.WXChatOptions self=(WeChatWASM.WXChatOptions)checkSelf(l);
			System.Nullable<System.Int32> v;
			checkNullable(l,2,out v);
			self.y=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_logoUrl(IntPtr l) {
		try {
			WeChatWASM.WXChatOptions self=(WeChatWASM.WXChatOptions)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.logoUrl);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_logoUrl(IntPtr l) {
		try {
			WeChatWASM.WXChatOptions self=(WeChatWASM.WXChatOptions)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.logoUrl=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_movable(IntPtr l) {
		try {
			WeChatWASM.WXChatOptions self=(WeChatWASM.WXChatOptions)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.movable);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_movable(IntPtr l) {
		try {
			WeChatWASM.WXChatOptions self=(WeChatWASM.WXChatOptions)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.movable=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_enableSnap(IntPtr l) {
		try {
			WeChatWASM.WXChatOptions self=(WeChatWASM.WXChatOptions)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.enableSnap);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_enableSnap(IntPtr l) {
		try {
			WeChatWASM.WXChatOptions self=(WeChatWASM.WXChatOptions)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.enableSnap=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_scale(IntPtr l) {
		try {
			WeChatWASM.WXChatOptions self=(WeChatWASM.WXChatOptions)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.scale);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_scale(IntPtr l) {
		try {
			WeChatWASM.WXChatOptions self=(WeChatWASM.WXChatOptions)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.scale=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXChatOptions");
		addMember(l,"x",get_x,set_x,true);
		addMember(l,"y",get_y,set_y,true);
		addMember(l,"logoUrl",get_logoUrl,set_logoUrl,true);
		addMember(l,"movable",get_movable,set_movable,true);
		addMember(l,"enableSnap",get_enableSnap,set_enableSnap,true);
		addMember(l,"scale",get_scale,set_scale,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXChatOptions));
	}
}
