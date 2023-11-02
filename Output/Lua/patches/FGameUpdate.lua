local FUpdateSession = require "network.FUpdateSession"
local SLAXML = require "lib.SLAXML.slaxdom"
local FUpdateUI = require "patches.FUpdateUI"
local FGameUpdate = FLua.Class("FGameUpdate")
local l_instance = nil
do
    local _MAX_VERSION_ = 9999
    local function tobool(str)
        return str == "true" or str == "1"
    end
    local function compareVersionString(versionA,versionB)
        local va = versionA:split(".")
        local vb = versionB:split(".")
        local localV1,localV2,localV3 = tonumber(va[1]),tonumber(va[2]),tonumber(va[3])
        local remoteV1,remoteV2,remoteV3 = tonumber(vb[1]),tonumber(vb[2]),tonumber(vb[3])
        if localV1 < remoteV1 then return -1 end
        if localV1 > remoteV1 then return 1 end
        if localV2 < remoteV2 then return -1 end
        if localV2 > remoteV2 then return 1 end
        if localV3 < remoteV3 then return -1 end
        if localV3 > remoteV3 then return 1 else
        return 0 end
    end
    local function nextVersionStr(versionA)
        local va = versionA:split(".")
        local localV1,localV2,localV3 = tonumber(va[1]),tonumber(va[2]),tonumber(va[3])
        if localV3 < _MAX_VERSION_ then
            return string.format("%d.%d.%d",localV1,localV2,localV3+1)
        elseif localV2 < _MAX_VERSION_ then
            return string.format("%d.%d.%d",localV1,localV2+1,0)
        else
            return string.format("%d.%d.%d",localV1+1,0,0)
        end
    end
      local function prevVersionStr(versionA)
        local va = versionA:split(".")
        local localV1,localV2,localV3 = tonumber(va[1]),tonumber(va[2]),tonumber(va[3])
        if localV3 >0 then
            return string.format("%d.%d.%d",localV1,localV2,localV3-1)
        elseif localV2 > 0 then
            return string.format("%d.%d.%d",localV1,localV2-1,_MAX_VERSION_)
        else
            return string.format("%d.%d.%d",localV1-1,_MAX_VERSION_,_MAX_VERSION_)
        end
    end
    --version.xml
    local function parseVersion(content)
        local doc = SLAXML:dom(content)
        if not doc then return nil end
        local root = doc.root
        if not root then return nil end
        local result = {}
        result.project_name = root.attr.name
        for i,v in ipairs(root.el) do
            if v.name == "program" then
                result.program = {
                    method = v.attr.method,
                    action = v.attr.action,
                    md5 = v.attr.md5,
                }
            elseif v.name == "resource" then
                result.resource = {
                    package_url = v.attr.package_url,
                    ext = v.attr.ext,
                    mini_version = v.attr.mini_version,
                }
            end
        end

        return result
    end
    --启动参数
    local function parseEntryConfig(content)
        local doc = SLAXML:dom(content)
        if not doc then return nil end
        local root = doc.root
        if not root then return nil end
        local result = {}

        for i,v in ipairs(root.el) do
            if v.name == "program_updage" then
                result.program_updage = tobool(v.kids[1].value)
            elseif v.name == "resource_update" then
                result.resource_update = tobool(v.kids[1].value)
            elseif v.name == "dirserver" then
                local dirserver = {host=v.attr.host,port=tonumber(v.attr.port)}
                result.dirserver = dirserver
            end
        end
        return result
    end
    --res_base_version
    local function parseResBase(content)
        local doc = SLAXML:dom(content)
        if not doc then return nil end
        local root = doc.root
        if not root then return nil end
        return root.attr.value
    end
    --game_ver
    local function parseGameVer(content)
        local v = content:split(":")
        return v[2]
    end
    local function saveGameVer(ver)
        GameUtil.CreateDirectory(GameUtil.AssetRoot.."/Configs")
        local gameversion = GameUtil.AssetRoot.."/Configs/game_ver"
        local fp = io.open(gameversion,"wb")
        fp:write(string.format("version:%s", ver))
        fp:close()
    end
    --version.txt
    local function parseVersiontxt(_content)
        local content = _content:gsub("\r\n","\n")
        local fields = content:split("\n")
        local result = {}
        local v = fields[1]:split(":")
        result.project_name = v[2]
        v = fields[2]:split(":")
        assert(v[1] == "patches")
        local vers = v[2]:split("/")
        result.lates_version = vers[1]
        result.base_version = vers[2]
        local count = #fields
        local patcheslist = {}
        local patch_count = 0
        for i=3,count do
            local p = fields[i]:split(":")
            local vs = p[1]:split("-")
            local info = {
                begin_v = vs[1],
                end_v = vs[2],
                size = tonumber(p[2]),
            }
            patch_count = patch_count + 1
            patcheslist[p[1]] = info
        end
        result.patches_dict = patcheslist
        result.patches_count = patch_count
        return result
    end
    --获取更新的patches列表
    local function get_patheslist(now_version,latest_version, patches_dict,patches_count)
        local first_patch = string.format("%s-%s",now_version,latest_version)
        --优先查找是否可以一次下载
        if patches_dict[first_patch] then
            return {patches_dict[first_patch],}
        else
            local function exists(vb,ve)
                local patch = string.format("%s-%s",vb,ve)
                return patches_dict[patch] ~= nil
            end
            local function find(vb,ve)
                if exists(vb, ve) then return ve end
                local lastValid = nil
                local nextVer = nextVersionStr(vb)
                while compareVersionString(nextVer, ve) <0 do
                    if exists(vb, nextVer) then
                        lastValid = nextVer
                    end
                    nextVer = nextVersionStr(nextVer)
                end
                return lastValid
            end

            local result = {}
            local vb = now_version
            local vp = find(vb,latest_version)
            if not vp then
                vb = prevVersionStr(vb)
                vp = find(vb,latest_version)
                while not vp and compareVersionString(vb,"0.0.0") >0 do
                    vb = prevVersionStr(vb)
                    vp = find(vb,latest_version)
                end
            end
            if vp then
                while vp do
                    local patch = string.format("%s-%s",vb,vp)
                    result[#result+1] = patches_dict[patch]
                    vb = vp
                    vp = find(vp,latest_version)
                end
            end
            --按照更新顺序排序
            table.sort(result,function(a,b)
                local patcha = string.format("%s-%s",a.begin_v,a.end_v)
                local patchb = string.format("%s-%s",b.begin_v,b.end_v)
                return patcha < patchb
            end)

            return result
        end
    end

    function FGameUpdate:__constructor()
        self.m_UpdateSession = nil
        self.m_UpdateFinished = false
        self.m_EntryConfig = nil
        self.m_LoaclVersion = nil
        self.m_ResBaseVersion = nil
        self.m_RemoteVersion = nil
        self.m_PatchesInfo = nil
        self.m_GameVersion = nil
    end
    function FGameUpdate.Instance()
        if not l_instance then
            l_instance = FGameUpdate()
            l_instance:Init()
        end
        return l_instance
    end
    function FGameUpdate:Init()
        local entry_path = "Configs/entrypoint.xml"
        local content = _G.ReadFileContent(entry_path)
        self.m_EntryConfig = parseEntryConfig(content)
        if not self.m_EntryConfig then
            error("can not get entrypoint.xml",1)
        end

        local resbase_path = "Configs/res_base_version.xml"
        content = ReadFileContent(resbase_path)
        self.m_ResBaseVersion = parseResBase(content)

        local version_path = "Configs/version.xml"
        content = ReadFileContent(version_path)
        self.m_LoaclVersion = parseVersion(content)
        if not self.m_LoaclVersion then
            error("can not get local-version.xml",1)
        end

        GameUtil.CreateDirectory(GameUtil.AssetRoot.."/Configs")
        local gameversion = GameUtil.AssetRoot.."/Configs/game_ver"
        if not GameUtil.IsAssetFileExists(gameversion) then
           local fp = io.open(gameversion,"wb")
           fp:write(string.format("version:%s",self.m_ResBaseVersion))
           fp:close()
        end
    end

    function FGameUpdate:Run()
        self.m_UpdateSession = FUpdateSession.Instance()
        self.m_UpdateSession:InitNetwork()

        FUpdateUI.Instance():ShowPanel(true)

        self.m_UpdateFinished = false
        local c = coroutine.create(function()
            self:UpdateDirCoroutine()
        end)
        coroutine.resume(c)
    end

    function FGameUpdate:UpdateDirCoroutine()
        if not self.m_EntryConfig.resource_update then
            warn("客户端禁止更新")
            self.m_UpdateFinished = true
            self:OnFinished(true)
            return
        end
        print ("检查更新中。。。")
        self.m_UpdateSession:InitNetwork()
        self.m_UpdateSession:Reset()
        self.m_UpdateSession:ConnectTo(self.m_EntryConfig.dirserver.host, self.m_EntryConfig.dirserver.port)

        Yield(WaitUntil(function()return self.m_UpdateSession:IsDone() end))
        self.m_UpdateSession:Close()

        if not self.m_UpdateSession.m_VersionInfo or #self.m_UpdateSession.m_VersionInfo == 0 then
            warn("获取更新失败。。。")
            MsgBox(self,StringReader.Get(5),"update",MsgBoxType.MBBT_OK,function(_,ret)
                if ret == MsgBoxRetT.MBRT_OK then
                    local c = coroutine.create(function()
                        self:UpdateDirCoroutine()
                    end)
                    coroutine.resume(c)
                else
                    self:OnFinished(false)
                end
            end)
        else
            self.m_PatchesInfo = self.m_UpdateSession.m_PatchesInfo
            self.m_RemoteVersion = parseVersion(self.m_UpdateSession.m_VersionInfo) 
            self:UpdateCoroutineWithVersion()
        end
    end

    function FGameUpdate:UpdateCoroutineWithVersion()
        if not self.m_RemoteVersion then
            MsgBox(self,StringReader.Get(6),"update",MsgBoxType.MBT_INFO)
        elseif self.m_LoaclVersion.project_name ~= self.m_RemoteVersion.project_name then
            MsgBox(self,StringReader.Get(7),"update",MsgBoxType.MBT_INFO)
        else
            local versiontxt = GameUtil.AssetRoot.."/Configs/game_ver"
            local content = GameUtil.ReadAssetFile(versiontxt)
            local game_version = self.m_ResBaseVersion
            if content then
                local txt_version = parseGameVer(LuaHelper.BytesToLuaString(content))
                if compareVersionString(txt_version, self.m_ResBaseVersion) >0 then
                    game_version = txt_version
                end
            end

            local patchesInfo = parseVersiontxt(self.m_PatchesInfo)
            if not patchesInfo then
                MsgBox(self,StringReader.Get(9),"update",MsgBoxType.MBT_INFO)
                return
            elseif self.m_LoaclVersion.project_name ~= patchesInfo.project_name then
                MsgBox(self,StringReader.Get(7),"update",MsgBoxType.MBT_INFO)
                return
            elseif compareVersionString(game_version,patchesInfo.base_version) <0 then
                MsgBox(self,StringReader.Get(10),"update",MsgBoxType.MBT_INFO)
                return
            end
            warn("localversion:",game_version, "remote-version",patchesInfo.lates_version)
            Yield(WaitUntil(function()return FUpdateUI.Instance():IsActive() end))
            FUpdateUI.Instance():SetLoaclVersion(game_version)
            FUpdateUI.Instance():SetRemoteVersion(patchesInfo.lates_version)
            FUpdateUI.Instance():SetProgress(0)
            FUpdateUI.Instance():SetTip(StringReader.Get(11))
            if compareVersionString(game_version, patchesInfo.lates_version) < 0 then 
                FUpdateUI.Instance():SetTip(StringReader.Get(14))
                local patches_list = get_patheslist(game_version, patchesInfo.lates_version, patchesInfo.patches_dict,patchesInfo.patches_count)
                local updateSize = self:CalcDownloadSize(patches_list)
                local boxType = compareVersionString(game_version, self.m_RemoteVersion.resource.mini_version) >= 0 and MsgBoxType.MBBT_OKCANCEL or MsgBoxType.MBBT_OK
                MsgBox(self,StringReader.Get(8),"update",boxType,function(_,ret)
                    if ret == MsgBoxRetT.MBRT_OK then
                        warn("准备下载更新资源,更新大小：",updateSize)
                        self:DownloadResource(patches_list)
                    else
                        self:Finish()
                    end
                end)
            else
                self:Finish()
            end
        end
    end

    function FGameUpdate:CalcDownloadSize(patch_list) 
        local size = 0
        for _,v in ipairs(patch_list) do
            size = size + v.size
        end
        return size
    end

    function FGameUpdate:DownloadResource(patch_list)
        --下载目录
        local patches_dir = GameUtil.AssetRoot .. "/patches"
        GameUtil.CreateDirectory(patches_dir)

        local function downloadinfo(patchinfo)
            local url = self.m_RemoteVersion.resource.package_url .. string.format("%s-%s",patchinfo.begin_v,patchinfo.end_v) .. self.m_RemoteVersion.resource.ext
            local filename = patches_dir .. "/" .. string.format("%s-%s",patchinfo.begin_v,patchinfo.end_v) .. self.m_RemoteVersion.resource.ext
            return url, filename
        end

        local isDownFinished = false
        local c = coroutine.create(function()
            local bFailed = false
            while not bFailed do
                local patchinfo = patch_list[1]
                if not patchinfo then
                    break
                end
                local curFinished = false
                local url,filename = downloadinfo(patchinfo)
                FUpdateUI.Instance():SetProgress(0)
                FUpdateUI.Instance():SetTip(StringReader.Get(12))
                print("DownLoad " .. url .. " To " .. filename)
                GameUtil.DownLoad(url,filename,true,true,nil,
                function(a,b,c)
                    print("下载进度：",b/c*100 .. "%")
                    FUpdateUI.Instance():SetProgress(b/c)
                end,
                function(succeess,req,resp,complete_param)
                    if succeess then
                        print("下载完成，开始解压")
                        FUpdateUI.Instance():SetProgress(0)
                        FUpdateUI.Instance():SetTip(StringReader.Get(13))
                        GameUtil.UnZip(filename, patches_dir.."/temp","", function(name,pro,size,length)
                            FUpdateUI.Instance():SetProgress(size/length)
                        end)
                        curFinished = true
                        --TODO:此处应写入版本信息
                        saveGameVer(patchinfo.end_v)
                        --TODO:删除已经成功下载的
                        table.remove(patch_list, 1)
                    else
                        bFailed = true
                        print("下载失败。", complete_param)
                        MsgBox(self,StringReader.Get(16),"update",MsgBoxType.MBBT_OK,function(_,ret)
                            if ret == MsgBoxRetT.MBRT_OK then
                                self:DownloadResource(patch_list)
                            end
                        end)
                    end
                end)
                if bFailed then
                    break
                end
                Yield(WaitUntil(function()return curFinished end))
            end
            if not bFailed then
                FUpdateUI.Instance():SetProgress(1)
                FUpdateUI.Instance():SetTip(StringReader.Get(15))
                Yield(WaitForEndOfFrame())
                Yield(WaitForEndOfFrame())
                FUpdateUI.Instance():DestroyPanel()

                self:Finish()
            end
        end)
        coroutine.resume(c)
    end

    function FGameUpdate:Finish()
        self:OnFinished(true)
        self.m_UpdateFinished = true
    end

    function FGameUpdate:OnFinished(succeess)
        warn("OnFinished", succeess)
        FUpdateUI.Instance():ShowPanel(false)
        self.m_UpdateSession:FinishWorking()
    end

    function FGameUpdate:IsFinished()
        return self.m_UpdateFinished
    end
end

return FGameUpdate