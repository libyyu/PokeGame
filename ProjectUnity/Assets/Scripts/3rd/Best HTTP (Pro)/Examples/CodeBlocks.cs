/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。

插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using System;

public static class CodeBlocks
{
    #region TextureDownloadSample
    public static string TextureDownloadSample = @"<pre style=""font-family:Consolas;font-size:13;color:black;background:silver;""><span style=""color:blue;"">using</span>&nbsp;System;
<span style=""color:blue;"">using</span>&nbsp;System.Collections.Generic;
 
<span style=""color:blue;"">using</span>&nbsp;UnityEngine;
<span style=""color:blue;"">using</span>&nbsp;BestHTTP;
 
<span style=""color:blue;"">public</span>&nbsp;<span style=""color:blue;"">sealed</span>&nbsp;<span style=""color:blue;"">class</span>&nbsp;<span style=""color:#2b91af;"">TextureDownloadSample</span>&nbsp;:&nbsp;<span style=""color:#2b91af;"">MonoBehaviour</span>
{
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;The&nbsp;URL&nbsp;of&nbsp;the&nbsp;server&nbsp;that&nbsp;will&nbsp;serve&nbsp;the&nbsp;image&nbsp;resources</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">const</span>&nbsp;<span style=""color:blue;"">string</span>&nbsp;BaseURL&nbsp;=&nbsp;<span style=""color:#a31515;"">&quot;http://besthttp.azurewebsites.net/Content/&quot;</span>;
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#region</span>&nbsp;Private&nbsp;Fields
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;The&nbsp;downloadable&nbsp;images</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">string</span>[]&nbsp;Images&nbsp;=&nbsp;<span style=""color:blue;"">new</span>&nbsp;<span style=""color:blue;"">string</span>[9]&nbsp;{&nbsp;<span style=""color:#a31515;"">&quot;One.png&quot;</span>,&nbsp;<span style=""color:#a31515;"">&quot;Two.png&quot;</span>,&nbsp;<span style=""color:#a31515;"">&quot;Three.png&quot;</span>,&nbsp;<span style=""color:#a31515;"">&quot;Four.png&quot;</span>,&nbsp;<span style=""color:#a31515;"">&quot;Five.png&quot;</span>,&nbsp;<span style=""color:#a31515;"">&quot;Six.png&quot;</span>,&nbsp;<span style=""color:#a31515;"">&quot;Seven.png&quot;</span>,&nbsp;<span style=""color:#a31515;"">&quot;Eight.png&quot;</span>,&nbsp;<span style=""color:#a31515;"">&quot;Nine.png&quot;</span>&nbsp;};
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;The&nbsp;downloaded&nbsp;images&nbsp;will&nbsp;be&nbsp;stored&nbsp;as&nbsp;textures&nbsp;in&nbsp;this&nbsp;array</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">Texture2D</span>[]&nbsp;Textures&nbsp;=&nbsp;<span style=""color:blue;"">new</span>&nbsp;<span style=""color:#2b91af;"">Texture2D</span>[9];
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;True&nbsp;if&nbsp;all&nbsp;images&nbsp;are&nbsp;loaded&nbsp;from&nbsp;the&nbsp;local&nbsp;cache&nbsp;instead&nbsp;of&nbsp;the&nbsp;server</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">bool</span>&nbsp;allDownloadedFromLocalCache;
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;How&nbsp;many&nbsp;sent&nbsp;requests&nbsp;are&nbsp;finished</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">int</span>&nbsp;finishedCount;
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;GUI&nbsp;scroll&nbsp;position</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">Vector2</span>&nbsp;scrollPos;
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#endregion</span>
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#region</span>&nbsp;Unity&nbsp;Events
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;Awake()
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Set&nbsp;a&nbsp;well&nbsp;observable&nbsp;value</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;This&nbsp;is&nbsp;how&nbsp;many&nbsp;concurrent&nbsp;requests&nbsp;can&nbsp;be&nbsp;made&nbsp;to&nbsp;a&nbsp;server</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">HTTPManager</span>.MaxConnectionPerServer&nbsp;=&nbsp;1;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Create&nbsp;placeholder&nbsp;textures</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">for</span>&nbsp;(<span style=""color:blue;"">int</span>&nbsp;i&nbsp;=&nbsp;0;&nbsp;i&nbsp;&lt;&nbsp;Images.Length;&nbsp;++i)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Textures[i]&nbsp;=&nbsp;<span style=""color:blue;"">new</span>&nbsp;<span style=""color:#2b91af;"">Texture2D</span>(100,&nbsp;150);
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;OnDestroy()
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Set&nbsp;back&nbsp;to&nbsp;its&nbsp;defualt&nbsp;value.</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">HTTPManager</span>.MaxConnectionPerServer&nbsp;=&nbsp;4;
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;OnGUI()
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUIHelper</span>.DrawArea(<span style=""color:#2b91af;"">GUIHelper</span>.ClientArea,&nbsp;<span style=""color:blue;"">true</span>,&nbsp;()&nbsp;=&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;scrollPos&nbsp;=&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.BeginScrollView(scrollPos);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Draw&nbsp;out&nbsp;the&nbsp;textures</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.SelectionGrid(0,&nbsp;Textures,&nbsp;3);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(finishedCount&nbsp;==&nbsp;Images.Length&nbsp;&amp;&amp;&nbsp;allDownloadedFromLocalCache)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUIHelper</span>.DrawCenteredText(<span style=""color:#a31515;"">&quot;All&nbsp;images&nbsp;loaded&nbsp;from&nbsp;the&nbsp;local&nbsp;cache!&quot;</span>);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.FlexibleSpace();
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.BeginHorizontal();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.Label(<span style=""color:#a31515;"">&quot;Max&nbsp;Connection/Server:&nbsp;&quot;</span>,&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.Width(150));
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.Label(<span style=""color:#2b91af;"">HTTPManager</span>.MaxConnectionPerServer.ToString(),&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.Width(20));
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">HTTPManager</span>.MaxConnectionPerServer&nbsp;=&nbsp;(<span style=""color:blue;"">byte</span>)<span style=""color:#2b91af;"">GUILayout</span>.HorizontalSlider(<span style=""color:#2b91af;"">HTTPManager</span>.MaxConnectionPerServer,&nbsp;1,&nbsp;10);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.EndHorizontal();
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(<span style=""color:#2b91af;"">GUILayout</span>.Button(<span style=""color:#a31515;"">&quot;Start&nbsp;Download&quot;</span>))
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;DownloadImages();
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.EndScrollView();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;});
&nbsp;&nbsp;&nbsp;&nbsp;}
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#endregion</span>
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#region</span>&nbsp;Private&nbsp;Helper&nbsp;Functions
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;DownloadImages()
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Set&nbsp;these&nbsp;metadatas&nbsp;to&nbsp;its&nbsp;initial&nbsp;values</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;allDownloadedFromLocalCache&nbsp;=&nbsp;<span style=""color:blue;"">true</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;finishedCount&nbsp;=&nbsp;0;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">for</span>&nbsp;(<span style=""color:blue;"">int</span>&nbsp;i&nbsp;=&nbsp;0;&nbsp;i&nbsp;&lt;&nbsp;Images.Length;&nbsp;++i)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Set&nbsp;a&nbsp;blank&nbsp;placeholder&nbsp;texture,&nbsp;overriding&nbsp;previously&nbsp;downloaded&nbsp;texture</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Textures[i]&nbsp;=&nbsp;<span style=""color:blue;"">new</span>&nbsp;<span style=""color:#2b91af;"">Texture2D</span>(100,&nbsp;150);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Construct&nbsp;the&nbsp;request</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">var</span>&nbsp;request&nbsp;=&nbsp;<span style=""color:blue;"">new</span>&nbsp;<span style=""color:#2b91af;"">HTTPRequest</span>(<span style=""color:blue;"">new</span>&nbsp;<span style=""color:#2b91af;"">Uri</span>(BaseURL&nbsp;+&nbsp;Images[i]),&nbsp;ImageDownloaded);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Set&nbsp;the&nbsp;Tag&nbsp;property,&nbsp;we&nbsp;can&nbsp;use&nbsp;it&nbsp;as&nbsp;a&nbsp;general&nbsp;storage&nbsp;bound&nbsp;to&nbsp;the&nbsp;request</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;request.Tag&nbsp;=&nbsp;Textures[i];
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Send&nbsp;out&nbsp;the&nbsp;request</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;request.Send();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;Callback&nbsp;function&nbsp;of&nbsp;the&nbsp;image&nbsp;download&nbsp;http&nbsp;requests</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;ImageDownloaded(<span style=""color:#2b91af;"">HTTPRequest</span>&nbsp;req,&nbsp;<span style=""color:#2b91af;"">HTTPResponse</span>&nbsp;resp)
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Increase&nbsp;the&nbsp;finished&nbsp;count&nbsp;regardless&nbsp;of&nbsp;the&nbsp;state&nbsp;of&nbsp;our&nbsp;request</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;finishedCount++;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">switch</span>&nbsp;(req.State)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;The&nbsp;request&nbsp;finished&nbsp;without&nbsp;any&nbsp;problem.</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">case</span>&nbsp;<span style=""color:#2b91af;"">HTTPRequestStates</span>.Finished:
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(resp.IsSuccess)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Get&nbsp;the&nbsp;Texture&nbsp;from&nbsp;the&nbsp;Tag&nbsp;property</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">Texture2D</span>&nbsp;tex&nbsp;=&nbsp;req.Tag&nbsp;<span style=""color:blue;"">as</span>&nbsp;<span style=""color:#2b91af;"">Texture2D</span>;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Load&nbsp;the&nbsp;texture</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;tex.LoadImage(resp.Data);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Update&nbsp;the&nbsp;cache-info&nbsp;variable</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;allDownloadedFromLocalCache&nbsp;=&nbsp;allDownloadedFromLocalCache&nbsp;&amp;&amp;&nbsp;resp.IsFromCache;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">else</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">Debug</span>.LogWarning(<span style=""color:blue;"">string</span>.Format(<span style=""color:#a31515;"">&quot;Request&nbsp;finished&nbsp;Successfully,&nbsp;but&nbsp;the&nbsp;server&nbsp;sent&nbsp;an&nbsp;error.&nbsp;Status&nbsp;Code:&nbsp;{0}-{1}&nbsp;Message:&nbsp;{2}&quot;</span>,
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;resp.StatusCode,
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;resp.Message,
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;resp.DataAsText));
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">break</span>;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;The&nbsp;request&nbsp;finished&nbsp;with&nbsp;an&nbsp;unexpected&nbsp;error.&nbsp;The&nbsp;request&#39;s&nbsp;Exception&nbsp;property&nbsp;may&nbsp;contain&nbsp;more&nbsp;info&nbsp;about&nbsp;the&nbsp;error.</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">case</span>&nbsp;<span style=""color:#2b91af;"">HTTPRequestStates</span>.Error:
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">Debug</span>.LogError(<span style=""color:#a31515;"">&quot;Request&nbsp;Finished&nbsp;with&nbsp;Error!&nbsp;&quot;</span>&nbsp;+&nbsp;(req.Exception&nbsp;!=&nbsp;<span style=""color:blue;"">null</span>&nbsp;?&nbsp;(req.Exception.Message&nbsp;+&nbsp;<span style=""color:#a31515;"">&quot;\n&quot;</span>&nbsp;+&nbsp;req.Exception.StackTrace)&nbsp;:&nbsp;<span style=""color:#a31515;"">&quot;No&nbsp;Exception&quot;</span>));
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">break</span>;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;The&nbsp;request&nbsp;aborted,&nbsp;initiated&nbsp;by&nbsp;the&nbsp;user.</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">case</span>&nbsp;<span style=""color:#2b91af;"">HTTPRequestStates</span>.Aborted:
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">Debug</span>.LogWarning(<span style=""color:#a31515;"">&quot;Request&nbsp;Aborted!&quot;</span>);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">break</span>;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Ceonnecting&nbsp;to&nbsp;the&nbsp;server&nbsp;is&nbsp;timed&nbsp;out.</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">case</span>&nbsp;<span style=""color:#2b91af;"">HTTPRequestStates</span>.ConnectionTimedOut:
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">Debug</span>.LogError(<span style=""color:#a31515;"">&quot;Connection&nbsp;Timed&nbsp;Out!&quot;</span>);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">break</span>;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;The&nbsp;request&nbsp;didn&#39;t&nbsp;finished&nbsp;in&nbsp;the&nbsp;given&nbsp;time.</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">case</span>&nbsp;<span style=""color:#2b91af;"">HTTPRequestStates</span>.TimedOut:
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">Debug</span>.LogError(<span style=""color:#a31515;"">&quot;Processing&nbsp;the&nbsp;request&nbsp;Timed&nbsp;Out!&quot;</span>);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">break</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}
&nbsp;&nbsp;&nbsp;&nbsp;}
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#endregion</span>
}</pre>";
    #endregion

    #region WebSocketSample
    public static string WebSocketSample = @"<pre style=""font-family:Consolas;font-size:13;color:black;background:silver;""><span style=""color:blue;"">using</span>&nbsp;System;
<span style=""color:blue;"">using</span>&nbsp;UnityEngine;
<span style=""color:blue;"">using</span>&nbsp;BestHTTP;
<span style=""color:blue;"">using</span>&nbsp;BestHTTP.WebSocket;
 
