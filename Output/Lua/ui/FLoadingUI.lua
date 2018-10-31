local FBaseUI = require "ui.FBaseUI"
local FGUITools = require "utility.FGUITools"

local l_instance = nil
local FLoadingUI = FLua.Class("FLoadingUI",FBaseUI)
do
	local OBJPATH = 
	{
		progress = "n15",
		tip = "tip",
	}
	function FLoadingUI:_ctor()
		self.m_progress = nil
		self.m_tip = nil
		self.callback = nil
	end

	function FLoadingUI.Instance()
		if not l_instance then
			l_instance = FLoadingUI.new()
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
		self.m_progress = self:FindChildObj(OBJPATH.progress)
		self.m_tip = self:FindChildObj(OBJPATH.tip)
		self.m_progress.value = 0

		LuaTimer.Add(0,1,function(t,b)
			if self.m_panel then
				self.m_progress.value = self.m_progress.value + 0.5*10/100
				FGUITools.setText(self.m_tip,"已加载" .. ("%d%%"):format(self.m_progress.value*100))
				if self.m_progress.value >= 1.0 then
					if self.callback then
						self.callback()
						self.callback = nil
					end
					return false
				else
					return true
				end
			else
				return false
			end
		end)
	end

	function FLoadingUI:StartLoading(callback)
		self.callback = callback
		self:ShowPanel(true)
	end
end

return FLoadingUI
