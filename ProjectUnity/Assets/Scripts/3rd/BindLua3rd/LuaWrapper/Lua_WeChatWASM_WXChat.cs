//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXChat : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXChat o;
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			o=new WeChatWASM.WXChat(a1);
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
	static public int On(IntPtr l) {
		try {
			WeChatWASM.WXChat self=(WeChatWASM.WXChat)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			System.Action<WeChatWASM.WXChatOnCallbackRes> a2 = default(System.Action<WeChatWASM.WXChatOnCallbackRes>);
			checkDelegate(l,3,out a2);
			self.On(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Off(IntPtr l) {
		try {
			WeChatWASM.WXChat self=(WeChatWASM.WXChat)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.Off(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Hide(IntPtr l) {
		try {
			WeChatWASM.WXChat self=(WeChatWASM.WXChat)checkSelf(l);
			self.Hide();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Show(IntPtr l) {
		try {
			WeChatWASM.WXChat self=(WeChatWASM.WXChat)checkSelf(l);
			WeChatWASM.WXChatOptions a1 = default(WeChatWASM.WXChatOptions);
			checkType(l,2,out a1);
			self.Show(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Close(IntPtr l) {
		try {
			WeChatWASM.WXChat self=(WeChatWASM.WXChat)checkSelf(l);
			self.Close();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Open(IntPtr l) {
		try {
			WeChatWASM.WXChat self=(WeChatWASM.WXChat)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.Open(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetTabs(IntPtr l) {
		try {
			WeChatWASM.WXChat self=(WeChatWASM.WXChat)checkSelf(l);
			System.String[] a1 = default(System.String[]);
			checkArray(l,2,out a1);
			self.SetTabs(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetChatSignature(IntPtr l) {
		try {
			WeChatWASM.WXChat self=(WeChatWASM.WXChat)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.SetChatSignature(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_OnActionList(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,WeChatWASM.WXChat.OnActionList);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_OnActionList(IntPtr l) {
		try {
			System.Collections.Generic.Dictionary<System.String,System.Action<WeChatWASM.WXChatOnCallbackRes>> v;
			checkType(l,2,out v);
			WeChatWASM.WXChat.OnActionList=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXChat");
		addMember(l,On);
		addMember(l,Off);
		addMember(l,Hide);
		addMember(l,Show);
		addMember(l,Close);
		addMember(l,Open);
		addMember(l,SetTabs);
		addMember(l,SetChatSignature);
		addMember(l,"OnActionList",get_OnActionList,set_OnActionList,false);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXChat));
	}
}
