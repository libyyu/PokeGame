//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_CopyFileParam : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.CopyFileParam o;
			o=new WeChatWASM.CopyFileParam();
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
	static public int get_srcPath(IntPtr l) {
		try {
			WeChatWASM.CopyFileParam self=(WeChatWASM.CopyFileParam)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.srcPath);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_srcPath(IntPtr l) {
		try {
			WeChatWASM.CopyFileParam self=(WeChatWASM.CopyFileParam)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.srcPath=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_destPath(IntPtr l) {
		try {
			WeChatWASM.CopyFileParam self=(WeChatWASM.CopyFileParam)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.destPath);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_destPath(IntPtr l) {
		try {
			WeChatWASM.CopyFileParam self=(WeChatWASM.CopyFileParam)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.destPath=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.CopyFileParam");
		addMember(l,"srcPath",get_srcPath,set_srcPath,true);
		addMember(l,"destPath",get_destPath,set_destPath,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.CopyFileParam));
	}
}
