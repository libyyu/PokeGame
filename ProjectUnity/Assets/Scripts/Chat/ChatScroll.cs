using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatScroll : MonoBehaviour
{
    private ScrollRect scroRect;
    private Transform content;              
    public float spacing;                   //间隔
    public GameObject chatItem;             //子物体
    private Vector3 contPos;                //content初始位置
    private Vector3[] corners;              //存ui四个角坐标，世界
    private RectTransform viewRect;         //显示界面viewPort
    [SerializeField] 
    private float viewStart;                //viewPort底部位置
    [SerializeField] 
    private float viewEnd;                  //viewPort顶部位置
    private TestChat testC;                 //数据脚本
    private RectTransform contentR;         //content组件
    private bool outSizeFirst = false;      //顶部是否超界
    
    void Start()
    {
        corners = new Vector3[4];
        viewRect = GetComponent<RectTransform>();
        viewRect.GetWorldCorners(corners);
        viewStart = corners[0].y;
        viewEnd = corners[1].y;
        testC = GetComponent<TestChat>();
        scroRect = this.GetComponent<ScrollRect>();
        content = scroRect.content;
        contentR = content.GetComponent<RectTransform>();
        contPos = content.position;
        spacing = 15;
        AddFirstItem();
        //加载data数据
    }

    //当向上滑动时调用-加载上方子物体
    private void AddLastItem()
    {
        ChatData data = testC.chatData.GetEndData();
        if (data == null)
            return;

        Transform end = FindEnd();
        GameObject obj = GetChatItem();
        obj.GetComponent<ChatItem>().RefreshItem(data);
        obj.transform.SetAsLastSibling();
        float h = obj.GetComponent<RectTransform>().sizeDelta.y;

        if (end != null)
        {
            obj.transform.position = end.position + new Vector3(0, h + spacing, 0);
        }

        if (IsNeedAddUpHigh(obj.transform))
        {
            contentR.sizeDelta += new Vector2(0, h + spacing);
            RefreshAllNode(-(h + spacing) / 2);
        }
        
    }

    private bool isStart = true;

    //向下滑动，加载向下的子物体
    private void AddFirstItem()
    {
        ChatData data = testC.chatData.GetHeadData();
        if (data == null)
            return;
        
        Transform first = FindFirst();
        GameObject obj = GetChatItem();
        obj.transform.SetAsFirstSibling();
        obj.GetComponent<ChatItem>().RefreshItem(data);

        if (first != null)
        {
            float height = first.GetComponent<RectTransform>().sizeDelta.y;
            obj.transform.position = first.position - new Vector3(0, height + spacing, 0);
        }

        if (isStart)
        {
            float h = obj.GetComponent<RectTransform>().sizeDelta.y;
            contentR.sizeDelta += new Vector2(0, h);
            obj.transform.position = content.position + new Vector3(0, h);
            isStart = false;
        }
    }

   
    //发送新消息时调用
    public GameObject AddFirstItem(ChatData data)
    {
        GameObject obj = GetChatItem();
        obj.GetComponent<ChatItem>().RefreshItem(data);
        float height = obj.GetComponent<RectTransform>().sizeDelta.y;
        obj.transform.SetAsFirstSibling();
        
        //Transform last = FindEnd();
        float h = obj.GetComponent<RectTransform>().sizeDelta.y;
        contentR.sizeDelta += new Vector2(0, h + spacing);
        RefreshNodeEcpFirst((h + spacing) / 2);
        obj.transform.position = content.position + new Vector3(0, h);
        
        return obj;
    }
    
    private void RefreshNodeEcpFirst(float h)
    {
        for (int i = 1; i < content.childCount; ++i)
        {
            Transform tf = content.GetChild(i);
            if (tf.gameObject.activeSelf)
            {
                tf.position += new Vector3(0, h, 0);
            }
        }
    }
    
    //刷新所有子物体的位置
    private void RefreshAllNode(float h)
    {
        for (int i = 0; i < content.childCount; ++i)
        {
            Transform tf = content.GetChild(i);
            if (tf.gameObject.activeSelf)
            {
                tf.position += new Vector3(0, h, 0);
            }
        }
    }

    //获取子物体，有隐藏优先隐藏，否则实例化新物体
    private GameObject GetChatItem()
    {
        for (int i = 0; i < content.childCount; ++i)
        {
            GameObject tempGo = content.GetChild(i).gameObject;
            if (!tempGo.activeSelf)
            {
                tempGo.SetActive(true);
                return tempGo;
            }
        }

        GameObject obj = GameObject.Instantiate(chatItem, content) as GameObject;
        //obj.transform.SetParent(content);
        obj.transform.localScale = Vector3.one;
        obj.transform.position = Vector3.zero;
        obj.GetComponent<RectTransform>().pivot = new Vector2(0.5f,1);

        ChatItem cIt = obj.GetComponent<ChatItem>();
        cIt.OnAddFirst += AddFirstItem;
        cIt.OnAddLast += AddLastItem;
        cIt.OnRemoveFirst += RemoveFist;
        cIt.OnRemoveLast += RemoveLast;
        return obj;
    }

    //隐藏底部出界子物体
    private void RemoveFist()
    {
        var scrollData = this.GetComponent<TestChat>().chatData;
        if (scrollData.RemoveHeadData())
        {
            Transform tf = FindFirst();
            if (tf != null)
                tf.gameObject.SetActive(false);
        }
    }

    //隐藏顶部出界子物体
    private void RemoveLast()
    {
        var scrollData = this.GetComponent<TestChat>().chatData;
        if (scrollData.RemoveEndData())
        {
            Transform tf = FindEnd();
            if (tf != null)
                tf.gameObject.SetActive(false);
        }
    }
    
    //找到显示区底部子物体
    private Transform FindFirst()
    {
        for (int i = 0; i < content.childCount; ++i)
        {
            if (content.GetChild(i).gameObject.activeSelf)
            {
                return content.GetChild(i);
            }
        }
        return null;
    }

    //找到显示顶部子物体
    private Transform FindEnd()
    {
        for (int i = content.childCount - 1; i >= 0; --i)
        {
            if (content.GetChild(i).gameObject.activeSelf)
            {
                return content.GetChild(i);
            }
        }
        return null;
    }

    private bool IsNeedAddUpHigh(Transform tf)
    {
        Vector3[] rectC = new Vector3[4];
        Vector3[] contentC = new Vector3[4];
        tf.GetComponent<RectTransform>().GetWorldCorners(rectC);
        contentR.GetWorldCorners(contentC);
        if (rectC[1].y > contentC[1].y)
            return true;
        return false;
    }
    
    private bool IsNeedAddDownHigh(Transform tf)
    {
        Vector3[] rectC = new Vector3[4];
        Vector3[] contentC = new Vector3[4];
        tf.GetComponent<RectTransform>().GetWorldCorners(rectC);
        contentR.GetWorldCorners(contentC);
        if (rectC[0].y < contentC[0].y)
            return true;
        return false;
    }
}
