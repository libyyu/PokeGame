local getmetatable = getmetatable
local setmetatable = setmetatable
local error = error
local print = print
local type = type
local select = select
local assert = assert
local require = require
local pcall = pcall
local xpcall = xpcall
local tostring = tostring
local debug = debug

local _M = {}
local _ABSTRACT = 1
local _STATIC = 2
local _FINAL = 3
local _INTERFACE = 4
local _CLASS = 5

local createGcProxy
if _VERSION == "Lua 5.1" then
    function createGcProxy (callback)
        local proxy = newproxy(true)
        local meta = getmetatable(proxy)
        meta.__gc = callback
        return proxy
    end
else
    function createGcProxy (callback)
        local proxy = {}
        local meta = {}
        meta.__gc = callback
        return setmetatable(proxy, meta)
    end
end

do
    local typeClassMagic = {}
    local typeObjMagic = {}

    local all_class = {}
    local forward_class = {}

    local function _getClassMeta (classType)
        if type(classType) ~= "table" then
            return nil
        end
        
        local meta = getmetatable(classType)
        
        --check magic
        if meta == nil or rawget(meta, "__magic") ~= typeClassMagic then
            return nil
        end

        return meta
    end
    _M.getClassMeta = _getClassMeta

    local function _getObjMeta (obj)
        if type(obj) ~= "table" then
            return nil
        end
        
        local meta = getmetatable(obj)
        
        --check magic
        if meta == nil or rawget(meta, "__magic") ~= typeObjMagic then
            return nil
        end

        return meta
    end
    _M.getObjMeta = _getObjMeta

    local function _IsClass(classType)
        return nil ~= _getClassMeta(classType)
    end
    _M.IsClass = _IsClass

    local function _IsForwardDeclare(classType)
        local meta = _getClassMeta(classType)
        if meta and rawget(meta, "__declared") == true then
            return true
        end
    end

    local function _ForwardDeclare(className)
        if className ~= nil then
            if type(className) ~= "string" then
                error("invalid class-name (string expected, got " .. type(className) .. ")", 2)
            end

            local typeTable = all_class[className] or forward_class[className]
            if typeTable ~= nil then
                return typeTable
            end
        end

        local classType = {}

        local typeMeta = {
            __magic = typeClassMagic,
            __declared = true,
            __typetable = classType,
            __property = {},
            __typeName = className
        }
        --local cls_pointer = tostring(classType)
        typeMeta.__tostring = function(theType)
            local meta = getmetatable(theType)
            local typeString = (meta.__typeName or "anonymousType") .. "(forward declare)"
            return typeString
        end

        setmetatable(classType, typeMeta)
        if className then
            forward_class[className] = classType
        end

        return classType
    end
    _M.ForwardDeclare = _ForwardDeclare

    ------------------------------------------------------------------
    local function class__rawget(theType, key)
        local meta = getmetatable(theType)
        if rawget(meta, key) then
            return rawget(meta, key)
        end

        local property = meta.__property
        if property[key] then
            return property[key].value
        end

        return nil
    end

    local function class__tryget(theType, key)
        local meta = getmetatable(theType)
        if rawget(meta, key) then
            return rawget(meta, key)
        end

        local property = meta.__property
        if property[key] then
            return property[key].value
        else
            local parent = meta.__parent
            if parent then
                local pv = class__tryget(parent, key)
                if pv then
                    return pv
                end
            end
        end
        return nil
    end
    _M.class__tryget = class__tryget

    local function obj__tryget(obj, key)
        if rawget(obj, key) then
            return rawget(obj, key), true
        end
        local objMeta = getmetatable(obj)
        if rawget(objMeta, key) then
            return rawget(objMeta, key), true
        end

        local attributes = rawget(obj, "__attributes")
        if attributes and attributes[key] then
            return attributes[key].value, true
        else
            local v = class__tryget(objMeta.__classType, key)
            return v, not not v
        end
        return nil
    end
    _M.obj__tryget = obj__tryget
    ------------------------------------------------------------------

    local function _CreateEmptyClass(className, forwardCls)
        local resultTable
        if forwardCls ~= nil then
            resultTable = forwardCls
        else
            if className == nil then
                resultTable = {}
            else
                resultTable = forward_class[className] or {} 
            end
        end
        
        if className ~= nil then
            forward_class[className] = nil     -- fetch the forward declared type table
        end
        
        setmetatable(resultTable, nil)
        return resultTable
    end

    local function _Class(parentClassType, classNameOrForwardCls, classOption)
        local className
        local typeSourceInfo
        local forwardType

        if classNameOrForwardCls then
            if type(classNameOrForwardCls) == "string" then
                if all_class[classNameOrForwardCls] then
                    error("dumplicate define class " .. classNameOrForwardCls, 2)
                end

                className = classNameOrForwardCls
            elseif type(classNameOrForwardCls) == "table" then
                local forwardDeclareMeta = getmetatable(classNameOrForwardCls)
        
                if forwardDeclareMeta == nil then   -- not type table
                    error("invalid forward declare (type table expected, got " .. type(classNameOrForwardCls) .. ")", 2)
                end
                if not forwardDeclareMeta.__declared then
                    error("invalid forward declare (type is already defined)", 2)
                end

                forwardType = classNameOrForwardCls
            else
                error("arguement #2 must be string or forward-declare class-type, but got ".. type(classNameOrForwardCls), 2)
            end
        else
            local info = debug.getinfo(4, "Sl")
            if info then
                typeSourceInfo = ("@%s:%d"):format(tostring(info.short_src), tostring(info.currentline))
            end
        end

        if parentClassType then
            if _IsForwardDeclare(parentClassType) then
                error("forward declared type " .. tostring(parentClassType) .. " can not be inherited", 2)
            elseif not _IsClass(parentClassType) then
                error("arguement #1 must be class-type, but got ".. type(parentClassType), 2)
            else
                local parentOption = getmetatable(parentClassType).__options
                if parentOption and parentOption.type == _FINAL then
                    error("can not extend final class " .. tostring(parentClassType), 2)
                end

                if classOption and classOption.type == _STATIC then
                    if not parentOption or (parentOption.type == _CLASS) then
                        error("can not extend non-static class " .. tostring(parentClassType), 2)
                    end
                end
            end
        end
        
        --[[

            classType {
                __mt = typeMeta,
            }
            typeMeta {
                __parent,
                __index,
                __newindex,
                __tostring,
                __call,
                property...,
            }
            objMeta {
                __index,
                __newindex,
                __tostring,
                __gc,
                __class,
            }
            obj {
                __mt = objMeta,
            }
        ]]

        local classType = _CreateEmptyClass(className, forwardType)

        local built_in_type = 
        {
            __magic = true,
            __typetable = true,
            __property = true,
            __typeName = true,
            __mfields = true,
            __options = true,
            __objmt = true,
        }

        local objMeta = {
            __magic=typeObjMagic, 
            __classType=classType, 
        }

        local typeMeta = {
            __magic = typeClassMagic,
            __typetable = classType,
            __property = {},
            __typeName = className,
            __mfields = {},
            __options = classOption,
            __objmt = objMeta,
        }

        setmetatable(classType, typeMeta)

        if className then
            typeMeta.__typeName = className
        elseif typeSourceInfo then
            typeMeta.__typeSourceInfo = typeSourceInfo
        end

        if parentClassType then
            typeMeta.__parent = parentClassType
        end
        ------------------------------------------------------------------
        classType.Implement = function(interface)
            if not _M.getClassMeta(interface) then
                error(("arguement #1 not a valid FLua-class"):format(tostring(interface)), 2)
            end
            local classOption = getmetatable(interface).__options
            
            if classOption.type == _INTERFACE then
                typeMeta.__options.interfaces = typeMeta.__options.interfaces or {}
                table.insert(typeMeta.__options.interfaces, interface)
            else
                error(("arguement #1 not a valid interface class"):format(tostring(interface)), 2) 
            end
            return classType
        end
        ------------------------------------------------------------------

        local cls_pointer = tostring(classType)
        typeMeta.__tostring = function(theType)
            local meta = getmetatable(theType)
            local typeString = meta.__typeName or ("anonymousType" .. (meta.__typeSourceInfo or ""))
            return typeString .. "(".. cls_pointer .. ")"
        end

        typeMeta.__index = function(theType, key)
            local v = class__tryget(theType, key)
            if v then
                return v
            else
                error(("failed to access non-exist property '%s' in class:'%s'"):format(key, tostring(theType)), 2)
            end
        end

        typeMeta.__newindex = function(theType, key, value)
            if built_in_type[key] then
                error(("failed to override built-in property '%s' in class:'%s'"):format(key, tostring(theType)), 2)
            end
            -- local v = class__rawget(theType, key)
            -- if v then
            --    error(("failed to override property '%s' in class:'%s'"):format(key, tostring(theType)), 2) 
            -- end
            if #key >2 and key:sub(1, 2) == "__" then
                local meta = getmetatable(theType)
                meta[key] = value
                getmetatable(theType).__mfields[key] = value
                getmetatable(theType).__objmt[key] = value
            else
                local property = getmetatable(theType).__property
                property[key] = {value = value, }
            end
        end
        ------------------------------------------------------------------
        
        objMeta.__index = function(obj, key)
            local v, b = obj__tryget(obj, key)
            if b then
                return v
            else
                error(("failed to access non-exist field:'%s@%s'"):format(key, tostring(obj)), 2)
            end
        end

        objMeta.__newindex = function(obj, key, value)
            local v, b = obj__tryget(obj, key)
            if not v and not b and not rawget(obj, "__in_constructor") then
                error(("failed to assignment non-exist field:'%s@%s'"):format(key, tostring(obj)), 2)
                return
            end
            
            if key == "__magic" 
                or key == "__classType" 
                or key == "__gcproxy"
                or key == "__pointer" then
                error(("failed to assignment const field:'%s@%s'"):format(key, tostring(obj)), 2)
                return
            end

            local attributes = obj.__attributes
            attributes[key] = {value = value, }
        end

        objMeta.__tostring = function(obj)
            local meta = getmetatable(obj)
            local clsType = meta.__classType
            local toString = class__tryget(clsType, "toString") or class__tryget(clsType, "__tostring")
            if toString then 
                return toString(obj)
            else
                return tostring(clsType) ..  "(".. obj.__pointer .. ")"
            end
        end
        for _, k in ipairs({"__add", "__sub", "__mul", "__div", "__mod", "__pow", "__unm", "__contact", "__len", "__eq", "__lt", "__le"}) do
            local v = class__tryget(classType, k)
            if v and type(v) == "function" then
                rawset(objMeta, k, v)
            end
        end
        ------------------------------------------------------------------

        typeMeta.__call = function(theType, ...)
            local classOption = getmetatable(theType).__options
            if classOption and classOption.type == _ABSTRACT then
                error("can not instantiate abstract class " .. tostring(theType), 2)
            elseif classOption and classOption.type == _STATIC then
                error("can not instantiate static class " .. tostring(theType), 2)
            elseif classOption and classOption.type == _INTERFACE then
                error("can not instantiate interface class " .. tostring(theType), 2)
            end

            for _, interface in ipairs(classOption.interfaces or {}) do
                for k, v in pairs(getmetatable(interface).__mfields) do
                    if type(v) == "function" then
                        if not class__rawget(theType, k) or type(class__rawget(theType, k)) ~= "function" then
                            error(("can not instantiate class %s, interface '%s' must be implement"):format(tostring(theType), k), 2)
                        end
                    end
                end
                for k, v in pairs(getmetatable(interface).__property) do
                    if type(v.value) == "function" then
                        if not class__rawget(theType, k) or type(class__rawget(theType, k)) ~= "function" then
                            error(("can not instantiate class %s, interface method '%s' must be implement"):format(tostring(theType), k), 2)
                        end
                    end
                end
            end

            for _, k in ipairs({"__add", "__sub", "__mul", "__div", "__mod", "__pow", "__unm", "__contact", "__len", "__eq", "__lt", "__le"}) do
                local v = class__tryget(theType, k)
                if v and type(v) == "function" then
                    --print("rawset", k, v)
                    rawset(objMeta, k, v)
                end
            end

            local attributes = {}
            local instance = {__in_constructor=true, __ctor_args={...}, __attributes=attributes}

            attributes.__pointer = {value=tostring(instance)}
            
            setmetatable(instance, objMeta)

            --继承列表
            do
                local clsList = {}
                local pcls = theType
                while pcls ~= nil do
                    table.insert(clsList, pcls)
                    pcls = class__tryget(pcls, "__parent")
                end

                do --__destructor
                    attributes.__gcproxy = {value=createGcProxy(function(...)
                        --warn("__gc", instance, ...)
                        for i = 1, #clsList do
                            local _cls = clsList[i]
                            local func = class__rawget(_cls, "__destructor")
                            if func then
                                func(instance)
                            end
                        end
                    end)}
                end

                do --constructor               
                    for i = #clsList, 1, -1 do
                        local _cls = clsList[i]
                        local func = class__rawget(_cls, "__constructor")
                        if func then
                            func(instance)
                        end
                    end                 
                end
            end
            rawset(instance, "__in_constructor", nil)
            
            return instance
        end
        
        if className then
            all_class[className] = classType
        end

        return classType
    end
    _M.Class = _Class
