local FObjInfo = FLua.Class("FObjInfo")
do
	function FObjInfo:_ctor()
		self.ID = 0 
		self.Name = ""
	end
end

return FObjInfo