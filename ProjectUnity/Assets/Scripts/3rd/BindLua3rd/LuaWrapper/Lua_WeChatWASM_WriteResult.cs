//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WriteResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WriteResult o;
			o=new WeChatWASM.WriteResult();
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
	static public int get_bytesWritten(IntPtr l) {
		try {
			WeChatWASM.WriteResult self=(WeChatWASM.WriteResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.bytesWritten);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_bytesWritten(IntPtr l) {
		try {
			WeChatWASM.WriteResult self=(WeChatWASM.WriteResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.bytesWritten=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WriteResult");
		addMember(l,"bytesWritten",get_bytesWritten,set_bytesWritten,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WriteResult));
	}
}
