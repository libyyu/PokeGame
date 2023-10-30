//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_CreateBLEPeripheralServerSuccessCallbackResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.CreateBLEPeripheralServerSuccessCallbackResult o;
			o=new WeChatWASM.CreateBLEPeripheralServerSuccessCallbackResult();
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
	static public int get_server(IntPtr l) {
		try {
			WeChatWASM.CreateBLEPeripheralServerSuccessCallbackResult self=(WeChatWASM.CreateBLEPeripheralServerSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.server);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_server(IntPtr l) {
		try {
			WeChatWASM.CreateBLEPeripheralServerSuccessCallbackResult self=(WeChatWASM.CreateBLEPeripheralServerSuccessCallbackResult)checkSelf(l);
			WeChatWASM.BLEPeripheralServer v;
			checkType(l,2,out v);
			self.server=v;
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
			WeChatWASM.CreateBLEPeripheralServerSuccessCallbackResult self=(WeChatWASM.CreateBLEPeripheralServerSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.CreateBLEPeripheralServerSuccessCallbackResult self=(WeChatWASM.CreateBLEPeripheralServerSuccessCallbackResult)checkSelf(l);
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
		getTypeTable(l,"WeChatWASM.CreateBLEPeripheralServerSuccessCallbackResult");
		addMember(l,"server",get_server,set_server,true);
		addMember(l,"errMsg",get_errMsg,set_errMsg,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.CreateBLEPeripheralServerSuccessCallbackResult));
	}
}
