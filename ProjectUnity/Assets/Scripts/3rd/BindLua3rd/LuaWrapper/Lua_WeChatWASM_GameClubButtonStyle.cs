//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_GameClubButtonStyle : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.GameClubButtonStyle o;
			o=new WeChatWASM.GameClubButtonStyle();
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
	static public int get_left(IntPtr l) {
		try {
			WeChatWASM.GameClubButtonStyle self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.left);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_left(IntPtr l) {
		try {
			WeChatWASM.GameClubButtonStyle self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.left=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_top(IntPtr l) {
		try {
			WeChatWASM.GameClubButtonStyle self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.top);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_top(IntPtr l) {
		try {
			WeChatWASM.GameClubButtonStyle self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.top=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_width(IntPtr l) {
		try {
			WeChatWASM.GameClubButtonStyle self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.width);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_width(IntPtr l) {
		try {
			WeChatWASM.GameClubButtonStyle self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.width=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_height(IntPtr l) {
		try {
			WeChatWASM.GameClubButtonStyle self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.height);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_height(IntPtr l) {
		try {
			WeChatWASM.GameClubButtonStyle self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.height=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_backgroundColor(IntPtr l) {
		try {
			WeChatWASM.GameClubButtonStyle self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.backgroundColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_backgroundColor(IntPtr l) {
		try {
			WeChatWASM.GameClubButtonStyle self;
			checkValueType(l,1,out self);
			System.String v;
			checkType(l,2,out v);
			self.backgroundColor=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_borderColor(IntPtr l) {
		try {
			WeChatWASM.GameClubButtonStyle self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.borderColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_borderColor(IntPtr l) {
		try {
			WeChatWASM.GameClubButtonStyle self;
			checkValueType(l,1,out self);
			System.String v;
			checkType(l,2,out v);
			self.borderColor=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_borderWidth(IntPtr l) {
		try {
			WeChatWASM.GameClubButtonStyle self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.borderWidth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_borderWidth(IntPtr l) {
		try {
			WeChatWASM.GameClubButtonStyle self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.borderWidth=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_borderRadius(IntPtr l) {
		try {
			WeChatWASM.GameClubButtonStyle self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.borderRadius);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_borderRadius(IntPtr l) {
		try {
			WeChatWASM.GameClubButtonStyle self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.borderRadius=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_color(IntPtr l) {
		try {
			WeChatWASM.GameClubButtonStyle self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.color);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_color(IntPtr l) {
		try {
			WeChatWASM.GameClubButtonStyle self;
			checkValueType(l,1,out self);
			System.String v;
			checkType(l,2,out v);
			self.color=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_textAlign(IntPtr l) {
		try {
			WeChatWASM.GameClubButtonStyle self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.textAlign);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_textAlign(IntPtr l) {
		try {
			WeChatWASM.GameClubButtonStyle self;
			checkValueType(l,1,out self);
			WeChatWASM.GameClubButtonTextAlign v;
			checkEnum(l,2,out v);
			self.textAlign=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_fontSize(IntPtr l) {
		try {
			WeChatWASM.GameClubButtonStyle self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.fontSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_fontSize(IntPtr l) {
		try {
			WeChatWASM.GameClubButtonStyle self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.fontSize=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_lineHeight(IntPtr l) {
		try {
			WeChatWASM.GameClubButtonStyle self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.lineHeight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_lineHeight(IntPtr l) {
		try {
			WeChatWASM.GameClubButtonStyle self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.lineHeight=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.GameClubButtonStyle");
		addMember(l,"left",get_left,set_left,true);
		addMember(l,"top",get_top,set_top,true);
		addMember(l,"width",get_width,set_width,true);
		addMember(l,"height",get_height,set_height,true);
		addMember(l,"backgroundColor",get_backgroundColor,set_backgroundColor,true);
		addMember(l,"borderColor",get_borderColor,set_borderColor,true);
		addMember(l,"borderWidth",get_borderWidth,set_borderWidth,true);
		addMember(l,"borderRadius",get_borderRadius,set_borderRadius,true);
		addMember(l,"color",get_color,set_color,true);
		addMember(l,"textAlign",get_textAlign,set_textAlign,true);
		addMember(l,"fontSize",get_fontSize,set_fontSize,true);
		addMember(l,"lineHeight",get_lineHeight,set_lineHeight,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.GameClubButtonStyle),typeof(System.ValueType));
	}
}
