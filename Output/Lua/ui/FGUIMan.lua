
local l_instance = nil
local FGUIMan = FLua.Class("FGUIMan")
do
	function FGUIMan.Instance()
		if not l_instance then
			l_instance = FGUIMan()
		end
		return l_instance
	end
	function FGUIMan:__constructor()
		self.m_UIRoot = nil
		self.m_PanelContainer = {}
	end

	function FGUIMan:GetGUIRoot()
		return self.m_UIRoot
	end

	function FGUIMan:UseFairyGUI()
		return false
	end

	function FGUIMan:InitUIRoot()
		if self.m_UIRoot and not self.m_UIRoot.isNil then return end
		print("GUIMan:InitUIRoot")
		if self:UseFairyGUI() then
			FairyGUI.GRoot.inst:SetContentScaleFactor(1344, 750)
			self.m_UIRoot = FairyGUI.GRoot.inst.rootContainer.gameObject
		else
			local goRoot = NewGameObject("UIRoot(2D)");
		    goRoot.transform.localPosition = Vector3(0, 0, 0);
		    goRoot.transform.localScale = Vector3(1, 1, 1);
		    goRoot.layer = UnityEngine.LayerMask.NameToLayer("UI");
		    local cam = goRoot:AddComponent(UnityEngine.Camera)
		    cam.clearFlags = UnityEngine.CameraClearFlags.Depth
		    --cam.backgroundColor = Color(128,128,128,255)
		    cam.cullingMask = 32
		    cam.orthographic = true;
		    cam.orthographicSize = 3.2
		    cam.nearClipPlane = -10;
		    cam.farClipPlane = 1000;

		    goRoot:AddComponent(LuaHelper.GetClsType("UnityEngine.FlareLayer"))
	        --goRoot:AddComponent(LuaHelper.GetClsType("UnityEngine.GUILayer"));

	        local goCanvas = NewGameObject("Canvas")
	        goCanvas.layer = UnityEngine.LayerMask.NameToLayer("UI");

	        goCanvas.transform:SetParent(goRoot.transform)
		    goCanvas.transform.localPosition = Vector3(0, 0, 0);
		    goCanvas.transform.localScale = Vector3(1, 1, 1);
		    local canvas = goCanvas:AddComponent(LuaHelper.GetClsType("UnityEngine.Canvas"));
		    canvas.renderMode = 1--UnityEngine.RenderMode.ScreenSpaceCamera;
		    canvas.pixelPerfect = true
		    canvas.worldCamera = cam

		    local canScaler = goCanvas:AddComponent(UnityEngine.UI.CanvasScaler);
		    canScaler.uiScaleMode = UnityEngine.UI.CanvasScaler.ScaleMode.ScaleWithScreenSize
		    canScaler.screenMatchMode = UnityEngine.UI.CanvasScaler.ScreenMatchMode.MatchWidthOrHeight
		    canScaler.referenceResolution = Vector2(750, 1344)

		    goCanvas:AddComponent(UnityEngine.UI.GraphicRaycaster);

	        --Event Handle
			local goEvent = NewGameObject("EventSystem");
		    goEvent:AddComponent(EventSystems.EventSystem);
		    goEvent:AddComponent(EventSystems.StandaloneInputModule);
		    --goEvent:AddComponent(EventSystems.TouchInputModule);
		    DontDestroyOnLoad(goEvent)
		    goEvent.transform:SetParent(goRoot.transform)

		    self.m_UIRoot = goCanvas.transform
		end
	end

	function FGUIMan:RegisterPanel(name, panel)
		self.m_PanelContainer[name] = panel
	end
	function FGUIMan:UnRegisterPanel(name)
		self.m_PanelContainer[name] = nil
	end

	function FGUIMan:RemoveWindow(child)
		if self:UseFairyGUI() then 
			FairyGUI.GRoot.inst:RemoveChild(child)
		end
	end

	function FGUIMan:LoadPanelRes(assetName, callback)
		if self:UseFairyGUI() then 
			AsyncLoadBundleArray({ResPathReader.PokerCommon, assetName}, function(bundles)
				if not bundles[1] then
					warn("Failed to get common resource")
				else
					FairyGUI.UIPackage.AddPackage(bundles[1])
				end
				if bundles[2] then
					FairyGUI.UIPackage.AddPackage(bundles[2])
					callback(bundles[2])
				else
					callback(nil)
				end
			end)
		else
			AsyncLoad(assetName, function(obj)
				callback(obj)
			end)
		end
	end

	function FGUIMan:CreateSimpleUI(assetName, callback, onclick)
		local M = FLua.Class(require "ui.FBaseUI")
		do
			function M.OnCreate(panel)
				if callback then 
					callback(panel)
				end
			end
			function M.OnClick(panel, go)
				if onclick then
					onclick(panel, go)
				end
			end
		end
		local panel = M()
		panel:CreatePanel(assetName)
		return panel
	end
end

return FGUIMan