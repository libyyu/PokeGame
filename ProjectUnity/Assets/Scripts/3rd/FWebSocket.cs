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


    EventHandler<OpenEventArgs> e1 = null;
    EventHandler<CloseEventArgs> e2 = null;
    EventHandler<ErrorEventArgs> e3 = null;
    EventHandler<MessageEventArgs> e4 = null;
    public FWebSocket(string address): base(address)
    {
        e1 = new EventHandler<OpenEventArgs>(_OnSocketOpen);
        e2 = new EventHandler<CloseEventArgs>(_OnSocketClose);
        e3 = new EventHandler<ErrorEventArgs>(_OnSocketError);
        e4 = new EventHandler<MessageEventArgs>(_OnSocketMessage);

        OnOpen += e1;
        OnClose += e2;
        OnError += e3;
        OnMessage += e4;
    }

    ~FWebSocket()
    {
        OnOpen -= e1;
        OnClose -= e2;
        OnError -= e3;
        OnMessage -= e4;
    }

    private void _OnSocketOpen(object sender, OpenEventArgs e)
    {
        foreach(LuaFunction func in _on_open)
        {
            func.call();
        }
    }
    private void _OnSocketClose(object sender, CloseEventArgs e)
    {
        foreach(LuaFunction func in _on_close)
        {
            func.call(e.Code, e.Reason);
        }
    }
    private void _OnSocketError(object sender, ErrorEventArgs e) 
    {
        foreach(LuaFunction func in _on_error)
        {
            func.call(e.Message);
        }
    }
    private void _OnSocketMessage(object sender, MessageEventArgs e) 
    {
        foreach(LuaFunction func in _on_message)
        {
            func.call(e);
        }
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
    }

    public void BindOnCloseCallback(LuaFunction callback)
    {
        _on_close.Add(callback);
    }
    public void UnBindOnCloseCallback(LuaFunction callback)
    {
        _on_close.Remove(callback);
    }

    public void BindOnErrorCallback(LuaFunction callback)
    {
        _on_error.Add(callback);
    }
    public void UnBindOnErrorCallback(LuaFunction callback)
    {
        _on_error.Remove(callback);
    }

    public void BindOnMessageCallback(LuaFunction callback)
    {
        _on_message.Add(callback);
    }
    public void UnBindOnMessageCallback(LuaFunction callback)
    {
        _on_message.Remove(callback);
    }


}
