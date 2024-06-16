#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;
using System.IO;

public class MyPostprocessor : AssetPostprocessor
{
    //使用AssetPostprocessor类定义的函数OnPostprocessAssetbundleNameChanged回调
    //当AssetBundle的名称发生变化时，编辑器会自动执行以下函数，返回变化信息
    public void OnPostprocessAssetbundleNameChanged(string assetPath, string previousAssetBundleName, string newAssetBundleName)
    {
        //Debug.Log("Asset " + assetPath + " has been moved from assetBundle " + previousAssetBundleName + " to assetBundle " + newAssetBundleName);
    }

    /// <summary>  
    /// 在导入纹理之后调用  
    /// </summary>  
    void OnPostprocessTexture(Texture2D texture)
    {
        string AtlasName = new DirectoryInfo(Path.GetDirectoryName(assetPath)).Name;
        TextureImporter textureImporter = assetImporter as TextureImporter;
        textureImporter.textureType = TextureImporterType.Sprite;
        textureImporter.spritePackingTag = AtlasName;
        textureImporter.mipmapEnabled = false;
    }

    /// <summary>  
    /// 移动、删除资源  
    /// </summary>  
    private static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
    {
        //当移动资源的时候  也就是重新导入资源  
       /* for (int i = 0; i < movedAssets.Length; i++  )  
        {
            UnityEngine.Debug.Log("Reimported Asset: "  + movedAssets[i]);
        }
        //删除资源  
        for (int i = 0; i < deletedAssets.Length; i++  )  
        {
            UnityEngine.Debug.Log("Deleted Asset: "  + deletedAssets[i]);
        }
        //移动资源  
        for (var i = 0; i < movedAssets.Length; i++  ) {
            UnityEngine.Debug.Log("Moved Asset: " +  movedAssets[i]  + " from: " +  movedFromAssetPaths[i]);
        }
        */
        for (int i = 0; i < importedAssets.Length; ++i)
        {
            //AssetExport.AutoSetAssetBundleName(importedAssets[i]);
        }
    }
}

#endif