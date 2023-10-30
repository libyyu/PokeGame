//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_UpdateShareMenuOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.UpdateShareMenuOption o;
			o=new WeChatWASM.UpdateShareMenuOption();
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
	static public int get_activityId(IntPtr l) {
		try {
			WeChatWASM.UpdateShareMenuOption self=(WeChatWASM.UpdateShareMenuOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.activityId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_activityId(IntPtr l) {
		try {
			WeChatWASM.UpdateShareMenuOption self=(WeChatWASM.UpdateShareMenuOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.activityId=v;
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
			WeChatWASM.UpdateShareMenuOption self=(WeChatWASM.UpdateShareMenuOption)checkSelf(l);
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
	static public int set_fail(IntPtr l) {
		try {
			WeChatWASM.UpdateShareMenuOption self=(WeChatWASM.UpdateShareMenuOption)checkSelf(l);
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
	static public int get_isPrivateMessage(IntPtr l) {
		try {
			WeChatWASM.UpdateShareMenuOption self=(WeChatWASM.UpdateShareMenuOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isPrivateMessage);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_isPrivateMessage(IntPtr l) {
		try {
			WeChatWASM.UpdateShareMenuOption self=(WeChatWASM.UpdateShareMenuOption)checkSelf(l);
			System.Nullable<System.Boolean> v;
			checkNullable(l,2,out v);
			self.isPrivateMessage=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_isUpdatableMessage(IntPtr l) {
		try {
			WeChatWASM.UpdateShareMenuOption self=(WeChatWASM.UpdateShareMenuOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isUpdatableMessage);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_isUpdatableMessage(IntPtr l) {
		try {
			WeChatWASM.UpdateShareMenuOption self=(WeChatWASM.UpdateShareMenuOption)checkSelf(l);
			System.Nullable<System.Boolean> v;
			checkNullable(l,2,out v);
			self.isUpdatableMessage=v;
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
			WeChatWASM.UpdateShareMenuOption self=(WeChatWASM.UpdateShareMenuOption)checkSelf(l);
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_templateInfo(IntPtr l) {
		try {
			WeChatWASM.UpdateShareMenuOption self=(WeChatWASM.UpdateShareMenuOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.templateInfo);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_templateInfo(IntPtr l) {
		try {
			WeChatWASM.UpdateShareMenuOption self=(WeChatWASM.UpdateShareMenuOption)checkSelf(l);
			WeChatWASM.UpdatableMessageFrontEndTemplateInfo v;
			checkType(l,2,out v);
			self.templateInfo=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_toDoActivityId(IntPtr l) {
		try {
			WeChatWASM.UpdateShareMenuOption self=(WeChatWASM.UpdateShareMenuOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.toDoActivityId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_toDoActivityId(IntPtr l) {
		try {
			WeChatWASM.UpdateShareMenuOption self=(WeChatWASM.UpdateShareMenuOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.toDoActivityId=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_withShareTicket(IntPtr l) {
		try {
			WeChatWASM.UpdateShareMenuOption self=(WeChatWASM.UpdateShareMenuOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.withShareTicket);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_withShareTicket(IntPtr l) {
		try {
			WeChatWASM.UpdateShareMenuOption self=(WeChatWASM.UpdateShareMenuOption)checkSelf(l);
			System.Nullable<System.Boolean> v;
			checkNullable(l,2,out v);
			self.withShareTicket=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.UpdateShareMenuOption");
		addMember(l,"activityId",get_activityId,set_activityId,true);
		addMember(l,"complete",null,set_complete,true);
		addMember(l,"fail",null,set_fail,true);
		addMember(l,"isPrivateMessage",get_isPrivateMessage,set_isPrivateMessage,true);
		addMember(l,"isUpdatableMessage",get_isUpdatableMessage,set_isUpdatableMessage,true);
		addMember(l,"success",null,set_success,true);
		addMember(l,"templateInfo",get_templateInfo,set_templateInfo,true);
		addMember(l,"toDoActivityId",get_toDoActivityId,set_toDoActivityId,true);
		addMember(l,"withShareTicket",get_withShareTicket,set_withShareTicket,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.UpdateShareMenuOption));
	}
}
