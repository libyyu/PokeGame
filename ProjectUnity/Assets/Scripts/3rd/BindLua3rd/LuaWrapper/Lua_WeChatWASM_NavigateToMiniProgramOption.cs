//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_NavigateToMiniProgramOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.NavigateToMiniProgramOption o;
			o=new WeChatWASM.NavigateToMiniProgramOption();
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
	static public int get_appId(IntPtr l) {
		try {
			WeChatWASM.NavigateToMiniProgramOption self=(WeChatWASM.NavigateToMiniProgramOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.appId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_appId(IntPtr l) {
		try {
			WeChatWASM.NavigateToMiniProgramOption self=(WeChatWASM.NavigateToMiniProgramOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.appId=v;
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
			WeChatWASM.NavigateToMiniProgramOption self=(WeChatWASM.NavigateToMiniProgramOption)checkSelf(l);
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
	static public int get_envVersion(IntPtr l) {
		try {
			WeChatWASM.NavigateToMiniProgramOption self=(WeChatWASM.NavigateToMiniProgramOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.envVersion);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_envVersion(IntPtr l) {
		try {
			WeChatWASM.NavigateToMiniProgramOption self=(WeChatWASM.NavigateToMiniProgramOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.envVersion=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_extraData(IntPtr l) {
		try {
			WeChatWASM.NavigateToMiniProgramOption self=(WeChatWASM.NavigateToMiniProgramOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.extraData);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_extraData(IntPtr l) {
		try {
			WeChatWASM.NavigateToMiniProgramOption self=(WeChatWASM.NavigateToMiniProgramOption)checkSelf(l);
			System.Collections.Generic.Dictionary<System.String,System.String> v;
			checkType(l,2,out v);
			self.extraData=v;
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
			WeChatWASM.NavigateToMiniProgramOption self=(WeChatWASM.NavigateToMiniProgramOption)checkSelf(l);
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
	static public int get_noRelaunchIfPathUnchanged(IntPtr l) {
		try {
			WeChatWASM.NavigateToMiniProgramOption self=(WeChatWASM.NavigateToMiniProgramOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.noRelaunchIfPathUnchanged);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_noRelaunchIfPathUnchanged(IntPtr l) {
		try {
			WeChatWASM.NavigateToMiniProgramOption self=(WeChatWASM.NavigateToMiniProgramOption)checkSelf(l);
			System.Nullable<System.Boolean> v;
			checkNullable(l,2,out v);
			self.noRelaunchIfPathUnchanged=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_path(IntPtr l) {
		try {
			WeChatWASM.NavigateToMiniProgramOption self=(WeChatWASM.NavigateToMiniProgramOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.path);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_path(IntPtr l) {
		try {
			WeChatWASM.NavigateToMiniProgramOption self=(WeChatWASM.NavigateToMiniProgramOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.path=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_shortLink(IntPtr l) {
		try {
			WeChatWASM.NavigateToMiniProgramOption self=(WeChatWASM.NavigateToMiniProgramOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.shortLink);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_shortLink(IntPtr l) {
		try {
			WeChatWASM.NavigateToMiniProgramOption self=(WeChatWASM.NavigateToMiniProgramOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.shortLink=v;
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
			WeChatWASM.NavigateToMiniProgramOption self=(WeChatWASM.NavigateToMiniProgramOption)checkSelf(l);
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
		getTypeTable(l,"WeChatWASM.NavigateToMiniProgramOption");
		addMember(l,"appId",get_appId,set_appId,true);
		addMember(l,"complete",null,set_complete,true);
		addMember(l,"envVersion",get_envVersion,set_envVersion,true);
		addMember(l,"extraData",get_extraData,set_extraData,true);
		addMember(l,"fail",null,set_fail,true);
		addMember(l,"noRelaunchIfPathUnchanged",get_noRelaunchIfPathUnchanged,set_noRelaunchIfPathUnchanged,true);
		addMember(l,"path",get_path,set_path,true);
		addMember(l,"shortLink",get_shortLink,set_shortLink,true);
		addMember(l,"success",null,set_success,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.NavigateToMiniProgramOption));
	}
}
