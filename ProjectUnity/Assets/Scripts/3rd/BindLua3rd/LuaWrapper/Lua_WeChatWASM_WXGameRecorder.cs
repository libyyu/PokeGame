//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXGameRecorder : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXGameRecorder o;
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			o=new WeChatWASM.WXGameRecorder(a1);
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
	static public int Off(IntPtr l) {
		try {
			WeChatWASM.WXGameRecorder self=(WeChatWASM.WXGameRecorder)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.Off(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int On(IntPtr l) {
		try {
			WeChatWASM.WXGameRecorder self=(WeChatWASM.WXGameRecorder)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			System.Action<WeChatWASM.GameRecorderCallbackRes> a2 = default(System.Action<WeChatWASM.GameRecorderCallbackRes>);
			checkDelegate(l,3,out a2);
			self.On(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Start(IntPtr l) {
		try {
			WeChatWASM.WXGameRecorder self=(WeChatWASM.WXGameRecorder)checkSelf(l);
			WeChatWASM.GameRecorderStartOption a1 = default(WeChatWASM.GameRecorderStartOption);
			checkType(l,2,out a1);
			self.Start(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Abort(IntPtr l) {
		try {
			WeChatWASM.WXGameRecorder self=(WeChatWASM.WXGameRecorder)checkSelf(l);
			self.Abort();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Pause(IntPtr l) {
		try {
			WeChatWASM.WXGameRecorder self=(WeChatWASM.WXGameRecorder)checkSelf(l);
			self.Pause();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Resume(IntPtr l) {
		try {
			WeChatWASM.WXGameRecorder self=(WeChatWASM.WXGameRecorder)checkSelf(l);
			self.Resume();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Stop(IntPtr l) {
		try {
			WeChatWASM.WXGameRecorder self=(WeChatWASM.WXGameRecorder)checkSelf(l);
			self.Stop();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_OnActionList(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,WeChatWASM.WXGameRecorder.OnActionList);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_OnActionList(IntPtr l) {
		try {
			System.Collections.Generic.Dictionary<System.String,System.Action<WeChatWASM.GameRecorderCallbackRes>> v;
			checkType(l,2,out v);
			WeChatWASM.WXGameRecorder.OnActionList=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXGameRecorder");
		addMember(l,Off);
		addMember(l,On);
		addMember(l,Start);
		addMember(l,Abort);
		addMember(l,Pause);
		addMember(l,Resume);
		addMember(l,Stop);
		addMember(l,"OnActionList",get_OnActionList,set_OnActionList,false);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXGameRecorder));
	}
}
