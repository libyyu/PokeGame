local M = {}

function M:Awake()
	print("M:Awake", self)--, self.component)
end

function M:Start()
	print("M:Start", self, self.component, self.gameObject)
end

function M:onClick(go)
	print("M:onClick", self, go)
	-- local id = tonumber(self.transform:Find("idHidden"):GetComponent("Text").text)

	-- FireEvent(EventDef.MainTabSelect, id)
end

function M:UpdateData(data)
	self.data = data
	--print(data[4])
	self.transform:Find("Name"):GetComponent("Text").text = data.title
	--self.transform:Find("Content"):GetComponent("TextMesh").text = data[4]
	self.transform:Find("Content"):GetComponent("Text").text = data.brief
	local icon = self.transform:Find("Icon"):GetComponent("RawImage")


	local imageCode = path.join(UnityEngine.Application.persistentDataPath, GameUtil.CalculateMD5Hash(data.image))
	local texCache = GameUtil.LoadTexture2DFromFile(imageCode)
	if texCache then
		print("load image from cache:", data.image)
		icon.texture = texCache
	else
		print("load image from web:", data.image)
		GameUtil.AsyncLoadTextureFromPathOrUrl(data.image, function(tex)
			if tex then
				GameUtil.SaveTextureToFile(tex, imageCode)
			end
			if icon.isNil then return end
			icon.texture = tex
		end)
	end
end

return M