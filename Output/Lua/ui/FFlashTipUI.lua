local FBaseUI = require "ui.FBaseUI"
local FGUITools = require "utility.FGUITools"

local l_instance = nil
local FFlashTipUI = FLua.Class("FFlashTipUI",FBaseUI)
do
	local OBJPATH = 
	{
		text = "Text",
	}

	function FFlashTipUI:_ctor()
		self.context = ""
	end

	function FFlashTipUI.Instance()
		if not l_instance then
			l_instance = FFlashTipUI.new()
		end
		return l_instance
	end

	function FFlashTipUI:ShowTip(tip)
		if not self.m_panel then
			self.context = tip
			self:CreatePanel(ResPathReader.FlashTipUI)
		else
			self:FillText(tip)
		end
	end

	function FFlashTipUI:GetContext()
		return self.context
	end

	function FFlashTipUI:FillText(tip)
		self.context = tip
		if not self.m_panel then
			return
		end
		local label = self:FindChildObj(OBJPATH.text)
		FGUITools.setText(label,tip)
	end

	function FFlashTipUI:OnCreate()
		self:FillText(self.context)

		local playTween = self.m_panel:GetComponent("UIPlayTween")
		playTween:Play(true)
	end
end

return FFlashTipUI
