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
		local last = UnityEngine.Time.realtimeSinceStartup
		local speed = (to - start) / time
		local target = 0
		local idTimer = 0
		local currentProgress = start
		local UPDATE_INTERVAL = 0.2
		self.normalizedValue = currentProgress/100
		idTimer = LuaTimer.Add(0, 0.2, function()
			if self.isNil or currentProgress >= to then
				LuaTimer.Delete(idTimer)
				idTimer = 0
				return
			end
			speed = math.max(to - currentProgress, 0) / UPDATE_INTERVAL / 2
			local newProgress = math.min(currentProgress + speed * (UnityEngine.Time.realtimeSinceStartup - last), to)
			self.normalizedValue = newProgress/100
			currentProgress = newProgress
			last = UnityEngine.Time.realtimeSinceStartup
		end)
	end
end