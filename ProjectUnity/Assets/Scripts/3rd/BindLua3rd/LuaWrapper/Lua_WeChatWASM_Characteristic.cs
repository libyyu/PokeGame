//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_Characteristic : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.Characteristic o;
			o=new WeChatWASM.Characteristic();
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
	static public int get_uuid(IntPtr l) {
		try {
			WeChatWASM.Characteristic self=(WeChatWASM.Characteristic)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.uuid);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_uuid(IntPtr l) {
		try {
			WeChatWASM.Characteristic self=(WeChatWASM.Characteristic)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.uuid=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_descriptors(IntPtr l) {
		try {
			WeChatWASM.Characteristic self=(WeChatWASM.Characteristic)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.descriptors);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_descriptors(IntPtr l) {
		try {
			WeChatWASM.Characteristic self=(WeChatWASM.Characteristic)checkSelf(l);
			WeChatWASM.Descriptor[] v;
			checkArray(l,2,out v);
			self.descriptors=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_permission(IntPtr l) {
		try {
			WeChatWASM.Characteristic self=(WeChatWASM.Characteristic)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.permission);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_permission(IntPtr l) {
		try {
			WeChatWASM.Characteristic self=(WeChatWASM.Characteristic)checkSelf(l);
			WeChatWASM.CharacteristicPermission v;
			checkType(l,2,out v);
			self.permission=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_properties(IntPtr l) {
		try {
			WeChatWASM.Characteristic self=(WeChatWASM.Characteristic)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.properties);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_properties(IntPtr l) {
		try {
			WeChatWASM.Characteristic self=(WeChatWASM.Characteristic)checkSelf(l);
			WeChatWASM.CharacteristicProperties v;
			checkType(l,2,out v);
			self.properties=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_value(IntPtr l) {
		try {
			WeChatWASM.Characteristic self=(WeChatWASM.Characteristic)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.value);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_value(IntPtr l) {
		try {
			WeChatWASM.Characteristic self=(WeChatWASM.Characteristic)checkSelf(l);
			System.Byte[] v;
			checkArray(l,2,out v);
			self.value=v;
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
			WeChatWASM.Characteristic self=(WeChatWASM.Characteristic)checkSelf(l);
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
			WeChatWASM.Characteristic self=(WeChatWASM.Characteristic)checkSelf(l);
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
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.Characteristic");
		addMember(l,"uuid",get_uuid,set_uuid,true);
		addMember(l,"descriptors",get_descriptors,set_descriptors,true);
		addMember(l,"permission",get_permission,set_permission,true);
		addMember(l,"properties",get_properties,set_properties,true);
		addMember(l,"value",get_value,set_value,true);
		addMember(l,"arrayBufferLength",get_arrayBufferLength,set_arrayBufferLength,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.Characteristic));
	}
}
