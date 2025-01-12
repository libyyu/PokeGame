
#ifndef LUA_LIB
#define LUA_LIB
#endif

#include "flib/flib.h"
#include "base/LuaEnv.hpp"

_FStdUsing

////////////////////////////////////////////////////
static LuaEnv* g_luaEnv = nullptr;
LuaEnv* glb_GetLuaEnv()
{
    return g_luaEnv;
}

////////////////////////////////////////////////////
//wrapper to unity log
enum LOG_TYPE
{
    LOG_ERROR = 0,
    LOG_ASSERT = 1,
    LOG_WARNING = 2,
    LOG_INFO = 3,
    LOG_EXCEPTION = 4,
};
typedef void (*UnityLogFunc) (int logType, const char* message);
static UnityLogFunc s_UnityLogFn = nullptr;
static void DefaultConsoleOutputImpl(FLIB_LOGLEVEL, const char*message, const FMessageLogContext&)
{
    if(s_UnityLogFn != nullptr) s_UnityLogFn(LOG_TYPE::LOG_INFO, message);
}


_FDeclsBegin

//extern void luaS_openextlibs(lua_State *L);
LUALIB_API void L_CleanupLuaState()
{
    F_CONSOLE(INFO) << "Cleanup luaState.";
    if(g_luaEnv)
    {
        delete g_luaEnv;
    }
	g_luaEnv = nullptr;
}
LUALIB_API void L_SetupLuaState(lua_State* L)
{
	if(g_luaEnv) delete g_luaEnv;
	g_luaEnv = new LuaEnv(L);
    // luaS_openextlibs(L);
    F_CONSOLE(INFO) << "Setup luaState.";
}
LUALIB_API void L_EstablishAnyLog(void* pfunc)
{
    s_UnityLogFn = (UnityLogFunc)pfunc;
    FSetLogConsoleOuputFunc(DefaultConsoleOutputImpl);
	
    // auto lua_print = [](const char* message)
    // {
    //     F_CONSOLE(INFO) << message;
    // };
    // auto lua_warn = [](const char* message)
    // {
    //     F_CONSOLE(WARN) << message;
    // };
    // auto lua_error = [](const char* message)
    // {
    //     F_CONSOLE(ERROR) << message;
    // };
    
    // LuaOutHandler::Get().SetPrintHandler(lua_print, 0);
    // LuaOutHandler::Get().SetPrintHandler(lua_warn, 1);
    // LuaOutHandler::Get().SetPrintHandler(lua_error, 2);
    
    F_CONSOLE(INFO) << "AnyLog Setup!";
}

LUALIB_API void L_UnEstablishAnyLog()
{
	F_CONSOLE(INFO) << "AnyLog Cleanup!";
}

LUALIB_API void L_AddFilePackageLayer(const char* path)
{
    //FileSystem::Get().AddLayer(path);
}
LUALIB_API bool L_ReadFileBuffer(const char* szFile, char** ppbuffer, int* length)
{
    return false;//FileSystem::Get().ReadFileBuffer(szFile, ppbuffer, length);
}
LUALIB_API void L_ReleaseFileBuffer(char* pbuffer)
{
    //FileSystem::Get().ReleaseFileBuffer(pbuffer);
}
LUALIB_API bool L_FileExists(const char* path)
{
    return false;//FileSystem::Get().FileExists(path);
}

_FDeclsEnd
