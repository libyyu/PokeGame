//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_FaceAngel : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.FaceAngel o;
			o=new WeChatWASM.FaceAngel();
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
	static public int get_pitch(IntPtr l) {
		try {
			WeChatWASM.FaceAngel self=(WeChatWASM.FaceAngel)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.pitch);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_pitch(IntPtr l) {
		try {
			WeChatWASM.FaceAngel self=(WeChatWASM.FaceAngel)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.pitch=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_roll(IntPtr l) {
		try {
			WeChatWASM.FaceAngel self=(WeChatWASM.FaceAngel)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.roll);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_roll(IntPtr l) {
		try {
			WeChatWASM.FaceAngel self=(WeChatWASM.FaceAngel)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.roll=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_yaw(IntPtr l) {
		try {
			WeChatWASM.FaceAngel self=(WeChatWASM.FaceAngel)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.yaw);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_yaw(IntPtr l) {
		try {
			WeChatWASM.FaceAngel self=(WeChatWASM.FaceAngel)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.yaw=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.FaceAngel");
		addMember(l,"pitch",get_pitch,set_pitch,true);
		addMember(l,"roll",get_roll,set_roll,true);
		addMember(l,"yaw",get_yaw,set_yaw,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.FaceAngel));
	}
}
