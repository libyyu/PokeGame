//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_ReportSceneOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.ReportSceneOption o;
			o=new WeChatWASM.ReportSceneOption();
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
	static public int get_sceneId(IntPtr l) {
		try {
			WeChatWASM.ReportSceneOption self=(WeChatWASM.ReportSceneOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.sceneId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_sceneId(IntPtr l) {
		try {
			WeChatWASM.ReportSceneOption self=(WeChatWASM.ReportSceneOption)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.sceneId=v;
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
			WeChatWASM.ReportSceneOption self=(WeChatWASM.ReportSceneOption)checkSelf(l);
			System.Action<WeChatWASM.ReportSceneError> v;
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
	static public int get_costTime(IntPtr l) {
		try {
			WeChatWASM.ReportSceneOption self=(WeChatWASM.ReportSceneOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.costTime);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_costTime(IntPtr l) {
		try {
			WeChatWASM.ReportSceneOption self=(WeChatWASM.ReportSceneOption)checkSelf(l);
			System.Nullable<System.Double> v;
			checkNullable(l,2,out v);
			self.costTime=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_dimension(IntPtr l) {
		try {
			WeChatWASM.ReportSceneOption self=(WeChatWASM.ReportSceneOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.dimension);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_dimension(IntPtr l) {
		try {
			WeChatWASM.ReportSceneOption self=(WeChatWASM.ReportSceneOption)checkSelf(l);
			System.Collections.Generic.Dictionary<System.String,System.String> v;
			checkType(l,2,out v);
			self.dimension=v;
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
			WeChatWASM.ReportSceneOption self=(WeChatWASM.ReportSceneOption)checkSelf(l);
			System.Action<WeChatWASM.ReportSceneFailCallbackErr> v;
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
	static public int get_metric(IntPtr l) {
		try {
			WeChatWASM.ReportSceneOption self=(WeChatWASM.ReportSceneOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.metric);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_metric(IntPtr l) {
		try {
			WeChatWASM.ReportSceneOption self=(WeChatWASM.ReportSceneOption)checkSelf(l);
			System.Collections.Generic.Dictionary<System.String,System.String> v;
			checkType(l,2,out v);
			self.metric=v;
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
			WeChatWASM.ReportSceneOption self=(WeChatWASM.ReportSceneOption)checkSelf(l);
			System.Action<WeChatWASM.ReportSceneSuccessCallbackResult> v;
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
		getTypeTable(l,"WeChatWASM.ReportSceneOption");
		addMember(l,"sceneId",get_sceneId,set_sceneId,true);
		addMember(l,"complete",null,set_complete,true);
		addMember(l,"costTime",get_costTime,set_costTime,true);
		addMember(l,"dimension",get_dimension,set_dimension,true);
		addMember(l,"fail",null,set_fail,true);
		addMember(l,"metric",get_metric,set_metric,true);
		addMember(l,"success",null,set_success,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.ReportSceneOption));
	}
}
