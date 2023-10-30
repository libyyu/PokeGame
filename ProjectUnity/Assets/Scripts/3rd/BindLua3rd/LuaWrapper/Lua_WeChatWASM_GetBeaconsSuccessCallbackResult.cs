//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_GetBeaconsSuccessCallbackResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.GetBeaconsSuccessCallbackResult o;
			o=new WeChatWASM.GetBeaconsSuccessCallbackResult();
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
	static public int get_beacons(IntPtr l) {
		try {
			WeChatWASM.GetBeaconsSuccessCallbackResult self=(WeChatWASM.GetBeaconsSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.beacons);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_beacons(IntPtr l) {
		try {
			WeChatWASM.GetBeaconsSuccessCallbackResult self=(WeChatWASM.GetBeaconsSuccessCallbackResult)checkSelf(l);
			WeChatWASM.BeaconInfo[] v;
			checkArray(l,2,out v);
			self.beacons=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_errMsg(IntPtr l) {
		try {
			WeChatWASM.GetBeaconsSuccessCallbackResult self=(WeChatWASM.GetBeaconsSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.errMsg);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_errMsg(IntPtr l) {
		try {
			WeChatWASM.GetBeaconsSuccessCallbackResult self=(WeChatWASM.GetBeaconsSuccessCallbackResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.errMsg=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.GetBeaconsSuccessCallbackResult");
		addMember(l,"beacons",get_beacons,set_beacons,true);
		addMember(l,"errMsg",get_errMsg,set_errMsg,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.GetBeaconsSuccessCallbackResult));
	}
}
