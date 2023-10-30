//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_FaceConf : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.FaceConf o;
			o=new WeChatWASM.FaceConf();
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
	static public int get_global(IntPtr l) {
		try {
			WeChatWASM.FaceConf self=(WeChatWASM.FaceConf)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.global);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_global(IntPtr l) {
		try {
			WeChatWASM.FaceConf self=(WeChatWASM.FaceConf)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.global=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_leftEye(IntPtr l) {
		try {
			WeChatWASM.FaceConf self=(WeChatWASM.FaceConf)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.leftEye);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_leftEye(IntPtr l) {
		try {
			WeChatWASM.FaceConf self=(WeChatWASM.FaceConf)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.leftEye=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_mouth(IntPtr l) {
		try {
			WeChatWASM.FaceConf self=(WeChatWASM.FaceConf)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.mouth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_mouth(IntPtr l) {
		try {
			WeChatWASM.FaceConf self=(WeChatWASM.FaceConf)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.mouth=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_nose(IntPtr l) {
		try {
			WeChatWASM.FaceConf self=(WeChatWASM.FaceConf)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.nose);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_nose(IntPtr l) {
		try {
			WeChatWASM.FaceConf self=(WeChatWASM.FaceConf)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.nose=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_rightEye(IntPtr l) {
		try {
			WeChatWASM.FaceConf self=(WeChatWASM.FaceConf)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rightEye);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_rightEye(IntPtr l) {
		try {
			WeChatWASM.FaceConf self=(WeChatWASM.FaceConf)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.rightEye=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.FaceConf");
		addMember(l,"global",get_global,set_global,true);
		addMember(l,"leftEye",get_leftEye,set_leftEye,true);
		addMember(l,"mouth",get_mouth,set_mouth,true);
		addMember(l,"nose",get_nose,set_nose,true);
		addMember(l,"rightEye",get_rightEye,set_rightEye,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.FaceConf));
	}
}
