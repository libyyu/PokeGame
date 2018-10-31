local l_netId2PbClass = {}
local l_nameToInfo = {}		--name => {type=type, name=name, pb_class=pb_class, id=id}
local l_pbClassToInfo = {}		--pb_class => {type=type, name=name, pb_class=pb_class, id=id}

do
	local function registerNET(type,name,id, pb_class)
		local info = {type=type,name=name,pb_class=pb_class,id=id}
		l_nameToInfo[name] = info
		l_pbClassToInfo[pb_class] = info
		l_netId2PbClass[id] = pb_class
	end

	for MsgName, MsgType in pairs(message_common_pb) do
		if type(MsgType) == "table" and MsgType.GetFieldDescriptor then	--是一个 protocol buffer 消息
			local field = MsgType.GetFieldDescriptor("type")
			if field then
				local theType = field.enum_type
				local MsgID = field.default_value
				registerNET(theType, MsgName, MsgID, MsgType)
			end
		end
	end

	for MsgName, MsgType in pairs(message_client_pb) do
		if type(MsgType) == "table" and MsgType.GetFieldDescriptor then	--是一个 protocol buffer 消息
			local field = MsgType.GetFieldDescriptor("type")
			if field then
				local theType = field.enum_type
				local MsgID = field.default_value
				registerNET(theType,MsgName, MsgID, MsgType)
			end
		end
	end

	for MsgName, MsgType in pairs(message_server_pb) do
		if type(MsgType) == "table" and MsgType.GetFieldDescriptor then	--是一个 protocol buffer 消息
			local field = MsgType.GetFieldDescriptor("type")
			if field then
				local theType = field.enum_type
				local MsgID = field.default_value
				registerNET(theType,MsgName, MsgID, MsgType)
			end
		end
	end
end

local FPBHelper = FLua.Class("FPBHelper")
do
	function FPBHelper.GetPbClass(name)
		if type(name) == "string" then
			local info = l_nameToInfo[name]
			if info then
				return info.pb_class
			else
				return nil
			end
		else
			return l_netId2PbClass[name]
		end
	end
	function FPBHelper.NewPbMsg(name)
		local info = l_nameToInfo[name]
		if info then
			return info.pb_class()
		else
			return nil
		end
	end
	function FPBHelper.GetPbId(pb_class)
		local info = l_pbClassToInfo[pb_class]
		if info then
			return info.id
		else
			return nil
		end
	end
	function FPBHelper.GetPbName(pb_class_or_id)
		local pb_class
		if type(pb_class_or_id) == "number" then
			pb_class = FPBHelper.GetPbClass(pb_class_or_id)
			if not pb_class then return nil end		
		else
			pb_class = pb_class_or_id
		end
		local info = l_pbClassToInfo[pb_class]
		if info then
			return info.name
		else
			return nil
		end
	end	
end

return FPBHelper

