//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXCreateBannerAdParam : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXCreateBannerAdParam o;
			o=new WeChatWASM.WXCreateBannerAdParam();
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
	static public int get_adUnitId(IntPtr l) {
		try {
			WeChatWASM.WXCreateBannerAdParam self=(WeChatWASM.WXCreateBannerAdParam)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.adUnitId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_adUnitId(IntPtr l) {
		try {
			WeChatWASM.WXCreateBannerAdParam self=(WeChatWASM.WXCreateBannerAdParam)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.adUnitId=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_adIntervals(IntPtr l) {
		try {
			WeChatWASM.WXCreateBannerAdParam self=(WeChatWASM.WXCreateBannerAdParam)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.adIntervals);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_adIntervals(IntPtr l) {
		try {
			WeChatWASM.WXCreateBannerAdParam self=(WeChatWASM.WXCreateBannerAdParam)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.adIntervals=v;
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
			WeChatWASM.WXCreateBannerAdParam self=(WeChatWASM.WXCreateBannerAdParam)checkSelf(l);
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
			WeChatWASM.WXCreateBannerAdParam self=(WeChatWASM.WXCreateBannerAdParam)checkSelf(l);
			WeChatWASM.Style v;
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
			WeChatWASM.WXCreateBannerAdParam self=(WeChatWASM.WXCreateBannerAdParam)checkSelf(l);
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
			WeChatWASM.WXCreateBannerAdParam self=(WeChatWASM.WXCreateBannerAdParam)checkSelf(l);
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
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXCreateBannerAdParam");
		addMember(l,"adUnitId",get_adUnitId,set_adUnitId,true);
		addMember(l,"adIntervals",get_adIntervals,set_adIntervals,true);
		addMember(l,"style",get_style,set_style,true);
		addMember(l,"styleRaw",get_styleRaw,set_styleRaw,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXCreateBannerAdParam));
	}
}
