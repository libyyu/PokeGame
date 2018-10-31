--[[

]]
local getmetatable = getmetatable
local setmetatable = setmetatable
local print = print
local error = error
local warn = print

local class_map = {}
--[[
	检查类是否定义
]]
local function isClassRegistered(classname)
	return not not class_map[classname]
end
local function defaultClassName()
	local start = 1
	local toFind = "Anonymous#" .. start
	for _,v in pairs(class_map) do
		if isClassRegistered(toFind) then
			start = start + 1
			toFind = "Anonymous#" .. start
		else
			return toFind
		end
	end
	return "Anonymous#" .. start
end
local function registerClassName(classname, class)
	class_map[classname] = class
end
--[[
	克隆
]]
local function clone(object)
    local lookup_table = {}
    local function _copy(object)
        if type(object) ~= "table" then
            return object
        elseif lookup_table[object] then
            return lookup_table[object]
        end
        local new_table = {}
        lookup_table[object] = new_table
        for key, value in pairs(object) do
            new_table[_copy(key)] = _copy(value)
        end
        return setmetatable(new_table, getmetatable(object))
    end
    return _copy(object)
end

--[[
	定义一个类
]]
local function class(parentclass, classname)
	if(type(classname) ~= "string") then
		error(" Class: \""..tostring(classname).."\" 无效!!", 1)
	end
	if isClassRegistered(classname) then
		error(" Class: \""..tostring(classname).."\" 重复定义!!", 1)
	end
    local superType = type(parentclass)
    local cls

    if parentclass and superType ~= "function" and superType ~= "table" then
        superType = nil
        parentclass = nil
        error("parentclass:" .. parentclass .. " is not valid")
    end

    if superType == "function" or (parentclass and parentclass.__ctype == 1) then
        -- inherited from native C++ Object
        cls = {}
        if superType == "table" then
            -- copy fields from super
            for k,v in pairs(parentclass) do cls[k] = v end
            cls.__create = parentclass.__create
            cls.__parent = parentclass
        else
            cls.__create = parentclass
        end

        cls.__ctor    = function() end
        cls.__cname = classname
        cls.__ctype = 1

        function cls.New(...)
            local instance = cls.__create(...)
            -- copy fields from class to native object
            for k,v in pairs(cls) do instance[k] = v end
            local objName = "\"" .. classname .. "(".. tostring(instance) .. ")\""
			cls.__tostring = function(_)
				return objName
			end
            instance.__class = cls
            instance:__ctor(...)
            return instance
        end
    else
        -- inherited from Lua Object
        if parentclass then
            cls = {}
            cls.__parent = parentclass
        else
            cls = {__ctor = function() end, _ctor = function() end}
        end


        --查找类链
        local clsList = {}
		do
			local pcls = cls
			while pcls ~= nil do
				table.insert(clsList, pcls)
				pcls = pcls.__parent
			end
		end
		local __fields, __attributes = {}, {}

        cls.__curfunc = nil
        cls.__curcls = nil
        cls.__cname = classname
        cls.__ctype = 2 -- lua
        cls.__attributes = __attributes
        cls.__fields = __fields
        cls.__tryget = function(t, k, check)
        	local function get(m, k, check)
        		local v = rawget(m, k)
	        	if v then
	        		if type(v) == "function" then
	        			if k ~= "super" then
	        				rawset(t, "__curfunc", k)
	        			end
	        		end
	        		return v
	        	end

				local attr = m.__attributes[k]
				if m.__fields[k] then
					if type(v) == "function" then
	        			if k ~= "super" then
	        				rawset(t, "__curfunc", k)
	        			end
	        		end
					return attr
				end

				local pcls = m.__parent
				while pcls ~= nil do
					v = get(pcls, k, check)
					if v ~= nil then
						if type(v) == "function" then
		        			if k ~= "super" then
		        				rawset(t, "__curfunc", k)
		        			end
		        		end

						return v
					end

					pcls = pcls.__parent
				end

				if check and not m.__fields[k] then
					error("attribute \""..k.."\" not found in ".. tostring(t), 2)
				end

				return nil
        	end

        	return get(getmetatable(t), k, check)
    	end
        cls.__index = function(t, k)
        	return cls.__tryget(t, k, true)
       	end

       	cls.__newindex = function(t, k, v)
       		if k == "__cname" or
       			k == "__ctype" or
       			k == "__ctor" or k == "_ctor" or
       			k == "__attributes" or
       			k == "__fields" or
       			k == "__curfunc" or
       			k == "__curcls" or
       			k == "__tryget" or
       			k == "__class" then
       			error(k .. " 是只读属性. ".. tostring(cls) .." !!")
       		end
       		local m = getmetatable(t)

       		local curfunc = t.__curfunc
       		if curfunc ~= "__ctor" and curfunc ~= "_ctor" then
	       		if not m.__fields[k] then
	       			error("不能为".. tostring(m) .."的实例动态添加属性 \""..k.."\" !!")
	       		end
	       	end
       		--改变的值不是一个方法. 就添加到属性列表中
			m.__attributes[k] = v
			m.__fields[k] = true
       	end

       	cls.super = function(t, ...)
       		local curfunc = rawget(t, "__curfunc")
       		if not curfunc then
       			error("super only called in inner function")
       		end

       		local bFind = false
       		local m = getmetatable(t)
 			local curcls = rawget(t, "__curcls")
			local pcls = m.__parent
			local bFind = false
			while pcls do
				if curcls.__parent == pcls then
					bFind = true
				end
				if bFind then
					local func = pcls[curfunc]
					if func and type(func) == "function" then
						rawset(t, "__curcls", pcls)
						func(t, ...)
						rawset(t, "__curcls", nil)
						return
					end
				end

				pcls = pcls.__parent
			end

       		error(tostring(curcls) .. " has no base function \"" .. curfunc .. "\"")
        end

        function cls.New(...)
            local instance = {__curfunc=nil, __curcls=cls, __class = cls}
            local objName = "\"" .. classname .. "(".. tostring(instance) .. ")\""
            setmetatable(instance, cls)

            local __tostring = cls.__tryget(instance, "__tostring", false)
			cls.__tostring = function(t)
				return __tostring and __tostring(t) or objName
			end

			do
				local lt = cls.__tryget(instance, "__lt", false)
				if lt then
					cls.__lt = lt
				end
				local le = cls.__tryget(instance, "__le", false)
				if le then
					cls.__le = le
				end
				local eq = cls.__tryget(instance, "__eq", false)
				if eq then
					cls.__eq = eq
				end
				local add = cls.__tryget(instance, "__add", false)
				if add then
					cls.__add = add
				end
				local sub = cls.__tryget(instance, "__sub", false)
				if sub then
					cls.__sub = sub
				end
				local mul = cls.__tryget(instance, "__mul", false)
				if mul then
					cls.__mul = mul
				end
				local div = cls.__tryget(instance, "__div", false)
				if div then
					cls.__div = div
				end
			end
			local function ctor(o, c, ...)
				local __ctor = rawget(c, "__ctor")
				local _ctor = rawget(c, "_ctor")
				if __ctor then
					rawset(o, "__curfunc", "__ctor")
					__ctor(o, ...)
				elseif _ctor then
					rawset(o, "__curfunc", "_ctor")
					_ctor(o, ...)
				end
			end
			do
				for i = #clsList, 1, -1 do
					local _cls = clsList[i]
					if _cls ~= cls then
						ctor(instance, _cls, ...)
					end
				end
			end
			ctor(instance, cls, ...)
            return instance
        end
        cls.new = cls.New
    end

    local typeMeta = {
    	__cname = classname,
    	__class = cls,
	}

    local typeName = "\"Class#" .. classname .. "(".. tostring(cls) .. ")\""
    typeMeta.__tostring = function(_)
    	return typeName
	end
	typeMeta.__index = function(c, k)
		if k == "__parent" then
			return rawget(c, "__parent")
		end
    	local pcls = c
		while pcls ~= nil do
			v = rawget(pcls, k)
			if v ~= nil then
				return v
			end

			pcls = pcls.__parent
		end
		return nil
	end
	setmetatable(cls, typeMeta)
	--reg
	registerClassName(classname, cls)

    return cls
