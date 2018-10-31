local FModel = require "object.FModel"
local FObjInfo = require "object.FObjInfo"

local FObject = FLua.Class("FObject")

do
	function FObject:_ctor()
		self.m_InfoData = nil
		self.m_Model = nil 
		self.OnLoadedCallbacks = {}
	end

	function FObject:LoadModel(abName,resName,cb)
		local m = FModel.new()
		m:Load(abName,resName,function(ret)
			if ret then
				self.m_Model = ret
			end
			if cb then cb(ret) end
		end)
	end

	function FObject:Destroy()
		if self.m_Model then
			self.m_Model:Destroy()
		end
	end

	function FObject:Play(aniname,mode)
		if self.m_Model then
			self.m_Model:WrapMode(mode)
			self.m_Model:Play(aniname)
		end
	end

	function FObject:CrossFade(aniname, fade) 
		if self.m_Model then
			if fade == 0 then
				self.m_Model:Play(aniname,UnityEngine.PlayMode.StopSameLayer)
			else
				self.m_Model:CrossFade(aniname,fade,UnityEngine.PlayMode.StopSameLayer)
			end
		end
	end

	function FObject:WrapMode(mode)
		if self.m_Model then
			self.m_Model:WrapMode(mode)
		end
	end

end

return FObject
