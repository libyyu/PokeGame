#include "ILog.h"
#include <string>

using namespace AnyLog;

void ILog::Log(const char* format, ...)
{
	va_list va;
	va_start(va, format);
	LogFormatInner(LOG_INFO, format, va);
	va_end(va);
}

void ILog::LogWarning(const char* format, ...)
{
	va_list va;
	va_start(va, format);
	LogFormatInner(LOG_WARNING, format, va);
	va_end(va);
}

void ILog::LogError(const char* format, ...)
{
	va_list va;
	va_start(va, format);
	LogFormatInner(LOG_ERROR, format, va);
	va_end(va);
}

void ILog::LogException(const char* format, ...)
{
	va_list va;
	va_start(va, format);
	LogFormatInner(LOG_EXCEPTION, format, va);
	va_end(va);
}

void ILog::LogFormatInner(LOG_TYPE logType, const char* format, va_list va)
{
	if (format)
	{
		char buff[20480] = { 0 };
#ifdef _WIN32
		_vsnprintf(buff, 20480, format, va);
#else
		vsnprintf(buff, 20480, format, va);
#endif
		LogImpl(logType, buff);
	}
}

