//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_OnBackgroundFetchDataListenerResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.OnBackgroundFetchDataListenerResult o;
			o=new WeChatWASM.OnBackgroundFetchDataListenerResult();
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
	static public int get_fetchType(IntPtr l) {
		try {
			WeChatWASM.OnBackgroundFetchDataListenerResult self=(WeChatWASM.OnBackgroundFetchDataListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.fetchType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_fetchType(IntPtr l) {
		try {
			WeChatWASM.OnBackgroundFetchDataListenerResult self=(WeChatWASM.OnBackgroundFetchDataListenerResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.fetchType=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_fetchedData(IntPtr l) {
		try {
			WeChatWASM.OnBackgroundFetchDataListenerResult self=(WeChatWASM.OnBackgroundFetchDataListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.fetchedData);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_fetchedData(IntPtr l) {
		try {
			WeChatWASM.OnBackgroundFetchDataListenerResult self=(WeChatWASM.OnBackgroundFetchDataListenerResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.fetchedData=v;
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
			WeChatWASM.OnBackgroundFetchDataListenerResult self=(WeChatWASM.OnBackgroundFetchDataListenerResult)checkSelf(l);
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
			WeChatWASM.OnBackgroundFetchDataListenerResult self=(WeChatWASM.OnBackgroundFetchDataListenerResult)checkSelf(l);
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
	static public int get_query(IntPtr l) {
		try {
			WeChatWASM.OnBackgroundFetchDataListenerResult self=(WeChatWASM.OnBackgroundFetchDataListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.query);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_query(IntPtr l) {
		try {
			WeChatWASM.OnBackgroundFetchDataListenerResult self=(WeChatWASM.OnBackgroundFetchDataListenerResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.query=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_scene(IntPtr l) {
		try {
			WeChatWASM.OnBackgroundFetchDataListenerResult self=(WeChatWASM.OnBackgroundFetchDataListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.scene);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_scene(IntPtr l) {
		try {
			WeChatWASM.OnBackgroundFetchDataListenerResult self=(WeChatWASM.OnBackgroundFetchDataListenerResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.scene=v;
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
			WeChatWASM.OnBackgroundFetchDataListenerResult self=(WeChatWASM.OnBackgroundFetchDataListenerResult)checkSelf(l);
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
			WeChatWASM.OnBackgroundFetchDataListenerResult self=(WeChatWASM.OnBackgroundFetchDataListenerResult)checkSelf(l);
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
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.OnBackgroundFetchDataListenerResult");
		addMember(l,"fetchType",get_fetchType,set_fetchType,true);
		addMember(l,"fetchedData",get_fetchedData,set_fetchedData,true);
		addMember(l,"path",get_path,set_path,true);
		addMember(l,"query",get_query,set_query,true);
		addMember(l,"scene",get_scene,set_scene,true);
		addMember(l,"timeStamp",get_timeStamp,set_timeStamp,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.OnBackgroundFetchDataListenerResult));
	}
}
