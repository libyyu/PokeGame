--filename: FBaseUI.lua
--author: lidengfeng
--email: libyyu@qq.com
--time: 2017/2/19
--comment: 所有UI的基类
local FGUIMan = require "ui.FGUIMan"
local FDebugOption = require "game.FDebugOption"

local FBaseUI = FLua.Class("FBaseUI")
do
	function FBaseUI:__constructor()
		self.m_abName = ""
		self.m_assetPath = ""
		self.m_panelName = ""
		self.m_panel = nil
		self.m_loading = false
		self.m_created = false
		self.m_isfgui = false
		self.m_fguiwindow = nil
		self.m_msghandler = nil
		self.m_UnloadBundleWhenDestroy = true
		self.m_TriggerGCWhenDestroy = true
		self.m_createCustomCallback = {}
		self.m_destoryCustomCallback = {}
	end

	function FBaseUI:GetUIRoot()
		if self:UseFairyGUI() then
			return FGUIMan.Instance():GetFGUIRoot()
		else
			return FGUIMan.Instance():GetUGUIRoot()
		end
	end

	function FBaseUI:UseFairyGUI()
		return self.m_isfgui
	end

	function FBaseUI:TouchGUIMsg()
		local function getFunc(name)
			local func = self:tryget(name)
			if func and type(func) == "function" then
				return func
			end
			return nil
		end
		if not self:UseFairyGUI() or not self.m_fguiwindow then
			self.m_msghandler = self.m_panel:GetComponent(LuaBehaviour)
			if not self.m_msghandler then
				self.m_msghandler = self.m_panel:AddComponent(LuaBehaviour)
			end
			local mst = {
				onDestroy = function() self:_Destroy() end,
				onBecameVisible = function(...) self:_BecameVisible(...) end,
				onBecameInvisible = function(...) self:_BecameInvisible(...) end,
			}
			local func = getFunc("OnClick")
			if func then
				mst.onClick = function(...) print("ui:click", ...) self:OnClick(...) end
			end 
			func = getFunc("OnSubmit")
			if func then
				mst.onSubmit = function(...) self:OnSubmit(...) end
			end 
			func = getFunc("OnChange")
			if func then
				mst.onTextChange = function(...) self:OnChange(...) end
			end 
			-- func = getFunc("OnStepTweenFinish")
			-- if func then
			-- 	mst.onStepTweenFinish = function(...) self:OnStepTweenFinish(...) end
			-- end 
			-- func = getFunc("OnScroll")
			-- if func then
			-- 	mst.onScroll = function(...) self:OnScroll(...) end
			-- end 

			self.m_msghandler:TouchGUIMsg(mst)

			if self:UseFairyGUI() then
				local gpanel = self.m_panel:GetComponent("UIPanel")
				local ui = gpanel.ui
				if mst.onClick then
					ui:AddEventListener("onClick", mst.onClick)
				end
				if mst.onSubmit then
					ui:AddEventListener("onSubmit", mst.onSubmit)
				end
				if mst.onTextChange then
					ui:AddEventListener("onChanged", mst.onTextChange)
				end
			end
		else
			local mst = {
				OnInit = function(...) print("OnInit", ...) end,
				OnShown = function(...) self:_BecameVisible(...) end,
				OnHide = function(...) self:_BecameInvisible(...) end,
			}

			if self.m_fguiwindow then
				print("TouchGUIMsg", self.m_fguiwindow, self.m_panel)
				local func = self:tryget("DoShowAnimation")
				if func and type(func) == "function" then
					mst.DoShowAnimation = function(...) print("DoShowAnimation", ...) end
				end 
				func = self:tryget("DoHideAnimation")
				if func and type(func) == "function" then
					mst.DoHideAnimation = function(...) print("DoHideAnimation", ...) end
				end 
				local ui = self.m_fguiwindow
				ui:SetLuaHandler(mst)
				if getFunc("OnClick") then
					ui:AddEventListener("onClick", function(...)
						print("ui:click", ...) self:OnClick(...) 
					end)
				end
				if getFunc("OnSubmit") then
					ui:AddEventListener("onSubmit", function(...)
						print("ui:input-submit", ...) self:OnSubmit(...) 
					end)
				end
				if getFunc("OnChange") then
					ui:AddEventListener("onChanged", function(...)
						print("ui:input-changed", ...) self:OnChange(...) 
					end)
				end
			end
		end
	end

	function FBaseUI:BringDepth()
		-- local canvas = self.m_panel:GetComponent(UnityEngine.Canvas)
		-- if not canvas then
		-- 	canvas = self.m_panel:AddComponent(UnityEngine.Canvas)
		-- end
		-- canvas.overrideSorting = true
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

	if FairyGUI then
		FairyGUI.GLoader.gLoaderFunc = function(url, loader)
			print("loader:", url, loader, loader.rootOwner.displayObject.gameObject)
			--local panel = FGUIMan.Instance():GetPanelByObj(loader.rootOwner.displayObject.gameObject.transform.parent.gameObject)
			print("loader:", panel)
			return true
		end
	end

	function FBaseUI:CreatePanel(assetName)
		--Init GUIRoot
		FGUIMan.Instance():InitUIRoot()

		if not self.m_loading and not self.m_created then
			local isfgui, abName, prefabName, packageName, window = parseResource(assetName)
			print("parseResource", assetName, abName, prefabName, packageName)
			self.m_loading = true
			self.m_isfgui = isfgui
			self.m_assetPath = assetName
			self.m_panelName = prefabName
			self.m_abName = abName
			FGUIMan.Instance():RegisterPanel(assetName, self)
			FGUIMan.Instance():LoadPanelRes(assetName, function(obj)
				if self:UseFairyGUI() then
					local bundle = obj
					if bundle then
						if not self.m_loading then
							return
						end
												
						if window then
							print("CreateWindow",packageName,prefabName)
							local panel = FGUIHelper.CreateWindow(packageName, prefabName)
							if panel then
								print("panel", panel)
								self.m_fguiwindow = panel
								self.m_panel = panel.rootContainer.gameObject
								self.m_panel.layer = LayerMask.NameToLayer("FairyGUI")
								self.m_panel.tag = "Panel"
								self:_Create()
								panel.modal = true
								panel:Show()
							end
						else
							print("CreatePanel",packageName,prefabName)
							local panel = FGUIHelper.CreatePanel(packageName, prefabName)
							if panel then
								print("panel", panel, self:GetUIRoot())
								panel.fitScreen = FairyGUI.FitScreen.FitSize
								self.m_panel = panel.gameObject
								self.m_panel.transform:SetParent(self:GetUIRoot().transform)
								self.m_panel.layer = LayerMask.NameToLayer("FairyGUI")
								self.m_panel.tag = "Panel"
								panel:CreateUI()
								self:_Create()
							end
						end

						if not self.m_panel then
							self:DestroyPanel()	
							warn("CreatePanel Failed,assetname="..assetName)
						end
					else
						self:DestroyPanel()
						warn("CreatePanel Failed,assetbundle="..assetName)
					end
				else
					if obj then
						if not self.m_loading then
							return
						end
						self.m_panel = Instantiate(obj, self.m_panelName, self:GetUIRoot())
						self.m_panel.transform.localPosition = Vector3(0, 0, 0)
						self.m_panel.transform.localScale = Vector3(1, 1, 1)
						self.m_panel.layer = LayerMask.NameToLayer("UI")
						self.m_panel.tag = "Panel"
						self:_Create()
					else
						self:DestroyPanel()
						warn("CreatePanel Failed,assetbundle="..assetName)
					end
				end
			end, self:UseFairyGUI())
		end
	end

	function FBaseUI:DestroyPanel()
		if self.m_panel ~= nil then
			if self:UseFairyGUI() then
				if self.m_fguiwindow then
					FGUIMan.Instance():RemoveWindow(self.m_fguiwindow)
				end
				UnityEngine.Object.Destroy(self.m_panel)
			else
				UnityEngine.Object.Destroy(self.m_panel)
			end
		else
			if self.m_UnloadBundleWhenDestroy then
				UnloadAssetBundle(self.m_abName, false)
			end
		end

		self.m_loading = false
		self.m_created = false
	end

	function FBaseUI:IsValid()
		if not self.m_panel or self.m_panel.isNil then
			return false
		else
			return true
		end
	end

	function FBaseUI:IsActive()
		if not self.m_panel or self.m_panel.isNil then
			return false
		else
			return self.m_panel.activeSelf
		end
	end

	function FBaseUI:SetActive(active)
		self.m_panel:SetActive(active)
	end

	function FBaseUI:FindChild(objpath)
		if not self.m_panel then
			warn("error" .. tostring(self) .. "(FindChild)".. ", self.m_panel is nil")
			return nil
		else
			if self:UseFairyGUI() then
				local obj = self:FindChildObj(objpath)
				if not obj then
					warn("can not " .. tostring(self) .. "(FindChild):".. objpath)
				end
				return FGUIHelper.ToCom(obj)
			else
				local obj = self.m_panel.transform:Find(objpath)
				if not obj then
					warn("can not " .. tostring(self) .. "(FindChild):".. objpath)
				end

				return obj
			end
		end
	end

	function FBaseUI:FindChildObj(objpath)
		if not self.m_panel then
			warn("error " .. tostring(self) .. "(FindChildObj)".. ", self.m_panel is nil")
			return nil
		else
			if self:UseFairyGUI() then
				if not self.m_fguiwindow then
					local uipanel = self.m_panel:GetComponent("UIPanel")
					if uipanel and uipanel.ui then
						return FGUIHelper.Find(uipanel.ui, objpath)
					end
				else

				end
				local uiwindow
			else
				local transform = self.m_panel.transform:Find(objpath)
				if not transform then
					warn("error " .. tostring(self) .. "(FindChildObj):".. objpath)
					return nil
				else
					return transform.gameObject
				end
			end
		end
	end

	function FBaseUI:AttachCreateFunc(func)
		if type(func) ~= "function" then
			error("create callback must be a function")
		end
		if self.m_created then
			func(self)
			return
		end
		local len = #self.m_createCustomCallback
		self.m_createCustomCallback[len+1] = func
	end
	function FBaseUI:AttachDestroyFunc(func)
		if type(func) ~= "function" then
			error("destroy callback must be a function")
		end
		local len = #self.m_destoryCustomCallback
		self.m_destoryCustomCallback[len+1] = func
	end

	function FBaseUI:OnCreate()
	end
	function FBaseUI:_Create()
		self.m_loading = false
		self.m_created = true
		FGUIMan.Instance():RegisterPanelObj(self.m_panel, self)
		self:TouchGUIMsg()
		self:BringDepth()
		self:OnCreate()
		FireEvent(EventDef.PanelCreate,self)
		for _,func in ipairs(self.m_createCustomCallback) do
			func(self)
		end
		self.m_createCustomCallback = {}
	end

	function FBaseUI:OnDestroy()
	end
	function FBaseUI:_Destroy()
		FGUIMan.Instance():UnRegisterPanelObj(self.m_panel)
		self.m_panel = nil
		self.m_fguiwindow = nil
		self.m_loading = false
		self.m_created = false
		self:OnDestroy()
		FireEvent(EventDef.PanelDestroy,self)
		local debugName = "[" .. self.m_panelName .. "@" .. self.m_abName .. "]"
		warn(debugName,"is Destroy")
		for _,func in ipairs(self.m_destoryCustomCallback) do
			func(self)
		end
		self.m_destoryCustomCallback = {}

		if self.m_UnloadBundleWhenDestroy then
			UnloadAssetBundle(self.m_abName,false)
			warn(debugName, "asset is unload.")
		end
		if self.m_TriggerGCWhenDestroy then
			GameUtil.LuaGC()
			warn(debugName, "destroyed trigger gc.")
		end
	end

	function FBaseUI:OnVisibleChanged(bShow)
	end

	function FBaseUI:_BecameVisible(...)
		print("BecameVisible", self, ...)
		self:OnVisibleChanged(true)
	end
	
	function FBaseUI:_BecameInvisible(...)
		print("BecameInvisible", self, ...)
		self:OnVisibleChanged(false)
	end
end

return FBaseUI
