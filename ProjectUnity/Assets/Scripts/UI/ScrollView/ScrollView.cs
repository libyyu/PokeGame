using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SLua;

public enum ScrollType
{
    UP,
    DOWN,
    LEFT,
    RIGHT
}

public delegate void ScrollViewItemUpdate(GameObject item);
public delegate void ScrollViewItemRemoved(GameObject item);


[RequireComponent(typeof(ScrollRect))]
public class ScrollView : MonoBehaviour
{
    public GameObject scrollItemGo;
    public float spacing = 15;

    private RectTransform content;
    private bool isStart = true;

    private ScrollData<LuaTable> scrollData = new ScrollData<LuaTable>();

    /// <summary>
    /// 列表项更新的回调
    /// </summary>
    private ScrollViewItemUpdate _onItemUpdate;
    private ScrollViewItemRemoved _onItemRemoved;

    void Start()
    {
        content = this.GetComponent<ScrollRect>().content;
        OnAddHead();
    }

    /// <summary>
    /// 列表渲染回调
    /// </summary>
    public ScrollViewItemUpdate OnItemUpdate { get => _onItemUpdate; set => _onItemUpdate = value; }
    public ScrollViewItemRemoved OnItemRemove { get => _onItemRemoved; set => _onItemRemoved = value; }

