local FPlayer = require "player.FPlayer"
local FHostPlayer = FLua.Class(FPlayer, "FHostPlayer")

do
	function FHostPlayer:__constructor()
		self.m_IsHost = true
	end

	function FHostPlayer:Init(info)
		self.m_InfoData = info
		self:Create("TestProjName/Model/Npc_boy/villarger_B_Boy/Prefabs/Villager_B_Boy_prefab.prefab")
	end

	function FHostPlayer:OnLoaded(obj)
		obj.tag = "HostPlayer"
		obj.transform.localPosition = Vector3(80.45,10.4,16.14)
		obj.transform.localScale = Vector3(3,3,3)
		self:Play("Idle",UnityEngine.WrapMode.Loop)
		theGame.m_MainCam:GetComponent("FSmootFollow").target = obj.transform
		self.m_IsReady = true
	end
end


return FHostPlayer
