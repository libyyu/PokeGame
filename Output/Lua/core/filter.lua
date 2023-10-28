--!A cross-platform build utility based on Lua
--
-- Licensed to the Apache Software Foundation (ASF) under one
-- or more contributor license agreements.  See the NOTICE file
-- distributed with this work for additional information
-- regarding copyright ownership.  The ASF licenses this file
-- to you under the Apache License, Version 2.0 (the
-- "License"); you may not use this file except in compliance
-- with the License.  You may obtain a copy of the License at
--
--     http://www.apache.org/licenses/LICENSE-2.0
--
-- Unless required by applicable law or agreed to in writing, software
-- distributed under the License is distributed on an "AS IS" BASIS,
-- WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
-- See the License for the specific language governing permissions and
-- limitations under the License.
-- 
-- Copyright (C) 2015 - 2018, TBOOX Open Source Group.
--
-- @author      ruki
-- @file        filter.lua
--

-- define module: filter
local filter = filter or {}

-- globals
local escape_table1 = {["$"] = "\001", ["("] = "\002", [")"] = "\003", ["%"] = "\004"}
local escape_table2 = {["\001"] = "$", ["\002"] = "(", ["\003"] = ")", ["\004"] = "%"}

-- new filter instance
function filter.new()

    -- init an filter instance
    local self = setmetatable({}, filter)
    filter.__index = filter

    -- init handler
    self._HANDLERS = {}

    -- ok
    return self
end

-- filter the shell command
-- 
-- .e.g
--
-- print("$(shell echo hello xmake)")
-- add_ldflags("$(shell pkg-config --libs sqlite3)")
--
function filter.shell(cmd)

    -- empty?
    if #cmd == 0 then
        os.raise("empty $(shell)!")
    end

    local file = io.popen(cmd)
    if file then
        local content = file:read("*a")
        file:close()

        return content
    end

    return ("run %$(shell %s) failed"):format(cmd)
end

-- filter the environment variables
function filter.env(name)
    return os.getenv(name) 
end

-- filter the winreg path
function filter.reg(path)

    -- must be windows
    if os.host() ~= "windows" then
        return 
    end

    -- query registry value
    return (winos.registry_query(path)) 
end

-- set handlers
function filter:set_handlers(handlers)
    self._HANDLERS = handlers
end

-- get handlers
function filter:handlers()
    return self._HANDLERS
end

-- register handler
function filter:register(name, handler)
    self._HANDLERS[name] = handler
end

-- get variable value
function filter:get(variable)
    -- check
    assert(variable)

    -- is shell?
    if variable:startswith("shell ") then
        return filter.shell(variable:sub(7))
    -- is environment variable?
    elseif variable:startswith("env ") then
        return filter.env(variable:sub(5))
    elseif variable:startswith("reg ") then
        return filter.reg(variable:sub(5))
    end

    local params = variable:split(' ')
    local varkey = params[1]
    params = variable:sub(#varkey+1):trim()

    -- handler it
    local result = nil
    if self._HANDLERS[varkey] then
        result = self._HANDLERS[varkey](params)
        if result then
            return result
        end
    end

    if self._HANDLERS["common"] then
        result = self._HANDLERS["common"](varkey, params)
        if result then
            return result
        end
    end

    -- parse variable:mode
    local varmode   = variable:split(':')
    local mode      = varmode[2]
    variable        = varmode[1]
   
    -- handler it
    local result = nil
    for name, handler in pairs(self._HANDLERS) do
        result = handler(variable)
        if result then
            break
        end
    end

    -- TODO need improve
    -- handle mode
    if mode and result then
        if mode == "upper" then
            result = result:upper()
        elseif mode == "lower" then
            result = result:lower()
        end
    end

    -- ok?
    return result
end

-- filter the builtin variables: "hello $(variable)" for string
--
-- .e.g  
--
-- print("$(host)")
-- print("$(env PATH)")
-- print("$(shell echo hello xmake!)")
-- print("$(reg HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\XXXX;Name)")
--
function filter:handle(value)

    -- check
    assert(type(value) == "string", value)

    -- escape "%$", "%(", "%)", "%%" to "\001", "\002", "\003", "\004"
    value = value:gsub("%%([%$%(%)%%])", function (ch) return escape_table1[ch] end)

    -- filter the builtin variables
    return (value:gsub("%$%((.-)%)", function (variable) 
        
        -- escape "%$", "%(", "%)", "%%" to "$", "(", ")", "%"
        variable = variable:gsub("[\001\002\003\004]", function (ch) return escape_table2[ch] end)

        -- get variable value
        return self:get(variable) or ""

    end):gsub("[\001\002\003\004]", function (ch) return escape_table2[ch] end))
end


-- return module: filter
return filter