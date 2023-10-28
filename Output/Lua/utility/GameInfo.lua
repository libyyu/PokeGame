--[[
	为游戏信息查询提供统一接口
	所有信息为只读
	建议：
		信息分为属性和方法，无需参数的信息尽量使用方法，以简化查询
		所有信息名称使用小写字母，单词间用 '_' 符号分隔
	示例：
		local gameinfo = GameInfo.getInfo()
		
		local hostname = gameinfo.host.name
		local isHostMale = gameinfo.host.is_male
		local bHasSkill = gameinfo.host.hasSkill(101)
]]

local TableProxy = require "utility.TableProxy"
local _G = _G

--[[
	GameInfo 是一个环境类，包含以下接口：
		def.static("=>", "table").getInfo: 取得查询用的接口表
		def.static("=>", "table").getRawInfo: 取得内部数据表，内部数据表未设为只读，比 getInfo 所得结果性能稍好
		def.static("string", "dynamic").set: 设置一项数据
]]
local GameInfo = TableProxy.createEnvClass()

------------------------------------
--
-- register basic functions
--
------------------------------------

do
	local globals =
	{
		"assert",
		"error",
		"ipairs",
		"next",
		"pairs",
		"pcall",
		"print",
		"warn",
		"select",
		"tonumber",
		"tostring",
		"type",
		"unpack",
		"xpcall",
		
		--standard libs
		"math",
		"string",
		"table",
		
		--EC lib
		"GameUtil",
		"_G",
	}

	for i = 1, #globals do
		local name = globals[i]
		GameInfo.set(name, _G[name])
	end
end

return GameInfo
