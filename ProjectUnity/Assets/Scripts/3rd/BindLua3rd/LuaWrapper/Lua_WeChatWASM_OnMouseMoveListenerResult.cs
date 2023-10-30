//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_OnMouseMoveListenerResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.OnMouseMoveListenerResult o;
			o=new WeChatWASM.OnMouseMoveListenerResult();
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
	static public int get_movementX(IntPtr l) {
		try {
			WeChatWASM.OnMouseMoveListenerResult self=(WeChatWASM.OnMouseMoveListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.movementX);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_movementX(IntPtr l) {
		try {
			WeChatWASM.OnMouseMoveListenerResult self=(WeChatWASM.OnMouseMoveListenerResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.movementX=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_movementY(IntPtr l) {
		try {
			WeChatWASM.OnMouseMoveListenerResult self=(WeChatWASM.OnMouseMoveListenerResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.movementY);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_movementY(IntPtr l) {
		try {
			WeChatWASM.OnMouseMoveListenerResult self=(WeChatWASM.OnMouseMoveListenerResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.movementY=v;
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
			WeChatWASM.OnMouseMoveListenerResult self=(WeChatWASM.OnMouseMoveListenerResult)checkSelf(l);
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
			WeChatWASM.OnMouseMoveListenerResult self=(WeChatWASM.OnMouseMoveListenerResult)checkSelf(l);
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
			WeChatWASM.OnMouseMoveListenerResult self=(WeChatWASM.OnMouseMoveListenerResult)checkSelf(l);
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
			WeChatWASM.OnMouseMoveListenerResult self=(WeChatWASM.OnMouseMoveListenerResult)checkSelf(l);
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
			WeChatWASM.OnMouseMoveListenerResult self=(WeChatWASM.OnMouseMoveListenerResult)checkSelf(l);
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
			WeChatWASM.OnMouseMoveListenerResult self=(WeChatWASM.OnMouseMoveListenerResult)checkSelf(l);
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
		getTypeTable(l,"WeChatWASM.OnMouseMoveListenerResult");
		addMember(l,"movementX",get_movementX,set_movementX,true);
		addMember(l,"movementY",get_movementY,set_movementY,true);
		addMember(l,"timeStamp",get_timeStamp,set_timeStamp,true);
		addMember(l,"x",get_x,set_x,true);
		addMember(l,"y",get_y,set_y,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.OnMouseMoveListenerResult));
	}
}
