local FGame = FLua.ForwardClass("FGame")
do
	function FGame:OnRun()
		self:EnterGameLogic()
	end

	function FGame:EnterGameLogic()
		local musicGo = NewGameObject("BackgroundMusic")
		local backgroundMusic = musicGo:AddComponent(LuaHelper.GetClsType("FBackgroundMusic"))
		DontDestroyOnLoad(musicGo)
		--测试背景音
		AsyncLoad(ResPathReader.BackgroundMusic, function(obj)
			warn("=======",obj)
			--if obj and not obj.isNil then
				backgroundMusic:PlayBackgroundMusic(obj)
			--end
		end)
		musicGo:TestLuaFunc()

		local FWaitingUI = require "ui.FWaitingUI"
		FWaitingUI.Instance():DestroyPanel()
		self.m_isGameLogic = true
		--加载世界
		AsyncLoad("TestProjName/Model/x1.prefab", function(asset)
			local goMap = Instantiate(asset)
			goMap.transform.localPosition = Vector3(-121.6,-44.2,-241.3)
			goMap.transform.localScale = Vector3(1, 1, 1)

			-- local player = require "player.FHostPlayer"
			-- local p = player()
			-- p:Init({})
			-- self.m_HostPlayer = p
		end)

		require "ui.FGUIMan".Instance():CreateSimpleUI("TestProjName/UI/Level.prefab", nil, function(panel, go)
			require "ui.FGUIMan".Instance():CreateSimpleUI("ProjIdiom/UI/UIStart.prefab", function(panel)
				print(panel.m_panel.transform)
				print(panel.m_panel.transform.localPosition)
				print(panel.m_panel.transform.localScale)
				print(panel.m_panel.transform.rect)
			end)
		end)
	end
	function FGame:LeaveGameLogic()
		self.m_isGameLogic = false
	end
end