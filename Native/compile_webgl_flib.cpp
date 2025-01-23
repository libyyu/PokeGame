#define _FDeclsCBegin   extern "C" {
#define _FDeclsCEnd     }

#define LUA_WEBGL 1
#define PLATFORM_WEBGL 1

#include "compile.flib.cpp"

_FDeclsCBegin
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
static void DefaultConsoleOutputImpl(_FStd(FLIB_LOGLEVEL), const char*message, const _FStd(FMessageLogContext)&)
{
    if(s_UnityLogFn != nullptr) s_UnityLogFn(LOG_TYPE::LOG_INFO, message);
}

void exp_EstablishAnyLog(void* pfunc)
{
	_FStdUsing
	s_UnityLogFn = (UnityLogFunc)pfunc;
	FSetLogConsoleOuputFunc(DefaultConsoleOutputImpl);

	F_CONSOLE(INFO) << "AnyLog Setup!";
}

void exp_UnEstablishAnyLog()
{
	F_CONSOLE(INFO) << "AnyLog Cleanup!";
	s_UnityLogFn = nullptr;
}

void exp_InitAllLayer()
{
	
}
void exp_UnInitAllLayer()
{
	
}
void exp_InitLayer(int layer)
{
	
}
void exp_UnInitLayer(int layer)
{
	
}

int exp_AddFilePackageLayer(const char* path, int mode, bool read_only)
{
	F_CONSOLE(INFO) << "AddLayer " << path;
	return false;
}
bool exp_ReadFileBuffer(const char* szFile, char** ppbuffer, int* length)
{
	return false;
}
void exp_ReleaseFileBuffer(char* pbuffer)
{

}
void exp_ReleaseBuffer(char* pbuffer)
{
	if (!!pbuffer)
	{
		delete[] pbuffer;
	}
}
_FDeclsCEnd