--filename: FNetwork.lua
--author: lidengfeng
--email: libyyu@qq.com
--time: 2017/2/19
--comment: 网络处理基础类
local FNetwork = FLua.Class("FNetwork")
do
	function FNetwork:_ctor()
		self.m_GoNetwork = nil
		self.m_Network = nil
		self.m_status = "broken"
		self.m_netName = ""
		self.m_ip = nil
		self.m_port = 0
	end

	function FNetwork:InitNetwork()
		if self.m_Network and not self.m_Network.isNil then
			return
		end
		self.m_GoNetwork = NewGameObject(self.m_netName)
		self.m_Network = self.m_GoNetwork:AddComponent(NetworkManager)
		self.m_Network:SetMsgHandle(self)
		DontDestroyOnLoad(self.m_GoNetwork)
	end

	function FNetwork:FinishWorking()
		self:Release()
	end

	function FNetwork:Connect()
		if self:isConnected() then
			warn(self.m_netName ..".Connect: Already Connected, Can not link again.")
			return
		elseif self.m_status == "connecting" then
			warn(self.m_netName .. ".Connect: Now is connecting, please waiting.")
			return
		end
		warn(self.m_netName .. ".Connect To " .. self.m_ip .. ":" .. self.m_port )
		self.m_status = "connecting"
		self.m_Network:ConnectTo(self.m_ip,self.m_port)
	end

	function FNetwork:ConnectTo(ip,port)
		self.m_ip = ip
		self.m_port = port
		self:Connect()
	end

	function FNetwork:isConnected()
		return self.m_status == "connected" and self.m_Network and not self.m_Network.isNil and self.m_Network.IsConnected
	end

	function FNetwork:Close()
		self.m_Network:Close()
		self.m_status = "broken"
	end

	function FNetwork:Release()
		self:Close()
		DestroyObject(self.m_GoNetwork)
		self.m_GoNetwork = nil
		self.m_Network = nil
	end

	function FNetwork:Ping(ip)
		self.m_Network:Ping(ip)
	end

	function FNetwork:Send(bytes)
		return self.m_Network:SendMessage(bytes)
	end

	function FNetwork:SendPB(pb_msg)
		local meta = message_common_pb.Message()
		print(".........meta", meta.type, meta)
		meta.message_type = pb_msg.type
		meta.message_body = pb_msg:SerializeToString()

		local msgbuf = meta:SerializeToString()
		local count = self.m_Network:SendPbMessage(msgbuf)
		warn("send bytes-count:",count, ", content:", meta)
	end

	function FNetwork:BytesToMessage(data)
		local meta = message_common_pb.Message()
		meta:ParseFromString(data)
		local msgId = meta.message_type
		local FPBHelper = require "pb.FPBHelper"
		local cls = FPBHelper.GetPbClass(msgId)
		local msg = cls()
		msg:ParseFromString(meta.message_body)
		return msg, msgId
	end

	function FNetwork:OnConnected()
		warn(self.m_netName .. ".OnConnected")
		self.m_status = "connected"
	end

	function FNetwork:OnTimeout()
		warn(self.m_netName .. ".OnTimeout")
		self.m_status = "broken"
		local content = StringReader.Get(3)
		MsgBox(self,content,"timeout",MsgBoxType.MBBT_OKCANCEL,function(_,ret)
			if ret == MsgBoxRetT.MBRT_OK then
				self:Connect()
			end
		end)
	end

	function FNetwork:OnDisconnect(err_code,err_msg)
	end

	function FNetwork:OnPing(buffer)
		local text = buffer:ReadString()
		warn(text)
	end

	function FNetwork:OnReceiveMessage(protocal,buffer)
		warn(self.m_netName .. ".OnReceiveMessage", protocal, buffer)
		local Protocal = FGame.Protocal
		if protocal == Protocal.Connect then
			self:OnConnected()
		elseif protocal == Protocal.Exception then
			self.m_status = "broken"
			self:OnDisconnect(buffer:ReadInt(), buffer:ReadString())
		elseif protocal == Protocal.Disconnect then
			self.m_status = "broken"
			self:OnDisconnect(0,buffer:ReadString())
		elseif protocal == Protocal.Timeout then
			self:OnTimeout()
		elseif protocal == Protocal.Ping then
			self:OnPing(buffer)
		elseif protocal == Protocal.GameData then
			self:OnGameData(buffer)
		end
		buffer:Close()
	end

	function FNetwork:OnGameData(buffer)
	end
end

return FNetwork