<span style=""color:blue;"">public</span>&nbsp;<span style=""color:blue;"">class</span>&nbsp;<span style=""color:#2b91af;"">WebSocketSample</span>&nbsp;:&nbsp;<span style=""color:#2b91af;"">MonoBehaviour</span>
{
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#region</span>&nbsp;Private&nbsp;Fields
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;The&nbsp;WebSocket&nbsp;address&nbsp;to&nbsp;connect</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">string</span>&nbsp;address&nbsp;=&nbsp;<span style=""color:#a31515;"">&quot;ws://echo.websocket.org&quot;</span>;
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;Default&nbsp;text&nbsp;to&nbsp;send</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">string</span>&nbsp;msgToSend&nbsp;=&nbsp;<span style=""color:#a31515;"">&quot;Hello&nbsp;World!&quot;</span>;
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;Debug&nbsp;text&nbsp;to&nbsp;draw&nbsp;on&nbsp;the&nbsp;gui</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">string</span>&nbsp;Text&nbsp;=&nbsp;<span style=""color:blue;"">string</span>.Empty;
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;Saved&nbsp;WebSocket&nbsp;instance</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">WebSocket</span>&nbsp;webSocket;
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;GUI&nbsp;scroll&nbsp;position</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">Vector2</span>&nbsp;scrollPos;
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#endregion</span>
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#region</span>&nbsp;Unity&nbsp;Events
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;OnDestroy()
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(webSocket&nbsp;!=&nbsp;<span style=""color:blue;"">null</span>)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;webSocket.Close();
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;OnGUI()
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUIHelper</span>.DrawArea(<span style=""color:#2b91af;"">GUIHelper</span>.ClientArea,&nbsp;<span style=""color:blue;"">true</span>,&nbsp;()&nbsp;=&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;scrollPos&nbsp;=&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.BeginScrollView(scrollPos);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.Label(Text);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.EndScrollView();
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.Space(5);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.FlexibleSpace();
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;address&nbsp;=&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.TextField(address);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(webSocket&nbsp;==&nbsp;<span style=""color:blue;"">null</span>&nbsp;&amp;&amp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.Button(<span style=""color:#a31515;"">&quot;Open&nbsp;Web&nbsp;Socket&quot;</span>))
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Create&nbsp;the&nbsp;WebSocket&nbsp;instance</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;webSocket&nbsp;=&nbsp;<span style=""color:blue;"">new</span>&nbsp;<span style=""color:#2b91af;"">WebSocket</span>(<span style=""color:blue;"">new</span>&nbsp;<span style=""color:#2b91af;"">Uri</span>(address));
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(<span style=""color:#2b91af;"">HTTPManager</span>.Proxy&nbsp;!=&nbsp;<span style=""color:blue;"">null</span>)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;webSocket.InternalRequest.Proxy&nbsp;=&nbsp;<span style=""color:blue;"">new</span>&nbsp;<span style=""color:#2b91af;"">HTTPProxy</span>(<span style=""color:#2b91af;"">HTTPManager</span>.Proxy.Address,&nbsp;<span style=""color:#2b91af;"">HTTPManager</span>.Proxy.Credentials,&nbsp;<span style=""color:blue;"">false</span>);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Subscribe&nbsp;to&nbsp;the&nbsp;WS&nbsp;events</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;webSocket.OnOpen&nbsp;+=&nbsp;OnOpen;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;webSocket.OnMessage&nbsp;+=&nbsp;OnMessageReceived;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;webSocket.OnClosed&nbsp;+=&nbsp;OnClosed;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;webSocket.OnError&nbsp;+=&nbsp;OnError;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Start&nbsp;connecting&nbsp;to&nbsp;the&nbsp;server</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;webSocket.Open();
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Text&nbsp;+=&nbsp;<span style=""color:#a31515;"">&quot;Opening&nbsp;Web&nbsp;Socket...\n&quot;</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(webSocket&nbsp;!=&nbsp;<span style=""color:blue;"">null</span>&nbsp;&amp;&amp;&nbsp;webSocket.IsOpen)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.Space(10);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.BeginHorizontal();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;msgToSend&nbsp;=&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.TextField(msgToSend);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(<span style=""color:#2b91af;"">GUILayout</span>.Button(<span style=""color:#a31515;"">&quot;Send&quot;</span>,&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.MaxWidth(70)))
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Text&nbsp;+=&nbsp;<span style=""color:#a31515;"">&quot;Sending&nbsp;message...\n&quot;</span>;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Send&nbsp;message&nbsp;to&nbsp;the&nbsp;server</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;webSocket.Send(msgToSend);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.EndHorizontal();
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.Space(10);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(<span style=""color:#2b91af;"">GUILayout</span>.Button(<span style=""color:#a31515;"">&quot;Close&quot;</span>))
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Close&nbsp;the&nbsp;connection</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;webSocket.Close(1000,&nbsp;<span style=""color:#a31515;"">&quot;Bye!&quot;</span>);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;});
&nbsp;&nbsp;&nbsp;&nbsp;}
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#endregion</span>
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#region</span>&nbsp;WebSocket&nbsp;Event&nbsp;Handlers
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;Called&nbsp;when&nbsp;the&nbsp;web&nbsp;socket&nbsp;is&nbsp;open,&nbsp;and&nbsp;we&nbsp;are&nbsp;ready&nbsp;to&nbsp;send&nbsp;and&nbsp;receive&nbsp;data</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;OnOpen(<span style=""color:#2b91af;"">WebSocket</span>&nbsp;ws)
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Text&nbsp;+=&nbsp;<span style=""color:blue;"">string</span>.Format(<span style=""color:#a31515;"">&quot;-WebSocket&nbsp;Open!\n&quot;</span>);
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;Called&nbsp;when&nbsp;we&nbsp;received&nbsp;a&nbsp;text&nbsp;message&nbsp;from&nbsp;the&nbsp;server</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;OnMessageReceived(<span style=""color:#2b91af;"">WebSocket</span>&nbsp;ws,&nbsp;<span style=""color:blue;"">string</span>&nbsp;message)
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Text&nbsp;+=&nbsp;<span style=""color:blue;"">string</span>.Format(<span style=""color:#a31515;"">&quot;-Message&nbsp;received:&nbsp;{0}\n&quot;</span>,&nbsp;message);
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;Called&nbsp;when&nbsp;the&nbsp;web&nbsp;socket&nbsp;closed</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;OnClosed(<span style=""color:#2b91af;"">WebSocket</span>&nbsp;ws,&nbsp;<span style=""color:#2b91af;"">UInt16</span>&nbsp;code,&nbsp;<span style=""color:blue;"">string</span>&nbsp;message)
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Text&nbsp;+=&nbsp;<span style=""color:blue;"">string</span>.Format(<span style=""color:#a31515;"">&quot;-WebSocket&nbsp;closed!&nbsp;Code:&nbsp;{0}&nbsp;Message:&nbsp;{1}\n&quot;</span>,&nbsp;code,&nbsp;message);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;webSocket&nbsp;=&nbsp;<span style=""color:blue;"">null</span>;
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;Called&nbsp;when&nbsp;an&nbsp;error&nbsp;occured&nbsp;on&nbsp;client&nbsp;side</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;OnError(<span style=""color:#2b91af;"">WebSocket</span>&nbsp;ws,&nbsp;<span style=""color:#2b91af;"">Exception</span>&nbsp;ex)
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">string</span>&nbsp;errorMsg&nbsp;=&nbsp;<span style=""color:blue;"">string</span>.Empty;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(ws.InternalRequest.Response&nbsp;!=&nbsp;<span style=""color:blue;"">null</span>)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;errorMsg&nbsp;=&nbsp;<span style=""color:blue;"">string</span>.Format(<span style=""color:#a31515;"">&quot;Status&nbsp;Code&nbsp;from&nbsp;Server:&nbsp;{0}&nbsp;and&nbsp;Message:&nbsp;{1}&quot;</span>,&nbsp;ws.InternalRequest.Response.StatusCode,&nbsp;ws.InternalRequest.Response.Message);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Text&nbsp;+=&nbsp;<span style=""color:blue;"">string</span>.Format(<span style=""color:#a31515;"">&quot;-An&nbsp;error&nbsp;occured:&nbsp;{0}\n&quot;</span>,&nbsp;(ex&nbsp;!=&nbsp;<span style=""color:blue;"">null</span>&nbsp;?&nbsp;ex.Message&nbsp;:&nbsp;<span style=""color:#a31515;"">&quot;Unknown&nbsp;Error&nbsp;&quot;</span>&nbsp;+&nbsp;errorMsg));
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;webSocket&nbsp;=&nbsp;<span style=""color:blue;"">null</span>;
&nbsp;&nbsp;&nbsp;&nbsp;}
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#endregion</span>
}</pre>";
    #endregion

    #region AssetBundleSample
    public static string AssetBundleSample = @"<pre style=""font-family:Consolas;font-size:13;color:black;background:silver;""><span style=""color:blue;"">using</span>&nbsp;System;
<span style=""color:blue;"">using</span>&nbsp;System.Collections;
<span style=""color:blue;"">using</span>&nbsp;System.Collections.Generic;
 
<span style=""color:blue;"">using</span>&nbsp;UnityEngine;
<span style=""color:blue;"">using</span>&nbsp;BestHTTP;
 
<span style=""color:blue;"">public</span>&nbsp;<span style=""color:blue;"">sealed</span>&nbsp;<span style=""color:blue;"">class</span>&nbsp;<span style=""color:#2b91af;"">AssetBundleSample</span>&nbsp;:&nbsp;<span style=""color:#2b91af;"">MonoBehaviour</span>
{
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;The&nbsp;url&nbsp;of&nbsp;the&nbsp;resource&nbsp;to&nbsp;download</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">const</span>&nbsp;<span style=""color:blue;"">string</span>&nbsp;URL&nbsp;=&nbsp;<span style=""color:#a31515;"">&quot;http://besthttp.azurewebsites.net/Content/AssetBundle.html&quot;</span>;
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#region</span>&nbsp;Private&nbsp;Fields
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;Debug&nbsp;status&nbsp;text</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">string</span>&nbsp;status&nbsp;=&nbsp;<span style=""color:#a31515;"">&quot;Waiting&nbsp;for&nbsp;user&nbsp;interaction&quot;</span>;
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;The&nbsp;downloaded&nbsp;and&nbsp;cached&nbsp;AssetBundle</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">AssetBundle</span>&nbsp;cachedBundle;
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;The&nbsp;loaded&nbsp;texture&nbsp;from&nbsp;the&nbsp;AssetBundle</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">Texture2D</span>&nbsp;texture;
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;A&nbsp;flag&nbsp;that&nbsp;indicates&nbsp;that&nbsp;we&nbsp;are&nbsp;processing&nbsp;the&nbsp;request/bundle&nbsp;to&nbsp;hide&nbsp;the&nbsp;&quot;Start&nbsp;Download&quot;&nbsp;button.</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">bool</span>&nbsp;downloading;
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#endregion</span>
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#region</span>&nbsp;Unity&nbsp;Events
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;OnGUI()
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUIHelper</span>.DrawArea(<span style=""color:#2b91af;"">GUIHelper</span>.ClientArea,&nbsp;<span style=""color:blue;"">true</span>,&nbsp;()&nbsp;=&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.Label(<span style=""color:#a31515;"">&quot;Status:&nbsp;&quot;</span>&nbsp;+&nbsp;status);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Draw&nbsp;the&nbsp;texture&nbsp;from&nbsp;the&nbsp;downloaded&nbsp;bundle</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(texture&nbsp;!=&nbsp;<span style=""color:blue;"">null</span>)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.Box(texture,&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.MaxHeight(256));
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(!downloading&nbsp;&amp;&amp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.Button(<span style=""color:#a31515;"">&quot;Start&nbsp;Download&quot;</span>))
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;UnloadBundle();
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;StartCoroutine(DownloadAssetBundle());
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;});
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;OnDestroy()
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;UnloadBundle();
&nbsp;&nbsp;&nbsp;&nbsp;}
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#endregion</span>
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#region</span>&nbsp;Private&nbsp;Helper&nbsp;Functions
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">IEnumerator</span>&nbsp;DownloadAssetBundle()
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;downloading&nbsp;=&nbsp;<span style=""color:blue;"">true</span>;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Create&nbsp;and&nbsp;send&nbsp;our&nbsp;request</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">var</span>&nbsp;request&nbsp;=&nbsp;<span style=""color:blue;"">new</span>&nbsp;<span style=""color:#2b91af;"">HTTPRequest</span>(<span style=""color:blue;"">new</span>&nbsp;<span style=""color:#2b91af;"">Uri</span>(URL)).Send();
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;status&nbsp;=&nbsp;<span style=""color:#a31515;"">&quot;Download&nbsp;started&quot;</span>;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Wait&nbsp;while&nbsp;it&#39;s&nbsp;finishes&nbsp;and&nbsp;add&nbsp;some&nbsp;fancy&nbsp;dots&nbsp;to&nbsp;display&nbsp;something&nbsp;while&nbsp;the&nbsp;user&nbsp;waits&nbsp;for&nbsp;it.</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;A&nbsp;simple&nbsp;&quot;yield&nbsp;return&nbsp;StartCoroutine(request);&quot;&nbsp;would&nbsp;do&nbsp;the&nbsp;job&nbsp;too.</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">while</span>(request.State&nbsp;&lt;&nbsp;<span style=""color:#2b91af;"">HTTPRequestStates</span>.Finished)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">yield</span>&nbsp;<span style=""color:blue;"">return</span>&nbsp;<span style=""color:blue;"">new</span>&nbsp;<span style=""color:#2b91af;"">WaitForSeconds</span>(0.1f);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;status&nbsp;+=&nbsp;<span style=""color:#a31515;"">&quot;.&quot;</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Check&nbsp;the&nbsp;outcome&nbsp;of&nbsp;our&nbsp;request.</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">switch</span>&nbsp;(request.State)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;The&nbsp;request&nbsp;finished&nbsp;without&nbsp;any&nbsp;problem.</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">case</span>&nbsp;<span style=""color:#2b91af;"">HTTPRequestStates</span>.Finished:
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(request.Response.IsSuccess)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;status&nbsp;=&nbsp;<span style=""color:blue;"">string</span>.Format(<span style=""color:#a31515;"">&quot;AssetBundle&nbsp;downloaded!&nbsp;Loaded&nbsp;from&nbsp;local&nbsp;cache:&nbsp;{0}&quot;</span>,&nbsp;request.Response.IsFromCache.ToString());
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Start&nbsp;creating&nbsp;the&nbsp;downloaded&nbsp;asset&nbsp;bundle</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">AssetBundleCreateRequest</span>&nbsp;async&nbsp;=&nbsp;<span style=""color:#2b91af;"">AssetBundle</span>.CreateFromMemory(request.Response.Data);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;wait&nbsp;for&nbsp;it</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">yield</span>&nbsp;<span style=""color:blue;"">return</span>&nbsp;async;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;And&nbsp;process&nbsp;the&nbsp;bundle</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">yield</span>&nbsp;<span style=""color:blue;"">return</span>&nbsp;StartCoroutine(ProcessAssetBundle(async.assetBundle));
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">else</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;status&nbsp;=&nbsp;<span style=""color:blue;"">string</span>.Format(<span style=""color:#a31515;"">&quot;Request&nbsp;finished&nbsp;Successfully,&nbsp;but&nbsp;the&nbsp;server&nbsp;sent&nbsp;an&nbsp;error.&nbsp;Status&nbsp;Code:&nbsp;{0}-{1}&nbsp;Message:&nbsp;{2}&quot;</span>,
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;request.Response.StatusCode,
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;request.Response.Message,
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;request.Response.DataAsText);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">Debug</span>.LogWarning(status);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">break</span>;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;The&nbsp;request&nbsp;finished&nbsp;with&nbsp;an&nbsp;unexpected&nbsp;error.&nbsp;The&nbsp;request&#39;s&nbsp;Exception&nbsp;property&nbsp;may&nbsp;contain&nbsp;more&nbsp;info&nbsp;about&nbsp;the&nbsp;error.</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">case</span>&nbsp;<span style=""color:#2b91af;"">HTTPRequestStates</span>.Error:
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;status&nbsp;=&nbsp;<span style=""color:#a31515;"">&quot;Request&nbsp;Finished&nbsp;with&nbsp;Error!&nbsp;&quot;</span>&nbsp;+&nbsp;(request.Exception&nbsp;!=&nbsp;<span style=""color:blue;"">null</span>&nbsp;?&nbsp;(request.Exception.Message&nbsp;+&nbsp;<span style=""color:#a31515;"">&quot;\n&quot;</span>&nbsp;+&nbsp;request.Exception.StackTrace)&nbsp;:&nbsp;<span style=""color:#a31515;"">&quot;No&nbsp;Exception&quot;</span>);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">Debug</span>.LogError(status);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">break</span>;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;The&nbsp;request&nbsp;aborted,&nbsp;initiated&nbsp;by&nbsp;the&nbsp;user.</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">case</span>&nbsp;<span style=""color:#2b91af;"">HTTPRequestStates</span>.Aborted:
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;status&nbsp;=&nbsp;<span style=""color:#a31515;"">&quot;Request&nbsp;Aborted!&quot;</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">Debug</span>.LogWarning(status);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">break</span>;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Ceonnecting&nbsp;to&nbsp;the&nbsp;server&nbsp;is&nbsp;timed&nbsp;out.</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">case</span>&nbsp;<span style=""color:#2b91af;"">HTTPRequestStates</span>.ConnectionTimedOut:
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;status&nbsp;=&nbsp;<span style=""color:#a31515;"">&quot;Connection&nbsp;Timed&nbsp;Out!&quot;</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">Debug</span>.LogError(status);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">break</span>;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;The&nbsp;request&nbsp;didn&#39;t&nbsp;finished&nbsp;in&nbsp;the&nbsp;given&nbsp;time.</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">case</span>&nbsp;<span style=""color:#2b91af;"">HTTPRequestStates</span>.TimedOut:
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;status&nbsp;=&nbsp;<span style=""color:#a31515;"">&quot;Processing&nbsp;the&nbsp;request&nbsp;Timed&nbsp;Out!&quot;</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">Debug</span>.LogError(status);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">break</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;downloading&nbsp;=&nbsp;<span style=""color:blue;"">false</span>;
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;In&nbsp;this&nbsp;function&nbsp;we&nbsp;can&nbsp;do&nbsp;whatever&nbsp;we&nbsp;want&nbsp;with&nbsp;the&nbsp;freshly&nbsp;downloaded&nbsp;bundle.</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;In&nbsp;this&nbsp;example&nbsp;we&nbsp;will&nbsp;cache&nbsp;it&nbsp;for&nbsp;later&nbsp;use,&nbsp;and&nbsp;we&nbsp;will&nbsp;load&nbsp;a&nbsp;texture&nbsp;from&nbsp;it.</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">IEnumerator</span>&nbsp;ProcessAssetBundle(<span style=""color:#2b91af;"">AssetBundle</span>&nbsp;bundle)
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(bundle&nbsp;==&nbsp;<span style=""color:blue;"">null</span>)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">yield</span>&nbsp;<span style=""color:blue;"">break</span>;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Save&nbsp;the&nbsp;bundle&nbsp;for&nbsp;future&nbsp;use</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;cachedBundle&nbsp;=&nbsp;bundle;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Start&nbsp;loading&nbsp;the&nbsp;asset&nbsp;from&nbsp;the&nbsp;bundle</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">var</span>&nbsp;asyncAsset&nbsp;=&nbsp;cachedBundle.LoadAsync(<span style=""color:#a31515;"">&quot;9443182_orig&quot;</span>,&nbsp;<span style=""color:blue;"">typeof</span>(<span style=""color:#2b91af;"">Texture2D</span>));
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;wait&nbsp;til&nbsp;load</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">yield</span>&nbsp;<span style=""color:blue;"">return</span>&nbsp;asyncAsset;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;get&nbsp;the&nbsp;texture</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;texture&nbsp;=&nbsp;asyncAsset.asset&nbsp;<span style=""color:blue;"">as</span>&nbsp;<span style=""color:#2b91af;"">Texture2D</span>;
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;UnloadBundle()
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(cachedBundle&nbsp;!=&nbsp;<span style=""color:blue;"">null</span>)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;cachedBundle.Unload(<span style=""color:blue;"">true</span>);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;cachedBundle&nbsp;=&nbsp;<span style=""color:blue;"">null</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}
&nbsp;&nbsp;&nbsp;&nbsp;}
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#endregion</span>
}</pre>";
    #endregion

    #region LargeFileDownloadSample
    public static string LargeFileDownloadSample = @"<pre style=""font-family:Consolas;font-size:13;color:black;background:silver;""><span style=""color:blue;"">using</span>&nbsp;System;
<span style=""color:blue;"">using</span>&nbsp;System.Collections.Generic;
 
<span style=""color:blue;"">using</span>&nbsp;UnityEngine;
<span style=""color:blue;"">using</span>&nbsp;BestHTTP;
 
<span style=""color:blue;"">public</span>&nbsp;<span style=""color:blue;"">sealed</span>&nbsp;<span style=""color:blue;"">class</span>&nbsp;<span style=""color:#2b91af;"">LargeFileDownloadSample</span>&nbsp;:&nbsp;<span style=""color:#2b91af;"">MonoBehaviour</span>
{
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;The&nbsp;url&nbsp;of&nbsp;the&nbsp;resource&nbsp;to&nbsp;download</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">const</span>&nbsp;<span style=""color:blue;"">string</span>&nbsp;URL&nbsp;=&nbsp;<span style=""color:#a31515;"">&quot;http://ipv4.download.thinkbroadband.com/100MB.zip&quot;</span>;
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#region</span>&nbsp;Private&nbsp;Fields
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;Cached&nbsp;request&nbsp;to&nbsp;be&nbsp;able&nbsp;to&nbsp;abort&nbsp;it</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">HTTPRequest</span>&nbsp;request;
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;Debug&nbsp;status&nbsp;of&nbsp;the&nbsp;request</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">string</span>&nbsp;status&nbsp;=&nbsp;<span style=""color:blue;"">string</span>.Empty;
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;Download(processing)&nbsp;progress.&nbsp;Its&nbsp;range&nbsp;is&nbsp;between&nbsp;[0..1]</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">float</span>&nbsp;progress;
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;The&nbsp;fragment&nbsp;size&nbsp;that&nbsp;we&nbsp;will&nbsp;set&nbsp;to&nbsp;the&nbsp;request</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">int</span>&nbsp;fragmentSize&nbsp;=&nbsp;<span style=""color:#2b91af;"">HTTPResponse</span>.MinBufferSize;
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#endregion</span>
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#region</span>&nbsp;Unity&nbsp;Events
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;Awake()
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;If&nbsp;we&nbsp;have&nbsp;a&nbsp;non-finished&nbsp;download,&nbsp;set&nbsp;the&nbsp;progress&nbsp;to&nbsp;the&nbsp;value&nbsp;where&nbsp;we&nbsp;left&nbsp;it</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(<span style=""color:#2b91af;"">PlayerPrefs</span>.HasKey(<span style=""color:#a31515;"">&quot;DownloadLength&quot;</span>))
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;progress&nbsp;=&nbsp;<span style=""color:#2b91af;"">PlayerPrefs</span>.GetInt(<span style=""color:#a31515;"">&quot;DownloadProgress&quot;</span>)&nbsp;/&nbsp;(<span style=""color:blue;"">float</span>)<span style=""color:#2b91af;"">PlayerPrefs</span>.GetInt(<span style=""color:#a31515;"">&quot;DownloadLength&quot;</span>);
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;OnDestroy()
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Stop&nbsp;the&nbsp;download&nbsp;if&nbsp;we&nbsp;are&nbsp;leaving&nbsp;this&nbsp;example</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(request&nbsp;!=&nbsp;<span style=""color:blue;"">null</span>&nbsp;&amp;&amp;&nbsp;request.State&nbsp;&lt;&nbsp;<span style=""color:#2b91af;"">HTTPRequestStates</span>.Finished)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;request.OnProgress&nbsp;=&nbsp;<span style=""color:blue;"">null</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;request.Callback&nbsp;=&nbsp;<span style=""color:blue;"">null</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;request.Abort();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;OnGUI()
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUIHelper</span>.DrawArea(<span style=""color:#2b91af;"">GUIHelper</span>.ClientArea,&nbsp;<span style=""color:blue;"">true</span>,&nbsp;()&nbsp;=&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Draw&nbsp;the&nbsp;current&nbsp;status</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.Label(<span style=""color:#a31515;"">&quot;Request&nbsp;status:&nbsp;&quot;</span>&nbsp;+&nbsp;status);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.Space(5);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Draw&nbsp;the&nbsp;current&nbsp;progress</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.Label(<span style=""color:blue;"">string</span>.Format(<span style=""color:#a31515;"">&quot;Progress:&nbsp;{0:P2}&nbsp;of&nbsp;{1:N0}Mb&quot;</span>,&nbsp;progress,&nbsp;<span style=""color:#2b91af;"">PlayerPrefs</span>.GetInt(<span style=""color:#a31515;"">&quot;DownloadLength&quot;</span>)&nbsp;/&nbsp;1048576&nbsp;<span style=""color:green;"">/*1&nbsp;Mb*/</span>));
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.HorizontalSlider(progress,&nbsp;0,&nbsp;1);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.Space(50);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(request&nbsp;==&nbsp;<span style=""color:blue;"">null</span>)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Draw&nbsp;a&nbsp;slider&nbsp;to&nbsp;be&nbsp;able&nbsp;to&nbsp;change&nbsp;the&nbsp;fragment&nbsp;size</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.Label(<span style=""color:blue;"">string</span>.Format(<span style=""color:#a31515;"">&quot;Desired&nbsp;Fragment&nbsp;Size:&nbsp;{0:N}&nbsp;KBytes&quot;</span>,&nbsp;fragmentSize&nbsp;/&nbsp;1024f));
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;fragmentSize&nbsp;=&nbsp;(<span style=""color:blue;"">int</span>)<span style=""color:#2b91af;"">GUILayout</span>.HorizontalSlider(fragmentSize,&nbsp;<span style=""color:#2b91af;"">HTTPResponse</span>.MinBufferSize,&nbsp;10&nbsp;*&nbsp;1024&nbsp;*&nbsp;1024);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.Space(5);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">string</span>&nbsp;buttonStr&nbsp;=&nbsp;<span style=""color:#2b91af;"">PlayerPrefs</span>.HasKey(<span style=""color:#a31515;"">&quot;DownloadProgress&quot;</span>)&nbsp;?&nbsp;<span style=""color:#a31515;"">&quot;Continue&nbsp;Download&quot;</span>&nbsp;:&nbsp;<span style=""color:#a31515;"">&quot;Start&nbsp;Download&quot;</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(<span style=""color:#2b91af;"">GUILayout</span>.Button(buttonStr))
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;StreamLargeFileTest();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">else</span>&nbsp;<span style=""color:blue;"">if</span>&nbsp;(request.State&nbsp;==&nbsp;<span style=""color:#2b91af;"">HTTPRequestStates</span>.Processing&nbsp;&amp;&amp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.Button(<span style=""color:#a31515;"">&quot;Abort&nbsp;Download&quot;</span>))
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Simulate&nbsp;a&nbsp;connection&nbsp;lost</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;request.Abort();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;});
&nbsp;&nbsp;&nbsp;&nbsp;}
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#endregion</span>
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#region</span>&nbsp;Private&nbsp;Helper&nbsp;Functions
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Calling&nbsp;this&nbsp;function&nbsp;again&nbsp;when&nbsp;the&nbsp;&quot;DownloadProgress&quot;&nbsp;key&nbsp;in&nbsp;the&nbsp;PlayerPrefs&nbsp;present&nbsp;will&nbsp;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//	continue&nbsp;the&nbsp;download</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;StreamLargeFileTest()
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;request&nbsp;=&nbsp;<span style=""color:blue;"">new</span>&nbsp;<span style=""color:#2b91af;"">HTTPRequest</span>(<span style=""color:blue;"">new</span>&nbsp;<span style=""color:#2b91af;"">Uri</span>(URL),&nbsp;(req,&nbsp;resp)&nbsp;=&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">switch</span>&nbsp;(req.State)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;The&nbsp;request&nbsp;is&nbsp;currently&nbsp;processed.&nbsp;With&nbsp;UseStreaming&nbsp;==&nbsp;true,&nbsp;we&nbsp;can&nbsp;get&nbsp;the&nbsp;streamed&nbsp;fragments&nbsp;here</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">case</span>&nbsp;<span style=""color:#2b91af;"">HTTPRequestStates</span>.Processing:
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Set&nbsp;the&nbsp;DownloadLength,&nbsp;so&nbsp;we&nbsp;can&nbsp;display&nbsp;the&nbsp;progress</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(!<span style=""color:#2b91af;"">PlayerPrefs</span>.HasKey(<span style=""color:#a31515;"">&quot;DownloadLength&quot;</span>))
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">string</span>&nbsp;value&nbsp;=&nbsp;resp.GetFirstHeaderValue(<span style=""color:#a31515;"">&quot;content-length&quot;</span>);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(!<span style=""color:blue;"">string</span>.IsNullOrEmpty(value))
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">PlayerPrefs</span>.SetInt(<span style=""color:#a31515;"">&quot;DownloadLength&quot;</span>,&nbsp;<span style=""color:blue;"">int</span>.Parse(value));
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Get&nbsp;the&nbsp;fragments,&nbsp;and&nbsp;save&nbsp;them</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;ProcessFragments(resp.GetStreamedFragments());
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;status&nbsp;=&nbsp;<span style=""color:#a31515;"">&quot;Processing&quot;</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">break</span>;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;The&nbsp;request&nbsp;finished&nbsp;without&nbsp;any&nbsp;problem.</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">case</span>&nbsp;<span style=""color:#2b91af;"">HTTPRequestStates</span>.Finished:
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(resp.IsSuccess)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Save&nbsp;any&nbsp;remaining&nbsp;fragments</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;ProcessFragments(resp.GetStreamedFragments());
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Completly&nbsp;finished</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(resp.IsStreamingFinished)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;status&nbsp;=&nbsp;<span style=""color:#a31515;"">&quot;Streaming&nbsp;finished!&quot;</span>;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;We&nbsp;are&nbsp;done,&nbsp;delete&nbsp;the&nbsp;progress&nbsp;key</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">PlayerPrefs</span>.DeleteKey(<span style=""color:#a31515;"">&quot;DownloadProgress&quot;</span>);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">PlayerPrefs</span>.Save();
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;request&nbsp;=&nbsp;<span style=""color:blue;"">null</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">else</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;status&nbsp;=&nbsp;<span style=""color:#a31515;"">&quot;Processing&quot;</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">else</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;status&nbsp;=&nbsp;<span style=""color:blue;"">string</span>.Format(<span style=""color:#a31515;"">&quot;Request&nbsp;finished&nbsp;Successfully,&nbsp;but&nbsp;the&nbsp;server&nbsp;sent&nbsp;an&nbsp;error.&nbsp;Status&nbsp;Code:&nbsp;{0}-{1}&nbsp;Message:&nbsp;{2}&quot;</span>,
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;resp.StatusCode,
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;resp.Message,
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;resp.DataAsText);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">Debug</span>.LogWarning(status);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;request&nbsp;=&nbsp;<span style=""color:blue;"">null</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">break</span>;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;The&nbsp;request&nbsp;finished&nbsp;with&nbsp;an&nbsp;unexpected&nbsp;error.&nbsp;The&nbsp;request&#39;s&nbsp;Exception&nbsp;property&nbsp;may&nbsp;contain&nbsp;more&nbsp;info&nbsp;about&nbsp;the&nbsp;error.</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">case</span>&nbsp;<span style=""color:#2b91af;"">HTTPRequestStates</span>.Error:
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;status&nbsp;=&nbsp;<span style=""color:#a31515;"">&quot;Request&nbsp;Finished&nbsp;with&nbsp;Error!&nbsp;&quot;</span>&nbsp;+&nbsp;(req.Exception&nbsp;!=&nbsp;<span style=""color:blue;"">null</span>&nbsp;?&nbsp;(req.Exception.Message&nbsp;+&nbsp;<span style=""color:#a31515;"">&quot;\n&quot;</span>&nbsp;+&nbsp;req.Exception.StackTrace)&nbsp;:&nbsp;<span style=""color:#a31515;"">&quot;No&nbsp;Exception&quot;</span>);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">Debug</span>.LogError(status);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;request&nbsp;=&nbsp;<span style=""color:blue;"">null</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">break</span>;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;The&nbsp;request&nbsp;aborted,&nbsp;initiated&nbsp;by&nbsp;the&nbsp;user.</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">case</span>&nbsp;<span style=""color:#2b91af;"">HTTPRequestStates</span>.Aborted:
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;status&nbsp;=&nbsp;<span style=""color:#a31515;"">&quot;Request&nbsp;Aborted!&quot;</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">Debug</span>.LogWarning(status);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;request&nbsp;=&nbsp;<span style=""color:blue;"">null</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">break</span>;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Ceonnecting&nbsp;to&nbsp;the&nbsp;server&nbsp;is&nbsp;timed&nbsp;out.</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">case</span>&nbsp;<span style=""color:#2b91af;"">HTTPRequestStates</span>.ConnectionTimedOut:
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;status&nbsp;=&nbsp;<span style=""color:#a31515;"">&quot;Connection&nbsp;Timed&nbsp;Out!&quot;</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">Debug</span>.LogError(status);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;request&nbsp;=&nbsp;<span style=""color:blue;"">null</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">break</span>;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;The&nbsp;request&nbsp;didn&#39;t&nbsp;finished&nbsp;in&nbsp;the&nbsp;given&nbsp;time.</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">case</span>&nbsp;<span style=""color:#2b91af;"">HTTPRequestStates</span>.TimedOut:
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;status&nbsp;=&nbsp;<span style=""color:#a31515;"">&quot;Processing&nbsp;the&nbsp;request&nbsp;Timed&nbsp;Out!&quot;</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">Debug</span>.LogError(status);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;request&nbsp;=&nbsp;<span style=""color:blue;"">null</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">break</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;});
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Are&nbsp;there&nbsp;any&nbsp;progress,&nbsp;that&nbsp;we&nbsp;can&nbsp;continue?</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(<span style=""color:#2b91af;"">PlayerPrefs</span>.HasKey(<span style=""color:#a31515;"">&quot;DownloadProgress&quot;</span>))
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Set&nbsp;the&nbsp;range&nbsp;header</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;request.SetRangeHeader(<span style=""color:#2b91af;"">PlayerPrefs</span>.GetInt(<span style=""color:#a31515;"">&quot;DownloadProgress&quot;</span>));
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">else</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;This&nbsp;is&nbsp;a&nbsp;new&nbsp;request</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">PlayerPrefs</span>.SetInt(<span style=""color:#a31515;"">&quot;DownloadProgress&quot;</span>,&nbsp;0);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;If&nbsp;we&nbsp;are&nbsp;writing&nbsp;our&nbsp;own&nbsp;file&nbsp;set&nbsp;it&nbsp;true(disable),&nbsp;so&nbsp;don&#39;t&nbsp;duplicate&nbsp;it&nbsp;on&nbsp;the&nbsp;filesystem</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;request.DisableCache&nbsp;=&nbsp;<span style=""color:blue;"">true</span>;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;We&nbsp;want&nbsp;to&nbsp;access&nbsp;the&nbsp;downloaded&nbsp;bytes&nbsp;while&nbsp;we&nbsp;are&nbsp;still&nbsp;downloading</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;request.UseStreaming&nbsp;=&nbsp;<span style=""color:blue;"">true</span>;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Set&nbsp;a&nbsp;reasonable&nbsp;high&nbsp;fragment&nbsp;size.&nbsp;Here&nbsp;it&nbsp;is&nbsp;5&nbsp;megabytes.</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;request.StreamFragmentSize&nbsp;=&nbsp;fragmentSize;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Start&nbsp;Processing&nbsp;the&nbsp;request</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;request.Send();
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;In&nbsp;this&nbsp;function&nbsp;we&nbsp;can&nbsp;do&nbsp;whatever&nbsp;we&nbsp;want&nbsp;with&nbsp;the&nbsp;downloaded&nbsp;bytes.&nbsp;In&nbsp;this&nbsp;sample&nbsp;we&nbsp;will&nbsp;do&nbsp;nothing,&nbsp;just&nbsp;set&nbsp;the&nbsp;metadata&nbsp;to&nbsp;display&nbsp;progress.</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;ProcessFragments(<span style=""color:#2b91af;"">List</span>&lt;<span style=""color:blue;"">byte</span>[]&gt;&nbsp;fragments)
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(fragments&nbsp;!=&nbsp;<span style=""color:blue;"">null</span>&nbsp;&amp;&amp;&nbsp;fragments.Count&nbsp;&gt;&nbsp;0)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">/*string&nbsp;dir&nbsp;=&nbsp;&quot;TODO!&quot;;</span>
<span style=""color:green;"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;string&nbsp;filename&nbsp;=&nbsp;&quot;TODO!&quot;;</span>
 
<span style=""color:green;"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;using&nbsp;(System.IO.FileStream&nbsp;fs&nbsp;=&nbsp;new&nbsp;System.IO.FileStream(System.IO.Path.Combine(dir,&nbsp;filename),&nbsp;System.IO.FileMode.Append))</span>
<span style=""color:green;"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;for&nbsp;(int&nbsp;i&nbsp;=&nbsp;0;&nbsp;i&nbsp;&lt;&nbsp;fragments.Count;&nbsp;++i)</span>
<span style=""color:green;"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;fs.Write(fragments[i],&nbsp;0,&nbsp;fragments[i].Length);*/</span>
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">for</span>&nbsp;(<span style=""color:blue;"">int</span>&nbsp;i&nbsp;=&nbsp;0;&nbsp;i&nbsp;&lt;&nbsp;fragments.Count;&nbsp;++i)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Save&nbsp;how&nbsp;many&nbsp;bytes&nbsp;we&nbsp;wrote&nbsp;successfully</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">int</span>&nbsp;downloaded&nbsp;=&nbsp;<span style=""color:#2b91af;"">PlayerPrefs</span>.GetInt(<span style=""color:#a31515;"">&quot;DownloadProgress&quot;</span>)&nbsp;+&nbsp;fragments[i].Length;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">PlayerPrefs</span>.SetInt(<span style=""color:#a31515;"">&quot;DownloadProgress&quot;</span>,&nbsp;downloaded);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">PlayerPrefs</span>.Save();
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Set&nbsp;the&nbsp;progress&nbsp;to&nbsp;the&nbsp;actually&nbsp;processed&nbsp;bytes</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;progress&nbsp;=&nbsp;<span style=""color:#2b91af;"">PlayerPrefs</span>.GetInt(<span style=""color:#a31515;"">&quot;DownloadProgress&quot;</span>)&nbsp;/&nbsp;(<span style=""color:blue;"">float</span>)<span style=""color:#2b91af;"">PlayerPrefs</span>.GetInt(<span style=""color:#a31515;"">&quot;DownloadLength&quot;</span>);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}
&nbsp;&nbsp;&nbsp;&nbsp;}
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#endregion</span>
}</pre>";
    #endregion

    #region SocketIOChatSample
    public static string SocketIOChatSample = @"<pre style=""font-family:Consolas;font-size:13;color:black;background:silver;""><span style=""color:blue;"">using</span>&nbsp;System;
<span style=""color:blue;"">using</span>&nbsp;System.Collections.Generic;
 
<span style=""color:blue;"">using</span>&nbsp;UnityEngine;
<span style=""color:blue;"">using</span>&nbsp;BestHTTP;
<span style=""color:blue;"">using</span>&nbsp;BestHTTP.SocketIO;
<span style=""color:blue;"">using</span>&nbsp;BestHTTP.JSON;
<span style=""color:blue;"">using</span>&nbsp;BestHTTP.SocketIO.Events;
 
<span style=""color:blue;"">public</span>&nbsp;<span style=""color:blue;"">sealed</span>&nbsp;<span style=""color:blue;"">class</span>&nbsp;<span style=""color:#2b91af;"">SocketIOChatSample</span>&nbsp;:&nbsp;<span style=""color:#2b91af;"">MonoBehaviour</span>
{
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">private</span>&nbsp;<span style=""color:blue;"">readonly</span>&nbsp;<span style=""color:#2b91af;"">TimeSpan</span>&nbsp;TYPING_TIMER_LENGTH&nbsp;=&nbsp;<span style=""color:#2b91af;"">TimeSpan</span>.FromMilliseconds(700);
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">private</span>&nbsp;<span style=""color:blue;"">enum</span>&nbsp;<span style=""color:#2b91af;"">ChatStates</span>
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Login,
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Chat
&nbsp;&nbsp;&nbsp;&nbsp;}
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#region</span>&nbsp;Fields
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;The&nbsp;Socket.IO&nbsp;manager&nbsp;instance.</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">private</span>&nbsp;<span style=""color:#2b91af;"">SocketManager</span>&nbsp;Manager;
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;Current&nbsp;state&nbsp;of&nbsp;the&nbsp;chat&nbsp;demo.</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">private</span>&nbsp;<span style=""color:#2b91af;"">ChatStates</span>&nbsp;State;
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;The&nbsp;selected&nbsp;nickname</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">private</span>&nbsp;<span style=""color:blue;"">string</span>&nbsp;userName&nbsp;=&nbsp;<span style=""color:blue;"">string</span>.Empty;
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;Currently&nbsp;typing&nbsp;message</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">private</span>&nbsp;<span style=""color:blue;"">string</span>&nbsp;message&nbsp;=&nbsp;<span style=""color:blue;"">string</span>.Empty;
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;Sent&nbsp;and&nbsp;received&nbsp;messages.</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">private</span>&nbsp;<span style=""color:blue;"">string</span>&nbsp;chatLog&nbsp;=&nbsp;<span style=""color:blue;"">string</span>.Empty;
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;Position&nbsp;of&nbsp;the&nbsp;scroller</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">private</span>&nbsp;<span style=""color:#2b91af;"">Vector2</span>&nbsp;scrollPos;
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;True&nbsp;if&nbsp;the&nbsp;user&nbsp;is&nbsp;currently&nbsp;typing</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">private</span>&nbsp;<span style=""color:blue;"">bool</span>&nbsp;typing;
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;When&nbsp;the&nbsp;message&nbsp;changed.</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">private</span>&nbsp;<span style=""color:#2b91af;"">DateTime</span>&nbsp;lastTypingTime&nbsp;=&nbsp;<span style=""color:#2b91af;"">DateTime</span>.MinValue;
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;Users&nbsp;that&nbsp;typing.</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">private</span>&nbsp;<span style=""color:#2b91af;"">List</span>&lt;<span style=""color:blue;"">string</span>&gt;&nbsp;typingUsers&nbsp;=&nbsp;<span style=""color:blue;"">new</span>&nbsp;<span style=""color:#2b91af;"">List</span>&lt;<span style=""color:blue;"">string</span>&gt;();
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#endregion</span>
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#region</span>&nbsp;Unity&nbsp;Events
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;Start()
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;The&nbsp;current&nbsp;state&nbsp;is&nbsp;Login</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;State&nbsp;=&nbsp;<span style=""color:#2b91af;"">ChatStates</span>.Login;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Change&nbsp;an&nbsp;option&nbsp;to&nbsp;show&nbsp;how&nbsp;it&nbsp;should&nbsp;be&nbsp;done</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">SocketOptions</span>&nbsp;options&nbsp;=&nbsp;<span style=""color:blue;"">new</span>&nbsp;<span style=""color:#2b91af;"">SocketOptions</span>();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;options.AutoConnect&nbsp;=&nbsp;<span style=""color:blue;"">false</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Create&nbsp;the&nbsp;Socket.IO&nbsp;manager</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Manager&nbsp;=&nbsp;<span style=""color:blue;"">new</span>&nbsp;<span style=""color:#2b91af;"">SocketManager</span>(<span style=""color:blue;"">new</span>&nbsp;<span style=""color:#2b91af;"">Uri</span>(<span style=""color:#a31515;"">&quot;http://chat.socket.io/socket.io/&quot;</span>),&nbsp;options);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Set&nbsp;up&nbsp;custom&nbsp;chat&nbsp;events</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Manager.Socket.On(<span style=""color:#a31515;"">&quot;login&quot;</span>,&nbsp;OnLogin);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Manager.Socket.On(<span style=""color:#a31515;"">&quot;new&nbsp;message&quot;</span>,&nbsp;OnNewMessage);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Manager.Socket.On(<span style=""color:#a31515;"">&quot;user&nbsp;joined&quot;</span>,&nbsp;OnUserJoined);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Manager.Socket.On(<span style=""color:#a31515;"">&quot;user&nbsp;left&quot;</span>,&nbsp;OnUserLeft);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Manager.Socket.On(<span style=""color:#a31515;"">&quot;typing&quot;</span>,&nbsp;OnTyping);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Manager.Socket.On(<span style=""color:#a31515;"">&quot;stop&nbsp;typing&quot;</span>,&nbsp;OnStopTyping);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;The&nbsp;argument&nbsp;will&nbsp;be&nbsp;an&nbsp;Error&nbsp;object.</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Manager.Socket.On(<span style=""color:#2b91af;"">SocketIOEventTypes</span>.Error,&nbsp;(socket,&nbsp;packet,&nbsp;args)&nbsp;=&gt;&nbsp;<span style=""color:#2b91af;"">Debug</span>.LogError(<span style=""color:blue;"">string</span>.Format(<span style=""color:#a31515;"">&quot;Error:&nbsp;{0}&quot;</span>,&nbsp;args[0].ToString())));
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;We&nbsp;set&nbsp;SocketOptions&#39;&nbsp;AutoConnect&nbsp;to&nbsp;false,&nbsp;so&nbsp;we&nbsp;have&nbsp;to&nbsp;call&nbsp;it&nbsp;manually.</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Manager.Open();
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;OnDestroy()
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Leaving&nbsp;this&nbsp;sample,&nbsp;close&nbsp;the&nbsp;socket</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Manager.Close();
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;Update()
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Go&nbsp;back&nbsp;to&nbsp;the&nbsp;demo&nbsp;selector</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(<span style=""color:#2b91af;"">Input</span>.GetKeyDown(<span style=""color:#2b91af;"">KeyCode</span>.Escape))
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">SampleSelector</span>.SelectedSample.DestroyUnityObject();
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Stop&nbsp;typing&nbsp;if&nbsp;some&nbsp;time&nbsp;passed&nbsp;without&nbsp;typing</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(typing)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">var</span>&nbsp;typingTimer&nbsp;=&nbsp;<span style=""color:#2b91af;"">DateTime</span>.UtcNow;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">var</span>&nbsp;timeDiff&nbsp;=&nbsp;typingTimer&nbsp;-&nbsp;lastTypingTime;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(timeDiff&nbsp;&gt;=&nbsp;TYPING_TIMER_LENGTH)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Manager.Socket.Emit(<span style=""color:#a31515;"">&quot;stop&nbsp;typing&quot;</span>);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;typing&nbsp;=&nbsp;<span style=""color:blue;"">false</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;OnGUI()
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">switch</span>(State)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">case</span>&nbsp;<span style=""color:#2b91af;"">ChatStates</span>.Login:&nbsp;DrawLoginScreen();&nbsp;<span style=""color:blue;"">break</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">case</span>&nbsp;<span style=""color:#2b91af;"">ChatStates</span>.Chat:&nbsp;DrawChatScreen();&nbsp;<span style=""color:blue;"">break</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}
&nbsp;&nbsp;&nbsp;&nbsp;}
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#endregion</span>
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#region</span>&nbsp;Chat&nbsp;Logic
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;Called&nbsp;from&nbsp;an&nbsp;OnGUI&nbsp;event&nbsp;to&nbsp;draw&nbsp;the&nbsp;Login&nbsp;Screen.</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;DrawLoginScreen()
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUIHelper</span>.DrawArea(<span style=""color:#2b91af;"">GUIHelper</span>.ClientArea,&nbsp;<span style=""color:blue;"">true</span>,&nbsp;()&nbsp;=&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.BeginVertical();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.FlexibleSpace();
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUIHelper</span>.DrawCenteredText(<span style=""color:#a31515;"">&quot;What&#39;s&nbsp;your&nbsp;nickname?&quot;</span>);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;userName&nbsp;=&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.TextField(userName);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(<span style=""color:#2b91af;"">GUILayout</span>.Button(<span style=""color:#a31515;"">&quot;Join&quot;</span>))
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;SetUserName();
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.FlexibleSpace();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.EndVertical();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;});
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;Called&nbsp;from&nbsp;an&nbsp;OnGUI&nbsp;event&nbsp;to&nbsp;draw&nbsp;the&nbsp;Chat&nbsp;Screen.</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;DrawChatScreen()
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUIHelper</span>.DrawArea(<span style=""color:#2b91af;"">GUIHelper</span>.ClientArea,&nbsp;<span style=""color:blue;"">true</span>,&nbsp;()&nbsp;=&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.BeginVertical();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;scrollPos&nbsp;=&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.BeginScrollView(scrollPos);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.Label(chatLog,&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.ExpandWidth(<span style=""color:blue;"">true</span>),&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.ExpandHeight(<span style=""color:blue;"">true</span>));
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.EndScrollView();
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">string</span>&nbsp;typing&nbsp;=&nbsp;<span style=""color:blue;"">string</span>.Empty;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(typingUsers.Count&nbsp;&gt;&nbsp;0)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;typing&nbsp;+=&nbsp;<span style=""color:blue;"">string</span>.Format(<span style=""color:#a31515;"">&quot;{0}&quot;</span>,&nbsp;typingUsers[0]);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">for</span>&nbsp;(<span style=""color:blue;"">int</span>&nbsp;i&nbsp;=&nbsp;1;&nbsp;i&nbsp;&lt;&nbsp;typingUsers.Count;&nbsp;++i)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;typing&nbsp;+=&nbsp;<span style=""color:blue;"">string</span>.Format(<span style=""color:#a31515;"">&quot;,&nbsp;{0}&quot;</span>,&nbsp;typingUsers[i]);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(typingUsers.Count&nbsp;==&nbsp;1)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;typing&nbsp;+=&nbsp;<span style=""color:#a31515;"">&quot;&nbsp;is&nbsp;typing!&quot;</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">else</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;typing&nbsp;+=&nbsp;<span style=""color:#a31515;"">&quot;&nbsp;are&nbsp;typing!&quot;</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.Label(typing);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.Label(<span style=""color:#a31515;"">&quot;Type&nbsp;here:&quot;</span>);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.BeginHorizontal();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;message&nbsp;=&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.TextField(message);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(<span style=""color:#2b91af;"">GUILayout</span>.Button(<span style=""color:#a31515;"">&quot;Send&quot;</span>,&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.MaxWidth(100)))
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;SendMessage();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.EndHorizontal();
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(<span style=""color:#2b91af;"">GUI</span>.changed)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;UpdateTyping();
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.EndVertical();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;});
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;SetUserName()
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(<span style=""color:blue;"">string</span>.IsNullOrEmpty(userName))
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">return</span>;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;State&nbsp;=&nbsp;<span style=""color:#2b91af;"">ChatStates</span>.Chat;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Manager.Socket.Emit(<span style=""color:#a31515;"">&quot;add&nbsp;user&quot;</span>,&nbsp;userName);
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;SendMessage()
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(<span style=""color:blue;"">string</span>.IsNullOrEmpty(message))
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">return</span>;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Manager.Socket.Emit(<span style=""color:#a31515;"">&quot;new&nbsp;message&quot;</span>,&nbsp;message);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;chatLog&nbsp;+=&nbsp;<span style=""color:blue;"">string</span>.Format(<span style=""color:#a31515;"">&quot;{0}:&nbsp;{1}\n&quot;</span>,&nbsp;userName,&nbsp;message);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;message&nbsp;=&nbsp;<span style=""color:blue;"">string</span>.Empty;
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;UpdateTyping()
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(!typing)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;typing&nbsp;=&nbsp;<span style=""color:blue;"">true</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Manager.Socket.Emit(<span style=""color:#a31515;"">&quot;typing&quot;</span>);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;lastTypingTime&nbsp;=&nbsp;<span style=""color:#2b91af;"">DateTime</span>.UtcNow;
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;addParticipantsMessage(<span style=""color:#2b91af;"">Dictionary</span>&lt;<span style=""color:blue;"">string</span>,&nbsp;<span style=""color:blue;"">object</span>&gt;&nbsp;data)
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">int</span>&nbsp;numUsers&nbsp;=&nbsp;<span style=""color:#2b91af;"">Convert</span>.ToInt32(data[<span style=""color:#a31515;"">&quot;numUsers&quot;</span>]);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(numUsers&nbsp;==&nbsp;1)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;chatLog&nbsp;+=&nbsp;<span style=""color:#a31515;"">&quot;there&#39;s&nbsp;1&nbsp;participant\n&quot;</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">else</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;chatLog&nbsp;+=&nbsp;<span style=""color:#a31515;"">&quot;there&nbsp;are&nbsp;&quot;</span>&nbsp;+&nbsp;numUsers&nbsp;+&nbsp;<span style=""color:#a31515;"">&quot;&nbsp;participants\n&quot;</span>;
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;addChatMessage(<span style=""color:#2b91af;"">Dictionary</span>&lt;<span style=""color:blue;"">string</span>,&nbsp;<span style=""color:blue;"">object</span>&gt;&nbsp;data)
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">var</span>&nbsp;username&nbsp;=&nbsp;data[<span style=""color:#a31515;"">&quot;username&quot;</span>]&nbsp;<span style=""color:blue;"">as</span>&nbsp;<span style=""color:blue;"">string</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">var</span>&nbsp;msg&nbsp;=&nbsp;data[<span style=""color:#a31515;"">&quot;message&quot;</span>]&nbsp;<span style=""color:blue;"">as</span>&nbsp;<span style=""color:blue;"">string</span>;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;chatLog&nbsp;+=&nbsp;<span style=""color:blue;"">string</span>.Format(<span style=""color:#a31515;"">&quot;{0}:&nbsp;{1}\n&quot;</span>,&nbsp;username,&nbsp;msg);
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;AddChatTyping(<span style=""color:#2b91af;"">Dictionary</span>&lt;<span style=""color:blue;"">string</span>,&nbsp;<span style=""color:blue;"">object</span>&gt;&nbsp;data)
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">var</span>&nbsp;username&nbsp;=&nbsp;data[<span style=""color:#a31515;"">&quot;username&quot;</span>]&nbsp;<span style=""color:blue;"">as</span>&nbsp;<span style=""color:blue;"">string</span>;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;typingUsers.Add(username);
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;RemoveChatTyping(<span style=""color:#2b91af;"">Dictionary</span>&lt;<span style=""color:blue;"">string</span>,&nbsp;<span style=""color:blue;"">object</span>&gt;&nbsp;data)
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">var</span>&nbsp;username&nbsp;=&nbsp;data[<span style=""color:#a31515;"">&quot;username&quot;</span>]&nbsp;<span style=""color:blue;"">as</span>&nbsp;<span style=""color:blue;"">string</span>;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">int</span>&nbsp;idx&nbsp;=&nbsp;typingUsers.FindIndex((name)&nbsp;=&gt;&nbsp;name.Equals(username));
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(idx&nbsp;!=&nbsp;-1)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;typingUsers.RemoveAt(idx);
&nbsp;&nbsp;&nbsp;&nbsp;}
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#endregion</span>
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#region</span>&nbsp;Custom&nbsp;SocketIO&nbsp;Events
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;OnLogin(<span style=""color:#2b91af;"">Socket</span>&nbsp;socket,&nbsp;<span style=""color:#2b91af;"">Packet</span>&nbsp;packet,&nbsp;<span style=""color:blue;"">params</span>&nbsp;<span style=""color:blue;"">object</span>[]&nbsp;args)
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;chatLog&nbsp;=&nbsp;<span style=""color:#a31515;"">&quot;Welcome&nbsp;to&nbsp;Socket.IO&nbsp;Chat&nbsp;—&nbsp;\n&quot;</span>;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;addParticipantsMessage(args[0]&nbsp;<span style=""color:blue;"">as</span>&nbsp;<span style=""color:#2b91af;"">Dictionary</span>&lt;<span style=""color:blue;"">string</span>,&nbsp;<span style=""color:blue;"">object</span>&gt;);
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;OnNewMessage(<span style=""color:#2b91af;"">Socket</span>&nbsp;socket,&nbsp;<span style=""color:#2b91af;"">Packet</span>&nbsp;packet,&nbsp;<span style=""color:blue;"">params</span>&nbsp;<span style=""color:blue;"">object</span>[]&nbsp;args)
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;addChatMessage(args[0]&nbsp;<span style=""color:blue;"">as</span>&nbsp;<span style=""color:#2b91af;"">Dictionary</span>&lt;<span style=""color:blue;"">string</span>,&nbsp;<span style=""color:blue;"">object</span>&gt;);
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;OnUserJoined(<span style=""color:#2b91af;"">Socket</span>&nbsp;socket,&nbsp;<span style=""color:#2b91af;"">Packet</span>&nbsp;packet,&nbsp;<span style=""color:blue;"">params</span>&nbsp;<span style=""color:blue;"">object</span>[]&nbsp;args)
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">var</span>&nbsp;data&nbsp;=&nbsp;args[0]&nbsp;<span style=""color:blue;"">as</span>&nbsp;<span style=""color:#2b91af;"">Dictionary</span>&lt;<span style=""color:blue;"">string</span>,&nbsp;<span style=""color:blue;"">object</span>&gt;;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">var</span>&nbsp;username&nbsp;=&nbsp;data[<span style=""color:#a31515;"">&quot;username&quot;</span>]&nbsp;<span style=""color:blue;"">as</span>&nbsp;<span style=""color:blue;"">string</span>;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;chatLog&nbsp;+=&nbsp;<span style=""color:blue;"">string</span>.Format(<span style=""color:#a31515;"">&quot;{0}&nbsp;joined\n&quot;</span>,&nbsp;username);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;addParticipantsMessage(data);
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;OnUserLeft(<span style=""color:#2b91af;"">Socket</span>&nbsp;socket,&nbsp;<span style=""color:#2b91af;"">Packet</span>&nbsp;packet,&nbsp;<span style=""color:blue;"">params</span>&nbsp;<span style=""color:blue;"">object</span>[]&nbsp;args)
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">var</span>&nbsp;data&nbsp;=&nbsp;args[0]&nbsp;<span style=""color:blue;"">as</span>&nbsp;<span style=""color:#2b91af;"">Dictionary</span>&lt;<span style=""color:blue;"">string</span>,&nbsp;<span style=""color:blue;"">object</span>&gt;;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">var</span>&nbsp;username&nbsp;=&nbsp;data[<span style=""color:#a31515;"">&quot;username&quot;</span>]&nbsp;<span style=""color:blue;"">as</span>&nbsp;<span style=""color:blue;"">string</span>;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;chatLog&nbsp;+=&nbsp;<span style=""color:blue;"">string</span>.Format(<span style=""color:#a31515;"">&quot;{0}&nbsp;left\n&quot;</span>,&nbsp;username);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;addParticipantsMessage(data);
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;OnTyping(<span style=""color:#2b91af;"">Socket</span>&nbsp;socket,&nbsp;<span style=""color:#2b91af;"">Packet</span>&nbsp;packet,&nbsp;<span style=""color:blue;"">params</span>&nbsp;<span style=""color:blue;"">object</span>[]&nbsp;args)
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;AddChatTyping(args[0]&nbsp;<span style=""color:blue;"">as</span>&nbsp;<span style=""color:#2b91af;"">Dictionary</span>&lt;<span style=""color:blue;"">string</span>,&nbsp;<span style=""color:blue;"">object</span>&gt;);
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;OnStopTyping(<span style=""color:#2b91af;"">Socket</span>&nbsp;socket,&nbsp;<span style=""color:#2b91af;"">Packet</span>&nbsp;packet,&nbsp;<span style=""color:blue;"">params</span>&nbsp;<span style=""color:blue;"">object</span>[]&nbsp;args)
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;RemoveChatTyping(args[0]&nbsp;<span style=""color:blue;"">as</span>&nbsp;<span style=""color:#2b91af;"">Dictionary</span>&lt;<span style=""color:blue;"">string</span>,&nbsp;<span style=""color:blue;"">object</span>&gt;);
&nbsp;&nbsp;&nbsp;&nbsp;}
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#endregion</span>
}</pre>";
    #endregion

    #region SocketIOWePlaySample
    public static string SocketIOWePlaySample = @"<pre style=""font-family:Consolas;font-size:13;color:black;background:silver;""><span style=""color:blue;"">using</span>&nbsp;System;
<span style=""color:blue;"">using</span>&nbsp;System.Collections.Generic;
 
<span style=""color:blue;"">using</span>&nbsp;UnityEngine;
<span style=""color:blue;"">using</span>&nbsp;BestHTTP.SocketIO;
<span style=""color:blue;"">using</span>&nbsp;BestHTTP.SocketIO.Events;
 
<span style=""color:blue;"">public</span>&nbsp;<span style=""color:blue;"">sealed</span>&nbsp;<span style=""color:blue;"">class</span>&nbsp;<span style=""color:#2b91af;"">SocketIOWePlaySample</span>&nbsp;:&nbsp;<span style=""color:#2b91af;"">MonoBehaviour</span>
{
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;Possible&nbsp;states&nbsp;of&nbsp;the&nbsp;game.</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">enum</span>&nbsp;<span style=""color:#2b91af;"">States</span>
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Connecting,
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;WaitForNick,
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Joined
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;Controls&nbsp;that&nbsp;the&nbsp;server&nbsp;understands&nbsp;as&nbsp;a&nbsp;parameter&nbsp;in&nbsp;the&nbsp;move&nbsp;event.</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">private</span>&nbsp;<span style=""color:blue;"">string</span>[]&nbsp;controls&nbsp;=&nbsp;<span style=""color:blue;"">new</span>&nbsp;<span style=""color:blue;"">string</span>[]&nbsp;{&nbsp;<span style=""color:#a31515;"">&quot;left&quot;</span>,&nbsp;<span style=""color:#a31515;"">&quot;right&quot;</span>,&nbsp;<span style=""color:#a31515;"">&quot;a&quot;</span>,&nbsp;<span style=""color:#a31515;"">&quot;b&quot;</span>,&nbsp;<span style=""color:#a31515;"">&quot;up&quot;</span>,&nbsp;<span style=""color:#a31515;"">&quot;down&quot;</span>,&nbsp;<span style=""color:#a31515;"">&quot;select&quot;</span>,&nbsp;<span style=""color:#a31515;"">&quot;start&quot;</span>&nbsp;};
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;Ratio&nbsp;of&nbsp;the&nbsp;drawn&nbsp;GUI&nbsp;texture&nbsp;from&nbsp;the&nbsp;screen</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">private</span>&nbsp;<span style=""color:blue;"">const</span>&nbsp;<span style=""color:blue;"">float</span>&nbsp;ratio&nbsp;=&nbsp;1.5f;
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;How&nbsp;many&nbsp;messages&nbsp;to&nbsp;keep.</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">private</span>&nbsp;<span style=""color:blue;"">int</span>&nbsp;MaxMessages&nbsp;=&nbsp;50;
&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;Current&nbsp;state&nbsp;of&nbsp;the&nbsp;game.</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">private</span>&nbsp;<span style=""color:#2b91af;"">States</span>&nbsp;State;
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;The&nbsp;root(&quot;/&quot;)&nbsp;Socket&nbsp;instance.</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">private</span>&nbsp;<span style=""color:#2b91af;"">Socket</span>&nbsp;Socket;
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;The&nbsp;user-selected&nbsp;nickname.</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">private</span>&nbsp;<span style=""color:blue;"">string</span>&nbsp;Nick&nbsp;=&nbsp;<span style=""color:blue;"">string</span>.Empty;
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;The&nbsp;message&nbsp;that&nbsp;the&nbsp;user&nbsp;want&nbsp;to&nbsp;send&nbsp;to&nbsp;the&nbsp;chat.</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">private</span>&nbsp;<span style=""color:blue;"">string</span>&nbsp;messageToSend&nbsp;=&nbsp;<span style=""color:blue;"">string</span>.Empty;
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;How&nbsp;many&nbsp;user&nbsp;connected&nbsp;to&nbsp;the&nbsp;server.</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">private</span>&nbsp;<span style=""color:blue;"">int</span>&nbsp;connections;
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;Local&nbsp;and&nbsp;server&nbsp;sent&nbsp;messages.</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">private</span>&nbsp;<span style=""color:#2b91af;"">List</span>&lt;<span style=""color:blue;"">string</span>&gt;&nbsp;messages&nbsp;=&nbsp;<span style=""color:blue;"">new</span>&nbsp;<span style=""color:#2b91af;"">List</span>&lt;<span style=""color:blue;"">string</span>&gt;();
&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;The&nbsp;chat&nbsp;scroll&nbsp;position.</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">private</span>&nbsp;<span style=""color:#2b91af;"">Vector2</span>&nbsp;scrollPos;
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;The&nbsp;decoded&nbsp;texture&nbsp;from&nbsp;the&nbsp;server&nbsp;sent&nbsp;binary&nbsp;data</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">private</span>&nbsp;<span style=""color:#2b91af;"">Texture2D</span>&nbsp;FrameTexture;
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#region</span>&nbsp;Unity&nbsp;Events
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;Start()
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Change&nbsp;an&nbsp;option&nbsp;to&nbsp;show&nbsp;how&nbsp;it&nbsp;should&nbsp;be&nbsp;done</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">SocketOptions</span>&nbsp;options&nbsp;=&nbsp;<span style=""color:blue;"">new</span>&nbsp;<span style=""color:#2b91af;"">SocketOptions</span>();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;options.AutoConnect&nbsp;=&nbsp;<span style=""color:blue;"">false</span>;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Create&nbsp;the&nbsp;SocketManager&nbsp;instance</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">var</span>&nbsp;manager&nbsp;=&nbsp;<span style=""color:blue;"">new</span>&nbsp;<span style=""color:#2b91af;"">SocketManager</span>(<span style=""color:blue;"">new</span>&nbsp;<span style=""color:#2b91af;"">Uri</span>(<span style=""color:#a31515;"">&quot;http://io.weplay.io/socket.io/&quot;</span>),&nbsp;options);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Keep&nbsp;a&nbsp;reference&nbsp;to&nbsp;the&nbsp;root&nbsp;namespace</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Socket&nbsp;=&nbsp;manager.Socket;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Set&nbsp;up&nbsp;our&nbsp;event&nbsp;handlers.</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Socket.On(<span style=""color:#2b91af;"">SocketIOEventTypes</span>.Connect,&nbsp;OnConnected);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Socket.On(<span style=""color:#a31515;"">&quot;joined&quot;</span>,&nbsp;OnJoined);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Socket.On(<span style=""color:#a31515;"">&quot;connections&quot;</span>,&nbsp;OnConnections);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Socket.On(<span style=""color:#a31515;"">&quot;join&quot;</span>,&nbsp;OnJoin);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Socket.On(<span style=""color:#a31515;"">&quot;move&quot;</span>,&nbsp;OnMove);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Socket.On(<span style=""color:#a31515;"">&quot;message&quot;</span>,&nbsp;OnMessage);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Socket.On(<span style=""color:#a31515;"">&quot;reload&quot;</span>,&nbsp;OnReload);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Don&#39;t&nbsp;waste&nbsp;cpu&nbsp;cycles&nbsp;on&nbsp;decoding&nbsp;the&nbsp;payload,&nbsp;we&nbsp;are&nbsp;expecting&nbsp;only&nbsp;binary&nbsp;data&nbsp;with&nbsp;this&nbsp;event,</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;&nbsp;and&nbsp;we&nbsp;can&nbsp;access&nbsp;it&nbsp;through&nbsp;the&nbsp;packet&#39;s&nbsp;Attachments&nbsp;property.</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Socket.On(<span style=""color:#a31515;"">&quot;frame&quot;</span>,&nbsp;OnFrame,&nbsp;<span style=""color:green;"">/*autoDecodePayload:*/</span>&nbsp;<span style=""color:blue;"">false</span>);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Add&nbsp;error&nbsp;handler,&nbsp;so&nbsp;we&nbsp;can&nbsp;display&nbsp;it</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Socket.On(<span style=""color:#2b91af;"">SocketIOEventTypes</span>.Error,&nbsp;OnError);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;We&nbsp;set&nbsp;SocketOptions&#39;&nbsp;AutoConnect&nbsp;to&nbsp;false,&nbsp;so&nbsp;we&nbsp;have&nbsp;to&nbsp;call&nbsp;it&nbsp;manually.</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;manager.Open();
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;We&nbsp;are&nbsp;connecting&nbsp;to&nbsp;the&nbsp;server.</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;State&nbsp;=&nbsp;<span style=""color:#2b91af;"">States</span>.Connecting;
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;OnDestroy()
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Leaving&nbsp;this&nbsp;sample,&nbsp;close&nbsp;the&nbsp;socket</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Socket.Manager.Close();
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;Update()
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Go&nbsp;back&nbsp;to&nbsp;the&nbsp;demo&nbsp;selector</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(<span style=""color:#2b91af;"">Input</span>.GetKeyDown(<span style=""color:#2b91af;"">KeyCode</span>.Escape))
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">SampleSelector</span>.SelectedSample.DestroyUnityObject();
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;OnGUI()
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">switch</span>(State)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">case</span>&nbsp;<span style=""color:#2b91af;"">States</span>.Connecting:
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUIHelper</span>.DrawArea(<span style=""color:#2b91af;"">GUIHelper</span>.ClientArea,&nbsp;<span style=""color:blue;"">true</span>,&nbsp;()&nbsp;=&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.BeginVertical();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.FlexibleSpace();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUIHelper</span>.DrawCenteredText(<span style=""color:#a31515;"">&quot;Connecting&nbsp;to&nbsp;the&nbsp;server...&quot;</span>);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.FlexibleSpace();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.EndVertical();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;});
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">break</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">case</span>&nbsp;<span style=""color:#2b91af;"">States</span>.WaitForNick:
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUIHelper</span>.DrawArea(<span style=""color:#2b91af;"">GUIHelper</span>.ClientArea,&nbsp;<span style=""color:blue;"">true</span>,&nbsp;()&nbsp;=&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;DrawLoginScreen();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;});
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">break</span>;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">case</span>&nbsp;<span style=""color:#2b91af;"">States</span>.Joined:
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUIHelper</span>.DrawArea(<span style=""color:#2b91af;"">GUIHelper</span>.ClientArea,&nbsp;<span style=""color:blue;"">true</span>,&nbsp;()&nbsp;=&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Draw&nbsp;Texture</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(FrameTexture&nbsp;!=&nbsp;<span style=""color:blue;"">null</span>)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.Box(FrameTexture);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;DrawControls();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;DrawChat();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;});
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">break</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}
&nbsp;&nbsp;&nbsp;&nbsp;}
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#endregion</span>
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#region</span>&nbsp;Helper&nbsp;Functions
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;Called&nbsp;from&nbsp;an&nbsp;OnGUI&nbsp;event&nbsp;to&nbsp;draw&nbsp;the&nbsp;Login&nbsp;Screen.</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;DrawLoginScreen()
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.BeginVertical();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.FlexibleSpace();
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUIHelper</span>.DrawCenteredText(<span style=""color:#a31515;"">&quot;What&#39;s&nbsp;your&nbsp;nickname?&quot;</span>);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Nick&nbsp;=&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.TextField(Nick);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(<span style=""color:#2b91af;"">GUILayout</span>.Button(<span style=""color:#a31515;"">&quot;Join&quot;</span>))
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Join();
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.FlexibleSpace();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.EndVertical();
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;DrawControls()
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.BeginHorizontal();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.Label(<span style=""color:#a31515;"">&quot;Controls:&quot;</span>);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">for</span>&nbsp;(<span style=""color:blue;"">int</span>&nbsp;i&nbsp;=&nbsp;0;&nbsp;i&nbsp;&lt;&nbsp;controls.Length;&nbsp;++i)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(<span style=""color:#2b91af;"">GUILayout</span>.Button(controls[i]))
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Socket.Emit(<span style=""color:#a31515;"">&quot;move&quot;</span>,&nbsp;controls[i]);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.Label(<span style=""color:#a31515;"">&quot;&nbsp;Connections:&nbsp;&quot;</span>&nbsp;+&nbsp;connections);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.EndHorizontal();
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;DrawChat(<span style=""color:blue;"">bool</span>&nbsp;withInput&nbsp;=&nbsp;<span style=""color:blue;"">true</span>)
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.BeginVertical();
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Draw&nbsp;the&nbsp;messages</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;scrollPos&nbsp;=&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.BeginScrollView(scrollPos,&nbsp;<span style=""color:blue;"">false</span>,&nbsp;<span style=""color:blue;"">false</span>);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">for</span>&nbsp;(<span style=""color:blue;"">int</span>&nbsp;i&nbsp;=&nbsp;0;&nbsp;i&nbsp;&lt;&nbsp;messages.Count;&nbsp;++i)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.Label(messages[i],&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.MinWidth(<span style=""color:#2b91af;"">Screen</span>.width));
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.EndScrollView();
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(withInput)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.Label(<span style=""color:#a31515;"">&quot;Your&nbsp;message:&nbsp;&quot;</span>);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.BeginHorizontal();
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;messageToSend&nbsp;=&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.TextField(messageToSend);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(<span style=""color:#2b91af;"">GUILayout</span>.Button(<span style=""color:#a31515;"">&quot;Send&quot;</span>,&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.MaxWidth(100)))
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;SendMessage();
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.EndHorizontal();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.EndVertical();
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;Add&nbsp;a&nbsp;message&nbsp;to&nbsp;the&nbsp;message&nbsp;log</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;param&nbsp;name=</span><span style=""color:gray;"">&quot;msg&quot;</span><span style=""color:gray;"">&gt;&lt;/param&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;AddMessage(<span style=""color:blue;"">string</span>&nbsp;msg)
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;messages.Insert(0,&nbsp;msg);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(messages.Count&nbsp;&gt;&nbsp;MaxMessages)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;messages.RemoveRange(MaxMessages,&nbsp;messages.Count&nbsp;-&nbsp;MaxMessages);
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;Send&nbsp;a&nbsp;chat&nbsp;message.&nbsp;The&nbsp;message&nbsp;must&nbsp;be&nbsp;in&nbsp;the&nbsp;messageToSend&nbsp;field.</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;SendMessage()
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(<span style=""color:blue;"">string</span>.IsNullOrEmpty(messageToSend))
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">return</span>;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Socket.Emit(<span style=""color:#a31515;"">&quot;message&quot;</span>,&nbsp;messageToSend);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;AddMessage(<span style=""color:blue;"">string</span>.Format(<span style=""color:#a31515;"">&quot;{0}:&nbsp;{1}&quot;</span>,&nbsp;Nick,&nbsp;messageToSend));
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;messageToSend&nbsp;=&nbsp;<span style=""color:blue;"">string</span>.Empty;
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;Join&nbsp;to&nbsp;the&nbsp;game&nbsp;with&nbsp;the&nbsp;nickname&nbsp;stored&nbsp;in&nbsp;the&nbsp;Nick&nbsp;field.</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;Join()
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">PlayerPrefs</span>.SetString(<span style=""color:#a31515;"">&quot;Nick&quot;</span>,&nbsp;Nick);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Socket.Emit(<span style=""color:#a31515;"">&quot;join&quot;</span>,&nbsp;Nick);
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;Reload&nbsp;the&nbsp;game.</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;Reload()
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;FrameTexture&nbsp;=&nbsp;<span style=""color:blue;"">null</span>;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(Socket&nbsp;!=&nbsp;<span style=""color:blue;"">null</span>)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Socket.Manager.Close();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Socket&nbsp;=&nbsp;<span style=""color:blue;"">null</span>;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Start();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}
&nbsp;&nbsp;&nbsp;&nbsp;}
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#endregion</span>
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#region</span>&nbsp;SocketIO&nbsp;Events
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;Socket&nbsp;connected&nbsp;event.</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">private</span>&nbsp;<span style=""color:blue;"">void</span>&nbsp;OnConnected(<span style=""color:#2b91af;"">Socket</span>&nbsp;socket,&nbsp;<span style=""color:#2b91af;"">Packet</span>&nbsp;packet,&nbsp;<span style=""color:blue;"">params</span>&nbsp;<span style=""color:blue;"">object</span>[]&nbsp;args)
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(<span style=""color:#2b91af;"">PlayerPrefs</span>.HasKey(<span style=""color:#a31515;"">&quot;Nick&quot;</span>))
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Nick&nbsp;=&nbsp;<span style=""color:#2b91af;"">PlayerPrefs</span>.GetString(<span style=""color:#a31515;"">&quot;Nick&quot;</span>,&nbsp;<span style=""color:#a31515;"">&quot;NickName&quot;</span>);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Join();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">else</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;State&nbsp;=&nbsp;<span style=""color:#2b91af;"">States</span>.WaitForNick;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;AddMessage(<span style=""color:#a31515;"">&quot;connected&quot;</span>);
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;Local&nbsp;player&nbsp;joined&nbsp;after&nbsp;sending&nbsp;a&nbsp;&#39;join&#39;&nbsp;event</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">private</span>&nbsp;<span style=""color:blue;"">void</span>&nbsp;OnJoined(<span style=""color:#2b91af;"">Socket</span>&nbsp;socket,&nbsp;<span style=""color:#2b91af;"">Packet</span>&nbsp;packet,&nbsp;<span style=""color:blue;"">params</span>&nbsp;<span style=""color:blue;"">object</span>[]&nbsp;args)
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;State&nbsp;=&nbsp;<span style=""color:#2b91af;"">States</span>.Joined;
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;Server&nbsp;sent&nbsp;us&nbsp;a&nbsp;&#39;reload&#39;&nbsp;event.</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">private</span>&nbsp;<span style=""color:blue;"">void</span>&nbsp;OnReload(<span style=""color:#2b91af;"">Socket</span>&nbsp;socket,&nbsp;<span style=""color:#2b91af;"">Packet</span>&nbsp;packet,&nbsp;<span style=""color:blue;"">params</span>&nbsp;<span style=""color:blue;"">object</span>[]&nbsp;args)
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Reload();
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;Someone&nbsp;wrote&nbsp;a&nbsp;message&nbsp;to&nbsp;the&nbsp;chat.</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">private</span>&nbsp;<span style=""color:blue;"">void</span>&nbsp;OnMessage(<span style=""color:#2b91af;"">Socket</span>&nbsp;socket,&nbsp;<span style=""color:#2b91af;"">Packet</span>&nbsp;packet,&nbsp;<span style=""color:blue;"">params</span>&nbsp;<span style=""color:blue;"">object</span>[]&nbsp;args)
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(args.Length&nbsp;==&nbsp;1)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;AddMessage(args[0]&nbsp;<span style=""color:blue;"">as</span>&nbsp;<span style=""color:blue;"">string</span>);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">else</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;AddMessage(<span style=""color:blue;"">string</span>.Format(<span style=""color:#a31515;"">&quot;{0}:&nbsp;{1}&quot;</span>,&nbsp;args[1],&nbsp;args[0]));
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;Someone&nbsp;(including&nbsp;us)&nbsp;pressed&nbsp;a&nbsp;button.</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">private</span>&nbsp;<span style=""color:blue;"">void</span>&nbsp;OnMove(<span style=""color:#2b91af;"">Socket</span>&nbsp;socket,&nbsp;<span style=""color:#2b91af;"">Packet</span>&nbsp;packet,&nbsp;<span style=""color:blue;"">params</span>&nbsp;<span style=""color:blue;"">object</span>[]&nbsp;args)
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;AddMessage(<span style=""color:blue;"">string</span>.Format(<span style=""color:#a31515;"">&quot;{0}&nbsp;pressed&nbsp;{1}&quot;</span>,&nbsp;args[1],&nbsp;args[0]));
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;Someone&nbsp;joined&nbsp;to&nbsp;the&nbsp;game</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">private</span>&nbsp;<span style=""color:blue;"">void</span>&nbsp;OnJoin(<span style=""color:#2b91af;"">Socket</span>&nbsp;socket,&nbsp;<span style=""color:#2b91af;"">Packet</span>&nbsp;packet,&nbsp;<span style=""color:blue;"">params</span>&nbsp;<span style=""color:blue;"">object</span>[]&nbsp;args)
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">string</span>&nbsp;loc&nbsp;=&nbsp;args.Length&nbsp;&gt;&nbsp;1&nbsp;?&nbsp;<span style=""color:blue;"">string</span>.Format(<span style=""color:#a31515;"">&quot;({0})&quot;</span>,&nbsp;args[1])&nbsp;:&nbsp;<span style=""color:blue;"">string</span>.Empty;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;AddMessage(<span style=""color:blue;"">string</span>.Format(<span style=""color:#a31515;"">&quot;{0}&nbsp;joined&nbsp;{1}&quot;</span>,&nbsp;args[0],&nbsp;loc));
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;How&nbsp;many&nbsp;players&nbsp;are&nbsp;connected&nbsp;to&nbsp;the&nbsp;game.</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">private</span>&nbsp;<span style=""color:blue;"">void</span>&nbsp;OnConnections(<span style=""color:#2b91af;"">Socket</span>&nbsp;socket,&nbsp;<span style=""color:#2b91af;"">Packet</span>&nbsp;packet,&nbsp;<span style=""color:blue;"">params</span>&nbsp;<span style=""color:blue;"">object</span>[]&nbsp;args)
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;connections&nbsp;=&nbsp;<span style=""color:#2b91af;"">Convert</span>.ToInt32(args[0]);
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;The&nbsp;server&nbsp;sent&nbsp;us&nbsp;a&nbsp;new&nbsp;picture&nbsp;to&nbsp;draw&nbsp;the&nbsp;game.</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">private</span>&nbsp;<span style=""color:blue;"">void</span>&nbsp;OnFrame(<span style=""color:#2b91af;"">Socket</span>&nbsp;socket,&nbsp;<span style=""color:#2b91af;"">Packet</span>&nbsp;packet,&nbsp;<span style=""color:blue;"">params</span>&nbsp;<span style=""color:blue;"">object</span>[]&nbsp;args)
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(State&nbsp;!=&nbsp;<span style=""color:#2b91af;"">States</span>.Joined)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">return</span>;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(FrameTexture&nbsp;==&nbsp;<span style=""color:blue;"">null</span>)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;FrameTexture&nbsp;=&nbsp;<span style=""color:blue;"">new</span>&nbsp;<span style=""color:#2b91af;"">Texture2D</span>(0,&nbsp;0,&nbsp;<span style=""color:#2b91af;"">TextureFormat</span>.RGBA32,&nbsp;<span style=""color:blue;"">false</span>);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;FrameTexture.filterMode&nbsp;=&nbsp;<span style=""color:#2b91af;"">FilterMode</span>.Point;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Binary&nbsp;data&nbsp;usage&nbsp;case&nbsp;1&nbsp;-&nbsp;using&nbsp;directly&nbsp;the&nbsp;Attachments&nbsp;property:</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">byte</span>[]&nbsp;data&nbsp;=&nbsp;packet.Attachments[0];
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Binary&nbsp;data&nbsp;usage&nbsp;case&nbsp;2&nbsp;-&nbsp;using&nbsp;the&nbsp;packet&#39;s&nbsp;ReconstructAttachmentAsIndex()&nbsp;function</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">/*packet.ReconstructAttachmentAsIndex();</span>
<span style=""color:green;"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;args&nbsp;=&nbsp;packet.Decode(socket.Manager.Encoder);</span>
<span style=""color:green;"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;data&nbsp;=&nbsp;packet.Attachments[Convert.ToInt32(args[0])];*/</span>
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Binary&nbsp;data&nbsp;usage&nbsp;case&nbsp;3&nbsp;-&nbsp;using&nbsp;the&nbsp;packet&#39;s&nbsp;ReconstructAttachmentAsBase64()&nbsp;function</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">/*packet.ReconstructAttachmentAsBase64();</span>
<span style=""color:green;"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;args&nbsp;=&nbsp;packet.Decode(socket.Manager.Encoder);</span>
<span style=""color:green;"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;data&nbsp;=&nbsp;Convert.FromBase64String(args[0]&nbsp;as&nbsp;string);*/</span>
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Load&nbsp;the&nbsp;server&nbsp;sent&nbsp;picture</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;FrameTexture.LoadImage(data);
&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;Called&nbsp;on&nbsp;local&nbsp;or&nbsp;remote&nbsp;error.</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">private</span>&nbsp;<span style=""color:blue;"">void</span>&nbsp;OnError(<span style=""color:#2b91af;"">Socket</span>&nbsp;socket,&nbsp;<span style=""color:#2b91af;"">Packet</span>&nbsp;packet,&nbsp;<span style=""color:blue;"">params</span>&nbsp;<span style=""color:blue;"">object</span>[]&nbsp;args)
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;AddMessage(<span style=""color:blue;"">string</span>.Format(<span style=""color:#a31515;"">&quot;--ERROR&nbsp;-&nbsp;{0}&quot;</span>,&nbsp;args[0].ToString()));
&nbsp;&nbsp;&nbsp;&nbsp;}
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#endregion</span>
}</pre>";
    #endregion

    #region CacheMaintenanceSample
    public static string CacheMaintenanceSample = @"<pre style=""font-family:Consolas;font-size:13;color:black;background:silver;""><span style=""color:blue;"">using</span>&nbsp;System;
<span style=""color:blue;"">using</span>&nbsp;System.Collections.Generic;
 
<span style=""color:blue;"">using</span>&nbsp;UnityEngine;
<span style=""color:blue;"">using</span>&nbsp;BestHTTP;
<span style=""color:blue;"">using</span>&nbsp;BestHTTP.Caching;
 
<span style=""color:blue;"">public</span>&nbsp;<span style=""color:blue;"">sealed</span>&nbsp;<span style=""color:blue;"">class</span>&nbsp;<span style=""color:#2b91af;"">CacheMaintenanceSample</span>&nbsp;:&nbsp;<span style=""color:#2b91af;"">MonoBehaviour</span>
{
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;An&nbsp;enum&nbsp;for&nbsp;better&nbsp;readability</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">enum</span>&nbsp;<span style=""color:#2b91af;"">DeleteOlderTypes</span>
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Days,
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Hours,
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Mins,
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Secs
&nbsp;&nbsp;&nbsp;&nbsp;};
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#region</span>&nbsp;Private&nbsp;Fields
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;What&nbsp;methode&nbsp;to&nbsp;call&nbsp;on&nbsp;the&nbsp;TimeSpan</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">DeleteOlderTypes</span>&nbsp;deleteOlderType&nbsp;=&nbsp;<span style=""color:#2b91af;"">DeleteOlderTypes</span>.Secs;
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;The&nbsp;value&nbsp;for&nbsp;the&nbsp;TimeSpan.</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">int</span>&nbsp;value&nbsp;=&nbsp;10;
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;What&#39;s&nbsp;our&nbsp;maximum&nbsp;cache&nbsp;size</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:gray;"">///</span><span style=""color:green;"">&nbsp;</span><span style=""color:gray;"">&lt;/summary&gt;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">int</span>&nbsp;maxCacheSize&nbsp;=&nbsp;5&nbsp;*&nbsp;1024&nbsp;*&nbsp;1024;
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#endregion</span>
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#region</span>&nbsp;Unity&nbsp;Events
 
&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">void</span>&nbsp;OnGUI()
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUIHelper</span>.DrawArea(<span style=""color:#2b91af;"">GUIHelper</span>.ClientArea,&nbsp;<span style=""color:blue;"">true</span>,&nbsp;()&nbsp;=&gt;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.BeginHorizontal();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.Label(<span style=""color:#a31515;"">&quot;Delete&nbsp;cached&nbsp;entities&nbsp;older&nbsp;then&quot;</span>);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.Label(value.ToString(),&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.MinWidth(50));
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;value&nbsp;=&nbsp;(<span style=""color:blue;"">int</span>)<span style=""color:#2b91af;"">GUILayout</span>.HorizontalSlider(value,&nbsp;1,&nbsp;60,&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.MinWidth(100));
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.Space(10);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;deleteOlderType&nbsp;=&nbsp;(<span style=""color:#2b91af;"">DeleteOlderTypes</span>)(<span style=""color:blue;"">int</span>)<span style=""color:#2b91af;"">GUILayout</span>.SelectionGrid((<span style=""color:blue;"">int</span>)deleteOlderType,&nbsp;<span style=""color:blue;"">new</span>&nbsp;<span style=""color:blue;"">string</span>[]&nbsp;{&nbsp;<span style=""color:#a31515;"">&quot;Days&quot;</span>,&nbsp;<span style=""color:#a31515;"">&quot;Hours&quot;</span>,&nbsp;<span style=""color:#a31515;"">&quot;Mins&quot;</span>,&nbsp;<span style=""color:#a31515;"">&quot;Secs&quot;</span>&nbsp;},&nbsp;4);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.FlexibleSpace();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.EndHorizontal();
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.Space(10);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.BeginHorizontal();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.Label(<span style=""color:#a31515;"">&quot;Max&nbsp;Cache&nbsp;Size&nbsp;(bytes):&nbsp;&quot;</span>,&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.Width(150));
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.Label(maxCacheSize.ToString(<span style=""color:#a31515;"">&quot;N0&quot;</span>),&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.Width(70));
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;maxCacheSize&nbsp;=&nbsp;(<span style=""color:blue;"">int</span>)<span style=""color:#2b91af;"">GUILayout</span>.HorizontalSlider(maxCacheSize,&nbsp;1024,&nbsp;10&nbsp;*&nbsp;1024&nbsp;*&nbsp;1024);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.EndHorizontal();
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">GUILayout</span>.Space(10);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">if</span>&nbsp;(<span style=""color:#2b91af;"">GUILayout</span>.Button(<span style=""color:#a31515;"">&quot;Maintenance&quot;</span>))
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">TimeSpan</span>&nbsp;deleteOlder&nbsp;=&nbsp;<span style=""color:#2b91af;"">TimeSpan</span>.FromDays(14);
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">switch</span>&nbsp;(deleteOlderType)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">case</span>&nbsp;<span style=""color:#2b91af;"">DeleteOlderTypes</span>.Days:&nbsp;deleteOlder&nbsp;=&nbsp;<span style=""color:#2b91af;"">TimeSpan</span>.FromDays(value);&nbsp;<span style=""color:blue;"">break</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">case</span>&nbsp;<span style=""color:#2b91af;"">DeleteOlderTypes</span>.Hours:&nbsp;deleteOlder&nbsp;=&nbsp;<span style=""color:#2b91af;"">TimeSpan</span>.FromHours(value);&nbsp;<span style=""color:blue;"">break</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">case</span>&nbsp;<span style=""color:#2b91af;"">DeleteOlderTypes</span>.Mins:&nbsp;deleteOlder&nbsp;=&nbsp;<span style=""color:#2b91af;"">TimeSpan</span>.FromMinutes(value);&nbsp;<span style=""color:blue;"">break</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:blue;"">case</span>&nbsp;<span style=""color:#2b91af;"">DeleteOlderTypes</span>.Secs:&nbsp;deleteOlder&nbsp;=&nbsp;<span style=""color:#2b91af;"">TimeSpan</span>.FromSeconds(value);&nbsp;<span style=""color:blue;"">break</span>;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:green;"">//&nbsp;Call&nbsp;the&nbsp;BeginMaintainence&nbsp;function.&nbsp;It&nbsp;will&nbsp;run&nbsp;on&nbsp;a&nbsp;thread&nbsp;to&nbsp;do&nbsp;not&nbsp;block&nbsp;the&nbsp;main&nbsp;thread.</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=""color:#2b91af;"">HTTPCacheService</span>.BeginMaintainence(<span style=""color:blue;"">new</span>&nbsp;<span style=""color:#2b91af;"">HTTPCacheMaintananceParams</span>(deleteOlder,&nbsp;(<span style=""color:blue;"">ulong</span>)maxCacheSize));
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;});
&nbsp;&nbsp;&nbsp;&nbsp;}
 
<span style=""color:blue;"">&nbsp;&nbsp;&nbsp;&nbsp;#endregion</span>
}</pre>";
    #endregion
}
