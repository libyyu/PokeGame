//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXCamera : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXCamera o;
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			o=new WeChatWASM.WXCamera(a1);
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
	static public int CloseFrameChange(IntPtr l) {
		try {
			WeChatWASM.WXCamera self=(WeChatWASM.WXCamera)checkSelf(l);
			self.CloseFrameChange();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Destroy(IntPtr l) {
		try {
			WeChatWASM.WXCamera self=(WeChatWASM.WXCamera)checkSelf(l);
			self.Destroy();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ListenFrameChange(IntPtr l) {
		try {
			WeChatWASM.WXCamera self=(WeChatWASM.WXCamera)checkSelf(l);
			self.ListenFrameChange();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnAuthCancel(IntPtr l) {
		try {
			WeChatWASM.WXCamera self=(WeChatWASM.WXCamera)checkSelf(l);
			System.Action a1 = default(System.Action);
			checkDelegate(l,2,out a1);
			self.OnAuthCancel(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnCameraFrame(IntPtr l) {
		try {
			WeChatWASM.WXCamera self=(WeChatWASM.WXCamera)checkSelf(l);
			System.Action<WeChatWASM.OnCameraFrameCallbackResult> a1 = default(System.Action<WeChatWASM.OnCameraFrameCallbackResult>);
			checkDelegate(l,2,out a1);
			self.OnCameraFrame(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnStop(IntPtr l) {
		try {
			WeChatWASM.WXCamera self=(WeChatWASM.WXCamera)checkSelf(l);
			System.Action a1 = default(System.Action);
			checkDelegate(l,2,out a1);
			self.OnStop(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_OnCreateActionList(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,WeChatWASM.WXCamera.OnCreateActionList);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_OnCreateActionList(IntPtr l) {
		try {
			System.Collections.Generic.Dictionary<System.String,WeChatWASM.CreateCameraOption> v;
			checkType(l,2,out v);
			WeChatWASM.WXCamera.OnCreateActionList=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_OnAuthCancelActionList(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,WeChatWASM.WXCamera.OnAuthCancelActionList);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_OnAuthCancelActionList(IntPtr l) {
		try {
			System.Collections.Generic.Dictionary<System.String,System.Action> v;
			checkType(l,2,out v);
			WeChatWASM.WXCamera.OnAuthCancelActionList=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_OnCameraFrameActionList(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,WeChatWASM.WXCamera.OnCameraFrameActionList);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_OnCameraFrameActionList(IntPtr l) {
		try {
			System.Collections.Generic.Dictionary<System.String,System.Action<WeChatWASM.OnCameraFrameCallbackResult>> v;
			checkType(l,2,out v);
			WeChatWASM.WXCamera.OnCameraFrameActionList=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_OnStopActionList(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,WeChatWASM.WXCamera.OnStopActionList);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_OnStopActionList(IntPtr l) {
		try {
			System.Collections.Generic.Dictionary<System.String,System.Action> v;
			checkType(l,2,out v);
			WeChatWASM.WXCamera.OnStopActionList=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXCamera");
		addMember(l,CloseFrameChange);
		addMember(l,Destroy);
		addMember(l,ListenFrameChange);
		addMember(l,OnAuthCancel);
		addMember(l,OnCameraFrame);
		addMember(l,OnStop);
		addMember(l,"OnCreateActionList",get_OnCreateActionList,set_OnCreateActionList,false);
		addMember(l,"OnAuthCancelActionList",get_OnAuthCancelActionList,set_OnAuthCancelActionList,false);
		addMember(l,"OnCameraFrameActionList",get_OnCameraFrameActionList,set_OnCameraFrameActionList,false);
		addMember(l,"OnStopActionList",get_OnStopActionList,set_OnStopActionList,false);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXCamera));
	}
}
