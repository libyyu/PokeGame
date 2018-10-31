local FBaseUI = require "ui.FBaseUI"
local FGUITools = require "utility.FGUITools"
local server_list = dofile "configs.server_list"

local l_instance = nil
local FServerListUI = FLua.Class("FServerListUI",FBaseUI)
do
	local OBJPATH = 
	{
		Template = "ServerList/List/Template",
		List = "ServerList/List"
	}	
	function FServerListUI:_ctor( )
		self.m_ListCtrl = nil
		self.m_currentServerInfo = nil
	end
	function FServerListUI.Instance()
		if not l_instance then
			l_instance = FServerListUI.new()
		end
		return l_instance
	end

	function FServerListUI:ShowPanel(show)
		if show then
			if not self.m_panel then
				self:CreatePanel(ResPathReader.ServerListUI)
			end
		else
			self:DestroyPanel()
		end
	end

	function FServerListUI:OnCreate()
		self.m_ListCtrl = self:FindChildObj(OBJPATH.List)--:GetComponent(UnityEngine.UI.GridLayoutGroup)
		local template = self:FindChildObj(OBJPATH.Template)
		assert(self.m_ListCtrl)
		assert(template)
		
		for k,v in pairs(server_list) do
			local newObj = Instantiate(template,("Button%02d"):format(k))
			newObj.transform:SetParent(self.m_ListCtrl.transform)
			newObj.transform.localPosition = Vector3(0, 0, 0)
			newObj.transform.localScale = Vector3(1, 1, 1)
			newObj:SetActive(true)
		end
		self:TouchGUIMsg()

		local count = #server_list + 13
		local rtTrans = self.m_ListCtrl:GetComponent("RectTransform");
		local rowNum = count / 2;
		if count % 2 > 0 then
			rowNum = math.floor(rowNum+1)
		end
		local size = rtTrans.sizeDelta;
		size.y = rowNum * 42 + (rowNum - 1) * 21;
		rtTrans.sizeDelta = size;

		local position = rtTrans.localPosition;
		position.y = -(size.y / 2);
		rtTrans.localPosition = position;
	end

	function FServerListUI:OnClick(go)
		local id = go.name
		if id == "Btn_SelectServer" then
			self:DestroyPanel()
		elseif id:find("Button(%d+)") then
			local _,_,tmpId = id:find("Button(%d+)")
			local buttonId = tonumber(tmpId)
		end
	end
	
end

return FServerListUI
