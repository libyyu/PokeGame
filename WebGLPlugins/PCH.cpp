#define LUA_LIB
#include "PCH.h"
static AnyLog::ILog* g_theLog = NULL;
static LuaEnv* g_luaEnv = NULL;

LuaEnv* glb_GetLuaEnv()
{
    return g_luaEnv;
}
void glb_SetLuaEnv(LuaEnv* env)
{
    g_luaEnv = env;
}

AnyLog::ILog* glb_GetAnyLog()
{
    return g_theLog;
}
void glb_SetAnyLog(AnyLog::ILog* pLog)
{
    FLog::DestroyILog(g_theLog);
	g_theLog = pLog;
}

void formatString(std::string& str, const char* fmt, ...)
{
	char buff[20481] = { 0 };
	va_list va;
	va_start(va, fmt);
	vsnprintf(buff, 20480, fmt, va);
	va_end(va);

	str = buff;
}

ErrRet DisplayError(const char* errorTitle,
	const char* errorText,
	const char* errorDescription,
	const char* fileName,
	int lineNumber)
{
#if FLIB_COMPILER_MSVC
	const int MODULE_NAME_SIZE = 255;
	char moduleName[MODULE_NAME_SIZE] = {0};
	// attempt to get the module name
	if (!GetModuleFileNameA(NULL, moduleName, MODULE_NAME_SIZE))
	{
		const char *msg = "<unknown application>";
		//_tcscpy_s(moduleName, _tcsclen(msg), msg);
		strcpy(moduleName, msg);
	}

	// build a collosal string containing the entire asster message
	const	int		MAX_BUFFER_SIZE = 1024;
	char	buffer[MAX_BUFFER_SIZE];

	int Size = snprintf(buffer,
		MAX_BUFFER_SIZE,
		"%s\n\nProgram : %s\nFile : %s\nLine : %d\nError: %s\nComment: %s\n \
		Abort to exit (or debug), Retry to continue,\n \
		Ignore to disregard all occurances of this error\n",
		errorTitle,
		moduleName,
		fileName,
		lineNumber,
		errorText,
		errorDescription);

	// place a copy of the message into the clipboard
	if (OpenClipboard(NULL))
	{
		size_t bufferLength = strlen(buffer);
		HGLOBAL hMem = GlobalAlloc(GHND | GMEM_DDESHARE, bufferLength + 1);

		if (hMem)
		{
			BYTE* pMem = (BYTE*)GlobalLock(hMem);
			memcpy(pMem, buffer, bufferLength);
			GlobalUnlock(hMem);
			EmptyClipboard();
			SetClipboardData(CF_TEXT, hMem);
		}

		CloseClipboard();
	}

	// find the top most window of the current application
	HWND hWndParent = GetActiveWindow();
	if (NULL != hWndParent)
	{
		hWndParent = GetLastActivePopup(hWndParent);
	}
	std::string sbuf;
	sbuf += buffer;
	// put up a message box with the error
	int iRet = MessageBoxA(hWndParent,
		sbuf.c_str(),
		"ERROR NOTIFICATION...",
		MB_TASKMODAL | MB_SETFOREGROUND | MB_ABORTRETRYIGNORE | MB_ICONERROR);

	// Figure out what to do on the return.
	if (iRet == IDRETRY)
	{
		// ignore this error and continue
		return (ERRRET_CONTINUE);
	}
	if (iRet == IDIGNORE)
	{
		// ignore this error and continue,
		// plus never stop on this error again (handled by the caller)
		return (ERRRET_IGNORE);
	}

	// The return has to be IDABORT, but does the user want to enter the debugger
	// or just exit the application?
	iRet = MessageBoxA(hWndParent,
		"Do you wish to debug the last error?",
		"DEBUG OR EXIT?",
		MB_TASKMODAL | MB_SETFOREGROUND | MB_YESNO | MB_ICONQUESTION);

	if (iRet == IDYES)
	{
		// inform the caller to break on the current line of execution
		return (ERRRET_BREAKPOINT);
	}

	// must be a full-on termination of the app
	ExitProcess((UINT)-1);
	return (ERRRET_ABORT);
#else
	return (ERRRET_BREAKPOINT);
#endif
}


ErrRet NotifyAssert(const char* condition, const char* fileName, int lineNumber, const char* formats, ...)
{
	char szBuffer[4096] = {0};

	va_list args;
	va_start(args, formats);
	vsnprintf(szBuffer,4096, formats, args);
	va_end(args);

	std::string filenameStr = fileName;

	// pass the data on to the message box
	ErrRet result = DisplayError("Assert Failed!",
		condition,
		szBuffer,
		filenameStr.c_str(),
		lineNumber);
	return result;
}