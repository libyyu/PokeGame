//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_OnHeadersReceivedListenerResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.OnHeadersReceivedListenerResult o;
			o=new WeChatWASM.OnHeadersReceivedListenerResult();
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
	static public int get_header(IntPtr l) {
		try {
			WeChatWASM.OnHeadersReceivedListenerResult self=(WeChatWASM.OnHeadersReceivedListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.header);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_header(IntPtr l) {
		try {
			WeChatWASM.OnHeadersReceivedListenerResult self=(WeChatWASM.OnHeadersReceivedListenerResult)checkSelf(l);
			System.Collections.Generic.Dictionary<System.String,System.String> v;
			checkType(l,2,out v);
			self.header=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.OnHeadersReceivedListenerResult");
		addMember(l,"header",get_header,set_header,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.OnHeadersReceivedListenerResult));
	}
}
