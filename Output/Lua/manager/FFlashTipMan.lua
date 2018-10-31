local FFlashTipMan = FLua.Class("FFlashTipMan")
do
	local MAX_CACHE = 10
	local MAX_TIPS = 3
	function FFlashTipMan:_ctor()
		self.m_root = nil
		self.m_cached = {}
		self.m_used = {}
	end

	function FFlashTipMan:InitCacheRoot()
		self.m_root = NewGameObject("FlashTipCacheRoot")
	end

	function FFlashTipMan:NewFlashTip()
		local len = #self.m_cached
		local flash = self.m_cached[len]
		return flash
	end

	function FFlashTipMan:FlashTip(tip)
		self:DoWhileTipMax()

		local FFlashTipUI = require "ui.FFlashTipUI"
		local flashTipUI = FFlashTipUI.new()
		local flash = self:NewFlashTip()
		if flash then
			flashTipUI:FillText(tip)
			flash:SetActive(true)
			flashTipUI:Attach(flash)
		else
			flashTipUI:ShowTip(tip)
		end

		table.insert(self.m_used,flashTipUI)
	end

	function FFlashTipMan:DoWhileTipMax()
		if #self.m_used == MAX_TIPS then
			for i=1,MAX_TIPS-1 do
				self.m_used[i]:FillText(self.m_used[i+1]:GetContext())
			end
			local flashTipUI = table.remove(self.m_used,MAX_TIPS)
			flashTipUI:Detach(self.m_root)
			return true
		end
		return false
	end
end

FlashTipMan = FFlashTipMan.new()

return FFlashTipMan