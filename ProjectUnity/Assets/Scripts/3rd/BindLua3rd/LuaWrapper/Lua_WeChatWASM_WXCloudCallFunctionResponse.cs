//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXCloudCallFunctionResponse : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXCloudCallFunctionResponse o;
			o=new WeChatWASM.WXCloudCallFunctionResponse();
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
	static public int get_result(IntPtr l) {
		try {
			WeChatWASM.WXCloudCallFunctionResponse self=(WeChatWASM.WXCloudCallFunctionResponse)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.result);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_result(IntPtr l) {
		try {
			WeChatWASM.WXCloudCallFunctionResponse self=(WeChatWASM.WXCloudCallFunctionResponse)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.result=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_requestID(IntPtr l) {
		try {
			WeChatWASM.WXCloudCallFunctionResponse self=(WeChatWASM.WXCloudCallFunctionResponse)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.requestID);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_requestID(IntPtr l) {
		try {
			WeChatWASM.WXCloudCallFunctionResponse self=(WeChatWASM.WXCloudCallFunctionResponse)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.requestID=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXCloudCallFunctionResponse");
		addMember(l,"result",get_result,set_result,true);
		addMember(l,"requestID",get_requestID,set_requestID,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXCloudCallFunctionResponse),typeof(WeChatWASM.WXBaseResponse));
	}
}
