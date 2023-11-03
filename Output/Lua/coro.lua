--if _G.MarkNotReloadAfterUpdate then _G.MarkNotReloadAfterUpdate() end

_G.coro = {}
local coroTable = {}
local coroToRun = {}
local stopTag = "stop"
local quitTag

local function newCoro()
	local c
	c = coroutine.create(function()
		while true do
			local func = rawget(coroToRun, c)
			if func then 
				func()
			end
			coroutine.yield(stopTag)
		end
	end)
	return c
end

function _G.coro.start(func)
	if quitTag then
		return
	end
	for _, c in ipairs(coroTable) do
		if rawget(coroToRun, c) == nil then
			rawset(coroToRun, c, func)
			return
		end
	end
	
	local c = newCoro()
	table.insert(coroTable, c)
	rawset(coroToRun, c, func)
end

function _G.coro.yield()
	return coroutine.yield()
end

function _G.coro.wait(milliseconds)
	local startTime = os.GetTickCount()
	while os.GetTickCount() - startTime < milliseconds do
		coroutine.yield()
	end
end

function _G.coro.async_complete_task(task_func)
	local is_complete = false
	local function OnFinish()
		is_complete = true
	end
	task_func(OnFinish)
	while not is_complete do
		coroutine.yield()
	end
end

function _G.coro.async_load(path)
	local result
	coro.async_complete_task(function (OnFinish)
		
	end)
	return result
end

function _G.coro.clear()
	coroTable = {}
end

function _G.coro.quit()
	quitTag = true
	coroTable = {}
end

--local promises = require('promises')

function _G.TickCoroutine(DeltaTime)
	if quitTag then
		return
	end
	
	for c, func in pairs(coroToRun) do
		if c and func then
			local ret1, ret2 = coroutine.resume(c)
			if (not ret1) or (ret2 == stopTag) then
				rawset(coroToRun, c, nil)
				if not ret1 then
					printerror(debug.traceback(c, ret2, 0))
				end
			end
		end
	end

	--promises.run('nowait')
end
