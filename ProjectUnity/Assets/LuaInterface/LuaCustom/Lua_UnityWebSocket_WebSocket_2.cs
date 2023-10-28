using System;
using SLua;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityWebSocket;
using System.IO;

public class Lua_UnityWebSocket_WebSocket_2 : LuaObject {

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
    static public int SendMessage(IntPtr l)
    {
        try
        {
            WebSocket self =(WebSocket)checkSelf(l);

            if (matchType(l, 2, typeof(System.Byte[])))
            {
                System.Byte[] a1;
                checkType(l, 2, out a1);
                self.SendAsync(a1);
            }
            else if (matchType(l, 1, typeof(FByteBuffer)))
            {
                FByteBuffer a1;
                checkType(l, 1, out a1);
                self.SendAsync(a1.ToBytes());
            }
            else
            {
                int len = 0;
                IntPtr buffer = LuaDLL.lua_tolstring(l, 2, out len);
                byte[] b = new byte[len];
                Marshal.Copy(buffer, b, 0, len);
                self.SendAsync(b);
            }
			pushValue(l,true);
			return 1;
        }
        catch (Exception e)
        {
            return error(l, e);
        }
    }



	static public void reg_custom(IntPtr l) {
        addMember(l, SendMessage);
    }	
}
