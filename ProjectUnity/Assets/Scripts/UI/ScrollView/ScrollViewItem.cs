using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class ScrollViewItem : MonoBehaviour
{
    private RectTransform viewRect;
    private RectTransform rect;

    [SerializeField]
    private float viewStart;
    [SerializeField]
    private float viewEnd;
    [SerializeField]
    private Vector3[] rectCorners;

    public Action onAddHead;
    public Action onRemoveHead;
    public Action onAddEnd;
    public Action onRemoveEnd;

    void Start()
    {
        Init();
    }

    public void Init()
    {
        viewRect = transform.parent.parent.GetComponent<RectTransform>();
        rect = this.GetComponent<RectTransform>();
        rectCorners = new Vector3[4];
        viewRect.GetWorldCorners(rectCorners);
        viewStart = rectCorners[1].y;
        viewEnd = rectCorners[0].y;
    }

    void Update()
    {
        OnRecyclingItem();
    }

    //超界变false；
    private void OnRecyclingItem()
    {
        rect = this.GetComponent<RectTransform>();
        rectCorners = new Vector3[4];
        rect.GetWorldCorners(rectCorners);

        if (IsFirst())
        {
            if (rectCorners[0].y > viewStart)
            {
                //隐藏头节点  
                if (onRemoveHead != null)
                    onRemoveHead();
            }

            if (rectCorners[1].y < viewStart)
            {
                //添加头节点-头节点不为数据起始点
                if (onAddHead != null)
                    onAddHead();
            }
        }

        if (IsLast())
        {
            if (rectCorners[0].y > viewEnd)
            {
                //添加尾节点-尾节点不为数据末尾 
                if (onAddEnd != null)
                    onAddEnd();
            }

            if (rectCorners[1].y < viewEnd)
            {
                //隐藏尾节点 
                if (onRemoveEnd != null)
                    onRemoveEnd();
            }
        }
    }

    private bool IsFirst()
    {
        for (int i = 0; i < transform.parent.childCount; ++i)
        {
            Transform tf = transform.parent.GetChild(i);
            if (tf.gameObject.activeSelf)
            {
                if (tf == this.transform)
                {
                    return true;
                }
                break;
            }
        }
        return false;
    }

    private bool IsLast()
    {
        for (int i = transform.parent.childCount-1; i >= 0 ; i--)
        {
            Transform tf = transform.parent.GetChild(i);
            if (tf.gameObject.activeSelf)
            {
                if (tf == this.transform)
                {
                    return true;
                }
                break;
            }
        }
        return false;
    }

    public bool IsInView()
    {
        rect = this.GetComponent<RectTransform>();
        rect.GetWorldCorners(rectCorners);
        if (rectCorners[1].y > viewEnd || rectCorners[0].y < viewStart)
            return false;
        return true;
    }

    public void RefreshData(Data da)
    {
        //nameT.text = da.name;
        //inputT.text = da.text;
        //rect = this.GetComponent<RectTransform>();
        //Vector2 oldSize = rect.sizeDelta;
        //rect.sizeDelta = new Vector2(oldSize.x, 200 + da.h);
    }
}
