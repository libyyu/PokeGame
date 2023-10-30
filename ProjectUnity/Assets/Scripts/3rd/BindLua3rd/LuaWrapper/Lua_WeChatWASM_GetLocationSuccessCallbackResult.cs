//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_GetLocationSuccessCallbackResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.GetLocationSuccessCallbackResult o;
			o=new WeChatWASM.GetLocationSuccessCallbackResult();
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
			WeChatWASM.GetLocationSuccessCallbackResult self=(WeChatWASM.GetLocationSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.GetLocationSuccessCallbackResult self=(WeChatWASM.GetLocationSuccessCallbackResult)checkSelf(l);
			System.Double v;
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
	static public int get_altitude(IntPtr l) {
		try {
			WeChatWASM.GetLocationSuccessCallbackResult self=(WeChatWASM.GetLocationSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.altitude);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_altitude(IntPtr l) {
		try {
			WeChatWASM.GetLocationSuccessCallbackResult self=(WeChatWASM.GetLocationSuccessCallbackResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.altitude=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_horizontalAccuracy(IntPtr l) {
		try {
			WeChatWASM.GetLocationSuccessCallbackResult self=(WeChatWASM.GetLocationSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.horizontalAccuracy);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_horizontalAccuracy(IntPtr l) {
		try {
			WeChatWASM.GetLocationSuccessCallbackResult self=(WeChatWASM.GetLocationSuccessCallbackResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.horizontalAccuracy=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_latitude(IntPtr l) {
		try {
			WeChatWASM.GetLocationSuccessCallbackResult self=(WeChatWASM.GetLocationSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.latitude);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_latitude(IntPtr l) {
		try {
			WeChatWASM.GetLocationSuccessCallbackResult self=(WeChatWASM.GetLocationSuccessCallbackResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.latitude=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_longitude(IntPtr l) {
		try {
			WeChatWASM.GetLocationSuccessCallbackResult self=(WeChatWASM.GetLocationSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.longitude);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_longitude(IntPtr l) {
		try {
			WeChatWASM.GetLocationSuccessCallbackResult self=(WeChatWASM.GetLocationSuccessCallbackResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.longitude=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_speed(IntPtr l) {
		try {
			WeChatWASM.GetLocationSuccessCallbackResult self=(WeChatWASM.GetLocationSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.speed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_speed(IntPtr l) {
		try {
			WeChatWASM.GetLocationSuccessCallbackResult self=(WeChatWASM.GetLocationSuccessCallbackResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.speed=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_verticalAccuracy(IntPtr l) {
		try {
			WeChatWASM.GetLocationSuccessCallbackResult self=(WeChatWASM.GetLocationSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.verticalAccuracy);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_verticalAccuracy(IntPtr l) {
		try {
			WeChatWASM.GetLocationSuccessCallbackResult self=(WeChatWASM.GetLocationSuccessCallbackResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.verticalAccuracy=v;
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
			WeChatWASM.GetLocationSuccessCallbackResult self=(WeChatWASM.GetLocationSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.GetLocationSuccessCallbackResult self=(WeChatWASM.GetLocationSuccessCallbackResult)checkSelf(l);
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
		getTypeTable(l,"WeChatWASM.GetLocationSuccessCallbackResult");
		addMember(l,"accuracy",get_accuracy,set_accuracy,true);
		addMember(l,"altitude",get_altitude,set_altitude,true);
		addMember(l,"horizontalAccuracy",get_horizontalAccuracy,set_horizontalAccuracy,true);
		addMember(l,"latitude",get_latitude,set_latitude,true);
		addMember(l,"longitude",get_longitude,set_longitude,true);
		addMember(l,"speed",get_speed,set_speed,true);
		addMember(l,"verticalAccuracy",get_verticalAccuracy,set_verticalAccuracy,true);
		addMember(l,"errMsg",get_errMsg,set_errMsg,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.GetLocationSuccessCallbackResult));
	}
}
