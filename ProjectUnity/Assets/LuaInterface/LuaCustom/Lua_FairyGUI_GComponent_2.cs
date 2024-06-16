using System;
using SLua;
using System.Collections.Generic;

public class Lua_FairyGUI_GComponent_2 : LuaObject {

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
    static public int SetLuaHandler(IntPtr l)
    {
        try
        {
            FairyGUI.GComponent self = (FairyGUI.GComponent)checkSelf(l);
            SLua.LuaTable a1 = default(SLua.LuaTable);
            checkType(l, 2, out a1);
#if FAIRYGUI_TOLUA || FAIRYGUI_SLUA
            self.SetLuaPeer(a1);
#endif
            pushValue(l, true);
            return 1;
        }
        catch (Exception e)
        {
            return error(l, e);
        }
    }

    static public void reg_custom(IntPtr l) {
        addMember(l, SetLuaHandler);
    }	
}
