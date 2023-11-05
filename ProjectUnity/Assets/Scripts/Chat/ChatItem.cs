using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class ChatItem : MonoBehaviour
{
    private RectTransform rect;             
    private RectTransform viewRect;         //viewport组件
    private ChatScroll cScroll;             //scrollview脚本
    private float spacing;                  //子物体间隔   
    private float sizeH = 62;

    [SerializeField] private float viewStart;
    [SerializeField] private float viewEnd;
    [SerializeField] private Vector3[] rectCorners;

    public Text inputTxt;

    public Action OnAddLast;
    public Action OnAddFirst;
    public Action OnRemoveFirst;
    public Action OnRemoveLast;

    void Start()
    {
        viewRect = transform.parent.parent.GetComponent<RectTransform>();
        rect = this.GetComponent<RectTransform>();
        rectCorners = new Vector3[4];
        viewRect.GetWorldCorners(rectCorners);
        viewEnd = rectCorners[1].y;
        viewStart = rectCorners[0].y;
        cScroll = viewRect.parent.GetComponent<ChatScroll>();
        spacing = cScroll.spacing;
    }
    
    void Update()
    {
        RcycleScroll();
    }

    private void RcycleScroll()
    {
        float height = rect.sizeDelta.y;
        rectCorners = new Vector3[4];
        rect.GetWorldCorners(rectCorners);
        //最上方为空
        if (IsFirst())
        {
            if (rectCorners[0].y > viewStart + spacing)
            {
                if (Mathf.Abs(rectCorners[0].y - viewStart - spacing) > 0.1f)
                {
                    //添加头节点-头节点不为数据起始点
                    if (OnAddFirst != null)
                        OnAddFirst();
                }
            }
            if (rectCorners[1].y < viewStart)
            {
                //隐藏头节点  
                if (OnRemoveFirst != null)
                    OnRemoveFirst();
            }
        }

        //最下方为空
        if (IsLast())
        {
            if (rectCorners[1].y < viewEnd - spacing)
            {
                //添加尾节点-尾节点不为数据末尾 
                if (OnAddLast != null)
                    OnAddLast();
            }
            
            if (rectCorners[0].y > viewEnd)
            {
                //隐藏尾节点 
                if (OnRemoveLast != null)
                    OnRemoveLast();
            }
        }
    }

    //更新数据
    public void RefreshItem(ChatData perDa)
    {
        inputTxt.text = perDa.text;
        Vector2 size = GetComponent<RectTransform>().sizeDelta;
        GetComponent<RectTransform>().sizeDelta = new Vector2(size.x, sizeH + perDa.h);
    }
    

    //判断是否为底部物体
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
    
    //判断是否为顶部物体
    public bool IsLast()
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
}
