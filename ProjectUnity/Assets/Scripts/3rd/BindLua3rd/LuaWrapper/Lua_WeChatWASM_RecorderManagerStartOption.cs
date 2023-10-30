//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_RecorderManagerStartOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.RecorderManagerStartOption o;
			o=new WeChatWASM.RecorderManagerStartOption();
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
	static public int get_audioSource(IntPtr l) {
		try {
			WeChatWASM.RecorderManagerStartOption self=(WeChatWASM.RecorderManagerStartOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.audioSource);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_audioSource(IntPtr l) {
		try {
			WeChatWASM.RecorderManagerStartOption self=(WeChatWASM.RecorderManagerStartOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.audioSource=v;
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
			WeChatWASM.RecorderManagerStartOption self=(WeChatWASM.RecorderManagerStartOption)checkSelf(l);
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
			WeChatWASM.RecorderManagerStartOption self=(WeChatWASM.RecorderManagerStartOption)checkSelf(l);
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
	static public int get_encodeBitRate(IntPtr l) {
		try {
			WeChatWASM.RecorderManagerStartOption self=(WeChatWASM.RecorderManagerStartOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.encodeBitRate);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_encodeBitRate(IntPtr l) {
		try {
			WeChatWASM.RecorderManagerStartOption self=(WeChatWASM.RecorderManagerStartOption)checkSelf(l);
			System.Nullable<System.Double> v;
			checkNullable(l,2,out v);
			self.encodeBitRate=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_format(IntPtr l) {
		try {
			WeChatWASM.RecorderManagerStartOption self=(WeChatWASM.RecorderManagerStartOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.format);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_format(IntPtr l) {
		try {
			WeChatWASM.RecorderManagerStartOption self=(WeChatWASM.RecorderManagerStartOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.format=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_frameSize(IntPtr l) {
		try {
			WeChatWASM.RecorderManagerStartOption self=(WeChatWASM.RecorderManagerStartOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.frameSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_frameSize(IntPtr l) {
		try {
			WeChatWASM.RecorderManagerStartOption self=(WeChatWASM.RecorderManagerStartOption)checkSelf(l);
			System.Nullable<System.Double> v;
			checkNullable(l,2,out v);
			self.frameSize=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_numberOfChannels(IntPtr l) {
		try {
			WeChatWASM.RecorderManagerStartOption self=(WeChatWASM.RecorderManagerStartOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.numberOfChannels);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_numberOfChannels(IntPtr l) {
		try {
			WeChatWASM.RecorderManagerStartOption self=(WeChatWASM.RecorderManagerStartOption)checkSelf(l);
			System.Nullable<System.Double> v;
			checkNullable(l,2,out v);
			self.numberOfChannels=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_sampleRate(IntPtr l) {
		try {
			WeChatWASM.RecorderManagerStartOption self=(WeChatWASM.RecorderManagerStartOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.sampleRate);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_sampleRate(IntPtr l) {
		try {
			WeChatWASM.RecorderManagerStartOption self=(WeChatWASM.RecorderManagerStartOption)checkSelf(l);
			System.Nullable<System.Double> v;
			checkNullable(l,2,out v);
			self.sampleRate=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.RecorderManagerStartOption");
		addMember(l,"audioSource",get_audioSource,set_audioSource,true);
		addMember(l,"duration",get_duration,set_duration,true);
		addMember(l,"encodeBitRate",get_encodeBitRate,set_encodeBitRate,true);
		addMember(l,"format",get_format,set_format,true);
		addMember(l,"frameSize",get_frameSize,set_frameSize,true);
		addMember(l,"numberOfChannels",get_numberOfChannels,set_numberOfChannels,true);
		addMember(l,"sampleRate",get_sampleRate,set_sampleRate,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.RecorderManagerStartOption));
	}
}
