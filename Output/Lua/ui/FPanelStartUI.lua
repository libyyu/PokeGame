local FPanelBaseUI = require "ui.FPanelBaseUI"
local FGUITools = require "utility.FGUITools"

local l_instance = nil
local FPanelStartUI = FLua.Class(FPanelBaseUI, "FPanelStartUI")
do
	function FPanelStartUI.Instance()
		if not l_instance then
			l_instance = FPanelStartUI()
			--l_instance.m_UnloadBundleWhenDestroy = true
			--l_instance.m_TriggerGCWhenDestroy = true
		end
		return l_instance
	end

	function FPanelStartUI:GetResPath()
		return ResPathReader.StarupUI
	end

	function FPanelStartUI:OnCreate()
		-- self:FindChildObj("progressbar"):SetActive(false)

		-- self:FindChildObj("btnStart"):GetComponent("Button").onClick:AddListener(function()
		-- 	self:ShowBag()
		-- end)
		local pb = self:RequireFind("progressBar")
		print("pb", pb)
		pb.value = 0
		pb:AutoProgress(2, nil, 100, function()
			print("load finished")
			theGame:EnterGameLogic()
		end)
	end

	function FPanelStartUI:ShowMain()
		require "ui.FPanelMainUI".Instance():ShowPanel(true, nil, function(panel)
			self:DestroyPanel()
		end)
	end

	function FPanelStartUI:ShowBag()
		require "ui.FGUIMan".Instance():CreateSimpleUI(ResPathReader.BagBtnUI, function(panel)
			print('panel:FindChildObj("BagBtn")', panel:FindChildObj("BagBtn"))
			panel:FindChildObj("BagBtn").onClick:Add(function()
				print("bag btn click")
				require "ui.FGUIMan".Instance():CreateSimpleUI(ResPathReader.BagMainUI, function(bag)
					panel:DestroyPanel()
				end)
			end)

			self:DestroyPanel()
		end)
	end

	-- function FPanelStartUI:OnClick(go)
	-- 	if go.name == "btnStart" then
	-- 		--theGame:EnterGameLogic()		
	-- 		self:ShowBag()
	-- 	end
	-- end

	function FPanelStartUI:AutoProgress(time, start, to, onfinish)
		self:FindChildObj("progressbar"):SetActive(true)
		local slider = self:FindChildObj("progressbar"):GetComponent("Slider")
		slider:AutoProgress(time, start, to, onfinish)
	end

end

return FPanelStartUI
