using UnityEngine;
using System;
using SLua;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class Lua_FGame_ByteBuffer_2 : LuaObject {

    [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
    static public int WriteBytesString(IntPtr l)
    {
        try
        {
            FGame.ByteBuffer self = (FGame.ByteBuffer)checkSelf(l);
            int len = 0;
            IntPtr buffer = LuaDLL.lua_tolstring(l, 2, out len);
            byte[] b = new byte[len];
            Marshal.Copy(buffer, b, 0, len);

            self.WriteBytes(b);
            pushValue(l, true);
            return 1;
        }
        catch (Exception e)
        {
            return error(l, e);
        }
    }
    [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
    static public int ReadBytesString(IntPtr l)
    {
        try
        {
            FGame.ByteBuffer self = (FGame.ByteBuffer)checkSelf(l);
            Byte[] b = self.ReadBytes();

            pushValue(l, true);
            LuaDLL.lua_pushlstring(l, b, b.Length);
            return 2;
        }
        catch (Exception e)
        {
            return error(l, e);
        }
    }

    static public void reg_custom(IntPtr l) {
        addMember(l, WriteBytesString);
        addMember(l, ReadBytesString);
    }
}
