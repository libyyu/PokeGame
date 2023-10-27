using UnityEngine;
using UnityEditor;
using System;
using System.IO;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityLog = UnityEngine.Debug;
using UObject = UnityEngine.Object;

public class AssetExport
{
	const string password = "LuaGame";
	const string bundleExt = ".assetbundle";

	static void SetAssetBundleName(UObject[] o)
	{
        if (o.Length == 0)
            return;
        string sp = AssetDatabase.GetAssetPath(o[0]);
        string abName = sp.ToLower().Replace("\\", "/");
        string bundleName = abName;

        AssetImporter import = null;
		foreach (UObject s in o) {
			sp = AssetDatabase.GetAssetPath (s);
			abName = sp.ToLower ().Replace ("\\", "/");

            import = AssetImporter.GetAtPath (sp);
            import.assetBundleName = abName + bundleExt;
            LogUtil.Log(abName);
		}

		AssetDatabase.Refresh();
	}

	static void UnSetAssetBundleName(UObject[] o)
	{
		AssetImporter import = null;
		foreach (UObject s in o){
			import = AssetImporter.GetAtPath(AssetDatabase.GetAssetPath(s));
			import.assetBundleName = null;
		}

		AssetDatabase.Refresh();
	}

	public static bool CompileLuaFile(string srcFile, string outFile, bool luajit = false) {
		bool isWin = true;
		string luaexe = string.Empty;
		string args = string.Empty;
		string exedir = string.Empty;
		string currDir = Directory.GetCurrentDirectory();
		if (luajit) {
			args = "-b " + srcFile + " " + outFile;
			exedir = Application.dataPath + "/../../Tools/LuaEncoder/luajit/";
			if (Application.platform == RuntimePlatform.WindowsEditor) {
				isWin = true;
				luaexe = "luajit.exe";
			} else if (Application.platform == RuntimePlatform.OSXEditor) {
				isWin = false;
				luaexe = "./luajit";
			}
		} else {
			args = "-o " + outFile + " " + srcFile;
			exedir = Application.dataPath + "/../../Tools/LuaEncoder/luavm/";
			if (Application.platform == RuntimePlatform.WindowsEditor) {
				isWin = true;
				luaexe = "luac.exe";
			} else if (Application.platform == RuntimePlatform.OSXEditor) {
				isWin = false;
				luaexe = "./luac";
			}
		}

		Directory.SetCurrentDirectory(exedir);
		ProcessStartInfo info = new ProcessStartInfo();
		info.FileName = luaexe;
		info.Arguments = args;
		info.WindowStyle = ProcessWindowStyle.Hidden;
		info.ErrorDialog = true;
		info.UseShellExecute = isWin;
		LogUtil.Log(info.FileName + " " + info.Arguments);

		Process pro = Process.Start(info);
		pro.WaitForExit();
		Directory.SetCurrentDirectory(currDir);
		int code = pro.ExitCode;
		if (code != 0) {
			LogUtil.LogError (string.Format ("Failed to Compile Lua Script, File={0},Exec={1}", srcFile,luaexe));
			return false;
		}
		return true;
	}

	static bool CompileLuaScripts(string src, string dst, bool luajit = false )
	{
		if (!Directory.Exists (src))
			return true;
		Directory.CreateDirectory (dst);
		foreach (string filename in Directory.GetFiles(src, "*.lua", SearchOption.AllDirectories))
		{
			string fname = filename.Replace (src, "");
			string foutname = dst + fname;
			Directory.CreateDirectory (Path.GetDirectoryName(foutname));
			if (!CompileLuaFile (filename, foutname, luajit))
				return false;
		}
		return true;
	}

	static void CopyDirectorys(string src, string dst, Action<string> call = null)
	{
		if (!Directory.Exists (src))
			return;
		Directory.CreateDirectory (dst);
		foreach (string filename in Directory.GetFiles(src, "*.*", SearchOption.AllDirectories))
		{
			string fname = filename.Replace (src, "");
			string foutname = dst + fname;
			Directory.CreateDirectory (Path.GetDirectoryName(foutname));
			File.Copy (filename, foutname, true);
			if (call != null) call(foutname);
        }
	}

