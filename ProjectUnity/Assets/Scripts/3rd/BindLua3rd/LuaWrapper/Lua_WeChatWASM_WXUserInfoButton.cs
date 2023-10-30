//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXUserInfoButton : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXUserInfoButton o;
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			o=new WeChatWASM.WXUserInfoButton(a1);
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
	static public int InvokeCallback(IntPtr l) {
		try {
			WeChatWASM.WXUserInfoButton self=(WeChatWASM.WXUserInfoButton)checkSelf(l);
			WeChatWASM.WXUserInfoResponse a1 = default(WeChatWASM.WXUserInfoResponse);
			checkType(l,2,out a1);
			self.InvokeCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Destroy(IntPtr l) {
		try {
			WeChatWASM.WXUserInfoButton self=(WeChatWASM.WXUserInfoButton)checkSelf(l);
			self.Destroy();
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
			WeChatWASM.WXUserInfoButton self=(WeChatWASM.WXUserInfoButton)checkSelf(l);
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
	static public int OffTap(IntPtr l) {
		try {
			WeChatWASM.WXUserInfoButton self=(WeChatWASM.WXUserInfoButton)checkSelf(l);
			self.OffTap();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnTap(IntPtr l) {
		try {
			WeChatWASM.WXUserInfoButton self=(WeChatWASM.WXUserInfoButton)checkSelf(l);
			System.Action<WeChatWASM.WXUserInfoResponse> a1 = default(System.Action<WeChatWASM.WXUserInfoResponse>);
			checkDelegate(l,2,out a1);
			self.OnTap(a1);
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
			WeChatWASM.WXUserInfoButton self=(WeChatWASM.WXUserInfoButton)checkSelf(l);
			self.Show();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Dict(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,WeChatWASM.WXUserInfoButton.Dict);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_Dict(IntPtr l) {
		try {
			System.Collections.Generic.Dictionary<System.String,WeChatWASM.WXUserInfoButton> v;
			checkType(l,2,out v);
			WeChatWASM.WXUserInfoButton.Dict=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXUserInfoButton");
		addMember(l,InvokeCallback);
		addMember(l,Destroy);
		addMember(l,Hide);
		addMember(l,OffTap);
		addMember(l,OnTap);
		addMember(l,Show);
		addMember(l,"Dict",get_Dict,set_Dict,false);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXUserInfoButton));
	}
}
