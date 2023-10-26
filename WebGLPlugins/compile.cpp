//#if defined(__cplusplus)
    #define _FDeclsBegin   extern "C" {
    #define _FDeclsEnd     }
//#else
//    #define _FDeclsBegin
//    #define _FDeclsEnd
//#endif

// #if defined(__cplusplus)
//     #define  _FCFun   extern "C"
// #else
//     #define  _FCFun   extern
// #endif //__cplusplus

#define LUA_WEBGL 1
#define LUA_COMPAT_5_1
#define LUA_COMPAT_5_2
#define LUA_COMPAT_BITLIB
//base lua
_FDeclsBegin
#include "lua51/lapi.c"
#include "lua51/lauxlib.c"
#include "lua51/lbaselib.c"
#include "lua51/lbitlib.c"
#include "lua51/lcode.c"
#include "lua51/lcorolib.c"
#include "lua51/lctype.c"
#include "lua51/ldblib.c"
#include "lua51/ldebug.c"
#include "lua51/ldo.c"
#include "lua51/ldump.c"
#include "lua51/lfunc.c"
#include "lua51/lgc.c"
#include "lua51/linit.c"
#include "lua51/liolib.c"
#include "lua51/llex.c"
#include "lua51/lmathlib.c"
#include "lua51/lmem.c"
#include "lua51/loadlib.c"
#include "lua51/lobject.c"
#include "lua51/lopcodes.c"
#include "lua51/loslib.c"
#include "lua51/lparser.c"
#include "lua51/lstate.c"
#include "lua51/lstring.c"
#include "lua51/lstrlib.c"
#include "lua51/ltable.c"
#include "lua51/ltablib.c"
#include "lua51/ltm.c"
#include "lua51/lundump.c"
#include "lua51/lutf8lib.c"
#include "lua51/lvm.c"
#include "lua51/lzio.c"
//#include "lua51/i64lib.c"
#include "lua51/perflib.c"
_FDeclsEnd

_FDeclsBegin
#include "i64lib/i64lib.c"
_FDeclsEnd

_FDeclsBegin
#include "lpeg/lpeg.c"
_FDeclsEnd

_FDeclsBegin
#include "pb.c"
#include "slua.c"
_FDeclsEnd

_FDeclsBegin
#include "lua-cjson/fpconv.c"
#include "lua-cjson/lua_cjson.c"
#include "lua-cjson/strbuf.c"
_FDeclsEnd

//_FDeclsBegin
#include "PCH.cpp"
#include "FilePackage/File.cpp"
#include "FilePackage/FileSystem.cpp"
#include "FLuaExport.cpp"
//_FDeclsEnd