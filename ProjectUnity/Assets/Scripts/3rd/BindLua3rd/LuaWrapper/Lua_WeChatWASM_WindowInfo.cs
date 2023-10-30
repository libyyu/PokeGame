//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WindowInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WindowInfo o;
			o=new WeChatWASM.WindowInfo();
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
	static public int get_pixelRatio(IntPtr l) {
		try {
			WeChatWASM.WindowInfo self=(WeChatWASM.WindowInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.pixelRatio);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_pixelRatio(IntPtr l) {
		try {
			WeChatWASM.WindowInfo self=(WeChatWASM.WindowInfo)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.pixelRatio=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_safeArea(IntPtr l) {
		try {
			WeChatWASM.WindowInfo self=(WeChatWASM.WindowInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.safeArea);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_safeArea(IntPtr l) {
		try {
			WeChatWASM.WindowInfo self=(WeChatWASM.WindowInfo)checkSelf(l);
			WeChatWASM.SafeArea v;
			checkType(l,2,out v);
			self.safeArea=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_screenHeight(IntPtr l) {
		try {
			WeChatWASM.WindowInfo self=(WeChatWASM.WindowInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.screenHeight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_screenHeight(IntPtr l) {
		try {
			WeChatWASM.WindowInfo self=(WeChatWASM.WindowInfo)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.screenHeight=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_screenTop(IntPtr l) {
		try {
			WeChatWASM.WindowInfo self=(WeChatWASM.WindowInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.screenTop);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_screenTop(IntPtr l) {
		try {
			WeChatWASM.WindowInfo self=(WeChatWASM.WindowInfo)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.screenTop=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_screenWidth(IntPtr l) {
		try {
			WeChatWASM.WindowInfo self=(WeChatWASM.WindowInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.screenWidth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_screenWidth(IntPtr l) {
		try {
			WeChatWASM.WindowInfo self=(WeChatWASM.WindowInfo)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.screenWidth=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_statusBarHeight(IntPtr l) {
		try {
			WeChatWASM.WindowInfo self=(WeChatWASM.WindowInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.statusBarHeight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_statusBarHeight(IntPtr l) {
		try {
			WeChatWASM.WindowInfo self=(WeChatWASM.WindowInfo)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.statusBarHeight=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_windowHeight(IntPtr l) {
		try {
			WeChatWASM.WindowInfo self=(WeChatWASM.WindowInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.windowHeight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_windowHeight(IntPtr l) {
		try {
			WeChatWASM.WindowInfo self=(WeChatWASM.WindowInfo)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.windowHeight=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_windowWidth(IntPtr l) {
		try {
			WeChatWASM.WindowInfo self=(WeChatWASM.WindowInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.windowWidth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_windowWidth(IntPtr l) {
		try {
			WeChatWASM.WindowInfo self=(WeChatWASM.WindowInfo)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.windowWidth=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WindowInfo");
		addMember(l,"pixelRatio",get_pixelRatio,set_pixelRatio,true);
		addMember(l,"safeArea",get_safeArea,set_safeArea,true);
		addMember(l,"screenHeight",get_screenHeight,set_screenHeight,true);
		addMember(l,"screenTop",get_screenTop,set_screenTop,true);
		addMember(l,"screenWidth",get_screenWidth,set_screenWidth,true);
		addMember(l,"statusBarHeight",get_statusBarHeight,set_statusBarHeight,true);
		addMember(l,"windowHeight",get_windowHeight,set_windowHeight,true);
		addMember(l,"windowWidth",get_windowWidth,set_windowWidth,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WindowInfo));
	}
}
