//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXAssetBundle : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetInstanceID(IntPtr l) {
		try {
			WeChatWASM.WXAssetBundle self=(WeChatWASM.WXAssetBundle)checkSelf(l);
			var ret=self.GetInstanceID();
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
	static public int LoadAssetAsync(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				WeChatWASM.WXAssetBundle self=(WeChatWASM.WXAssetBundle)checkSelf(l);
				System.String a1 = default(System.String);
				checkType(l,2,out a1);
				var ret=self.LoadAssetAsync(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				WeChatWASM.WXAssetBundle self=(WeChatWASM.WXAssetBundle)checkSelf(l);
				System.String a1 = default(System.String);
				checkType(l,2,out a1);
				System.Type a2 = default(System.Type);
				checkType(l,3,out a2);
				var ret=self.LoadAssetAsync(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function LoadAssetAsync to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LoadAsset(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(string))){
				WeChatWASM.WXAssetBundle self=(WeChatWASM.WXAssetBundle)checkSelf(l);
				System.String a1 = default(System.String);
				checkType(l,2,out a1);
				var ret=self.LoadAsset(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(string))){
				WeChatWASM.WXAssetBundle self=(WeChatWASM.WXAssetBundle)checkSelf(l);
				System.String a1 = default(System.String);
				checkType(l,2,out a1);
				var ret=self.LoadAsset<UnityEngine.Object>(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				WeChatWASM.WXAssetBundle self=(WeChatWASM.WXAssetBundle)checkSelf(l);
				System.String a1 = default(System.String);
				checkType(l,2,out a1);
				System.Type a2 = default(System.Type);
				checkType(l,3,out a2);
				var ret=self.LoadAsset(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function LoadAsset to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LoadAllAssets(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2)){
				WeChatWASM.WXAssetBundle self=(WeChatWASM.WXAssetBundle)checkSelf(l);
				var ret=self.LoadAllAssets();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2)){
				WeChatWASM.WXAssetBundle self=(WeChatWASM.WXAssetBundle)checkSelf(l);
				var ret=self.LoadAllAssets<UnityEngine.Object>();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				WeChatWASM.WXAssetBundle self=(WeChatWASM.WXAssetBundle)checkSelf(l);
				System.Type a1 = default(System.Type);
				checkType(l,2,out a1);
				var ret=self.LoadAllAssets(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function LoadAllAssets to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LoadAllAssetsAsync(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				WeChatWASM.WXAssetBundle self=(WeChatWASM.WXAssetBundle)checkSelf(l);
				var ret=self.LoadAllAssetsAsync();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				WeChatWASM.WXAssetBundle self=(WeChatWASM.WXAssetBundle)checkSelf(l);
				System.Type a1 = default(System.Type);
				checkType(l,2,out a1);
				var ret=self.LoadAllAssetsAsync(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function LoadAllAssetsAsync to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AllAssetNames(IntPtr l) {
		try {
			WeChatWASM.WXAssetBundle self=(WeChatWASM.WXAssetBundle)checkSelf(l);
			var ret=self.AllAssetNames();
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
	static public int GetAllAssetNames(IntPtr l) {
		try {
			WeChatWASM.WXAssetBundle self=(WeChatWASM.WXAssetBundle)checkSelf(l);
			var ret=self.GetAllAssetNames();
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
	static public int Unload(IntPtr l) {
		try {
			WeChatWASM.WXAssetBundle self=(WeChatWASM.WXAssetBundle)checkSelf(l);
			System.Boolean a1 = default(System.Boolean);
			checkType(l,2,out a1);
			self.Unload(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int UnloadbyPath_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			WeChatWASM.WXAssetBundle.UnloadbyPath(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int UnCleanbyPath_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			WeChatWASM.WXAssetBundle.UnCleanbyPath(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CheckWXFSReady_s(IntPtr l) {
		try {
			var ret=WeChatWASM.WXAssetBundle.CheckWXFSReady();
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
	static public int LoadFromFileAsync_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				System.String a1 = default(System.String);
				checkType(l,1,out a1);
				var ret=WeChatWASM.WXAssetBundle.LoadFromFileAsync(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.String a1 = default(System.String);
				checkType(l,1,out a1);
				System.UInt32 a2 = default(System.UInt32);
				checkType(l,2,out a2);
				var ret=WeChatWASM.WXAssetBundle.LoadFromFileAsync(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				System.String a1 = default(System.String);
				checkType(l,1,out a1);
				System.UInt32 a2 = default(System.UInt32);
				checkType(l,2,out a2);
				System.UInt64 a3 = default(System.UInt64);
				checkType(l,3,out a3);
				var ret=WeChatWASM.WXAssetBundle.LoadFromFileAsync(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function LoadFromFileAsync to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LoadFromFile_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				System.String a1 = default(System.String);
				checkType(l,1,out a1);
				var ret=WeChatWASM.WXAssetBundle.LoadFromFile(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.String a1 = default(System.String);
				checkType(l,1,out a1);
				System.UInt32 a2 = default(System.UInt32);
				checkType(l,2,out a2);
				var ret=WeChatWASM.WXAssetBundle.LoadFromFile(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				System.String a1 = default(System.String);
				checkType(l,1,out a1);
				System.UInt32 a2 = default(System.UInt32);
				checkType(l,2,out a2);
				System.UInt64 a3 = default(System.UInt64);
				checkType(l,3,out a3);
				var ret=WeChatWASM.WXAssetBundle.LoadFromFile(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function LoadFromFile to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int UnloadAllAssetBundles_s(IntPtr l) {
		try {
			System.Boolean a1 = default(System.Boolean);
			checkType(l,1,out a1);
			WeChatWASM.WXAssetBundle.UnloadAllAssetBundles(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetAssetBundle_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				System.String a1 = default(System.String);
				checkType(l,1,out a1);
				var ret=WeChatWASM.WXAssetBundle.GetAssetBundle(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.String a1 = default(System.String);
				checkType(l,1,out a1);
				System.UInt32 a2 = default(System.UInt32);
				checkType(l,2,out a2);
				var ret=WeChatWASM.WXAssetBundle.GetAssetBundle(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function GetAssetBundle to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_bundle2path(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,WeChatWASM.WXAssetBundle.bundle2path);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_bundle2path(IntPtr l) {
		try {
			System.Collections.Generic.Dictionary<UnityEngine.AssetBundle,System.String> v;
			checkType(l,2,out v);
			WeChatWASM.WXAssetBundle.bundle2path=v;
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
			WeChatWASM.WXAssetBundle self=(WeChatWASM.WXAssetBundle)checkSelf(l);
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
	static public int set_assetBundle(IntPtr l) {
		try {
			WeChatWASM.WXAssetBundle self=(WeChatWASM.WXAssetBundle)checkSelf(l);
			UnityEngine.AssetBundle v;
			checkType(l,2,out v);
			self.assetBundle=v;
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
			WeChatWASM.WXAssetBundle self=(WeChatWASM.WXAssetBundle)checkSelf(l);
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
			WeChatWASM.WXAssetBundle self=(WeChatWASM.WXAssetBundle)checkSelf(l);
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
	static public int get_wxfs_ready(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,WeChatWASM.WXAssetBundle.wxfs_ready);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_wxfs_ready(IntPtr l) {
		try {
			System.Boolean v;
			checkType(l,2,out v);
			WeChatWASM.WXAssetBundle.wxfs_ready=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_name(IntPtr l) {
		try {
			WeChatWASM.WXAssetBundle self=(WeChatWASM.WXAssetBundle)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.name);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_isStreamedSceneAssetBundle(IntPtr l) {
		try {
			WeChatWASM.WXAssetBundle self=(WeChatWASM.WXAssetBundle)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isStreamedSceneAssetBundle);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXAssetBundle");
		addMember(l,GetInstanceID);
		addMember(l,LoadAssetAsync);
		addMember(l,LoadAsset);
		addMember(l,LoadAllAssets);
		addMember(l,LoadAllAssetsAsync);
		addMember(l,AllAssetNames);
		addMember(l,GetAllAssetNames);
		addMember(l,Unload);
		addMember(l,UnloadbyPath_s);
		addMember(l,UnCleanbyPath_s);
		addMember(l,CheckWXFSReady_s);
		addMember(l,LoadFromFileAsync_s);
		addMember(l,LoadFromFile_s);
		addMember(l,UnloadAllAssetBundles_s);
		addMember(l,GetAssetBundle_s);
		addMember(l,"bundle2path",get_bundle2path,set_bundle2path,false);
		addMember(l,"assetBundle",get_assetBundle,set_assetBundle,true);
		addMember(l,"path",get_path,set_path,true);
		addMember(l,"wxfs_ready",get_wxfs_ready,set_wxfs_ready,false);
		addMember(l,"name",get_name,null,true);
		addMember(l,"isStreamedSceneAssetBundle",get_isStreamedSceneAssetBundle,null,true);
		createTypeMetatable(l,null, typeof(WeChatWASM.WXAssetBundle));
	}
}
