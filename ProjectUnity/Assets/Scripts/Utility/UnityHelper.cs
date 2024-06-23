using UnityEngine;
using System;
using System.Collections.Generic;
using System.Text;

public static class UnityHelper {

    public static bool Color32Equal(Color32 c, byte r, byte g, byte b, byte a)
    {
        return c.r == r && c.g == g && c.b == b && c.a == a;
    }

    public static byte GetAlpha(uint c)
    {
        return (byte)((c & 0xff000000) >> 24);
    }

    public static byte GetRed(uint c)
    {
        return (byte)((c & 0x00ff0000) >> 16);
    }

    public static byte GetGreen(uint c)
    {
        return (byte)((c & 0x0000ff00) >> 8);
    }

    public static byte GetBlue(uint c)
    {
        return (byte)(c & 0x000000ff);
    }

    public static Color32 UInt32ToColor32(uint c)
    {
        return new Color32(GetRed(c), GetGreen(c), GetBlue(c), GetAlpha(c));
    }

	public static float GetMagnitudeH(this Vector3 v)
	{
		return (float)Math.Sqrt(v.x * v.x + v.z * v.z);
	}

	public static String RGBHexString(this Color32 color)
	{
		return String.Format("{0:x02}{1:x02}{2:x02}", color.r, color.g, color.b);
	}

	/// <summary>
	/// 查找 Child
	/// </summary>
	/// <param name="obj">在此对象中查找</param>
	/// <param name="name">子对象名</param>
	/// <returns>子对象。未找到时返回 null</returns>
	public static GameObject FindChild(this GameObject obj, String name)
	{
		Transform child = obj.transform.Find(name);
		return child ? child.gameObject : null;
	}

	public static GameObject FindChild(this GameObject obj, params String[] childNames)
	{
		GameObject child = obj;
		for (Int32 i=0; i<childNames.Length; ++i)
		{
			child = FindChild(child, childNames[i]);
			if (child == null)
				return null;
		}
		return child;
	}

	/// <summary>
	/// 查找 Component
	/// </summary>
	/// <typeparam name="TComponent">Component 类型</typeparam>
	/// <param name="obj">在此对象中查找</param>
	/// <param name="childName">子对象名</param>
	/// <returns></returns>
	public static TComponent FindChild<TComponent>(this GameObject obj, String childName) where TComponent : Component
	{
		GameObject child = FindChild(obj, childName);
		if (child != null)
			return child.GetComponent<TComponent>();
		else
			return null;
	}

	public static TComponent FindChildComponent<TComponent>(this GameObject obj, params String[] childNames) where TComponent : Component
	{
		GameObject child = FindChild(obj, childNames);
		if (child != null)
			return child.GetComponent<TComponent>();
		else
			return null;
	}

	public static void RequireChild(this GameObject obj, out GameObject child, String name)
	{
		child = FindChild(obj, name);
		if (child == null)
			throw new Exception(String.Format("Child with name {0} not found in {1}", name, obj));
	}

	public static void RequireChild(this GameObject obj, out GameObject child, params String[] childNames)
	{
		child = FindChild(obj, childNames);
		if (child == null)
			throw new Exception(String.Format("Child not found in {0}", obj));
	}

	/// <summary>
	/// 查找 Component，未找到时抛出异常
	/// </summary>
	/// <typeparam name="TComponent">Component 类型</typeparam>
	/// <param name="obj"></param>
	/// <param name="component">返回的 Component</param>
	/// <param name="name"></param>
	public static void RequireChild<TComponent>(this GameObject obj, out TComponent component, String name) where TComponent : Component
	{
		TComponent child = FindChildComponent<TComponent>(obj, name);
		if (child == null)
			throw new Exception(String.Format("Component with child name {0} and type {1} not found in {2}", name, typeof(TComponent).Name, obj));
		component = child;
	}

	/// <summary>
	/// 查找 Component，未找到时抛出异常
	/// </summary>
	/// <typeparam name="TComponent">Component ����</typeparam>
	/// <param name="obj"></param>
	/// <param name="component">���ص� Component</param>
	/// <param name="childNames"></param>
	public static void RequireChild<TComponent>(this GameObject obj, out TComponent component, params String[] childNames) where TComponent : Component
	{
		TComponent child = FindChildComponent<TComponent>(obj, childNames);
		if (child == null)
		{
			String lastChildName = "";
			if (childNames != null && childNames.Length > 0)
				lastChildName = childNames[childNames.Length-1];
			throw new Exception(String.Format("Component with type {0} (last child name: {1}) not found in {2}", typeof(TComponent).Name, lastChildName, obj));
		}
		component = child;
	}

