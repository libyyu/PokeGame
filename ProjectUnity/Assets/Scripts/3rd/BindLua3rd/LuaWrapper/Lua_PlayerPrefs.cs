//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_PlayerPrefs : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetInt_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			System.Int32 a2 = default(System.Int32);
			checkType(l,2,out a2);
			PlayerPrefs.SetInt(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetInt_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			System.Int32 a2 = default(System.Int32);
			checkType(l,2,out a2);
			var ret=PlayerPrefs.GetInt(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetString_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			System.String a2 = default(System.String);
			checkType(l,2,out a2);
			PlayerPrefs.SetString(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetString_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			System.String a2 = default(System.String);
			checkType(l,2,out a2);
			var ret=PlayerPrefs.GetString(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetFloat_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			System.Single a2 = default(System.Single);
			checkType(l,2,out a2);
			PlayerPrefs.SetFloat(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetFloat_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			System.Single a2 = default(System.Single);
			checkType(l,2,out a2);
			var ret=PlayerPrefs.GetFloat(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DeleteAll_s(IntPtr l) {
		try {
			PlayerPrefs.DeleteAll();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DeleteKey_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			PlayerPrefs.DeleteKey(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int HasKey_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			var ret=PlayerPrefs.HasKey(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Save_s(IntPtr l) {
		try {
			PlayerPrefs.Save();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"PlayerPrefs");
		addMember(l,SetInt_s);
		addMember(l,GetInt_s);
		addMember(l,SetString_s);
		addMember(l,GetString_s);
		addMember(l,SetFloat_s);
		addMember(l,GetFloat_s);
		addMember(l,DeleteAll_s);
		addMember(l,DeleteKey_s);
		addMember(l,HasKey_s);
		addMember(l,Save_s);
		createTypeMetatable(l,null, typeof(PlayerPrefs));
	}
}
