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
				--backgroundMusic:PlayBackgroundMusic(obj)
			--end
		end)

		self:EnterStartUI(function()
			require "ui.FGUIMan".Instance():CreateSimpleUI("Arts/UI/UILoading.prefab", function(panel)
				local slider = panel:FindChildObj("bg/Slider"):GetComponent("Slider")
				slider:AutoProgress(2, nil, 80)

				AsyncLoad("Arts/Prefabs/Scene/Environment_Prefab.prefab", function(asset)
					local goMap = Instantiate(asset)
					goMap.transform.localPosition = Vector3(0, 0, 0)
					goMap.transform.localScale = Vector3(1, 1, 1)

					local player = require "player.FHostPlayer"
					local p = player()
					p:Init({})
					self.m_HostPlayer = p
					slider:AutoProgress(1, nil, 100, function()
						panel:DestroyPanel()
					end)

					local FWaitingUI = require "ui.FWaitingUI"
					FWaitingUI.Instance():DestroyPanel()
					self.m_isGameLogic = true
				end)
			end)
		end)
	end

	function FGame:EnterStartUI(OnFinish)
		require "ui.FGUIMan".Instance():CreateSimpleUI("Arts/UI/UIStart.prefab", nil, function(panel, go)
			panel:DestroyPanel()

			OnFinish()
		end)
	end

	function FGame:LeaveGameLogic()
		self.m_isGameLogic = false
	end
end