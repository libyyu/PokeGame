//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_FaceDetectSuccessCallbackResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.FaceDetectSuccessCallbackResult o;
			o=new WeChatWASM.FaceDetectSuccessCallbackResult();
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
	static public int get_angleArray(IntPtr l) {
		try {
			WeChatWASM.FaceDetectSuccessCallbackResult self=(WeChatWASM.FaceDetectSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.angleArray);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_angleArray(IntPtr l) {
		try {
			WeChatWASM.FaceDetectSuccessCallbackResult self=(WeChatWASM.FaceDetectSuccessCallbackResult)checkSelf(l);
			WeChatWASM.FaceAngel v;
			checkType(l,2,out v);
			self.angleArray=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_confArray(IntPtr l) {
		try {
			WeChatWASM.FaceDetectSuccessCallbackResult self=(WeChatWASM.FaceDetectSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.confArray);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_confArray(IntPtr l) {
		try {
			WeChatWASM.FaceDetectSuccessCallbackResult self=(WeChatWASM.FaceDetectSuccessCallbackResult)checkSelf(l);
			WeChatWASM.FaceConf v;
			checkType(l,2,out v);
			self.confArray=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_detectRect(IntPtr l) {
		try {
			WeChatWASM.FaceDetectSuccessCallbackResult self=(WeChatWASM.FaceDetectSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.detectRect);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_detectRect(IntPtr l) {
		try {
			WeChatWASM.FaceDetectSuccessCallbackResult self=(WeChatWASM.FaceDetectSuccessCallbackResult)checkSelf(l);
			System.Collections.Generic.Dictionary<System.String,System.String> v;
			checkType(l,2,out v);
			self.detectRect=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_faceInfo(IntPtr l) {
		try {
			WeChatWASM.FaceDetectSuccessCallbackResult self=(WeChatWASM.FaceDetectSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.faceInfo);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_faceInfo(IntPtr l) {
		try {
			WeChatWASM.FaceDetectSuccessCallbackResult self=(WeChatWASM.FaceDetectSuccessCallbackResult)checkSelf(l);
			System.Collections.Generic.Dictionary<System.String,System.String> v;
			checkType(l,2,out v);
			self.faceInfo=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_pointArray(IntPtr l) {
		try {
			WeChatWASM.FaceDetectSuccessCallbackResult self=(WeChatWASM.FaceDetectSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.pointArray);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_pointArray(IntPtr l) {
		try {
			WeChatWASM.FaceDetectSuccessCallbackResult self=(WeChatWASM.FaceDetectSuccessCallbackResult)checkSelf(l);
			System.Collections.Generic.Dictionary<System.String,System.String> v;
			checkType(l,2,out v);
			self.pointArray=v;
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
			WeChatWASM.FaceDetectSuccessCallbackResult self=(WeChatWASM.FaceDetectSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.FaceDetectSuccessCallbackResult self=(WeChatWASM.FaceDetectSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.FaceDetectSuccessCallbackResult self=(WeChatWASM.FaceDetectSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.FaceDetectSuccessCallbackResult self=(WeChatWASM.FaceDetectSuccessCallbackResult)checkSelf(l);
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_errMsg(IntPtr l) {
		try {
			WeChatWASM.FaceDetectSuccessCallbackResult self=(WeChatWASM.FaceDetectSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.FaceDetectSuccessCallbackResult self=(WeChatWASM.FaceDetectSuccessCallbackResult)checkSelf(l);
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
		getTypeTable(l,"WeChatWASM.FaceDetectSuccessCallbackResult");
		addMember(l,"angleArray",get_angleArray,set_angleArray,true);
		addMember(l,"confArray",get_confArray,set_confArray,true);
		addMember(l,"detectRect",get_detectRect,set_detectRect,true);
		addMember(l,"faceInfo",get_faceInfo,set_faceInfo,true);
		addMember(l,"pointArray",get_pointArray,set_pointArray,true);
		addMember(l,"x",get_x,set_x,true);
		addMember(l,"y",get_y,set_y,true);
		addMember(l,"errMsg",get_errMsg,set_errMsg,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.FaceDetectSuccessCallbackResult));
	}
}
