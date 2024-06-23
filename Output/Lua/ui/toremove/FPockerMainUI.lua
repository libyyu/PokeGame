local FBaseUI = require "ui.FBaseUI"
local FGUITools = require "utility.FGUITools"

local l_instance = nil
local FPockerMainUI = FLua.Class(FBaseUI, "FPockerMainUI")
do
	local OBJPATH = 
	{
		BtnCreateRoom = "n4",
	}
	function FPockerMainUI.Instance()
		if not l_instance then
			l_instance = FPockerMainUI()
			l_instance.m_UnloadBundleWhenDestroy = true
			l_instance.m_TriggerGCWhenDestroy = true
		end
		return l_instance
	end

	function FPockerMainUI:ShowPanel(show)
		if show then
			if not self.m_panel then
				self:CreatePanel(ResPathReader.PokerMainUI)
			end
		else
			self:DestroyPanel()
		end
	end

	function FPockerMainUI:OnCreate()
		local btnCreateRoom = self:FindChildObj(OBJPATH.BtnCreateRoom)
		btnCreateRoom.onClick:Add(function()
			require "ui.FPokerTableUI".Instance():ShowPanel(true)
		end)
	end
end

return FPockerMainUI
