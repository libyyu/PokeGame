local Callbacks = require "utility.Callbacks"
local FWorld = FLua.Class("FWorld")

function FWorld:__constructor()
	self.m_IsReady = false
	self.m_WorldInfo = nil
	self.m_CurWorld = nil
	self.m_OnWorldLoadedCallbacks = nil
end

function FWorld:Init(data)
	self.m_WorldInfo = data
end

function FWorld:OnWorldLoaded()
end

function FWorld:Load(onFinish)
	if onFinish then
		self:AddWorldLoadedCallback(onFinish)
	end

	AsyncLoad(ResPathReader.MainWorld, function(asset)
		local goMap = Instantiate(asset)
		goMap.transform.localPosition = Vector3(0, 0, 0)
		goMap.transform.localScale = Vector3(1, 1, 1)
		self.m_CurWorld = goMap
		self:OnWorldLoaded()

		if self.m_OnWorldLoadedCallbacks then
			self.m_OnWorldLoadedCallbacks:invokeAndClear(self)
		end
	end)
end

function FWorld:AddWorldLoadedCallback(callback)
	if self.m_IsReady then
		callback(self)
		return
	end

	if not self.m_OnWorldLoadedCallbacks then
		self.m_OnWorldLoadedCallbacks  = Callbacks()
	end

	self.m_OnWorldLoadedCallbacks:add(callback)
end




return FWorld