local FDebugOption = FLua.Class("FDebugOption")
local l_instance = nil
do
	function FDebugOption:__constructor()
		self.m_showclick = false
	end

	function FDebugOption.Instance()
		if not l_instance then
			l_instance = FDebugOption()
		end
		return l_instance
	end

	function FDebugOption:ToggleShowClick(show)
		self.m_showclick = show
	end
	function FDebugOption:ShowClick()
		return self.m_showclick
	end
end

return FDebugOption