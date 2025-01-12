
#ifndef LUA_LIB
#define LUA_LIB
#endif

#include "flib/flib.h"
#include <lua.hpp>
#define MODULE_NAME "FengEngine"
#define MODULE_VERSION "1.0.1"

#if FLIB_COMPILER_WINDOWS

#include <Windows.h>

BOOL APIENTRY DllMain(HMODULE hModule,
	DWORD  ul_reason_for_call,
	LPVOID lpReserved
	)
{
	switch (ul_reason_for_call)
	{
	case DLL_PROCESS_ATTACH:
	case DLL_THREAD_ATTACH:
	case DLL_THREAD_DETACH:
	case DLL_PROCESS_DETACH:
		break;
	}
	return TRUE;
}

_FDeclsBegin
LUALIB_API void L_SetupLuaState(lua_State *L);
LUALIB_API void luaS_openextlibs(lua_State *L);

LUALIB_API int luaopen_FengEngine(lua_State* L)
{
    int nTop = lua_gettop(L);
    F_CONSOLE(INFO) << "open slua, top " << nTop;
    {
        L_SetupLuaState(L);
        //luaS_openextlibs(L);
    }
    lua_settop(L, nTop);
    F_CONSOLE(INFO) << "open slua, top " << nTop;
    lua_newtable(L);
    //make version string available to scripts
    lua_pushstring(L, "_VERSION");
    lua_pushstring(L, MODULE_VERSION);
    lua_settable(L, -3);
    F_CONSOLE(INFO) << "version, top " << nTop;
    _FStdUsing
    F_CONSOLE(INFO) << FFormat("Setup luaState for module %s, version %s.", MODULE_NAME, MODULE_VERSION);
    
    return 1;
}
_FDeclsEnd


#endif
