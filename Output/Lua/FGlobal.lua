import "UnityEngine"

GameObject = UnityEngine.GameObject
Vector2 = UnityEngine.Vector2
Vector3 = UnityEngine.Vector3
Quaternion = UnityEngine.Quaternion

function OnUnityLog(t,str)
	if theGame then
		theGame:OnUnityLog(t,str)
	end
end

function OnHotKeyCodeMap()
	return {
		KeyCode.Tab,
		KeyCode.Escape,
		KeyCode.UpArrow,
		KeyCode.DownArrow,
		KeyCode.RightArrow,
		KeyCode.LeftArrow,
		KeyCode.Return,
	}
end

function OnHotKeyInput( key, down )
	local KeyCode = UnityEngine.KeyCode
	if key == KeyCode.Tab and down then
		theGame:ToggleConsole()
	elseif key == KeyCode.Escape then
		theGame:ForceCloseConsole()
	elseif key == KeyCode.UpArrow then
		if theGame.m_HostPlayer then
			theGame.m_HostPlayer:Play("Run",UnityEngine.WrapMode.Loop)
		end
	elseif key == KeyCode.DownArrow then
		if theGame.m_HostPlayer then
			theGame.m_HostPlayer:Play("Skill",UnityEngine.WrapMode.Once)
		end
	elseif key == KeyCode.RightArrow and down then
		if theGame.m_HostPlayer then
			theGame.m_HostPlayer:Play("Skill",UnityEngine.WrapMode.Once)
		end
	elseif key == KeyCode.Return then
		if theGame.m_HostPlayer then
			theGame.m_HostPlayer:Play("Idle",UnityEngine.WrapMode.Loop)
		end
	end
end

function TransformABName(assetName)
	local abName = assetName:lower()
	if abName:sub(1, 7) ~= 'assets/' then
		abName = "assets/" .. abName
	end

	local i = abName:find_last(".", true)
    if i then
        abName = abName:sub(1, i - 1)
    end

	if abName:sub(-3) ~= ".ab" then
		abName = abName .. ".ab"
	end
	return abName
end

function AsyncLoadWithAB(abName, assetName, cb)
	local FAssetBundleUtil = require "utility.FAssetBundleUtil"
	FAssetBundleUtil.Instance():AsyncLoad(abName, assetName, function(obj)
		cb(obj)
	end)
end

function AsyncLoad(assetName, cb)
	if type(assetName) ~= "string" then
		error(("argument #%d expected string, but got %s"):format(1, type(assetName)))
	end
	local abName = TransformABName(assetName)
	AsyncLoadWithAB(abName, assetName, cb)
end

function AsyncLoadArray(assetNames, cb)
	if type(assetName) ~= "table" then
		error(("argument #%d expected table, but got %s"):format(2, type(assetName)))
	end

	local results = {}
	local count = #assetNames
	local finishnum = 0
	for i=1, #assetNames do
		AsyncLoad(assetNames[i], function(obj)
			results[i] = obj
			finishnum = finishnum + 1

			if finishnum == count then
				cb(results)
			end
		end)
	end
end

function AsyncLoadABundle(assetBundleName)
	local abName = TransformABName(assetBundleName)
	local FAssetBundleUtil = require "utility.FAssetBundleUtil"
	FAssetBundleUtil.Instance():AsyncLoadABundle(abName, function(ab)
		cb(ab)
	end)
end

function UnloadAssetBundle(assetBundleName, unload)
	local abName = TransformABName(assetBundleName)
	local FAssetBundleUtil = require "utility.FAssetBundleUtil"
	FAssetBundleUtil.Instance():UnloadABundle(abName, unload)
end

function MsgBox(hwnd,content,title,mask,click_cb)
	local FMsgBoxMan = require "manager.FMsgBoxMan"
	FMsgBoxMan.Instance():ShowMsgBox(hwnd,content,title,mask,click_cb)
end

function AddEvent(obj, ...)
	theGame.m_LogicEvent:AddEvent(obj,...)
end

function DelEvent(obj,...)
	theGame.m_LogicEvent:DelEvent(obj,...)
end

function FireEvent(eventname,...)
	theGame.m_LogicEvent:Fire(eventname,...)
end

function NewGameObject(name, parent)
	if type(name) == "string" then
		local go = GameObject(name)
		if parent then
			go.transform:SetParent(parent.transform)
		end
		return go
	elseif not name then
		local go = GameObject()
		if parent then
			go.transform:SetParent(parent.transform)
		end
		return go
	else
		error("constructor GameObject param 1 is expected nil or string")
	end
end

function Instantiate(go,name)
	local obj = UnityEngine.Object.Instantiate(go)
	if type(name) == "string" then
		obj.name = name
	end
	return obj
end

function DestroyObject(go)
	UnityEngine.Object.Destroy(go)
end

function DontDestroyOnLoad(go)
	UnityEngine.Object.DontDestroyOnLoad(go)
end

function Table2String(tab)
    local str = {}
    local function internal(tab, str, indent)
        for k,v in pairs(tab) do
            if type(v) == "table" then
                table.insert(str, indent.."["..tostring(k).."]="..":\n")
                internal(v, str, indent..' ')
            else
                table.insert(str, indent..tostring(k).."="..tostring(v).."\n")
            end
        end
    end

    internal(tab, str, '')
    return table.concat(str, '')
end

function PrintTable(t)
	local str = Table2String(t)
	print(str)
end

function NewByteBuffer(data)
	if not data then
		return FByteBuffer()
	else
		return FByteBuffer(data)
	end
end

function ReadFileContent(filename)
	local buff
	if GameUtil.CanSepAssets and GameUtil.IsAssetFileExists(GameUtil.SepPath.."/"..filename) then
		buff = GameUtil.ReadAssetFile(GameUtil.SepPath.."/"..filename)
	elseif GameUtil.IsAssetFileExists(GameUtil.AssetRoot.."/"..filename) then
		buff = GameUtil.ReadAssetFile(GameUtil.AssetRoot.."/"..filename)
	else
		buff = GameUtil.ReadAssetFile(GameUtil.BaseStreamAssetPath.."/res_base/"..filename)
	end
	if buff then
		return LuaHelper.BytesToLuaString(buff)
	else
		return nil
	end
end

function IsWebGLRuntime()
	return UnityEngine.RuntimePlatform.WebGLPlayer == UnityEngine.Application.platform
end

_G.PlatformSuffix = IsWebGLRuntime() and "WebGL" or "App"


local function mask_to_index_func()
    local c = 1
    local t = {}
    for i = 0, 31 do
        t[c] = i
        c = c * 2
    end
    return t
end

_G.mask_to_index = mask_to_index_func()
_G.mask_to_string = function(mask)
	local str = ""
	for i = 0, 31 do
		if mask == 0 then break end
		if mask % 2 == 1 then
			str = str..tostring(i)..";"
		end
		mask = math.floor( mask/2)
	end
	return str
end

function _G.index_to_mask (index)
	return bit.lshift(1, index - 1)
end