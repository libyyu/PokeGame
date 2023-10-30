//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXVideoDecoder : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXVideoDecoder o;
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			o=new WeChatWASM.WXVideoDecoder(a1);
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
	static public int GetFrameData(IntPtr l) {
		try {
			WeChatWASM.WXVideoDecoder self=(WeChatWASM.WXVideoDecoder)checkSelf(l);
			var ret=self.GetFrameData();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Remove(IntPtr l) {
		try {
			WeChatWASM.WXVideoDecoder self=(WeChatWASM.WXVideoDecoder)checkSelf(l);
			self.Remove();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Seek(IntPtr l) {
		try {
			WeChatWASM.WXVideoDecoder self=(WeChatWASM.WXVideoDecoder)checkSelf(l);
			System.Double a1 = default(System.Double);
			checkType(l,2,out a1);
			self.Seek(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Start(IntPtr l) {
		try {
			WeChatWASM.WXVideoDecoder self=(WeChatWASM.WXVideoDecoder)checkSelf(l);
			WeChatWASM.VideoDecoderStartOption a1 = default(WeChatWASM.VideoDecoderStartOption);
			checkType(l,2,out a1);
			self.Start(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Stop(IntPtr l) {
		try {
			WeChatWASM.WXVideoDecoder self=(WeChatWASM.WXVideoDecoder)checkSelf(l);
			self.Stop();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Off(IntPtr l) {
		try {
			WeChatWASM.WXVideoDecoder self=(WeChatWASM.WXVideoDecoder)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			self.Off(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int On(IntPtr l) {
		try {
			WeChatWASM.WXVideoDecoder self=(WeChatWASM.WXVideoDecoder)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			System.Action<System.String> a2 = default(System.Action<System.String>);
			checkDelegate(l,3,out a2);
			self.On(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_OnActionList(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,WeChatWASM.WXVideoDecoder.OnActionList);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_OnActionList(IntPtr l) {
		try {
			System.Collections.Generic.Dictionary<System.String,System.Action<System.String>> v;
			checkType(l,2,out v);
			WeChatWASM.WXVideoDecoder.OnActionList=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXVideoDecoder");
		addMember(l,GetFrameData);
		addMember(l,Remove);
		addMember(l,Seek);
		addMember(l,Start);
		addMember(l,Stop);
		addMember(l,Off);
		addMember(l,On);
		addMember(l,"OnActionList",get_OnActionList,set_OnActionList,false);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXVideoDecoder));
	}
}
