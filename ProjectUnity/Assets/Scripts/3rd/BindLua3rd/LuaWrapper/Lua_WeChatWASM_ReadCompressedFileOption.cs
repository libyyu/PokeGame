//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_ReadCompressedFileOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.ReadCompressedFileOption o;
			o=new WeChatWASM.ReadCompressedFileOption();
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
	static public int get_compressionAlgorithm(IntPtr l) {
		try {
			WeChatWASM.ReadCompressedFileOption self=(WeChatWASM.ReadCompressedFileOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.compressionAlgorithm);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_compressionAlgorithm(IntPtr l) {
		try {
			WeChatWASM.ReadCompressedFileOption self=(WeChatWASM.ReadCompressedFileOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.compressionAlgorithm=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_filePath(IntPtr l) {
		try {
			WeChatWASM.ReadCompressedFileOption self=(WeChatWASM.ReadCompressedFileOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.filePath);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_filePath(IntPtr l) {
		try {
			WeChatWASM.ReadCompressedFileOption self=(WeChatWASM.ReadCompressedFileOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.filePath=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.ReadCompressedFileOption");
		addMember(l,"compressionAlgorithm",get_compressionAlgorithm,set_compressionAlgorithm,true);
		addMember(l,"filePath",get_filePath,set_filePath,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.ReadCompressedFileOption));
	}
}
