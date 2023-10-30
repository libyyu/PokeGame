//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_GetBLEDeviceCharacteristicsSuccessCallbackResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.GetBLEDeviceCharacteristicsSuccessCallbackResult o;
			o=new WeChatWASM.GetBLEDeviceCharacteristicsSuccessCallbackResult();
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
	static public int get_characteristics(IntPtr l) {
		try {
			WeChatWASM.GetBLEDeviceCharacteristicsSuccessCallbackResult self=(WeChatWASM.GetBLEDeviceCharacteristicsSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.characteristics);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_characteristics(IntPtr l) {
		try {
			WeChatWASM.GetBLEDeviceCharacteristicsSuccessCallbackResult self=(WeChatWASM.GetBLEDeviceCharacteristicsSuccessCallbackResult)checkSelf(l);
			WeChatWASM.BLECharacteristic[] v;
			checkArray(l,2,out v);
			self.characteristics=v;
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
			WeChatWASM.GetBLEDeviceCharacteristicsSuccessCallbackResult self=(WeChatWASM.GetBLEDeviceCharacteristicsSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.GetBLEDeviceCharacteristicsSuccessCallbackResult self=(WeChatWASM.GetBLEDeviceCharacteristicsSuccessCallbackResult)checkSelf(l);
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
		getTypeTable(l,"WeChatWASM.GetBLEDeviceCharacteristicsSuccessCallbackResult");
		addMember(l,"characteristics",get_characteristics,set_characteristics,true);
		addMember(l,"errMsg",get_errMsg,set_errMsg,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.GetBLEDeviceCharacteristicsSuccessCallbackResult));
	}
}