	[MenuItem("ExportAssets/测试")]
	static void Test()
	{
		CopyDirectorys (Application.dataPath+"/../../Output",Application.dataPath+"/../../Output2");
	}


	static void ExportAssets(string output)
	{
		BuildTarget target = EditorUserBuildSettings.activeBuildTarget;
		UnityLog.Log(string.Format("打包资源到目录:{0},平台:{1}", output, target.ToString()));

		if (!Directory.Exists(output))
			Directory.CreateDirectory(output);
		
		BuildAssetBundleOptions options = BuildAssetBundleOptions.DeterministicAssetBundle | 
			BuildAssetBundleOptions.UncompressedAssetBundle;
		BuildPipeline.BuildAssetBundles(output, options, target);

		AssetDatabase.Refresh();
		UnityLog.Log("AssetBundle打包完成");
	}

    [MenuItem("ExportAssets/步骤0.导入Lua脚本", false, 10)]
    public static void ImportLuaScript()
    {
        string src_res = Application.dataPath + "/../../Output";

		CopyDirectorys(src_res + "/Lua", Application.dataPath + "/Lua", (String filepath) =>
		{
			File.Delete(filepath + ".bytes");
			File.Move(filepath, filepath + ".bytes");
		});
    }

    [MenuItem("ExportAssets/步骤1.导出AssetBundle", false, 11)]
	public static void ExportAllAssets()
	{
        string dst_path = Application.dataPath + "/../../Output/StreamingAssets";
        ExportAssets(dst_path);
	}

	[MenuItem("ExportAssets/步骤2.打包所有资源(使用Lua源码)", false, 12)]
	public static void NoZipPackUnityResNoCompileLua()
	{
		string dst_res = Application.dataPath +  "/StreamingAssets/res_base";

		string src_res = Application.dataPath + "/../../Output";

		CopyDirectorys (src_res+"/Configs", dst_res+"/Configs");
		CopyDirectorys (src_res+"/Lua", dst_res+"/Lua");
		CopyDirectorys (src_res+"/StreamingAssets", dst_res+"/StreamingAssets");

		UnityLog.Log("Zip包自作完成,path=" + dst_res);
		AssetDatabase.Refresh();
	}

	[MenuItem("ExportAssets/步骤2.打包所有资源(使用luac编译)", false, 13)]
	public static void NoZipPackUnityResCompileLua()
	{
		string dst_res = Application.dataPath +  "/StreamingAssets/res_base";

		string src_res = Application.dataPath + "/../../Output";

		string temp_dir = Application.dataPath + "/../../Output/temp";

		CopyDirectorys (src_res+"/Configs", temp_dir+"/Configs");
		CopyDirectorys (src_res+"/StreamingAssets", temp_dir+"/StreamingAssets");

		if (!CompileLuaScripts (src_res + "/Lua", temp_dir + "/Lua", false)) {
			if (!EditorUtility.DisplayDialog ("FLuaGame", "Failed to Pack All Assets", "Continue", "No")) {
				return;
			}
		}

		CopyDirectorys (temp_dir, dst_res);

		Directory.Delete (temp_dir, true);

		UnityLog.Log("Zip包自作完成,path=" + dst_res);
		AssetDatabase.Refresh();
	}

