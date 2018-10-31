#if UNITY_EDITOR
using System;
using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;
using System.Text;
using Zulong.UnityEditor.iOS.Xcode;
using Zulong.UnityEditor.iOS.Xcode.Extensions;
using ZulongXcode=Zulong.UnityEditor.iOS.Xcode;

public class CustomHotKey : MonoBehaviour
{
	[MenuItem("CustomHotKey/ToggleActivie &v")]
	public static void ToggleActive()
	{
		foreach (var obj in Selection.gameObjects)
		{
			obj.SetActive(!obj.activeSelf);
		}
	}

	[MenuItem("CustomHotKey/TogglePause &p")]
	public static void TogglePause()
	{
		EditorApplication.isPaused = !EditorApplication.isPaused;
	}

	[MenuItem("CustomHotKey/SaveProject &s")]
	public static void SaveAssets()
	{
		AssetDatabase.SaveAssets();
		Debug.Log("Project Saved.");
	}

	[MenuItem("CustomHotKey/ApplyPrefab &a")]
	public static void ApplyPrefab()
	{
		foreach (var obj in Selection.gameObjects)
		{
			var prefabParent = PrefabUtility.GetCorrespondingObjectFromSource(obj);
			if (prefabParent != null)
                PrefabUtility.ReplacePrefab(PrefabUtility.FindPrefabRoot(obj), prefabParent, ReplacePrefabOptions.ConnectToPrefab);
		}
	}

	[MenuItem("CustomHotKey/Open Containing Folder &o")]
	public static void OpenContainingFolder()
	{
#if UNITY_EDITOR_WIN
		//var path = Path.Combine(Path.Combine(Application.dataPath, ".."), AssetDatabase.GetAssetPath(Selection.activeObject));
        
		//ShowSelectedInExplorer.FilesOrFolders(path);
#else
		Debug.LogWarning("not supported on current platform");
#endif
	}

	//这里有bug
	[MenuItem("Test/Writer")]
	static void Test()
	{
		//写法2
		StreamWriter file = new StreamWriter("1.txt", false, Encoding.UTF8);
		file.WriteLine ("aaa");

		StreamWriter file2 = new StreamWriter("2.txt", false, Encoding.UTF8);
		file2.WriteLine ("bbb");
		file2.Close ();

		file.WriteLine ("ccc");
		file.Close ();

	}

	[MenuItem("Test/XUPorter")]
	static void TestXUPorter()
	{
		ZulongXcode.PBXLog.logMessageReceived += LogCallback;
		ZulongXcode.PBXLog.LogWarning ("sssssssssssssss");
	}

	public void ApplyMod(PBXMod mod)
	{
		ZulongXcode.PBXProject proj = new ZulongXcode.PBXProject ();
		string workPath = "";
		ZulongXcode.PBXLog.Log(">>>>>>Embed binaries ");
		if (mod.embed_binaries != null)
		{
			foreach (ZulongXcode.XCEmbedFile f in mod.embed_binaries)
			{
				string completePath = Path.Combine(workPath, f.filePath);
				string completeinfoPlistPath = Path.Combine(workPath, f.infoplist);
				ZulongXcode.PBXLog.Log("Adding Embed " + string.Format("{0}, bundle:{1},infoplist:{2}", completePath, f.bundle, completeinfoPlistPath));
				proj.AddAppExtension("1111", completePath, f.bundle, completeinfoPlistPath);
			}
		}
	}

	static void LogCallback (string condition, string stackTrace, ZulongXcode.PBXLogType type)
	{
		switch (type) {
		case ZulongXcode.PBXLogType.Assert:
			Debug.LogAssertion (condition);
			break;
		case ZulongXcode.PBXLogType.Exception:
			Debug.LogException (new Exception (condition));
			break;
		case ZulongXcode.PBXLogType.Error:
			Debug.LogError (condition);
			break;
		case ZulongXcode.PBXLogType.Warning:
			Debug.LogWarning (condition);
			break;
		default:
			Debug.Log (condition);
			break;
		}
	}
}
#endif