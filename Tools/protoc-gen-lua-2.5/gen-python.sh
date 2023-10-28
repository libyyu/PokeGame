#!/bin/sh
# 生成protobuf lua

current_path=$(cd `dirname $0`; pwd)
protos_dir="$current_path/protos"

out_dir="$current_path/pb_python"
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

#if [ ! -d "$out_dir/google/protobuf" ]; then
#	mkdir -p "$out_dir/google/protobuf"
#fi
#gen -I=$protos_dir --python_out=$out_dir $protos_dir/google/protobuf/*.proto
gen -I=$protos_dir --python_out=$out_dir $protos_dir/*.proto

if [ -d "$current_path/../../GameServer/protobuf" ]; then
	cp -rf "$out_dir/"* "$current_path/../../GameServer/protobuf/"
fi

exit 0
