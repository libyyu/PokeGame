//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_OnFrameRecordedBufferCallbackResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.OnFrameRecordedBufferCallbackResult o;
			o=new WeChatWASM.OnFrameRecordedBufferCallbackResult();
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
	static public int get_frameBufferLength(IntPtr l) {
		try {
			WeChatWASM.OnFrameRecordedBufferCallbackResult self=(WeChatWASM.OnFrameRecordedBufferCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.frameBufferLength);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_frameBufferLength(IntPtr l) {
		try {
			WeChatWASM.OnFrameRecordedBufferCallbackResult self=(WeChatWASM.OnFrameRecordedBufferCallbackResult)checkSelf(l);
			System.Int64 v;
			checkType(l,2,out v);
			self.frameBufferLength=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_isLastFrame(IntPtr l) {
		try {
			WeChatWASM.OnFrameRecordedBufferCallbackResult self=(WeChatWASM.OnFrameRecordedBufferCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isLastFrame);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_isLastFrame(IntPtr l) {
		try {
			WeChatWASM.OnFrameRecordedBufferCallbackResult self=(WeChatWASM.OnFrameRecordedBufferCallbackResult)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.isLastFrame=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.OnFrameRecordedBufferCallbackResult");
		addMember(l,"frameBufferLength",get_frameBufferLength,set_frameBufferLength,true);
		addMember(l,"isLastFrame",get_isLastFrame,set_isLastFrame,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.OnFrameRecordedBufferCallbackResult));
	}
}