end
------------------------------------------------------------------
local FBaseObject = _M.Class(nil, "FBaseObject", {type=_ABSTRACT})
do
    function FBaseObject:GetClass()
        return self.__classType
    end
    function FBaseObject:GetParentClass()
        return _M.class__tryget(self:GetClass(), "__parent")
    end
    function FBaseObject:GetPointer()
        return self.__pointer
    end
    function FBaseObject:GetClassOptions()
        return self.__classType.__options
    end
    function FBaseObject:toString()
        return tostring(self:GetClass()) ..  "(".. self:GetPointer() .. ")"
    end
    function FBaseObject:tryget(name)
        local v = _M.obj__tryget(self, name)
        return v
    end
    function FBaseObject:tryexec(name, ...)
        local f = self:tryget(name)
        if f then
            assert(type(f) == "function", "field '" .. name .. "' not a valid function")

            return f(self, ...)
        end
    end

    function FBaseObject:is(classType)
        local meta = _M.getClassMeta(classType)
        if not meta then
            return false
        end

        if meta.__options.type == _INTERFACE then
            for _, v in ipairs(self:GetClassOptions().interfaces or {}) do
                if v == classType then
                    return true
                end
            end
        end

        local pcls = self:GetClass()
        while pcls do
            if pcls == classType then
                return true
            else
                pcls = _M.class__tryget(pcls, "__parent")
            end
        end
        return false
    end
    function FBaseObject:as(classType)
        if self:is(classType) then
            return self
        else
            return nil
        end
    end
    function FBaseObject:cast(classType)
        if self:is(classType) then
            return self
        else
            error("bad cast from " .. tostring(self:GetClass()) .. " to " .. tostring(classType), 2)
        end
    end
