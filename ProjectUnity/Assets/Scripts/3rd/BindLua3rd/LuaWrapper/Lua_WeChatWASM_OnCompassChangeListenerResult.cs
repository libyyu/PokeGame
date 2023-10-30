//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_OnCompassChangeListenerResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.OnCompassChangeListenerResult o;
			o=new WeChatWASM.OnCompassChangeListenerResult();
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
	static public int get_accuracy(IntPtr l) {
		try {
			WeChatWASM.OnCompassChangeListenerResult self=(WeChatWASM.OnCompassChangeListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.accuracy);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_accuracy(IntPtr l) {
		try {
			WeChatWASM.OnCompassChangeListenerResult self=(WeChatWASM.OnCompassChangeListenerResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.accuracy=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_direction(IntPtr l) {
		try {
			WeChatWASM.OnCompassChangeListenerResult self=(WeChatWASM.OnCompassChangeListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.direction);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_direction(IntPtr l) {
		try {
			WeChatWASM.OnCompassChangeListenerResult self=(WeChatWASM.OnCompassChangeListenerResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.direction=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.OnCompassChangeListenerResult");
		addMember(l,"accuracy",get_accuracy,set_accuracy,true);
		addMember(l,"direction",get_direction,set_direction,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.OnCompassChangeListenerResult));
	}
}