    private GameObject GetChildItem()
    {
        //查找是否有未回收的子节点
        for (int i = 0; i < content.childCount; ++i)
        {
            GameObject tempGo = content.GetChild(i).gameObject;
            if (!tempGo.activeSelf && tempGo != scrollItemGo)
            {
                tempGo.SetActive(true);
                return tempGo;
            }
        }

        //无创建新的
        GameObject childItem = GameObject.Instantiate<GameObject>(scrollItemGo, content.transform);
        ScrollViewItem scrollItem = childItem.GetComponent<ScrollViewItem>();
        if (scrollItem == null)
            scrollItem = childItem.AddComponent<ScrollViewItem>();
        
        scrollItem.onAddHead += OnAddHead;
        scrollItem.onRemoveHead += OnRemoveHead;
        scrollItem.onAddEnd += OnAddEnd;
        scrollItem.onRemoveEnd += OnRemoveEnd;
        scrollItem.Init();

        childItem.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 1);
        childItem.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 1);
        childItem.GetComponent<RectTransform>().pivot = new Vector2(0, 1);
        
        childItem.transform.localScale = Vector3.one;
        childItem.transform.localPosition = Vector3.zero;
        
        //-----设置宽高——加载数据 
        return childItem;
    }

    private void OnAddHead()
    {
        LuaTable data = scrollData.GetHeadData();

        if (data != null)
        {
            Transform first = FindFirst();
            //----first 不为 数据头---在data中做了
            GameObject obj = GetChildItem();
            obj.transform.SetAsFirstSibling();

            if (null != OnItemUpdate)
            {
                OnItemUpdate.Invoke(obj);
            }

            RectTransform objRect = obj.GetComponent<RectTransform>();
            //float height = objRect.sizeDelta.y;

            //if (first != null)
            //{
            //    obj.transform.localPosition = first.localPosition + new Vector3(0, height + spacing, 0);
            //}

            //if (isStart)
            //{
            //    content.sizeDelta += new Vector2(0, height + spacing);
            //    isStart = false;
            //}

            float totalHeight = 0;
            Transform prev = null;
            for (int i = 0; i < content.childCount; ++i)
            {
                var tr = content.GetChild(i);
                if (tr.gameObject != scrollItemGo)
                {
                    if (prev != null)
                    {
                        float height = prev.GetComponent<RectTransform>().sizeDelta.y;
                        tr.localPosition = prev.localPosition - new Vector3(0, height + spacing, 0);
                    }
                    else
                    {
                        tr.localPosition.Set(tr.localPosition.x, 0, 0);
                    }
                    prev = tr;

                    totalHeight += tr.GetComponent<RectTransform>().sizeDelta.y + spacing;
                }
            }

            content.sizeDelta = new Vector2(content.sizeDelta.x, totalHeight+spacing);
        }
    }

    private void OnRemoveHead()
    {
        if (scrollData.RemoveHeadData())
        {
            Transform tf = FindFirst();
            if (tf != null)
            {
                tf.gameObject.SetActive(false);
                OnItemRemove?.Invoke(tf.gameObject);
            }
        }
    }

    private void OnAddEnd()
    {
        LuaTable data = scrollData.GetEndData();

        if (data != null)
        {
            Transform end = FindEnd();
            //----end 不为 数据尾在data中做了
            GameObject obj = GetChildItem();

            obj.transform.SetAsLastSibling();

            if (null != OnItemUpdate)
            {
                OnItemUpdate.Invoke(obj);
            }

            if (end != null)
            {
                float height = end.GetComponent<RectTransform>().sizeDelta.y;
                obj.transform.localPosition = end.localPosition - new Vector3(0, height + spacing, 0);
            }

            //是否增加content高度
            if (IsAddContentH(obj.transform))
            {
                float h = obj.GetComponent<RectTransform>().sizeDelta.y;
                content.sizeDelta += new Vector2(0, h + spacing);
            }

            //float totalHeight = 0;
            //for (int i = 0; i < content.childCount; ++i)
            //{
            //    var tr = content.GetChild(i);
            //    if (tr.gameObject != scrollItemGo)
            //    {
            //        totalHeight += tr.GetComponent<RectTransform>().sizeDelta.y + spacing;
            //    }
            //}
            //content.sizeDelta = new Vector2(content.sizeDelta.x, totalHeight + spacing);
        }
    }

    private void OnRemoveEnd()
    {
        if (scrollData.RemoveEndData())
        {
            Transform tf = FindEnd();
            if (tf != null)
            {
                tf.gameObject.SetActive(false);
                OnItemRemove?.Invoke(tf.gameObject);
            }
        }
    }

    private Transform FindFirst()
    {
        for (int i = 0; i < content.childCount; ++i)
        {
            var tr = content.GetChild(i);
            if (tr.gameObject.activeSelf && tr.gameObject != scrollItemGo)
            {
                return tr;
            }
        }
        return null;
    }

    private Transform FindEnd()
    {
        for (int i = content.childCount - 1; i >= 0; --i)
        {
            var tr = content.GetChild(i);
            if (tr.gameObject.activeSelf && tr.gameObject != scrollItemGo)
            {
                return tr;
            }
        }
        return null;
    }
    
    private bool IsAddContentH(Transform tf)
    {
        Vector3[] rectC = new Vector3[4];
        Vector3[] contentC = new Vector3[4];
        tf.GetComponent<RectTransform>().GetWorldCorners(rectC);
        content.GetWorldCorners(contentC);
        if (rectC[0].y < contentC[0].y)
            return true;
        return false;
    }

    public bool IsEmpty()
    {
        return Length() == 0;
    }
    public int Length()
    {
        return scrollData.Length;
    }

    public void AddDataList(List<LuaTable> datas)
    {
        scrollData.AddData(datas);
        OnAddEnd();
    }
    public void AddDataTail(LuaTable data)
    {
        scrollData.AddTail(data);
        OnAddEnd();
    }
    public void AddDataFront(LuaTable data)
    {
        scrollData.AddFront(data);
        OnAddHead();
    }

    public void InitTest()
    {
        List<LuaTable> datas = new List<LuaTable>();
        for (int i = 0; i < 3; ++i)
        {
            LuaTable t = new LuaTable(LuaState.main);
            datas.Add(t);
        }
        AddDataList(datas);
    }
    public void AddTailTest()
    {
        LuaTable t = new LuaTable(LuaState.main);
        AddDataTail(t);
    }
    public void AddFrontTest()
    {
        LuaTable t = new LuaTable(LuaState.main);
        AddDataFront(t);
    }
}


