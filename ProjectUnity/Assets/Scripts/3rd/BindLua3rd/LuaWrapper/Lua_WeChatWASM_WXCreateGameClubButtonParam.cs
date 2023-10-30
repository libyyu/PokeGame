//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXCreateGameClubButtonParam : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXCreateGameClubButtonParam o;
			o=new WeChatWASM.WXCreateGameClubButtonParam();
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
	static public int get_type(IntPtr l) {
		try {
			WeChatWASM.WXCreateGameClubButtonParam self=(WeChatWASM.WXCreateGameClubButtonParam)checkSelf(l);
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
			WeChatWASM.WXCreateGameClubButtonParam self=(WeChatWASM.WXCreateGameClubButtonParam)checkSelf(l);
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
			WeChatWASM.WXCreateGameClubButtonParam self=(WeChatWASM.WXCreateGameClubButtonParam)checkSelf(l);
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
			WeChatWASM.WXCreateGameClubButtonParam self=(WeChatWASM.WXCreateGameClubButtonParam)checkSelf(l);
			System.String v;
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
			WeChatWASM.WXCreateGameClubButtonParam self=(WeChatWASM.WXCreateGameClubButtonParam)checkSelf(l);
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
			WeChatWASM.WXCreateGameClubButtonParam self=(WeChatWASM.WXCreateGameClubButtonParam)checkSelf(l);
			System.String v;
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
	static public int get_style(IntPtr l) {
		try {
			WeChatWASM.WXCreateGameClubButtonParam self=(WeChatWASM.WXCreateGameClubButtonParam)checkSelf(l);
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
			WeChatWASM.WXCreateGameClubButtonParam self=(WeChatWASM.WXCreateGameClubButtonParam)checkSelf(l);
			WeChatWASM.GameClubButtonStyle v;
			checkValueType(l,2,out v);
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
	static public int get_styleRaw(IntPtr l) {
		try {
			WeChatWASM.WXCreateGameClubButtonParam self=(WeChatWASM.WXCreateGameClubButtonParam)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.styleRaw);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_styleRaw(IntPtr l) {
		try {
			WeChatWASM.WXCreateGameClubButtonParam self=(WeChatWASM.WXCreateGameClubButtonParam)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.styleRaw=v;
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
			WeChatWASM.WXCreateGameClubButtonParam self=(WeChatWASM.WXCreateGameClubButtonParam)checkSelf(l);
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
			WeChatWASM.WXCreateGameClubButtonParam self=(WeChatWASM.WXCreateGameClubButtonParam)checkSelf(l);
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
	static public int get_hasRedDot(IntPtr l) {
		try {
			WeChatWASM.WXCreateGameClubButtonParam self=(WeChatWASM.WXCreateGameClubButtonParam)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.hasRedDot);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_hasRedDot(IntPtr l) {
		try {
			WeChatWASM.WXCreateGameClubButtonParam self=(WeChatWASM.WXCreateGameClubButtonParam)checkSelf(l);
			System.Nullable<System.Boolean> v;
			checkNullable(l,2,out v);
			self.hasRedDot=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_openlink(IntPtr l) {
		try {
			WeChatWASM.WXCreateGameClubButtonParam self=(WeChatWASM.WXCreateGameClubButtonParam)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.openlink);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_openlink(IntPtr l) {
		try {
			WeChatWASM.WXCreateGameClubButtonParam self=(WeChatWASM.WXCreateGameClubButtonParam)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.openlink=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXCreateGameClubButtonParam");
		addMember(l,"type",get_type,set_type,true);
		addMember(l,"text",get_text,set_text,true);
		addMember(l,"image",get_image,set_image,true);
		addMember(l,"style",get_style,set_style,true);
		addMember(l,"styleRaw",get_styleRaw,set_styleRaw,true);
		addMember(l,"icon",get_icon,set_icon,true);
		addMember(l,"hasRedDot",get_hasRedDot,set_hasRedDot,true);
		addMember(l,"openlink",get_openlink,set_openlink,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXCreateGameClubButtonParam));
	}
}
