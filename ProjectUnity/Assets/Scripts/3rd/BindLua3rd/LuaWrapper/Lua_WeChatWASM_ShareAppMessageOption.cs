//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_ShareAppMessageOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.ShareAppMessageOption o;
			o=new WeChatWASM.ShareAppMessageOption();
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
	static public int get_imageUrl(IntPtr l) {
		try {
			WeChatWASM.ShareAppMessageOption self=(WeChatWASM.ShareAppMessageOption)checkSelf(l);
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
			WeChatWASM.ShareAppMessageOption self=(WeChatWASM.ShareAppMessageOption)checkSelf(l);
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
	static public int get_imageUrlId(IntPtr l) {
		try {
			WeChatWASM.ShareAppMessageOption self=(WeChatWASM.ShareAppMessageOption)checkSelf(l);
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
			WeChatWASM.ShareAppMessageOption self=(WeChatWASM.ShareAppMessageOption)checkSelf(l);
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
	static public int get_path(IntPtr l) {
		try {
			WeChatWASM.ShareAppMessageOption self=(WeChatWASM.ShareAppMessageOption)checkSelf(l);
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
			WeChatWASM.ShareAppMessageOption self=(WeChatWASM.ShareAppMessageOption)checkSelf(l);
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_query(IntPtr l) {
		try {
			WeChatWASM.ShareAppMessageOption self=(WeChatWASM.ShareAppMessageOption)checkSelf(l);
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
			WeChatWASM.ShareAppMessageOption self=(WeChatWASM.ShareAppMessageOption)checkSelf(l);
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
	static public int get_title(IntPtr l) {
		try {
			WeChatWASM.ShareAppMessageOption self=(WeChatWASM.ShareAppMessageOption)checkSelf(l);
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
			WeChatWASM.ShareAppMessageOption self=(WeChatWASM.ShareAppMessageOption)checkSelf(l);
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
	static public int get_toCurrentGroup(IntPtr l) {
		try {
			WeChatWASM.ShareAppMessageOption self=(WeChatWASM.ShareAppMessageOption)checkSelf(l);
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
			WeChatWASM.ShareAppMessageOption self=(WeChatWASM.ShareAppMessageOption)checkSelf(l);
			System.Nullable<System.Boolean> v;
			checkNullable(l,2,out v);
			self.toCurrentGroup=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.ShareAppMessageOption");
		addMember(l,"imageUrl",get_imageUrl,set_imageUrl,true);
		addMember(l,"imageUrlId",get_imageUrlId,set_imageUrlId,true);
		addMember(l,"path",get_path,set_path,true);
		addMember(l,"query",get_query,set_query,true);
		addMember(l,"title",get_title,set_title,true);
		addMember(l,"toCurrentGroup",get_toCurrentGroup,set_toCurrentGroup,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.ShareAppMessageOption));
	}
}
