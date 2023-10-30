//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_CharacteristicPermission : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.CharacteristicPermission o;
			o=new WeChatWASM.CharacteristicPermission();
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
	static public int get_readEncryptionRequired(IntPtr l) {
		try {
			WeChatWASM.CharacteristicPermission self=(WeChatWASM.CharacteristicPermission)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.readEncryptionRequired);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_readEncryptionRequired(IntPtr l) {
		try {
			WeChatWASM.CharacteristicPermission self=(WeChatWASM.CharacteristicPermission)checkSelf(l);
			System.Nullable<System.Boolean> v;
			checkNullable(l,2,out v);
			self.readEncryptionRequired=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_readable(IntPtr l) {
		try {
			WeChatWASM.CharacteristicPermission self=(WeChatWASM.CharacteristicPermission)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.readable);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_readable(IntPtr l) {
		try {
			WeChatWASM.CharacteristicPermission self=(WeChatWASM.CharacteristicPermission)checkSelf(l);
			System.Nullable<System.Boolean> v;
			checkNullable(l,2,out v);
			self.readable=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_writeEncryptionRequired(IntPtr l) {
		try {
			WeChatWASM.CharacteristicPermission self=(WeChatWASM.CharacteristicPermission)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.writeEncryptionRequired);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_writeEncryptionRequired(IntPtr l) {
		try {
			WeChatWASM.CharacteristicPermission self=(WeChatWASM.CharacteristicPermission)checkSelf(l);
			System.Nullable<System.Boolean> v;
			checkNullable(l,2,out v);
			self.writeEncryptionRequired=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_writeable(IntPtr l) {
		try {
			WeChatWASM.CharacteristicPermission self=(WeChatWASM.CharacteristicPermission)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.writeable);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_writeable(IntPtr l) {
		try {
			WeChatWASM.CharacteristicPermission self=(WeChatWASM.CharacteristicPermission)checkSelf(l);
			System.Nullable<System.Boolean> v;
			checkNullable(l,2,out v);
			self.writeable=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.CharacteristicPermission");
		addMember(l,"readEncryptionRequired",get_readEncryptionRequired,set_readEncryptionRequired,true);
		addMember(l,"readable",get_readable,set_readable,true);
		addMember(l,"writeEncryptionRequired",get_writeEncryptionRequired,set_writeEncryptionRequired,true);
		addMember(l,"writeable",get_writeable,set_writeable,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.CharacteristicPermission));
	}
}
