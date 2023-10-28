--filename: FLogicSession.lua
--author: lidengfeng
--email: libyyu@qq.com
--time: 2017/2/19
--comment: 游戏逻辑网络处理类
local FNetwork = require "network.FNetwork"
local l_instance = nil
local FLogicSession = FLua.Class(FNetwork, "FLogicSession")
do
	function FLogicSession:__constructor()
		self.m_UserInfo = nil
		self.m_netName = "LogicSession"
	end
	function FLogicSession.Instance()
		if not l_instance then
			l_instance = FLogicSession()
		end
		return l_instance
	end

	function FLogicSession:ConnectTo(ip,port,name,passwd)
		self.m_UserInfo = {name=name,passwd=passwd,}
		FNetwork.ConnectTo(self,ip,port)
	end

	function FLogicSession:OnConnected()
		FNetwork.OnConnected(self)
		local name = self.m_UserInfo.name
		local passwd = self.m_UserInfo.passwd
		local msg = message_client_pb.TestMessage()
		self:SendPB(msg)
	end

	function FLogicSession:OnGameData(buffer)
		warn("FLogicSession:OnGameData",buffer)
		local FPBHelper = require "pb.FPBHelper"
		local bytes = buffer:ReadBytesString()
		local msg, msgId = self:BytesToMessage(bytes)
		print(msg, FPBHelper.GetPbName(msgId))
		FireEvent(FPBHelper.GetPbName(msgId),msg)
	end

	function FLogicSession:OnDisconnect(err_code, err_msg)
		local content = err_code == 0 and StringReader.Get(2) or StringReader.Get(1)
		MsgBox(self,content,reason,MsgBoxType.MBBT_OKCANCEL,function(_,ret)
			if ret == MsgBoxRetT.MBRT_OK then
				self:Connect()
			else
				warn("Test Enter Game")
				theGame:EnterGameLogic()
			end
		end)
	end
end

return FLogicSession