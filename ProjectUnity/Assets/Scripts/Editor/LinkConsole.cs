#if UNITY_EDITOR	
namespace SLua
{
	using UnityEngine;
	using System.Collections;
	using System.Collections.Generic;
	using System.IO;
	using System;
	using System.Reflection;
	using UnityEditor;
	using System.Text;
	using System.Text.RegularExpressions;

	public class ConnectDebugger : EditorWindow
	{
		string addr = "localhost:10240";
		static ConnectDebugger wnd;
		[MenuItem("SLua/Console")]
		static void Init()
		{
			if (wnd == null)
				wnd = (ConnectDebugger)EditorWindow.GetWindow(typeof(ConnectDebugger), true, "Connect debugger");
			wnd.position = new Rect(Screen.width / 2, Screen.height / 2, 500, 50);
			wnd.Show();
		}


		void OnGUI()
		{
			addr = EditorGUILayout.TextField("Debugger IP:", addr);
			if (GUILayout.Button("Connect", GUILayout.ExpandHeight(true)))
			{
				try
				{
					string ip = "localhost";
					int port = 10240;
					string[] comp = addr.Split(':');

					ip = comp[0];
					if (comp.Length > 0)
						port = Convert.ToInt32(comp[1]);

                    string debuggerPath = Application.dataPath + "/../../tools/";
#if UNITY_EDITOR_WIN
					System.Diagnostics.Process.Start(debuggerPath + "debugger\\win\\ldb.exe", string.Format("-host {0} -port {1}", ip, port));
#else
					System.Diagnostics.ProcessStartInfo proc = new System.Diagnostics.ProcessStartInfo();
					proc.FileName = "bash";
					proc.WorkingDirectory = debuggerPath + "debugger/mac";
					proc.Arguments =  @"-c ""./runldb.sh {0} {1} """;
					proc.Arguments = string.Format(proc.Arguments,ip,port);
					proc.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
					proc.CreateNoWindow = false;
					proc.UseShellExecute = true;
					System.Diagnostics.Process.Start(proc);
#endif
                }
                catch (Exception e)
				{
					Debug.LogError(e);
				}

			}
		}

	}
}
#endif