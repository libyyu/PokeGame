--filename: FUpdateSession.lua
--author: lidengfeng
--email: libyyu@qq.com
--time: 2017/2/19
--comment: 游戏更新处理类
local FNetwork = require "network.FNetwork"
local l_instance = nil
local FUpdateSession = FLua.Class(FNetwork, "FUpdateSession")
do
	function FUpdateSession:__constructor()
		self.m_netName = "UpdateSession"
		self.m_VersionInfo = nil
		self.m_PatchesInfo = nil
		self.m_isDone = false
	end
	function FUpdateSession.Instance()
		if not l_instance then
			l_instance = FUpdateSession()
		end
		return l_instance
	end

	function FUpdateSession:OnConnected()
		FNetwork.OnConnected(self)
		local msg = message_common_pb.DirInfo()
		self:SendPB(msg)
	end

	function FUpdateSession:OnGameData(buffer)
		local bytes = buffer:ReadBytesString()
		local msg = self:BytesToMessage(bytes)
		self.m_VersionInfo = msg.version
		self.m_PatchesInfo = msg.patches
		self.m_isDone = true
	end

	function FUpdateSession:OnDisconnect(err_code, err_msg)
		warn("FUpdateSession.OnDisconnect",err_code, err_msg)
		self.m_isDone = true
	end

	function FUpdateSession:IsDone()
		return self.m_isDone
	end

	function FUpdateSession:Reset()
		self.m_isDone = false
	end
end

return FUpdateSession