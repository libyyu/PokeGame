local FObjInfo = FLua.Class("FObjInfo")
do
	function FObjInfo:__constructor()
		self.ID = 0 
		self.Name = ""
	end
end

return FObjInfo