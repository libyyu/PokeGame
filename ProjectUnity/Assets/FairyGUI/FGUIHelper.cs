using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SLua;

[CustomLuaClass]
public static class FGUIHelper 
{
    public static FairyGUI.GComponent ToCom(FairyGUI.GObject obj)
    {
        if (obj == null)
            return null;

        FairyGUI.GComponent comp = null;
        if (obj.GetType() == typeof(FairyGUI.GLoader))
        {
            FairyGUI.GLoader loader = obj as FairyGUI.GLoader;
            comp = loader.component;
        }
        else
        {
            comp = obj.asCom;
        }
        return comp;
    }

    public static FairyGUI.GObject Find(FairyGUI.GObject root, string path)
    {
        FairyGUI.GComponent comp = ToCom(root);
        if (comp == null)
            return null;

        FairyGUI.GObject obj = null;
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

    public static FGUIWindow CreateWindow(string n1, string n2)
    {
        return new FGUIWindow(n1, n2);
    }

    public static FairyGUI.UIPanel CreatePanel(string n1, string n2)
    {
        GameObject go = new GameObject(n2 + "@" + n1);
        FairyGUI.UIPanel ret = go.AddComponent<FairyGUI.UIPanel>();
        ret.packageName = n1;
        ret.componentName = n2;

        return ret;
    }
}
