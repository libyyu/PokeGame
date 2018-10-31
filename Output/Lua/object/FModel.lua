local FModel = FLua.Class("FModel")

do
	local ModelStatus = { NORMAL = 0, LOADING = 1, DESTROY = 2}


	function FModel:_ctor()
		self.m_asset = nil
		self.m_model = nil 
		self.m_ani = nil
		self.m_status = ModelStatus.NORMAL  
		self.m_resName = ""
		self.m_abName = ""
		self.m_visible = false
	end

	function FModel:Load(abname,resname,cb)
		local function loaded(obj)
			if self.m_status == ModelStatus.DESTROY then
				return
			end
			if not obj then 
				cb(false)
				return 
			end
			local m = Instantiate(obj)
			self.m_model = m		
			self.m_asset = obj
			self.m_ani = m:GetComponent("Animation")
			self.m_status = ModelStatus.NORMAL
			self.m_visible = true
			if cb then cb(self) end
		end
		self:Destroy()
		self.m_resName = resname
		self.m_abName = abname
		
		self.m_status = ModelStatus.LOADING
		AsyncLoad(abname,resname, loaded)
	end

	function FModel:Destroy()
		self.m_status = ModelStatus.DESTROY
		
	end

	function FModel:Play(aniname) 
		local ani = self.m_ani
		if not ani then return end
		ani:Play(aniname,1)--UnityEngine.PlayMode.StopSameLayer)
	end

	function FModel:CrossFade(aniname, fade) 
		local ani = self.m_ani
		if not ani then return end
		if fade == 0 then
			ani:Play(aniname,1)--UnityEngine.PlayMode.StopSameLayer)
		else
			ani:CrossFade(aniname,fade,1)--UnityEngine.PlayMode.StopSameLayer)
		end
	end

	function FModel:WrapMode(mode)
		local ani = self.m_ani
		if not ani then return end
		ani.wrapMode = mode
	end
end

return FModel
