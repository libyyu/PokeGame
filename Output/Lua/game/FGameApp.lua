
local FGame = FLua.ForwardClass("FGame")
do
	function FGame:OnRun()
		self:EnterLoginStage()
	end
	
	-- function FGame:EnterLoginStage()
	-- 	self:InitLoginInfo()
	-- 	local login = require "ui.FLoginUI"
	-- 	login.Instance():ShowPanel(true)

	-- 	local musicGo = NewGameObject("BackgroundMusic")
	-- 	musicGo:AddComponent(LuaHelper.GetClsType("FBackgroundMusic"))
	-- 	DontDestroyOnLoad(musicGo)
	-- 	--测试背景音
	-- 	AsyncLoad(ResPathReader.BackgroundMusic, function(obj)
	-- 		warn("=======",obj)
	-- 		--if obj and not obj.isNil then
	-- 			local backgroundMusic = musicGo:GetComponent(LuaHelper.GetClsType("FBackgroundMusic"))
	-- 			backgroundMusic:PlayBackgroundMusic(obj)
	-- 		--end
	-- 	end)
	-- end
	-- function FGame:LeaveLoginState()
	-- 	local login = require "ui.FLoginUI"
	-- 	login.Instance():ShowPanel(false)
	-- end

	function FGame:EnterLoginStage()
		require "ui.FPanelStartUI".Instance():ShowPanel(true)
	end
	function FGame:LeaveLoginState()
		require "ui.FPanelStartUI".Instance():ShowPanel(false)
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
		self.m_isGameLogic = true
		require "ui.FPanelMainUI".Instance():ShowPanel(true, nil, function(panel)
			self:LeaveLoginState()
			self:ResumeBackgroundMusic()
		end)
	end

	function FGame:LeaveGameLogic()
		self.m_isGameLogic = false
	end
	
end
