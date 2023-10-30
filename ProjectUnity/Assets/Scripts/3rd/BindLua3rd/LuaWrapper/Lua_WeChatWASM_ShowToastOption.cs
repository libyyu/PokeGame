//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_ShowToastOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.ShowToastOption o;
			o=new WeChatWASM.ShowToastOption();
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
	static public int get_title(IntPtr l) {
		try {
			WeChatWASM.ShowToastOption self=(WeChatWASM.ShowToastOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.title);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_title(IntPtr l) {
		try {
			WeChatWASM.ShowToastOption self=(WeChatWASM.ShowToastOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.title=v;
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
			WeChatWASM.ShowToastOption self=(WeChatWASM.ShowToastOption)checkSelf(l);
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
	static public int get_duration(IntPtr l) {
		try {
			WeChatWASM.ShowToastOption self=(WeChatWASM.ShowToastOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.duration);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_duration(IntPtr l) {
		try {
			WeChatWASM.ShowToastOption self=(WeChatWASM.ShowToastOption)checkSelf(l);
			System.Nullable<System.Double> v;
			checkNullable(l,2,out v);
			self.duration=v;
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
			WeChatWASM.ShowToastOption self=(WeChatWASM.ShowToastOption)checkSelf(l);
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
	static public int get_icon(IntPtr l) {
		try {
			WeChatWASM.ShowToastOption self=(WeChatWASM.ShowToastOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.icon);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_icon(IntPtr l) {
		try {
			WeChatWASM.ShowToastOption self=(WeChatWASM.ShowToastOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.icon=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_image(IntPtr l) {
		try {
			WeChatWASM.ShowToastOption self=(WeChatWASM.ShowToastOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.image);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_image(IntPtr l) {
		try {
			WeChatWASM.ShowToastOption self=(WeChatWASM.ShowToastOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.image=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_mask(IntPtr l) {
		try {
			WeChatWASM.ShowToastOption self=(WeChatWASM.ShowToastOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.mask);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_mask(IntPtr l) {
		try {
			WeChatWASM.ShowToastOption self=(WeChatWASM.ShowToastOption)checkSelf(l);
			System.Nullable<System.Boolean> v;
			checkNullable(l,2,out v);
			self.mask=v;
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
			WeChatWASM.ShowToastOption self=(WeChatWASM.ShowToastOption)checkSelf(l);
			System.Action<WeChatWASM.GeneralCallbackResult> v;
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
		getTypeTable(l,"WeChatWASM.ShowToastOption");
		addMember(l,"title",get_title,set_title,true);
		addMember(l,"complete",null,set_complete,true);
		addMember(l,"duration",get_duration,set_duration,true);
		addMember(l,"fail",null,set_fail,true);
		addMember(l,"icon",get_icon,set_icon,true);
		addMember(l,"image",get_image,set_image,true);
		addMember(l,"mask",get_mask,set_mask,true);
		addMember(l,"success",null,set_success,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.ShowToastOption));
	}
}
