//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_OperateGameRecorderVideoOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.OperateGameRecorderVideoOption o;
			o=new WeChatWASM.OperateGameRecorderVideoOption();
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
	static public int get_atempo(IntPtr l) {
		try {
			WeChatWASM.OperateGameRecorderVideoOption self=(WeChatWASM.OperateGameRecorderVideoOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.atempo);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_atempo(IntPtr l) {
		try {
			WeChatWASM.OperateGameRecorderVideoOption self=(WeChatWASM.OperateGameRecorderVideoOption)checkSelf(l);
			System.Nullable<System.Double> v;
			checkNullable(l,2,out v);
			self.atempo=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_audioMix(IntPtr l) {
		try {
			WeChatWASM.OperateGameRecorderVideoOption self=(WeChatWASM.OperateGameRecorderVideoOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.audioMix);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_audioMix(IntPtr l) {
		try {
			WeChatWASM.OperateGameRecorderVideoOption self=(WeChatWASM.OperateGameRecorderVideoOption)checkSelf(l);
			System.Nullable<System.Boolean> v;
			checkNullable(l,2,out v);
			self.audioMix=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_bgm(IntPtr l) {
		try {
			WeChatWASM.OperateGameRecorderVideoOption self=(WeChatWASM.OperateGameRecorderVideoOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.bgm);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_bgm(IntPtr l) {
		try {
			WeChatWASM.OperateGameRecorderVideoOption self=(WeChatWASM.OperateGameRecorderVideoOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.bgm=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_desc(IntPtr l) {
		try {
			WeChatWASM.OperateGameRecorderVideoOption self=(WeChatWASM.OperateGameRecorderVideoOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.desc);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_desc(IntPtr l) {
		try {
			WeChatWASM.OperateGameRecorderVideoOption self=(WeChatWASM.OperateGameRecorderVideoOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.desc=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_path(IntPtr l) {
		try {
			WeChatWASM.OperateGameRecorderVideoOption self=(WeChatWASM.OperateGameRecorderVideoOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.path);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_path(IntPtr l) {
		try {
			WeChatWASM.OperateGameRecorderVideoOption self=(WeChatWASM.OperateGameRecorderVideoOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.path=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_query(IntPtr l) {
		try {
			WeChatWASM.OperateGameRecorderVideoOption self=(WeChatWASM.OperateGameRecorderVideoOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.query);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_query(IntPtr l) {
		try {
			WeChatWASM.OperateGameRecorderVideoOption self=(WeChatWASM.OperateGameRecorderVideoOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.query=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_timeRange(IntPtr l) {
		try {
			WeChatWASM.OperateGameRecorderVideoOption self=(WeChatWASM.OperateGameRecorderVideoOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.timeRange);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_timeRange(IntPtr l) {
		try {
			WeChatWASM.OperateGameRecorderVideoOption self=(WeChatWASM.OperateGameRecorderVideoOption)checkSelf(l);
			System.Double[][] v;
			checkArray(l,2,out v);
			self.timeRange=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_title(IntPtr l) {
		try {
			WeChatWASM.OperateGameRecorderVideoOption self=(WeChatWASM.OperateGameRecorderVideoOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.title);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_title(IntPtr l) {
		try {
			WeChatWASM.OperateGameRecorderVideoOption self=(WeChatWASM.OperateGameRecorderVideoOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.title=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_volume(IntPtr l) {
		try {
			WeChatWASM.OperateGameRecorderVideoOption self=(WeChatWASM.OperateGameRecorderVideoOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.volume);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_volume(IntPtr l) {
		try {
			WeChatWASM.OperateGameRecorderVideoOption self=(WeChatWASM.OperateGameRecorderVideoOption)checkSelf(l);
			System.Nullable<System.Double> v;
			checkNullable(l,2,out v);
			self.volume=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.OperateGameRecorderVideoOption");
		addMember(l,"atempo",get_atempo,set_atempo,true);
		addMember(l,"audioMix",get_audioMix,set_audioMix,true);
		addMember(l,"bgm",get_bgm,set_bgm,true);
		addMember(l,"desc",get_desc,set_desc,true);
		addMember(l,"path",get_path,set_path,true);
		addMember(l,"query",get_query,set_query,true);
		addMember(l,"timeRange",get_timeRange,set_timeRange,true);
		addMember(l,"title",get_title,set_title,true);
		addMember(l,"volume",get_volume,set_volume,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.OperateGameRecorderVideoOption));
	}
}
