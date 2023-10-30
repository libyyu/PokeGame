//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXCreateInterstitialAdParam : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXCreateInterstitialAdParam o;
			o=new WeChatWASM.WXCreateInterstitialAdParam();
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
			WeChatWASM.WXCreateInterstitialAdParam self=(WeChatWASM.WXCreateInterstitialAdParam)checkSelf(l);
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
			WeChatWASM.WXCreateInterstitialAdParam self=(WeChatWASM.WXCreateInterstitialAdParam)checkSelf(l);
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
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXCreateInterstitialAdParam");
		addMember(l,"adUnitId",get_adUnitId,set_adUnitId,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXCreateInterstitialAdParam));
	}
}
