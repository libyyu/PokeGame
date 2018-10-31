using UnityEngine;
using System;
using SLua;
using System.Collections.Generic;
using System.IO;
public class Lua_System_IO_BinaryReader_2 : LuaObject {

    [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
    static public int Create(IntPtr l)
    {
        try
        {
            BinaryReader o;
            if (matchType(l, 1, typeof(System.Byte[])))
            {
                System.Byte[] a1;
                checkType(l, 1, out a1);
                MemoryStream buff = new MemoryStream(a1);
                o = new BinaryReader(buff);
                pushValue(l, true);
                pushValue(l, o);
                return 2;
            }
            else if (matchType(l, 1, typeof(FGame.ByteBuffer)))
            {
                FGame.ByteBuffer a1;
                checkType(l, 1, out a1);
                MemoryStream buff = new MemoryStream(a1.ToBytes());
                o = new BinaryReader(buff);
                pushValue(l, true);
                pushValue(l, o);
                return 2;
            }
            return error(l, "New object failed.");
        }
        catch (Exception e)
        {
            return error(l, e);
        }
    }

	static public void reg_custom(IntPtr l) {
        addMember(l, Create,false);
	}
}
