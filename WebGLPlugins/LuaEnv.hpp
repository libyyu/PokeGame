#ifndef _LUA_ENV_HPP
#define _LUA_ENV_HPP

#include "lua.hpp"
#include <string>
#include <assert.h>
#include <iostream>
#ifdef _WIN32
#include <direct.h>
#include <Windows.h>
#else
#include <unistd.h>
#include <dirent.h>
#endif

typedef void (*PLuaOutFunc) (const char* message);

class LuaOutHandler
{
    PLuaOutFunc m_print_func = nullptr;
    PLuaOutFunc m_warn_func = nullptr;
    PLuaOutFunc m_error_func = nullptr;
	PLuaOutFunc m_exception_func = nullptr;
public:
    void SetPrintHandler(PLuaOutFunc pfunc, int flag)
    {
        if(flag == 0)
            m_print_func = (PLuaOutFunc)pfunc;
        else if(flag == 1)
            m_warn_func = (PLuaOutFunc)pfunc;
        else if(flag == 2)
            m_error_func = (PLuaOutFunc)pfunc;
		else
			m_exception_func = (PLuaOutFunc)pfunc;
    }
    
    void Stdout(const char* message, bool warning)
    {
        if(warning){
            if(m_warn_func) m_warn_func(message);
            else std::cout << message << std::endl;
        }
        else {
            if(m_print_func) m_print_func(message);
            else std::cout << message << std::endl;
        }
    }
    void Stderr(const char* message)
    {
        if(m_error_func) m_error_func(message);
        else std::cerr << message << std::endl;
    }

	void Exception(const char* message)
	{
		if(m_exception_func) m_exception_func(message);
		else throw message;
	}
    
    static LuaOutHandler& Get()
    {
        static LuaOutHandler handler;
        return handler;
    }
};

class LuaEnv
{
public:
	LuaEnv(bool open_ = true)
    : m_L(nullptr)
    , m_errRef(-1)
	, m_bNoClose(0)
	{
		if (open_) open();
	}
	~LuaEnv()
	{
		close();
	}
	LuaEnv(lua_State* L)
	: m_L(nullptr)
    , m_errRef(-1)
	{
		close();
		m_L = L;
		m_bNoClose = L ? 1 : 0;
		/*luaL_openlibs(m_L);
		lua_atpanic(m_L, panic);

		lua_pushcfunction(m_L, print);
		lua_setfield(m_L, LUA_GLOBALSINDEX, "print");

		lua_pushcfunction(m_L, warn);
		lua_setfield(m_L, LUA_GLOBALSINDEX, "warn");*/
		lua_pushcfunction(m_L, error_traceback);
		m_errRef = luaL_ref(m_L, LUA_REGISTRYINDEX);

		lua_pushnumber(m_L, m_errRef);
#if LUA_VERSION_NUM < 503
		lua_setfield(m_L, LUA_GLOBALSINDEX, "__err_ref");
#else
		lua_setglobal(m_L, "__err_ref");
#endif

		lua_pushstring(m_L, "_luaEnv");
		lua_pushlightuserdata(m_L, this);
		lua_rawset(m_L, LUA_REGISTRYINDEX);
	}
	bool open()
	{
		close();
		m_L = luaL_newstate();
		luaL_openlibs(m_L);
		lua_atpanic(m_L, panic);

		lua_pushcfunction(m_L, print);
#if LUA_VERSION_NUM < 503
		lua_setfield(m_L, LUA_GLOBALSINDEX, "print");
#else
		lua_setglobal(m_L, "print");
#endif		

		lua_pushcfunction(m_L, warn);
#if LUA_VERSION_NUM < 503
		lua_setfield(m_L, LUA_GLOBALSINDEX, "warn");
#else
		lua_setglobal(m_L, "warn");
#endif

		lua_pushcfunction(m_L, printerror);
#if LUA_VERSION_NUM < 503
		lua_setfield(m_L, LUA_GLOBALSINDEX, "printerror");
#else
		lua_setglobal(m_L, "printerror");
#endif

		lua_pushcfunction(m_L, cprint);
#if LUA_VERSION_NUM < 503
		lua_setfield(m_L, LUA_GLOBALSINDEX, "cprint");
#else
		lua_setglobal(m_L, "cprint");
#endif

		lua_pushcfunction(m_L, error_traceback);
		m_errRef = luaL_ref(m_L, LUA_REGISTRYINDEX);

		lua_pushnumber(m_L, m_errRef);
#if LUA_VERSION_NUM < 503
		lua_setfield(m_L, LUA_GLOBALSINDEX, "__err_ref");
#else
		lua_setglobal(m_L, "__err_ref");
#endif

		lua_pushstring(m_L, "_luaEnv");
		lua_pushlightuserdata(m_L, this);
		lua_rawset(m_L, LUA_REGISTRYINDEX);

		return true;
	}
	void close()
	{
		if (m_L && !m_bNoClose)
		{
			//doString("print('close lua state')");
			lua_pushstring(m_L, "_luaEnv");
			lua_pushnil(m_L);
			lua_rawset(m_L, LUA_REGISTRYINDEX);

			lua_pushnil(m_L);
#if LUA_VERSION_NUM < 503
			lua_setfield(m_L, LUA_GLOBALSINDEX, "__err_ref");
#else
			lua_setglobal(m_L, "__err_ref");
#endif

			luaL_unref(m_L, LUA_REGISTRYINDEX, m_errRef);
			m_errRef = -1;
			lua_close(m_L);
		}
		m_L = nullptr;
	}
	operator lua_State* () { return m_L; }
	operator bool() { return m_L != nullptr; }

