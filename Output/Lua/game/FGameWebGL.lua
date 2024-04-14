
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

	function FGame:LoadHostPlayer()
		local player = require "player.FHostPlayer"
		local p = player()
		p:Init({ResPath="Arts/Prefabs/Player/Player_CC.prefab"})
		p:Load(function()
			local panel = require "ui.FPanelStartUI".Instance()
			panel:AutoProgress(1, nil, 100, function()
				panel:DestroyPanel()

				self:ResumeBackgroundMusic()

				require "ui.FGUIMan".Instance():CreateSimpleUI("Assets/Arts/UI/UIGameing.prefab", function(_)
				end)
			end)
		end)
		self.m_HostPlayer = p
	end

	function FGame:EnterWorld(cb)
		local FWorld = require "world.FWorld"
		self.m_world = FWorld()
		self.m_world:Init({})
		self.m_world:Load(cb)

		self.m_isGameLogic = true
	end

	function FGame:EnterGameLogic()
		self:LeaveLoginState()
		
		local panel = require "ui.FPanelStartUI".Instance()
		panel:AutoProgress(2, 0, 80)

		self:EnterWorld(function()
			self:LoadHostPlayer()
		end)
	end

	function FGame:LeaveGameLogic()
		self.m_isGameLogic = false
	end
end