local l_instance = nil
local FMsgBoxMan = FLua.Class("FMsgBoxMan")
do
	function FMsgBoxMan.Instance()
		if not l_instance then
			l_instance = FMsgBoxMan.new()
		end
		return l_instance
	end
	function FMsgBoxMan:_ctor()
		self.m_boxList = {}
		self.m_curBox = nil
	end

	function FMsgBoxMan:Push(msgbox)
		local len = #self.m_boxList
		self.m_boxList[len+1] = msgbox
		return len
	end
	function FMsgBoxMan:Pop()
		if #self.m_boxList >0 then
			return table.remove(self.m_boxList,1)
		end
		return nil
	end

	function FMsgBoxMan:Remove(msgbox)
		for i,v in ipairs(self.m_boxList) do
			if v == msgbox then
				table.remove(self.m_boxList,i)
				return i
			end
		end
		return 0
	end

	local function OnMsgBoxDestroy(msgbox)
		local self = FMsgBoxMan.Instance()
		local bNilCur = false
		if msgbox == self.m_curBox then
			bNilCur = true
		end
		self:Remove(msgbox)
		if bNilCur then
			self.m_curBox = nil
		end
		local newbox = self:Pop()
		if newbox then
			self:TryPopup(newbox)
		end
	end

	function FMsgBoxMan:TryPopup(msgbox)
		if self.m_curBox then
			self:Push(msgbox)
		else
			self.m_curBox = msgbox
			msgbox:DoTask()
		end
	end

	function FMsgBoxMan:ShowMsgBox(hwnd,content,title,mask,click_cb)
		local FMsgBoxUI = require "ui.FMsgBoxUI"
		local msgbox = FMsgBoxUI.new()
		msgbox:SetInfo(hwnd,content,title,mask,click_cb)
		msgbox:AttachDestroyFunc(OnMsgBoxDestroy)
		self:TryPopup(msgbox)
	end
end

return FMsgBoxMan