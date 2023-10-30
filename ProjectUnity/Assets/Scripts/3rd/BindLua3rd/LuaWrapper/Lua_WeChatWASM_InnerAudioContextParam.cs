//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_InnerAudioContextParam : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.InnerAudioContextParam o;
			o=new WeChatWASM.InnerAudioContextParam();
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
	static public int get_src(IntPtr l) {
		try {
			WeChatWASM.InnerAudioContextParam self=(WeChatWASM.InnerAudioContextParam)checkSelf(l);
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
			WeChatWASM.InnerAudioContextParam self=(WeChatWASM.InnerAudioContextParam)checkSelf(l);
			System.String v;
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
	static public int get_loop(IntPtr l) {
		try {
			WeChatWASM.InnerAudioContextParam self=(WeChatWASM.InnerAudioContextParam)checkSelf(l);
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
			WeChatWASM.InnerAudioContextParam self=(WeChatWASM.InnerAudioContextParam)checkSelf(l);
			System.Boolean v;
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
	static public int get_startTime(IntPtr l) {
		try {
			WeChatWASM.InnerAudioContextParam self=(WeChatWASM.InnerAudioContextParam)checkSelf(l);
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
			WeChatWASM.InnerAudioContextParam self=(WeChatWASM.InnerAudioContextParam)checkSelf(l);
			System.Single v;
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
	static public int get_autoplay(IntPtr l) {
		try {
			WeChatWASM.InnerAudioContextParam self=(WeChatWASM.InnerAudioContextParam)checkSelf(l);
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
			WeChatWASM.InnerAudioContextParam self=(WeChatWASM.InnerAudioContextParam)checkSelf(l);
			System.Boolean v;
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
	static public int get_volume(IntPtr l) {
		try {
			WeChatWASM.InnerAudioContextParam self=(WeChatWASM.InnerAudioContextParam)checkSelf(l);
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
			WeChatWASM.InnerAudioContextParam self=(WeChatWASM.InnerAudioContextParam)checkSelf(l);
			System.Single v;
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
	static public int get_playbackRate(IntPtr l) {
		try {
			WeChatWASM.InnerAudioContextParam self=(WeChatWASM.InnerAudioContextParam)checkSelf(l);
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
			WeChatWASM.InnerAudioContextParam self=(WeChatWASM.InnerAudioContextParam)checkSelf(l);
			System.Single v;
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
	static public int get_needDownload(IntPtr l) {
		try {
			WeChatWASM.InnerAudioContextParam self=(WeChatWASM.InnerAudioContextParam)checkSelf(l);
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
			WeChatWASM.InnerAudioContextParam self=(WeChatWASM.InnerAudioContextParam)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.needDownload=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.InnerAudioContextParam");
		addMember(l,"src",get_src,set_src,true);
		addMember(l,"loop",get_loop,set_loop,true);
		addMember(l,"startTime",get_startTime,set_startTime,true);
		addMember(l,"autoplay",get_autoplay,set_autoplay,true);
		addMember(l,"volume",get_volume,set_volume,true);
		addMember(l,"playbackRate",get_playbackRate,set_playbackRate,true);
		addMember(l,"needDownload",get_needDownload,set_needDownload,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.InnerAudioContextParam));
	}
}
