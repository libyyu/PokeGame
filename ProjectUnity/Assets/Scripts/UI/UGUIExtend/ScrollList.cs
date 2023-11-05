using SLua;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public delegate void ItemUpdate(int index, GameObject item);

[RequireComponent(typeof(ScrollRect))]
[RequireComponent(typeof(RectTransform))]
public class ScrollList : MonoBehaviour
{
    public enum ELayoutType
    {
        /// <summary>
        /// 垂直列表
        /// </summary>
        Vertical,
        /// <summary>
        /// 横向列表
        /// </summary>
        Horzontal,
    }

    /// <summary>
    /// 布局方式
    /// </summary>
    public ELayoutType layoutType = ELayoutType.Vertical;

    /// <summary>
    /// 列表项的间隔
    /// </summary>
    public Vector2 itemGap = Vector2.zero;

    /// <summary>
    /// 滚动组件
    /// </summary>
    public ScrollRect scrollRect;

    /// <summary>
    /// 内存组件
    /// </summary>
    RectTransform contentRectTransform;

    /// <summary>
    /// 列表项的Prefab
    /// </summary>
    public GameObject itemPrefab;

    /// <summary>
    /// 列表项的大小
    /// </summary>
    Vector2 _itemSize;

    /// <summary>
    /// 列表视口大小
    /// </summary>
    Vector2 _viewPortSize;

    /// <summary>
    /// 单行或单列对象最大数量
    /// </summary>
    private int countCal;

    /// <summary>
    /// 单行或单列对象最大数量
    /// </summary>
    public int itemCount;

    /// <summary>
    /// 行距或列距
    /// </summary>
    public float spacing = -1;

    /// <summary>
    /// 视口可见的最大列表项数量
    /// </summary>
    int _itemMaxCount;

    /// <summary>
    /// 列表项更新的回调
    /// </summary>
    ItemUpdate _onItemUpdate;

    /// <summary>
    /// 列表项占用的x轴空间
    /// </summary>
    float _itemSpace_x = 0;

    /// <summary>
    /// 列表项占用的y轴空间
    /// </summary>
    float _itemSpace_y = 0;

    /// <summary>
    /// item的缓存池
    /// </summary>
    Queue<GameObject> _itemPool = new Queue<GameObject>();
    /// <summary>
    /// gameobj销毁缓存池
    /// </summary>
    Queue<GameObject> _itemDestoryPool = new Queue<GameObject>();
    /// <summary>
    /// 正在显示的列表项
    /// </summary>
    Dictionary<int, GameObject> _showedDic = new Dictionary<int, GameObject>();

    /// <summary>
    /// 当前正在显示的item项
    /// </summary>
    public List<GameObject> curShowObj
    {
        get
        {
            return new List<GameObject>(_showedDic.Values);
        }
    }

    [DoNotToLua]
    public int itemNum;

    /// <summary>
    /// 对象数量
    /// </summary>
    public int ItemNum
    {
        get
        {
            return itemNum;
        }
        set
        {
            itemNum = value;
            switch (layoutType)
            {
                case ELayoutType.Vertical:
                    SetContentSize((_itemSpace_y * Mathf.CeilToInt(itemNum * 1f / itemCount)) - itemGap.y);
                    break;
                case ELayoutType.Horzontal:
                    SetContentSize((_itemSpace_x * Mathf.CeilToInt(itemNum * 1f / itemCount)) - itemGap.x);
                    break;
            }
            RefreshList();
        }
    }

    private void InitHorzontal()
    {
        if (itemCount <= 0)
        {
            itemCount = 1;
        }
        float y = (Mathf.Abs(_viewPortSize.y) - itemCount * _itemSize.y) / (itemCount + 1);
        itemGap = new Vector2(spacing < 0 ? y : spacing, y);
        _itemSpace_x = _itemSize.x + itemGap.x;
        _itemSpace_y = _itemSize.y + itemGap.y;
        countCal = Mathf.CeilToInt(Mathf.Abs(_viewPortSize.x) / _itemSpace_x) + 1;
        _itemMaxCount = itemCount * countCal;
    }

