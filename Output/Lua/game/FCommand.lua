local l_commands = {}

local l_configs = {}
do
	function l_configs:getAllCommands()
		return l_commands
	end

	function l_configs:addcmd(id)
		return function(config)
			if not l_commands[id] then
				config.name = id
				l_commands[id] = config
			else
				error("command:"..id.." is already define",2)
			end
		end
	end
end

l_configs:addcmd("print")
{
	usage = "print hello",
	description = "function print",
	execute = function(args)
		if #args ==0 then
			local usage = [[<b>command:print</b>
	<b>description:</b>function print
	<b>usage:</b>print hello]]
		    print(usage)
		else
			print(table.concat( args, ", "))
		end
	end
}

l_configs:addcmd("warn")
{
	usage = "warn hello",
	description = "function warn",
	execute = function(args)
	end
}

l_configs:addcmd("lua")
{
	usage = "lua print('hello')",
	description = "loadstring",
	execute = function(args)
		if #args == 0 then
			local usage = [[<b>command:lua</b>
<b>description:</b>function loadstring
<b>usage:</b>lua print('hello ')]]
		    print(usage)
		else
			local script = table.concat( args, " ")
			local f, err = loadstring(script)
			if f == nil then
				warn(err)
			else
				f()
			end
		end
	end
}

l_configs:addcmd("ping")
{
	usage = "ping www.baidu.com",
	description = "function ping",
	execute = function(args)
		if #args ==0 then
			local usage = [[<b>command:ping</b>
	<b>description:</b>function ping
	<b>usage:</b>ping www.baidu.com]]
		    print(usage)
		else
			theGame.m_Network:Ping(args[1])
		end
	end
}

l_configs:addcmd("showclick")
{
	usage = "showclick 1",
	description = "show gameObject which is clicked",
	execute = function(args)
		if #args ==0 then
			local usage = [[<b>command:showclick</b>
	<b>description:</b>show gameObject which is clicked
	<b>usage:</b>showclick 1]]
		    print(usage)
		else
			local FDebugOption = require "game.FDebugOption"
			FDebugOption.Instance():ToggleShowClick(tonumber(args[1]) == 1)
		end
	end
}
l_configs:addcmd("fps")
{
	usage = "fps 1",
	description = "show fps",
	execute = function(args)
		if #args ==0 then
			local usage = [[<b>command:fps</b>
	<b>description:</b>show fps
	<b>usage:</b>fps 1]]
		    print(usage)
		else
			theGame:ShowFPS(tonumber(args[1]) == 1)
		end
	end
}


l_configs:addcmd("quit")
{
	execute = function(args)
		local content = StringReader.Get(4)
		MsgBox(self,content,nil,MsgBoxType.MBBT_OKCANCEL,function(_,ret)
			if ret == MsgBoxRetT.MBRT_OK then
				Application.Quit()
			end
		end)
	end
}

l_configs:addcmd("restart")
{
	execute = function(args)
		GameUtil.ReStart(function()
			warn("Restart...")
		end)
	end
}
return l_configs