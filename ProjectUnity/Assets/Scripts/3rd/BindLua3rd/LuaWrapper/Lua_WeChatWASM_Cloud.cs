//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_Cloud : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.Cloud o;
			o=new WeChatWASM.Cloud();
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
	static public int Init(IntPtr l) {
		try {
			WeChatWASM.Cloud self=(WeChatWASM.Cloud)checkSelf(l);
			WeChatWASM.CallFunctionInitParam a1 = default(WeChatWASM.CallFunctionInitParam);
			checkType(l,2,out a1);
			self.Init(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CallFunction(IntPtr l) {
		try {
			WeChatWASM.Cloud self=(WeChatWASM.Cloud)checkSelf(l);
			WeChatWASM.CallFunctionParam a1 = default(WeChatWASM.CallFunctionParam);
			checkType(l,2,out a1);
			self.CallFunction(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CloudID(IntPtr l) {
		try {
			WeChatWASM.Cloud self=(WeChatWASM.Cloud)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			var ret=self.CloudID(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.Cloud");
		addMember(l,Init);
		addMember(l,CallFunction);
		addMember(l,CloudID);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.Cloud));
	}
}
