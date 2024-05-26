local M = {}

function M:Awake()
	print("M:Awake", self, self.component)
end

function M:Start()
	print("M:Start", self, self.component, self.gameObject)
end

function M:onClick(go)
	local panel = require "ui.FLoadingUI".Instance()
	panel:AutoProgress(2, 0, 70)
	theGame:EnterWorld(function()
		print("EnterWorld OnLoaded")
		panel:AutoProgress(0.5, nil, 90)
		theGame:LoadHostPlayer(function()
			print("LoadHostPlayer OnLoaded")
			panel:AutoProgress(1, nil, 100, function()
				print("AutoProgress OnLoaded")
				panel:DestroyPanel()

				local ui = go.transform.parent.parent.parent
				local uipanel = require "ui.FGUIMan".Instance():GetPanelByObj(ui.gameObject)
				print("ui", ui, uipanel)
				if uipanel then
					uipanel:DestroyPanel()
				end
				theGame:ResumeBackgroundMusic()
			end)
		end)
	end)
end

return M