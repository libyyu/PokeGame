using UnityEngine;
using System.Collections;
using SuperSocket.ProtoBase;
using System;
using FGame;
using System.IO;

namespace SuperSocket.ClientEngine
{
    public class FSuperSocket : EasyClient
    {
        NetworkManager NetMgr;
        public FSuperSocket(NetworkManager mgr)
        {
            NetMgr = mgr;
            this.Initialize<FPackageInfo>(new FReceiveFilter(), HandlePackage);
            this.Connected += new EventHandler(onConnect);
            this.Closed += new EventHandler(onClosed);
            this.Error += new EventHandler<ErrorEventArgs>(onError);
        }

        public void ConnectTo(string ip, int port)
        {
            this.BeginConnect(new System.Net.IPEndPoint(System.Net.IPAddress.Parse(ip), port));
        }

        public int Send(byte[] buffer)
        {
            MemoryStream ms = null;
            using (ms = new MemoryStream())
            {
                ms.Position = 0;
                BinaryWriter writer = new BinaryWriter(ms);
                ushort msglen = (ushort)buffer.Length;
                writer.Write(msglen);
                writer.Write(buffer);
                writer.Flush();
                byte[] payload = ms.ToArray();
                return Send(payload, 0, payload.Length);
            }
			//return Send (buffer, 0, buffer.Length);
        }

        protected int Send(byte[] buffer,int offset,int length)
        {
            Send(new ArraySegment<byte>(buffer, 0, length));
			return length;
        }

        void onConnect(object sender, EventArgs arg)
        {
            if (null != NetMgr) NetMgr.AddEvent(Protocal.Connect, new ByteBuffer());
        }   

        void onClosed(object sender,EventArgs arg)
        {
			if (null != NetMgr) {
				ByteBuffer buffer = new ByteBuffer();
				buffer.WriteString("Socket Link Is Broken!");
				NetMgr.AddEvent (Protocal.Disconnect, new ByteBuffer(buffer.ToBytes()));
			}
            else
				LogUtil.LogWarning("Socket Link Is Broken!");
        }

        void onError(object sender, ErrorEventArgs e)
        {
			System.Net.Sockets.SocketException ex = e.Exception as System.Net.Sockets.SocketException;
            if (null != NetMgr)
            {
                ByteBuffer buffer = new ByteBuffer();
				buffer.WriteInt (ex.ErrorCode);
                buffer.WriteString(ex.Message);
                NetMgr.AddEvent(Protocal.Exception, new ByteBuffer(buffer.ToBytes()));
            }
			else
				LogUtil.LogWarning("Socket Error {0}:{1}",ex.ErrorCode,ex.Message);
        }

        void onReceive(object sender, byte[] data)
        {
            if (null != NetMgr)
            {
				ByteBuffer buffer = new ByteBuffer();
				buffer.WriteBytes (data);
				NetMgr.AddEvent(Protocal.GameData, new ByteBuffer(buffer.ToBytes()));
				buffer.Close ();
            }
            else
                LogUtil.Log("onReceive:{0}", GameUtil.ToHexString(data));
        }
        void HandlePackage(FPackageInfo package)
        {
            //if(package.Body != null)
                onReceive(this, package.Body);
        }

        /// <summary>
        /// FPackageInfo
        /// </summary>
        class FPackageInfo : IPackageInfo
        {
            public byte[] Body { get; protected set; }

            public FPackageInfo(byte[] body)
            {
                Body = body;
            }
        }
        /// <summary>
        /// FReceiveFilter
        /// </summary>
        class FReceiveFilter : FixedHeaderReceiveFilter<FPackageInfo>
        {
            const int H_SIZE = sizeof(ushort);
            public FReceiveFilter() : base(H_SIZE) { }
            public override FPackageInfo ResolvePackage(IBufferStream bufferStream)
            {
                var PackageTogalSize = (int)(bufferStream.Length);
                bufferStream.Skip(H_SIZE);

                byte[] data = new byte[PackageTogalSize - H_SIZE];
                bufferStream.Read(data, 0, PackageTogalSize - H_SIZE);

                return new FPackageInfo(data);
            }

            protected override int GetBodyLengthFromHeader(IBufferStream bufferStream, int length)
            {
                byte[] lenbuffer = new byte[length];
                bufferStream.Read(lenbuffer, 0, length);
                int nLen = BitConverter.ToInt16(lenbuffer, 0);
                return nLen;
            }
        }
    }

#if TEST_EASYSOCKET
    public class FTestSuperSocket : FSuperSocket
    {
        public FTestSuperSocket() : base(null) {

            this.Connected += new EventHandler(OnConnectSuccess);
        }

        void OnConnectSuccess(object sender, EventArgs arg)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            System.IO.BinaryWriter writer = new System.IO.BinaryWriter(ms);
            writer.Write((short)2);
            writer.Write("Hello");

            Send(new ArraySegment<byte>(ms.ToArray()));
        }
    }
#endif
}
