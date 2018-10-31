using UnityEngine;
using System;
using SLua;
using System.Collections.Generic;
using System.IO;
public class Lua_System_IO_BinaryWriter_2 : LuaObject
{
    [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
    static public int Create(IntPtr l)
    {
        try
        {
            MemoryStream buff = new MemoryStream();
            BinaryWriter o = new BinaryWriter(buff);
            pushValue(l, true);
            pushValue(l, o);
            return 2;
        }
        catch (Exception e)
        {
            return error(l, e);
        }
    }

    static public void reg_custom(IntPtr l)
    {
        addMember(l, Create, false);
    }
}
