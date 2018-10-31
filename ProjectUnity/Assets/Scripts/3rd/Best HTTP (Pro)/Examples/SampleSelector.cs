/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。

插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using System;
using System.Collections.Generic;

using UnityEngine;
using BestHTTP;
using BestHTTP.Statistics;

/// <summary>
/// A class to describe an Example and store it's metadata.
/// </summary>
public sealed class SampleDescriptor
{
    public Type Type { get; set; }
    public string DisplayName { get; set; }
    public string Description { get; set; }
    public string CodeBlock { get; set; }

    public bool IsSelected { get; set; }
    public GameObject UnityObject { get; set; }
    public bool IsRunning { get { return UnityObject != null; } }

    public SampleDescriptor(Type type, string displayName, string description, string codeBlock)
    {
        this.Type = type;
        this.DisplayName = displayName;
        this.Description = description;
        this.CodeBlock = codeBlock;
    }

    public void CreateUnityObject()
    {
        if (UnityObject != null)
            return;

        UnityObject = new GameObject(DisplayName);
        UnityObject.AddComponent(Type);

#if UNITY_WEBPLAYER
        if (!string.IsNullOrEmpty(CodeBlock))
            Application.ExternalCall("ShowCodeBlock", CodeBlock);
        else
            Application.ExternalCall("HideCodeBlock");
#endif
    }

    public void DestroyUnityObject()
    {
        if (UnityObject != null)
        {
#if UNITY_WEBPLAYER
            Application.ExternalCall("HideCodeBlock");
#endif

            UnityEngine.Object.Destroy(UnityObject);
            UnityObject = null;
        }
    }
}

public class SampleSelector : MonoBehaviour
{
    public const int statisticsHeight = 160;

    List<SampleDescriptor> Samples = new List<SampleDescriptor>();
    public static SampleDescriptor SelectedSample;

    Vector2 scrollPos;

    void Awake()
    {
#if UNITY_WEBPLAYER
        // Set up a global proxy in webplayer builds to breach the Socket Policy Service restriction
        BestHTTP.HTTPManager.Proxy = new BestHTTP.HTTPProxy(new Uri("http://u3assets.cloudapp.net:8888"), null, true);
#endif

        Samples.Add(new SampleDescriptor(typeof(TextureDownloadSample), "Texture Download", "With HTTPManager.MaxConnectionPerServer you can control how many requests can be processed per server parallel.\n\nFeatures demoed in this example:\n-Parallel requests to the same server\n-Controlling the parallelization\n-Automatic Caching\n-Create a Texture2D from the downloaded data", CodeBlocks.TextureDownloadSample));
        Samples.Add(new SampleDescriptor(typeof(AssetBundleSample), "AssetBundle Download", "A small example that shows a possible way to download an AssetBundle and load a resource from it.\n\nFeatures demoed in this example:\n-Using HTTPRequest without a callback\n-Using HTTPRequest in a Coroutine\n-Loading an AssetBundle from the downloaded bytes\n-Automatic Caching", CodeBlocks.AssetBundleSample));
        Samples.Add(new SampleDescriptor(typeof(LargeFileDownloadSample), "Large File Download", "This example demonstrates how you can download a (large) file and continue the download after the connection is aborted.\n\nFeatures demoed in this example:\n-Setting up a streamed download\n-How to access the downloaded data while the download is in progress\n-Setting the HTTPRequest's StreamFragmentSize to controll the frequency and size of the fragments\n-How to use the SetRangeHeader to continue a previously disconnected download\n-How to disable the local, automatic caching", CodeBlocks.LargeFileDownloadSample));
        Samples.Add(new SampleDescriptor(typeof(WebSocketSample), "WebSocket - Echo", "A WebSocket demonstration that connects to a WebSocket echo service.\n\nFeatures demoed in this example:\n-Basic useage of the WebSocket class", CodeBlocks.WebSocketSample));
        Samples.Add(new SampleDescriptor(typeof(SocketIOChatSample), "Socket.IO - Chat", "This example uses the Socket.IO implementation to connect to the official Chat demo server(http://chat.socket.io/).\n\nFeatures demoed in this example:\n-Instantiating and setting up a SocketManager to connect to a Socket.IO server\n-Changing SocketOptions property\n-Subscribing to Socket.IO events\n-Sending custom events to the server", CodeBlocks.SocketIOChatSample));
        Samples.Add(new SampleDescriptor(typeof(SocketIOWePlaySample), "Socket.IO - WePlay", "This example uses the Socket.IO implementation to connect to the official WePlay demo server(http://weplay.io/).\n\nFeatures demoed in this example:\n-Instantiating and setting up a SocketManager to connect to a Socket.IO server\n-Subscribing to Socket.IO events\n-Receiving binary data\n-How to load a texture from the received binary data\n-How to disable payload decoding for fine tune for some speed\n-Sending custom events to the server", CodeBlocks.SocketIOWePlaySample));
        Samples.Add(new SampleDescriptor(typeof(CacheMaintenanceSample), "Cache Maintenance", "With this demo you can see how you can use the HTTPCacheService's BeginMaintainence function to delete too old cached entities and keep the cache size under a specified value.\n\nFeatures demoed in this example:\n-How to set up a HTTPCacheMaintananceParams\n-How to call the BeginMaintainence function", CodeBlocks.CacheMaintenanceSample));

        SelectedSample = Samples[0];
    }

