//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXFeedbackButton : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXFeedbackButton o;
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			WeChatWASM.CreateOpenSettingButtonOption a2 = default(WeChatWASM.CreateOpenSettingButtonOption);
			checkType(l,3,out a2);
			o=new WeChatWASM.WXFeedbackButton(a1,a2);
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
	static public int Destroy(IntPtr l) {
		try {
			WeChatWASM.WXFeedbackButton self=(WeChatWASM.WXFeedbackButton)checkSelf(l);
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
			WeChatWASM.WXFeedbackButton self=(WeChatWASM.WXFeedbackButton)checkSelf(l);
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
			WeChatWASM.WXFeedbackButton self=(WeChatWASM.WXFeedbackButton)checkSelf(l);
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
			WeChatWASM.WXFeedbackButton self=(WeChatWASM.WXFeedbackButton)checkSelf(l);
			System.Action<WeChatWASM.GeneralCallbackResult> a1 = default(System.Action<WeChatWASM.GeneralCallbackResult>);
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
			WeChatWASM.WXFeedbackButton self=(WeChatWASM.WXFeedbackButton)checkSelf(l);
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
	static public int get_OnTapActionList(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,WeChatWASM.WXFeedbackButton.OnTapActionList);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_OnTapActionList(IntPtr l) {
		try {
			System.Collections.Generic.Dictionary<System.String,System.Action<WeChatWASM.GeneralCallbackResult>> v;
			checkType(l,2,out v);
			WeChatWASM.WXFeedbackButton.OnTapActionList=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_type(IntPtr l) {
		try {
			WeChatWASM.WXFeedbackButton self=(WeChatWASM.WXFeedbackButton)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.type);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_type(IntPtr l) {
		try {
			WeChatWASM.WXFeedbackButton self=(WeChatWASM.WXFeedbackButton)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.type=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_image(IntPtr l) {
		try {
			WeChatWASM.WXFeedbackButton self=(WeChatWASM.WXFeedbackButton)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.image);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_image(IntPtr l) {
		try {
			WeChatWASM.WXFeedbackButton self=(WeChatWASM.WXFeedbackButton)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.image=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_text(IntPtr l) {
		try {
			WeChatWASM.WXFeedbackButton self=(WeChatWASM.WXFeedbackButton)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.text);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_text(IntPtr l) {
		try {
			WeChatWASM.WXFeedbackButton self=(WeChatWASM.WXFeedbackButton)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.text=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXFeedbackButton");
		addMember(l,Destroy);
		addMember(l,Hide);
		addMember(l,OffTap);
		addMember(l,OnTap);
		addMember(l,Show);
		addMember(l,"OnTapActionList",get_OnTapActionList,set_OnTapActionList,false);
		addMember(l,"type",get_type,set_type,true);
		addMember(l,"image",get_image,set_image,true);
		addMember(l,"text",get_text,set_text,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXFeedbackButton));
	}
}
