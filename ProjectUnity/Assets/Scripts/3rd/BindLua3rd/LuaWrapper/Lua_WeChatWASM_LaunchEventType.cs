//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_LaunchEventType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"WeChatWASM.LaunchEventType");
		addMember(l,0,"launchPlugin");
		addMember(l,1,"loadWasm");
		addMember(l,2,"compileWasm");
		addMember(l,3,"loadAssets");
		addMember(l,5,"readAssets");
		addMember(l,6,"prepareGame");
		LuaDLL.lua_pop(l, 1);
	}
}
