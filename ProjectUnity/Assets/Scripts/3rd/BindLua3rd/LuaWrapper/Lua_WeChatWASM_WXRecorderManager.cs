//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXRecorderManager : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXRecorderManager o;
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			o=new WeChatWASM.WXRecorderManager(a1);
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
	static public int OnError(IntPtr l) {
		try {
			WeChatWASM.WXRecorderManager self=(WeChatWASM.WXRecorderManager)checkSelf(l);
			System.Action a1 = default(System.Action);
			checkDelegate(l,2,out a1);
			self.OnError(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnFrameRecorded(IntPtr l) {
		try {
			WeChatWASM.WXRecorderManager self=(WeChatWASM.WXRecorderManager)checkSelf(l);
			System.Action<WeChatWASM.OnFrameRecordedCallbackResult> a1 = default(System.Action<WeChatWASM.OnFrameRecordedCallbackResult>);
			checkDelegate(l,2,out a1);
			self.OnFrameRecorded(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnInterruptionBegin(IntPtr l) {
		try {
			WeChatWASM.WXRecorderManager self=(WeChatWASM.WXRecorderManager)checkSelf(l);
			System.Action a1 = default(System.Action);
			checkDelegate(l,2,out a1);
			self.OnInterruptionBegin(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnInterruptionEnd(IntPtr l) {
		try {
			WeChatWASM.WXRecorderManager self=(WeChatWASM.WXRecorderManager)checkSelf(l);
			System.Action a1 = default(System.Action);
			checkDelegate(l,2,out a1);
			self.OnInterruptionEnd(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnPause(IntPtr l) {
		try {
			WeChatWASM.WXRecorderManager self=(WeChatWASM.WXRecorderManager)checkSelf(l);
			System.Action a1 = default(System.Action);
			checkDelegate(l,2,out a1);
			self.OnPause(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnResume(IntPtr l) {
		try {
			WeChatWASM.WXRecorderManager self=(WeChatWASM.WXRecorderManager)checkSelf(l);
			System.Action a1 = default(System.Action);
			checkDelegate(l,2,out a1);
			self.OnResume(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnStart(IntPtr l) {
		try {
			WeChatWASM.WXRecorderManager self=(WeChatWASM.WXRecorderManager)checkSelf(l);
			System.Action a1 = default(System.Action);
			checkDelegate(l,2,out a1);
			self.OnStart(a1);
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
			WeChatWASM.WXRecorderManager self=(WeChatWASM.WXRecorderManager)checkSelf(l);
			System.Action<WeChatWASM.OnStopCallbackResult> a1 = default(System.Action<WeChatWASM.OnStopCallbackResult>);
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
	static public int Pause(IntPtr l) {
		try {
			WeChatWASM.WXRecorderManager self=(WeChatWASM.WXRecorderManager)checkSelf(l);
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
			WeChatWASM.WXRecorderManager self=(WeChatWASM.WXRecorderManager)checkSelf(l);
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
	static public int Start(IntPtr l) {
		try {
			WeChatWASM.WXRecorderManager self=(WeChatWASM.WXRecorderManager)checkSelf(l);
			WeChatWASM.RecorderManagerStartOption a1 = default(WeChatWASM.RecorderManagerStartOption);
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
	static public int Stop(IntPtr l) {
		try {
			WeChatWASM.WXRecorderManager self=(WeChatWASM.WXRecorderManager)checkSelf(l);
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
	static public int get_OnRecorderErrorActionList(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,WeChatWASM.WXRecorderManager.OnRecorderErrorActionList);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_OnRecorderErrorActionList(IntPtr l) {
		try {
			System.Collections.Generic.Dictionary<System.String,System.Action> v;
			checkType(l,2,out v);
			WeChatWASM.WXRecorderManager.OnRecorderErrorActionList=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_OnRecorderFrameRecordedActionList(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,WeChatWASM.WXRecorderManager.OnRecorderFrameRecordedActionList);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_OnRecorderFrameRecordedActionList(IntPtr l) {
		try {
			System.Collections.Generic.Dictionary<System.String,System.Action<WeChatWASM.OnFrameRecordedCallbackResult>> v;
			checkType(l,2,out v);
			WeChatWASM.WXRecorderManager.OnRecorderFrameRecordedActionList=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_OnRecorderInterruptionBeginActionList(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,WeChatWASM.WXRecorderManager.OnRecorderInterruptionBeginActionList);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_OnRecorderInterruptionBeginActionList(IntPtr l) {
		try {
			System.Collections.Generic.Dictionary<System.String,System.Action> v;
			checkType(l,2,out v);
			WeChatWASM.WXRecorderManager.OnRecorderInterruptionBeginActionList=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_OnRecorderInterruptionEndActionList(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,WeChatWASM.WXRecorderManager.OnRecorderInterruptionEndActionList);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_OnRecorderInterruptionEndActionList(IntPtr l) {
		try {
			System.Collections.Generic.Dictionary<System.String,System.Action> v;
			checkType(l,2,out v);
			WeChatWASM.WXRecorderManager.OnRecorderInterruptionEndActionList=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_OnRecorderPauseActionList(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,WeChatWASM.WXRecorderManager.OnRecorderPauseActionList);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_OnRecorderPauseActionList(IntPtr l) {
		try {
			System.Collections.Generic.Dictionary<System.String,System.Action> v;
			checkType(l,2,out v);
			WeChatWASM.WXRecorderManager.OnRecorderPauseActionList=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_OnRecorderResumeActionList(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,WeChatWASM.WXRecorderManager.OnRecorderResumeActionList);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_OnRecorderResumeActionList(IntPtr l) {
		try {
			System.Collections.Generic.Dictionary<System.String,System.Action> v;
			checkType(l,2,out v);
			WeChatWASM.WXRecorderManager.OnRecorderResumeActionList=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_OnRecorderStartActionList(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,WeChatWASM.WXRecorderManager.OnRecorderStartActionList);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_OnRecorderStartActionList(IntPtr l) {
		try {
			System.Collections.Generic.Dictionary<System.String,System.Action> v;
			checkType(l,2,out v);
			WeChatWASM.WXRecorderManager.OnRecorderStartActionList=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_OnRecorderStopActionList(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,WeChatWASM.WXRecorderManager.OnRecorderStopActionList);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_OnRecorderStopActionList(IntPtr l) {
		try {
			System.Collections.Generic.Dictionary<System.String,System.Action<WeChatWASM.OnStopCallbackResult>> v;
			checkType(l,2,out v);
			WeChatWASM.WXRecorderManager.OnRecorderStopActionList=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXRecorderManager");
		addMember(l,OnError);
		addMember(l,OnFrameRecorded);
		addMember(l,OnInterruptionBegin);
		addMember(l,OnInterruptionEnd);
		addMember(l,OnPause);
		addMember(l,OnResume);
		addMember(l,OnStart);
		addMember(l,OnStop);
		addMember(l,Pause);
		addMember(l,Resume);
		addMember(l,Start);
		addMember(l,Stop);
		addMember(l,"OnRecorderErrorActionList",get_OnRecorderErrorActionList,set_OnRecorderErrorActionList,false);
		addMember(l,"OnRecorderFrameRecordedActionList",get_OnRecorderFrameRecordedActionList,set_OnRecorderFrameRecordedActionList,false);
		addMember(l,"OnRecorderInterruptionBeginActionList",get_OnRecorderInterruptionBeginActionList,set_OnRecorderInterruptionBeginActionList,false);
		addMember(l,"OnRecorderInterruptionEndActionList",get_OnRecorderInterruptionEndActionList,set_OnRecorderInterruptionEndActionList,false);
		addMember(l,"OnRecorderPauseActionList",get_OnRecorderPauseActionList,set_OnRecorderPauseActionList,false);
		addMember(l,"OnRecorderResumeActionList",get_OnRecorderResumeActionList,set_OnRecorderResumeActionList,false);
		addMember(l,"OnRecorderStartActionList",get_OnRecorderStartActionList,set_OnRecorderStartActionList,false);
		addMember(l,"OnRecorderStopActionList",get_OnRecorderStopActionList,set_OnRecorderStopActionList,false);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXRecorderManager));
	}
}
