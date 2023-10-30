//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_UnzipOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.UnzipOption o;
			o=new WeChatWASM.UnzipOption();
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
	static public int get_targetPath(IntPtr l) {
		try {
			WeChatWASM.UnzipOption self=(WeChatWASM.UnzipOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.targetPath);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_targetPath(IntPtr l) {
		try {
			WeChatWASM.UnzipOption self=(WeChatWASM.UnzipOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.targetPath=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_zipFilePath(IntPtr l) {
		try {
			WeChatWASM.UnzipOption self=(WeChatWASM.UnzipOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.zipFilePath);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_zipFilePath(IntPtr l) {
		try {
			WeChatWASM.UnzipOption self=(WeChatWASM.UnzipOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.zipFilePath=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.UnzipOption");
		addMember(l,"targetPath",get_targetPath,set_targetPath,true);
		addMember(l,"zipFilePath",get_zipFilePath,set_zipFilePath,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.UnzipOption));
	}
}
