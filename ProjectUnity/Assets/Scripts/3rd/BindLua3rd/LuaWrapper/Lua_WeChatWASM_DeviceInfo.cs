//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_DeviceInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.DeviceInfo o;
			o=new WeChatWASM.DeviceInfo();
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
	static public int get_abi(IntPtr l) {
		try {
			WeChatWASM.DeviceInfo self=(WeChatWASM.DeviceInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.abi);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_abi(IntPtr l) {
		try {
			WeChatWASM.DeviceInfo self=(WeChatWASM.DeviceInfo)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.abi=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_benchmarkLevel(IntPtr l) {
		try {
			WeChatWASM.DeviceInfo self=(WeChatWASM.DeviceInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.benchmarkLevel);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_benchmarkLevel(IntPtr l) {
		try {
			WeChatWASM.DeviceInfo self=(WeChatWASM.DeviceInfo)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.benchmarkLevel=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_brand(IntPtr l) {
		try {
			WeChatWASM.DeviceInfo self=(WeChatWASM.DeviceInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.brand);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_brand(IntPtr l) {
		try {
			WeChatWASM.DeviceInfo self=(WeChatWASM.DeviceInfo)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.brand=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_cpuType(IntPtr l) {
		try {
			WeChatWASM.DeviceInfo self=(WeChatWASM.DeviceInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.cpuType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_cpuType(IntPtr l) {
		try {
			WeChatWASM.DeviceInfo self=(WeChatWASM.DeviceInfo)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.cpuType=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_deviceAbi(IntPtr l) {
		try {
			WeChatWASM.DeviceInfo self=(WeChatWASM.DeviceInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.deviceAbi);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_deviceAbi(IntPtr l) {
		try {
			WeChatWASM.DeviceInfo self=(WeChatWASM.DeviceInfo)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.deviceAbi=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_memorySize(IntPtr l) {
		try {
			WeChatWASM.DeviceInfo self=(WeChatWASM.DeviceInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.memorySize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_memorySize(IntPtr l) {
		try {
			WeChatWASM.DeviceInfo self=(WeChatWASM.DeviceInfo)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.memorySize=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_model(IntPtr l) {
		try {
			WeChatWASM.DeviceInfo self=(WeChatWASM.DeviceInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.model);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_model(IntPtr l) {
		try {
			WeChatWASM.DeviceInfo self=(WeChatWASM.DeviceInfo)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.model=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_platform(IntPtr l) {
		try {
			WeChatWASM.DeviceInfo self=(WeChatWASM.DeviceInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.platform);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_platform(IntPtr l) {
		try {
			WeChatWASM.DeviceInfo self=(WeChatWASM.DeviceInfo)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.platform=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_system(IntPtr l) {
		try {
			WeChatWASM.DeviceInfo self=(WeChatWASM.DeviceInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.system);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_system(IntPtr l) {
		try {
			WeChatWASM.DeviceInfo self=(WeChatWASM.DeviceInfo)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.system=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.DeviceInfo");
		addMember(l,"abi",get_abi,set_abi,true);
		addMember(l,"benchmarkLevel",get_benchmarkLevel,set_benchmarkLevel,true);
		addMember(l,"brand",get_brand,set_brand,true);
		addMember(l,"cpuType",get_cpuType,set_cpuType,true);
		addMember(l,"deviceAbi",get_deviceAbi,set_deviceAbi,true);
		addMember(l,"memorySize",get_memorySize,set_memorySize,true);
		addMember(l,"model",get_model,set_model,true);
		addMember(l,"platform",get_platform,set_platform,true);
		addMember(l,"system",get_system,set_system,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.DeviceInfo));
	}
}
