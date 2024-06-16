using UnityEngine;
using System.Collections;
using SLua;

[CustomLuaClass]
public class FGUIWindow : FairyGUI.Window
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
        FairyGUI.GComponent panel = FairyGUI.UIPackage.CreateObject(pkgName, resName).asCom;
        panel.gameObjectName = pkgName;
        //this.rootContainer.gameObject.transform.SetParent(owner.transform);
        this.contentPane = panel;
    }

    public FairyGUI.GObject Find(string name)
    {
        return FGUIHelper.Find(this.contentPane, name);
    }
}
