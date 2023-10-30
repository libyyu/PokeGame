//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_OnFrameRecordedCallbackResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.OnFrameRecordedCallbackResult o;
			o=new WeChatWASM.OnFrameRecordedCallbackResult();
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
	static public int get_frameBuffer(IntPtr l) {
		try {
			WeChatWASM.OnFrameRecordedCallbackResult self=(WeChatWASM.OnFrameRecordedCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.frameBuffer);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_frameBuffer(IntPtr l) {
		try {
			WeChatWASM.OnFrameRecordedCallbackResult self=(WeChatWASM.OnFrameRecordedCallbackResult)checkSelf(l);
			System.Byte[] v;
			checkArray(l,2,out v);
			self.frameBuffer=v;
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
			WeChatWASM.OnFrameRecordedCallbackResult self=(WeChatWASM.OnFrameRecordedCallbackResult)checkSelf(l);
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
			WeChatWASM.OnFrameRecordedCallbackResult self=(WeChatWASM.OnFrameRecordedCallbackResult)checkSelf(l);
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
		getTypeTable(l,"WeChatWASM.OnFrameRecordedCallbackResult");
		addMember(l,"frameBuffer",get_frameBuffer,set_frameBuffer,true);
		addMember(l,"isLastFrame",get_isLastFrame,set_isLastFrame,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.OnFrameRecordedCallbackResult));
	}
}
