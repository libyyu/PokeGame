local FBaseUI = require "ui.FBaseUI"
local FGUITools = require "utility.FGUITools"

local l_instance = nil
local FPockerTableUI = FLua.Class("FPockerTableUI",FBaseUI)
do
	local OBJPATH = 
	{
		CardList = "n1/CardList",
	}
	function FPockerTableUI.Instance()
		if not l_instance then
			l_instance = FPockerTableUI.new()
			l_instance.m_UnloadBundleWhenDestroy = true
			l_instance.m_TriggerGCWhenDestroy = true
		end
		return l_instance
	end

	function FPockerTableUI:ShowPanel(show)
		if show then
			if not self.m_panel then
				self:CreatePanel(ResPathReader.PokerTableUI)
			end
		else
			self:DestroyPanel()
		end
	end

	function FPockerTableUI:OnCreate()
		local gList = self:FindChildObj(OBJPATH.CardList)
		warn("gList", gList)
		gList.itemRenderer = function(index, obj) self:OnItemRenderer(index, obj) end
		gList.numItems = 17
	end

	function FPockerTableUI:OnItemRenderer(index, obj)
		print(index, obj, obj:GetChild("n1"))
		local loader = obj:GetChild("n1")
		loader.icon = FairyGUI.UIPackage.GetItemURL("Common", "1_13")
	end
end

return FPockerTableUI
