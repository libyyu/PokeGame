require "core.string"
require "core.path"
require "core.table"
require "core.os"


local filter = require "core.filter"

local _g = _g or {}

_g.filter = filter.new()
rawset(_G, "_g", _g)

getmetatable("123").__tostring = function(s)
	return _g.filter:handle(s)
end

function val(s)
	return _g.filter:handle(s)
end