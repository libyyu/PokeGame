--[[
	class GcCallbacks
	execute callbacks on gc
]]

local newproxy = newproxy
local getmetatable = getmetatable
local setmetatable = setmetatable
local error = error
local pairs = pairs
local tostring = tostring
local type = type
local _G = _G
local _VERSION = _VERSION
local is_5_1 = (_VERSION == "Lua 5.1")
local _ENV = nil


---@class GcCallbacks:System.Object
---@field protected m_gcProxy any
---@field protected m_proxyCallback function
---@field protected m_callbacks table
---@field protected m_needDisposeErrMsg any
---@field public Commit fun():GcCallbacks
---@field public add fun(self:GcCallbacks, callback:function)
---@field public dispose fun(self:GcCallbacks)
---@field public setNeedDispose fun(self:GcCallbacks, errMsg:string)
---@field public checkGcProxy fun(self:GcCallbacks)
local GcCallbacks = FLua.Class()
do
	--
	-- utilities
	--
	local function clearTable (t)
		for k, _ in pairs(t) do
			t[k] = nil
		end
	end
	
	local createGcProxy
	if is_5_1 then
		function createGcProxy (callback)
			local proxy = newproxy(true)
			local meta = getmetatable(proxy)
			meta.__gc = callback
			return proxy
		end
	else
		function createGcProxy (callback)
			local proxy = {}
			local meta = {}
			meta.__gc = callback
			return setmetatable(proxy, meta)
		end
	end
	
	local function checkNonNil (obj, who, argIndex, errLevel)
		if obj == nil then
			error(([[bad argument #%d to %s in 'GcCallbacks' (Non-nil expected, got nil)]]):format(argIndex, who, type(obj)), errLevel+1)
		end
	end

	---------------------------------
	--
	-- public methods
	--
	---------------------------------
	
	--[[
		add callback on gc
		param callback: function to be called on gc
	]]

	---@param self GcCallbacks
	---@param callback function
	---@return void
	function GcCallbacks:add(callback)
		checkNonNil(callback, "add", 2, 2)

		self:checkGcProxy()
		local callbacks = self.m_callbacks
		callbacks[#callbacks+1] = callback
	end
	
	--[[
		call callbacks manually, and clear callbacks
	]]

	---@param self GcCallbacks
	---@return void
	function GcCallbacks:dispose()
		self.m_needDisposeErrMsg = nil
		
		local proxyCallback = self.m_proxyCallback
		if proxyCallback then
			proxyCallback()
		end
	end
	
	--[[
		set GcCallback to expect dispose
		If dispose is not invoked, GcCallback will report an error on gc
		
		param errMsg: add into error info when report error
	]]

	---@param self GcCallbacks
	---@param errMsg string
	---@return void
	function GcCallbacks:setNeedDispose(errMsg)
		self.m_needDisposeErrMsg = errMsg or ""
	end
	
	---------------------------------
	--
	-- END of public
	--
	---------------------------------
	function GcCallbacks:__constructor()
		self.m_gcProxy = nil 
		self.m_proxyCallback = nil 
		self.m_callbacks = nil
		self.m_needDisposeErrMsg = nil
	end

	-- create gc proxy if need

	---@param self GcCallbacks
	---@return void
	function GcCallbacks:checkGcProxy()
		if self.m_gcProxy == nil then
			self.m_callbacks = {}
			
			local function proxyCallback ()
				if self.m_needDisposeErrMsg then
					warn("dispose need to be invoked: " .. tostring(self.m_needDisposeErrMsg), 2)
				end
				
				local callbacks = self.m_callbacks
				for i = 1, #callbacks do
					local f = callbacks[i]
					if f then	--in case that dispose in callback
						f()
					end
				end
				clearTable(callbacks)
			end
			
			self.m_gcProxy = createGcProxy(proxyCallback)
			self.m_proxyCallback = proxyCallback
		end
	end
end

return GcCallbacks
