local FBaseUI = require "ui.FBaseUI"
local FGUITools = require "utility.FGUITools"

local l_instance = nil
local FUpdateUI = FLua.Class("FUpdateUI",FBaseUI)
do
	local OBJPATH = 
	{
		progress = "n15",
		tip = "tip",
		localversion = "local_version",
		remoteversion = "remote_version",
	}
	function FUpdateUI:_ctor()
		self.m_progress = nil
		self.m_tip = nil
		self.m_localversion = nil
		self.m_remoteversion = nil
		self.localverionVal = "--"
		self.remoteverionVal = "--"
	end

	function FUpdateUI.Instance()
		if not l_instance then
			l_instance = FUpdateUI.new()
		end
		return l_instance
	end

	function FUpdateUI:ShowPanel(show)
		if show then
			if not self.m_panel then
				self:CreatePanel(ResPathReader.PokerUpdateUI)
			end
		else
			self:DestroyPanel()
		end
	end

	function FUpdateUI:OnCreate()		
		self.m_progress = self:FindChildObj(OBJPATH.progress)
		self.m_tip = self:FindChildObj(OBJPATH.tip)
		self.m_localversion = self:FindChildObj(OBJPATH.localversion)
		self.m_remoteversion = self:FindChildObj(OBJPATH.remoteversion)

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
