local FObject = require "object.FObject"
local FPlayer = FLua.Class(FObject, "FPlayer")

do
	function FPlayer:__constructor()
		self.m_IsHost = false
		self.m_IsReady = false
	end

	function FPlayer:Create(resname)
		local abName = TransformABName(resname)
		self:LoadModel(abName,resname,function(model)
			self:OnLoaded(model.m_model)
		end)
	end

	function FPlayer:OnLoaded(obj)
	end
end


return FPlayer
