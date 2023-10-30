//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_GetFontResponse : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.GetFontResponse o;
			o=new WeChatWASM.GetFontResponse();
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
	static public int get_binData(IntPtr l) {
		try {
			WeChatWASM.GetFontResponse self=(WeChatWASM.GetFontResponse)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.binData);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_binData(IntPtr l) {
		try {
			WeChatWASM.GetFontResponse self=(WeChatWASM.GetFontResponse)checkSelf(l);
			System.Byte[] v;
			checkArray(l,2,out v);
			self.binData=v;
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
			WeChatWASM.GetFontResponse self=(WeChatWASM.GetFontResponse)checkSelf(l);
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
			WeChatWASM.GetFontResponse self=(WeChatWASM.GetFontResponse)checkSelf(l);
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_ascent(IntPtr l) {
		try {
			WeChatWASM.GetFontResponse self=(WeChatWASM.GetFontResponse)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.ascent);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_ascent(IntPtr l) {
		try {
			WeChatWASM.GetFontResponse self=(WeChatWASM.GetFontResponse)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.ascent=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_descent(IntPtr l) {
		try {
			WeChatWASM.GetFontResponse self=(WeChatWASM.GetFontResponse)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.descent);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_descent(IntPtr l) {
		try {
			WeChatWASM.GetFontResponse self=(WeChatWASM.GetFontResponse)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.descent=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_lineGap(IntPtr l) {
		try {
			WeChatWASM.GetFontResponse self=(WeChatWASM.GetFontResponse)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.lineGap);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_lineGap(IntPtr l) {
		try {
			WeChatWASM.GetFontResponse self=(WeChatWASM.GetFontResponse)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.lineGap=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_unitsPerEm(IntPtr l) {
		try {
			WeChatWASM.GetFontResponse self=(WeChatWASM.GetFontResponse)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.unitsPerEm);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_unitsPerEm(IntPtr l) {
		try {
			WeChatWASM.GetFontResponse self=(WeChatWASM.GetFontResponse)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.unitsPerEm=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.GetFontResponse");
		addMember(l,"binData",get_binData,set_binData,true);
		addMember(l,"byteLength",get_byteLength,set_byteLength,true);
		addMember(l,"ascent",get_ascent,set_ascent,true);
		addMember(l,"descent",get_descent,set_descent,true);
		addMember(l,"lineGap",get_lineGap,set_lineGap,true);
		addMember(l,"unitsPerEm",get_unitsPerEm,set_unitsPerEm,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.GetFontResponse),typeof(WeChatWASM.WXBaseResponse));
	}
}
