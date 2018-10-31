#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GUITools  {

    static GameObject uiRoot2D = null;
    public static GameObject GetUIRootObj()
    {
        if(null == uiRoot2D)
        {
            uiRoot2D = CreateUIRoot2D();
        }
        return uiRoot2D;
    }

#if UNITY_EDITOR
    [MenuItem("Tools/GUI/Create 2D UI")]
#endif
    public static GameObject CreateUIRoot2D()
    {
        GameObject uiRoot2D = new GameObject("UIRoot(2D)");
        uiRoot2D.layer = LayerMask.NameToLayer("UI");
        uiRoot2D.transform.localPosition = new Vector3(0, 0, 0);
        GameObject goCam = new GameObject("UICamera");
        goCam.transform.SetParent(uiRoot2D.transform);
        goCam.transform.localPosition = new Vector3(0, 0, 0);
        goCam.layer = LayerMask.NameToLayer("UI");
        Camera cam = goCam.AddComponent<Camera>();
        cam.clearFlags = CameraClearFlags.Depth;
        cam.cullingMask = 32;
        cam.nearClipPlane = 0;
        cam.orthographic = true;
        cam.orthographicSize = 3.2f;

        goCam.AddComponent<GUILayer>();
        goCam.AddComponent<FlareLayer>();

        Canvas canVas = uiRoot2D.GetComponent<Canvas>();
        if(null == canVas)
        {
            canVas = uiRoot2D.AddComponent<Canvas>();
        }
        canVas.renderMode = RenderMode.ScreenSpaceCamera;
        canVas.pixelPerfect = true;
        canVas.worldCamera = cam;

        CanvasScaler cs = uiRoot2D.GetComponent<CanvasScaler>();
        if(null == cs)
        {
            cs = uiRoot2D.AddComponent<CanvasScaler>();
        }
        cs.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        cs.referenceResolution = new Vector2(960, 640);
        //cs.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;

        GraphicRaycaster gr = uiRoot2D.GetComponent<GraphicRaycaster>();
        if(null == gr)
        {
            gr = uiRoot2D.AddComponent<GraphicRaycaster>();
        }

#if UNITY_EDITOR
        GameObject goEvt = new GameObject("EventSystem");
        goEvt.transform.SetParent(uiRoot2D.transform);
        EventSystem evt = goEvt.AddComponent<EventSystem>();
        goEvt.AddComponent<StandaloneInputModule>();
        goEvt.AddComponent<TouchInputModule>();

        Selection.activeObject = uiRoot2D;
#endif

        return uiRoot2D;
    }

    public static string RapFilePath(string fullname)
    {
        return fullname.Replace('\\', '/');
    }

    public static string GetFilePath(string fullname)
    {
        string temp = RapFilePath(fullname);

        int nPos = temp.LastIndexOf('/');
        if (nPos != -1)
        {
            return temp.Substring(0,nPos);
        }
        else
            return temp;
    }

#if UNITY_EDITOR
    [MenuItem("Tools/GUI/AtlasMaker")]
    public static void MakeAtlas()
    {
        Object[] SelectedAsset = Selection.GetFiltered(typeof(Object), SelectionMode.DeepAssets);
        foreach (Object obj in SelectedAsset)
        {
            string assetPath = AssetDatabase.GetAssetPath(obj);
            if(assetPath.EndsWith(".png"))
            {
                Sprite sprite = AssetDatabase.LoadAssetAtPath<Sprite>(assetPath);
                GameObject go = new GameObject(sprite.name);
                go.AddComponent<SpriteRenderer>().sprite = sprite;
                
                string allPath = GetFilePath(assetPath) + "/" + sprite.name + ".prefab";
                string prefabPath = allPath.Substring(allPath.IndexOf("Assets"));
                PrefabUtility.CreatePrefab(prefabPath, go);
                GameObject.DestroyImmediate(go);
            }
        }
    }
#endif

#if UNITY_EDITOR
    [MenuItem("Tools/Create Main Camera")]
    public static void CreateMainCamera()
    {
        GameObject cam_root = new GameObject("MainCamera Root");
        cam_root.transform.localPosition = new Vector3(0, 0, 0);
        cam_root.transform.localScale = new Vector3(1, 1, 1);
        GameObject camobj = new GameObject("Main Camera");
        camobj.transform.SetParent(cam_root.transform);
        camobj.transform.localPosition = new Vector3(0,0,0);
        camobj.transform.localScale = new Vector3(1, 1, 1);
        camobj.AddComponent<Camera>();
        camobj.AddComponent<FlareLayer>();
        camobj.AddComponent<GUILayer>();
        camobj.tag = "MainCamera";
    }
#endif
}