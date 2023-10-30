//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXShareAppMessageParam : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXShareAppMessageParam o;
			o=new WeChatWASM.WXShareAppMessageParam();
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
	static public int get_title(IntPtr l) {
		try {
			WeChatWASM.WXShareAppMessageParam self=(WeChatWASM.WXShareAppMessageParam)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.title);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_title(IntPtr l) {
		try {
			WeChatWASM.WXShareAppMessageParam self=(WeChatWASM.WXShareAppMessageParam)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.title=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_imageUrl(IntPtr l) {
		try {
			WeChatWASM.WXShareAppMessageParam self=(WeChatWASM.WXShareAppMessageParam)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.imageUrl);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_imageUrl(IntPtr l) {
		try {
			WeChatWASM.WXShareAppMessageParam self=(WeChatWASM.WXShareAppMessageParam)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.imageUrl=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_query(IntPtr l) {
		try {
			WeChatWASM.WXShareAppMessageParam self=(WeChatWASM.WXShareAppMessageParam)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.query);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_query(IntPtr l) {
		try {
			WeChatWASM.WXShareAppMessageParam self=(WeChatWASM.WXShareAppMessageParam)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.query=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_imageUrlId(IntPtr l) {
		try {
			WeChatWASM.WXShareAppMessageParam self=(WeChatWASM.WXShareAppMessageParam)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.imageUrlId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_imageUrlId(IntPtr l) {
		try {
			WeChatWASM.WXShareAppMessageParam self=(WeChatWASM.WXShareAppMessageParam)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.imageUrlId=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_toCurrentGroup(IntPtr l) {
		try {
			WeChatWASM.WXShareAppMessageParam self=(WeChatWASM.WXShareAppMessageParam)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.toCurrentGroup);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_toCurrentGroup(IntPtr l) {
		try {
			WeChatWASM.WXShareAppMessageParam self=(WeChatWASM.WXShareAppMessageParam)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.toCurrentGroup=v;
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
			WeChatWASM.WXShareAppMessageParam self=(WeChatWASM.WXShareAppMessageParam)checkSelf(l);
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
			WeChatWASM.WXShareAppMessageParam self=(WeChatWASM.WXShareAppMessageParam)checkSelf(l);
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
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXShareAppMessageParam");
		addMember(l,"title",get_title,set_title,true);
		addMember(l,"imageUrl",get_imageUrl,set_imageUrl,true);
		addMember(l,"query",get_query,set_query,true);
		addMember(l,"imageUrlId",get_imageUrlId,set_imageUrlId,true);
		addMember(l,"toCurrentGroup",get_toCurrentGroup,set_toCurrentGroup,true);
		addMember(l,"path",get_path,set_path,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXShareAppMessageParam));
	}
}
