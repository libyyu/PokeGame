import "UnityEngine"
GameObject = UnityEngine.GameObject

local c=coroutine.create(function()

	print "coroutine start"

	Yield(WaitForSeconds(2))
	print "coroutine WaitForSeconds 2"

	local www = WWW("https://www.baidu.com")
	Yield(www)
	print(LuaHelper.ToString(www.bytes))

	print("Yield ok")
end)
coroutine.resume(c)

function OnConnect(s)
	warn("OKKKKKKKKKKKKKKKK",s)
end

function OnReceiveMessage(id,buffer)
	warn("RRRRRRRRR",id,buffer)
end

function main()
	warn("main")
	warn('timeid = ' .. LuaTimer.Add(0,function(t)
		warn("inner",t)
	end))
	LuaTimer.Add(0,function(t)
		warn("inner2",t)
	end)
	warn(LuaTimer.Add(1,1,function(t,b)
		warn("inner3",t,b)
		return false
	end))

	local bit = require "bit"
	warn("bit",bit)

	local pb = require "pb"
	warn("pb",pb)
end