end

------------------------------------------------------------------
FLua = {}

local function _makeClass(a, b, classOption)
    assert(not not classOption, "arguement #3 classOption must not be null")
    if not a and not b then
        return _M.Class(FBaseObject, nil, classOption)
    elseif a and b then
        local parentClassType, classNameOrForwardCls = a, b
        return _M.Class(parentClassType, classNameOrForwardCls, classOption)
    else
        local param = a or b
        if type(param) == "string" then
            return _M.Class(FBaseObject, param, classOption)
        elseif type(param) == "table" then
            return _M.Class(param, nil, classOption)
        else
            error("invalid param (string or FLua-Object expected, got " .. type(param) .. ")", 2)
        end
    end
end

function FLua.IsClass(classType)
    return nil ~= _M.getClassMeta(classType)
end

function FLua.IsObject(obj)
    return nil ~= _M.getObjMeta(obj)
end

function FLua.IsAbstract(classType)
    local meta = _M.getClassMeta(classType)
    if meta then
        return meta.__options.type == _ABSTRACT
    end
end

function FLua.IsInterface(classType)
    local meta = _M.getClassMeta(classType)
    if meta then
        return meta.__options.type == _INTERFACE
    end
end

function FLua.is(obj, classType)
    if nil == _M.getObjMeta(obj) then
        return false
    end
    return obj:is(classType)
