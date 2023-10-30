//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_OnAddToFavoritesListenerResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.OnAddToFavoritesListenerResult o;
			o=new WeChatWASM.OnAddToFavoritesListenerResult();
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
	static public int get_disableForward(IntPtr l) {
		try {
			WeChatWASM.OnAddToFavoritesListenerResult self=(WeChatWASM.OnAddToFavoritesListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.disableForward);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_disableForward(IntPtr l) {
		try {
			WeChatWASM.OnAddToFavoritesListenerResult self=(WeChatWASM.OnAddToFavoritesListenerResult)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.disableForward=v;
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
			WeChatWASM.OnAddToFavoritesListenerResult self=(WeChatWASM.OnAddToFavoritesListenerResult)checkSelf(l);
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
			WeChatWASM.OnAddToFavoritesListenerResult self=(WeChatWASM.OnAddToFavoritesListenerResult)checkSelf(l);
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
			WeChatWASM.OnAddToFavoritesListenerResult self=(WeChatWASM.OnAddToFavoritesListenerResult)checkSelf(l);
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
			WeChatWASM.OnAddToFavoritesListenerResult self=(WeChatWASM.OnAddToFavoritesListenerResult)checkSelf(l);
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
			WeChatWASM.OnAddToFavoritesListenerResult self=(WeChatWASM.OnAddToFavoritesListenerResult)checkSelf(l);
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
			WeChatWASM.OnAddToFavoritesListenerResult self=(WeChatWASM.OnAddToFavoritesListenerResult)checkSelf(l);
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
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.OnAddToFavoritesListenerResult");
		addMember(l,"disableForward",get_disableForward,set_disableForward,true);
		addMember(l,"imageUrl",get_imageUrl,set_imageUrl,true);
		addMember(l,"query",get_query,set_query,true);
		addMember(l,"title",get_title,set_title,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.OnAddToFavoritesListenerResult));
	}
}
