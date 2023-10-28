#!/bin/sh
# 生成protobuf lua

current_path=$(cd `dirname $0`; pwd)
protos_dir="$current_path/protos"
plugin=
if [ "$OS" = "Windows_NT" ]; then
	plugin="$current_path/plugin/gen-lua.exe"
else
	plugin="$current_path/plugin/gen-lua"
fi

out_dir="$current_path/pb_lua"
if [ ! -d "$out_dir" ]; then
	mkdir -p "$out_dir"
fi

#是否存在命令
find_command()
{
	which $1 > /dev/null 2>&1
	if [ $? == 0 ]; then
	    echo true
	else
	    echo false
	fi
}

gen()
{

	#是否存在系统命令
	which protoc > /dev/null 2>&1
	if [ $? == 0 ]; then
	    protoc ${1+"$@"} || { echo>&2 "生成protoc python失败"; exit 1; }
	else
	    "$current_path/protoc.exe" ${1+"$@"} || { echo>&2 "生成protoc python失败"; exit 1; }
	fi
}



#gen $protos_dir/google/protobuf/*.proto --lua_out="$out_dir" --plugin=protoc-gen-lua="$plugin" --proto_path="$protos_dir"
gen $protos_dir/*.proto --lua_out="$out_dir" --plugin=protoc-gen-lua="$plugin" --proto_path="$protos_dir"

if [ -d "$current_path/../../Output/Lua/pb" ]; then
	cp -rf "$out_dir/"* "$current_path/../../Output/Lua/pb"
fi

exit 0