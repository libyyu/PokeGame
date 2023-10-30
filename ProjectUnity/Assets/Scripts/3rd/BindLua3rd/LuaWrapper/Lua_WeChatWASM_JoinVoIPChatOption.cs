//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_JoinVoIPChatOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.JoinVoIPChatOption o;
			o=new WeChatWASM.JoinVoIPChatOption();
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
	static public int get_groupId(IntPtr l) {
		try {
			WeChatWASM.JoinVoIPChatOption self=(WeChatWASM.JoinVoIPChatOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.groupId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_groupId(IntPtr l) {
		try {
			WeChatWASM.JoinVoIPChatOption self=(WeChatWASM.JoinVoIPChatOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.groupId=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_nonceStr(IntPtr l) {
		try {
			WeChatWASM.JoinVoIPChatOption self=(WeChatWASM.JoinVoIPChatOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.nonceStr);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_nonceStr(IntPtr l) {
		try {
			WeChatWASM.JoinVoIPChatOption self=(WeChatWASM.JoinVoIPChatOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.nonceStr=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_signature(IntPtr l) {
		try {
			WeChatWASM.JoinVoIPChatOption self=(WeChatWASM.JoinVoIPChatOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.signature);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_signature(IntPtr l) {
		try {
			WeChatWASM.JoinVoIPChatOption self=(WeChatWASM.JoinVoIPChatOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.signature=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_timeStamp(IntPtr l) {
		try {
			WeChatWASM.JoinVoIPChatOption self=(WeChatWASM.JoinVoIPChatOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.timeStamp);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_timeStamp(IntPtr l) {
		try {
			WeChatWASM.JoinVoIPChatOption self=(WeChatWASM.JoinVoIPChatOption)checkSelf(l);
			System.Int64 v;
			checkType(l,2,out v);
			self.timeStamp=v;
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
			WeChatWASM.JoinVoIPChatOption self=(WeChatWASM.JoinVoIPChatOption)checkSelf(l);
			System.Action<WeChatWASM.JoinVoIPChatError> v;
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
	static public int set_fail(IntPtr l) {
		try {
			WeChatWASM.JoinVoIPChatOption self=(WeChatWASM.JoinVoIPChatOption)checkSelf(l);
			System.Action<WeChatWASM.JoinVoIPChatError> v;
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
	static public int get_forceCellularNetwork(IntPtr l) {
		try {
			WeChatWASM.JoinVoIPChatOption self=(WeChatWASM.JoinVoIPChatOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.forceCellularNetwork);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_forceCellularNetwork(IntPtr l) {
		try {
			WeChatWASM.JoinVoIPChatOption self=(WeChatWASM.JoinVoIPChatOption)checkSelf(l);
			System.Nullable<System.Boolean> v;
			checkNullable(l,2,out v);
			self.forceCellularNetwork=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_muteConfig(IntPtr l) {
		try {
			WeChatWASM.JoinVoIPChatOption self=(WeChatWASM.JoinVoIPChatOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.muteConfig);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_muteConfig(IntPtr l) {
		try {
			WeChatWASM.JoinVoIPChatOption self=(WeChatWASM.JoinVoIPChatOption)checkSelf(l);
			WeChatWASM.MuteConfig v;
			checkType(l,2,out v);
			self.muteConfig=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_roomType(IntPtr l) {
		try {
			WeChatWASM.JoinVoIPChatOption self=(WeChatWASM.JoinVoIPChatOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.roomType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_roomType(IntPtr l) {
		try {
			WeChatWASM.JoinVoIPChatOption self=(WeChatWASM.JoinVoIPChatOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.roomType=v;
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
			WeChatWASM.JoinVoIPChatOption self=(WeChatWASM.JoinVoIPChatOption)checkSelf(l);
			System.Action<WeChatWASM.JoinVoIPChatSuccessCallbackResult> v;
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
		getTypeTable(l,"WeChatWASM.JoinVoIPChatOption");
		addMember(l,"groupId",get_groupId,set_groupId,true);
		addMember(l,"nonceStr",get_nonceStr,set_nonceStr,true);
		addMember(l,"signature",get_signature,set_signature,true);
		addMember(l,"timeStamp",get_timeStamp,set_timeStamp,true);
		addMember(l,"complete",null,set_complete,true);
		addMember(l,"fail",null,set_fail,true);
		addMember(l,"forceCellularNetwork",get_forceCellularNetwork,set_forceCellularNetwork,true);
		addMember(l,"muteConfig",get_muteConfig,set_muteConfig,true);
		addMember(l,"roomType",get_roomType,set_roomType,true);
		addMember(l,"success",null,set_success,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.JoinVoIPChatOption));
	}
}
