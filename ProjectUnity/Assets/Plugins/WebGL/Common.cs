#if UNITY_WEBGL && !UNITY_EDITOR
using UnityEngine;
using System.Runtime.InteropServices;

public class WebCommon
{
	[DllImport("__Internal")]
	public static extern void logToWeb(string str);
}

#endif