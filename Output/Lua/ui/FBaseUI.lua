--filename: FBaseUI.lua
--author: lidengfeng
--email: libyyu@qq.com
--time: 2017/2/19
--comment: 所有UI的基类
local FGUIMan = require "ui.FGUIMan"
local FDebugOption = require "game.FDebugOption"

local FBaseUI = FLua.Class("FBaseUI")
do
	local s_lastPanel = nil
	function FBaseUI:__constructor()
		self.m_abName = ""
		self.m_panelName = ""
		self.m_panel = nil
		self.m_msghandler = nil
		self.m_loading = false
		self.m_created = false
		self.m_UnloadBundleWhenDestroy = true
		self.m_TriggerGCWhenDestroy = true
		self.m_createCustomCallback = {}
		self.m_destoryCustomCallback = {}
	end

	function FBaseUI:GetUIRoot()
		return FGUIMan.Instance():GetGUIRoot()
	end
	function FBaseUI:UseFairyGUI()
		return FGUIMan.Instance():UseFairyGUI()
	end

	function FBaseUI:TouchGUIMsg()
		self.m_msghandler = self.m_panel:GetComponent(LuaBehaviour)
		if not self.m_msghandler then
			self.m_msghandler = self.m_panel:AddComponent(LuaBehaviour)
		end
		local mst = {
			onDestroy = function() self:_Destroy() end,
			onClick = function(go) self:_Click(go) end,
			onSubmit = function(go,str) self:_Submit(go,str) end,
			onStepTweenFinish = function(go) self:_onStepTweenFinish(go) end,
			onScroll = function(go,v) self:_onScroll(go,v) end
		}
		self.m_msghandler:TouchGUIMsg(mst)
	end

	function FBaseUI:BringDepth()
		-- local canvas = self.m_panel:GetComponent(UnityEngine.Canvas)
		-- if not canvas then
		-- 	canvas = self.m_panel:AddComponent(UnityEngine.Canvas)
		-- end
		-- canvas.overrideSorting = true
	end

	local function getPanelNameFromResName (resName)
		local i, j, cap = resName:lower():find("/([%w_]+)%.prefab$")
		if cap then
			return cap
		end
		local i, j, cap = resName:lower():find("([^/]*)$")
		return cap or "<noname>"
	end

	function FBaseUI:CreatePanel(assetName)
		--Init GUIRoot
		FGUIMan.Instance():InitUIRoot()

		if not self.m_loading and not self.m_created then
			self.m_abName = assetName
			self.m_panelName = getPanelNameFromResName(assetName)
			self.m_loading = true
			FGUIMan.Instance():RegisterPanel(assetName, self)
			FGUIMan.Instance():LoadPanelRes(assetName, function(obj)
				if self:UseFairyGUI() then
				else
					if obj then
						if not self.m_loading then
							return
						end
						self.m_panel = Instantiate(obj)
						self.m_panel.name = self.m_panelName
						self:_Create()
					else
						self:DestroyPanel()
						warn("CreatePanel Failed,assetbundle="..assetName)
					end
				end
			end)
		end
	end

	function FBaseUI:Detach(root)
		if self.m_panel then
			self.m_panel.transform:SetParent(root)
		end
		return self.m_panel
	end

	function FBaseUI:Attach(go)
		assert(go)
		assert(go.tag == "Panel")
		assert(not self.m_panel)

		self.m_panel = go
		self:_Create()
	end

	function FBaseUI:DestroyPanel()
		if self.m_panel ~= nil then
			UnityEngine.Object.Destroy(self.m_panel)
		end
		self.m_loading = false
		self.m_created = false
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
			local obj = self.m_panel.transform:FindChild(objpath)
			if not obj then
				warn("can not " .. tostring(self) .. "(FindChild):".. objpath)
			end
			return obj
		end
	end

	function FBaseUI:FindChildObj(objpath)
		if not self.m_panel then
			warn("error " .. tostring(self) .. "(FindChildObj)".. ", self.m_panel is nil")
			return nil
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

	function FBaseUI:AttachCreateFunc(func)
		if type(func) ~= "function" then
			error("create callback must be a function")
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
		self.m_panel.layer = LayerMask.NameToLayer("UI")
		self.m_panel.tag = "Panel"
		self.m_panel.transform:SetParent(self:GetUIRoot())
		self.m_panel.transform.localPosition = Vector3(0, 0, 0)
		self.m_panel.transform.localScale = Vector3(1, 1, 1)
		self:TouchGUIMsg()
		self:BringDepth()
		self:OnCreate()
		FireEvent(EventDef.PanelCreate,self)
		for i,func in ipairs(self.m_createCustomCallback) do
			func(self)
		end
	end

	function FBaseUI:OnDestroy()
	end
	function FBaseUI:_Destroy()
		self.m_panel = nil
		self.m_loading = false
		self.m_created = false
		self:OnDestroy()
		FireEvent(EventDef.PanelDestroy,self)
		warn("[" .. self.m_panelName.."] is Destroy")
		for i,func in ipairs(self.m_destoryCustomCallback) do
			func(self)
		end
		if self.m_UnloadBundleWhenDestroy then
			UnloadAssetBundle(self.m_abName,false)
			warn("["..self.m_panelName.."] asset is unload.")
		end
		if self.m_TriggerGCWhenDestroy then
			GameUtil.LuaGC()
			warn("["..self.m_panelName.."] destroyed trigger gc.")
		end
	end
	function FBaseUI:OnClick(go)
	end
	function FBaseUI:_Click(go)
		if FDebugOption.Instance():ShowClick() then
			warn("id:["..go.name.."("..tostring(self)..")".."] is clicked")
		end
		self:OnClick(go)
	end
	function FBaseUI:OnSubmit(go,str)
	end
	function FBaseUI:_Submit(go,str)
		self:OnSubmit(go,str)
	end

	function FBaseUI:_onStepTweenFinish(go)
		--warn("onStepTweenFinish",go.name)
	end

	function FBaseUI:onScrollValue(go,v)
	end
	function FBaseUI:onScrollFinished(go)
	end

	function FBaseUI:_onScroll(go,v)
		self:onScrollValue(go,v)
		if v >= 1.0 then
			self:onScrollFinished(go)
		end
	end
end

return FBaseUI
