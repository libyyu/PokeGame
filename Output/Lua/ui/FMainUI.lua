local FBaseUI = require "ui.FBaseUI"
local FGUITools = require "utility.FGUITools"
local json = require "utility.json"

local l_instance = nil
local FMainUI = FLua.Class(FBaseUI, "FMainUI")
do
	function FMainUI.Instance()
		if not l_instance then
			l_instance = FMainUI()
			l_instance.m_UnloadBundleWhenDestroy = true
			l_instance.m_TriggerGCWhenDestroy = true
		end
		return l_instance
	end

	function FMainUI:__constructor()
		self.curTab = nil
		self.tabBar = nil
		self.tabBarData = {
			{
				name = "开搭",
				id = 1,
			},
			{
				name = "我的",
				id = 2,
			}
		}

		self.m_bRequesting = false
		self.m_requestPage = 1
		self.actListView = nil 
		self.actListData = {}
	end

	function FMainUI:ShowPanel(show)
		if show then
			if not self.m_panel then
				self:CreatePanel(ResPathReader.MainUI)
			end
		else
			self:DestroyPanel()
		end
	end

	local function onTabSelect(_, id)
		print("onTabSelect", id)
		local self = FMainUI.Instance()
		if self.curTab == id then return end
		self.curTab = id
		self:FindChildObj("Content/ActivityView"):SetActive(id == 1)
		self:FindChildObj("Content/MineView"):SetActive(id == 2)
	end


	function FMainUI:OnDestroy()
		DelEvent(onTabSelect,EventDef.MainTabSelect)
		self.curTab = nil
	end

	function FMainUI:OnCreate()
		onTabSelect(_, 1)
		AddEvent(onTabSelect, EventDef.MainTabSelect)
		local tabBar = self:FindChildObj("TabBar"):GetComponent("UITabBar")
		print("tabBar", tabBar)
		self.tabBar = tabBar
		tabBar.OnItemUpdate = function(objItem, index)
			print("item update", objItem, index)
			local script = objItem:GetAnyLuaScriptFile()
			script:UpdateData(self.tabBarData[index+1])
		end
		tabBar.OnItemRemove = function(objItem, index)
		end
		tabBar.itemCount = #self.tabBarData

		self.actListView = self:FindChildObj("Content/ActivityView"):GetComponent("ScrollListView") 


		self.actListView.OnItemUpdate = function(objItem, index)
			print("actitem update", objItem, index)
			local script = objItem:GetAnyLuaScriptFile()
			script:UpdateData(self.actListData[index+1])
		end
		self.actListView.OnItemRemove = function(objItem, index)
		end
		self.actListView.OnFetchMore = function(down)
			if down then
				self:RequestPage(self.m_requestPage, function(page, data)
					print("get page ", page, data, dant and #data)
					if data then
						table.extend(self.actListData, data)
						self.actListView.itemCount = #(self.actListData)
						self.m_requestPage = page + 1
					end
				end)
			end
		end

		self:RequestPage(1, function(page, data)
			print("get page ", page, data, dant and #data)
			if data then
				table.extend(self.actListData, data)
				self.actListView.itemCount = #(self.actListData)
				self.m_requestPage = page + 1
			end
		end)
	end

	function FMainUI:RequestPage(page, callback)
		if self.m_bRequesting then
			return 
		end
		self:FindChildObj("Content/Loading"):SetActive(true)
		self.m_bRequesting = true
		_G.coro.start(function()
			local request = UnityEngine.Networking.UnityWebRequest.Get("http://192.168.18.146:8001/mfwhotlist?page="..tostring(page))
			request:SendWebRequest()
			while not request.isDone do
				_G.coro.yield()
			end
			self.m_bRequesting = false
			if self:IsValid() then
				self:FindChildObj("Content/Loading"):SetActive(false)
				if request.result == UnityEngine.Networking.UnityWebRequest.Result.Success then
					local text = request.downloadHandler.text
					if string.isEmpty(text) then
						warn("error search page", page, "respond text not valid")
						callback(page, false)
					else
						local jd = json.decode(text)
						if not jd or not jd.data or jd.code ~= 0 then
							warn("error search page", page, "respond text not valid json format")
							callback(page, false)
						else
							callback(page, jd.data)
						end 
					end
				else
					warn("error search page", page)
					callback(page, false)
				end
			end 
			
			request:Dispose()
		end)
	end

end

return FMainUI
