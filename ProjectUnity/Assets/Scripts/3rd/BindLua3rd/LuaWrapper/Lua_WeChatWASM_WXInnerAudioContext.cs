//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXInnerAudioContext : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext o;
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			WeChatWASM.InnerAudioContextParam a2 = default(WeChatWASM.InnerAudioContextParam);
			checkType(l,3,out a2);
			o=new WeChatWASM.WXInnerAudioContext(a1,a2);
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
	static public int _HandleCallBack(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			System.String a2 = default(System.String);
			checkType(l,3,out a2);
			self._HandleCallBack(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Play(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			self.Play();
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
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
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
	static public int Stop(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
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
	static public int Seek(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			System.Single a1 = default(System.Single);
			checkType(l,2,out a1);
			self.Seek(a1);
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
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
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
	static public int OnCanplay(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			System.Action a1 = default(System.Action);
			checkDelegate(l,2,out a1);
			self.OnCanplay(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffCanplay(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			System.Action a1 = default(System.Action);
			checkDelegate(l,2,out a1);
			self.OffCanplay(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnPlay(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			System.Action a1 = default(System.Action);
			checkDelegate(l,2,out a1);
			self.OnPlay(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffPlay(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			System.Action a1 = default(System.Action);
			checkDelegate(l,2,out a1);
			self.OffPlay(a1);
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
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
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
	static public int OffPause(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			System.Action a1 = default(System.Action);
			checkDelegate(l,2,out a1);
			self.OffPause(a1);
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
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
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
	static public int OffStop(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			System.Action a1 = default(System.Action);
			checkDelegate(l,2,out a1);
			self.OffStop(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnEnded(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			System.Action a1 = default(System.Action);
			checkDelegate(l,2,out a1);
			self.OnEnded(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffEnded(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			System.Action a1 = default(System.Action);
			checkDelegate(l,2,out a1);
			self.OffEnded(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnTimeUpdate(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			System.Action a1 = default(System.Action);
			checkDelegate(l,2,out a1);
			self.OnTimeUpdate(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffTimeUpdate(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			System.Action a1 = default(System.Action);
			checkDelegate(l,2,out a1);
			self.OffTimeUpdate(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnError(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			System.Action<WeChatWASM.InnerAudioContextOnErrorListenerResult> a1 = default(System.Action<WeChatWASM.InnerAudioContextOnErrorListenerResult>);
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
	static public int OffError(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			System.Action<WeChatWASM.InnerAudioContextOnErrorListenerResult> a1 = default(System.Action<WeChatWASM.InnerAudioContextOnErrorListenerResult>);
			checkDelegate(l,2,out a1);
			self.OffError(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnWaiting(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			System.Action a1 = default(System.Action);
			checkDelegate(l,2,out a1);
			self.OnWaiting(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffWaiting(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			System.Action a1 = default(System.Action);
			checkDelegate(l,2,out a1);
			self.OffWaiting(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnSeeking(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			System.Action a1 = default(System.Action);
			checkDelegate(l,2,out a1);
			self.OnSeeking(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffSeeking(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			System.Action a1 = default(System.Action);
			checkDelegate(l,2,out a1);
			self.OffSeeking(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnSeeked(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			System.Action a1 = default(System.Action);
			checkDelegate(l,2,out a1);
			self.OnSeeked(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffSeeked(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			System.Action a1 = default(System.Action);
			checkDelegate(l,2,out a1);
			self.OffSeeked(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_ht(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.ht);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_ht(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			System.Collections.Hashtable v;
			checkType(l,2,out v);
			self.ht=v;
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
			pushValue(l,WeChatWASM.WXInnerAudioContext.Dict);
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
			System.Collections.Generic.Dictionary<System.String,WeChatWASM.WXInnerAudioContext> v;
			checkType(l,2,out v);
			WeChatWASM.WXInnerAudioContext.Dict=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_instanceId(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.instanceId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_instanceId(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.instanceId=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_autoplay(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.autoplay);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_autoplay(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.autoplay=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_src(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.src);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_src(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.src=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_needDownload(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.needDownload);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_needDownload(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.needDownload=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_startTime(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.startTime);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_startTime(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.startTime=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_loop(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.loop);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_loop(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.loop=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_volume(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.volume);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_volume(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.volume=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_mute(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.mute);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_mute(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.mute=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_playbackRate(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.playbackRate);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_playbackRate(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.playbackRate=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_duration(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.duration);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_currentTime(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.currentTime);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_buffered(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.buffered);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_paused(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.paused);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_isPlaying(IntPtr l) {
		try {
			WeChatWASM.WXInnerAudioContext self=(WeChatWASM.WXInnerAudioContext)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isPlaying);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXInnerAudioContext");
		addMember(l,_HandleCallBack);
		addMember(l,Play);
		addMember(l,Pause);
		addMember(l,Stop);
		addMember(l,Seek);
		addMember(l,Destroy);
		addMember(l,OnCanplay);
		addMember(l,OffCanplay);
		addMember(l,OnPlay);
		addMember(l,OffPlay);
		addMember(l,OnPause);
		addMember(l,OffPause);
		addMember(l,OnStop);
		addMember(l,OffStop);
		addMember(l,OnEnded);
		addMember(l,OffEnded);
		addMember(l,OnTimeUpdate);
		addMember(l,OffTimeUpdate);
		addMember(l,OnError);
		addMember(l,OffError);
		addMember(l,OnWaiting);
		addMember(l,OffWaiting);
		addMember(l,OnSeeking);
		addMember(l,OffSeeking);
		addMember(l,OnSeeked);
		addMember(l,OffSeeked);
		addMember(l,"ht",get_ht,set_ht,true);
		addMember(l,"Dict",get_Dict,set_Dict,false);
		addMember(l,"instanceId",get_instanceId,set_instanceId,true);
		addMember(l,"autoplay",get_autoplay,set_autoplay,true);
		addMember(l,"src",get_src,set_src,true);
		addMember(l,"needDownload",get_needDownload,set_needDownload,true);
		addMember(l,"startTime",get_startTime,set_startTime,true);
		addMember(l,"loop",get_loop,set_loop,true);
		addMember(l,"volume",get_volume,set_volume,true);
		addMember(l,"mute",get_mute,set_mute,true);
		addMember(l,"playbackRate",get_playbackRate,set_playbackRate,true);
		addMember(l,"duration",get_duration,null,true);
		addMember(l,"currentTime",get_currentTime,null,true);
		addMember(l,"buffered",get_buffered,null,true);
		addMember(l,"paused",get_paused,null,true);
		addMember(l,"isPlaying",get_isPlaying,null,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXInnerAudioContext));
	}
}
