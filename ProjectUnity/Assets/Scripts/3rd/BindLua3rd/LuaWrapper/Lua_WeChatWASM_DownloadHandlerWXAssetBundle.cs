//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_DownloadHandlerWXAssetBundle : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.DownloadHandlerWXAssetBundle o;
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			System.UInt32 a2 = default(System.UInt32);
			checkType(l,3,out a2);
			o=new WeChatWASM.DownloadHandlerWXAssetBundle(a1,a2);
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
	static public int get_isDone(IntPtr l) {
		try {
			WeChatWASM.DownloadHandlerWXAssetBundle self=(WeChatWASM.DownloadHandlerWXAssetBundle)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isDone);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_isDone(IntPtr l) {
		try {
			WeChatWASM.DownloadHandlerWXAssetBundle self=(WeChatWASM.DownloadHandlerWXAssetBundle)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.isDone=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_assetBundle(IntPtr l) {
		try {
			WeChatWASM.DownloadHandlerWXAssetBundle self=(WeChatWASM.DownloadHandlerWXAssetBundle)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.assetBundle);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.DownloadHandlerWXAssetBundle");
		addMember(l,"isDone",get_isDone,set_isDone,true);
		addMember(l,"assetBundle",get_assetBundle,null,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.DownloadHandlerWXAssetBundle),typeof(UnityEngine.Networking.DownloadHandlerScript));
	}
}
