local FTask = FLua.Class("FTask")
do
	function FTask._ctor( )
		self.m_action = function(...) end
		self.m_cancelCallback = function(...) end
		self.finishTask = function(...) end
		self.m_status = "created"
		self.m_canceled = nil
		self.m_parent = nil
		self.m_result = nil
		self.m_waitingChildCount = nil
		self.m_nextResumeEntry = nil
		self.m_cancelNotifyList = nil
	end

	function FTask.create(action)
		return FTask.createEx(action,nil)
	end
	function FTask.createEx(action,cancelCallback)
		local obj = FTask.new()
		obj.m_action = action
		obj.m_cancelCallback = cancelCallback
		return obj
	end
	function FTask.createCo(actionCo)
		return FTask.createCoEx(actionCo,nil)
	end
	function FTask.createCoEx(actionCo,cancelCallback)
		return FTask.createEx(FTask.wrapCoroutine(actionCo), cancelCallback)
	end
	function FTask.createSteps(action)
		return FTask.createStepsEx(action,nil)
	end
	function FTask.createStepsEx(action,cancelCallback)
		local step = 0
		local function actionFunc (task, ...)
			step = step + 1
			return action(task, step, ...)
		end
		return FTask.createEx(actionFunc, cancelCallback)
	end
	function FTask.createOneStep(action)
		return FTask.createOneStepEx(action,nil)
	end
	function FTask.createOneStepEx(action,cancelCallback)
		local firstStep = true
		local function actionFunc (task, result)
			if firstStep then
				firstStep = false
				return action(task)
			else
				return "end", result
			end
		end
		return FTask.createEx(actionFunc, cancelCallback)
	end

	function FTask:start()
		if self.m_status ~= "created" then
			error("can not start a task which is already started")
		end
		
		-- make a new closure each time when need a entry, to avoid entering for multiple times
		local function makeResumEntry ()
			local firstTime = true
			local function resumeEntry (...)
				if not firstTime then
					return
				end
				firstTime = false
				
				if self.m_canceled then
					self:finishTask(nil)
					return
				end
				
				-- execute a step
				local asyncOp, result = self.m_action(self, ...)
				while asyncOp == "continue" do
					if self.m_canceled then
						self:finishTask(nil)
						return
					end
					asyncOp, result = self.m_action(self, ...)
				end
				
				if self.m_canceled then
					self:finishTask(nil)
					return
				end
				
				if asyncOp == "end" then
					self:finishTask(result)
				elseif type(asyncOp) == "function" then
					asyncOp(self, makeResumEntry())
				else
					error(([[bad return value from action, should be "end" or async operation, got %s (%s)]]):
						format(tostring(asyncOp), type(asyncOp)))
				end
			end
			return resumeEntry
		end
		
		self.m_status = "running"
		makeResumEntry()()
	end

	function FTask:startAsChild(parent)
		if self.m_parent then
			error("can not start a child task which is already started")
		end
		self.m_parent = parent
		parent:incWaitingChildCount()
		parent:appendCancelNotify(self)
		
		self:start()
	end
	function FTask:startAsChildEx(parent,cancelWithParent)
		if self.m_parent then
			error("can not start a child task which is already started")
		end
		self.m_parent = parent
		parent:incWaitingChildCount()
		
		if cancelWithParent then
			parent:appendCancelNotify(self)
		end
		
		self:start()
	end

	function FTask:executeSub(sub)
		local function subResumeFunction (task, resumeEntry)
			self:appendCancelNotify(sub)
			sub.m_nextResumeEntry = resumeEntry
			sub:start()
		end
		return subResumeFunction
	end
	function FTask:completeSub(sub)
		local function subResumeFunction (task, resumeEntry)
			self:appendCancelNotify(sub)
			sub.m_nextResumeEntry = function ()
				if sub:isCanceled() then
					task:cancel()
				end
				resumeEntry()
			end
			sub:start()
		end
		return subResumeFunction
	end
	function FTask:continueWith(continuationFunction)
		if self.m_status == "canceled" or self.m_status == "completed" then
			continuationFunction(self)
		else
			self:appendContinuation(continuationFunction)
		end
		return self
	end
	function FTask:completeWith(continuationFunction)
		self:continueWith(function (task)
			if not task.m_canceled then
				continuationFunction(task)
			end
		end)
		return self
	end
	function FTask:cancelWith(continuationFunction)
		self:continueWith(function (task)
			if task.m_canceled then
				continuationFunction(task)
			end
		end)
		return self
	end
	function FTask:getResult()
		return self.m_result
	end
	function FTask:cancel()
		if self.m_canceled or self.m_status == "completed" then
			return
		end
		
		self.m_canceled = true
		
		local notifyList = self.m_cancelNotifyList
		if notifyList then
			for i = #notifyList, 1, -1 do
				notifyList[i]:cancel()
			end
		end
		local cancelCallback = self.m_cancelCallback
		if cancelCallback then
			local ret = cancelCallback(self)
			if ret == "stop" then
				self:finishTask(nil)
			end
		end
	end
	function FTask:isActive()
		return self.m_status == "running" and not self.m_canceled
	end
	function FTask:isCanceled()
		return not not self.m_canceled
	end
	function FTask:isCompleted()
		return self.m_status == "completed"
	end
	function FTask:getStatus()
		return self.m_status
	end
	function FTask.wrapCoroutine(f)
		local coroutine = require "coroutine"

		local co = coroutine.create(f)
		local coresume = coroutine.resume
		local costatus = coroutine.status
				
		local function wrapper (task, ...)
			if costatus(co) ~= "dead" then
				local succ, ret1, ret2 = coresume(co, task, ...)
				if succ then
					return ret1, ret2
				else
					local err = ret1
					local info = debug.getinfo(f, "nS")
					error(("wrapped coroutine function has error: %s")
						:format(tostring(err)))
					
				end
			else
				local info = debug.getinfo(f, "S")
				error(("wrapped coroutine exit without either finish or cancel: %s:%d")
					:format(info.source, info.linedefined))
			end
		end
		return wrapper
	end
	--privite
	function FTask:appendCancelNotify(task)
		local cancelNotifyList = self.m_cancelNotifyList
		if cancelNotifyList == nil then
			cancelNotifyList = {}
			self.m_cancelNotifyList = cancelNotifyList
		end
		cancelNotifyList[#cancelNotifyList+1] = task
	end
	function FTask:finishTask(result)
		if self.m_status ~= "running" then
			return
		end
		
		self.m_result = result
		
		-- wait for children
		if not self.m_waitingChildCount then
			self:completeTask()
		else
			self.m_status = "waiting_for_children"
		end
	end
	function FTask:completeTask()
		if self.m_canceled then
			self.m_status = "canceled"
		else
			self.m_status = "completed"
		end
		
		-- execute continuations
		local continuations = self.m_continuations
		if continuations == nil then
		elseif type(continuations) == "function" then	--single function
			continuations(self)
		else	--function array
			for i = 1, #continuations do
				continuations[i](self)
			end
		end
		
		--notify parent
		local parent = self.m_parent
		if parent then
			parent:onChildComplete(self)
		end
		
		-- enter next resumeEntry (sub Task)
		local nextResumeEntry = self.m_nextResumeEntry
		if nextResumeEntry then
			nextResumeEntry()
		end
	end
	function FTask:onChildComplete(child)
		if self:decWaitingChildCount() then
			self:completeTask()
		end
	end
	function FTask:appendContinuation(f)
		local current = self.m_continuations
		if current == nil then
			self.m_continuations = f
		elseif type(current) == "function" then
			self.m_continuations = { current, f }
		else
			current[#current+1] = f
		end
	end
	function FTask:incWaitingChildCount()
		local waitingChildCount = self.m_waitingChildCount
		if waitingChildCount then
			self.m_waitingChildCount = waitingChildCount + 1
		else
			self.m_waitingChildCount = 1
		end
	end
	-- return: true means get to zero
	function FTask:decWaitingChildCount()
		local waitingChildCount = self.m_waitingChildCount
		if waitingChildCount == 1 then
			self.m_waitingChildCount = nil
			return true
		else
			self.m_waitingChildCount = waitingChildCount - 1
			return false
		end
	end
end

return FTask