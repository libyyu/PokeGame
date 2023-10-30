mergeInto(LibraryManager.library, {
  //输出日志到浏览器console
  logToWeb:function(str) 
  {
      console.log(UTF8ToString(str)); 
  },
  isRunEnvWX:function()
  {
    return typeof wx === "object";
  },
  getStreamingAssetsUrl:function()
  {
    var streamingAssetsUrl = "";
    if(typeof GameGlobal === "object" && typeof GameGlobal.manager === "object" && typeof GameGlobal.manager.streamingAssetsUrl == 'string') {
      streamingAssetsUrl = GameGlobal.manager.streamingAssetsUrl;
    }
    var length = lengthBytesUTF8(streamingAssetsUrl) + 1;
    var buffer = _malloc(length);
    stringToUTF8(streamingAssetsUrl, buffer, length);
    return buffer;
  },
  getAssetBundleManifestName:function()
  {
    var ret = "StreamingAssets";
    if(typeof GameGlobal === "object" && typeof GameGlobal.manager === "object" && typeof GameGlobal.manager.assetBundleManifestName == 'string') {
      ret = GameGlobal.manager.assetBundleManifestName;
    }
    var length = lengthBytesUTF8(ret) + 1;
    var buffer = _malloc(length);
    stringToUTF8(ret, buffer, length);
    return buffer;
  },
  callJSMethod:function(method, jsonStr)
  {
    var M;
    if (typeof GameGlobal === "object") {
      M = GameGlobal;
    }
    else {
      M = unityFramework;
    }
    if(typeof M === "object" && typeof M.callJSMethod === 'function'){
      var m = UTF8ToString(method);
      var a = UTF8ToString(jsonStr);
      var ret = M.callJSMethod(m, a);
      if(typeof ret === 'string') {
        var length = lengthBytesUTF8(ret) + 1;
        var buffer = _malloc(length);
        stringToUTF8(ret, buffer, length);
        return buffer;
      }
    } else {
      console.log(UTF8ToString(method) , " method not found");
    }
    return null;
  }
});