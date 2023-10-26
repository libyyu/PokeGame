/********************************************************************
FileName :  ILog.h
Version  :  0.10
Date     :	2010-2-1 19:41:30
Author   :  Feng(libyyu@qq.com)
Comment  :

*********************************************************************/
#ifndef __ILOG_H__
#define __ILOG_H__
#pragma once
#include <stdio.h>
#include <stdlib.h>
#include <stdarg.h>
#include <assert.h>

enum LOG_TYPE
{
	LOG_ERROR = 0,
	LOG_ASSERT = 1,
	LOG_WARNING = 2,
	LOG_INFO = 3,
	LOG_EXCEPTION = 4,
};

typedef void (*PLogFunc) (int logType, const char* message);

namespace AnyLog
{
	class ILog
	{
	public:
		void Log(const char* format,...);
		void LogWarning(const char* format,...);
		void LogError(const char* format,...);
		void LogException(const char* format,...);
	protected:
		virtual void LogImpl(LOG_TYPE logType,const char* message) = 0;
	private:
		void LogFormatInner(LOG_TYPE logType,const char* format, va_list va);
	};

	typedef ILog *PLOG;
}


#endif//__ILOG_H__
