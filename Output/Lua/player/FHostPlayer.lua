local FPlayer = require "player.FPlayer"
local FHostPlayer = FLua.Class(FPlayer, "FHostPlayer")

do
	function FHostPlayer:__constructor()
		self.m_IsHost = true
	end

	function FHostPlayer:Init(info)
		self.m_InfoData = info
		self:Create("Arts/Prefabs/Player/Player_CC.prefab")
	end

	function FHostPlayer:OnLoaded(obj)
		obj.tag = "HostPlayer"
		obj.transform.localPosition = Vector3(0, 0, 0)
		obj.transform.localScale = Vector3(1, 1, 1)
		--self:Play("Idle",UnityEngine.WrapMode.Loop)
		self.m_IsReady = true
	end
end


return FHostPlayer
