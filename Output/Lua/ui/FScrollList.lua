
local FViewBaseUI = require "ui.FViewBaseUI"

local FScrollList = FLua.Class(FViewBaseUI, "FScrollList")

local FViewWrapper = FLua.Class(FViewBaseUI)
do
	function FViewWrapper:__constructor()
		self._view = nil
		self._list = nil
	end

	function FViewWrapper.Create(list)
		local wrapper = FViewWrapper()
		wrapper._list = list
		return wrapper
	end

	function FViewWrapper:OnDestroy()
		if self._view then
			self:DetachSubView(self._view, true)
			self._view = nil
		end
	end

	function FViewWrapper:BeforeDetached()
	    self:SetView(nil, false, true)
	end

	function FViewWrapper:SetView(view, invoke_on_create, invoke_on_destroy)
		if self._view == view then
			if not view or view:GetRootView() ~= nil then
				return
			end
		end
		if self._view ~= view then
			if self._view and self._view:GetOwnerView() then
				self:DetachSubView(self._view, invoke_on_destroy)
			end
			self._view = nil
			if view and view:GetOwnerView() ~= nil then
				view:GetOwnerView():SetView(nil, invoke_on_create, invoke_on_destroy)
			end
		end

		if view then
			self._view = view
			self:AttachSubView(self.m_viewObj, view, invoke_on_create)
		end
	end

	function FViewWrapper:GetWrappedView()
		return self._view
	end
end


function FScrollList:__constructor()
	self._view_list = {}
	self._data_list = nil
	self._obj_wrapper_map = setmetatable({}, {__mode = "k"})
	self._item_view_constructor = nil
	self._item_update_func = nil
	self._is_inited = false
end

function FScrollList.Create(item_view_constructor, item_update_func)
	if not item_update_func then
		error("[FScrollList]update function can not be nil.")
	end
	local view = FScrollList()
	view._item_view_constructor = item_view_constructor
	view._item_update_func = item_update_func
	return view
end

function FScrollList:SetCountNoForceUpdate(count)
	local old_count = self:GetCount()
	local new_count = math.max(count, 0)
	local cur_view_count = #self._view_list
	if new_count < cur_view_count then
		for i = cur_view_count, new_count + 1, -1 do
			local view = self._view_list[i]
			if view then
				if view.m_viewObj and not view.m_viewObj.isNil then
					local wrapper = self._obj_wrapper_map[view.m_viewObj]
					if wrapper then
						wrapper:SetView(nil, false, true)
					end
				end
				table.remove(self._view_list, i)
			end
		end
		local exist_obj_map = {}
		for i = 1, new_count do
			local itemObj = self:GetItemObj(i)
			if itemObj then
				exist_obj_map[itemObj] = true
			end
		end
		for k, v in pairs(self._obj_wrapper_map) do
			if v:GetRootView() ~= nil and (not v:IsValid() or not exist_obj_map[v.m_viewObj]) then
				self:DetachSubView(v, true)
				self._obj_wrapper_map[k] = nil
			end
		end
	end

	self.m_viewObj.numItems = count

	return old_count ~= new_count
end

function FScrollList:SetCount(count, ...)
	local old_count = self:GetCount()
	local new_count = math.max(count, 0)
	local force_update = select(1, ...)
	force_update = force_update == nil and true or force_update
	self:SetCountNoForceUpdate(count)
	if force_update and new_count == old_count then
		self:ForceUpdate()
	end
end

function FScrollList:ForceUpdate()
	self.m_viewObj:RefreshVirtualList()
end

function FScrollList:GetCount()
	return self.m_viewObj.numItems
end

function FScrollList:_Init()
	if not self:IsValid() or self._is_inited then
		return
	end
	if not self.m_viewObj:IsExtend("FairyGUI.GList") then
		error(string.format("[FScrollList] object <%s> is not a ScrollList.", tostring(self.m_viewObj)))
	end
	self.m_viewObj:SetVirtual()
	self.m_viewObj.itemRenderer = function(index, itemObj)
		if not self._is_inited then
			return
		end
		if self._item_view_constructor then
			local wrapper = self._obj_wrapper_map[itemObj]
			if not wrapper then
				wrapper = FViewWrapper.Create(self)
				self._obj_wrapper_map[itemObj] = wrapper
			end
			if not wrapper:GetOwnerView() then
				self:AttachSubView(itemObj, wrapper, true)
			end
			local view = self._view_list[index]
			local view_not_exist = view == nil
			if view_not_exist then
				view = self._item_view_constructor(itemObj, index)
				if not view then
					error("[FScrollList] invalid item view constructor: return value nil.")
				end
				self._view_list[index] = view
			end
			wrapper:SetView(view, true, true)
			self:TrySetViewData(view, index)
			self._item_update_func(view, index)
		else
			self._item_update_func(itemObj, index)
		end
	end
	self._is_inited = true
end

function FScrollList:OnCreate()
	self:_Init()
end

function FScrollList:GetItem(index)
	if self._item_view_constructor then
		return self._view_list[index]
	else
		return self:GetItemObj(index)
	end
end

function FScrollList:GetAllItem()
	return self._view_list
end

function FScrollList:GetItemObj(index)
	local childIndex = self.m_viewObj:ItemIndexToChildIndex(index-1)
	return self.m_viewObj:GetChild(childIndex)
end


function FScrollList:OnDestroy()
	self._data_list = nil
	self._is_inited = false
end

function FScrollList:_GetWrappedView(index)
	local obj = self:GetItemObj(index)
	local wrapper = obj and self._obj_wrapper_map[obj]
	return wrapper and wrapper:GetWrappedView()
end

function FScrollList:SetDataList(data_list)
	self._data_list = data_list
	self:SetCount(#data_list, true)
end

function FScrollList:TrySetViewData(view, index)
	local data = self._data_list and self._data_list[index]
	if view and data then
		if view:tryget("SetData") then
			view:SetData(data)
		else
			error(string.format("[ECScrollList]must implement method <SetData> for view(%s) before calling <SetDataList>.", view))
		end
	end
end

function FScrollList:BeforeDetached(view)
    self:SetCount(0, false)
	self.m_viewObj.itemRenderer = nil
end

function FScrollList:GetDataList()
	return self._data_list
end

return FScrollList