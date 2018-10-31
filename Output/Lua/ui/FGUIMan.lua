
local l_instance = nil
local FGUIMan = FLua.Class("FGUIMan")
do
	function FGUIMan.Instance()
		if not l_instance then
			l_instance = FGUIMan.new()
		end
		return l_instance
	end
	function FGUIMan:_ctor()
		self.m_UIRoot = nil
		self.m_PanelContainer = {}
	end

	function FGUIMan:GetGUIRoot()
		return self.m_UIRoot
	end

	function FGUIMan:InitUIRoot()	
		if self.m_UIRoot and not self.m_UIRoot.isNil then
			return
		end
		FairyGUI.GRoot.inst:SetContentScaleFactor(1344, 750)
		self.m_UIRoot = FairyGUI.GRoot.inst.rootContainer.gameObject
	end

	function FGUIMan:RegisterPanel(name,panel)
		self.m_PanelContainer[name] = panel
	end

	function FGUIMan:RemoveWindow(child)
		FairyGUI.GRoot.inst:RemoveChild(child)
	end

	function FGUIMan:CreatePanel(assetName, callback)
		AsyncLoadBundleArray({ResPathReader.PokerCommon, assetName}, function(bundles)
			if not bundles[1] then
				warn("Failed to get common resource")
			else
				FairyGUI.UIPackage.AddPackage(bundles[1])
			end
			if bundles[2] then
				FairyGUI.UIPackage.AddPackage(bundles[2])
				callback(bundles[2])
			else
				callback(nil)
			end
		end)
	end

end

return FGUIMan