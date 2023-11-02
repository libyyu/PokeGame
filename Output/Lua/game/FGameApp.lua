
local FGame = FLua.ForwardClass("FGame")
do
	function FGame:EnterLoginStage()
		self:InitLoginInfo()
		local login = require "ui.FLoginUI"
		login.Instance():ShowPanel(true)

		local musicGo = NewGameObject("BackgroundMusic")
		musicGo:AddComponent(LuaHelper.GetClsType("FBackgroundMusic"))
		DontDestroyOnLoad(musicGo)
		--测试背景音
		AsyncLoad(ResPathReader.BackgroundMusic, function(obj)
			warn("=======",obj)
			--if obj and not obj.isNil then
				local backgroundMusic = musicGo:GetComponent(LuaHelper.GetClsType("FBackgroundMusic"))
				backgroundMusic:PlayBackgroundMusic(obj)
			--end
		end)
	end
	function FGame:LeaveLoginState()
		local login = require "ui.FLoginUI"
		login.Instance():ShowPanel(false)
	end
end