	[MenuItem("ExportAssets/步骤2.打包所有资源(使用luajit编译)", false, 14)]
	public static void NoZipPackUnityResCompileLuaWithJit()
	{
		string dst_res = Application.dataPath +  "/StreamingAssets/res_base";

		string src_res = Application.dataPath + "/../../Output";

		string temp_dir = Application.dataPath + "/../../Output/temp";

		CopyDirectorys (src_res+"/Configs", temp_dir+"/Configs");
		CopyDirectorys (src_res+"/StreamingAssets", temp_dir+"/StreamingAssets");

		if (!CompileLuaScripts (src_res + "/Lua", temp_dir + "/Lua", true)) {
			if (!EditorUtility.DisplayDialog ("FLuaGame", "Failed to Pack All Assets", "Continue", "No")) {
				return;
			}
		}

		CopyDirectorys (temp_dir, dst_res);

		Directory.Delete (temp_dir, true);

		UnityLog.Log("Zip包自作完成,path=" + dst_res);
		AssetDatabase.Refresh();
	}
	/*	
	[MenuItem("ExportAssets/步骤2.打成一个Zip包(Lua源码)", false, 15)]
	public static void PackUnityResNoCompileLua()
	{
		string dst_res = Application.dataPath +  "/StreamingAssets/res_base/data.zip";

		string src_res = Application.dataPath + "/../../Output";

		string temp_dir = Application.dataPath + "/../../Output/temp";

		CopyDirectorys (src_res, temp_dir);

		UnZipUtil.XSharpUnZip.ZipDirectory(dst_res, temp_dir, password);

		Directory.Delete (temp_dir, true);

		UnityLog.Log("Zip包自作完成,path=" + dst_res);
		AssetDatabase.Refresh();
	}

	[MenuItem("ExportAssets/步骤2.打成一个Zip包(luac编译)", false, 16)]
	public static void PackUnityResCompileLua()
	{
		string dst_res = Application.dataPath +  "/StreamingAssets/res_base/data.zip";

		string src_res = Application.dataPath + "/../../Output";

		string temp_dir = Application.dataPath + "/../../Output/temp";

		CopyDirectorys (src_res+"/Configs", temp_dir+"/Configs");
		CopyDirectorys (src_res+"/StreamingAssets", temp_dir+"/StreamingAssets");

		if (!CompileLuaScripts (src_res + "/Lua", temp_dir + "/Lua", false)) {
			if (!EditorUtility.DisplayDialog ("FLuaGame", "Failed to Pack All Assets", "Continue", "No")) {
				return;
			}
		}


		UnZipUtil.XSharpUnZip.ZipDirectory(dst_res, temp_dir, password);

		Directory.Delete (temp_dir, true);

		UnityLog.Log("Zip包自作完成,path=" + dst_res);
		AssetDatabase.Refresh();
	}

	[MenuItem("ExportAssets/步骤2.打成一个Zip包(luajit编译)", false, 17)]
	public static void PackUnityResCompileLuaWithJit()
	{
		string dst_res = Application.dataPath +  "/StreamingAssets/res_base/data.zip";

		string src_res = Application.dataPath + "/../../Output";

		string temp_dir = Application.dataPath + "/../../Output/temp";

		CopyDirectorys (src_res+"/Configs", temp_dir+"/Configs");
		CopyDirectorys (src_res+"/StreamingAssets", temp_dir+"/StreamingAssets");

		if (!CompileLuaScripts (src_res + "/Lua", temp_dir + "/Lua", true)) {
			UnityLog.LogError ("Failed to Pack All Assets");
			if (!EditorUtility.DisplayDialog("FLuaGame", "Failed to Pack All Assets", "Continue", "No"))
			{
				return;
			}
		}

		UnZipUtil.XSharpUnZip.ZipDirectory(dst_res, temp_dir, password);

		Directory.Delete (temp_dir, true);

		UnityLog.Log("Zip包自作完成,path=" + dst_res);
		AssetDatabase.Refresh();
	}*/

	[MenuItem("Assets/BundleName/SetBundleName", false, 15)]
	public static void SetAssetBundleName()
	{
		UObject[] SelectedAsset = Selection.GetFiltered(typeof(UObject), SelectionMode.DeepAssets);
		SetAssetBundleName (SelectedAsset);
	}

	[MenuItem("Assets/BundleName/UnSetBundleName", false, 16)]
	public static void ClearAssetBundleName()
	{
		UObject[] SelectedAsset = Selection.GetFiltered(typeof(UObject), SelectionMode.DeepAssets);
		UnSetAssetBundleName (SelectedAsset);
	}

}

