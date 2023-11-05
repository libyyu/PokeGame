using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class ChatData
{
    public string text;
    public float h;
}

public class TestChat : MonoBehaviour
{
    public Button sendTxt;
    public Button goLast;
    private ChatScroll cScroll;
    private ScrollRect scroll;
    
    public ScrollData<ChatData> chatData;
    private int count;          //测试用，发新消息条数
    private bool goFirsh;
    void Start()
    {
        count = 0;
        goFirsh = false;
        chatData = new ScrollData<ChatData>();
        cScroll = this.GetComponent<ChatScroll>();
        sendTxt.onClick.AddListener(OnSendTxt);
        goLast.onClick.AddListener(OnGoLast);
        InitData();
        scroll = this.GetComponent<ScrollRect>();
    }
    
    void Update()
    {
        GoFirsh();
    }

    private void InitData()
    {
        ChatData[] arr = new ChatData[5];
        for (int i = 0; i < 5; ++i)
        {
            ChatData temp = new ChatData();
            temp.text = "0000000000" + i.ToString();
            temp.h = UnityEngine.Random.Range(0, 50);
            arr[i] = temp;
        }
        chatData.AddData(arr);
    }

    private void OnSendTxt()
    {
        ChatData data = new ChatData();
        data.text = "新消息" + count.ToString();
        data.h = UnityEngine.Random.Range(0, 50);
        count++;
        //TODO---更新网络数据
       // chatData.AddData(data);
        goFirsh = true;
        
        StartCoroutine("GoBottom");
        
        cScroll.AddFirstItem(data);
    }

    private IEnumerable GoBottom()
    {
        float curPos = scroll.verticalNormalizedPosition;
        if (curPos != 0)
        {
            curPos -= 0.1f;
            if (curPos <= 0)
            {
                curPos = 0;
                goFirsh = false;
            }
            scroll.verticalNormalizedPosition = curPos;
            yield return 0;
        }
    }

    private void OnGoLast()
    {
        if (goFirsh)
            goFirsh = false;
        else
            goFirsh = true;
    }

    private void GoFirsh()
    {
        if (!goFirsh)
            return;
        
        float curPos = scroll.verticalNormalizedPosition;
        if (curPos != 0)
        {
            curPos -= 0.01f;
            if (curPos <= 0)
            {
                curPos = 0;
                goFirsh = false;
            }
            scroll.verticalNormalizedPosition = curPos;
        }
    }
}
