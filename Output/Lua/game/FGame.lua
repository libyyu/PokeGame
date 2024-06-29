
theGame = nil
local FLogicSession = require "network.FLogicSession"
local FAssetBundleUtil = require "utility.FAssetBundleUtil"
local FLibEvent = require "utility.FLibEvent"
local FCommand = require "game.FCommand"

local FGame = FLua.FinalClass("FGame")
do
	function FGame.Instance( )
		return theGame
	end

	function FGame:__constructor()
		self.m_LogicNetwork = nil
		self.m_LogicEvent = FLibEvent("LogicEvent")
		self.m_LogList = {}
		self.m_MainCam = nil
		self.m_HostPlayer = nil
		self.m_FPS = nil
		self.m_LoginInfo = nil
		self.m_isGameLogic = false
		self.m_backgroundMusicComp = nil
		self.m_world = nil
	end

	function FGame:InitGame()
		if not IsWebGLRuntime() then
			self.m_LogicNetwork = FLogicSession.Instance()
			self.m_LogicNetwork:InitNetwork()
		end

		--初始化主相机
		self:InitGameObject()

		--Init FHotKeyLogic
		local hotGo = NewGameObject("FHotKeyLogic")
		local clsT = LuaHelper.GetClsType("FHotKeyLogic")
		hotGo:AddComponent(clsT)
		DontDestroyOnLoad(hotGo)

		--初始化2D-ui根节点
		require "ui.FGUIMan".Instance():InitUIRoot()
		require "manager.FFlashTipMan".Instance():InitCacheRoot()
		require"ui.FPanelConsoleUI".Instance():ShowPanel(true)

		local musicGo = NewGameObject("BackgroundMusic")
		self.m_backgroundMusicComp = musicGo:AddComponent(LuaHelper.GetClsType("FBackgroundMusic"))
		DontDestroyOnLoad(musicGo)
	end

	function FGame:InitLoginInfo()
		self.m_LoginInfo = {name="libyyu",passwd="123456",}
	end

	function FGame:InitGameObject()
		if self.m_MainCam and not self.m_MainCam.isNil then
			return
		end
		if false then
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
		    cam.cullingMask = bit.bnot(bit.lshift(1,5)) --去除UI
		    --camobj:AddComponent(LuaHelper.GetClsType("UnityEngine.GUILayer"));
		    camobj:AddComponent(LuaHelper.GetClsType("UnityEngine.FlareLayer"))
	        camobj.tag = "MainCamera"
	        self.m_MainCam = camobj	    
		    --AudioListener
		    local goAudio = NewGameObject("AudioListener")
		    goAudio:AddComponent(LuaHelper.GetClsType("UnityEngine.AudioListener"))
		    DontDestroyOnLoad(goAudio)
		else
			local finished
			local resourceArr = {ResPathReader.CameraRoot, ResPathReader.RoundCorners, ResPathReader.IndependentRoundCorners, }
			if FairyGUI and not GameUtil.IsEditorEnv() then
				resourceArr[#resourceArr+1] = ResPathReader.FontBundle 		--4
				resourceArr[#resourceArr+1] = ResPathReader.CommonBundle	--5
			end
			AsyncLoadArray(resourceArr, function(assetArr)
				require"utility.Utils".printValue("assetArr", assetArr)
				local asset = assetArr[1]
				local goCamRoot = Instantiate(asset)
				goCamRoot.transform.localPosition = Vector3(0, 0, 0)
				goCamRoot.transform.localScale = Vector3(1, 1, 1)
				self.m_MainCam = goCamRoot.transform:Find("MainCameraRoot/MainCamera")

				print("shader:", assetArr[2], assetArr[3])

				if FairyGUI then
					if GameUtil.IsEditorEnv() then
						local font = FairyGUI.DynamicFont()
					  	font.name = "msyh"
					  	font.nativeFont = require "utility.FAssetBundleUtil".Instance():LoadAsset("", ResPathReader.FontBundle)
					  	FairyGUI.FontManager.RegisterFont(font)

						local commonAsset = ResPathReader.CommonBundle
						local assetPath = TransformAssetName(commonAsset)
						print("AddPackage:", commonAsset, assetPath)
						FairyGUI.UIPackage.AddPackage(assetPath)
						FairyGUI.UIConfig.buttonSound = FairyGUI.UIPackage.GetItemAssetByURL("ui://Common/tabswitch")
						FairyGUI.UIConfig.globalModalWaiting = "ui://Common/GlobalModalWaiting"
						print("FairyGUI.UIConfig.buttonSound", FairyGUI.UIConfig.buttonSound)
					else
						if assetArr[4] then
							print("bundles", assetArr[4])
							bAddFont = true
							local font = FairyGUI.DynamicFont()
						  	font.name = "msyh"
						  	font.nativeFont = assetArr[4]
						  	FairyGUI.FontManager.RegisterFont(font)
						end

						if assetArr[5] then
							print("CommonBundle", assetArr[5])
							FairyGUI.UIPackage.AddPackage(assetArr[5])
							FairyGUI.UIConfig.buttonSound = FairyGUI.UIPackage.GetItemAssetByURL("ui://Common/tabswitch")
							FairyGUI.UIConfig.globalModalWaiting = "ui://Common/GlobalModalWaiting"
							print("FairyGUI.UIConfig.buttonSound", FairyGUI.UIConfig.buttonSound)
						end
					end
				end

				finished = true
			end)
			while not finished do
				_G.coro.yield()
			end

			
		end
	end

	function FGame:Setup()
		MainThreadTask.Init()
		self:InitGame()
	end

	function FGame:Run()
		self:OnRun()
	end
	
	function FGame:ToggleConsole()
		FConsoleUI.Instance():ToggleConsole()
	end
	function FGame:ForceCloseConsole()
		FConsoleUI.Instance():DestroyPanel()
	end
	function FGame:OnUnityLog(t,str)
		if #self.m_LogList > 300 then
			table.remove(self.m_LogList, 1)
		end
		table.insert(self.m_LogList,{type=t,str=str})
		FireEvent(EventDef.UnityLog,{type=t,str=str})
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

	function FGame:ResumeBackgroundMusic()
		--测试背景音
		AsyncLoad(ResPathReader.BackgroundMusic, function(obj)
			if obj and not obj.isNil then
				self.m_backgroundMusicComp:PlayBackgroundMusic(obj)
			end
		end)
	end
end

require ("game.FGame" .. PlatformSuffix)

theGame = FGame()

return FGame
