
#define LUA_LIB

#include "PCH.h"

#if FLIB_COMPILER_MSVC || FLIB_COMPILER_CYGWIN

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

int luaopen_FengEngine(lua_State* L)
{
    int nTop = lua_gettop(L);
    {
        LuaEnv* env = glb_GetLuaEnv();
        SAFE_DELETE(env);
        env = new LuaEnv(L);
        luaS_openextlibs(L);
        glb_SetLuaEnv(env);
    }
    lua_settop(L, nTop);
    
    lua_newtable(L);
    //make version string available to scripts
    lua_pushstring(L, "_VERSION");
    lua_pushstring(L, MODULE_VERSION);
    lua_settable(L, -3);
    
    log_info("Setup luaState for module %s, version %s.", MODULE_NAME, MODULE_VERSION);
    
    return 1;
}



#endif
