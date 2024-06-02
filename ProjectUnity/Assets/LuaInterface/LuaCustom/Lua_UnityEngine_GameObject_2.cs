using System;
using SLua;
using System.Collections.Generic;

public class Lua_UnityEngine_GameObject_2 : LuaObject {

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
    static public int GetLuaScriptFiles(IntPtr l)
    {
        try
        {
            UnityEngine.GameObject self = (UnityEngine.GameObject)checkSelf(l);
            var ret = self.GetComponents<LuaScriptFile>();
            List<LuaTable> lt = new List<LuaTable>();
            foreach (var s in ret)
            {
                lt.Add(s.lua);
            }
            pushValue(l, true);
            pushValue(l, lt);
            return 2;
        }
        catch (Exception e)
        {
            return error(l, e);
        }
    }

    [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
    static public int GetAnyLuaScriptFile(IntPtr l)
    {
        try
        {
            UnityEngine.GameObject self = (UnityEngine.GameObject)checkSelf(l);
            var ret = self.GetComponent<LuaScriptFile>();
            pushValue(l, true);
            pushValue(l, ret != null ? ret.lua : null);
            return 2;
        }
        catch (Exception e)
        {
            return error(l, e);
        }
    }

    [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
    static public int GetLuaScriptFilesByName(IntPtr l)
    {
        try
        {
            UnityEngine.GameObject self = (UnityEngine.GameObject)checkSelf(l);
            string v;
            checkType(l, 2, out v);
            var ret = self.GetComponents<LuaScriptFile>();
            List<LuaTable> lst = new List<LuaTable>();
            foreach(var c in ret)
            {
                if(c.scriptFileName.Equals(v)) { lst.Add(c.lua);}
            }

            pushValue(l, true);
            pushValue(l, lst);
            return 2;
        }
        catch (Exception e)
        {
            return error(l, e);
        }
    }

    [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
    static public int GetAnyLuaScriptFileByName(IntPtr l)
    {
        try
        {
            UnityEngine.GameObject self = (UnityEngine.GameObject)checkSelf(l);
            string v;
            checkType(l, 2, out v);
            var ret = self.GetComponents<LuaScriptFile>();
            LuaTable script = null;
            foreach (var c in ret)
            {
                if (c.scriptFileName.Equals(v)) 
                {
                    script = c.lua;
                    break;
                }
            }

            pushValue(l, true);
            pushValue(l, script);
            return 2;
        }
        catch (Exception e)
        {
            return error(l, e);
        }
    }



    static public void reg_custom(IntPtr l) {
        addMember(l, GetLuaScriptFiles);
        addMember(l, GetAnyLuaScriptFile);
        addMember(l, GetLuaScriptFilesByName);
        addMember(l, GetAnyLuaScriptFileByName);
    }	
}
