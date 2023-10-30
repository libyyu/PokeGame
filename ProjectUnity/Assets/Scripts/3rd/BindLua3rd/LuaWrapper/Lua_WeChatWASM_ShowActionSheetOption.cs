//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_ShowActionSheetOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.ShowActionSheetOption o;
			o=new WeChatWASM.ShowActionSheetOption();
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
	static public int get_itemList(IntPtr l) {
		try {
			WeChatWASM.ShowActionSheetOption self=(WeChatWASM.ShowActionSheetOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.itemList);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_itemList(IntPtr l) {
		try {
			WeChatWASM.ShowActionSheetOption self=(WeChatWASM.ShowActionSheetOption)checkSelf(l);
			System.String[] v;
			checkArray(l,2,out v);
			self.itemList=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_alertText(IntPtr l) {
		try {
			WeChatWASM.ShowActionSheetOption self=(WeChatWASM.ShowActionSheetOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.alertText);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_alertText(IntPtr l) {
		try {
			WeChatWASM.ShowActionSheetOption self=(WeChatWASM.ShowActionSheetOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.alertText=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_complete(IntPtr l) {
		try {
			WeChatWASM.ShowActionSheetOption self=(WeChatWASM.ShowActionSheetOption)checkSelf(l);
			System.Action<WeChatWASM.GeneralCallbackResult> v;
			int op=checkDelegate(l,2,out v);
			if(op==0) self.complete=v;
			else if(op==1) self.complete+=v;
			else if(op==2) self.complete-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_fail(IntPtr l) {
		try {
			WeChatWASM.ShowActionSheetOption self=(WeChatWASM.ShowActionSheetOption)checkSelf(l);
			System.Action<WeChatWASM.GeneralCallbackResult> v;
			int op=checkDelegate(l,2,out v);
			if(op==0) self.fail=v;
			else if(op==1) self.fail+=v;
			else if(op==2) self.fail-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_itemColor(IntPtr l) {
		try {
			WeChatWASM.ShowActionSheetOption self=(WeChatWASM.ShowActionSheetOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.itemColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_itemColor(IntPtr l) {
		try {
			WeChatWASM.ShowActionSheetOption self=(WeChatWASM.ShowActionSheetOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.itemColor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_success(IntPtr l) {
		try {
			WeChatWASM.ShowActionSheetOption self=(WeChatWASM.ShowActionSheetOption)checkSelf(l);
			System.Action<WeChatWASM.ShowActionSheetSuccessCallbackResult> v;
			int op=checkDelegate(l,2,out v);
			if(op==0) self.success=v;
			else if(op==1) self.success+=v;
			else if(op==2) self.success-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.ShowActionSheetOption");
		addMember(l,"itemList",get_itemList,set_itemList,true);
		addMember(l,"alertText",get_alertText,set_alertText,true);
		addMember(l,"complete",null,set_complete,true);
		addMember(l,"fail",null,set_fail,true);
		addMember(l,"itemColor",get_itemColor,set_itemColor,true);
		addMember(l,"success",null,set_success,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.ShowActionSheetOption));
	}
}
