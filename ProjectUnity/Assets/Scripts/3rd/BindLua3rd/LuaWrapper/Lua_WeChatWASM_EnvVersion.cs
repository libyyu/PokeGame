//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_EnvVersion : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"WeChatWASM.EnvVersion");
		addMember(l,0,"develop");
		addMember(l,1,"trial");
		addMember(l,2,"release");
		LuaDLL.lua_pop(l, 1);
	}
}