    private void InitVertical()
    {
        if (itemCount <= 0)
        {
            itemCount = 1;
        }
        float x = (Mathf.Abs(_viewPortSize.x) - itemCount * _itemSize.x) / (itemCount + 1);
        itemGap = new Vector2(x, spacing < 0 ? x : spacing);
        _itemSpace_y = _itemSize.y + itemGap.y;
        _itemSpace_x = _itemSize.x + itemGap.x;
        countCal = Mathf.CeilToInt(Mathf.Abs(_viewPortSize.y) / _itemSpace_y) + 1;
        _itemMaxCount = countCal * itemCount;
    }

    /// <summary>
    /// 列表渲染回调
    /// </summary>
    public ItemUpdate OnItemUpdate { get => _onItemUpdate; set => _onItemUpdate = value; }

    /// <summary>
    /// 对象GameObject
    /// </summary>
    private void InitItemPrefab()
    {
        var rt = itemPrefab.GetComponent<RectTransform>();
        _itemSize = rt.rect.size;
        var topLeft = new Vector2(0, 1);
        rt.pivot = topLeft;
        rt.anchorMin = topLeft;
        rt.anchorMax = topLeft;
        itemPrefab.SetActive(false);
        Init();
    }

    private void Awake()
    {
        scrollRect = GetComponent<ScrollRect>();
        if (null == scrollRect)
        {
            throw new Exception("can't find component ScrollRect");
        }
        scrollRect.vertical = layoutType == ELayoutType.Vertical;
        scrollRect.horizontal = layoutType == ELayoutType.Horzontal;
        contentRectTransform = scrollRect.content;
        if (layoutType == ELayoutType.Vertical)
        {
            scrollRect.viewport.offsetMax = new Vector2(0, -spacing);
            contentRectTransform.anchorMin = Vector2.up;
            contentRectTransform.anchorMax = Vector2.one;
        }
        else
        {
            scrollRect.viewport.offsetMin = new Vector2(spacing, 0);
            contentRectTransform.anchorMin = Vector2.zero;
            contentRectTransform.anchorMax = Vector2.up;
        }
        _viewPortSize = GetComponent<RectTransform>().sizeDelta;

        InitItemPrefab();
    }

    private void Start()
    {
        ItemNum = itemNum;
        RefreshList();
    }

    private void Init()
    {
        switch (layoutType)
        {
            case ELayoutType.Vertical:
                InitVertical();
                break;
            case ELayoutType.Horzontal:
                InitHorzontal();
                break;
        }
    }

    public void SetItemGap(Vector2 gap)
    {
        itemGap = gap;
        Init();
        ItemNum = itemNum;
    }

    private void OnEnable()
    {
        scrollRect.onValueChanged.AddListener(OnScroll);
    }

    /// <summary>
    /// 显示指定索引位置的列表项
    /// </summary>
    /// <param name="idx"></param>
    public void ShowItem(int idx)
    {
        var pos = layoutType == ELayoutType.Vertical ? _itemSpace_y * (idx / itemCount) : _itemSpace_x * (idx / itemCount);
        SetContentPos(pos);
        RefreshUI();
    }

    void SetContentSize(float size)
    {
        var contentSize = contentRectTransform.sizeDelta;

        switch (layoutType)
        {
            case ELayoutType.Vertical:
                contentSize.y = size;
                break;
            case ELayoutType.Horzontal:
                contentSize.x = size;
                break;
        }

        contentRectTransform.sizeDelta = contentSize;
    }

    /// <summary>
    /// 设置显示位置的y轴坐标
    /// </summary>
    /// <param name="pos"></param>
    public void SetContentPos(float pos)
    {
        var contentPos = contentRectTransform.localPosition;

        switch (layoutType)
        {
            case ELayoutType.Vertical:
                float _contentMax_y = contentRectTransform.rect.height - _viewPortSize.y;
                if (_contentMax_y < 0)
                {
                    _contentMax_y = 0;
                }
                if (pos > _contentMax_y)
                {
                    pos = _contentMax_y;
                }
                contentPos.y = pos;
                break;
            case ELayoutType.Horzontal:
                float _contentMax_x = contentRectTransform.rect.width - _viewPortSize.x;
                if (_contentMax_x < 0)
                {
                    _contentMax_x = 0;
                }
                if (pos > _contentMax_x)
                {
                    pos = _contentMax_x;
                }
                contentPos.x = -1 * pos;
                break;
        }
        contentRectTransform.localPosition = contentPos;
    }

