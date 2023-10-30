//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXVideo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXVideo o;
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			WeChatWASM.WXCreateVideoParam a2 = default(WeChatWASM.WXCreateVideoParam);
			checkType(l,3,out a2);
			o=new WeChatWASM.WXVideo(a1,a2);
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
			WeChatWASM.WXVideo self=(WeChatWASM.WXVideo)checkSelf(l);
			WeChatWASM.WXVideoCallback a1 = default(WeChatWASM.WXVideoCallback);
			checkType(l,2,out a1);
			self._HandleCallBack(a1);
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
			WeChatWASM.WXVideo self=(WeChatWASM.WXVideo)checkSelf(l);
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
	static public int OnPlay(IntPtr l) {
		try {
			WeChatWASM.WXVideo self=(WeChatWASM.WXVideo)checkSelf(l);
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
			WeChatWASM.WXVideo self=(WeChatWASM.WXVideo)checkSelf(l);
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
	static public int OnEnded(IntPtr l) {
		try {
			WeChatWASM.WXVideo self=(WeChatWASM.WXVideo)checkSelf(l);
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
			WeChatWASM.WXVideo self=(WeChatWASM.WXVideo)checkSelf(l);
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
	static public int OnError(IntPtr l) {
		try {
			WeChatWASM.WXVideo self=(WeChatWASM.WXVideo)checkSelf(l);
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
	static public int OffError(IntPtr l) {
		try {
			WeChatWASM.WXVideo self=(WeChatWASM.WXVideo)checkSelf(l);
			System.Action a1 = default(System.Action);
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
	static public int OnPause(IntPtr l) {
		try {
			WeChatWASM.WXVideo self=(WeChatWASM.WXVideo)checkSelf(l);
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
			WeChatWASM.WXVideo self=(WeChatWASM.WXVideo)checkSelf(l);
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
	static public int OnWaiting(IntPtr l) {
		try {
			WeChatWASM.WXVideo self=(WeChatWASM.WXVideo)checkSelf(l);
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
			WeChatWASM.WXVideo self=(WeChatWASM.WXVideo)checkSelf(l);
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
	static public int Destroy(IntPtr l) {
		try {
			WeChatWASM.WXVideo self=(WeChatWASM.WXVideo)checkSelf(l);
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
	static public int ExitFullScreen(IntPtr l) {
		try {
			WeChatWASM.WXVideo self=(WeChatWASM.WXVideo)checkSelf(l);
			self.ExitFullScreen();
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
			WeChatWASM.WXVideo self=(WeChatWASM.WXVideo)checkSelf(l);
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
	static public int RequestFullScreen(IntPtr l) {
		try {
			WeChatWASM.WXVideo self=(WeChatWASM.WXVideo)checkSelf(l);
			System.Int32 a1 = default(System.Int32);
			checkType(l,2,out a1);
			self.RequestFullScreen(a1);
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
			WeChatWASM.WXVideo self=(WeChatWASM.WXVideo)checkSelf(l);
			System.Int32 a1 = default(System.Int32);
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
	static public int Stop(IntPtr l) {
		try {
			WeChatWASM.WXVideo self=(WeChatWASM.WXVideo)checkSelf(l);
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
	static public int OnTimeUpdate(IntPtr l) {
		try {
			WeChatWASM.WXVideo self=(WeChatWASM.WXVideo)checkSelf(l);
			System.Action<WeChatWASM.WXVideoTimeUpdate> a1 = default(System.Action<WeChatWASM.WXVideoTimeUpdate>);
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
			WeChatWASM.WXVideo self=(WeChatWASM.WXVideo)checkSelf(l);
			System.Action<WeChatWASM.WXVideoTimeUpdate> a1 = default(System.Action<WeChatWASM.WXVideoTimeUpdate>);
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
	static public int OnProgress(IntPtr l) {
		try {
			WeChatWASM.WXVideo self=(WeChatWASM.WXVideo)checkSelf(l);
			System.Action<WeChatWASM.WXVideoProgress> a1 = default(System.Action<WeChatWASM.WXVideoProgress>);
			checkDelegate(l,2,out a1);
			self.OnProgress(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OffProgress(IntPtr l) {
		try {
			WeChatWASM.WXVideo self=(WeChatWASM.WXVideo)checkSelf(l);
			System.Action<WeChatWASM.WXVideoProgress> a1 = default(System.Action<WeChatWASM.WXVideoProgress>);
			checkDelegate(l,2,out a1);
			self.OffProgress(a1);
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
			WeChatWASM.WXVideo self=(WeChatWASM.WXVideo)checkSelf(l);
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
			WeChatWASM.WXVideo self=(WeChatWASM.WXVideo)checkSelf(l);
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
	static public int get__Dict(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,WeChatWASM.WXVideo._Dict);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set__Dict(IntPtr l) {
		try {
			System.Collections.Generic.Dictionary<System.String,WeChatWASM.WXVideo> v;
			checkType(l,2,out v);
			WeChatWASM.WXVideo._Dict=v;
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
			WeChatWASM.WXVideo self=(WeChatWASM.WXVideo)checkSelf(l);
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
			WeChatWASM.WXVideo self=(WeChatWASM.WXVideo)checkSelf(l);
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
	static public int get_poster(IntPtr l) {
		try {
			WeChatWASM.WXVideo self=(WeChatWASM.WXVideo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.poster);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_poster(IntPtr l) {
		try {
			WeChatWASM.WXVideo self=(WeChatWASM.WXVideo)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.poster=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_x(IntPtr l) {
		try {
			WeChatWASM.WXVideo self=(WeChatWASM.WXVideo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.x);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_x(IntPtr l) {
		try {
			WeChatWASM.WXVideo self=(WeChatWASM.WXVideo)checkSelf(l);
			double v;
			checkType(l,2,out v);
			self.x=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_y(IntPtr l) {
		try {
			WeChatWASM.WXVideo self=(WeChatWASM.WXVideo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.y);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_y(IntPtr l) {
		try {
			WeChatWASM.WXVideo self=(WeChatWASM.WXVideo)checkSelf(l);
			double v;
			checkType(l,2,out v);
			self.y=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_width(IntPtr l) {
		try {
			WeChatWASM.WXVideo self=(WeChatWASM.WXVideo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.width);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_width(IntPtr l) {
		try {
			WeChatWASM.WXVideo self=(WeChatWASM.WXVideo)checkSelf(l);
			double v;
			checkType(l,2,out v);
			self.width=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_height(IntPtr l) {
		try {
			WeChatWASM.WXVideo self=(WeChatWASM.WXVideo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.height);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_height(IntPtr l) {
		try {
			WeChatWASM.WXVideo self=(WeChatWASM.WXVideo)checkSelf(l);
			double v;
			checkType(l,2,out v);
			self.height=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_isPlaying(IntPtr l) {
		try {
			WeChatWASM.WXVideo self=(WeChatWASM.WXVideo)checkSelf(l);
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
		getTypeTable(l,"WeChatWASM.WXVideo");
		addMember(l,_HandleCallBack);
		addMember(l,Play);
		addMember(l,OnPlay);
		addMember(l,OffPlay);
		addMember(l,OnEnded);
		addMember(l,OffEnded);
		addMember(l,OnError);
		addMember(l,OffError);
		addMember(l,OnPause);
		addMember(l,OffPause);
		addMember(l,OnWaiting);
		addMember(l,OffWaiting);
		addMember(l,Destroy);
		addMember(l,ExitFullScreen);
		addMember(l,Pause);
		addMember(l,RequestFullScreen);
		addMember(l,Seek);
		addMember(l,Stop);
		addMember(l,OnTimeUpdate);
		addMember(l,OffTimeUpdate);
		addMember(l,OnProgress);
		addMember(l,OffProgress);
		addMember(l,"instanceId",get_instanceId,set_instanceId,true);
		addMember(l,"_Dict",get__Dict,set__Dict,false);
		addMember(l,"src",get_src,set_src,true);
		addMember(l,"poster",get_poster,set_poster,true);
		addMember(l,"x",get_x,set_x,true);
		addMember(l,"y",get_y,set_y,true);
		addMember(l,"width",get_width,set_width,true);
		addMember(l,"height",get_height,set_height,true);
		addMember(l,"isPlaying",get_isPlaying,null,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXVideo));
	}
}
