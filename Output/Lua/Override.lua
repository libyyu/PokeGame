do
	local __lua_userdata = {}
	setmetatable(__lua_userdata, {__mode = "k"})
	local mt = LuaHelper.InstanceMeta(UnityEngine.Object)
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

	if FairyGUI and FairyGUI.GObject then
		local mt = LuaHelper.InstanceMeta(FairyGUI.GObject)
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

		local mtComp = LuaHelper.InstanceMeta(FairyGUI.GComponent)
		function mtComp:FindDirect(name)
			if name == "." or name == "" then
				return self
			end
			name = name:replace('.', '/', {plain=true})
			local sb = name:split('/')

			local root = self
			if self:IsExtend("FairyGUI.Window") then
				root = self.contentPane
			end

			local child = FGUIHelper.ToCom(root)
			for i, n in ipairs(sb) do
				child = child:GetChild(n)
				if child and i < #sb and child:IsExtend("FairyGUI.GGroup") then
					child = child.parent
				end
				local child2 = FGUIHelper.ToCom(child)
				if child2 then child = child2 end
				if not child then
					return nil
				end
			end
			return child
		end

		function mtComp:RequireFind(name)
			local child = self:FindDirect(name)
			if not child then
				error("failed to find child'" .. name .. "'")
			end
			return child
		end

		local mtGLoader = LuaHelper.InstanceMeta(FairyGUI.GLoader)
		function mtGLoader:FindDirect(name)
			if name == "." or name == "" then
				local child2 = FGUIHelper.ToCom(self)
				if child2 then 
					return child2
				end
				return self
			end
			name = name:replace('.', '/', {plain=true})
			local sb = name:split('/')

			local child = FGUIHelper.ToCom(self)
			for i, n in ipairs(sb) do
				child = child:GetChild(n)
				if child and i < #sb and child:IsExtend("FairyGUI.GGroup") then
					child = child.parent
				end
				local child2 = FGUIHelper.ToCom(child)
				if child2 then child = child2 end
				if not child then
					return nil
				end
			end
			return child
		end
		function mtGLoader:RequireFind(name)
			local child = self:FindDirect(name)
			if not child then
				error("failed to find child'" .. name .. "'")
			end
			return child
		end
	end
end

do
	local mt = LuaHelper.InstanceMeta(UnityEngine.GameObject)
	function mt:FindDirect(name)
		if name == "." or name == "" then
			return self
		end
		name = name:replace('.', '/', {plain=true})
		local sb = name:split('/')

		local child = self.m_viewObj.transform
		for _, n in ipairs(sb) do
			child = child:Find(n)
			if not child then
				return nil
			end
		end
		return child.gameObject
	end
end

do
	local mt = LuaHelper.InstanceMeta(UnityEngine.UI.Slider)
	function mt:AutoProgress(time, start, to, onfinish)
		local pretimer = self:GetLuaUserData("AutoProgress")
		if pretimer then
			GameUtil.RemoveObjectTimer(self.gameObject, pretimer)
			self:SetLuaUserData("AutoProgress", nil)
		end

		local minValue = self.minValue
		local maxValue = self.maxValue
		to = math.min(to or 0, 100)
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
			if self.isNil then
				return
			end
			--print("tick pro:", currentProgress, to)
			if currentProgress >= to then
				GameUtil.RemoveObjectTimer(self.gameObject, idTimer)
				self:SetLuaUserData("AutoProgress", nil)
				idTimer = 0
				if onfinish then onfinish() end
				return
			end
			local newProgress = math.min(currentProgress + speed * (UnityEngine.Time.realtimeSinceStartup - last), to)
			self.normalizedValue = newProgress/100
			currentProgress = newProgress
			last = UnityEngine.Time.realtimeSinceStartup
		end)

		self:SetLuaUserData("AutoProgress", idTimer)
	end
	if FairyGUI and FairyGUI.GProgressBar then
		local mt = LuaHelper.InstanceMeta(FairyGUI.GProgressBar)
		function mt:AutoProgress(time, start, to, onfinish)
			local pretimer = self:GetLuaUserData("AutoProgress")
			if pretimer then
				GameUtil.RemoveObjectTimer(self.displayObject.gameObject, pretimer)
				self:SetLuaUserData("AutoProgress", nil)
			end

			local minValue = self.min
			local maxValue = self.max
			to = math.min(to or 0, 100)
			start = math.min(start or 0, 100)
			start = math.max(self.value, start)
			print("AutoProgress", time, start, to)
			if not time or time == 0 then time = 0.1 end 
			local last = UnityEngine.Time.realtimeSinceStartup
			local speed = (to - start) / time
			local target = 0
			local idTimer = 0
			local currentProgress = start
			local UPDATE_INTERVAL = 0.2
			self.value = currentProgress
			idTimer = GameUtil.AddObjectTimer(self.displayObject.gameObject, 0, false, function()
				if self.displayObject.gameObject.isNil then
					return
				end
				--print("tick pro:", currentProgress, to)
				if currentProgress >= to then
					GameUtil.RemoveObjectTimer(self.displayObject.gameObject, idTimer)
					self:SetLuaUserData("AutoProgress", nil)
					idTimer = 0
					if onfinish then onfinish() end
					return
				end
				local newProgress = math.min(currentProgress + speed * (UnityEngine.Time.realtimeSinceStartup - last), to)
				self.value = newProgress
				currentProgress = newProgress
				last = UnityEngine.Time.realtimeSinceStartup
				--print("tick newProgress:", currentProgress, to)
			end)

			self:SetLuaUserData("AutoProgress", idTimer)
		end
	end
end