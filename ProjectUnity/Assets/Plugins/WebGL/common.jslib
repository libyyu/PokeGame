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
  }
});