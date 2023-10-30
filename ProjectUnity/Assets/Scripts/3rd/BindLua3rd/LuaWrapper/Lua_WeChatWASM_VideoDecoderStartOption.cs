//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_VideoDecoderStartOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.VideoDecoderStartOption o;
			o=new WeChatWASM.VideoDecoderStartOption();
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
	static public int get_source(IntPtr l) {
		try {
			WeChatWASM.VideoDecoderStartOption self=(WeChatWASM.VideoDecoderStartOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.source);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_source(IntPtr l) {
		try {
			WeChatWASM.VideoDecoderStartOption self=(WeChatWASM.VideoDecoderStartOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.source=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_abortAudio(IntPtr l) {
		try {
			WeChatWASM.VideoDecoderStartOption self=(WeChatWASM.VideoDecoderStartOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.abortAudio);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_abortAudio(IntPtr l) {
		try {
			WeChatWASM.VideoDecoderStartOption self=(WeChatWASM.VideoDecoderStartOption)checkSelf(l);
			System.Nullable<System.Boolean> v;
			checkNullable(l,2,out v);
			self.abortAudio=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_abortVideo(IntPtr l) {
		try {
			WeChatWASM.VideoDecoderStartOption self=(WeChatWASM.VideoDecoderStartOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.abortVideo);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_abortVideo(IntPtr l) {
		try {
			WeChatWASM.VideoDecoderStartOption self=(WeChatWASM.VideoDecoderStartOption)checkSelf(l);
			System.Nullable<System.Boolean> v;
			checkNullable(l,2,out v);
			self.abortVideo=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_mode(IntPtr l) {
		try {
			WeChatWASM.VideoDecoderStartOption self=(WeChatWASM.VideoDecoderStartOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.mode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_mode(IntPtr l) {
		try {
			WeChatWASM.VideoDecoderStartOption self=(WeChatWASM.VideoDecoderStartOption)checkSelf(l);
			System.Nullable<System.Double> v;
			checkNullable(l,2,out v);
			self.mode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.VideoDecoderStartOption");
		addMember(l,"source",get_source,set_source,true);
		addMember(l,"abortAudio",get_abortAudio,set_abortAudio,true);
		addMember(l,"abortVideo",get_abortVideo,set_abortVideo,true);
		addMember(l,"mode",get_mode,set_mode,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.VideoDecoderStartOption));
	}
}