	static LuaEnv* getLuaEnv(lua_State* L)
	{
		if(!L) return nullptr;
		lua_pushstring(L, "_luaEnv");
		lua_rawget(L, LUA_REGISTRYINDEX);
		LuaEnv* lenv = nullptr;
		if (lua_islightuserdata(L, -1))
		{
			lenv = (LuaEnv*)lua_touserdata(L, -1);
		}
		lua_pop(L, 1);
		return lenv;
	}
public:
	std::string getTraceback(const char* err = "Lua traceback:")
	{
		lua_State* l = m_L;
		int oldTop = lua_gettop(l);
		lua_checkstack(l, 3);
		lua_getglobal(l, "debug");
		lua_getfield(l, -1, "traceback");
		lua_pushstring(l, err);
		lua_pushnumber(l, 1);
		lua_pcall(l, 2, 1, 0);
		std::string trace = lua_tostring(l, -1);
		lua_settop(l, oldTop);
		return trace;
	}

	void SetSearcher(lua_CFunction loader)
	{
		lua_State* L = m_L;
		int top = lua_gettop(L);

		lua_pushcfunction(L, loader);
		int loaderFunc = lua_gettop(L);
#if LUA_VERSION_NUM < 503
		lua_getfield(L, LUA_GLOBALSINDEX, "package");
#else
		lua_getglobal(L, "package");
#endif
		lua_getfield(L, -1, "loaders");
		int loaderTable = lua_gettop(L);

		for (size_t e = lua_objlen(L, loaderTable) + 1; e > 1; e--)
		{
			lua_rawgeti(L, loaderTable, int(e - 1));
			lua_rawseti(L, loaderTable, int(e));
		}
		lua_pushvalue(L, loaderFunc);
		lua_rawseti(L, loaderTable, 1);

		lua_settop(L, top);
	}
    
	bool doCall(int nArgs, int nResults = -1)
	{
		lua_State* L = m_L;
		assert(m_L != nullptr && "lua vm is closed.");

		int oldTop = lua_gettop(L) - nArgs - 1;
		lua_rawgeti(L, LUA_REGISTRYINDEX, m_errRef);
		lua_insert(L, oldTop + 1);
		if (lua_pcall(L, nArgs, nResults, oldTop + 1) == 0)
		{
			lua_remove(L, oldTop + 1);	//pop errorFunc
			return true;
		}
		else
		{
			lua_remove(L, oldTop + 1);	//pop errorFunc
			const char* errmsg = lua_tostring(L, -1);
			on_error_handler(errmsg);
			return false;
		}
	}
#if 0
	template <typename ... Args>
	inline bool doString(const char* buff, const Args &... args)
	{
		lua_State* L = m_L;
		assert(m_L != nullptr && "lua vm is closed.");

		if (0 != luaL_loadstring(L, buff))
		{
			const char* errmsg = lua_tostring(L, -1);
			on_error_handler(errmsg);

			return false;
		}

		int n = lua::push(L, args...);
		return doCall(n, -1);
	}

	template <typename ... Args>
	inline bool doFile(const char* file, const Args &... args)
	{
		lua_State* L = m_L;
		assert(m_L != nullptr && "lua vm is closed.");

		if (0 != luaL_loadfile(L, file))
		{
			const char* errmsg = lua_tostring(L, -1);
			on_error_handler(errmsg);

			return false;
		}

		int n = lua::push(L, args...);
		return doCall(n, -1);
	}

	template <typename ... Args>
	inline bool doGlobal(const char* method, const Args &... args)
	{
		lua_State* L = m_L;
		assert(m_L != nullptr && "lua vm is closed.");

		lua_getglobal(L, method);
		if (!lua_isfunction(L, -1))
		{
			lua_pop(L, 1);
			luaL_error(L, "Error: function %s not found.\n", method);
			return false;
		}
		int n = lua::push(L, args...);
		return doCall(n, -1);
	}
	
