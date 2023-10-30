//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXStatResponse : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXStatResponse o;
			o=new WeChatWASM.WXStatResponse();
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
	static public int get_stats(IntPtr l) {
		try {
			WeChatWASM.WXStatResponse self=(WeChatWASM.WXStatResponse)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.stats);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_stats(IntPtr l) {
		try {
			WeChatWASM.WXStatResponse self=(WeChatWASM.WXStatResponse)checkSelf(l);
			System.Collections.Generic.List<WeChatWASM.WXStat> v;
			checkType(l,2,out v);
			self.stats=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_one_stat(IntPtr l) {
		try {
			WeChatWASM.WXStatResponse self=(WeChatWASM.WXStatResponse)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.one_stat);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_one_stat(IntPtr l) {
		try {
			WeChatWASM.WXStatResponse self=(WeChatWASM.WXStatResponse)checkSelf(l);
			WeChatWASM.WXStatInfo v;
			checkType(l,2,out v);
			self.one_stat=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXStatResponse");
		addMember(l,"stats",get_stats,set_stats,true);
		addMember(l,"one_stat",get_one_stat,set_one_stat,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXStatResponse),typeof(WeChatWASM.WXBaseResponse));
	}
}
