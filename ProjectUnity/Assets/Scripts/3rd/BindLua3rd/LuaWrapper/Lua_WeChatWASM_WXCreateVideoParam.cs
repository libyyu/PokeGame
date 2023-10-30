//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXCreateVideoParam : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXCreateVideoParam o;
			o=new WeChatWASM.WXCreateVideoParam();
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
	static public int get_x(IntPtr l) {
		try {
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
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
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
			System.Int32 v;
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
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
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
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
			System.Int32 v;
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
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
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
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
			System.Int32 v;
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
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
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
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
			System.Int32 v;
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
	static public int get_src(IntPtr l) {
		try {
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
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
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
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
	static public int get_poster(IntPtr l) {
		try {
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
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
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
			System.String v;
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
	static public int get_initialTime(IntPtr l) {
		try {
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.initialTime);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_initialTime(IntPtr l) {
		try {
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.initialTime=v;
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
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
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
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
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
	static public int get_live(IntPtr l) {
		try {
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.live);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_live(IntPtr l) {
		try {
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.live=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_objectFit(IntPtr l) {
		try {
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.objectFit);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_objectFit(IntPtr l) {
		try {
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.objectFit=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_controls(IntPtr l) {
		try {
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.controls);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_controls(IntPtr l) {
		try {
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.controls=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_showProgress(IntPtr l) {
		try {
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.showProgress);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_showProgress(IntPtr l) {
		try {
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.showProgress=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_showProgressInControlMode(IntPtr l) {
		try {
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.showProgressInControlMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_showProgressInControlMode(IntPtr l) {
		try {
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.showProgressInControlMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_backgroundColor(IntPtr l) {
		try {
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.backgroundColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_backgroundColor(IntPtr l) {
		try {
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.backgroundColor=v;
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
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
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
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
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
	static public int get_loop(IntPtr l) {
		try {
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
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
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
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
	static public int get_muted(IntPtr l) {
		try {
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.muted);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_muted(IntPtr l) {
		try {
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.muted=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_obeyMuteSwitch(IntPtr l) {
		try {
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.obeyMuteSwitch);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_obeyMuteSwitch(IntPtr l) {
		try {
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.obeyMuteSwitch=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_enableProgressGesture(IntPtr l) {
		try {
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.enableProgressGesture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_enableProgressGesture(IntPtr l) {
		try {
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.enableProgressGesture=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_enablePlayGesture(IntPtr l) {
		try {
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.enablePlayGesture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_enablePlayGesture(IntPtr l) {
		try {
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.enablePlayGesture=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_showCenterPlayBtn(IntPtr l) {
		try {
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.showCenterPlayBtn);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_showCenterPlayBtn(IntPtr l) {
		try {
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.showCenterPlayBtn=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_underGameView(IntPtr l) {
		try {
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.underGameView);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_underGameView(IntPtr l) {
		try {
			WeChatWASM.WXCreateVideoParam self=(WeChatWASM.WXCreateVideoParam)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.underGameView=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXCreateVideoParam");
		addMember(l,"x",get_x,set_x,true);
		addMember(l,"y",get_y,set_y,true);
		addMember(l,"width",get_width,set_width,true);
		addMember(l,"height",get_height,set_height,true);
		addMember(l,"src",get_src,set_src,true);
		addMember(l,"poster",get_poster,set_poster,true);
		addMember(l,"initialTime",get_initialTime,set_initialTime,true);
		addMember(l,"playbackRate",get_playbackRate,set_playbackRate,true);
		addMember(l,"live",get_live,set_live,true);
		addMember(l,"objectFit",get_objectFit,set_objectFit,true);
		addMember(l,"controls",get_controls,set_controls,true);
		addMember(l,"showProgress",get_showProgress,set_showProgress,true);
		addMember(l,"showProgressInControlMode",get_showProgressInControlMode,set_showProgressInControlMode,true);
		addMember(l,"backgroundColor",get_backgroundColor,set_backgroundColor,true);
		addMember(l,"autoplay",get_autoplay,set_autoplay,true);
		addMember(l,"loop",get_loop,set_loop,true);
		addMember(l,"muted",get_muted,set_muted,true);
		addMember(l,"obeyMuteSwitch",get_obeyMuteSwitch,set_obeyMuteSwitch,true);
		addMember(l,"enableProgressGesture",get_enableProgressGesture,set_enableProgressGesture,true);
		addMember(l,"enablePlayGesture",get_enablePlayGesture,set_enablePlayGesture,true);
		addMember(l,"showCenterPlayBtn",get_showCenterPlayBtn,set_showCenterPlayBtn,true);
		addMember(l,"underGameView",get_underGameView,set_underGameView,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXCreateVideoParam));
	}
}
