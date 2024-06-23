local FBaseUI = require "ui.FBaseUI"
local FGUITools = require "utility.FGUITools"

local l_instance = nil
local FLoginUI = FLua.Class(FBaseUI, "FLoginUI")
do
	local OBJPATH = 
	{
		Name = "login_panel/input_group/account/input_account",
		Passwd = "login_panel/input_group/password/input_password",
	}
	function FLoginUI.Instance()
		if not l_instance then
			l_instance = FLoginUI()
			l_instance.m_UnloadBundleWhenDestroy = true
			l_instance.m_TriggerGCWhenDestroy = true
		end
		return l_instance
	end

	function FLoginUI:ShowPanel(show)
		if show then
			if not self.m_panel then
				self:CreatePanel(ResPathReader.LoginUI)
			end
		else
			self:DestroyPanel()
		end
	end

	function FLoginUI:OnCreate()
		local nameObj = self:FindChildObj(OBJPATH.Name)
		local passwdObj = self:FindChildObj(OBJPATH.Passwd)
		local logginInfo = theGame.m_LoginInfo or {}
		FGUITools.setInputText(nameObj,logginInfo.name or "")
		FGUITools.setInputText(passwdObj,logginInfo.passwd or "")
		local btn = self:FindChildObj("login_panel/btn_group/btn_server"):GetComponent(UnityEngine.UI.Button)
	end

	function FLoginUI:OnClick(go)
		if go.name == "btn_login" then
			self:Connect()	
			local FWaitingUI = require "ui.FWaitingUI"
			FWaitingUI.Instance():ShowTip(nil)
		elseif go.name == "btn_server" then
			local FServerListUI = require "ui.FServerListUI"
			FServerListUI.Instance():ShowPanel(true)
		else
			Application.OpenURL("https://www.baidu.com")
		end
	end
	function FLoginUI:Connect()
		local nameObj = self:FindChildObj(OBJPATH.Name)
		local passwdObj = self:FindChildObj(OBJPATH.Passwd)
		local ip = "127.0.0.1"
		local port = 8001
		local name = FGUITools.getInputText(nameObj)
		local passwd = FGUITools.getInputText(passwdObj)
		theGame.m_LogicNetwork:ConnectTo(ip,port,name,passwd)
	end
end

return FLoginUI
