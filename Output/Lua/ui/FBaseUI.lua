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
	function FBaseUI:_ctor()
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

	function FBaseUI:BringDepth()
		-- local canvas = self.m_panel:GetComponent(UnityEngine.Canvas)
		-- if not canvas then
		-- 	canvas = self.m_panel:AddComponent(UnityEngine.Canvas)
		-- end
		-- canvas.overrideSorting = true
	end

	function FBaseUI:GetUIRoot()
		return FGUIMan.Instance():GetGUIRoot()
	end

	local function getPanelNameFromResName (resName)
		local i, j, cap = resName:find("/([%w_]+)%.prefab$")
		if cap then
			return cap
		end
		local i, j, cap = resName:find("([^/]*)$")
		return cap or "<noname>"
	end

	function FBaseUI:CreatePanel(assetName)
		--Init GUIRoot
		FGUIMan.Instance():InitUIRoot()

		if not self.m_loading and not self.m_created then
			self.m_abName = assetName
			self.m_panelName = getPanelNameFromResName(assetName)
			self.m_loading = true
			FGUIMan.Instance():RegisterPanel(assetName,self)
			FGUIMan.Instance():CreatePanel(assetName, function(bundle)
				if bundle then
					if not self.m_loading then
						return
					end
					local panelName = self.m_panelName
					self.m_panel = FGUIHelper.CreatePanel(panelName, "Main")
					self:_Create()
				else
					self:DestroyPanel()
					warn("CreatePanel Failed,assetbundle="..assetName)
				end
			end)
		end
	end

	function FBaseUI:DestroyPanel()
		if self.m_panel ~= nil then
			FGUIMan.Instance():RemoveWindow(self.m_panel)
			local obj = self.m_panel.rootContainer.gameObject
			UnityEngine.Object.Destroy(obj)

			self:_Destroy()
		end
		self.m_loading = false
		self.m_created = false
	end

	function FBaseUI:IsActive()
		if not self.m_panel or self.m_panel.isNil then
			return false
		else
			return self.m_panel.visible
		end
	end

	function FBaseUI:SetActive(active)
		if not self.m_panel or self.m_panel.isNil then
			return
		end
		self.m_panel.visible = active
	end

	function FBaseUI:FindChild(objpath)
		if not self.m_panel then
			warn("error" .. tostring(self) .. "(FindChild)".. ", self.m_panel is nil")
			return nil
		else
			local obj = self:FindChildObj(objpath)
			if not obj then
				warn("can not " .. tostring(self) .. "(FindChild):".. objpath)
			end
			return FGUIHelper.ToCom(obj)
		end
	end

	function FBaseUI:FindChildObj(objpath)
		if not self.m_panel then
			warn("error " .. tostring(self) .. "(FindChildObj)".. ", self.m_panel is nil")
			return nil
		else
			return self.m_panel:Find(objpath)
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
		--self.m_panel.transform:SetParent(self:GetUIRoot())
		--self.m_panel.transform.localPosition = Vector3(0, 0, 0)
		--self.m_panel.transform.localScale = Vector3(1, 1, 1)
		self.m_panel:Show()
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

	function FBaseUI:AddGUIHandle(objpath, eventName, callback)
	end

	function FBaseUI:Center()
		self.m_panel:Center()
	end
end

return FBaseUI
