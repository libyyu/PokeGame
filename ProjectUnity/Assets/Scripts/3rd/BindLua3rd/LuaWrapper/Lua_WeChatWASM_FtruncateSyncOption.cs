//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_FtruncateSyncOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.FtruncateSyncOption o;
			o=new WeChatWASM.FtruncateSyncOption();
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
	static public int get_fd(IntPtr l) {
		try {
			WeChatWASM.FtruncateSyncOption self=(WeChatWASM.FtruncateSyncOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.fd);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_fd(IntPtr l) {
		try {
			WeChatWASM.FtruncateSyncOption self=(WeChatWASM.FtruncateSyncOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.fd=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_length(IntPtr l) {
		try {
			WeChatWASM.FtruncateSyncOption self=(WeChatWASM.FtruncateSyncOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.length);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_length(IntPtr l) {
		try {
			WeChatWASM.FtruncateSyncOption self=(WeChatWASM.FtruncateSyncOption)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.length=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.FtruncateSyncOption");
		addMember(l,"fd",get_fd,set_fd,true);
		addMember(l,"length",get_length,set_length,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.FtruncateSyncOption));
	}
}
