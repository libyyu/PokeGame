using UnityEngine;
using System.Collections;
using FairyGUI;
using SLua;

[CustomLuaClass]
public class FGUIWindow : Window
{
    protected string pkgName;
    protected string resName;
    public FGUIWindow(string n1, string n2)
        : base()
    {
        pkgName = n1;
        resName = n2;
    }

    protected override void OnInit()
    {
        GComponent panel = UIPackage.CreateObject(pkgName, resName).asCom;
        panel.gameObjectName = pkgName;
        //this.rootContainer.gameObject.transform.SetParent(owner.transform);
        this.contentPane = panel;
    }

    public GObject Find(string name)
    {
        return FGUIHelper.Find(this.contentPane, name);
    }
}
