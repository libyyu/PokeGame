//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_ReleaseResult : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"WeChatWASM.ReleaseResult");
		addMember(l,1,"noNeedRelease");
		addMember(l,2,"exceedMax");
		addMember(l,3,"releaseSuccess");
		LuaDLL.lua_pop(l, 1);
	}
}
