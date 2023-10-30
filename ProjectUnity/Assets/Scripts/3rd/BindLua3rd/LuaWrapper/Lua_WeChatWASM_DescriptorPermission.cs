//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_DescriptorPermission : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.DescriptorPermission o;
			o=new WeChatWASM.DescriptorPermission();
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
	static public int get_read(IntPtr l) {
		try {
			WeChatWASM.DescriptorPermission self=(WeChatWASM.DescriptorPermission)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.read);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_read(IntPtr l) {
		try {
			WeChatWASM.DescriptorPermission self=(WeChatWASM.DescriptorPermission)checkSelf(l);
			System.Nullable<System.Boolean> v;
			checkNullable(l,2,out v);
			self.read=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_write(IntPtr l) {
		try {
			WeChatWASM.DescriptorPermission self=(WeChatWASM.DescriptorPermission)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.write);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_write(IntPtr l) {
		try {
			WeChatWASM.DescriptorPermission self=(WeChatWASM.DescriptorPermission)checkSelf(l);
			System.Nullable<System.Boolean> v;
			checkNullable(l,2,out v);
			self.write=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.DescriptorPermission");
		addMember(l,"read",get_read,set_read,true);
		addMember(l,"write",get_write,set_write,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.DescriptorPermission));
	}
}
