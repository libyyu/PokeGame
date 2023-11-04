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
	end

	function FPanelStartUI:OnClick(go)
		if go.name == "btnStart" then
			theGame:EnterGameLogic()		
		end
	end

	function FPanelStartUI:AutoProgress(time, start, to, onfinish)
		self:FindChildObj("progressbar"):SetActive(true)
		local slider = self:FindChildObj("progressbar"):GetComponent("Slider")
		slider:AutoProgress(time, start, to, onfinish)
	end

end

return FPanelStartUI
