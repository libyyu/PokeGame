do
	local mt = LuaHelper.InstanceMeta(UnityEngine.Object)
	local __lua_userdata = {}
	setmetatable(__lua_userdata, {__mode = "k"})
	function mt:SetLuaUserData(key, value)
		local t = rawget(__lua_userdata, self)
		if not t then
			t = {}
			rawset(__lua_userdata, self, t)
		end
		t[key] = value
	end
	function mt:GetLuaUserData(key)
		local t = rawget(__lua_userdata, self)
		if not t then
			return nil
		end
		return t[key]
	end
end

do
	local mt = LuaHelper.InstanceMeta(UnityEngine.GameObject)
end

do
	local mt = LuaHelper.InstanceMeta(UnityEngine.UI.Slider)
	function mt:AutoProgress(time, to, start)
		local minValue = self.minValue
		local maxValue = self.maxValue
		to = math.max(to or 0, 100)
		start = math.min(start or 0, 100)
		start = math.max(self.normalizedValue*100, start)
		print("AutoProgress", time, start, to)
		if not time or time == 0 then time = 0.1 end 
		local last = UnityEngine.Time.realtimeSinceStartup
		local speed = (to - start) / time
		local target = 0
		local idTimer = 0
		local currentProgress = start
		local UPDATE_INTERVAL = 0.2
		self.normalizedValue = currentProgress/100
		--idTimer = GameUtil.AddGlobalTimer(0.1, false, function()
		idTimer = GameUtil.AddObjectTimer(self.gameObject, 0.1, false, function()
			if self.isNil or currentProgress >= to then
				GameUtil.RemoveObjectTimer(self.gameObject, idTimer)
				idTimer = 0
				return
			end
			local newProgress = math.min(currentProgress + speed * (UnityEngine.Time.realtimeSinceStartup - last), to)
			self.normalizedValue = newProgress/100
			currentProgress = newProgress
			last = UnityEngine.Time.realtimeSinceStartup
			return
		end)
	end
end