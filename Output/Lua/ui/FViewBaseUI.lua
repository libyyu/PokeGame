--[[
	View 为 gameObject 组基类。如一组按钮，一个面板，一个子面板等
	View 是界面逻辑处理的合适单位，其会收到 OnCreate、OnDestroy 等消息
]]

local GcCallbacks = require "Utility.GcCallbacks"
local FPanelBaseUI = FLua.ForwardClass("FPanelBaseUI")

local FViewBaseUI = FLua.Class("FViewBaseUI")
do
	local DetachFlag =
	{
		Default = 0,
		AutoDetach = 1,
		AutoDetachAndInvokeDestroy = 2,
	}

	FViewBaseUI.DetachFlag = DetachFlag

	function FViewBaseUI:__constructor()
		self.m_viewRoot = nil
		self.m_viewObj = nil
		self.m_viewOwner = nil

		--各子 View 的 gameObject resolver，用于获取 View 的 gameObject根节点对象, function resolver (parentView) return subViewObj end, {subViewObjResolver1, ...}
		self.m_subViewObjResolvers = nil
		--各 View 对象 {subView1, ...}
		self.m_subViews = nil

		self.m_cleanerOnDestroy = nil
	end

	function FViewBaseUI:GetRootView()
		return self.m_viewRoot
	end

	function FViewBaseUI:GetOwnerView()
		return self.m_viewOwner
	end

	function FViewBaseUI:IsValid()
		local obj = self:GetRootObj()
		return obj ~= nil and not obj.isNil
	end

	function FViewBaseUI:IsRegister()
		if self == self.m_viewRoot then
			return true
		end

		if self.m_viewOwner ~= nil then
			return true
		end

		return false
	end

	function FViewBaseUI:IsSubView()
		if self ~= self.m_viewRoot and self:IsRegister() then
			return true
		end
		return false
	end



	function FViewBaseUI:GetRootObj()
		return self.m_viewObj
	end

	function FViewBaseUI:GetRootObjSafe()
		local obj = self:GetRootObj()
		return self:IsValid() and obj or nil
	end

	function FViewBaseUI:OnCreate()
	end

	--[[
		在创建好 gameObject 后触发，创建失败时不会触发
	]]
	function FViewBaseUI:AfterCreate()
	end

	--[[
		在将要销毁 gameObject 时触发
	]]

	function FViewBaseUI:OnDestroy()
	end

	--[[
		在销毁 gameObject 后触发
	]]

	function FViewBaseUI:AfterDestroy()
	end

	function FViewBaseUI:OnVisibilityChanged(bShow)
	end

	
	local function logError (str, errLevel)
		printerror(debug.traceback(str, (errLevel or 0)+1))
	end

	local function formatGameObjectInfo(obj)
		return tostring(obj)
	end


	function FViewBaseUI:FindDirect(name)
		return self.m_viewObj:FindDirect(name)
	end

	function FViewBaseUI:RequireFind(name)
		return self.m_viewObj:RequireFind(name)
	end



	function FViewBaseUI:RegisterSubView(subViewPath, subView)
		return self:RegisterSubViewEx(function (view)
			local viewObj = view.m_viewObj
			if #subViewPath == 0 or subViewPath == "." then
				return viewObj
			else
				local subViewObj = view:FindDirect(subViewPath)
				if subViewObj ~= nil then
					return subViewObj
				else
					logError(("failed to find view obj with path: %s, on obj: %s"):format(subViewPath, tostring(viewObj)), 2)
					return nil
				end
			end
		end, subView)
	end

	function FViewBaseUI:RegisterSubViewEx(subViewObjResolver, subView)
		if subView == nil then
			error("bad param #3 to RegisterSubViewEx (FViewBaseUI expected, got nil)", 2)
		end

		if self.m_viewObj ~= nil then
			error("can not call RegisterSubViewEx when GUI resource already loaded", 2)
		end

		if self.m_subViewObjResolvers == nil then
			self.m_subViewObjResolvers = {}
		end
		table.insert(self.m_subViewObjResolvers, subViewObjResolver)

		if self.m_subViews == nil then
			self.m_subViews = {}
		end
		table.insert(self.m_subViews, subView)

		subView.m_viewOwner = self
		subView:SetViewRoot(self.m_viewRoot)
		subView:OnAttached(self)
		return subView
	end

	function FViewBaseUI:AttachSubView(gameObject, subView, bInvokeOnCreate)
		return self:AttachSubViewEx(gameObject, subView, bInvokeOnCreate, DetachFlag.Default)
	end

	function FViewBaseUI:AttachSubViewEx(gameObject, subView, bInvokeOnCreate, nDetachFlag)
		if subView == nil then
			error("bad param #3 to AttachSubView (FViewBaseUI expected, got nil)", 2)
		end

		if self.m_viewObj == nil then
			error(string.format("can not call AttachSubView before GUI resource loaded:self:%s, sub:%s.", self, subView), 2)
		end

		if gameObject == nil then
			error("bad param #2 to AttachSubView (gameObject expected, got nil)", 2)
		elseif gameObject.isNil then
			error("bad param #2 to AttachSubView (gameObject was destroyed)", 2)
		end

		if subView.m_viewOwner ~= nil then
			error(string.format("subView(%s) has been attached to another owner(%s).", tostring(subView), tostring(subView.m_viewOwner)), 2)
		end

		if self.m_subViewObjResolvers == nil then
			self.m_subViewObjResolvers = {}
		end
		table.insert(self.m_subViewObjResolvers, nDetachFlag)	--no resolver

		if self.m_subViews == nil then
			self.m_subViews = {}
		end
		table.insert(self.m_subViews, subView)

		subView.m_viewOwner = self
		subView:SetViewRoot(self.m_viewRoot)
		subView:OnAttached(self)

		subView.m_viewObj = gameObject
		subView:UpdateSubViewObj()

		if bInvokeOnCreate then
			subView:OnCreateInternal()
			subView:AfterCreateInternal()
		end
		return subView
	end

	function FViewBaseUI:CreateFromObj(gameObject, Root)
		if gameObject == nil then
			error("bad param #2 to CreateFromObj (gameObject expedted, got nil)", 2)
		elseif gameObject.isNil then
			error("bad param #2 to CreateFromObj (gameObject was destroyed)", 2)
		end

		self:SetViewRoot(Root)
		self.m_viewObj = gameObject
		self:UpdateSubViewObj()
		self:OnCreateInternal()
		self:AfterCreateInternal()
	end

	function FViewBaseUI:DetachSubView(subView, bInvokeOnDestroy)
		if not subView:GetOwnerView() then
			logError(("subView(%s) does not attached to any view"):format(tostring(subView)), 2)
			return false
		end

		local subview_index = 0
		local can_be_detached = false
		if self.m_subViews then
			for i, v in ipairs(self.m_subViews) do
				if v == subView then
					subview_index = i
					if type(self.m_subViewObjResolvers[i]) == "number" then
						can_be_detached = true
					end
					break
				end
			end
		end
		if subview_index == 0 then
			logError(string.format("failed to detach. sub view:(%s) is not a child of %s.", tostring(subView), tostring(self)), 2)
			return false
		end

		if can_be_detached and bInvokeOnDestroy then
			if self.m_viewObj then
				subView:OnDestroyInternal()
				subView:AfterDestroyInternal()
			else
				logError("failed to invoke OnDestroyInternal for sub view, viewObj of self could have already been destroyed", 2)
			end
		end
		if subView.m_subViews then
			for j = #subView.m_subViews, 1, -1 do
				local view = subView.m_subViews[j]
				subView:DetachSubView(view, bInvokeOnDestroy)
			end
		end
		subView:BeforeDetached(self)
		if can_be_detached then
			table.remove(self.m_subViews, subview_index)
			table.remove(self.m_subViewObjResolvers, subview_index)
			subView.m_viewRoot = nil
			subView.m_viewOwner = nil
		end
		subView.m_viewObj = nil
		subView:OnDetached(self)
		return true
	end

	function FViewBaseUI:SetVisible(b)
		self:SetVisibleInner(b)
	end


	function FViewBaseUI:IsVisible()
		local obj = self:GetRootObjSafe()
		if obj == nil then return false end

		if obj:IsExtend("FairyGUI.GComponent") then --GComponent
			if obj.displayObject then
				return not not obj.displayObject.visible
			elseif obj.gameObject then
				return obj.gameObject.activeSelf
			end
		else
			return obj.activeSelf
		end
	end

	function FViewBaseUI:SendUIMessage(id, message)
		if self.m_subViews then
			for _, subView in ipairs(self.m_subViews) do
				if not subView:OnUIMessage(self, id, message) then
					subView:SendUIMessage(id, message)
				end
			end
		end
	end

	function FViewBaseUI:CallMethod(methodName, ...)
		if not self:tryget(methodName) then
			return nil
		end

		return self[methodName](self,...)
	end

	function FViewBaseUI:InvokeSubViewsFunction(functionName, ...)
		if self.m_subViews then
			for _, subView in ipairs(self.m_subViews) do
				local f = subView:tryget(functionName)
				if f then f(subView, ...) end
			end
		end
	end

	
	------------------------------------------------------------
	-- End of public
	------------------------------------------------------------
	function FViewBaseUI:SetVisibleInner(b)
		local obj = self:GetRootObjSafe()
		if obj then
			local oldVisible = self:IsVisible()
			if obj.SetActive then
				obj:SetActive(b)
			elseif obj.displayObject then
				obj.displayObject.visible = b
			elseif obj.gameObject then
				obj.gameObject:SetActive(b)
			else
				logError("viewObj not valid ugui or fgui object")
			end
			local newVisible = self:IsVisible()
			if oldVisible ~= newVisible then
				self:OnShowInternal(newVisible)
			end
		end
	end

	function FViewBaseUI:OnUIMessage(subView, id, message)
	end

	function FViewBaseUI:OnCreateInternal()
		self:OnCreate()
		self:InvokeSubViewsFunction("OnCreateInternal")
	end

	function FViewBaseUI:AfterCreateInternal()
		self:AfterCreate()
		self:InvokeSubViewsFunction("AfterCreateInternal")
	end

	function FViewBaseUI:OnDestroyInternal()
		self:OnDestroy()
		if self.m_subViews then
			for i=#self.m_subViews, 1, -1 do
				local subView = self.m_subViews[i]
				local subViewObjResolver = self.m_subViewObjResolvers[i]
				if subViewObjResolver == DetachFlag.AutoDetachAndInvokeDestroy then
					self:DetachSubView(subView, true)
				elseif subViewObjResolver == DetachFlag.AutoDetach then
					self:DetachSubView(subView, false)
				end
			end
		end
		self:InvokeSubViewsFunction("OnDestroyInternal")
		self:disposeCleanerOnDestroy()
	end

	function FViewBaseUI:AfterDestroyInternal()
		self:AfterDestroy()
		self:InvokeSubViewsFunction("AfterDestroyInternal")
	end

	function FViewBaseUI:OnShowInternal(bShow)
		self:OnVisibilityChanged(bShow)
		if self.m_subViews then
			for _, subView in ipairs(self.m_subViews) do
				local f = subView:tryget("OnShowInternal")
				if not bShow then
					if f then f(subView, false) end
				else
					local bVisible = subView:IsVisible()
					if f then f(subView, bVisible) end
				end
			end
		end
		--self:InvokeSubViewsFunction("OnShowInternal")
		--self:callMethod("__OnPanelShow", bShow)
	end

	function FViewBaseUI:SetViewRoot(viewPanel)
		self.m_viewRoot = viewPanel
		self:InvokeSubViewsFunction("SetViewRoot", viewPanel)
	end


	function FViewBaseUI:OnAttached(view) end
	function FViewBaseUI:OnDetached(view) end
	function FViewBaseUI:AfterAttached(view) end
	function FViewBaseUI:BeforeDetached(view) end

	function FViewBaseUI:cleanerOnDestroy()
		local cleaner = self.m_cleanerOnDestroy
		if not cleaner then
			cleaner = GcCallbacks()
			self.m_cleanerOnDestroy = cleaner
		end
		return cleaner
	end
	function FViewBaseUI:disposeCleanerOnDestroy()
		local cleaner = self.m_cleanerOnDestroy
		if cleaner then
			cleaner:dispose()
			self.m_cleanerOnDestroy = nil
		end
	end

	--[[
		子 View 对应的资源是否已加载好
	]]
	function FViewBaseUI:IsSubObjLoaded()
		return self.m_viewObj ~= nil
	end

	--[[
		处理自身 viewObj 变化
		默认递归更新子 View 的 viewObj
	]]

	function FViewBaseUI:UpdateSubViewObj()
		local loaded = self:IsSubObjLoaded()
		if self.m_subViews then
			for i = 1, #self.m_subViews do
				local subView = self.m_subViews[i]
				local subViewObjResolver = self.m_subViewObjResolvers[i]

				if type(subViewObjResolver) == "number" then		--no resolver
					error(("sub view '%s' was not detached before resource unload, on: %s (%s)"):format(tostring(subView), tostring(self), formatGameObjectInfo(self.m_viewObj)), 2)
				end

				if loaded then
					local subViewObj = subViewObjResolver(self)
					if subViewObj == nil then
						logError("resolved sub view obj is nil on: " .. formatGameObjectInfo(self.m_viewObj), 2)
					elseif subViewObj.isNil then
						logError("resolved sub view obj was destroyed on: " .. formatGameObjectInfo(self.m_viewObj), 2)
					end
					subView.m_viewObj = subViewObj
				else
					subView.m_viewObj = nil
				end
				subView:UpdateSubViewObj()
			end
		end
	end
end

return FViewBaseUI
