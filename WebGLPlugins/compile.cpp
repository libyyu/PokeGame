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

//base lua
_FDeclsBegin
#include "lua51/lua.dll.c"
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
#include "AnyLog/ILog.cpp"
#include "FilePackage/File.cpp"
#include "FilePackage/FileSystem.cpp"
#include "FLuaExport.cpp"
//_FDeclsEnd