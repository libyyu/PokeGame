import "UnityEngine"

GameObject = UnityEngine.GameObject
Vector2 = UnityEngine.Vector2
Vector3 = UnityEngine.Vector3
Quaternion = UnityEngine.Quaternion

if not rawget(GameUtil, "AssetRoot") then
	rawset(GameUtil, "AssetRoot", UnityEngine.Application.dataPath .. "/../../Output")
end

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

function TransformAssetName(inAssetName)
	--Arts/UI/UIStart.prefab
	--Main@Arts/UI/FairyGUI/Starup.ab

	inAssetName = inAssetName:lower()
	local assetPath = inAssetName
	local assetName
	local i = inAssetName:find('@')
    if i then
    	assetPath = inAssetName:sub(i + 1, -1)
    	assetName = inAssetName:sub(1, i-1)
    end

	if assetPath:sub(1, 7) ~= 'assets/' then
		assetPath = "assets/" .. assetPath
	end

    return assetPath, assetName
end

function TransformABAndAssetName(assetName)
	local abName, mainName = TransformAssetName(assetName)
	
	local i = abName:find_last(".", true)
    if i then
        abName = abName:sub(1, i - 1)
    end

    local abExt = GameUtil.BundleExt
	if abName:sub(-3) ~= abExt then
		abName = abName .. abExt
	end
	return abName, mainName or assetName
end

function TransformABName(assetName)
	local abName = TransformABAndAssetName(assetName)
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
	local abName, mainName = TransformABAndAssetName(assetName)
	AsyncLoadWithAB(abName, mainName, cb)
end

function AsyncLoadArray(assetNames, cb)
	if type(assetNames) ~= "table" then
		error(("argument #%d expected table, but got %s"):format(2, type(assetNames)))
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

function AsyncLoadABundle(assetBundleName, cb)
	local abName = TransformABName(assetBundleName)
	local FAssetBundleUtil = require "utility.FAssetBundleUtil"
	FAssetBundleUtil.Instance():AsyncLoadABundle(abName, function(ab)
		cb(ab)
	end)
end

function AsyncLoadABundleArray(assetBundleNames, cb)
	if type(assetBundleNames) ~= "table" then
		error(("argument #%d expected table, but got %s"):format(2, type(assetBundleName)))
	end
	local finishnum = 0
	local num = #assetBundleNames
	local result = {}
	for i, v in ipairs(assetBundleNames) do
		AsyncLoadABundle(v, function(ab)
			result[i] = ab
			finishnum = finishnum + 1
			if finishnum == num then
				cb(result)
			end
		end)
	end
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

function Instantiate(go, name, parentTr)
	local obj = parentTr and UnityEngine.Object.Instantiate(go, parentTr) or UnityEngine.Object.Instantiate(go)
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

function IsValidObject(obj)
	return obj ~= nil and not obj.isNil
end


function NewByteBuffer(data)
	if not data then
		return FByteBuffer()
	else
		return FByteBuffer(data)
	end
end

function ReadFileContent(filename)
	print("ReadFileContent", filename)
	local buff = GameUtil.ReadAssetFile(filename)
	-- if GameUtil.CanSepAssets and GameUtil.IsAssetFileExists(GameUtil.SepPath.."/"..filename) then
	-- 	buff = GameUtil.ReadAssetFile(GameUtil.SepPath.."/"..filename)
	-- elseif GameUtil.IsAssetFileExists(GameUtil.AssetRoot.."/"..filename) then
	-- 	buff = GameUtil.ReadAssetFile(GameUtil.AssetRoot.."/"..filename)
	-- else
	-- 	buff = GameUtil.ReadAssetFile(GameUtil.BaseStreamAssetPath.."/res_base/"..filename)
	-- end
	if buff then
		return LuaHelper.BytesToLuaString(buff)
	else
		return nil
	end
end

function IsWebGLRuntime()
	return UnityEngine.RuntimePlatform.WebGLPlayer == UnityEngine.Application.platform or GameUtil.IsWebGLEnv()
end

function IsWXRuntime()
	return IsWebGLRuntime() and not GameUtil.IsEditorEnv() and GameUtil.IsWXEnv()
end

_G.PlatformSuffix = IsWebGLRuntime() and "WebGL" or "App"
print("PlatformSuffix", PlatformSuffix, "IsWebGLRuntime", IsWebGLRuntime(), "IsWXRuntime", IsWXRuntime())

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

function TickGame(DeltaTime)
	TickCoroutine(DeltaTime)
	if theGame then
	end
end

function OnApplicationQuit()
	if FairyGUI then
		FairyGUI.GLoader.gLoaderFunc = nil
	end
end

function _G.WriteToFile (path, content, binary)
	GameUtil.CreateDirectoryForFile(path)
	local fout = io.open(path, binary and "wb" or "w")
	if fout then
		fout:write(content)
		fout:close()
		return true
	else
		return false
	end
end
function _G.AppendToFile(path, content)
	GameUtil.CreateDirectoryForFile(path)
	local fout = io.open(path, "a+")
	if fout then
		fout:write(content)
		fout:close()
		return true
	else
		return false
	end
end
function _G.ReadFromFile (path, binary)
	local fin = io.open(path, binary and "rb" or "r")
	if fin then
		local content = fin:read("*a")
		fin:close()
		return content
	else
		return nil
	end
end