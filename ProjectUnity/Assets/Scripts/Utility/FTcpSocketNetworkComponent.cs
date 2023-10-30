using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using SLua;

   
[CustomLuaClass]
public class FTcpSocketNetworkComponent : MonoBehaviour {

    [CustomLuaClass]
    public enum FProtocal
    {
        Connect = 1,    //连接服务器
        Exception,              //异常掉线
        Disconnect,             //正常断线  
        Timeout,
        Ping,
        GameData,
    }

    private object lockobj = new object();
    private Queue<KeyValuePair<FProtocal, FByteBuffer>> sEvents = new Queue<KeyValuePair<FProtocal, FByteBuffer>>();

    private FSuperSocket m_SuperSocket;
    public FSuperSocket LogicSocket
    {
        get {
            if (m_SuperSocket == null)
            {
                m_SuperSocket = new FSuperSocket(this);
            }
            return m_SuperSocket;
        }
    }

    void OnDestroy()
    {
        LogicSocket.Close();
		if (luaNetwork != null) {
			luaNetwork.Dispose ();
			luaNetwork = null;
		}
    }

    [DoNotToLua]
    public void AddEvent(FProtocal id, FByteBuffer data)
    {
        lock(lockobj)
        {
            sEvents.Enqueue(new KeyValuePair<FProtocal, FByteBuffer>(id, data));
        }
    }

	private LuaTable luaNetwork;
	public void SetMsgHandle(LuaTable _luaNet)
	{
		if (luaNetwork != null) {
			luaNetwork.Dispose ();
		}
		luaNetwork = _luaNet;
	}

    protected void CallMethod(string funcname,params object[] args)
    {
		if (null == luaNetwork)
            return;
		luaNetwork.safe_invoke_self (funcname, args);
    }

    /// <summary>
    /// 交给Command，这里不想关心发给谁。
    /// </summary>
    void Update()
    {
        lock (lockobj)
        {
            if (sEvents.Count > 0)
            {
                while (sEvents.Count > 0)
                {
                    KeyValuePair<FProtocal, FByteBuffer> _event = sEvents.Dequeue();
					CallMethod("OnReceiveMessage", new object[] { _event.Key, _event.Value });
                }
            }
        }
    }


    public void ConnectTo(string host, int port)
    {
        LogicSocket.ConnectTo(host, port);
    }

    public void Close()
    {
        LogicSocket.Close();
    }

	public int SendMessage(byte[] buffer)
    {
        return LogicSocket.Send(buffer);
    }

    public bool IsConnected
    {
        get
        {
            return LogicSocket.IsConnected;
        }
    }

    public void Ping(string ip)
    {
        new System.Threading.Thread(() =>
        {
            try
            {
                System.Net.NetworkInformation.Ping p = new System.Net.NetworkInformation.Ping();
                string data = "Hello!";
                byte[] buffer = System.Text.Encoding.ASCII.GetBytes(data);
                int timeout = 1000; // Timeout 时间，单位：毫秒  
                p.PingCompleted += new System.Net.NetworkInformation.PingCompletedEventHandler((object sender, System.Net.NetworkInformation.PingCompletedEventArgs e) =>
                {
                    try
                    {
                        if(e.Error != null)
                        {
                            FByteBuffer buffer2 = new FByteBuffer();
                            buffer2.WriteString(string.Format("Ping:{0},Error:{1}", ip,e.Error.Message));
                            AddEvent(FProtocal.Ping, new FByteBuffer(buffer2.ToBytes()));
                        }
                        System.Net.NetworkInformation.PingReply reply = e.Reply;
                        if (reply != null && reply.Status == System.Net.NetworkInformation.IPStatus.Success)
                        {
                            System.Text.StringBuilder sb = new System.Text.StringBuilder();
                            sb.AppendFormat("AcceptHost:{0}\n", reply.Address.ToString());
                            sb.AppendFormat("RoundTime:{0}\n", reply.RoundtripTime);
                            sb.AppendFormat("TTL:{0}", reply.Options.Ttl);
                            sb.AppendFormat("DontFragment:{0}", reply.Options.DontFragment);
                            sb.AppendFormat("Length:{0}", reply.Buffer.Length);
                            FByteBuffer buffer2 = new FByteBuffer();
                            buffer2.WriteString(sb.ToString());
                            AddEvent(FProtocal.Ping, new FByteBuffer(buffer2.ToBytes()));
                        }
                        else
                        {
                            FByteBuffer buffer2 = new FByteBuffer();
                            buffer2.WriteString(string.Format("Ping:{0},Cannot Reachable", ip));
                            AddEvent(FProtocal.Ping, new FByteBuffer(buffer2.ToBytes()));
                        }
                    }
                    catch (Exception ex)
                    {
                        FByteBuffer buffer2 = new FByteBuffer();
                        buffer2.WriteString(string.Format("Ping:{0},Error:{1}", ip, ex.Message));
                        AddEvent(FProtocal.Ping, new FByteBuffer(buffer2.ToBytes()));
                    }
                });
                p.SendAsync(ip, timeout, buffer, null);
            }
            catch (Exception ex)
            {
                FByteBuffer buffer2 = new FByteBuffer();
                buffer2.WriteString(string.Format("Ping:{0},Error:{1}", ip, ex.Message));
                AddEvent(FProtocal.Ping, new FByteBuffer(buffer2.ToBytes()));
            }
        }).Start();
    }

}
