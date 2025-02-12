--!A cross-platform build utility based on Lua
--
-- Licensed under the Apache License, Version 2.0 (the "License");
-- you may not use this file except in compliance with the License.
-- You may obtain a copy of the License at
--
--     http://www.apache.org/licenses/LICENSE-2.0
--
-- Unless required by applicable law or agreed to in writing, software
-- distributed under the License is distributed on an "AS IS" BASIS,
-- WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
-- See the License for the specific language governing permissions and
-- limitations under the License.
-- 
-- Copyright (C) 2015 - 2019, TBOOX Open Source Group.
--
-- @author      ruki
-- @file        path.lua
--

-- define module: path
path = path or {}

-- get the directory of the path
function path.directory(p)

    -- check
    assert(p)

    local i = p:find_last("[/\\]")
    if i then
        if i > 1 then i = i - 1 end
        return p:sub(1, i)
    else
        return "."
    end
end

-- get the filename of the path
function path.filename(p)

    -- check
    assert(p)

    local i = p:find_last("[/\\]")
    if i then
        return p:sub(i + 1)
    else
        return p
    end
end

-- get the basename of the path
function path.basename(p)

    -- check
    assert(p)

    local name = path.filename(p)
    local i = name:find_last(".", true)
    if i then
        return name:sub(1, i - 1)
    else
        return name
    end
end

-- get the file extension of the path: .xxx
function path.extension(p)

    -- check
    assert(p)

    -- get extension
    local i = p:find_last(".", true)
    if i then
        return p:sub(i)
    else
        return ""
    end
end

-- join path
function path.join(p, ...)

    -- check
    assert(p)

    -- join them
    for _, name in ipairs({...}) do
        p = p .. "/" .. name
    end

    -- translate path
    return path.translate(p)
end

-- join path
function path.urljoin(p, ...)

    -- check
    assert(p)

    -- join them
    for _, name in ipairs({...}) do
        if name:startswith('?') or name:startswith('&') then
            p = p .. name
        else
            p = p .. "/" .. name
        end
    end

    return p
end

function path.translate(p)
    return p:gsub("/", path.sep()):gsub("\\", path.sep())
end

-- split path by the separator
function path.split(p)

    -- check
    assert(p)

    return p:split("/\\")
end

-- get the path seperator
function path.sep()
    return os._HOST == "windows" and '\\' or '/'
end

-- get the path seperator of environment variable
function path.envsep()
    return os._HOST == "windows" and ';' or ':'
end

-- split environment variable with `path.envsep()`,
-- also handles more speical cases such as posix flags and windows quoted pathes
function path.splitenv(env_path)

    -- check
    assert(env_path)

    local result = {}
    if os._HOST == "windows" then
        while #env_path > 0 do
            if env_path:startswith(path.envsep()) then
                env_path = env_path:sub(2)
            elseif env_path:startswith('"') then
                -- path quoted with, can contain `;`
                local p_end = env_path:find('"' .. path.envsep(), 2, true) or env_path:find('"$', 2) or (#env_path + 1)
                table.insert(result, env_path:sub(2, p_end - 1))
                env_path = env_path:sub(p_end + 1)
            else
                local p_end = env_path:find(path.envsep(), 2, true) or (#env_path + 1)
                table.insert(result, env_path:sub(1, p_end - 1))
                env_path = env_path:sub(p_end)
            end
        end
    else
        -- see https://git.kernel.org/pub/scm/utils/dash/dash.git/tree/src/exec.c?h=v0.5.9.1&id=afe0e0152e4dc12d84be3c02d6d62b0456d68580#n173
        -- no escape sequences, so `:` and `%` is invalid in environment variable
        for _, v in ipairs(env_path:split(path.envsep(), { plain = true })) do
            -- flag for shells, style `<path>%<flag>`
            local flag = v:find("%", 1, true)
            if flag then
                v = v:sub(1, flag - 1)
            end
            if #v > 0 then
                table.insert(result, v)
            end
        end
    end

    return result
end

-- the last character is the path seperator?
function path.islastsep(p)

    -- check
    assert(p)

    local sep = p:sub(#p, #p)
    return os._HOST == "windows" and (sep == '\\' or sep == '/') or (sep == '/')
end

-- convert path pattern to a lua pattern
function path.pattern(pattern)

    -- translate wildcards, .e.g *, **
    pattern = pattern:gsub("([%+%.%-%^%$%(%)%%])", "%%%1")
    pattern = pattern:gsub("%*%*", "\001")
    pattern = pattern:gsub("%*", "\002")
    pattern = pattern:gsub("\001", ".*")
    pattern = pattern:gsub("\002", "[^/]*")

    -- case-insensitive filesystem?
    if not os.fscase() then
        pattern = string.ipattern(pattern, true)
    end
    return pattern
end

function path.exists(p)
    if os.FileExists(p) then
        return true, "file"
    elseif os.DirExists(p) then 
        return true, "directory"
    else
        return false
    end
end

-- return module: path
return path
