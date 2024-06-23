--[[
	辅助把 GcCallbacks 当作 cleaner
]]

local GcCallbacks = require "Utility.GcCallbacks"

local CleanerHelper = FLua.StaticClass()
do
	--[[
		(在类的定义过程中) 增加一个 cleaner
		
		param definer: 类的 define
		param getterName: 取得 cleaner 的函数名。此函数无 cleaner 时会自动创建一个
		param disposerName: dispose 并清除 cleaner 的函数名。此函数无 cleaner 时无操作
	]]

	---@param definer any
	---@param getterName string
	---@param disposerName string
	---@return void
	function CleanerHelper.defineCleaner(obj, getterName, disposerName)
		local cls = obj:GetClass()
		local cleanerFieldName = "m_" .. getterName
		
		obj[cleanerFieldName] = nil
		if not cls[getterName] then
			cls[getterName] = function (self)
				local cleaner = self[cleanerFieldName]
				if not cleaner then
					cleaner = GcCallbacks()
					self[cleanerFieldName] = cleaner
				end
				return cleaner
			end
			
			cls[disposerName] = function (self)
				local cleaner = self[cleanerFieldName]
				if cleaner then
					cleaner:dispose()
					self[cleanerFieldName] = nil
				end
			end
		end
	end
end

return CleanerHelper
