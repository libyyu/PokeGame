using UnityEngine;
using System.Collections;
using FGame;
using FairyGUI;

public class FTestOnly : MonoBehaviour {

    GComponent _mainView;
    // Use this for initialization
    void Start () {
        Application.targetFrameRate = 60;

        //Stage.inst.onKeyDown.Add(OnKeyDown);

        ResourceManager.Instance.SepDownloadURL = GameUtil.SepPath + "/StreamingAssets";
        ResourceManager.Instance.UpdateDownloadURL = GameUtil.AssetRoot +  "/StreamingAssets";
        ResourceManager.Instance.BaseDownloadingURL = GameUtil.BaseStreamAssetPath + "/res_base/StreamingAssets";
        ResourceManager.Instance.BundleExt = ".assetbundle";
        ResourceManager.Instance.LoadBundle("assets/arts/fairygui/login", (AssetBundle ab) =>
        {
            Debug.Log(ab);

            UIPackage.AddPackage(ab);

            _mainView = UIPackage.CreateObject("Login", "Main").asCom;
            _mainView.fairyBatching = true;
            _mainView.SetSize(GRoot.inst.width, GRoot.inst.height);
            _mainView.AddRelation(GRoot.inst, RelationType.Size);

            GRoot.inst.AddChild(_mainView);
            //_mainView.GetTransition("t0").Play();
            GObject p = FGUIHelper.Find(_mainView, "n4/n8");
            GButton button = p.asButton;
            Debug.Log(button);
            button.onClick.Add(() =>
            {
                Debug.Log("Click Me");
            });
        });
    }
	
	// Update is called once per frame
    void Update () {

    }
}
