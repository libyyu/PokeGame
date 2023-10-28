local newproxy = newproxy
local getmetatable = getmetatable
local pairs = pairs

-----------------------------------
-- helpers
-----------------------------------

local function checkNonNil (value, who, argIndex, errLevel)
	if value == nil then
		error(([[bad argument #%d to %s in 'TableProxy' (non-nil expected, got nil)]]):format(argIndex, who), errLevel+1)
	end
end

local function checkSimpleType (value, who, argIndex, needType, errLevel)
	if type(value) ~= needType then
		error(([[bad argument #%d to %s in 'TableProxy' (%s expected, got %s)]]):format(argIndex, who, needType, type(value)), errLevel+1)
	end
end


local TableProxy = FLua.StaticClass()
do
	local function createProxy (__index)
		local proxy = newproxy(true)
		local meta = getmetatable(proxy)
		meta.__index = __index
		function meta.__newindex (t, k)
			error("bad writing to readonly table with key: " .. tostring(k), 2)
		end
		
		return proxy
	end
	
	local function createTable (__index)
		return setmetatable({}, {__index=__index})
	end
	
	--[[
		创建只读表
		param table: 实际数据
	]]

	---@param table table
	---@return table
	function TableProxy.createReadonlyTable(t)
		return createTable(t)
	end
	
	--[[
		创建只读proxy (比表性能稍好)
		param table: 实际数据
	]]

	---@param table table
	---@return userdata
	function TableProxy.createReadonlyProxy(t)
		return createProxy(t)
	end
	
	local function getPropertyTableIndexer (propertyTable, table, who)
		checkNonNil(propertyTable, who, 3)
		
		--检查 property 是否只包含函数
		for k, v in pairs(propertyTable) do
			if type(v) ~= "function" then
				error(("bad argument #1 to '%s' (non function value with key: %s)"):format(who, tostring(k)), 3)
			end
		end
		
		return function (t, k)
			local prop = propertyTable[k]
			if prop then
				return prop()
			else
				if table then
					return table[k]
				else
					return nil
				end
			end
		end
	end
	
	--[[
		创建包含属性的只读表
		param propertyTable: 实际包含属性的 table，各属性为函数，调用后得到最终值
		param table: 实际数据
	]]

	---@param propertyTable table
	---@param table table
	---@return table
	function TableProxy.createReadonlyPropertyTable(propertyTable, t)
		return createTable(getPropertyTableIndexer(propertyTable, t, "createReadonlyPropertyTable"))
	end
	
	--[[
		创建包含属性的只读proxy (比表性能稍好)
		param propertyTable: 实际包含属性的 table，各属性为函数，调用后得到最终值
		param table: 实际数据
	]]

	---@param propertyTable table
	---@param table table
	---@return userdata
	function TableProxy.createReadonlyPropertyProxy(propertyTable, t)
		return createProxy(getPropertyTableIndexer(propertyTable, t, "createReadonlyPropertyTable"))
	end

	--[[
		创建一个类，以对外提供环境，类中有 getInfo，getRawInfo，set 等函数
	]]

	---@return EnvClass
	function TableProxy.createEnvClass()

		local EnvClass = FLua.StaticClass()
		do

			local infoMap = {}
			local infoMapProxy = TableProxy.createReadonlyProxy(infoMap)
			local infoEnv = TableProxy.createReadonlyTable(infoMap)
			
			--[[
				取得查询用的接口表
				return: 查询用的接口表，此值不会变化
			]]

			---@return userdata
			function EnvClass.getInfo()
				return infoMapProxy
			end

			--[[
				取得内部数据表，内部数据表未设为只读，比 getInfo 所得结果性能稍好
				return: 内部数据表，此值不会变化
			]]

			---@return table
			function EnvClass.getRawInfo()
				return infoMap
			end

			--[[
				取得作为运行环境的数据表
				return: 作为运行环境的数据表，此值不会变化
			]]

			---@return table
			function EnvClass.getEnv()
				return infoEnv
			end

			--[[
				设置一项数据
				param name: 数据的名字，以此值为 key 访问数据
				param value: 数据的值，本身尽量保持只读
			]]

			---@param name string
			---@param value any
			---@return void
			function EnvClass.set(name, value)
				infoMap[name] = value
			end
		end
	end
end

return TableProxy
