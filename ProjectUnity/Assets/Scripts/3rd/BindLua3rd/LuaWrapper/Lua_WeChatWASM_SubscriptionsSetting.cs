//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_SubscriptionsSetting : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.SubscriptionsSetting o;
			o=new WeChatWASM.SubscriptionsSetting();
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
	static public int get_mainSwitch(IntPtr l) {
		try {
			WeChatWASM.SubscriptionsSetting self=(WeChatWASM.SubscriptionsSetting)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.mainSwitch);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_mainSwitch(IntPtr l) {
		try {
			WeChatWASM.SubscriptionsSetting self=(WeChatWASM.SubscriptionsSetting)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.mainSwitch=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_itemSettings(IntPtr l) {
		try {
			WeChatWASM.SubscriptionsSetting self=(WeChatWASM.SubscriptionsSetting)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.itemSettings);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_itemSettings(IntPtr l) {
		try {
			WeChatWASM.SubscriptionsSetting self=(WeChatWASM.SubscriptionsSetting)checkSelf(l);
			System.Collections.Generic.Dictionary<System.String,System.String> v;
			checkType(l,2,out v);
			self.itemSettings=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.SubscriptionsSetting");
		addMember(l,"mainSwitch",get_mainSwitch,set_mainSwitch,true);
		addMember(l,"itemSettings",get_itemSettings,set_itemSettings,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.SubscriptionsSetting));
	}
}
