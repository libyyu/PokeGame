using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityWebSocket;
using SLua;

[CustomLuaClass]
public class FWebSocket : WebSocket
{
    List<LuaFunction> _on_open;
    List<LuaFunction> _on_close;
    List<LuaFunction> _on_error;
    List<LuaFunction> _on_message;
    public FWebSocket(string address): base(address)
    {
    }

    ~FWebSocket()
    {

    }

    public void Cleanup()
    {
        _on_open.Clear();
        _on_close.Clear();
        _on_error.Clear();
        _on_message.Clear();
    }

    public void BindOnOpenCallback(LuaFunction callback) 
    {
        _on_open.Add(callback);
    }
    public void UnBindOnOpenCallback(LuaFunction callback)
    {
        _on_open.Remove(callback);
        callback.Dispose();
    }

    public void BindOnCloseCallback(LuaFunction callback)
    {
        _on_close.Add(callback);
    }
    public void UnBindOnCloseCallback(LuaFunction callback)
    {
        _on_close.Remove(callback);
        callback.Dispose();
    }

    public void BindOnErrorCallback(LuaFunction callback)
    {
        _on_error.Add(callback);
    }
    public void UnBindOnErrorCallback(LuaFunction callback)
    {
        _on_error.Remove(callback);
        callback.Dispose();
    }

    public void BindOnMessageCallback(LuaFunction callback)
    {
        _on_message.Add(callback);
    }
    public void UnBindOnMessageCallback(LuaFunction callback)
    {
        _on_message.Remove(callback);
        callback.Dispose();
    }


}
