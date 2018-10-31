// The MIT License (MIT)

// Copyright 2015 Siney/Pangweiwei siney@yeah.net
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
#if UNITY_EDITOR
namespace SLua
{
    using System.Collections.Generic;
    using System;
    using System.IO;

    public class CustomExport
    {
        public static void OnGetAssemblyToGenerateExtensionMethod(out List<string> list) {
            list = new List<string> {
                "Assembly-CSharp",
            };
        }

        public static void OnAddCustomClass(LuaCodeGen.ExportGenericDelegate add)
        {
            // add(typeof(System.Func<int>), null);
            // add(typeof(System.Action<int, string>), null);
            // add(typeof(System.Action<int, Dictionary<int, object>>), null);
            // add(typeof(List<int>), "ListInt");
            // add(typeof(Dictionary<int, string>), "DictIntStr");
            // add(typeof(string), "String");
            add(typeof(BinaryReader), "BinaryReader");
            add(typeof(BinaryWriter), "BinaryWriter");
            add(typeof(BestHTTP.HTTPRequest), "HTTPRequest");
            add(typeof(BestHTTP.HTTPResponse), "HTTPResponse");
            add(typeof(BestHTTP.HTTPRequestStates), "HTTPRequestStates");
			add(typeof(BackgroundMusic), "BackgroundMusic");

            // add your custom class here
            // add( type, typename)
            // type is what you want to export
            // typename used for simplify generic type name or rename, like List<int> named to "ListInt", if not a generic type keep typename as null or rename as new type name
        }

        public static void OnAddCustomMethod(ref List<Type> list)
        {
            list = new List<Type>
            {
                typeof(BinaryReader),
                typeof(BinaryWriter),
                typeof(FGame.ByteBuffer),
				typeof(FGame.NetworkManager),
            };
        }

        public static void OnAddCustomAssembly(ref List<string> list)
        {
            // add your custom assembly here
            // you can build a dll for 3rd library like ngui titled assembly name "NGUI", put it in Assets folder
            // add its name into list, SLua will generate all exported interface automatically for you

            //list.Add("NGUI");
            list.Add("FairyGUI");
        }

        public static HashSet<string> OnAddCustomNamespace()
        {
            return new HashSet<string>
            {
                //"NLuaTest.Mock"
            };
        }

        // if uselist return a white list, don't check noUseList(black list) again
        public static void OnGetUseList(out List<string> list)
        {
            list = new List<string>
            {
                //"UnityEngine.GameObject",
            };
        }

        public static List<string> FunctionFilterList = new List<string>()
        {
            "UIWidget.showHandles",
            "UIWidget.showHandlesWithMoveTool",
            "ReflectionMethodsCache.GetRayIntersectionAllCallback",
            "UnityEngine.MonoBehaviour.get_runInEditMode",
            "UnityEngine.MonoBehaviour.set_useGUILayout",
            "UnityEngine.MonoBehaviour.get_runInEditMode",
            "UnityEngine.MonoBehaviour.set_useGUILayout",
            "UnityEngine.MonoBehaviour.runInEditMode",
            "UnityEngine.MonoBehaviour.useGUILayout",
			"UnityEngine.Light.get_lightmappingMode",
			"UnityEngine.Light.set_lightmappingMode",
            "UnityEngine.QualitySettings.set_streamingMipmapsRenderersPerFrame",
            "UnityEngine.Playables.PlayableGraph.GetEditorName",
            "UnityEngine.LightProbeGroup.set_probePositions",
            "UnityEngine.Light.shadowAngle",
            "UnityEngine.Light.shadowRadius",
            "UnityEngine.DrivenRectTransformTracker.StartRecordingUndo",
            "UnityEngine.DrivenRectTransformTracker.StopRecordingUndo",
            "UnityEngine.Texture.imageContentsHash",
        };
        // black list if white list not given
        public static void OnGetNoUseList(out List<string> list)
        {
            list = new List<string>
        {      
            "HideInInspector",
            "ExecuteInEditMode",
            "AddComponentMenu",
            "ContextMenu",
            "RequireComponent",
            "DisallowMultipleComponent",
            "SerializeField",
            "AssemblyIsEditorAssembly",
            "Attribute", 
            "Types",
            "UnitySurrogateSelector",
            "TrackedReference",
            "TypeInferenceRules",
            "FFTWindow",
            "RPC",
            "Network",
            "MasterServer",
            "BitStream",
            "HostData",
            "ConnectionTesterStatus",
            "GUI",
            "EventType",
            "EventModifiers",
            "FontStyle",
            "TextAlignment",
            "TextEditor",
            "TextEditorDblClickSnapping",
            "TextGenerator",
            "TextClipping",
            "Gizmos",
             "ADBannerView",
            "ADInterstitialAd",            
            "Android",
			"Tizen",
            "jvalue",
            "iPhone",
            "iOS",
            "tvOS",
                "Windows",
                "CalendarIdentifier",
                "CalendarUnit",
                "CalendarUnit",
                "ClusterInput",
                "FullScreenMovieControlMode",
                "FullScreenMovieScalingMode",
                "Handheld",
                "LocalNotification",
                "NotificationServices",
                "RemoteNotificationType",      
                "RemoteNotification",
                "SamsungTV",
                "TextureCompressionQuality",
                "TouchScreenKeyboardType",
                "TouchScreenKeyboard",
                "MovieTexture",
                "UnityEngineInternal",
                "Terrain",                            
                "Tree",
                "SplatPrototype",
                "DetailPrototype",
                "DetailRenderMode",
                "MeshSubsetCombineUtility",
                "AOT",
                "Social",
                "Enumerator",       
                "SendMouseEvents",               
                "Cursor",
                "Flash",
                "ActionScript",
                "OnRequestRebuild",
                "Ping",
                "ShaderVariantCollection",
                "SimpleJson.Reflection",
                "CoroutineTween",
                "GraphicRebuildTracker",
                "Advertisements",
                "UnityEditor",
			    "WSA",
			    "EventProvider",
			    "Apple",
			    "ClusterInput",
				"Motion",
                "UnityEngine.UI.ReflectionMethodsCache",
				"NativeLeakDetection",
				"NativeLeakDetectionMode",
				"WWWAudioExtensions",
                "UnityEngine.Experimental",
                "PinGCObjectAndGetAddress",
                "UnsafeUtility",
                "Unity.Jobs.LowLevel.Unsafe",
                "Unity.Collections.LowLevel.Unsafe",
                 "UnityEngine.tvOS",
            };
        }

    }
}
#endif