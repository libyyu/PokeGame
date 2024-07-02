local FPanelBaseUI = require "ui.FPanelBaseUI"

local l_instance = nil
local FPanelConsoleUI = FLua.Class(FPanelBaseUI, "FPanelConsoleUI")
do
	function FPanelConsoleUI.Instance()
		if not l_instance then
			l_instance = FPanelConsoleUI()
		end
		return l_instance
	end

	function FPanelConsoleUI:__constructor()
		self.m_consoleText = nil
		self.m_depthLayer = GUIDEPTH.TOPMOST
		self.m_dontDestroyOnLoad = true
		self.m_bVisibleLog = false
	end

	function FPanelConsoleUI:GetResPath()
		return ResPathReader.ConsoleUI
	end

	local function onUnityLog(evtName,log)
		local self = FPanelConsoleUI.Instance()
		if not self.m_panel then
			return
		end
		if self.m_bVisibleLog then
			self:RefreshLog(false)
		end
	end

	function FPanelConsoleUI:OnCreate()
		self:RequireFind("consoleGroup").visible = self.m_bVisibleLog
		self.m_consoleText = self:RequireFind("consoleGroup/out/output")
		print("self.m_consoleText", self.m_consoleText)
		AddEvent(onUnityLog, EventDef.UnityLog)
		if self.m_bVisibleLog then
			self:RefreshLog(true)
		end
	end 
	function FPanelConsoleUI:OnDestroy()
		DelEvent(onUnityLog, EventDef.UnityLog)
	end

	function FPanelConsoleUI:OnClick(eventContext)
		if not eventContext then return end
		if not eventContext.sender then return end
		local name = eventContext.sender.name
		if name == "toggle" then
			self.m_bVisibleLog = not self.m_bVisibleLog
			eventContext.sender.selected = self.m_bVisibleLog
			self:RequireFind("consoleGroup").visible = self.m_bVisibleLog
			if self.m_bVisibleLog then
				self:RefreshLog(true)
			end
		end
	end

	function FPanelConsoleUI:OnSubmit(eventContext)
		if not eventContext then return end
		if not eventContext.sender then return end
		local name = eventContext.sender.name
		if name ~= 'input' then return end
		local text = eventContext.sender.text
		if string.isEmpty(text) then
			return
		end
		eventContext.sender.text = ""
		theGame:ExecuteDebugString(text)
	end

	function FPanelConsoleUI:AppendLog(t,str)
		local oldText = self.m_consoleText.text
	    if t == UnityEngine.LogType.Exception or
	         t == UnityEngine.LogType.Error or
	         t == UnityEngine.LogType.Assert then
	         self.m_consoleText.text = oldText .. "\n" .. "[color=#FF0000]" .. str .. "[/color]"
	    elseif t == UnityEngine.LogType.Warning then
	        self.m_consoleText.text = oldText .. "\n" .. "[color=#00FF00]" .. str .. "[/color]"
	    else
	        self.m_consoleText.text = oldText .. "\n" .. "[color=#FFFFFF]" .. str .. "[/color]"
	    end

	    --self:RequireFind("consoleGroup/out").scrollPane:ScrollBottom()
	end

	function FPanelConsoleUI:RefreshLog(rebuild)
		local logs = theGame:GetAllLogs()
		if rebuild then
			self.m_consoleText.text = ""
			for i,log in ipairs(logs) do
	        	self:AppendLog(log.type,log.str)
	        end
		else
			local log = logs[#logs]
			if log then
				self:AppendLog(log.type,log.str)
			end
		end
	end
end 

return FPanelConsoleUI