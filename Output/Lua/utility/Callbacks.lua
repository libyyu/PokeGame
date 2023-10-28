local Callbacks = FLua.Class()

function Callbacks.new(name)
	local obj = Callbacks()
	if name then
		obj.name = name
	end
end

function Callbacks:__constructor()
	self.name = "unknow"
	self.callbacks = nil
end

function Callbacks:add(func)
	local callbacks = self.callbacks
	if not callbacks then
		callbacks = {}
		self.callbacks = callbacks
	end
	callbacks[#callbacks+1] = func
end

function Callbacks:remove(func)
	local callbacks = self.callbacks
	if callbacks then
		for i=1, #callbacks do
			if callbacks[i] == func then
				table.remove(callbacks, i)
				break
			end
		end
	end
end

function Callbacks:invoke(...)
	local callbacks = self.callbacks
	if callbacks then
		for _, func in ipairs(callbacks) do
			func(...)
		end
	end
end

function Callbacks:invokeAndClear(...)
	local callbacks = self.callbacks
	self.callbacks = nil
	if callbacks then
		for _, func in ipairs(callbacks) do
			func(...)
		end
	end
end


return Callbacks