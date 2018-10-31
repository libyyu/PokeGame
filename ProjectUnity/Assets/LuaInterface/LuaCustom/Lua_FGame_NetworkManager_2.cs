using System;
using SLua;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class Lua_FGame_NetworkManager_2 : LuaObject {

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
    static public int SendPbMessage(IntPtr l)
    {
        try
        {
			FGame.NetworkManager self=(FGame.NetworkManager)checkSelf(l);
			int len = 0;
			IntPtr buffer = LuaDLL.lua_tolstring(l, 2, out len);
			byte[] b = new byte[len];
			Marshal.Copy(buffer, b, 0, len);
			var ret=self.SendMessage(b);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
        }
        catch (Exception e)
        {
            return error(l, e);
        }
    }

	static public void reg_custom(IntPtr l) {
        addMember(l, SendPbMessage);
    }	
}
