local M = {}

function M:Awake()
	print("M:Awake", self)--, self.component)
end

function M:Start()
	print("M:Start", self, self.component, self.gameObject)
end

function M:onClick(go)
	print("M:onClick", self, go)
	local id = tonumber(self.transform:Find("idHidden"):GetComponent("Text").text)

	FireEvent(EventDef.MainTabSelect, id)
end

function M:UpdateData(data)
	self.transform:Find("Text"):GetComponent("Text").text = data.name
	self.transform:Find("idHidden"):GetComponent("Text").text = tostring(data.id)
end

return M