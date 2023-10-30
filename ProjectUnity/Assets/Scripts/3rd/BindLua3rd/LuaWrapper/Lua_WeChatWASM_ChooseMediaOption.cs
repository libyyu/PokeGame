//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_ChooseMediaOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.ChooseMediaOption o;
			o=new WeChatWASM.ChooseMediaOption();
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
	static public int get_camera(IntPtr l) {
		try {
			WeChatWASM.ChooseMediaOption self=(WeChatWASM.ChooseMediaOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.camera);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_camera(IntPtr l) {
		try {
			WeChatWASM.ChooseMediaOption self=(WeChatWASM.ChooseMediaOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.camera=v;
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
			WeChatWASM.ChooseMediaOption self=(WeChatWASM.ChooseMediaOption)checkSelf(l);
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
			WeChatWASM.ChooseMediaOption self=(WeChatWASM.ChooseMediaOption)checkSelf(l);
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
			WeChatWASM.ChooseMediaOption self=(WeChatWASM.ChooseMediaOption)checkSelf(l);
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
			WeChatWASM.ChooseMediaOption self=(WeChatWASM.ChooseMediaOption)checkSelf(l);
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
	static public int get_maxDuration(IntPtr l) {
		try {
			WeChatWASM.ChooseMediaOption self=(WeChatWASM.ChooseMediaOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.maxDuration);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_maxDuration(IntPtr l) {
		try {
			WeChatWASM.ChooseMediaOption self=(WeChatWASM.ChooseMediaOption)checkSelf(l);
			System.Nullable<System.Double> v;
			checkNullable(l,2,out v);
			self.maxDuration=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_mediaType(IntPtr l) {
		try {
			WeChatWASM.ChooseMediaOption self=(WeChatWASM.ChooseMediaOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.mediaType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_mediaType(IntPtr l) {
		try {
			WeChatWASM.ChooseMediaOption self=(WeChatWASM.ChooseMediaOption)checkSelf(l);
			System.Array v;
			checkType(l,2,out v);
			self.mediaType=v;
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
			WeChatWASM.ChooseMediaOption self=(WeChatWASM.ChooseMediaOption)checkSelf(l);
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
			WeChatWASM.ChooseMediaOption self=(WeChatWASM.ChooseMediaOption)checkSelf(l);
			System.String[] v;
			checkArray(l,2,out v);
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
			WeChatWASM.ChooseMediaOption self=(WeChatWASM.ChooseMediaOption)checkSelf(l);
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
			WeChatWASM.ChooseMediaOption self=(WeChatWASM.ChooseMediaOption)checkSelf(l);
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
			WeChatWASM.ChooseMediaOption self=(WeChatWASM.ChooseMediaOption)checkSelf(l);
			System.Action<WeChatWASM.ChooseMediaSuccessCallbackResult> v;
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
		getTypeTable(l,"WeChatWASM.ChooseMediaOption");
		addMember(l,"camera",get_camera,set_camera,true);
		addMember(l,"complete",null,set_complete,true);
		addMember(l,"count",get_count,set_count,true);
		addMember(l,"fail",null,set_fail,true);
		addMember(l,"maxDuration",get_maxDuration,set_maxDuration,true);
		addMember(l,"mediaType",get_mediaType,set_mediaType,true);
		addMember(l,"sizeType",get_sizeType,set_sizeType,true);
		addMember(l,"sourceType",get_sourceType,set_sourceType,true);
		addMember(l,"success",null,set_success,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.ChooseMediaOption));
	}
}
