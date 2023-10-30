//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_GetUserCurrentGameliveInfoSuccessCallbackOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.GetUserCurrentGameliveInfoSuccessCallbackOption o;
			o=new WeChatWASM.GetUserCurrentGameliveInfoSuccessCallbackOption();
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
	static public int get_feedIdList(IntPtr l) {
		try {
			WeChatWASM.GetUserCurrentGameliveInfoSuccessCallbackOption self=(WeChatWASM.GetUserCurrentGameliveInfoSuccessCallbackOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.feedIdList);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_feedIdList(IntPtr l) {
		try {
			WeChatWASM.GetUserCurrentGameliveInfoSuccessCallbackOption self=(WeChatWASM.GetUserCurrentGameliveInfoSuccessCallbackOption)checkSelf(l);
			System.String[] v;
			checkArray(l,2,out v);
			self.feedIdList=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.GetUserCurrentGameliveInfoSuccessCallbackOption");
		addMember(l,"feedIdList",get_feedIdList,set_feedIdList,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.GetUserCurrentGameliveInfoSuccessCallbackOption));
	}
}
