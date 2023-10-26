#ifndef __PCH_H__
#define __PCH_H__
#pragma once

#include "AnyLog/ILog.h"
#include "LuaEnv.hpp"

#define MODULE_NAME "FengEngine"
#define MODULE_VERSION "1.0.1"

static LuaEnv* glb_GetLuaEnv();
static AnyLog::ILog* glb_GetAnyLog();

#define  log_info(fmt,...)    \
if(glb_GetAnyLog() != NULL) \
{	\
	glb_GetAnyLog()->Log(fmt,##__VA_ARGS__);  \
}
#define  log_warning(fmt,...)  \
if(glb_GetAnyLog() != NULL) \
{	\
	glb_GetAnyLog()->LogWarning(fmt,##__VA_ARGS__);  \
}
#define  log_error(fmt,...)   \
if(glb_GetAnyLog() != NULL) \
{	\
	glb_GetAnyLog()->LogError(fmt,##__VA_ARGS__);  \
}
#define  log_exception(fmt,...)   \
if(glb_GetAnyLog() != NULL) \
{	\
	glb_GetAnyLog()->LogException(fmt,##__VA_ARGS__);  \
}

#ifndef SAFE_DELETE
#define SAFE_DELETE(p) { if(p){delete(p);  (p)=NULL;} }
#endif
 
#ifndef SAFE_DELETE_ARRAY
#define SAFE_DELETE_ARRAY(p) { if(p){delete[] (p);  (p)=NULL;} }
#endif

#ifndef SAFE_RELEASE
#define SAFE_RELEASE(p) { if(p){ (p)->Release();  (p)=NULL;} }
#endif

static void formatString(std::string& str, const char* fmt, ...);

typedef enum ErrRet
{
	ERRRET_IGNORE = 0,
	ERRRET_CONTINUE,
	ERRRET_BREAKPOINT,
	ERRRET_ABORT
}ErrRet;

static ErrRet NotifyAssert(const char* condition, const char* fileName, int lineNumber, const char* formats, ...);

#if defined( _DEBUG ) || defined( DEBUG )
#if FLIB_COMPILER_MSVC
#define f_assertx(x,fmt,...) { \
		static bool _ignoreAssert = false; \
		if(!_ignoreAssert && !(x)) \
		{ \
			ErrRet _err_result = NotifyAssert(#x, __FILE__, __LINE__, fmt, ##__VA_ARGS__); \
			if (_err_result == ERRRET_IGNORE) \
			{ \
				_ignoreAssert = true; \
			} \
			else if (_err_result == ERRRET_BREAKPOINT) \
			{ \
				__debugbreak(); \
			} \
		}}
#else
#define f_assertx(x, fmt, ...) { \
		if (!(x)) \
		{ \
			std::string comment; \
			formatString(comment, fmt, ##__VA_ARGS__); \
			if(!comment.empty()){ comment = std::string("Assert comment:") + comment + std::string("\n"); } \
			fprintf (stderr, "%s", comment.c_str()); \
			assert(x); \
			exit(-1);\
		}}
	#endif//_WIN32
#else
	#define f_assertx(x, fmt, ...)
#endif//_DEBUG

#if defined(_DEBUG) || defined(DEBUG)
#	define g_assert(x)		f_assertx(x, "")
#else
#	define g_assert(x)
#endif

#endif//__PCH_H__

