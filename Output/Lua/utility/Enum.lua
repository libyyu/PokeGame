local type = type
local string = string
local stringmatch = string.match

local Enum = FLua.StaticClass()
do
	--[[
		定义一个C风格枚举
		param definition: 格式如下
		{
			"var-name-0",		-- 只写枚举名时，自动递增各枚举值，首值从 0 开始
			"var-name-1",		-- value == 1
			"var-name-2", "=", var-value-2,		-- 在枚举名后加上 "=" 和值，显式设置枚举值
			"var-name-3", "=", "other-var-name",	-- 在枚举名后加上 "=" 和其他枚举名，显式设置为其他枚举名关联的枚举值
		}
	]]
	function Enum.make(definition)
		local defLen = #definition
		local curPos = 1
		local curValue = 0
		local curIndex = 1
		local result = {}

		while curPos <= defLen do
			-- the name
			local name = definition[curPos]
			if type(name) ~= "string" then
				error(("bad enumerate #%d item name (string expected, got %s)"):format(curIndex, type(name)))
			end
			if result[name] then
				error(("duplicated enumerate #%d item name (%s)"):format(curIndex, name))
			end
			if not stringmatch(name, "^[%a_][%w_]*$") then
				error(("invalid enumerate #%d item name ('%s')"):format(curIndex, name))
			end

			local value
			-- "="
			if definition[curPos + 1] == "=" then		--显式设值
				local assignedValue = definition[curPos + 2]
				if type(assignedValue) == "number" then
					value = assignedValue
				elseif type(assignedValue) == "string" then
					value = result[assignedValue]
					if value == nil then
						error(("enumerate #%d item assigning value not found ('%s')"):format(curIndex, assignedValue))
					end
				else
					error(("bad assigning value to enumerate #%d item (string expected, got %s)"):format(curIndex, type(assignedValue)))
				end

				curPos = curPos + 3
			else	--隐式设值
				value = curValue

				curPos = curPos + 1
			end

			result[name] = value
			curValue = value + 1
			curIndex = curIndex + 1
		end

		return result
	end
end

return Enum
