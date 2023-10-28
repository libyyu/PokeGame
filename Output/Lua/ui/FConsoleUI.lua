local FBaseUI = require "ui.FBaseUI"

local l_instance = nil
local FConsoleUI = FLua.Class(FBaseUI, "FConsoleUI")
do
	function FConsoleUI:__constructor()
		self.m_Toggled = false
		self.m_consoleText = nil
		self.m_inputText = nil
		self.m_inputHistory = {}
		self.m_cursor = 1
	end
	function FConsoleUI.Instance()
		if not l_instance then
			l_instance = FConsoleUI()
		end
		return l_instance
	end
	function FConsoleUI:ToggleConsole()
		if not self.m_panel then		
			self:CreatePanel(ResPathReader.ConsoleUI)
		else
			self:DestroyPanel()
		end
	end

	local function onUnityLog(evtName,log)
		local self = FConsoleUI.Instance()
		if not self.m_panel then
			return
		end
		self:RefreshLog(false)
	end

	function FConsoleUI:OnCreate()
		AddEvent(onUnityLog,EventDef.UnityLog)
		self.m_panel:SetActive(true)
        self.m_consoleText = self:FindChildObj("OutputArea/ScrollingMask/Text"):GetComponent("Text")
        self.m_inputText = self:FindChildObj("InputArea"):GetComponent("InputField")
        self.m_inputText:ActivateInputField()
        self.m_Toggled = true

        self:RefreshLog(true)
	end
	function FConsoleUI:OnDestroy()
		DelEvent(onUnityLog,EventDef.UnityLog)
		self.m_Toggled = false
		self.m_consoleText = nil
		self.m_inputText = nil
		self.m_cursor = 1
	end
	function FConsoleUI:OnClick(go)
		if go.name == "Prev" then
			local str = ""
			if #self.m_inputHistory >0 and self.m_cursor >0 then
				self.m_cursor = self.m_cursor - 1
				local pos = #self.m_inputHistory - self.m_cursor
				str = self.m_inputHistory[pos] or ""
			end
			self.m_inputText.text = str
		elseif go.name == "Next" then
			local str = ""
			if #self.m_inputHistory >0 and self.m_cursor < #self.m_inputHistory then
				local pos = #self.m_inputHistory - self.m_cursor
				str = self.m_inputHistory[pos] or ""
				self.m_cursor = self.m_cursor + 1
			end
			self.m_inputText.text = str
		end
	end
	function FConsoleUI:OnSubmit(go,text)
		if not text or #text == 0 then return end
		local userName = theGame.m_LoginInfo and theGame.m_LoginInfo.name and theGame.m_LoginInfo.name..">>" or ">>"
		print(userName..text)
		self.m_inputText.text = ""
		self.m_inputText:ActivateInputField()
		self.m_inputHistory[#self.m_inputHistory+1] = text
		theGame:ExecuteDebugString(text)
	end

	function FConsoleUI:LineDown()
		if not self.m_panel then
			return
		end
		local scrollObj = self:FindChildObj("Scrollbar"):GetComponent("Scrollbar")
		scrollObj.value = 0
	end

	function FConsoleUI:AppendLog(t,str)
		local oldText = self.m_consoleText.text
	    if t == UnityEngine.LogType.Exception or
	         t == UnityEngine.LogType.Error or
	         t == UnityEngine.LogType.Assert then
	         self.m_consoleText.text = oldText .. "\n" .. "<color=red>" .. str .. "</color>"
	    elseif t == UnityEngine.LogType.Warning then
	        self.m_consoleText.text = oldText .. "\n" .. "<color=green>" .. str .. "</color>"
	    else
	        self.m_consoleText.text = oldText .. "\n" .. "<color=white>" .. str .. "</color>"
	    end

	    self:LineDown()
	end

	function FConsoleUI:RefreshLog(rebuild)
		local logs = theGame:GetAllLogs()
		if rebuild then
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

return FConsoleUI