end

function FLua.IsImplement(obj, interfaceType)
    if not FLua.IsObject(obj) then
        return false
    end

    if not FLua.IsClass(interfaceType) then
        return false
    end

    -- direct extend interface
    if FLua.is(obj, interfaceType) then
        return true
    end

    --Implement interface
    local options = obj:GetClassOptions()
    for _, interface_ in ipairs(options.interfaces or {}) do
        if interface_ == interface then
            return true
        end
    end
    return false
end

function FLua.tryget(t, key)
    if FLua.IsObject(t) then
        local v = _M.obj__tryget(t, key)
        return v
    elseif FLua.IsClass(t) then
        return _M.class__tryget(t, key)
    else
        return t[key]
    end
end

function FLua.type(obj)
    if FLua.IsObject(obj) then
        return "object"
    elseif FLua.IsClass(obj) then
        return "class"
    else
        return type(obj)
    end
end

function FLua.Abstract(...)
    assert(select('#', ...) <=2, "arguements is too-more")
    local a, b = ...
    return _makeClass(a, b, {type=_ABSTRACT})
end

function FLua.Interface(...)
    assert(select('#', ...) <=2, "arguements is too-more")
    local a, b = ...
    return _makeClass(a, b, {type=_INTERFACE})
end

function FLua.Class(...)
    assert(select('#', ...) <=2, "arguements is too-more")
    local a, b = ...
    return _makeClass(a, b, {type=_CLASS})
