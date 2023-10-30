//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_GetChannelsLiveInfoOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.GetChannelsLiveInfoOption o;
			o=new WeChatWASM.GetChannelsLiveInfoOption();
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
	static public int get_finderUserName(IntPtr l) {
		try {
			WeChatWASM.GetChannelsLiveInfoOption self=(WeChatWASM.GetChannelsLiveInfoOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.finderUserName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_finderUserName(IntPtr l) {
		try {
			WeChatWASM.GetChannelsLiveInfoOption self=(WeChatWASM.GetChannelsLiveInfoOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.finderUserName=v;
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
			WeChatWASM.GetChannelsLiveInfoOption self=(WeChatWASM.GetChannelsLiveInfoOption)checkSelf(l);
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
	static public int get_endTime(IntPtr l) {
		try {
			WeChatWASM.GetChannelsLiveInfoOption self=(WeChatWASM.GetChannelsLiveInfoOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.endTime);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_endTime(IntPtr l) {
		try {
			WeChatWASM.GetChannelsLiveInfoOption self=(WeChatWASM.GetChannelsLiveInfoOption)checkSelf(l);
			System.Nullable<System.Double> v;
			checkNullable(l,2,out v);
			self.endTime=v;
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
			WeChatWASM.GetChannelsLiveInfoOption self=(WeChatWASM.GetChannelsLiveInfoOption)checkSelf(l);
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
	static public int get_startTime(IntPtr l) {
		try {
			WeChatWASM.GetChannelsLiveInfoOption self=(WeChatWASM.GetChannelsLiveInfoOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.startTime);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_startTime(IntPtr l) {
		try {
			WeChatWASM.GetChannelsLiveInfoOption self=(WeChatWASM.GetChannelsLiveInfoOption)checkSelf(l);
			System.Nullable<System.Double> v;
			checkNullable(l,2,out v);
			self.startTime=v;
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
			WeChatWASM.GetChannelsLiveInfoOption self=(WeChatWASM.GetChannelsLiveInfoOption)checkSelf(l);
			System.Action<WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult> v;
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
		getTypeTable(l,"WeChatWASM.GetChannelsLiveInfoOption");
		addMember(l,"finderUserName",get_finderUserName,set_finderUserName,true);
		addMember(l,"complete",null,set_complete,true);
		addMember(l,"endTime",get_endTime,set_endTime,true);
		addMember(l,"fail",null,set_fail,true);
		addMember(l,"startTime",get_startTime,set_startTime,true);
		addMember(l,"success",null,set_success,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.GetChannelsLiveInfoOption));
	}
}
