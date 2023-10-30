//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_CompressImageOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.CompressImageOption o;
			o=new WeChatWASM.CompressImageOption();
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
	static public int get_src(IntPtr l) {
		try {
			WeChatWASM.CompressImageOption self=(WeChatWASM.CompressImageOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.src);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_src(IntPtr l) {
		try {
			WeChatWASM.CompressImageOption self=(WeChatWASM.CompressImageOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.src=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_complete(IntPtr l) {
		try {
			WeChatWASM.CompressImageOption self=(WeChatWASM.CompressImageOption)checkSelf(l);
			System.Action<WeChatWASM.GeneralCallbackResult> v;
			int op=checkDelegate(l,2,out v);
			if(op==0) self.complete=v;
			else if(op==1) self.complete+=v;
			else if(op==2) self.complete-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_compressedHeight(IntPtr l) {
		try {
			WeChatWASM.CompressImageOption self=(WeChatWASM.CompressImageOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.compressedHeight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_compressedHeight(IntPtr l) {
		try {
			WeChatWASM.CompressImageOption self=(WeChatWASM.CompressImageOption)checkSelf(l);
			System.Nullable<System.Double> v;
			checkNullable(l,2,out v);
			self.compressedHeight=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_compressedWidth(IntPtr l) {
		try {
			WeChatWASM.CompressImageOption self=(WeChatWASM.CompressImageOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.compressedWidth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_compressedWidth(IntPtr l) {
		try {
			WeChatWASM.CompressImageOption self=(WeChatWASM.CompressImageOption)checkSelf(l);
			System.Nullable<System.Double> v;
			checkNullable(l,2,out v);
			self.compressedWidth=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_fail(IntPtr l) {
		try {
			WeChatWASM.CompressImageOption self=(WeChatWASM.CompressImageOption)checkSelf(l);
			System.Action<WeChatWASM.GeneralCallbackResult> v;
			int op=checkDelegate(l,2,out v);
			if(op==0) self.fail=v;
			else if(op==1) self.fail+=v;
			else if(op==2) self.fail-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_quality(IntPtr l) {
		try {
			WeChatWASM.CompressImageOption self=(WeChatWASM.CompressImageOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.quality);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_quality(IntPtr l) {
		try {
			WeChatWASM.CompressImageOption self=(WeChatWASM.CompressImageOption)checkSelf(l);
			System.Nullable<System.Double> v;
			checkNullable(l,2,out v);
			self.quality=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_success(IntPtr l) {
		try {
			WeChatWASM.CompressImageOption self=(WeChatWASM.CompressImageOption)checkSelf(l);
			System.Action<WeChatWASM.CompressImageSuccessCallbackResult> v;
			int op=checkDelegate(l,2,out v);
			if(op==0) self.success=v;
			else if(op==1) self.success+=v;
			else if(op==2) self.success-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.CompressImageOption");
		addMember(l,"src",get_src,set_src,true);
		addMember(l,"complete",null,set_complete,true);
		addMember(l,"compressedHeight",get_compressedHeight,set_compressedHeight,true);
		addMember(l,"compressedWidth",get_compressedWidth,set_compressedWidth,true);
		addMember(l,"fail",null,set_fail,true);
		addMember(l,"quality",get_quality,set_quality,true);
		addMember(l,"success",null,set_success,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.CompressImageOption));
	}
}
