//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_Touch : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.Touch o;
			o=new WeChatWASM.Touch();
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
	static public int get_clientX(IntPtr l) {
		try {
			WeChatWASM.Touch self=(WeChatWASM.Touch)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.clientX);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_clientX(IntPtr l) {
		try {
			WeChatWASM.Touch self=(WeChatWASM.Touch)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.clientX=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_clientY(IntPtr l) {
		try {
			WeChatWASM.Touch self=(WeChatWASM.Touch)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.clientY);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_clientY(IntPtr l) {
		try {
			WeChatWASM.Touch self=(WeChatWASM.Touch)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.clientY=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_force(IntPtr l) {
		try {
			WeChatWASM.Touch self=(WeChatWASM.Touch)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.force);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_force(IntPtr l) {
		try {
			WeChatWASM.Touch self=(WeChatWASM.Touch)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.force=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_identifier(IntPtr l) {
		try {
			WeChatWASM.Touch self=(WeChatWASM.Touch)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.identifier);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_identifier(IntPtr l) {
		try {
			WeChatWASM.Touch self=(WeChatWASM.Touch)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.identifier=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_pageX(IntPtr l) {
		try {
			WeChatWASM.Touch self=(WeChatWASM.Touch)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.pageX);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_pageX(IntPtr l) {
		try {
			WeChatWASM.Touch self=(WeChatWASM.Touch)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.pageX=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_pageY(IntPtr l) {
		try {
			WeChatWASM.Touch self=(WeChatWASM.Touch)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.pageY);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_pageY(IntPtr l) {
		try {
			WeChatWASM.Touch self=(WeChatWASM.Touch)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.pageY=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.Touch");
		addMember(l,"clientX",get_clientX,set_clientX,true);
		addMember(l,"clientY",get_clientY,set_clientY,true);
		addMember(l,"force",get_force,set_force,true);
		addMember(l,"identifier",get_identifier,set_identifier,true);
		addMember(l,"pageX",get_pageX,set_pageX,true);
		addMember(l,"pageY",get_pageY,set_pageY,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.Touch));
	}
}
