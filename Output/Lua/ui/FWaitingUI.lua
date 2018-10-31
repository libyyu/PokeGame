local FBaseUI = require "ui.FBaseUI"
local FGUITools = require "utility.FGUITools"

local l_instance = nil
local FWaitingUI = FLua.Class("FWaitingUI",FBaseUI)
do
	local OBJPATH = 
	{
		text = "desc",	
	}

	function FWaitingUI:_ctor()
		self.context = ""
	end

	function FWaitingUI.Instance()
		if not l_instance then
			l_instance = FWaitingUI.new()
		end
		return l_instance
	end

	function FWaitingUI:ShowTip(tip)
		if not self.m_panel then
			self.context = tip
			self:CreatePanel(ResPathReader.WaitingUI)
		else
			self:FillText(tip)
		end
	end

	function FWaitingUI:GetContext()
		return self.context
	end

	function FWaitingUI:FillText(tip)
		self.context = tip
		if not self.m_panel then
			return
		end
		if not self.context then
			return
		end
		local label = self:FindChildObj(OBJPATH.text)
		FGUITools.setText(label,tip)
	end

	function FWaitingUI:OnCreate()
		self:FillText(self.context)
	end
end

return FWaitingUI
