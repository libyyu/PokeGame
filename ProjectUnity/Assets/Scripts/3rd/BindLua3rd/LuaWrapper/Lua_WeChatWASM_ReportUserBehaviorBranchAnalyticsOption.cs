//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_ReportUserBehaviorBranchAnalyticsOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.ReportUserBehaviorBranchAnalyticsOption o;
			o=new WeChatWASM.ReportUserBehaviorBranchAnalyticsOption();
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
	static public int get_branchId(IntPtr l) {
		try {
			WeChatWASM.ReportUserBehaviorBranchAnalyticsOption self=(WeChatWASM.ReportUserBehaviorBranchAnalyticsOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.branchId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_branchId(IntPtr l) {
		try {
			WeChatWASM.ReportUserBehaviorBranchAnalyticsOption self=(WeChatWASM.ReportUserBehaviorBranchAnalyticsOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.branchId=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_eventType(IntPtr l) {
		try {
			WeChatWASM.ReportUserBehaviorBranchAnalyticsOption self=(WeChatWASM.ReportUserBehaviorBranchAnalyticsOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.eventType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_eventType(IntPtr l) {
		try {
			WeChatWASM.ReportUserBehaviorBranchAnalyticsOption self=(WeChatWASM.ReportUserBehaviorBranchAnalyticsOption)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.eventType=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_branchDim(IntPtr l) {
		try {
			WeChatWASM.ReportUserBehaviorBranchAnalyticsOption self=(WeChatWASM.ReportUserBehaviorBranchAnalyticsOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.branchDim);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_branchDim(IntPtr l) {
		try {
			WeChatWASM.ReportUserBehaviorBranchAnalyticsOption self=(WeChatWASM.ReportUserBehaviorBranchAnalyticsOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.branchDim=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.ReportUserBehaviorBranchAnalyticsOption");
		addMember(l,"branchId",get_branchId,set_branchId,true);
		addMember(l,"eventType",get_eventType,set_eventType,true);
		addMember(l,"branchDim",get_branchDim,set_branchDim,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.ReportUserBehaviorBranchAnalyticsOption));
	}
}
