
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
		self.m_UGUIRoot = nil
		self.m_FGUIRoot = nil
		self.m_panelSet = {}
		self.m_ObjToPanel = setmetatable({}, {__mode = "k"})
	end

	function FGUIMan:GetUGUIRoot()
		return self.m_UGUIRoot
	end
	function FGUIMan:GetFGUIRoot()
		return self.m_FGUIRoot
	end

	function FGUIMan:InitUGUIRoot()
		if self.m_UGUIRoot and not self.m_UGUIRoot.isNil then return end
		print("GUIMan:InitUGUIRoot")

		local goRoot = NewGameObject("UIRoot(2D)");
	    goRoot.transform.localPosition = Vector3(0, 0, 0);
	    goRoot.transform.localScale = Vector3(1, 1, 1);
	    goRoot.layer = UnityEngine.LayerMask.NameToLayer("UI");
	    goRoot.transform:SetParent(self.m_UIRoot.transform)

	    local cam = goRoot:AddComponent(UnityEngine.Camera)
	    cam.clearFlags = UnityEngine.CameraClearFlags.Depth
	    --cam.backgroundColor = Color(128,128,128,255)
	    cam.cullingMask = bit.lshift(1,5)
	    cam.orthographic = true;
	    cam.orthographicSize = 3.2
	    cam.nearClipPlane = -10;
	    cam.farClipPlane = 1000;
	    cam.depth = 0

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
	    goEvent.transform:SetParent(goRoot.transform)

	    self.m_UGUIRoot = goCanvas.transform
	end

	function FGUIMan:InitFGUIRoot()
		if self.m_FGUIRoot and not self.m_FGUIRoot.isNil then return end

		FairyGUI.StageCamera.LayerName = "FairyGUI"
		local camearGo = NewGameObject("Stage Camera");
	    camearGo.transform.localPosition = Vector3(2.790179, -5, 0);
	    camearGo.transform.localScale = Vector3(1, 1, 1);
	    camearGo.layer = UnityEngine.LayerMask.NameToLayer("FairyGUI")

	    local cam = camearGo:AddComponent(UnityEngine.Camera)
	    cam.clearFlags = UnityEngine.CameraClearFlags.Depth
	    --cam.backgroundColor = Color(128,128,128,255)
	    cam.cullingMask = bit.lshift(1,20)
	    cam.orthographic = true;
	    cam.orthographicSize = 5
	    cam.nearClipPlane = -30;
	    cam.farClipPlane = 30;
	    cam.depth = 1
	    camearGo:AddComponent(LuaHelper.GetClsType("FairyGUI.StageCamera"))


	    local goRoot = NewGameObject("FGUIRoot(2D)");
	    goRoot.transform.localPosition = Vector3(0, 0, 0);
	    goRoot.transform.localScale = Vector3(1, 1, 1);
	    goRoot.layer = UnityEngine.LayerMask.NameToLayer("FairyGUI")
	    goRoot.transform:SetParent(self.m_UIRoot.transform)
		self.m_FGUIRoot = goRoot

		print("GUIMan:InitFGUIRoot", self.m_FGUIRoot)
		FairyGUI.GRoot.inst:SetContentScaleFactor(750, 1344, FairyGUI.UIContentScaler.ScreenMatchMode.MatchWidthOrHeight)
		FairyGUI.Stage.inst.gameObject:GetComponent(FairyGUI.UIContentScaler).ignoreOrientation = true
		print("Stage width:", FairyGUI.Stage.inst.width, FairyGUI.Stage.inst.height)
		print("Screen width:", UnityEngine.Screen.width, UnityEngine.Screen.height)
	end

	function FGUIMan:InitUIRoot()
		if not self.m_UIRoot or self.m_UIRoot.isNil then
			self.m_UIRoot = NewGameObject("UIRootContainer")
		    self.m_UIRoot.transform.localPosition = Vector3(0, 0, 0)
		    self.m_UIRoot.transform.localScale = Vector3(1, 1, 1)
		end
		self:InitUGUIRoot()
		self:InitFGUIRoot()
	end

	function FGUIMan:RegisterPanel(panel)
		self.m_panelSet[panel] = true
	end
	function FGUIMan:UnRegisterPanel(panel)
		self.m_panelSet[panel] = nil
	end
	function FGUIMan:IsPanelRegistered(panel)
		return self.m_panelSet[panel] == true
	end

	function FGUIMan:EachPanel()
		return pairs(self.m_panelSet)
	end

	function FGUIMan:RegisterPanelObj(obj, panel)
		if obj then self.m_ObjToPanel[obj] = panel end
	end
	function FGUIMan:UnRegisterPanelObj(obj)
		if obj then self.m_ObjToPanel[obj] = nil end
	end

	function FGUIMan:GetPanelByObj(obj)
		return self.m_ObjToPanel[obj]
	end

	function FGUIMan:CreateSimpleUI(assetName, callback, onclick)
		local M = FLua.Class(require "ui.FPanelBaseUI")
		do
			function M.OnCreate(panel)
				if callback then 
					callback(panel)
				end
			end
			if onclick then
				M.OnClick = function(panel, ...)
					onclick(panel, ...)
				end
			end
		end
		local panel = M()
		panel:CreatePanel(assetName)
		return panel
	end
end

return FGUIMan