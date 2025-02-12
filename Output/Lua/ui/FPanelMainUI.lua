local FViewBaseUI = require "ui.FViewBaseUI"
local FPanelBaseUI = require "ui.FPanelBaseUI"
--local FFixedList = require "ui.FFixedList"
local FScrollList = require "ui.FScrollList"
local json = require "utility.json"

local l_instance = nil
local FPanelMainUI = FLua.Class(FPanelBaseUI, "FPanelMainUI")
do
	local FViewItem = FLua.Class(FViewBaseUI)
	do
		function FViewItem:__constructor()
			self.m_index = 0
			self.data = nil
		end
		function FViewItem.new(index)
			local obj = FViewItem()
			obj.m_index = index
			return obj
		end

		function FViewItem:OnDestroy()
			--print("item OnDestroy", self.m_viewObj, self.m_index)
			-- local graph = self:FindDirect("icon")
			-- if IsValidObject(graph) then
			-- 	graph.shape.visible = false
			-- end
		end

		function FViewItem:OnCreate()
			--local graph = self:FindDirect("icon")
			--graph.shape.visible = false
			self:Update(self.data)
		end

		function FViewItem:toString()
			return string.format("FViewItem-%d", self.m_index)
		end

		function FViewItem:Update(data)
			if not data then return end
			self.data = data
			local graph = self:FindDirect("icon")
			--graph.shape.graphics.texture = icon.texture
			--graph.shape.visible = true
			local imageCode = path.join(UnityEngine.Application.persistentDataPath, GameUtil.CalculateMD5Hash(data.image))
			local texCache = false --GameUtil.LoadTexture2DFromFile(imageCode)
			if texCache then
				print("load image from cache:", data.image)
				--icon.texture = texCache
				graph.shape.graphics.texture = FairyGUI.NTexture(texCache)
			else
				print("load image from web:", data.image)
				GameUtil.AsyncLoadTextureFromPathOrUrl(data.image, function(tex)
					if tex then
						GameUtil.SaveTextureToFile(tex, imageCode)
					end
					if not self:IsValid() then return end
					graph.shape.graphics.texture = FairyGUI.NTexture(tex)
				end)
			end

			local name = self:RequireFind("name")
			name.text = data.title
			local content = self:RequireFind("content")
			content.text = data.brief

		end

		function FViewItem:OnClick()
			GameUtil.CallNativeMethod("OpenUrl", self.data.url)
		end
	end

	function FPanelMainUI:__constructor()
		self.list = FScrollList.Create(function(itemObj, itemIndex) return FViewItem.new(itemIndex) end
		, function(view, index)
			view:Update(self.actListData[index])
		end)
		self:RegisterSubView("Content/listContainer/list", self.list)

		self.m_bRequesting = false
		self.m_requestPage = 1
		self.actListData = {}
		self.m_ModalWait = nil
	end

	function FPanelMainUI.Instance()
		if not l_instance then
			l_instance = FPanelMainUI()
		end
		return l_instance
	end

	function FPanelMainUI:GetResPath()
		return ResPathReader.FMainUI
	end

	function FPanelMainUI:OnCreate()
		--local list = self:RequireFind("Content/n14/list")
		-- print("listData", listData)
		-- listData.url = "ui://dzefjlp5aewvc"
		--local list = listData:RequireFind("list")
	end

	function FPanelMainUI:OnClick(eventContext)
		local sender = eventContext.sender
		if sender.gameObjectName == "listItem" then
			local index = self.list.m_viewObj.selectedIndex + 1
			print("listItemclick", index)
			local view = self.list:GetItem(index)
			view:OnClick()
		end
	end

	function FPanelMainUI:AfterCreate()
		self.list.m_viewObj.scrollPane.onPullUpRelease:Add(function() 
			self:RequestPage(self.m_requestPage, function(page, data)
				print("get page ", page, data, data and #data)
				if data and #data >0 then
					table.extend(self.actListData, data)
					self.list:SetCount(#(self.actListData))
					self.m_requestPage = page + 1
				end
			end)
		end)

		self:RequestPage(1, function(page, data)
			print("get page ", page, data, data and #data)
			if data and #data >0 then
				table.extend(self.actListData, data)
				-- self.actListView.itemCount = #(self.actListData)
				self.m_requestPage = page + 1
				self.list:SetCount(#(self.actListData))
			end
		end)
	end

	function FPanelMainUI:ShowModalWait(show)
		if show then
			if not self.m_ModalWait then
				local panel = FairyGUI.UIPackage.CreateObjectFromURL(FairyGUI.UIConfig.globalModalWaiting)
				self.m_ModalWait = panel
				self.m_ModalWait:SetHome(self.m_panel)
			end
			self.m_ModalWait:SetSize(self.m_panel.width, self.m_panel.height)
			self.m_ModalWait:AddRelation(self.m_panel, FairyGUI.RelationType.Size)
			self.m_panel:AddChild(self.m_ModalWait)
		else
			if IsValidObject(self.m_ModalWait) and self.m_ModalWait.parent then
				self.m_panel:RemoveChild(self.m_ModalWait)
			end
		end
	end

	function FPanelMainUI:RequestPage(page, callback)
		if self.m_bRequesting then
			return 
		end
		--FairyGUI.GRoot.inst:ShowModalWait()
		self:ShowModalWait(true)
		self.m_bRequesting = true
		_G.coro.start(function()
			local request = UnityEngine.Networking.UnityWebRequest.Get("http://192.168.18.146:8001/mfwhotlist?page="..tostring(page))
			if IsWXRuntime() then
				request:SetRequestHeader("UnityWebGL", "wx")
			elseif IsWebGLRuntime() and not GameUtil.IsEditorEnv() then
				request:SetRequestHeader("UnityWebGL", "web")
			end
			-- request:SetRequestHeader("Accept-Encoding", "gzip, deflate")
			-- request:SetRequestHeader("Access-Control-Allow-Headers", "Origin, X-Requested-With, Content-Type, Accept")
			request:SendWebRequest()
			while not request.isDone do
				_G.coro.yield()
			end
			self.m_bRequesting = false
			--FairyGUI.GRoot.inst:CloseModalWait()
			self:ShowModalWait(false)
			if self:IsValid() then
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

return FPanelMainUI
