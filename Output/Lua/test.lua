local M = {}

function M:Awake()
	print("file Awake", self.component)
end

function M:Start()
	print("file start", self.component)
end

return M