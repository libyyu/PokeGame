//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXFileCacheCleanTask : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			WeChatWASM.WXFileCacheCleanTask o;
			if(matchType(l,argc,2,typeof(int),typeof(System.Action<WeChatWASM.ReleaseResult>))){
				System.Int32 a1 = default(System.Int32);
				checkType(l,2,out a1);
				System.Action<WeChatWASM.ReleaseResult> a2 = default(System.Action<WeChatWASM.ReleaseResult>);
				checkDelegate(l,3,out a2);
				o=new WeChatWASM.WXFileCacheCleanTask(a1,a2);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(bool),typeof(System.Action<System.Boolean>))){
				System.Boolean a1 = default(System.Boolean);
				checkType(l,2,out a1);
				System.Action<System.Boolean> a2 = default(System.Action<System.Boolean>);
				checkDelegate(l,3,out a2);
				o=new WeChatWASM.WXFileCacheCleanTask(a1,a2);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(System.Action<System.Boolean>))){
				System.String a1 = default(System.String);
				checkType(l,2,out a1);
				System.Action<System.Boolean> a2 = default(System.Action<System.Boolean>);
				checkDelegate(l,3,out a2);
				o=new WeChatWASM.WXFileCacheCleanTask(a1,a2);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			return error(l,"New object failed.");
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_OnCleanFileCacheAction(IntPtr l) {
		try {
			WeChatWASM.WXFileCacheCleanTask self=(WeChatWASM.WXFileCacheCleanTask)checkSelf(l);
			System.Action<WeChatWASM.ReleaseResult> v;
			int op=checkDelegate(l,2,out v);
			if(op==0) self.OnCleanFileCacheAction=v;
			else if(op==1) self.OnCleanFileCacheAction+=v;
			else if(op==2) self.OnCleanFileCacheAction-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_OnCleanAllFileCacheAction(IntPtr l) {
		try {
			WeChatWASM.WXFileCacheCleanTask self=(WeChatWASM.WXFileCacheCleanTask)checkSelf(l);
			System.Action<System.Boolean> v;
			int op=checkDelegate(l,2,out v);
			if(op==0) self.OnCleanAllFileCacheAction=v;
			else if(op==1) self.OnCleanAllFileCacheAction+=v;
			else if(op==2) self.OnCleanAllFileCacheAction-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_OnRemoveFileAction(IntPtr l) {
		try {
			WeChatWASM.WXFileCacheCleanTask self=(WeChatWASM.WXFileCacheCleanTask)checkSelf(l);
			System.Action<System.Boolean> v;
			int op=checkDelegate(l,2,out v);
			if(op==0) self.OnRemoveFileAction=v;
			else if(op==1) self.OnRemoveFileAction+=v;
			else if(op==2) self.OnRemoveFileAction-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Dict(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,WeChatWASM.WXFileCacheCleanTask.Dict);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_Dict(IntPtr l) {
		try {
			System.Collections.Generic.Dictionary<System.String,WeChatWASM.WXFileCacheCleanTask> v;
			checkType(l,2,out v);
			WeChatWASM.WXFileCacheCleanTask.Dict=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXFileCacheCleanTask");
		addMember(l,"OnCleanFileCacheAction",null,set_OnCleanFileCacheAction,true);
		addMember(l,"OnCleanAllFileCacheAction",null,set_OnCleanAllFileCacheAction,true);
		addMember(l,"OnRemoveFileAction",null,set_OnRemoveFileAction,true);
		addMember(l,"Dict",get_Dict,set_Dict,false);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXFileCacheCleanTask));
	}
}
