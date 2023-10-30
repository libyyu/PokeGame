//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXAssetBundleRequest : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Dispose(IntPtr l) {
		try {
			WeChatWASM.WXAssetBundleRequest self=(WeChatWASM.WXAssetBundleRequest)checkSelf(l);
			self.Dispose();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int MoveNext(IntPtr l) {
		try {
			WeChatWASM.WXAssetBundleRequest self=(WeChatWASM.WXAssetBundleRequest)checkSelf(l);
			var ret=self.MoveNext();
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
	static public int Reset(IntPtr l) {
		try {
			WeChatWASM.WXAssetBundleRequest self=(WeChatWASM.WXAssetBundleRequest)checkSelf(l);
			self.Reset();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Callback_s(IntPtr l) {
		try {
			System.IntPtr a1 = default(System.IntPtr);
			checkType(l,1,out a1);
			System.UInt32 a2 = default(System.UInt32);
			checkType(l,2,out a2);
			System.IntPtr a3 = default(System.IntPtr);
			checkType(l,3,out a3);
			WeChatWASM.WXAssetBundleRequest.Callback(a1,a2,a3);
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
			WeChatWASM.WXAssetBundleRequest self=(WeChatWASM.WXAssetBundleRequest)checkSelf(l);
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
			WeChatWASM.WXAssetBundleRequest self=(WeChatWASM.WXAssetBundleRequest)checkSelf(l);
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
	static public int get_isDone(IntPtr l) {
		try {
			WeChatWASM.WXAssetBundleRequest self=(WeChatWASM.WXAssetBundleRequest)checkSelf(l);
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
			WeChatWASM.WXAssetBundleRequest self=(WeChatWASM.WXAssetBundleRequest)checkSelf(l);
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
	static public int get_url(IntPtr l) {
		try {
			WeChatWASM.WXAssetBundleRequest self=(WeChatWASM.WXAssetBundleRequest)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.url);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_assetBundle(IntPtr l) {
		try {
			WeChatWASM.WXAssetBundleRequest self=(WeChatWASM.WXAssetBundleRequest)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.assetBundle);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Current(IntPtr l) {
		try {
			WeChatWASM.WXAssetBundleRequest self=(WeChatWASM.WXAssetBundleRequest)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Current);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXAssetBundleRequest");
		addMember(l,Dispose);
		addMember(l,MoveNext);
		addMember(l,Reset);
		addMember(l,Callback_s);
		addMember(l,"path",get_path,set_path,true);
		addMember(l,"isDone",get_isDone,set_isDone,true);
		addMember(l,"url",get_url,null,true);
		addMember(l,"assetBundle",get_assetBundle,null,true);
		addMember(l,"Current",get_Current,null,true);
		createTypeMetatable(l,null, typeof(WeChatWASM.WXAssetBundleRequest),typeof(UnityEngine.AsyncOperation));
	}
}