end

local FBaseObject = class(nil, "FBaseObject")
do
	function FBaseObject:GetTypeTable()
		return self.__class
	end
	function FBaseObject:GetParentTypeTable()
		return self.__class.__parent
	end
	function FBaseObject:tryget(name)
		return self:GetTypeTable().__tryget(self, name, false)
	end
end

FLua = {}

function FLua.Class(a, b)
	local classname, parentclass = nil, nil
	if not b then
		if not a then
			classname = defaultClassName()
			parentclass = FBaseObject
		elseif type(a) == "string" then
			classname = a
			parentclass = FBaseObject
		elseif type(a) == "table" then
			local mt = getmetatable(a)
			if rawget(mt, "__cname") then
				classname = defaultClassName()
				parentclass = a
			else
				error("arguement #1 must be (string, table, nil),but got "..type(a))
			end
		end
	else
		if type(a) ~= "string" then
			error("arguement #1 must be string,but got "..type(a))
		end
		if type(b) ~= "table" then
			error("arguement #2 must be table,but got "..type(b))
		end
		local mt = getmetatable(b)
		if not rawget(mt, "__cname") then
			error("arguement #2 must be FBaseObject,but got "..type(b))
		end
		classname = a
		parentclass = b
	end

	return class(parentclass, classname)
end

function FLua.IsClass( cls )
	assert(type(cls) == "table")
	return getmetatable(cls).__class == cls
end

return FLua




