local FObject = require "object.FObject"
local FPlayer = FLua.Class("FPlayer",FObject)

do
	function FPlayer:_ctor()
		self.m_IsHost = false
		self.m_IsReady = false
	end

	function FPlayer:Create(resname)
		self:LoadModel("Player",resname,function(model)
			self:OnLoaded(model.m_model)
		end)
	end

	function FPlayer:OnLoaded(obj)
	end
end


return FPlayer
