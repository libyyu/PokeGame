local FGame = FLua.ForwardClass("FGame")
do
	function FGame:OnRun()
		self:EnterLoginStage()
	end

	function FGame:EnterLoginStage()
		require "ui.FPanelStartUI".Instance():ShowPanel(true)
	end
	function FGame:LeaveLoginState()
	end

	function FGame:EnterGameLogic()
		self:LeaveLoginState()
		
		local panel = require "ui.FPanelStartUI".Instance()
		panel:AutoProgress(2, 0, 80)

		AsyncLoad(ResPathReader.MainWorld, function(asset)
			local goMap = Instantiate(asset)
			goMap.transform.localPosition = Vector3(0, 0, 0)
			goMap.transform.localScale = Vector3(1, 1, 1)

			local player = require "player.FHostPlayer"
			local p = player()
			p:Init({ResPath="Arts/Prefabs/Player/Player_CC.prefab"})
			p:Load(function()
				self.m_isGameLogic = true
				panel:AutoProgress(1, nil, 100, function()
					panel:DestroyPanel()

					self:ResumeBackgroundMusic()
				end)
			end)
			self.m_HostPlayer = p
		end)
	end

	function FGame:LeaveGameLogic()
		self.m_isGameLogic = false
	end
end