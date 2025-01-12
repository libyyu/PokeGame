#if defined(_WIN32) || defined(__WIN32__) || defined(WIN32) || defined(_WIN64) || defined(WIN64) || defined(__WIN64__)
#	ifndef _WINSOCK_DEPRECATED_NO_WARNINGS
#	define _WINSOCK_DEPRECATED_NO_WARNINGS
#	endif
#	include <winsock2.h>
#	include <windows.h>
#	pragma comment(lib,"ws2_32.lib")
#	pragma comment(lib,"Iphlpapi.lib")
#	include <ws2tcpip.h>
#	include <iphlpapi.h>
#	include <in6addr.h>
#endif
#include <ctime>
#include <mutex>


#include "flib/FAlloctor.cpp"
#include "flib/FAString.cpp"
#include "flib/FBase64.cpp"
#include "flib/FBuffer.cpp"
#include "flib/FChannel.cpp"
#include "flib/FCondition.cpp"
#include "flib/FConsole.cpp"
#include "flib/FConvert.cpp"
#include "flib/FCounter.cpp"
#include "flib/FDataTable.cpp"
#include "flib/FDequeAddLock.cpp"
#include "flib/FDoStructFile.cpp"
#include "flib/FDownloader.cpp"
#include "flib/FDReadAWriteLock.cpp"
#include "flib/FEncoding.cpp"
#include "flib/FFile.cpp"
#include "flib/FFunc.cpp"
#include "flib/FIni.cpp"
#include "flib/FIOStream.cpp"
#include "flib/FITunnel.cpp"
#include "flib/FListAddLock.cpp"
#include "flib/FLock.cpp"
#include "flib/FMD5.cpp"
#include "flib/FMemPool.cpp"
#include "flib/FNetTunnel.cpp"
#include "flib/FPath.cpp"
#include "flib/FPipe.cpp"
#include "flib/FPlugin.cpp"
#include "flib/FPool.cpp"
#include "flib/FProcess.cpp"
#include "flib/FSemaphore.cpp"
#if !defined(PLATFORM_WEBGL) || PLATFORM_WEBGL != 1
#include "flib/FSocketUtil.cpp"
#include "flib/FSocket.cpp"
#endif
#include "flib/FStrHelper.cpp"
#include "flib/FThread.cpp"
#include "flib/FTimestamp.cpp"
#include "flib/FUrl.cpp"
#include "flib/FValue.cpp"
#include "flib/FWString.cpp"
#include "flib/IFile.cpp"