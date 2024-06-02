using SLua;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;


public delegate void UITabBarItemUpdate(GameObject item, int index);
public delegate void UITabBarItemRemoved(GameObject item, int index);

[CustomLuaClass]
[RequireComponent(typeof(RectTransform))]
public class UITabBar : MonoBehaviour
{
    public enum ScrollDirection
    {
        Vertical,
        Horizontal,
    }

    [Tooltip("布局方向")]
    public ScrollDirection direction = ScrollDirection.Horizontal;
    private ScrollDirection _last_direction = ScrollDirection.Horizontal;

    [Tooltip("总数量量")]
    public int itemCount = 0;
    private int _last_itemCount = 0;

    [Tooltip("格子模板对象")]
    public GameObject templateItemGo = null;

    [Header("格子模板对象")]
    public Vector2 templateCellSize = new Vector2(0, 0);

    [Tooltip("格子外间距")]
    public float itemPadding = 15;
    private float _last_itemPadding = 15;

    private List<GameObject> _items = new List<GameObject>();
    private List<GameObject> _unusedItems = new List<GameObject>();
    private RectTransform contentTransform = null;
    //private Vector3[] rectContentCorners = new Vector3[4];

    private UITabBarItemUpdate _onItemUpdate;
    private UITabBarItemRemoved _onItemRemoved;

    public UITabBarItemUpdate OnItemUpdate { get => _onItemUpdate; set => _onItemUpdate = value; }
    public UITabBarItemRemoved OnItemRemove { get => _onItemRemoved; set => _onItemRemoved = value; }

    // Start is called before the first frame update
    void Start()
    {
        if (templateItemGo != null)
        {
            templateItemGo.SetActive(false);

            Vector2 ItemGridSize = templateItemGo.GetComponent<RectTransform>().sizeDelta;
            if (templateCellSize.x <= 0) templateCellSize.x = ItemGridSize.x;
            if (templateCellSize.y <= 0) templateCellSize.y = ItemGridSize.y;
        }

        contentTransform = transform.GetComponent<RectTransform>();
        //contentTransform.GetWorldCorners(rectContentCorners);
        RepairDirection();
    }

    // Update is called once per frame
    void Update()
    {
        //contentTransform.GetWorldCorners(rectContentCorners);
        if (_last_direction != direction)
        {
            _last_direction = direction;
            RepairDirection();
            UpdateItemPosition();
        }

        if(_last_itemPadding != itemPadding)
        {
            _last_itemPadding = itemPadding;
            UpdateItemPosition();
        }

        if (_last_itemCount != itemCount)
        {
            if (itemCount > _last_itemCount)
            {
                for (int i = _last_itemCount; i < itemCount; i++)
                {
                    GameObject newObject = NewItemObject();
                    _items.Add(newObject);
                }
            }
            else
            {
                for (int i = _last_itemCount-1; i >= itemCount; i--)
                {
                    GameObject obj = _items[i];
                    _items.RemoveAt(i);
                    _unusedItems.Add(obj);

                    OnItemRemove?.Invoke(obj, i);
                }
            }

             _last_itemCount = itemCount;

            if (itemCount > 0)
            {
                UpdateItemPosition();
            }

            for (int i = 0; i < itemCount; i++)
            {
                GameObject obj = _items[i];
                OnItemUpdate?.Invoke(obj, i);
            }
        }
    }

    public int Length()
    {
        return itemCount;
    }

    public bool isEmpty()
    {
        return Length() == 0;
    }

    GameObject NewItemObject()
    {
        GameObject newObject = null;
        if (_unusedItems.Count > 0)
        {
            newObject = _unusedItems[0];
            _unusedItems.RemoveAt(0);
        }
        else
        {
            newObject = GameObject.Instantiate<GameObject>(templateItemGo, transform);
            RectTransform cellRectTrans = newObject.GetComponent<RectTransform>();

            newObject.transform.localScale = Vector3.one;
            newObject.transform.localPosition = Vector3.zero;

            cellRectTrans.pivot = new Vector2(0.5f, 0.5f);
            cellRectTrans.anchorMin = new Vector2(0.5f, 0.5f);
            cellRectTrans.anchorMax = new Vector2(0.5f, 0.5f);
            cellRectTrans.anchoredPosition = Vector2.zero;
        }
        newObject.SetActive(true);
        return newObject;
    }

    public void UpdateItemPosition()
    {
        for (int i = 0; i < itemCount; i++)
        {
            Vector2 pos;
            CalcItemPosition(i, out pos);
            GameObject obj = _items[i];
            //obj.transform.localPosition = new Vector3(pos.x, pos.y, 0);
            obj.GetComponent<RectTransform>().anchoredPosition = new Vector3(pos.x, pos.y, 0);
            //obj.GetComponent<RectTransform>().sizeDelta = new Vector2(templateCellSize.x, templateCellSize.y);
            //Debug.Log(string.Format("pos: {0}{1} {2}", i, pos, obj.transform.localPosition));
        }
    }

    void RepairDirection()
    {
        //float viewportH = rectContentCorners[1].y - rectContentCorners[0].y;
        //float viewportW = rectContentCorners[3].x - rectContentCorners[0].x;
        //if (direction == ScrollDirection.Horizontal)
        //{
        //    contentTransform.pivot = new Vector2(0f, 0f);
        //    contentTransform.anchorMin = new Vector2(0, 0);
        //    contentTransform.anchorMax = new Vector2(1, 0);
        //    contentTransform.anchoredPosition = Vector2.zero;
        //}
        //else
        //{
        //    contentTransform.pivot = new Vector2(0f, 1f);
        //    contentTransform.anchorMin = new Vector2(0, 0);
        //    contentTransform.anchorMax = new Vector2(1, 1);
        //    contentTransform.anchoredPosition = Vector2.zero;
        //}
    }


    void CalcItemPosition(int index, out Vector2 pos)
    {
        pos = new Vector2(0, 0);

        Vector2 Size = contentTransform.rect.size;

        //itemCount* templateCellSize.x + (itemCount+1)*gap = Size.x

        float center = (itemCount-1) * 1.0f / 2;

        if (direction == ScrollDirection.Vertical)
        {
            float gap = (Size.y - itemCount * templateCellSize.y) * 1.0f / (itemCount + 1);

            float span = templateCellSize.y;
            //           pos.y = (index * 1.0f - center) * span;
            pos.y = (index * 1.0f - center) * gap * 2;
        }
        else
        {
            float gap = (Size.x - itemCount * templateCellSize.x) * 1.0f / (itemCount + 1);
//            pos.x = (index - 1) * gap;
            pos.x = (index * 1.0f - center) * gap * 2;

            //Debug.Log(string.Format("gap: {0}  {1}  {2}", index, gap, center));
        }
    }
}
