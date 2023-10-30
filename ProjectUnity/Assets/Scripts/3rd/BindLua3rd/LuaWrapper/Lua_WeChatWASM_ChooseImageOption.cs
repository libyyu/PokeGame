//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_ChooseImageOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.ChooseImageOption o;
			o=new WeChatWASM.ChooseImageOption();
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
	static public int set_complete(IntPtr l) {
		try {
			WeChatWASM.ChooseImageOption self=(WeChatWASM.ChooseImageOption)checkSelf(l);
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
	static public int get_count(IntPtr l) {
		try {
			WeChatWASM.ChooseImageOption self=(WeChatWASM.ChooseImageOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.count);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_count(IntPtr l) {
		try {
			WeChatWASM.ChooseImageOption self=(WeChatWASM.ChooseImageOption)checkSelf(l);
			System.Nullable<System.Double> v;
			checkNullable(l,2,out v);
			self.count=v;
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
			WeChatWASM.ChooseImageOption self=(WeChatWASM.ChooseImageOption)checkSelf(l);
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
	static public int get_sizeType(IntPtr l) {
		try {
			WeChatWASM.ChooseImageOption self=(WeChatWASM.ChooseImageOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.sizeType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_sizeType(IntPtr l) {
		try {
			WeChatWASM.ChooseImageOption self=(WeChatWASM.ChooseImageOption)checkSelf(l);
			System.Array v;
			checkType(l,2,out v);
			self.sizeType=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_sourceType(IntPtr l) {
		try {
			WeChatWASM.ChooseImageOption self=(WeChatWASM.ChooseImageOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.sourceType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_sourceType(IntPtr l) {
		try {
			WeChatWASM.ChooseImageOption self=(WeChatWASM.ChooseImageOption)checkSelf(l);
			System.Array v;
			checkType(l,2,out v);
			self.sourceType=v;
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
			WeChatWASM.ChooseImageOption self=(WeChatWASM.ChooseImageOption)checkSelf(l);
			System.Action<WeChatWASM.ChooseImageSuccessCallbackResult> v;
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
		getTypeTable(l,"WeChatWASM.ChooseImageOption");
		addMember(l,"complete",null,set_complete,true);
		addMember(l,"count",get_count,set_count,true);
		addMember(l,"fail",null,set_fail,true);
		addMember(l,"sizeType",get_sizeType,set_sizeType,true);
		addMember(l,"sourceType",get_sourceType,set_sourceType,true);
		addMember(l,"success",null,set_success,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.ChooseImageOption));
	}
}
