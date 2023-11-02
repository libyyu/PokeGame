//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXFileSystemManager : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXFileSystemManager o;
			o=new WeChatWASM.WXFileSystemManager();
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
	static public int WriteFileSync(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(string),typeof(string),typeof(string))){
				WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
				System.String a1 = default(System.String);
				checkType(l,2,out a1);
				System.String a2 = default(System.String);
				checkType(l,3,out a2);
				System.String a3 = default(System.String);
				checkType(l,4,out a3);
				var ret=self.WriteFileSync(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(System.Byte[]),typeof(string))){
				WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
				System.String a1 = default(System.String);
				checkType(l,2,out a1);
				System.Byte[] a2 = default(System.Byte[]);
				checkArray(l,3,out a2);
				System.String a3 = default(System.String);
				checkType(l,4,out a3);
				var ret=self.WriteFileSync(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function WriteFileSync to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WriteFile(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(WeChatWASM.WriteFileParam))){
				WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
				WeChatWASM.WriteFileParam a1 = default(WeChatWASM.WriteFileParam);
				checkType(l,2,out a1);
				self.WriteFile(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(WeChatWASM.WriteFileStringParam))){
				WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
				WeChatWASM.WriteFileStringParam a1 = default(WeChatWASM.WriteFileStringParam);
				checkType(l,2,out a1);
				self.WriteFile(a1);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function WriteFile to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AppendFile(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(WeChatWASM.WriteFileParam))){
				WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
				WeChatWASM.WriteFileParam a1 = default(WeChatWASM.WriteFileParam);
				checkType(l,2,out a1);
				self.AppendFile(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(WeChatWASM.WriteFileStringParam))){
				WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
				WeChatWASM.WriteFileStringParam a1 = default(WeChatWASM.WriteFileStringParam);
				checkType(l,2,out a1);
				self.AppendFile(a1);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function AppendFile to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReadFile(IntPtr l) {
		try {
			WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
			WeChatWASM.ReadFileParam a1 = default(WeChatWASM.ReadFileParam);
			checkType(l,2,out a1);
			self.ReadFile(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReadFileSync(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
				System.String a1 = default(System.String);
				checkType(l,2,out a1);
				System.Nullable<System.Int64> a2 = default(System.Nullable<System.Int64>);
				checkNullable(l,3,out a2);
				System.Nullable<System.Int64> a3 = default(System.Nullable<System.Int64>);
				checkNullable(l,4,out a3);
				var ret=self.ReadFileSync(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==5){
				WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
				System.String a1 = default(System.String);
				checkType(l,2,out a1);
				System.String a2 = default(System.String);
				checkType(l,3,out a2);
				System.Nullable<System.Int64> a3 = default(System.Nullable<System.Int64>);
				checkNullable(l,4,out a3);
				System.Nullable<System.Int64> a4 = default(System.Nullable<System.Int64>);
				checkNullable(l,5,out a4);
				var ret=self.ReadFileSync(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function ReadFileSync to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AccessSync(IntPtr l) {
		try {
			WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			var ret=self.AccessSync(a1);
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
	static public int Access(IntPtr l) {
		try {
			WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
			WeChatWASM.AccessParam a1 = default(WeChatWASM.AccessParam);
			checkType(l,2,out a1);
			self.Access(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CopyFileSync(IntPtr l) {
		try {
			WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			System.String a2 = default(System.String);
			checkType(l,3,out a2);
			var ret=self.CopyFileSync(a1,a2);
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
	static public int CopyFile(IntPtr l) {
		try {
			WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
			WeChatWASM.CopyFileParam a1 = default(WeChatWASM.CopyFileParam);
			checkType(l,2,out a1);
			self.CopyFile(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int UnlinkSync(IntPtr l) {
		try {
			WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			var ret=self.UnlinkSync(a1);
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
	static public int UnlinkAsync(IntPtr l) {
		try {
			WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
			WeChatWASM.UnlinkParam a1 = default(WeChatWASM.UnlinkParam);
			checkType(l,2,out a1);
			self.Unlink(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Mkdir(IntPtr l) {
		try {
			WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
			WeChatWASM.MkdirParam a1 = default(WeChatWASM.MkdirParam);
			checkType(l,2,out a1);
			self.Mkdir(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int MkdirSync(IntPtr l) {
		try {
			WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			System.Boolean a2 = default(System.Boolean);
			checkType(l,3,out a2);
			var ret=self.MkdirSync(a1,a2);
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
	static public int Rmdir(IntPtr l) {
		try {
			WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
			WeChatWASM.RmdirParam a1 = default(WeChatWASM.RmdirParam);
			checkType(l,2,out a1);
			self.Rmdir(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RmdirSync(IntPtr l) {
		try {
			WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			System.Boolean a2 = default(System.Boolean);
			checkType(l,3,out a2);
			var ret=self.RmdirSync(a1,a2);
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
	static public int Stat(IntPtr l) {
		try {
			WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
			WeChatWASM.WXStatOption a1 = default(WeChatWASM.WXStatOption);
			checkType(l,2,out a1);
			self.Stat(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AppendFileSync(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(string),typeof(string),typeof(string))){
				WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
				System.String a1 = default(System.String);
				checkType(l,2,out a1);
				System.String a2 = default(System.String);
				checkType(l,3,out a2);
				System.String a3 = default(System.String);
				checkType(l,4,out a3);
				self.AppendFileSync(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(System.Byte[]),typeof(string))){
				WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
				System.String a1 = default(System.String);
				checkType(l,2,out a1);
				System.Byte[] a2 = default(System.Byte[]);
				checkArray(l,3,out a2);
				System.String a3 = default(System.String);
				checkType(l,4,out a3);
				self.AppendFileSync(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function AppendFileSync to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReaddirSync(IntPtr l) {
		try {
			WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			var ret=self.ReaddirSync(a1);
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
	static public int ReadCompressedFileSync(IntPtr l) {
		try {
			WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
			WeChatWASM.ReadCompressedFileSyncOption a1 = default(WeChatWASM.ReadCompressedFileSyncOption);
			checkType(l,2,out a1);
			var ret=self.ReadCompressedFileSync(a1);
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
	static public int Close(IntPtr l) {
		try {
			WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
			WeChatWASM.FileSystemManagerCloseOption a1 = default(WeChatWASM.FileSystemManagerCloseOption);
			checkType(l,2,out a1);
			self.Close(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Fstat(IntPtr l) {
		try {
			WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
			WeChatWASM.FstatOption a1 = default(WeChatWASM.FstatOption);
			checkType(l,2,out a1);
			self.Fstat(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Ftruncate(IntPtr l) {
		try {
			WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
			WeChatWASM.FtruncateOption a1 = default(WeChatWASM.FtruncateOption);
			checkType(l,2,out a1);
			self.Ftruncate(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetFileInfo(IntPtr l) {
		try {
			WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
			WeChatWASM.GetFileInfoOption a1 = default(WeChatWASM.GetFileInfoOption);
			checkType(l,2,out a1);
			self.GetFileInfo(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetSavedFileList(IntPtr l) {
		try {
			WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
			WeChatWASM.GetSavedFileListOption a1 = default(WeChatWASM.GetSavedFileListOption);
			checkType(l,2,out a1);
			self.GetSavedFileList(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Open(IntPtr l) {
		try {
			WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
			WeChatWASM.OpenOption a1 = default(WeChatWASM.OpenOption);
			checkType(l,2,out a1);
			self.Open(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Read(IntPtr l) {
		try {
			WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
			WeChatWASM.ReadOption a1 = default(WeChatWASM.ReadOption);
			checkType(l,2,out a1);
			self.Read(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReadZipEntry(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(WeChatWASM.ReadZipEntryOption))){
				WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
				WeChatWASM.ReadZipEntryOption a1 = default(WeChatWASM.ReadZipEntryOption);
				checkType(l,2,out a1);
				self.ReadZipEntry(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(WeChatWASM.ReadZipEntryOptionString))){
				WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
				WeChatWASM.ReadZipEntryOptionString a1 = default(WeChatWASM.ReadZipEntryOptionString);
				checkType(l,2,out a1);
				self.ReadZipEntry(a1);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function ReadZipEntry to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Readdir(IntPtr l) {
		try {
			WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
			WeChatWASM.ReaddirOption a1 = default(WeChatWASM.ReaddirOption);
			checkType(l,2,out a1);
			self.Readdir(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RemoveSavedFile(IntPtr l) {
		try {
			WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
			WeChatWASM.RemoveSavedFileOption a1 = default(WeChatWASM.RemoveSavedFileOption);
			checkType(l,2,out a1);
			self.RemoveSavedFile(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Rename(IntPtr l) {
		try {
			WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
			WeChatWASM.RenameOption a1 = default(WeChatWASM.RenameOption);
			checkType(l,2,out a1);
			self.Rename(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RenameSync(IntPtr l) {
		try {
			WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			System.String a2 = default(System.String);
			checkType(l,3,out a2);
			self.RenameSync(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SaveFile(IntPtr l) {
		try {
			WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
			WeChatWASM.SaveFileOption a1 = default(WeChatWASM.SaveFileOption);
			checkType(l,2,out a1);
			self.SaveFile(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Truncate(IntPtr l) {
		try {
			WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
			WeChatWASM.TruncateOption a1 = default(WeChatWASM.TruncateOption);
			checkType(l,2,out a1);
			self.Truncate(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Unzip(IntPtr l) {
		try {
			WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
			WeChatWASM.UnzipOption a1 = default(WeChatWASM.UnzipOption);
			checkType(l,2,out a1);
			self.Unzip(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Write(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(WeChatWASM.WriteOption))){
				WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
				WeChatWASM.WriteOption a1 = default(WeChatWASM.WriteOption);
				checkType(l,2,out a1);
				self.Write(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(WeChatWASM.WriteStringOption))){
				WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
				WeChatWASM.WriteStringOption a1 = default(WeChatWASM.WriteStringOption);
				checkType(l,2,out a1);
				self.Write(a1);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function Write to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReadSync(IntPtr l) {
		try {
			WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
			WeChatWASM.ReadSyncOption a1 = default(WeChatWASM.ReadSyncOption);
			checkType(l,2,out a1);
			var ret=self.ReadSync(a1);
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
	static public int FstatSync(IntPtr l) {
		try {
			WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
			WeChatWASM.FstatSyncOption a1 = default(WeChatWASM.FstatSyncOption);
			checkType(l,2,out a1);
			var ret=self.FstatSync(a1);
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
	static public int StatSync(IntPtr l) {
		try {
			WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			var ret=self.StatSync(a1);
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
	static public int WriteSync(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(WeChatWASM.WriteSyncOption))){
				WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
				WeChatWASM.WriteSyncOption a1 = default(WeChatWASM.WriteSyncOption);
				checkType(l,2,out a1);
				var ret=self.WriteSync(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(WeChatWASM.WriteSyncStringOption))){
				WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
				WeChatWASM.WriteSyncStringOption a1 = default(WeChatWASM.WriteSyncStringOption);
				checkType(l,2,out a1);
				var ret=self.WriteSync(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function WriteSync to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OpenSync(IntPtr l) {
		try {
			WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
			WeChatWASM.OpenSyncOption a1 = default(WeChatWASM.OpenSyncOption);
			checkType(l,2,out a1);
			var ret=self.OpenSync(a1);
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
	static public int SaveFileSync(IntPtr l) {
		try {
			WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
			System.String a1 = default(System.String);
			checkType(l,2,out a1);
			System.String a2 = default(System.String);
			checkType(l,3,out a2);
			var ret=self.SaveFileSync(a1,a2);
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
	static public int CloseSync(IntPtr l) {
		try {
			WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
			WeChatWASM.CloseSyncOption a1 = default(WeChatWASM.CloseSyncOption);
			checkType(l,2,out a1);
			self.CloseSync(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int FtruncateSync(IntPtr l) {
		try {
			WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
			WeChatWASM.FtruncateSyncOption a1 = default(WeChatWASM.FtruncateSyncOption);
			checkType(l,2,out a1);
			self.FtruncateSync(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int TruncateSync(IntPtr l) {
		try {
			WeChatWASM.WXFileSystemManager self=(WeChatWASM.WXFileSystemManager)checkSelf(l);
			WeChatWASM.TruncateSyncOption a1 = default(WeChatWASM.TruncateSyncOption);
			checkType(l,2,out a1);
			self.TruncateSync(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int HandleStatCallback_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			WeChatWASM.WXFileSystemManager.HandleStatCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int HandleMethodCallback_s(IntPtr l) {
		try {
			System.String a1 = default(System.String);
			checkType(l,1,out a1);
			WeChatWASM.WXFileSystemManager.HandleMethodCallback(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXFileSystemManager");
		addMember(l,WriteFileSync);
		addMember(l,WriteFile);
		addMember(l,AppendFile);
		addMember(l,ReadFile);
		addMember(l,ReadFileSync);
		addMember(l,AccessSync);
		addMember(l,Access);
		addMember(l,CopyFileSync);
		addMember(l,CopyFile);
		addMember(l,UnlinkSync);
		addMember(l,UnlinkAsync);
		addMember(l,Mkdir);
		addMember(l,MkdirSync);
		addMember(l,Rmdir);
		addMember(l,RmdirSync);
		addMember(l,Stat);
		addMember(l,AppendFileSync);
		addMember(l,ReaddirSync);
		addMember(l,ReadCompressedFileSync);
		addMember(l,Close);
		addMember(l,Fstat);
		addMember(l,Ftruncate);
		addMember(l,GetFileInfo);
		addMember(l,GetSavedFileList);
		addMember(l,Open);
		addMember(l,Read);
		addMember(l,ReadZipEntry);
		addMember(l,Readdir);
		addMember(l,RemoveSavedFile);
		addMember(l,Rename);
		addMember(l,RenameSync);
		addMember(l,SaveFile);
		addMember(l,Truncate);
		addMember(l,Unzip);
		addMember(l,Write);
		addMember(l,ReadSync);
		addMember(l,FstatSync);
		addMember(l,StatSync);
		addMember(l,WriteSync);
		addMember(l,OpenSync);
		addMember(l,SaveFileSync);
		addMember(l,CloseSync);
		addMember(l,FtruncateSync);
		addMember(l,TruncateSync);
		addMember(l,HandleStatCallback_s);
		addMember(l,HandleMethodCallback_s);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXFileSystemManager));
	}
}
