//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXGetFontCallback : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXGetFontCallback o;
			o=new WeChatWASM.WXGetFontCallback();
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
	static public int get_bufferPtr(IntPtr l) {
		try {
			WeChatWASM.WXGetFontCallback self=(WeChatWASM.WXGetFontCallback)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.bufferPtr);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_bufferPtr(IntPtr l) {
		try {
			WeChatWASM.WXGetFontCallback self=(WeChatWASM.WXGetFontCallback)checkSelf(l);
			System.UInt32 v;
			checkType(l,2,out v);
			self.bufferPtr=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_byteLength(IntPtr l) {
		try {
			WeChatWASM.WXGetFontCallback self=(WeChatWASM.WXGetFontCallback)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.byteLength);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_byteLength(IntPtr l) {
		try {
			WeChatWASM.WXGetFontCallback self=(WeChatWASM.WXGetFontCallback)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.byteLength=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXGetFontCallback");
		addMember(l,"bufferPtr",get_bufferPtr,set_bufferPtr,true);
		addMember(l,"byteLength",get_byteLength,set_byteLength,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXGetFontCallback),typeof(WeChatWASM.WXTextResponse));
	}
}
