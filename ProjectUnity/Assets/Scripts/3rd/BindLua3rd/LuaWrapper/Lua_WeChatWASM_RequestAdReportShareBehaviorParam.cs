//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_RequestAdReportShareBehaviorParam : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.RequestAdReportShareBehaviorParam o;
			o=new WeChatWASM.RequestAdReportShareBehaviorParam();
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
	static public int get_operation(IntPtr l) {
		try {
			WeChatWASM.RequestAdReportShareBehaviorParam self=(WeChatWASM.RequestAdReportShareBehaviorParam)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.operation);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_operation(IntPtr l) {
		try {
			WeChatWASM.RequestAdReportShareBehaviorParam self=(WeChatWASM.RequestAdReportShareBehaviorParam)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.operation=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_currentShow(IntPtr l) {
		try {
			WeChatWASM.RequestAdReportShareBehaviorParam self=(WeChatWASM.RequestAdReportShareBehaviorParam)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.currentShow);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_currentShow(IntPtr l) {
		try {
			WeChatWASM.RequestAdReportShareBehaviorParam self=(WeChatWASM.RequestAdReportShareBehaviorParam)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.currentShow=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_strategy(IntPtr l) {
		try {
			WeChatWASM.RequestAdReportShareBehaviorParam self=(WeChatWASM.RequestAdReportShareBehaviorParam)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.strategy);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_strategy(IntPtr l) {
		try {
			WeChatWASM.RequestAdReportShareBehaviorParam self=(WeChatWASM.RequestAdReportShareBehaviorParam)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.strategy=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_inviteUser(IntPtr l) {
		try {
			WeChatWASM.RequestAdReportShareBehaviorParam self=(WeChatWASM.RequestAdReportShareBehaviorParam)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.inviteUser);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_inviteUser(IntPtr l) {
		try {
			WeChatWASM.RequestAdReportShareBehaviorParam self=(WeChatWASM.RequestAdReportShareBehaviorParam)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.inviteUser=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_inviteUserAdunit(IntPtr l) {
		try {
			WeChatWASM.RequestAdReportShareBehaviorParam self=(WeChatWASM.RequestAdReportShareBehaviorParam)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.inviteUserAdunit);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_inviteUserAdunit(IntPtr l) {
		try {
			WeChatWASM.RequestAdReportShareBehaviorParam self=(WeChatWASM.RequestAdReportShareBehaviorParam)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.inviteUserAdunit=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_shareValue(IntPtr l) {
		try {
			WeChatWASM.RequestAdReportShareBehaviorParam self=(WeChatWASM.RequestAdReportShareBehaviorParam)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.shareValue);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_shareValue(IntPtr l) {
		try {
			WeChatWASM.RequestAdReportShareBehaviorParam self=(WeChatWASM.RequestAdReportShareBehaviorParam)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.shareValue=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_rewardValue(IntPtr l) {
		try {
			WeChatWASM.RequestAdReportShareBehaviorParam self=(WeChatWASM.RequestAdReportShareBehaviorParam)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rewardValue);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_rewardValue(IntPtr l) {
		try {
			WeChatWASM.RequestAdReportShareBehaviorParam self=(WeChatWASM.RequestAdReportShareBehaviorParam)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.rewardValue=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_depositAmount(IntPtr l) {
		try {
			WeChatWASM.RequestAdReportShareBehaviorParam self=(WeChatWASM.RequestAdReportShareBehaviorParam)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.depositAmount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_depositAmount(IntPtr l) {
		try {
			WeChatWASM.RequestAdReportShareBehaviorParam self=(WeChatWASM.RequestAdReportShareBehaviorParam)checkSelf(l);
			System.Nullable<System.Int32> v;
			checkNullable(l,2,out v);
			self.depositAmount=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.RequestAdReportShareBehaviorParam");
		addMember(l,"operation",get_operation,set_operation,true);
		addMember(l,"currentShow",get_currentShow,set_currentShow,true);
		addMember(l,"strategy",get_strategy,set_strategy,true);
		addMember(l,"inviteUser",get_inviteUser,set_inviteUser,true);
		addMember(l,"inviteUserAdunit",get_inviteUserAdunit,set_inviteUserAdunit,true);
		addMember(l,"shareValue",get_shareValue,set_shareValue,true);
		addMember(l,"rewardValue",get_rewardValue,set_rewardValue,true);
		addMember(l,"depositAmount",get_depositAmount,set_depositAmount,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.RequestAdReportShareBehaviorParam));
	}
}
