//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXUserInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXUserInfo o;
			o=new WeChatWASM.WXUserInfo();
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
	static public int get_nickName(IntPtr l) {
		try {
			WeChatWASM.WXUserInfo self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.nickName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_nickName(IntPtr l) {
		try {
			WeChatWASM.WXUserInfo self;
			checkValueType(l,1,out self);
			System.String v;
			checkType(l,2,out v);
			self.nickName=v;
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
	static public int get_avatarUrl(IntPtr l) {
		try {
			WeChatWASM.WXUserInfo self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.avatarUrl);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_avatarUrl(IntPtr l) {
		try {
			WeChatWASM.WXUserInfo self;
			checkValueType(l,1,out self);
			System.String v;
			checkType(l,2,out v);
			self.avatarUrl=v;
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
	static public int get_country(IntPtr l) {
		try {
			WeChatWASM.WXUserInfo self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.country);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_country(IntPtr l) {
		try {
			WeChatWASM.WXUserInfo self;
			checkValueType(l,1,out self);
			System.String v;
			checkType(l,2,out v);
			self.country=v;
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
	static public int get_province(IntPtr l) {
		try {
			WeChatWASM.WXUserInfo self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.province);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_province(IntPtr l) {
		try {
			WeChatWASM.WXUserInfo self;
			checkValueType(l,1,out self);
			System.String v;
			checkType(l,2,out v);
			self.province=v;
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
	static public int get_city(IntPtr l) {
		try {
			WeChatWASM.WXUserInfo self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.city);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_city(IntPtr l) {
		try {
			WeChatWASM.WXUserInfo self;
			checkValueType(l,1,out self);
			System.String v;
			checkType(l,2,out v);
			self.city=v;
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
	static public int get_language(IntPtr l) {
		try {
			WeChatWASM.WXUserInfo self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.language);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_language(IntPtr l) {
		try {
			WeChatWASM.WXUserInfo self;
			checkValueType(l,1,out self);
			System.String v;
			checkType(l,2,out v);
			self.language=v;
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
	static public int get_gender(IntPtr l) {
		try {
			WeChatWASM.WXUserInfo self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.gender);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_gender(IntPtr l) {
		try {
			WeChatWASM.WXUserInfo self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.gender=v;
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
		getTypeTable(l,"WeChatWASM.WXUserInfo");
		addMember(l,"nickName",get_nickName,set_nickName,true);
		addMember(l,"avatarUrl",get_avatarUrl,set_avatarUrl,true);
		addMember(l,"country",get_country,set_country,true);
		addMember(l,"province",get_province,set_province,true);
		addMember(l,"city",get_city,set_city,true);
		addMember(l,"language",get_language,set_language,true);
		addMember(l,"gender",get_gender,set_gender,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXUserInfo),typeof(System.ValueType));
	}
}
