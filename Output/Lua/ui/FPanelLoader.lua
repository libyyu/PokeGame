local FViewBaseUI = require "ui.FViewBaseUI"
local GcCallbacks = require "utility.GcCallbacks"
local FGUIMan = require "ui.FGUIMan"
--[[
	GUI 面板。有加载资源的功能，
]]

local FPanelLoader = FLua.Class(FViewBaseUI, "FPanelLoader")
do
	function FPanelLoader:__constructor()
		--所在的资源ab包
		self.m_abName = ""
		--资源路径
		self.m_assetPath = ""
		--界面名
		self.m_panelName = ""
		self.m_panel = nil
		--是否fairygui
		self.m_isfgui = false
		self.m_isfguiWindow = false
		self.m_fguiOwner = nil
		self.m_createRequested = false
		self.m_isLoading = false
		self.m_disappearing = false
		self.m_destroying = false
		self.m_HideOnDestroy = false
		self.m_panelHide = nil
		self.m_panelHideCleaner = nil
		self.m_TrigGC = false
		self.m_unloadSessionId = 0
	end

	function FPanelLoader:GetUIRoot()
		if self.m_isfgui then
			return FGUIMan.Instance():GetFGUIRoot()
		else
			return FGUIMan.Instance():GetUGUIRoot()
		end
	end

	function FPanelLoader:IsResourceReady()
		return self.m_createRequested and self.m_panel ~= nil and not self.m_panel.isNil and not self.m_disappearing
	end

	function FPanelLoader:IsResourceLoading()
		return self.m_createRequested and self.m_isLoading
	end

	local function LoadFairyGUIPackage(assetName, callback)
		if GameUtil.IsEditorEnv() then
			local commonAsset = ResPathReader.CommonBundle
			print("AddPackage:", commonAsset, TransformAssetName(commonAsset))
			FairyGUI.UIPackage.AddPackage(TransformAssetName(commonAsset))
			FairyGUI.UIConfig.buttonSound = FairyGUI.UIPackage.GetItemAssetByURL("ui://Common/tabswitch")
			FairyGUI.UIConfig.globalModalWaiting = "ui://Common/GlobalModalWaiting"
			print("FairyGUI.UIConfig.buttonSound", FairyGUI.UIConfig.buttonSound)

			print("AddPackage:", assetName, TransformAssetName(assetName))
			local pack = FairyGUI.UIPackage.AddPackage(TransformAssetName(assetName))
			if not pack then
				callback(nil)
				return
			end

			local dependencies = pack.dependencies or {}
			for i,v in ipairs(dependencies) do
				for k,v2 in pairs(v) do
					print("dependencies", i, k, v2)
					if k == "name" then
						local commonAsset = "Arts/UI/FairyGUI/" .. v2
						print("AddPackage:", commonAsset, TransformAssetName(commonAsset))
						FairyGUI.UIPackage.AddPackage(TransformAssetName(commonAsset)) 
					end
				end
			end

			callback({})
		else
			AsyncLoadABundleArray({ ResPathReader.CommonBundle, assetName }, function(bundles)
				if bundles[1] then
					FairyGUI.UIPackage.AddPackage(bundles[1])
					FairyGUI.UIConfig.buttonSound = FairyGUI.UIPackage.GetItemAssetByURL("ui://Common/tabswitch")
					print("FairyGUI.UIConfig.buttonSound", FairyGUI.UIConfig.buttonSound)
				end
				if not bundles[2] then
					callback(nil)
					return
				end

				local pack = FairyGUI.UIPackage.AddPackage(bundles[2])
				if not pack then
					callback(nil)
					return
				end

				local dependenciesab = {}
				local dependencies = pack.dependencies or {}
				for i, v in ipairs(dependencies) do
					for k,v2 in pairs(v) do
						print("dependencies", i, k, v2)
						if k == "name" then
							local commonAsset = "Arts/UI/FairyGUI/" .. v2
							dependenciesab[#dependenciesab+1] = commonAsset
						end
					end
				end

				if #dependenciesab >0 then
					AsyncLoadABundleArray(dependenciesab, function(dependencie_bundles)
						if dependencie_bundles then
							for _, ab in ipairs(dependencie_bundles) do
								FairyGUI.UIPackage.AddPackage(ab)
							end
						end
						
						callback(bundles[2])
					end)
				else
					callback(bundles[2])
				end
			end)
		end
	end

	local function LoadPanelPackage(assetName, callback, fgui)
		if fgui then 
			LoadFairyGUIPackage(assetName, callback)
		else
			AsyncLoad(assetName, function(obj)
				callback(obj)
			end)
		end
	end

	local function parseResource(resName)
		if resName:find('@') then
			local arr = resName:split('@')
			local componentName, packageABPath = arr[1], arr[2]
			local window = false
			if componentName:find(':') then
				local sb = componentName:split(':')
				componentName = sb[1]
				window = tonumber(sb[2]) == 1
			end
			local abName = TransformABName(packageABPath)
			local i = packageABPath:find_last("/", true)
			local packageName = packageABPath:sub(i+1, -1)
			return true, abName, componentName, packageName, window
		else
			local prefabName
			local i, j, cap = resName:find("/([%w_]+)%.prefab$")
			if cap then
				prefabName = cap
			else
				local i, j, cap = resName:find("([^/]*)$")
				prefabName = cap or "<noname>"	
			end

			local abName = TransformABName(resName)

			return false, abName, prefabName
		end
	end


	--[[
		param resName: 资源路径
		param panelName: 界面名称
		param parentObj: 新面板以此对象为父，非 nil 表示是子面板；nil 表示使用默认（暂时无用）
		param onCreateFinish: function onCreateFinish (bSucceeded)
	]]

	function FPanelLoader:LoadPanel(resName, parentObj, onCreateFinish)
		self.m_createRequested = true
		--资源加载中，不用重复创建
		if self.m_isLoading then
			return
		end
		self.m_isLoading = true
		local isfgui, abName, prefabName, packageName, window = parseResource(resName)
		print("parseResource", resName, abName, prefabName, packageName)
		self.m_isfgui = isfgui
		self.m_isfguiWindow = window
		self.m_assetPath = resName
		self.m_panelName = prefabName
		self.m_abName = abName
		if not parentObj then parentObj = self:GetUIRoot() end
		self:OnBeforeLoadPanel()

		local function onResourceLoaded(panel)
			self.m_isLoading = false
			if not panel then
				onCreateFinish(false)
				return 
			elseif not isfgui then
				self:SetPanelObject(panel)
			elseif window then
				self.m_fguiOwner = panel.rootContainer.gameObject
				self:SetPanelObject(panel)
			else
				self.m_fguiOwner = panel.gameObject
				self:SetPanelObject(panel.ui)
			end	
			onCreateFinish(self.m_panel ~= nil)	
		end
		
		--从隐藏界面中创建
		local panelHide = self:_FetchPanelHide()
		if panelHide then		
			onResourceLoaded(panelHide)
			return
		end
		
		local function onLoad(obj)
			--create请求已经退出了
			if not self.m_createRequested then
				onResourceLoaded(false)
				return
			end

			--未能正常加载资源
			if not obj then
				onResourceLoaded(false)
				return
			end

			if not isfgui then
				local panel = Instantiate(obj, self.m_panelName, parentObj)
				panel.transform.localPosition = Vector3(0, 0, 0)
				panel.transform.localScale = Vector3(1, 1, 1)
				panel.layer = LayerMask.NameToLayer("UI")
				panel.tag = "Panel"
				onResourceLoaded(panel)
			elseif window then
				print("CreateWindow", packageName, prefabName)
				local window = FGUIHelper.CreateWindow(packageName, prefabName)
				if window then
					print("window", window)
					--self.m_fguiwindow = window
					local objpanel = window.rootContainer.gameObject
					objpanel.layer = LayerMask.NameToLayer("FairyGUI")
					objpanel.tag = "Panel"
				end
				onResourceLoaded(window)
			else
				print("CreatePanel", packageName, prefabName)
				local panel = FGUIHelper.CreatePanel(packageName, prefabName)
				if panel then
					print("panel", panel)
					panel.fitScreen = FairyGUI.FitScreen.FitSize
					local objpanel = panel.gameObject
					objpanel.transform:SetParent(parentObj.transform)
					objpanel.layer = LayerMask.NameToLayer("FairyGUI")
					objpanel.tag = "Panel"
				end
				onResourceLoaded(panel)
			end
		end
		
		LoadPanelPackage(resName, onLoad, isfgui)
	end

	--TODO:
	function FPanelLoader:SetHideOnDestroy(bHideOnDestroy, clearGCLevel)
		self.m_HideOnDestroy = bHideOnDestroy
		self.m_HideOnDestroyGCLevel = clearGCLevel
		
		if not bHideOnDestroy then
			self:_SetPanelHide(nil)
		end
	end
	
	------------------------------------------------------------
	-- End of public
	------------------------------------------------------------
	function FPanelLoader:IsDisableWorldRendering()
		return false
	end

	function FPanelLoader:IsTrigGC()
		return self.m_TrigGC
	end

	function FPanelLoader:SetPanelObject(panelObject)
		self.m_panel = panelObject
		self:OnChangePanelObject()
	end

	function FPanelLoader:OnChangePanelObject()
	end

	function FPanelLoader:UnloadPanel()
		self.m_unloadSessionId = self.m_unloadSessionId + 1
		
		if self.m_panel then
			if self.m_HideOnDestroy then
				self:_SetPanelHide(self.m_panel)
			else
				if self.m_isfgui then
					if self.m_isfguiWindow then
						FairyGUI.GRoot.inst:RemoveChild(self.m_panel)
					end
					UnityEngine.Object.Destroy(self.m_fguiOwner)
				else
					UnityEngine.Object.Destroy(self.m_panel)
				end
			end

			self:SetPanelObject(nil)	--self.m_panel = nil
		end
		
		self.m_disappearing = false
	end
	
	function FPanelLoader:_SetPanelHide(panelHide)
		if self.m_panelHide == panelHide then
			return
		end
		
		if self.m_panelHide then
			--清除旧 panelHide
			UnityEngine.Object.Destroy(self.m_panelHide)
			self.m_panelHide = nil
		end
		if panelHide then
		end
	end
	
	--取出缓存的 panelHide 开始使用
	function FPanelLoader:_FetchPanelHide()
		local panelHide = self.m_panelHide
		if panelHide then
			self.m_panelHide = nil
			return panelHide
		else
			return nil
		end
	end

	function FPanelLoader:OnBeforeLoadPanel()
	end


end

return FPanelLoader
