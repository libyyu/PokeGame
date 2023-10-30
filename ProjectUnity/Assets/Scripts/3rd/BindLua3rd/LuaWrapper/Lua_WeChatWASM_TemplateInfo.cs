//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_TemplateInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.TemplateInfo o;
			o=new WeChatWASM.TemplateInfo();
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
	static public int get_parameterList(IntPtr l) {
		try {
			WeChatWASM.TemplateInfo self=(WeChatWASM.TemplateInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.parameterList);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_parameterList(IntPtr l) {
		try {
			WeChatWASM.TemplateInfo self=(WeChatWASM.TemplateInfo)checkSelf(l);
			WeChatWASM.TemplateInfoItem[] v;
			checkArray(l,2,out v);
			self.parameterList=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.TemplateInfo");
		addMember(l,"parameterList",get_parameterList,set_parameterList,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.TemplateInfo));
	}
}
