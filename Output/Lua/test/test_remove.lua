local M = {}

function M:Awake()
	print("M:Awake", self, self.component)
end

function M:Start()
	print("M:Start", self, self.component, self.gameObject)
end

function M:onClick(go)
	print("M:onClick", self, go, go.transform.parent)
	print("M:onClick", self, go, go.transform.parent:Find("InputField"))
	local input = go.transform.parent:Find("InputField").gameObject:GetComponent(UnityEngine.UI.InputField)
	local number = tonumber(input.text)
	local scrollView = go.transform.parent.parent:Find("ScrollListView").gameObject:GetComponent(LuaHelper.GetClsType("ScrollListView"))
	print("M:onClick", scrollView, input.text, number)
	scrollView:RemoveItem(number or 0)
end

return M