    public static GameObject FindChildGameObjectRecursively(this GameObject obj, String name, string ignoreName = null)
    {
        var objname = obj.name;

        if (ignoreName != null && objname == ignoreName)
            return null;

        if (objname == name)
            return obj;

        var trans = obj.transform;

        for (Int32 i = 0; i < trans.childCount; ++i)
        {
            var child = FindChildGameObjectRecursively(trans.GetChild(i).gameObject, name, ignoreName);
            if (child != null)
                return child;
        }

        return null;
    }

    public static GameObject FindChildRecursively(this GameObject obj, String name)
	{
		if (obj.name == name)
			return obj;

		for (Int32 i=0; i<obj.transform.childCount; ++i)
		{
			var child = FindChildRecursively(obj.transform.GetChild(i).gameObject, name);
			if (child != null)
				return child;
		}
		
		return null;
	}

	public static TComponent FindChildComponentRecursively<TComponent>(this GameObject obj, String childName) where TComponent : Component
	{
		GameObject child = FindChildRecursively(obj, childName);
		if (child != null)
			return child.GetComponent<TComponent>();
		else
			return null;
	}


    public static Texture2D GenAlphaTexFromJPG(byte[] jpgdata, byte[] alpha_data)
    {
        if (jpgdata == null || alpha_data == null)
            return null;

        Texture2D tex = new Texture2D(0, 0, TextureFormat.RGB24, false);
        if (!tex.LoadImage(jpgdata))
        {
            return null;
        }

        Color32[] data = tex.GetPixels32();
        int size = data.Length;

        if (alpha_data.Length != size)
        {
            UnityEngine.Object.Destroy(tex);
            return null;
        }

        for (int i = 0; i < size; i++)
        {
            data[i].a = alpha_data[i];
        }

        Texture2D texnew = new Texture2D(tex.width, tex.height, TextureFormat.ARGB32, false);
        texnew.SetPixels32(data);
        texnew.Apply();
        UnityEngine.Object.Destroy(tex);
        return texnew;
    }

    public static String FormatGameObjectPath(GameObject obj)
    {
        StringBuilder strBuilder = new StringBuilder();
        AppendGameObjectPath(strBuilder, obj);
        return strBuilder.ToString();
    }

    private static void AppendGameObjectPath(StringBuilder strBuilder, GameObject obj)
    {
        Transform parent = obj.transform.parent;
        if (parent != null)
        {
            AppendGameObjectPath(strBuilder, parent.gameObject);
            strBuilder.Append(".");
        }

        strBuilder.Append(obj.name);
    }

    public static String FormatObjectTree(GameObject obj)
    {
        StringBuilder strBuilder = new StringBuilder();
        FormatObjectTree_internal(strBuilder, obj, -1, 0);
        return strBuilder.ToString();
    }
    public static String FormatObjectTree(GameObject obj, Int32 maxDepth)
    {
        StringBuilder strBuilder = new StringBuilder();
        FormatObjectTree_internal(strBuilder, obj, maxDepth, 0);
        return strBuilder.ToString();
    }

    private static void FormatObjectTree_internal(StringBuilder strBuilder, GameObject obj, Int32 maxDepth, Int32 curDepth)
    {
        strBuilder.Append(new String(' ', curDepth * 2));
        if (obj == null)
        {
            strBuilder.Append("(null)");
        }
        else
        {
            FormatObject(strBuilder, obj);
        }
        strBuilder.Append("\n");

        if (obj && (maxDepth < 0 || curDepth < maxDepth))
        {
            foreach (Transform transform in obj.transform)
            {
                GameObject childObj = transform.gameObject;
                FormatObjectTree_internal(strBuilder, childObj, maxDepth, curDepth + 1);
            }
        }
    }

    private static void FormatObject(StringBuilder strBuilder, GameObject obj)
    {
        strBuilder.AppendFormat("{0} ({1})", obj.name, obj.transform.position);
    }
}
