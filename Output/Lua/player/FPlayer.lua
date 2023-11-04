local FObject = require "object.FObject"
local FPlayer = FLua.Class(FObject, "FPlayer")

do
	function FPlayer:__constructor()
		self.m_IsHost = false
		self.m_IsReady = false
		self.OnLoadedCallbacks = nil
	end

	function FPlayer:OnLoaded()

	end

	function FPlayer:AddLoadedCallback(callback)
		if self.m_IsReady then
			callback()
		else
			if not self.OnLoadedCallbacks then
				self.OnLoadedCallbacks = {}
			end
			table.insert(self.OnLoadedCallbacks, callback)
		end
	end

	function FPlayer:Load(onFinish)
		self:AddLoadedCallback(onFinish)
		local resName = self.m_InfoData.ResPath
		local abName = TransformABName(resName)
		self:LoadModel(abName, resName, function(model)
			self.m_IsReady = true
			self:OnLoaded()
			local callbacks = self.OnLoadedCallbacks
			self.OnLoadedCallbacks = nil
			if callbacks then
				for _, f in ipairs(callbacks) do
					f(self)
				end
			end
		end)
	end
end


return FPlayer
