
#define LUA_LIB
#define FLIB_DLL
#include "PCH.h"
#include "FilePackage/FileSystem.h"
using namespace FengEngine;

#define FLIB_DLL_API LUALIB_API

class FLog : public AnyLog::ILog
{
private:
    PLogFunc _log_message;
public:
    FLog() : _log_message(NULL) {}
    void SetLogCall(PLogFunc pFunc)
    {
        assert(pFunc && "AnyLog::PLogFunc must not be null.");
        _log_message = pFunc;
    }
    static AnyLog::PLOG CreateILog(void* pfunc)
    {
        FLog* pLog = new FLog();
        pLog->SetLogCall((PLogFunc)pfunc);
        return pLog;
    }
    static void DestroyILog(AnyLog::PLOG pLog)
    {
        FLog* plog = static_cast<FLog*>(pLog);
        if(NULL != plog)
        {
            delete plog;
            pLog = NULL;
        }
    }
protected:
    void LogImpl(LOG_TYPE logType, const char* message)
    {
        if (_log_message != NULL)
        {
            _log_message((int)logType, message);
        }
    }
};

extern void glb_SetLuaEnv(LuaEnv*);
extern void glb_SetAnyLog(AnyLog::ILog*);

static void CleanupAnyLog()
{
    AnyLog::ILog* theLogger = glb_GetAnyLog();
    FLog::DestroyILog(theLogger);
    glb_SetAnyLog(NULL);
}

extern "C" {

//extern void luaS_openextlibs(lua_State *L);
LUALIB_API void L_CleanupLuaState()
{
	log_info("Cleanup luaState.");
	glb_SetLuaEnv( NULL );
}
LUALIB_API void L_SetupLuaState(lua_State* L)
{
	LuaEnv* env = glb_GetLuaEnv();
	SAFE_DELETE(env);
	env = new LuaEnv(L);
   // luaS_openextlibs(L);
	glb_SetLuaEnv(env);
	log_info("Setup luaState.");
}
LUALIB_API void L_EstablishAnyLog(void* pfunc)
{
    CleanupAnyLog();
	glb_SetAnyLog(FLog::CreateILog(pfunc));
	
    auto lua_print = [](const char* message)
    {
        log_info(message);
    };
    auto lua_warn = [](const char* message)
    {
        log_warning(message);
    };
    auto lua_error = [](const char* message)
    {
        log_error(message);
    };
    
    LuaOutHandler::Get().SetPrintHandler(lua_print, 0);
    LuaOutHandler::Get().SetPrintHandler(lua_warn, 1);
    LuaOutHandler::Get().SetPrintHandler(lua_error, 2);
    
    log_info("AnyLog Setup!");
}

LUALIB_API void L_UnEstablishAnyLog()
{
	log_info("AnyLog Cleanup!");
	CleanupAnyLog();
}

LUALIB_API void L_AddFilePackageLayer(const char* path)
{
    FileSystem::Get().AddLayer(path);
}
LUALIB_API bool L_ReadFileBuffer(const char* szFile, char** ppbuffer, int* length)
{
    return FileSystem::Get().ReadFileBuffer(szFile, ppbuffer, length);
}
LUALIB_API void L_ReleaseFileBuffer(char* pbuffer)
{
    FileSystem::Get().ReleaseFileBuffer(pbuffer);
}
LUALIB_API bool L_FileExists(const char* path)
{
    return FileSystem::Get().FileExists(path);
}

}
