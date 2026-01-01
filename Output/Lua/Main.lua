
require "FPreload"
require "game.FGame"

function main()
	print("Application.platform", UnityEngine.Application.platform)
	_G.coro.start(function()
		--设置环境，全局管理器，Manager，资源加载
		theGame:Setup()
		theGame:Run()
	end)
	
	-- if not IsWebGLRuntime() then
	-- 	_G.coro.start(function()
	-- 		theGame:Setup()

	-- 		local FGameUpdate = require "patches.FGameUpdate"
	-- 		FGameUpdate.Instance():Run()

	-- 		while not FGameUpdate.Instance():IsFinished() do
	-- 			_G.coro.yield()
	-- 		end

	-- 		theGame:Run()
	-- 	end)

	-- 	-- local co = coroutine.create(function ( )
	-- 	-- 	Yield(WaitUntil(function() return FGameUpdate.Instance():IsFinished() end))
	-- 	-- 	MainThreadTask.RunInMainThread(function()
	-- 	-- 		warn("在主线程中运行，开始游戏。")
	-- 	-- 		theGame:Run()
	-- 	-- 	end)
	-- 	-- end)
	-- 	-- coroutine.resume(co)
	-- else
	-- 	_G.coro.start(function()
	-- 		--设置环境，全局管理器，Manager，资源加载
	-- 		theGame:Setup()
	-- 		theGame:Run()
	-- 	end)
	-- end
	
	--[[MainThreadTask.RunUntilFinish(function() return FGameUpdate.Instance():IsFinished() end,function()
		warn("在主线程中运行，开始游戏。")
		theGame:Run()
	end)]]
end


