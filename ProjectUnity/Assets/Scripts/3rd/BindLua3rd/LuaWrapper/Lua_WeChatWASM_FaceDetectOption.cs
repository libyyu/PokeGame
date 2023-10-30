//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_FaceDetectOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.FaceDetectOption o;
			o=new WeChatWASM.FaceDetectOption();
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
	static public int get_frameBuffer(IntPtr l) {
		try {
			WeChatWASM.FaceDetectOption self=(WeChatWASM.FaceDetectOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.frameBuffer);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_frameBuffer(IntPtr l) {
		try {
			WeChatWASM.FaceDetectOption self=(WeChatWASM.FaceDetectOption)checkSelf(l);
			System.Byte[] v;
			checkArray(l,2,out v);
			self.frameBuffer=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_arrayBufferLength(IntPtr l) {
		try {
			WeChatWASM.FaceDetectOption self=(WeChatWASM.FaceDetectOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.arrayBufferLength);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_arrayBufferLength(IntPtr l) {
		try {
			WeChatWASM.FaceDetectOption self=(WeChatWASM.FaceDetectOption)checkSelf(l);
			System.Nullable<System.Int32> v;
			checkNullable(l,2,out v);
			self.arrayBufferLength=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_height(IntPtr l) {
		try {
			WeChatWASM.FaceDetectOption self=(WeChatWASM.FaceDetectOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.height);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_height(IntPtr l) {
		try {
			WeChatWASM.FaceDetectOption self=(WeChatWASM.FaceDetectOption)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.height=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_width(IntPtr l) {
		try {
			WeChatWASM.FaceDetectOption self=(WeChatWASM.FaceDetectOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.width);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_width(IntPtr l) {
		try {
			WeChatWASM.FaceDetectOption self=(WeChatWASM.FaceDetectOption)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.width=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_complete(IntPtr l) {
		try {
			WeChatWASM.FaceDetectOption self=(WeChatWASM.FaceDetectOption)checkSelf(l);
			System.Action<WeChatWASM.GeneralCallbackResult> v;
			int op=checkDelegate(l,2,out v);
			if(op==0) self.complete=v;
			else if(op==1) self.complete+=v;
			else if(op==2) self.complete-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_enableAngle(IntPtr l) {
		try {
			WeChatWASM.FaceDetectOption self=(WeChatWASM.FaceDetectOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.enableAngle);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_enableAngle(IntPtr l) {
		try {
			WeChatWASM.FaceDetectOption self=(WeChatWASM.FaceDetectOption)checkSelf(l);
			System.Nullable<System.Boolean> v;
			checkNullable(l,2,out v);
			self.enableAngle=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_enableConf(IntPtr l) {
		try {
			WeChatWASM.FaceDetectOption self=(WeChatWASM.FaceDetectOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.enableConf);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_enableConf(IntPtr l) {
		try {
			WeChatWASM.FaceDetectOption self=(WeChatWASM.FaceDetectOption)checkSelf(l);
			System.Nullable<System.Boolean> v;
			checkNullable(l,2,out v);
			self.enableConf=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_enableMultiFace(IntPtr l) {
		try {
			WeChatWASM.FaceDetectOption self=(WeChatWASM.FaceDetectOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.enableMultiFace);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_enableMultiFace(IntPtr l) {
		try {
			WeChatWASM.FaceDetectOption self=(WeChatWASM.FaceDetectOption)checkSelf(l);
			System.Nullable<System.Boolean> v;
			checkNullable(l,2,out v);
			self.enableMultiFace=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_enablePoint(IntPtr l) {
		try {
			WeChatWASM.FaceDetectOption self=(WeChatWASM.FaceDetectOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.enablePoint);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_enablePoint(IntPtr l) {
		try {
			WeChatWASM.FaceDetectOption self=(WeChatWASM.FaceDetectOption)checkSelf(l);
			System.Nullable<System.Boolean> v;
			checkNullable(l,2,out v);
			self.enablePoint=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_fail(IntPtr l) {
		try {
			WeChatWASM.FaceDetectOption self=(WeChatWASM.FaceDetectOption)checkSelf(l);
			System.Action<WeChatWASM.GeneralCallbackResult> v;
			int op=checkDelegate(l,2,out v);
			if(op==0) self.fail=v;
			else if(op==1) self.fail+=v;
			else if(op==2) self.fail-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_success(IntPtr l) {
		try {
			WeChatWASM.FaceDetectOption self=(WeChatWASM.FaceDetectOption)checkSelf(l);
			System.Action<WeChatWASM.FaceDetectSuccessCallbackResult> v;
			int op=checkDelegate(l,2,out v);
			if(op==0) self.success=v;
			else if(op==1) self.success+=v;
			else if(op==2) self.success-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.FaceDetectOption");
		addMember(l,"frameBuffer",get_frameBuffer,set_frameBuffer,true);
		addMember(l,"arrayBufferLength",get_arrayBufferLength,set_arrayBufferLength,true);
		addMember(l,"height",get_height,set_height,true);
		addMember(l,"width",get_width,set_width,true);
		addMember(l,"complete",null,set_complete,true);
		addMember(l,"enableAngle",get_enableAngle,set_enableAngle,true);
		addMember(l,"enableConf",get_enableConf,set_enableConf,true);
		addMember(l,"enableMultiFace",get_enableMultiFace,set_enableMultiFace,true);
		addMember(l,"enablePoint",get_enablePoint,set_enablePoint,true);
		addMember(l,"fail",null,set_fail,true);
		addMember(l,"success",null,set_success,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.FaceDetectOption));
	}
}
