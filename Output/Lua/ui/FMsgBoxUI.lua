local FBaseUI = require "ui.FBaseUI"
local FGUITools = require "utility.FGUITools"

local FMsgBoxUI = FLua.Class("FMsgBoxUI",FBaseUI)
do
	local OBJPATH = 
	{
		Content = "n0",
		Ok = "n2",
		Cancel = "n1"
	}

	local _UniqueID = 0

	function FMsgBoxUI:_ctor()
		_UniqueID = _UniqueID + 1
		self.m_sender = nil
		self.m_title = "MsgBox"
		self.m_content = "Hello"
		self.m_mask = MsgBoxType.MBT_INFO
		self.m_click_cb = nil--function(sender,ret) end
		self.m_uniqueId = _UniqueID
		self.m_isdone = false
	end

	function FMsgBoxUI:SetInfo(hwnd,content,title,mask,click_cb)
		self.m_sender = hwnd
		self.m_content = content
		self.m_title = title or ""
		self.m_mask = mask or bit.bor(MsgBoxType.MBT_INFO,MsgBoxType.MBBT_OK)
		self.m_click_cb = click_cb
	end

	function FMsgBoxUI:FillInfo()
		local contentObj = self:FindChildObj(OBJPATH.Content)
		FGUITools.setText(contentObj,self.m_content)

		local nMask = self.m_mask
		local info_icon = (bit.band(nMask,MsgBoxType.MBT_INFO)  >0)
		local ok_icon = (bit.band(nMask,MsgBoxType.MBT_OK)  >0)
		local warn_icon = (bit.band(nMask,MsgBoxType.MBT_WARN) >0)

		local isShowCancel = (bit.band(nMask,MsgBoxType.MBBT_CANCEL) > 0)
		local isShowOk = (bit.band(nMask,MsgBoxType.MBBT_OK) > 0)
		local isShowCheckBox = (bit.band(nMask,MsgBoxType.MBBT_CHECKBOX) > 0)

		local okObj = self:FindChildObj(OBJPATH.Ok)
		local cancelObj = self:FindChildObj(OBJPATH.Cancel)

		--FGUITools.setActive(okObj,isShowOk)
		--FGUITools.setActive(cancelObj,isShowCancel)
	end

	function FMsgBoxUI:OnCreate()
		self:Center()
		self:FillInfo()

		local okObj = self:FindChildObj(OBJPATH.Ok)
		local cancelObj = self:FindChildObj(OBJPATH.Cancel)
		okObj.onClick:Add(function()
			self:OnOK()
		end)
		cancelObj.onClick:Add(function()
			self:OnCancel()
		end)
	end

	function FMsgBoxUI:OnDestroy()
	end

	function FMsgBoxUI:OnOK()
		if self.m_click_cb ~= nil then
			self.m_click_cb(self.m_sender,MsgBoxRetT.MBRT_OK)
		end
		self:DestroyPanel()
		self.m_isdone = true
	end
	function FMsgBoxUI:OnCancel()
		if self.m_click_cb ~= nil then
			self.m_click_cb(self.m_sender,MsgBoxRetT.MBRT_CANCEL)
		end

		self:DestroyPanel()
		self.m_isdone = true
	end

	function FMsgBoxUI:IsDone()
		return self.m_isdone
	end

	function FMsgBoxUI:DoTask()
		if not self.m_panel then
			self:CreatePanel(ResPathReader.MsgBoxUI)
		else
			self:SetActive(true)
			self:FillInfo()
		end
	end
end

return FMsgBoxUI

