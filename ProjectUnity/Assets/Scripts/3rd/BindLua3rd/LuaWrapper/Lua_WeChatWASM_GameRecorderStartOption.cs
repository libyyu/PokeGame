//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_GameRecorderStartOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.GameRecorderStartOption o;
			o=new WeChatWASM.GameRecorderStartOption();
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
	static public int get_bitrate(IntPtr l) {
		try {
			WeChatWASM.GameRecorderStartOption self=(WeChatWASM.GameRecorderStartOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.bitrate);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_bitrate(IntPtr l) {
		try {
			WeChatWASM.GameRecorderStartOption self=(WeChatWASM.GameRecorderStartOption)checkSelf(l);
			System.Nullable<System.Double> v;
			checkNullable(l,2,out v);
			self.bitrate=v;
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
			WeChatWASM.GameRecorderStartOption self=(WeChatWASM.GameRecorderStartOption)checkSelf(l);
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
	static public int set_duration(IntPtr l) {
		try {
			WeChatWASM.GameRecorderStartOption self=(WeChatWASM.GameRecorderStartOption)checkSelf(l);
			System.Nullable<System.Double> v;
			checkNullable(l,2,out v);
			self.duration=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_fps(IntPtr l) {
		try {
			WeChatWASM.GameRecorderStartOption self=(WeChatWASM.GameRecorderStartOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.fps);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_fps(IntPtr l) {
		try {
			WeChatWASM.GameRecorderStartOption self=(WeChatWASM.GameRecorderStartOption)checkSelf(l);
			System.Nullable<System.Double> v;
			checkNullable(l,2,out v);
			self.fps=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_gop(IntPtr l) {
		try {
			WeChatWASM.GameRecorderStartOption self=(WeChatWASM.GameRecorderStartOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.gop);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_gop(IntPtr l) {
		try {
			WeChatWASM.GameRecorderStartOption self=(WeChatWASM.GameRecorderStartOption)checkSelf(l);
			System.Nullable<System.Double> v;
			checkNullable(l,2,out v);
			self.gop=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_hookBgm(IntPtr l) {
		try {
			WeChatWASM.GameRecorderStartOption self=(WeChatWASM.GameRecorderStartOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.hookBgm);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_hookBgm(IntPtr l) {
		try {
			WeChatWASM.GameRecorderStartOption self=(WeChatWASM.GameRecorderStartOption)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.hookBgm=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.GameRecorderStartOption");
		addMember(l,"bitrate",get_bitrate,set_bitrate,true);
		addMember(l,"duration",get_duration,set_duration,true);
		addMember(l,"fps",get_fps,set_fps,true);
		addMember(l,"gop",get_gop,set_gop,true);
		addMember(l,"hookBgm",get_hookBgm,set_hookBgm,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.GameRecorderStartOption));
	}
}