end

function FLua.FinalClass(...)
    assert(select('#', ...) <=2, "arguements is too-more")
    local a, b = ...
    return _makeClass(a, b, {type=_FINAL})
end

function FLua.StaticClass(...)
    assert(select('#', ...) <=2, "arguements is too-more")
    local a, b = ...
    return _makeClass(a, b, {type=_STATIC})
end

function FLua.ForwardClass(className)
    return _M.ForwardDeclare(className)
end


function FLua.Value2String(sth)
    if type(sth) ~= "table" then
        return tostring(sth)
    else
        local mt = getmetatable(sth)
        if mt and mt.__tostring then
            return tostring(sth)
        end
    end
    local function make_key(k)
        if type(k) == "number" then
            return "[" .. tostring(k) .. "]"
        else
            return tostring(k)
        end
    end
    local function make_value(v)
        if type(v) == "string" then
            return "\"" .. v .. "\""
        else
            return tostring(v)
        end
    end

    local sb = {}
    local space, deep = string.rep(' ', 4), 0
    space = "\t" .. space
    local function _dump(t, level)
        local mt = getmetatable(t)
        if mt and mt.__tostring then
            sb[#sb+1] = string.rep(space, level + 1) .. tostring(t)
        else
            for key, v in pairs(t) do
                if type(v) == "table" then
                    sb[#sb+1] = string.format("%s%s = {", string.rep(space, level + 1), make_key(key))
                    _dump(v, level+1)
                    sb[#sb+1] = string.format("%s},", string.rep(space, level + 1))
                else
                    sb[#sb+1] = string.format("%s%s = %s,", string.rep(space, level + 1), make_key(key), make_value(v))
                end
            end
        end
    end

    sb[#sb+1] = "\n\t{"
    _dump(sth, deep)
    sb[#sb+1] = "\t}"
    return table.concat(sb, "\n")
end

function FLua.printValue(...)
    local sb = {}
    for _,v in ipairs({...}) do
        sb[#sb+1] = FLua.Value2String(v)
    end
    print(table.concat(sb, " "))
end




if false then
    local function dotest(cb)
        xpcall(cb, function (err) print(debug.traceback(err)) end)
    end 
    local TBase = FLua.Abstract(nil, "TBase")
    do
        TBase.testStaticValue = 19
        function TBase:__constructor()
            print("TBase:__constructor", self)
            self.baseN = 50
        end
        function TBase:__destructor()
            print("TBase:__destructor", self)
        end
        function TBase:test()
            print("test ", self)
        end
        function TBase:base()
            print("base ", self)
        end
        function TBase:__lt(ths)
            return false
        end
    end

    local TInterface = FLua.Interface(nil, "TInterface")
    do
        function TInterface:interface()
        end
    end

    local TB = FLua.Class(TBase).Implement(TInterface)
    do
        function TB:__constructor()
            print("TB:__constructor", self)
        end
        function TB:__destructor()
            print("TB:__destructor", self)
        end
        function TB:test()
            TBase.test(self)
            print("test 2 ", self)
        end
        function TB:interface()
        end
    end

    --dotest(function()
        print(TB)
        local b = TB()
        print(b)
        ---print(b.tt)
        print("testStaticValue", b.testStaticValue)
        TB.testStaticValue = 21
        print("testStaticValue", b.testStaticValue)
        print(b:tryget('tt'))
        b:test()
        b:base()
        print(b.__pointer)
        print(b.baseN)
        b.baseN = 20
        print(b.baseN)
        print(b.__gcproxy)

        local a = TB()
        print(a)
        print(a < b)
    --end)
end

return FLua