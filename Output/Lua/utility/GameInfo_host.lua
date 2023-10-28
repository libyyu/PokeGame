--[[
	为 DynamicText 提供主角相关的数据
]]

local Lplus = require "Lplus"
local GameInfo = require "Utility.GameInfo"
local TableProxy = require "Utility.TableProxy"
---@type ECHostPlayer
local ECHostPlayer = Lplus.ForwardDeclare "ECHostPlayer"

-- 缓存 hostPlayer 引用。此值可能为 nil
---@type ECHostPlayer
local l_hostplayer

-----------------------------
-- properties
-----------------------------

local HostProperty = {}
do
	local host = HostProperty

	function host.name ()
		if l_hostplayer then
			return l_hostplayer.InfoData.Name
		else
			return ""
		end
	end

	function host.id ()
		if l_hostplayer then
			return LuaUInt64.ToString(l_hostplayer.ID)
		else
			return LuaUInt64.ToString(ZeroUInt64)
		end
	end

	function host.level ()
		if l_hostplayer then
			return l_hostplayer.InfoData.Lv
		else
			return 0
		end
	end

	function host.gender ()
		if l_hostplayer then
			return l_hostplayer:GetActiveGender()
		else
			if _G.GIsAVGEditor then
				local avg_configs = _G.require_config("Configs/avg_configs.lua")
				return avg_configs.host_gender_for_editor
			else
				return 0
			end
		end
	end

	function host.gender_name()
		if l_hostplayer then
			if l_hostplayer:GetActiveGender() == _G.CONSTANT_DEFINE.GENDER_ENUM.GENDER_MALE then
				return "male"
			else
				return "female"
			end
		else
			return ""
		end
	end

	function host.is_male ()
		if l_hostplayer then
			return l_hostplayer:GetActiveGender() == 0
		else
			if _G.GIsAVGEditor then
				local avg_configs = _G.require_config("Configs/avg_configs.lua")
				return avg_configs.host_gender_for_editor == 0
			else
				return true
			end
		end
	end

	function host.profession ()
		if l_hostplayer then
			return l_hostplayer.InfoData.Prof
		else
			return 0
		end
	end
	
	function host.portrait ()
		if l_hostplayer then
			local isMale = l_hostplayer.InfoData.Gender == 0
			return isMale and 624 or 623
		else
			return 0
		end
	end
	
	function host.icon ()
		if l_hostplayer then
 			local idphoto = l_hostplayer.InfoData.idPhoto
			return idphoto
		else
			return ZeroUInt64
		end
	end
	
	function host.fight_data ()
		if l_hostplayer then
			return l_hostplayer.InfoData.FightData
		else
			return nil
		end
	end

	function host.self_camp()
		if not l_hostplayer then return "" end
		local faction = l_hostplayer.Faction
		if not faction then return "" end

		local faction_cfg = _G.require_config("Configs/faction_cfg.lua")
		local side = faction._support_side == 1 and 1 or 2
		return faction_cfg.support_side_cfg[side].name
	end

	function host.enemy_camp()
		if not l_hostplayer then return "" end
		local faction = l_hostplayer.Faction
		if not faction then return "" end

		local faction_cfg = _G.require_config("Configs/faction_cfg.lua")
		local side = faction._support_side == 1 and 2 or 1
		return faction_cfg.support_side_cfg[side].name
	end

	function host.control_type ()
		if l_hostplayer then
			return l_hostplayer:GetBeControledType()
		else
			return 0
		end
	end
end

-----------------------------
-- methods
-----------------------------

---@class HostMethod:System.Object
---@field public Commit fun():HostMethod @notnull
---@field public has_skill fun(skill_id:number):boolean
---@field public skill_level fun(skill_id:number):number
---@field public buff_info fun():table
---@field public has_task fun(task_id:number):boolean
---@field public task_finished fun(task_id:number):boolean
---@field public faction_reputation fun(reputation_id:number):number
---@field public reputation fun(reputation_id:number):number
---@field public handbook_is_activated fun(handbook_tid:number):boolean
---@field public is_in_region fun(...:any):boolean
local HostMethod = Lplus.Class()
do
	local def = HostMethod.define

	---@param skill_id number
	---@return boolean
	def.static("number", "=>", "boolean").has_skill = function (skill_id)
		if l_hostplayer then
			local userskill = l_hostplayer:GetUserSkill(skill_id)
			if userskill then
				return true
			end
		end
		
		return false	--not found
	end

	---@param skill_id number
	---@return number
	def.static("number", "=>", "number").skill_level = function (skill_id)	
		if l_hostplayer then
			local userskill = l_hostplayer:GetUserSkill(skill_id)
			if userskill then			
				return userskill:GetLevel()
			end
		end
		return 0	--not found
	end

	---@return table
	def.static("=>","table").buff_info = function ()
		if l_hostplayer then
			return l_hostplayer.m_buffStates
		else
			return {}
		end
	end

	---@param task_id number
	---@return boolean
	def.static("number", "=>", "boolean").has_task = function (task_id)
		local ECTaskInterface = require "Task.ECTaskInterface"
		return ECTaskInterface.HasTask(task_id)
	end

	---@param task_id number
	---@return boolean
	def.static("number", "=>", "boolean").task_finished = function (task_id)
		local ECTaskInterface = require "Task.ECTaskInterface"
		return ECTaskInterface.TaskHasFinished(task_id)
	end

	---@param reputation_id number
	---@return number
	def.static("number", "=>", "number").faction_reputation = function (reputation_id)
		if l_hostplayer then
			return l_hostplayer:GetFactionReputation(reputation_id)
		end
		
		return 0
	end

	---@param reputation_id number
	---@return number
	def.static("number", "=>", "number").reputation = function (reputation_id)
		if l_hostplayer then
			return l_hostplayer:GetReputation(reputation_id)
		end
		
		return 0
	end

	---@param handbook_tid number
	---@return boolean
	def.static("number", "=>", "boolean").handbook_is_activated = function (handbook_tid)
		local ECHandbookData = require "GUI.Handbook.ECHandbookData"
		return ECHandbookData.Instance():CheckHandbookIsActivated(handbook_tid)
	end

	---@param ... any
	---@return boolean
	def.static("varlist", "=>", "boolean").is_in_region = function (...)
		local regions = {...}
		local ECHostConditionOp = require "Players.ECHostConditionOp"
		local conditionOp = ECHostConditionOp.Maker.is_in_region(regions)
		if not conditionOp:hasState() then
			return false
		end
		return conditionOp:getState()
	end
end
HostMethod.Commit()

-----------------------------
-- register
-----------------------------

local l_hostInfo = TableProxy.createReadonlyPropertyProxy(HostProperty, HostMethod)
GameInfo.set("host", l_hostInfo)

-----------------------------
-- contoller
-----------------------------

---@class GameInfo_host:System.Object
---@field public Commit fun():GameInfo_host @notnull
---@field public setHostPlayer fun(hostplayer:ECHostPlayer)
local GameInfo_host = Lplus.Class()
do
	local def = GameInfo_host.define
	
	--[[
		更新当前 HostPlayer。应当在 HostPlayer 创建及销毁时调用
	]]

	---@param hostplayer ECHostPlayer
	---@return void
	def.static(ECHostPlayer).setHostPlayer = function (hostplayer)
		l_hostplayer = hostplayer
	end
end

return GameInfo_host.Commit()