	template <typename ... Args>
	inline bool doFunc(int refFunc, const Args&... args)
	{
		lua_State* L = m_L;
		assert(m_L != nullptr && "lua vm is closed.");

		lua_rawgeti(L, (int)LUA_REGISTRYINDEX, refFunc); //f
		if (!lua_isfunction(L, -1))
		{
			lua_pop(L, 1);
			luaL_error(L, "Error: registryindex %d is not a function\n", refFunc);
			return false;
		}
		int n = lua::push(L, args...);
		return doCall(n, -1);
	}

	template <typename ... Args>
	inline bool doTableFunc(int refTable, const char* method, const Args &... args)
	{
		lua_State* L = m_L;
		assert(m_L != nullptr && "lua vm is closed.");

		lua_rawgeti(L, (int)LUA_REGISTRYINDEX, refTable); //t
		if (!lua_istable(L, -1))
		{
			lua_pop(L, 1);
			luaL_error(L, "Error: registryindex %d not a table.\n", refTable);
			return false;
		}
		lua_getfield(L, -1, method);//t,func
		if (lua_isnone(L, -1))
		{
			lua_pop(L, 2);
			luaL_error(L, "Error: %s not found.\n", method);
			return false;
		}
		else if (lua_isnil(L, -1))
		{
			lua_pop(L, 2);
			return false;
		}
		int n = lua::push(L, args...);
		return doCall(n, -1);
	}
	
	template <typename ... Args>
	inline bool doTableFunc(const char* module, const char* method, const Args &... args)
	{
		lua_State* L = m_L;
		assert(m_L != nullptr && "lua vm is closed.");
		int oldTop = lua_gettop(L);

		lua_getglobal(L, module);	//--> t
		if (!lua_istable(L, -1))
		{
			lua_pop(L, 1);
			luaL_error(L, "Error: module %s not found.\n", module);
			return false;
		}
		lua_getfield(L, -1, method);	//--> t, func
		if (lua_isnone(L, -1))
		{
			lua_pop(L, 2);
			luaL_error(L, "Error:  %s@%s not found.\n", method, module);
			return false;
		}
		else if (lua_isnil(L, -1))
		{
			lua_pop(L, 2);
			return false;
		}

		int n = lua::push(L, args...);
		return doCall(n, -1);
	}
#endif
protected:
	static int panic(lua_State* L)
	{
		char sL[20] = { 0 };
		snprintf(sL, 20, "%p|", L);
		std::string reason(sL);
		reason += "unprotected error in call to Lua API (";
		const char* s = lua_tostring(L, -1);
		reason += s;
		reason += ")\n";

		LuaOutHandler::Get().Exception(reason.c_str());
		return 0;
	}
	static int print(lua_State* L)
	{
		std::string s = "[LUA]" + on_print_handler(L);
        LuaOutHandler::Get().Stdout(s.c_str(), false);
		return 0;
	}
	static int warn(lua_State* L)
	{
		std::string s = "[LUA]" + on_print_handler(L);
		LuaOutHandler::Get().Stdout(s.c_str(), true);
		return 0;
	}
	static int printerror(lua_State* L)
	{
		std::string s = "[LUA]" + on_print_handler(L);
		LuaOutHandler::Get().Stderr(s.c_str());
		return 0;
	}
	static int cprint(lua_State* L)
	{
		std::string s = on_print_handler(L);
		printf("%s\n", s.c_str());
		return 0;
	}
	static int error_traceback(lua_State* L)
	{
		if (!lua_isstring(L, 1))
			return 1;
		lua_checkstack(L, 3);
		lua_getglobal(L, "debug"); //msg, debug
		lua_getfield(L, -1, "traceback"); //msg, debug,traceback
		lua_pushvalue(L, 1); //msg, debug,traceback, msg
		lua_pushnumber(L, 1); //msg, debug,traceback, msg, level
		lua_pcall(L, 2, 1, 0);//msg, debug, tracebackstring
	
		return 1;
	}
	static void on_error_handler(const char* msg)
	{
        if(msg) LuaOutHandler::Get().Stderr(msg);
	}
private:
	static std::string on_print_handler(lua_State* L)
	{
		char sL[20] = { 0 };
		snprintf(sL, 20, "%p|", L);
		std::string s(sL);
		int n = lua_gettop(L);
		lua_getglobal(L, "tostring");

		for (int i = 1; i <= n; ++i)
		{
			lua_pushvalue(L, -1); // function to be called
			lua_pushvalue(L, i);  // value to print
			lua_pcall(L, 1, 1, 0);

			const char* ret = lua_tostring(L, -1);
			if(ret)
				s.append(ret);
			
			if (i < n)
				s.append("\t");

			lua_pop(L, 1); //pop result
		}

		return s;
	}
private:
	lua_State* m_L;
	int        m_errRef;
	int        m_bNoClose;
};


#endif//_LUA_ENV_H
