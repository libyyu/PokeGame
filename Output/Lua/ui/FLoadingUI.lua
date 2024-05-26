local FBaseUI = require "ui.FBaseUI"
local FGUITools = require "utility.FGUITools"

local l_instance = nil
local FLoadingUI = FLua.Class(FBaseUI, "FLoadingUI")
do
	local OBJPATH = 
	{
		progress = "load_progress",
		tip = "load_tip/Text",
	}
	function FLoadingUI:__constructor()
		self.m_progress = nil
		self.m_tip = nil
	end

	function FLoadingUI.Instance()
		if not l_instance then
			l_instance = FLoadingUI()
		end
		return l_instance
	end

	function FLoadingUI:ShowPanel(show)
		if show then
			if not self.m_panel then
				self:CreatePanel(ResPathReader.LoadingUI)
			end
		else
			self:DestroyPanel()
		end
	end

	function FLoadingUI:OnCreate()		
		-- self.m_progress = self:FindChildObj(OBJPATH.progress):GetComponent("Slider")
		-- self.m_tip = self:FindChildObj(OBJPATH.tip)

		-- LuaTimer.Add(0,1,function(t,b)
		-- 	if self.m_panel then
		-- 		self.m_progress.value = self.m_progress.value + 0.5*10/100
		-- 		FGUITools.setText(self.m_tip,"已加载" .. ("%d%%"):format(self.m_progress.value*100))
		-- 		if self.m_progress.value >= 1.0 then
		-- 			return false
		-- 		else
		-- 			return true
		-- 		end
		-- 	else
		-- 		return false
		-- 	end
		-- end)
	end

	function FLoadingUI:AutoProgress(time, start, to, onfinish)
		if not self.m_panel and not self.m_loading then
			self:AttachCreateFunc(function()
				self:FindChildObj("bg/Slider"):SetActive(true)
				local slider = self:FindChildObj("bg/Slider"):GetComponent("Slider")
				slider:AutoProgress(time, start, to, onfinish)	
			end)
			self:ShowPanel(true)
		elseif self.m_panel then
			self:FindChildObj("bg/Slider"):SetActive(true)
			local slider = self:FindChildObj("bg/Slider"):GetComponent("Slider")
			slider:AutoProgress(time, start, to, onfinish)
		end
	end
end

return FLoadingUI
