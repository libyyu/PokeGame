//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXGameClubButton : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXGameClubButton o;
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			WeChatWASM.WXCreateGameClubButtonParam a2 = default(WeChatWASM.WXCreateGameClubButtonParam);
			checkType(l,3,out a2);
			o=new WeChatWASM.WXGameClubButton(a1,a2);
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
			WeChatWASM.WXGameClubButton self=(WeChatWASM.WXGameClubButton)checkSelf(l);
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
			WeChatWASM.WXGameClubButton self=(WeChatWASM.WXGameClubButton)checkSelf(l);
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
			WeChatWASM.WXGameClubButton self=(WeChatWASM.WXGameClubButton)checkSelf(l);
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
	static public int OnTap(IntPtr l) {
		try {
			WeChatWASM.WXGameClubButton self=(WeChatWASM.WXGameClubButton)checkSelf(l);
			System.Action a1 = default(System.Action);
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
	static public int OffTap(IntPtr l) {
		try {
			WeChatWASM.WXGameClubButton self=(WeChatWASM.WXGameClubButton)checkSelf(l);
			System.Action a1 = default(System.Action);
			checkDelegate(l,2,out a1);
			self.OffTap(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int _HandleCallBack(IntPtr l) {
		try {
			WeChatWASM.WXGameClubButton self=(WeChatWASM.WXGameClubButton)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self._HandleCallBack(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_instanceId(IntPtr l) {
		try {
			WeChatWASM.WXGameClubButton self=(WeChatWASM.WXGameClubButton)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.instanceId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_instanceId(IntPtr l) {
		try {
			WeChatWASM.WXGameClubButton self=(WeChatWASM.WXGameClubButton)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.instanceId=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_style(IntPtr l) {
		try {
			WeChatWASM.WXGameClubButton self=(WeChatWASM.WXGameClubButton)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.style);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_style(IntPtr l) {
		try {
			WeChatWASM.WXGameClubButton self=(WeChatWASM.WXGameClubButton)checkSelf(l);
			WeChatWASM.WXGameClubButtonStyle v;
			checkType(l,2,out v);
			self.style=v;
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
			pushValue(l,WeChatWASM.WXGameClubButton.Dict);
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
			System.Collections.Generic.Dictionary<System.String,WeChatWASM.WXGameClubButton> v;
			checkType(l,2,out v);
			WeChatWASM.WXGameClubButton.Dict=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_icon(IntPtr l) {
		try {
			WeChatWASM.WXGameClubButton self=(WeChatWASM.WXGameClubButton)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.icon);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_icon(IntPtr l) {
		try {
			WeChatWASM.WXGameClubButton self=(WeChatWASM.WXGameClubButton)checkSelf(l);
			WeChatWASM.GameClubButtonIcon v;
			checkEnum(l,2,out v);
			self.icon=v;
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
			WeChatWASM.WXGameClubButton self=(WeChatWASM.WXGameClubButton)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.type);
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
			WeChatWASM.WXGameClubButton self=(WeChatWASM.WXGameClubButton)checkSelf(l);
			WeChatWASM.GameClubButtonType v;
			checkEnum(l,2,out v);
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
	static public int get_text(IntPtr l) {
		try {
			WeChatWASM.WXGameClubButton self=(WeChatWASM.WXGameClubButton)checkSelf(l);
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
			WeChatWASM.WXGameClubButton self=(WeChatWASM.WXGameClubButton)checkSelf(l);
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_image(IntPtr l) {
		try {
			WeChatWASM.WXGameClubButton self=(WeChatWASM.WXGameClubButton)checkSelf(l);
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
			WeChatWASM.WXGameClubButton self=(WeChatWASM.WXGameClubButton)checkSelf(l);
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
	static public int get_styleObj(IntPtr l) {
		try {
			WeChatWASM.WXGameClubButton self=(WeChatWASM.WXGameClubButton)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.styleObj);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_styleObj(IntPtr l) {
		try {
			WeChatWASM.WXGameClubButton self=(WeChatWASM.WXGameClubButton)checkSelf(l);
			WeChatWASM.WXGameClubButtonStyle v;
			checkType(l,2,out v);
			self.styleObj=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXGameClubButton");
		addMember(l,Destroy);
		addMember(l,Hide);
		addMember(l,Show);
		addMember(l,OnTap);
		addMember(l,OffTap);
		addMember(l,_HandleCallBack);
		addMember(l,"instanceId",get_instanceId,set_instanceId,true);
		addMember(l,"style",get_style,set_style,true);
		addMember(l,"Dict",get_Dict,set_Dict,false);
		addMember(l,"icon",get_icon,set_icon,true);
		addMember(l,"type",get_type,set_type,true);
		addMember(l,"text",get_text,set_text,true);
		addMember(l,"image",get_image,set_image,true);
		addMember(l,"styleObj",get_styleObj,set_styleObj,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXGameClubButton));
	}
}
