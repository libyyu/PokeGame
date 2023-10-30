//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_OnWheelListenerResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.OnWheelListenerResult o;
			o=new WeChatWASM.OnWheelListenerResult();
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
	static public int get_deltaX(IntPtr l) {
		try {
			WeChatWASM.OnWheelListenerResult self=(WeChatWASM.OnWheelListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.deltaX);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_deltaX(IntPtr l) {
		try {
			WeChatWASM.OnWheelListenerResult self=(WeChatWASM.OnWheelListenerResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.deltaX=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_deltaY(IntPtr l) {
		try {
			WeChatWASM.OnWheelListenerResult self=(WeChatWASM.OnWheelListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.deltaY);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_deltaY(IntPtr l) {
		try {
			WeChatWASM.OnWheelListenerResult self=(WeChatWASM.OnWheelListenerResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.deltaY=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_deltaZ(IntPtr l) {
		try {
			WeChatWASM.OnWheelListenerResult self=(WeChatWASM.OnWheelListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.deltaZ);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_deltaZ(IntPtr l) {
		try {
			WeChatWASM.OnWheelListenerResult self=(WeChatWASM.OnWheelListenerResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.deltaZ=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_timeStamp(IntPtr l) {
		try {
			WeChatWASM.OnWheelListenerResult self=(WeChatWASM.OnWheelListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.timeStamp);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_timeStamp(IntPtr l) {
		try {
			WeChatWASM.OnWheelListenerResult self=(WeChatWASM.OnWheelListenerResult)checkSelf(l);
			System.Int64 v;
			checkType(l,2,out v);
			self.timeStamp=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_x(IntPtr l) {
		try {
			WeChatWASM.OnWheelListenerResult self=(WeChatWASM.OnWheelListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.x);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_x(IntPtr l) {
		try {
			WeChatWASM.OnWheelListenerResult self=(WeChatWASM.OnWheelListenerResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.x=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_y(IntPtr l) {
		try {
			WeChatWASM.OnWheelListenerResult self=(WeChatWASM.OnWheelListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.y);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_y(IntPtr l) {
		try {
			WeChatWASM.OnWheelListenerResult self=(WeChatWASM.OnWheelListenerResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.y=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.OnWheelListenerResult");
		addMember(l,"deltaX",get_deltaX,set_deltaX,true);
		addMember(l,"deltaY",get_deltaY,set_deltaY,true);
		addMember(l,"deltaZ",get_deltaZ,set_deltaZ,true);
		addMember(l,"timeStamp",get_timeStamp,set_timeStamp,true);
		addMember(l,"x",get_x,set_x,true);
		addMember(l,"y",get_y,set_y,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.OnWheelListenerResult));
	}
}
