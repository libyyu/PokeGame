local FBaseUI = require "ui.FBaseUI"
local FGUITools = require "utility.FGUITools"

local l_instance = nil
local FPanelStartUI = FLua.Class(FBaseUI, "FPanelStartUI")
do
	local OBJPATH = 
	{
		Name = "login_panel/input_group/account/input_account",
		Passwd = "login_panel/input_group/password/input_password",
	}
	function FPanelStartUI.Instance()
		if not l_instance then
			l_instance = FPanelStartUI()
			l_instance.m_UnloadBundleWhenDestroy = true
			l_instance.m_TriggerGCWhenDestroy = true
		end
		return l_instance
	end

	function FPanelStartUI:ShowPanel(show)
		if show then
			if not self.m_panel then
				self:CreatePanel(ResPathReader.StartUI)
			end
		else
			self:DestroyPanel()
		end
	end

	function FPanelStartUI:OnCreate()
		self:FindChildObj("progressbar"):SetActive(false)

		self:FindChildObj("btnStart"):GetComponent("Button").onClick:AddListener(function()
			self:ShowBag()
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
