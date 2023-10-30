//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_FrameDataOptions : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.FrameDataOptions o;
			o=new WeChatWASM.FrameDataOptions();
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
	static public int get_data(IntPtr l) {
		try {
			WeChatWASM.FrameDataOptions self=(WeChatWASM.FrameDataOptions)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.data);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_data(IntPtr l) {
		try {
			WeChatWASM.FrameDataOptions self=(WeChatWASM.FrameDataOptions)checkSelf(l);
			System.Byte[] v;
			checkArray(l,2,out v);
			self.data=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_arrayBufferLength(IntPtr l) {
		try {
			WeChatWASM.FrameDataOptions self=(WeChatWASM.FrameDataOptions)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.arrayBufferLength);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_arrayBufferLength(IntPtr l) {
		try {
			WeChatWASM.FrameDataOptions self=(WeChatWASM.FrameDataOptions)checkSelf(l);
			System.Nullable<System.Int32> v;
			checkNullable(l,2,out v);
			self.arrayBufferLength=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_height(IntPtr l) {
		try {
			WeChatWASM.FrameDataOptions self=(WeChatWASM.FrameDataOptions)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.height);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_height(IntPtr l) {
		try {
			WeChatWASM.FrameDataOptions self=(WeChatWASM.FrameDataOptions)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.height=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_pkDts(IntPtr l) {
		try {
			WeChatWASM.FrameDataOptions self=(WeChatWASM.FrameDataOptions)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.pkDts);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_pkDts(IntPtr l) {
		try {
			WeChatWASM.FrameDataOptions self=(WeChatWASM.FrameDataOptions)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.pkDts=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_pkPts(IntPtr l) {
		try {
			WeChatWASM.FrameDataOptions self=(WeChatWASM.FrameDataOptions)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.pkPts);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_pkPts(IntPtr l) {
		try {
			WeChatWASM.FrameDataOptions self=(WeChatWASM.FrameDataOptions)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.pkPts=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_width(IntPtr l) {
		try {
			WeChatWASM.FrameDataOptions self=(WeChatWASM.FrameDataOptions)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.width);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_width(IntPtr l) {
		try {
			WeChatWASM.FrameDataOptions self=(WeChatWASM.FrameDataOptions)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.width=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.FrameDataOptions");
		addMember(l,"data",get_data,set_data,true);
		addMember(l,"arrayBufferLength",get_arrayBufferLength,set_arrayBufferLength,true);
		addMember(l,"height",get_height,set_height,true);
		addMember(l,"pkDts",get_pkDts,set_pkDts,true);
		addMember(l,"pkPts",get_pkPts,set_pkPts,true);
		addMember(l,"width",get_width,set_width,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.FrameDataOptions));
	}
}
