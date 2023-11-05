using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Test : MonoBehaviour
{
    public Button addDataBtn;
    public Button goHeadBtn;
    public Button goLastBtn;
    
    private bool isGoHead;
    private bool isGoLast;
    
    private ScrollRect scroll;
    public ScrollData<Data> scrollData;

    void Awake()
    {
        scrollData = new ScrollData<Data>();
        InitData();
        scroll = this.GetComponent<ScrollRect>();
        addDataBtn.onClick.AddListener(AddData);
        goHeadBtn.onClick.AddListener(OnGoHead);
        goLastBtn.onClick.AddListener(OnGoLast);
        
        isGoLast = false;
        isGoHead = false;
    }


    void Update()
    {
        GoHead();
        GoLast();
    }
    
    #region 测试用
    void InitData()
    {
        int[] hArr = new int[4];
        hArr[0] = 0;
        hArr[1] = 190;
        hArr[2] = 190 * 2;
        hArr[3] = 190 * 3;
        for (int i = 0; i < 30; ++i)
        {
            Data da = new Data();
            da.name = "小紫苏" + i.ToString();
            da.text = "000000" + i.ToString();
            int index = UnityEngine.Random.Range(0, 3);
            da.h = hArr[index];
            scrollData.allDatas.Add(da);
        }
    }
    #endregion
    
    private void AddData()
    {
        int[] hArr = new int[4];
        hArr[0] = 0;
        hArr[1] = 190;
        hArr[2] = 190 * 2;
        hArr[3] = 190 * 3;
        Data[] newData = new Data[20];
        for (int i = 0; i < 20; ++i)
        {
            Data da = new Data();
            da.name = "小紫苏" + i.ToString();
            da.text = "000000" + i.ToString();
            int index = UnityEngine.Random.Range(0, 3);
            da.h = hArr[index];
            newData[i] = da;
        }
        scrollData.AddData(newData);
    }
    
    private void OnGoHead()
    {
        if (isGoHead)
            isGoHead = false;
        else
            isGoHead = true;
    }
    
    private void OnGoLast()
    {
        if (isGoLast)
            isGoLast = false;
        else
            isGoLast = true;
    }
    
    private void GoHead()
    {
        if (!isGoHead)
            return;
        
        float curPos = scroll.verticalNormalizedPosition;
        if (curPos != 1)
        {
            curPos += 0.01f;
            if (curPos >= 1)
            {
                curPos = 1;
                isGoHead = false;
            }
            scroll.verticalNormalizedPosition = curPos;
        }
    }
    
    private void GoLast()
    {
        if (!isGoLast)
            return;
        float curPos = scroll.verticalNormalizedPosition;
        if (curPos != 0)
        {
            curPos -= 0.01f;
            if (curPos <= 0)
            {
                curPos = 0;
                isGoLast = false;
            }
            scroll.verticalNormalizedPosition = curPos;
        }
    }
}
