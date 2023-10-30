//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_OnDeviceMotionChangeListenerResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.OnDeviceMotionChangeListenerResult o;
			o=new WeChatWASM.OnDeviceMotionChangeListenerResult();
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
	static public int get_alpha(IntPtr l) {
		try {
			WeChatWASM.OnDeviceMotionChangeListenerResult self=(WeChatWASM.OnDeviceMotionChangeListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.alpha);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_alpha(IntPtr l) {
		try {
			WeChatWASM.OnDeviceMotionChangeListenerResult self=(WeChatWASM.OnDeviceMotionChangeListenerResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.alpha=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_beta(IntPtr l) {
		try {
			WeChatWASM.OnDeviceMotionChangeListenerResult self=(WeChatWASM.OnDeviceMotionChangeListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.beta);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_beta(IntPtr l) {
		try {
			WeChatWASM.OnDeviceMotionChangeListenerResult self=(WeChatWASM.OnDeviceMotionChangeListenerResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.beta=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_gamma(IntPtr l) {
		try {
			WeChatWASM.OnDeviceMotionChangeListenerResult self=(WeChatWASM.OnDeviceMotionChangeListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.gamma);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_gamma(IntPtr l) {
		try {
			WeChatWASM.OnDeviceMotionChangeListenerResult self=(WeChatWASM.OnDeviceMotionChangeListenerResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.gamma=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.OnDeviceMotionChangeListenerResult");
		addMember(l,"alpha",get_alpha,set_alpha,true);
		addMember(l,"beta",get_beta,set_beta,true);
		addMember(l,"gamma",get_gamma,set_gamma,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.OnDeviceMotionChangeListenerResult));
	}
}
