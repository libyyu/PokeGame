#define LUA_COMPAT_5_1
#define LUA_COMPAT_5_2
#define LUA_USE_MKSTEMP 1

// // Lua source code only, relative .
// #include "lapi.c"
// #include "lauxlib.c"
// #include "lbaselib.c"

// // Add all lua source file *.c, exclude lua.c, luac.c.//#include "$(LuaSrcRelativePath)/src/lua.c"//#include "$(LuaSrcRelativePath)/src/luac.c"
// #include "slua.c"

// #include "auxiliar.c"
// #include "buffer.c"
// #include "compat.c"
// #include "except.c"
// // #include "inet.c"
// #include "io.c"
// #include "lcode.c"
// #include "ldblib.c"
// #include "ldebug.c"
// #include "ldo.c"
// #include "ldump.c"
// #include "lfunc.c"
// #include "lgc.c"
// #include "linit.c"
// #include "liolib.c"
// #include "llex.c"
// #include "lmathlib.c"
// #include "lmem.c"
// #include "loadlib.c"
// #include "lobject.c"
// #include "lopcodes.c"
// #include "loslib.c"
// #include "lpack.c"
// #include "lparser.c"
// #include "lstate.c"
// #include "lstring.c"
// #include "lstrlib.c"
// #include "ltable.c"
// #include "ltablib.c"
// #include "ltm.c"
// // #include "luasocket.c"
// #include "lundump.c"
// #include "lvm.c"
// #include "lzio.c"
// #include "options.c"
// #include "print.c"
// #include "select.c"
// #include "tcp.c"
// #include "timeout.c"
// #include "udp.c"
// // #include "usocket.c"


#include "lua/lua51/src/lapi.c"
#include "lua/lua51/src/lauxlib.c"
#include "lua/lua51/src/lbaselib.c"
#include "lua/lua51/src/lbit.c"
#include "lua/lua51/src/lcode.c"
#include "lua/lua51/src/ldblib.c"
#include "lua/lua51/src/ldebug.c"
#include "lua/lua51/src/ldo.c"
#include "lua/lua51/src/ldump.c"
#include "lua/lua51/src/lfunc.c"
#include "lua/lua51/src/lgc.c"
#include "lua/lua51/src/linit.c"
#include "lua/lua51/src/liolib.c"
#include "lua/lua51/src/llex.c"
#include "lua/lua51/src/lmathlib.c"
#include "lua/lua51/src/lmem.c"
#include "lua/lua51/src/lobject.c"
#include "lua/lua51/src/lopcodes.c"
#include "lua/lua51/src/loslib.c"
#include "lua/lua51/src/lparser.c"
#include "lua/lua51/src/lstate.c"
#include "lua/lua51/src/lstring.c"
#include "lua/lua51/src/lstrlib.c"
#include "lua/lua51/src/ltable.c"
#include "lua/lua51/src/ltablib.c"
#include "lua/lua51/src/ltm.c"
#include "lua/lua51/src/lundump.c"
#include "lua/lua51/src/lvm.c"
#include "lua/lua51/src/lzio.c"
#include "lua/lua51/src/lpack.c"
#include "lua/lua51/src/loadlib.c"
// #include "luasocket.c"
// #include "i64lib.c"
//#include "memory_leak_checker.c"
// #include "pb.c"
// #include "lua_cjson.c"
// #include "fpconv.c"
// #include "strbuf.c"
// #include "xlua.c"