    private void OnDisable()
    {
        scrollRect.onValueChanged.RemoveListener(OnScroll);
    }

    private void OnScroll(Vector2 v)
    {
        RefreshUI();
    }

    /// <summary>
    /// 刷新列表显示
    /// </summary>
    public void RefreshList()
    {
        foreach (var item in _showedDic)
        {
            item.Value.gameObject.SetActive(false);
            _itemDestoryPool.Enqueue(item.Value.gameObject);
        }
        _showedDic.Clear();
        RefreshUI();
    }

    /// <summary>
    /// 刷新界面
    /// </summary>
    private void RefreshUI()
    {
        float localPos;
        int startIdx;
        if (layoutType == ELayoutType.Vertical)
        {
            float offset = (_itemMaxCount - 1) * _itemSpace_y - _viewPortSize.y;
            localPos = contentRectTransform.localPosition.y - offset;
            startIdx = Mathf.FloorToInt(localPos / _itemSpace_y) * itemCount;
        }
        else
        {
            float offset = (_itemMaxCount - 1) * _itemSpace_x - _viewPortSize.x;
            localPos = -1 * contentRectTransform.localPosition.x - offset;
            startIdx = Mathf.FloorToInt(localPos / _itemSpace_x) * itemCount;
        }

        //显示开始的索引
        //int startIdx = Mathf.FloorToInt(localPos / _itemSpace);
        if (startIdx < 0)
        {
            startIdx = 0;
        }

        //Item显示开始的位置      
        Vector2 pos = layoutType == ELayoutType.Vertical ? new Vector2(0f, startIdx * _itemSpace_y) : new Vector2(0f, startIdx * _itemSpace_x);

        int endIdx = startIdx + _itemMaxCount;
        if (endIdx > itemNum)
        {
            endIdx = itemNum;
        }

        HashSet<int> updateNeedlessSet = new HashSet<int>();
        Dictionary<int, GameObject> showedDic = new Dictionary<int, GameObject>();

        //找出可以不用更新的Item
        foreach (var entry in _showedDic)
        {
            if (entry.Key >= startIdx && entry.Key < endIdx)
            {
                //不用更新的
                updateNeedlessSet.Add(entry.Key);
                showedDic.Add(entry.Key, entry.Value);
            }
            else
            {
                //加入缓存池
                _itemPool.Enqueue(entry.Value);
            }
        }

        _showedDic = showedDic;

        for (int i = startIdx; i < endIdx; i++)
        {
            if (updateNeedlessSet.Contains(i))
            {
                //已经显示的可以忽略不处理
                continue;
            }

            if (layoutType == ELayoutType.Vertical)
            {
                pos.x = i % itemCount * _itemSpace_x + itemGap.x;
                pos.y = -1 * (i / itemCount) * _itemSpace_y;
            }
            else
            {
                pos.x = (i / itemCount) * _itemSpace_x;
                pos.y = -i % itemCount * _itemSpace_y - itemGap.y;
            }

            GameObject go = CreateItem(i, pos, _itemPool);
            if (null != OnItemUpdate)
            {
                OnItemUpdate.Invoke(i, go);
            }
        }
    }

    private GameObject CreateItem(int idx, Vector2 pos, Queue<GameObject> itemPool)
    {
        GameObject item = null;
        if (itemPool.Count > 0)
        {
            item = itemPool.Dequeue();
        }
        else
        {
            if (_itemDestoryPool.Count > 0)
            {
                item = _itemDestoryPool.Dequeue();
            }
            else
            {
                item = GameObject.Instantiate(itemPrefab, contentRectTransform);
            }
            item.name = "item" + idx;
        }

        _showedDic.Add(idx, item);
        item.transform.localPosition = pos;
        item.SetActive(true);
        return item;
    }

    /// <summary>
    /// 获取指定位置的GameObject
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    public GameObject GetChildAt(int index)
    {
        if (_showedDic.ContainsKey(index))
        {
            return _showedDic[index].gameObject;
        }
        else
        {
            ShowItem(index);
            return _showedDic[index].gameObject;
        }
    }
}

