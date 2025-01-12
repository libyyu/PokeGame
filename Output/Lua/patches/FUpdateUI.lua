local FPanelBaseUI = require "ui.FPanelBaseUI"
local FGUITools = require "utility.FGUITools"

local l_instance = nil
local FUpdateUI = FLua.Class(FPanelBaseUI, "FUpdateUI")
do
	local OBJPATH = 
	{
		progress = "load_progress",
		tip = "load_tip/Text",
		localversion = "local_version/version",
		remoteversion = "remote_version/version",
	}
	function FUpdateUI:__constructor()
		self.m_progress = nil
		self.m_tip = nil
		self.m_localversion = nil
		self.m_remoteversion = nil
		self.localverionVal = "--"
		self.remoteverionVal = "--"
	end

	function FUpdateUI.Instance()
		if not l_instance then
			l_instance = FUpdateUI()
		end
		return l_instance
	end

	function FUpdateUI:ShowPanel(show)
		if show then
			if not self.m_panel then
				self:CreatePanel(ResPathReader.UpdateUI)
			end
		else
			self:DestroyPanel()
		end
	end

	function FUpdateUI:OnCreate()		
		self.m_progress = self:FindDirect(OBJPATH.progress):GetComponent("Slider")
		self.m_tip = self:FindDirect(OBJPATH.tip)
		self.m_localversion = self:FindDirect(OBJPATH.localversion)
		self.m_remoteversion = self:FindDirect(OBJPATH.remoteversion)
		self.m_progress.interactable = false

		self:SetLoaclVersion(self.localverionVal)
		self:SetRemoteVersion(self.remoteverionVal)
	end

	function FUpdateUI:SetLoaclVersion(v)
		self.localverionVal = v
		if not self.m_localversion then
			return
		end
		FGUITools.setText(self.m_localversion,v)
	end
	function FUpdateUI:SetRemoteVersion(v)
		self.remoteverionVal = v
		if not self.m_remoteversion then
			return
		end
		FGUITools.setText(self.m_remoteversion,v)
	end

	function FUpdateUI:SetProgress(v)
		if not self.m_progress then return end
		self.m_progress.value = v
	end

	function FUpdateUI:SetTip(v)
		if not self.m_tip then return end
		FGUITools.setText(self.m_tip,v)
	end
end

return FUpdateUI
