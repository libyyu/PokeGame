package.path = "../?.lua;../utility/?.lua;" .. package.path

local FLua = require "FObject"
_G.FLua = FLua
_G.warn = print
local FLibEvent = require "FLibEvent"

local Event = FLibEvent.new()

local Cat = FLua.Class("Cat")
do
	function Cat:OnEvent(eventname, ...)
		if eventname == "MOUSE_SPAWNED" then
			print("Cat:OnEvent",...)
		end
	end

	function Cat.OnLog(name,log)
		print("log",log.type,log.str)
	end
end

function PrintWhenMouseSpawns(eventname, mouse)
	print("MOUSE SPAWNED! "..tostring(mouse))
end

Event:AddEvent(Cat, "MOUSE_SPAWNED")
Event:AddEvent(PrintWhenMouseSpawns, "MOUSE_SPAWNED")
Event:AddEvent(Cat.OnLog,"UNITY_LOG")

Event:Fire("MOUSE_SPAWNED","Hello")
Event:Fire("UNITY_LOG",{type=1,str="hhhhhhhhhhhhh"})