    void Start()
    {
        GUIHelper.ClientArea = new Rect(0, SampleSelector.statisticsHeight + 5, Screen.width, Screen.height - SampleSelector.statisticsHeight - 50);
    }

    void OnGUI()
    {
        var stats = HTTPManager.GetGeneralStatistics(StatisticsQueryFlags.All);

        // Connection statistics
        GUIHelper.DrawArea(new Rect(0, 0, Screen.width / 3, statisticsHeight), false, () =>
            {
                // Header
                GUIHelper.DrawCenteredText("Connections");

                GUILayout.Space(5);

                //GUIHelper.DrawRow("Sum Connections:", stats.Connections.ToString());
                GUIHelper.DrawRow("Active Connections:", stats.ActiveConnections.ToString());
                GUIHelper.DrawRow("Free Connections:", stats.FreeConnections.ToString());
                GUIHelper.DrawRow("Recycled Connections:", stats.RecycledConnections.ToString());
                GUIHelper.DrawRow("Requests in queue:", stats.RequestsInQueue.ToString());
            });

        // Cache statistics
        GUIHelper.DrawArea(new Rect(Screen.width / 3, 0, Screen.width / 3, statisticsHeight), false, () =>
            {
                GUIHelper.DrawCenteredText("Cache");
#if UNITY_WEBPLAYER
                GUI.color = Color.yellow;
                GUIHelper.DrawCenteredText("Disabled in WebPlayer Builds!");
                GUI.color = Color.white;
#endif

                GUILayout.Space(5);

                GUIHelper.DrawRow("Cached entities:", stats.CacheEntityCount.ToString());
                GUIHelper.DrawRow("Sum Size (bytes): ", stats.CacheSize.ToString("N0"));

                GUILayout.BeginVertical();

                GUILayout.FlexibleSpace();
                if (GUILayout.Button("Clear Cache"))
                    BestHTTP.Caching.HTTPCacheService.BeginClear();

                GUILayout.EndVertical();
            });

        // Cookie statistics
        GUIHelper.DrawArea(new Rect((Screen.width / 3) * 2, 0, Screen.width / 3, statisticsHeight), false, () =>
            {
                GUIHelper.DrawCenteredText("Cookies");
#if UNITY_WEBPLAYER
                GUI.color = Color.yellow;
                GUIHelper.DrawCenteredText("Saving and loading from disk is disabled in WebPlayer Builds!");
                GUI.color = Color.white;
#endif

                GUILayout.Space(5);

                GUIHelper.DrawRow("Cookies:", stats.CookieCount.ToString());
                GUIHelper.DrawRow("Estimated size (bytes):", stats.CookieJarSize.ToString("N0"));

                GUILayout.BeginVertical();

                GUILayout.FlexibleSpace();
                if (GUILayout.Button("Clear Cookies"))
                    BestHTTP.Cookies.CookieJar.Clear();

                GUILayout.EndVertical();
            });

        if (SelectedSample == null || (SelectedSample != null && !SelectedSample.IsRunning))
        {
            // Draw the list of samples
            GUIHelper.DrawArea(new Rect(0, statisticsHeight + 5, SelectedSample == null ? Screen.width : Screen.width / 3, Screen.height - statisticsHeight - 5), false, () =>
                {
                    scrollPos = GUILayout.BeginScrollView(scrollPos);
                    for (int i = 0; i < Samples.Count; ++i)
                        DrawSample(Samples[i]);
                    GUILayout.EndScrollView();
                });

            if (SelectedSample != null)
                DrawSampleDetails(SelectedSample);
        }
        else if (SelectedSample != null && SelectedSample.IsRunning)
        {
            GUILayout.BeginArea(new Rect(0, Screen.height - 50, Screen.width, 50), string.Empty);
                GUILayout.FlexibleSpace();
                GUILayout.BeginHorizontal();
                    GUILayout.FlexibleSpace();

                    GUILayout.BeginVertical();
                    GUILayout.FlexibleSpace();
                    if (GUILayout.Button("Back", GUILayout.MinWidth(100)))
                        SelectedSample.DestroyUnityObject();
                    GUILayout.FlexibleSpace();
                    GUILayout.EndVertical();
                    
                GUILayout.EndHorizontal();
            GUILayout.EndArea();
        }
    }

    private void DrawSample(SampleDescriptor sample)
    {
        if (GUILayout.Button(sample.DisplayName))
        {
            sample.IsSelected = true;

            if (SelectedSample != null)
                SelectedSample.IsSelected = false;

            SelectedSample = sample;
        }
    }

    private void DrawSampleDetails(SampleDescriptor sample)
    {
        Rect area = new Rect(Screen.width / 3, statisticsHeight + 5, (Screen.width / 3) * 2, Screen.height - statisticsHeight - 5);
        GUI.Box(area, string.Empty);

        GUILayout.BeginArea(area);
            GUILayout.BeginVertical();
                GUIHelper.DrawCenteredText(sample.DisplayName);
                GUILayout.Space(5);
                GUILayout.Label(sample.Description);
                GUILayout.FlexibleSpace();

                if (GUILayout.Button("Start"))
                    sample.CreateUnityObject();

            GUILayout.EndVertical();
        GUILayout.EndArea();
    }
}
