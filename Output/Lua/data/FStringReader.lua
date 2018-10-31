local string_list = dofile "configs.string_list"

local FStringReader = FLua.Class("FStringReader")

do
	function FStringReader.Get(id)
		return string_list[id] or "<string_list:"..id..">"
	end
end

StringReader = FStringReader