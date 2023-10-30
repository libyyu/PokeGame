
theGame = nil
local FLogicSession = require "network.FLogicSession"
local FAssetBundleUtil = require "utility.FAssetBundleUtil"
local FLibEvent = require "utility.FLibEvent"
local FConsoleUI = require "ui.FConsoleUI"
local FCommand = require "game.FCommand"

local FGame = FLua.Class("FGame")
do
	function FGame.Instance( )
		return theGame
	end

	function FGame:__constructor()
		self.m_LogicNetwork = nil
		self.m_AssetBundle = nil
		self.m_LogicEvent = FLibEvent("LogicEvent")
		self.m_LogList = {}
		self.m_MainCam = nil
		self.m_HostPlayer = nil
		self.m_FPS = nil
		self.m_LoginInfo = nil
		self.m_isGameLogic = false
	end

	function FGame:InitGame()
		self.m_LogicNetwork = FLogicSession.Instance()
		self.m_LogicNetwork:InitNetwork()
		self:InitGameObject()
		local FFlashTipMan = require "manager.FFlashTipMan"
		FlashTipMan:InitCacheRoot()
	end

	function FGame:InitLoginInfo()
		self.m_LoginInfo = {name="libyyu",passwd="123456",}
	end

	function FGame:InitGameObject()
		if self.m_MainCam and not self.m_MainCam.isNil then
			return
		end
		--Main Camera
		local cam_root = NewGameObject("MainCamera Root")
	    cam_root.transform.localPosition = Vector3(0, 0, 0)
	    cam_root.transform.localScale = Vector3(1, 1, 1)
	    DontDestroyOnLoad(cam_root)
	    local camobj = NewGameObject("Main Camera")
	    camobj.transform:SetParent(cam_root.transform)
	    camobj.transform.localPosition = Vector3(85, 18, 20);
	    camobj.transform.localRotation = Quaternion(0.1, -0.9, 0.4, 0.2);
	    camobj.transform.localScale = Vector3(1, 1, 1);
	    camobj:AddComponent(LuaHelper.GetClsType("FSmootFollow"))
	    local cam = camobj:AddComponent(UnityEngine.Camera)
	    cam.clearFlags = UnityEngine.CameraClearFlags.SolidColor
	    --camobj:AddComponent(UnityEngine.FlareLayer)
	    --camobj:AddComponent(LuaHelper.GetClsType("UnityEngine.GUILayer"));
        camobj.tag = "MainCamera"
        self.m_MainCam = camobj	    
	    --AudioListener
	    local goAudio = NewGameObject("AudioListener")
	    goAudio:AddComponent(LuaHelper.GetClsType("UnityEngine.AudioListener"))
	    DontDestroyOnLoad(goAudio)
	end

	function FGame:Setup()
		MainThreadTask.Init()
		--AssetBundleManager
		self.m_AssetBundle = FAssetBundleUtil.Instance()
		self.m_AssetBundle:InitAssetBundle()
		--Camera
		self:InitGameObject()
		--Init FHotKeyLogic
		local hotGo = NewGameObject("FHotKeyLogic")
		local clsT = LuaHelper.GetClsType("FHotKeyLogic")
		hotGo:AddComponent(clsT)
		DontDestroyOnLoad(hotGo)
	end

	function FGame:Run()
		self:InitGame()
		self:EnterLoginStage()
	end
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

	function FGame:EnterGameLogic()
		local musicGo = NewGameObject("BackgroundMusic")
		local backgroundMusic = musicGo:AddComponent(LuaHelper.GetClsType("FBackgroundMusic"))
		DontDestroyOnLoad(musicGo)
		--测试背景音
		AsyncLoad(ResPathReader.BackgroundMusic, ResPathReader.BackgroundMusic, function(obj)
			warn("=======",obj)
			--if obj and not obj.isNil then
				backgroundMusic:PlayBackgroundMusic(obj)
			--end
		end)

		local FWaitingUI = require "ui.FWaitingUI"
		FWaitingUI.Instance():DestroyPanel()
		self:LeaveLoginState()
		self.m_isGameLogic = true
		--加载世界
		AsyncLoad("Map","x1",function(asset)
			local goMap = Instantiate(asset)
			goMap.transform.localPosition = Vector3(-121.6,-44.2,-241.3)
			goMap.transform.localScale = Vector3(1, 1, 1)

			local player = require "player.FHostPlayer"
			local p = player()
			p:Init({})
			self.m_HostPlayer = p
		end)
	end
	function FGame:LeaveGameLogic()
		self.m_isGameLogic = false
	end


	function FGame:ToggleConsole()
		FConsoleUI.Instance():ToggleConsole()
	end
	function FGame:ForceCloseConsole()
		FConsoleUI.Instance():DestroyPanel()
	end
	function FGame:OnUnityLog(t,str)
		--table.insert(self.m_LogList,{type=t,str=str})
		--FireEvent(EventDef.UnityLog,{type=t,str=str})
	end
	function FGame:GetAllLogs()
		return self.m_LogList
	end

	function FGame:ExecuteDebugString(input)
		local args = string.split(input, ' ')
		local cmd = table.remove(args,1)

		local commands = FCommand:getAllCommands()
		if commands[cmd] then
			commands[cmd].execute(args)
		else
			warn("unknow command:"..cmd)
		end
	end

	function FGame:ShowFPS(show)
		if show then
			if not self.m_FPS then
				self.m_FPS = NewGameObject("FPS")
			end
			local fps = self.m_FPS:GetComponent("FPS")
			if not fps then
				self.m_FPS:AddComponent(LuaHelper.GetClsType("FPS"))
			end
		else
			if self.m_FPS then
				DestroyObject(self.m_FPS)
				self.m_FPS = nil
			end
		end
	end
end

theGame = FGame()

return FGame