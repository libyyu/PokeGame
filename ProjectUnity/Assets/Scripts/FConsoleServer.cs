#if !UNITY_WEBGL
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System;
using System.Threading;
using UnityEngine;

namespace FConsole
{
	public class FSocketServer
	{
		Socket serverSocket; 
		int port = 8815;
		bool disposed;
		struct MsgStruct
		{
			public Socket client;
			public FSocketServer server;
		};

		public void CreateAndListen(int port_ = 8815)
		{
			port = port_;
			//服务器IP地址  
			IPAddress ip = IPAddress.Parse("127.0.0.1");  
			serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);  
			serverSocket.Bind(new IPEndPoint(ip, port));  //绑定IP地址：端口  
			serverSocket.Listen(10);    //设定最多10个排队连接请求
			Debug.Log(string.Format("Start Listen At {0}:{1}", ip.ToString(), port));

			//通过Clientsoket发送数据  
			Thread myThread = new Thread(ListenClientConnect);  
			myThread.Start(this);  
		}
		static void ListenClientConnect(object o)  
		{  
			FSocketServer p = (FSocketServer)o;
			while (!p.disposed)  
			{  
				Socket clientSocket = p.serverSocket.Accept();  
				p.SendString(clientSocket,"hello client");  
				//获取客户端的IP和端口
				string ip = clientSocket.RemoteEndPoint.ToString();
				Debug.Log ("New Connect " + ip);
				MsgStruct sdata = new MsgStruct ();
				sdata.client = clientSocket;
				sdata.server = p;
				Thread receiveThread = new Thread(ReceiveMessage);  
				receiveThread.Start(sdata); 
			}  
		}  
		public void Close()
		{
			try{
				Debug.Log("Close...");
				disposed = true;
				serverSocket.Shutdown(SocketShutdown.Both);  
				serverSocket.Close(); 
			}
			catch(Exception e) {
				Debug.Log (e.Message);
			}
		}

		static byte[] StringToBytes(string s)
		{
			return System.Text.Encoding.Default.GetBytes (s);
		}
		static string BytesToString(byte[] buf, int len)
		{
			return System.Text.Encoding.Default.GetString (buf, 0, len);
		}

		int SendString(Socket sock, string content)
		{
			byte[] data = StringToBytes (content);
			return sock.Send(data, data.Length, 0);
		}
		static void ReceiveMessage(object o) 
		{
			byte[] result = new byte[1024];  
			MsgStruct d = (MsgStruct)o;
			Socket myClientSocket = d.client;
			while (true)  
			{  
				try  
				{  
					if(d.server.disposed)
						return;
					//通过clientSocket接收数据  
					int receiveNumber = myClientSocket.Receive(result);  
					if(receiveNumber <=0)
					{
							//myClientSocket.Shutdown(SocketShutdown.Both);  
							myClientSocket.Close();  
							return;
					}
					string content = BytesToString(result, receiveNumber);
					Debug.Log(content);
					HandCommand(content);
				}  
				catch(Exception ex)  
				{  
					Debug.Log(ex.Message);  
					myClientSocket.Shutdown(SocketShutdown.Both);  
					myClientSocket.Close();  
					break;  
				}  
			}  
		}
		static void HandCommand(string content)
		{
				
		}
	}
}

#endif