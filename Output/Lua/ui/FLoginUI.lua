local FBaseUI = require "ui.FBaseUI"
local FGUITools = require "utility.FGUITools"

local l_instance = nil
local FLoginUI = FLua.Class("FLoginUI",FBaseUI)
do
	local OBJPATH = 
	{
		Name = "n4/name",
		Passwd = "n4/password",
	}
	function FLoginUI.Instance()
		if not l_instance then
			l_instance = FLoginUI.new()
			l_instance.m_UnloadBundleWhenDestroy = true
			l_instance.m_TriggerGCWhenDestroy = true
		end
		return l_instance
	end

	function FLoginUI:ShowPanel(show)
		if show then
			if not self.m_panel then
				self:CreatePanel(ResPathReader.PokerLoginUI)
			end
		else
			self:DestroyPanel()
		end
	end

	function FLoginUI:OnTestMessageRe(msg)
		warn("OnEnter", msg)
		require "ui.FLoadingUI".Instance():StartLoading(function()
			theGame:EnterGameLogic()
		end)
	end

	function FLoginUI:OnDestroy( )
		DelEvent(self.OnTestMessageRe, "TestMessageRe")
	end

	function FLoginUI:OnCreate()
		local nameObj = self:FindChildObj(OBJPATH.Name)
		local passwdObj = self:FindChildObj(OBJPATH.Passwd)
		local logginInfo = theGame.m_LoginInfo or {}
		FGUITools.setInputText(nameObj,logginInfo.name or "")
		FGUITools.setInputText(passwdObj,logginInfo.passwd or "")
		AddEvent(self.OnTestMessageRe, "TestMessageRe")
		self:FindChildObj("n4/n9").onClick:Add(function()
			self:Connect()	
			local FWaitingUI = require "ui.FWaitingUI"
			FWaitingUI.Instance():ShowTip(StringReader.Get(17))
		end)
		self:FindChildObj("n4/n8").onClick:Add(function()
			--Application.OpenURL("http://www.libyyu.com")
			local P = require "game.FCardInfo"
			local p1 = P.new()
			local p2 = P.new()
			print("111111")
			p1:MakeCard("0_17")
			p2:MakeCard("0_16")
			print("333333")
			--local v = p1 + p2
			-- print(t, t2)
			--local b = p1 <= p2

			local mt = {}
			local Set = {}
			function Set.new()
				local obj = {}
				setmetatable(obj, mt)
				return obj
			end
			mt.__index = function(t, k)
				return rawget(t,k)
			end
			mt.__add = function(t, b)
				warn("1111111++++")
			end
			mt.__lt = function(t,b)
				warn("__lt")
			end
			mt.__le = function(t,b)
				warn("__le")
			end

			local v = Set.new()
			local v2 = Set.new()
			local vv = v + v2
			local vv = v < v2
			local vv = v <= v2
		end)
	end

	function FLoginUI:Connect()
		local nameObj = self:FindChildObj(OBJPATH.Name)
		local passwdObj = self:FindChildObj(OBJPATH.Passwd)
		local ip = "47.92.230.103"
		local port = 8001
		local name = FGUITools.getInputText(nameObj)
		local passwd = FGUITools.getInputText(passwdObj)
		theGame.m_LogicNetwork:ConnectTo(ip,port,name,passwd)
	end
end

return FLoginUI
