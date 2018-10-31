using System.Collections;
using System.Collections.Generic;
using FairyGUI;
using UnityEngine;
using SLua;

[CustomLuaClass]
public static class FGUIHelper 
{
    public static GComponent ToCom(GObject obj)
    {
        if (obj == null)
            return null;

        GComponent comp = null;
        if (obj.GetType() == typeof(GLoader))
        {
            GLoader loader = obj as GLoader;
            comp = loader.component;
        }
        else
        {
            comp = obj.asCom;
        }
        return comp;
    }

    public static GObject Find(GObject root, string path)
    {
        GComponent comp = ToCom(root);
        if (comp == null)
            return null;

        GObject obj = null;
        string[] ns = path.Split(new char[] { '/' });
        foreach(string name in ns)
        {
            if (comp == null)
                return null;

            obj = comp.GetChild(name);
            if (obj == null)
                return null;

            comp = ToCom(obj);
        }

        return obj;
    }

    public static FGUIWindow CreatePanel(string n1, string n2)
    {
        return new FGUIWindow(n1, n2);
    }
}
