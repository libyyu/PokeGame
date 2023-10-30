//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_LaunchEvent : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.LaunchEvent o;
			o=new WeChatWASM.LaunchEvent();
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
	static public int get_type(IntPtr l) {
		try {
			WeChatWASM.LaunchEvent self=(WeChatWASM.LaunchEvent)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.type);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_type(IntPtr l) {
		try {
			WeChatWASM.LaunchEvent self=(WeChatWASM.LaunchEvent)checkSelf(l);
			WeChatWASM.LaunchEventType v;
			checkEnum(l,2,out v);
			self.type=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_costTimeMs(IntPtr l) {
		try {
			WeChatWASM.LaunchEvent self=(WeChatWASM.LaunchEvent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.costTimeMs);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_costTimeMs(IntPtr l) {
		try {
			WeChatWASM.LaunchEvent self=(WeChatWASM.LaunchEvent)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.costTimeMs=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_runTimeMs(IntPtr l) {
		try {
			WeChatWASM.LaunchEvent self=(WeChatWASM.LaunchEvent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.runTimeMs);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_runTimeMs(IntPtr l) {
		try {
			WeChatWASM.LaunchEvent self=(WeChatWASM.LaunchEvent)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.runTimeMs=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_needDownloadDataPackage(IntPtr l) {
		try {
			WeChatWASM.LaunchEvent self=(WeChatWASM.LaunchEvent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.needDownloadDataPackage);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_needDownloadDataPackage(IntPtr l) {
		try {
			WeChatWASM.LaunchEvent self=(WeChatWASM.LaunchEvent)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.needDownloadDataPackage=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_loadDataPackageFromSubpackage(IntPtr l) {
		try {
			WeChatWASM.LaunchEvent self=(WeChatWASM.LaunchEvent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.loadDataPackageFromSubpackage);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_loadDataPackageFromSubpackage(IntPtr l) {
		try {
			WeChatWASM.LaunchEvent self=(WeChatWASM.LaunchEvent)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.loadDataPackageFromSubpackage=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_isVisible(IntPtr l) {
		try {
			WeChatWASM.LaunchEvent self=(WeChatWASM.LaunchEvent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isVisible);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_isVisible(IntPtr l) {
		try {
			WeChatWASM.LaunchEvent self=(WeChatWASM.LaunchEvent)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.isVisible=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_useCodeSplit(IntPtr l) {
		try {
			WeChatWASM.LaunchEvent self=(WeChatWASM.LaunchEvent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.useCodeSplit);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_useCodeSplit(IntPtr l) {
		try {
			WeChatWASM.LaunchEvent self=(WeChatWASM.LaunchEvent)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.useCodeSplit=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_isHighPerformance(IntPtr l) {
		try {
			WeChatWASM.LaunchEvent self=(WeChatWASM.LaunchEvent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isHighPerformance);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_isHighPerformance(IntPtr l) {
		try {
			WeChatWASM.LaunchEvent self=(WeChatWASM.LaunchEvent)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.isHighPerformance=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.LaunchEvent");
		addMember(l,"type",get_type,set_type,true);
		addMember(l,"costTimeMs",get_costTimeMs,set_costTimeMs,true);
		addMember(l,"runTimeMs",get_runTimeMs,set_runTimeMs,true);
		addMember(l,"needDownloadDataPackage",get_needDownloadDataPackage,set_needDownloadDataPackage,true);
		addMember(l,"loadDataPackageFromSubpackage",get_loadDataPackageFromSubpackage,set_loadDataPackageFromSubpackage,true);
		addMember(l,"isVisible",get_isVisible,set_isVisible,true);
		addMember(l,"useCodeSplit",get_useCodeSplit,set_useCodeSplit,true);
		addMember(l,"isHighPerformance",get_isHighPerformance,set_isHighPerformance,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.LaunchEvent));
	}
}
