using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public delegate void ScrollListViewItemUpdate(GameObject item, int index);
public delegate void ScrollListViewItemRemoved(GameObject item, int index);

[RequireComponent(typeof(ScrollRect))]
public class ScrollListView : MonoBehaviour
{
    public enum ScrollDirection
    {
        Vertical,
        Horizontal,
    }

    [Tooltip("格子模板对象")]
    public GameObject scrollItemGo;

    [Header("格子模板对象")]
    public Vector2 CellSize = new Vector2(80, 80);

    private Vector2 ItemGridSize = new Vector2(0, 0);

    [Tooltip("总数量量")]
    public int itemCount = 0;

    [Tooltip("当前显示的数量")]
    public int showCount = 0;
    
    [Tooltip("滚动方向")]
    public ScrollDirection direction = ScrollDirection.Vertical;
    private ScrollDirection _last_direction = ScrollDirection.Vertical;


    [Tooltip("格子外间距")]
    public Vector2 itemPadding = new Vector2(15, 15);

    [Tooltip("行或者列数量")]
    public int cellCount = 1;
    private int _lastCellCount = 1;

    private ScrollRect scrollRectComp;
    private RectTransform viewPortTransform;
    private RectTransform contentTransform;
    private Vector3[] rectViewportCorners = new Vector3[4];
    private Vector3[] rectContentCorners = new Vector3[4];
    
    private ScrollListViewItemUpdate _onItemUpdate;
    private ScrollListViewItemRemoved _onItemRemoved;

    public ScrollListViewItemUpdate OnItemUpdate { get => _onItemUpdate; set => _onItemUpdate = value; }
    public ScrollListViewItemRemoved OnItemRemove { get => _onItemRemoved; set => _onItemRemoved = value; }

    //所有当前显示的items
    private List<GameObject> _shownItems = new List<GameObject>();
    private List<GameObject> _unusedItems = new List<GameObject>();
    //当前显示的起始索引
    private int _startIndex = -1;
    private int _endIndex = -1;

    // Start is called before the first frame update
    void Start()
    {
        scrollRectComp = GetComponent<ScrollRect>();
        viewPortTransform = scrollRectComp.GetComponent<RectTransform>();
        contentTransform = scrollRectComp.content;

        viewPortTransform.GetWorldCorners(rectViewportCorners);
        contentTransform.GetWorldCorners(rectContentCorners);

        ItemGridSize = scrollItemGo.GetComponent<RectTransform>().sizeDelta;
        RepairDirection();
    }

    // Update is called once per frame
    void Update()
    {
        if (isEmpty())
        {
            return;
        }

        /*
         * C1-----C2
         * |      |
         * |      |
         * C0-----C3
        */
        viewPortTransform.GetWorldCorners(rectViewportCorners);
        contentTransform.GetWorldCorners(rectContentCorners);

        if (_last_direction != direction)
        {
            _last_direction = direction;
            ClearAllItem();

            RepairDirection();
        }

        if (_lastCellCount != cellCount)
        {
            _lastCellCount = cellCount;
            ClearAllItem();
        }     

        //头部
        if (NeedHideHead())
        {
            for(int i=0; i < cellCount; i++) 
            {
                GameObject headObj = _shownItems[0];
                RecycleObject(headObj);
                _shownItems.RemoveAt(0);
                OnItemRemove?.Invoke(headObj, _startIndex);
                _startIndex = _shownItems.Count >0 ? _startIndex + 1 : -1;
            }
        }

        //头部需要添加
        if (NeedAddHead())
        {
            for (int i = 0; i < cellCount; i++)
            {
                GameObject obj = NewItemObject();
                obj.transform.SetAsFirstSibling();
                obj.SetActive(true);

                GameObject prev = _shownItems.Count > 0 ? _shownItems[0] : null;
                _shownItems.Insert(0, obj);
                _startIndex = _startIndex == -1 ? 0 : _startIndex - 1;
                if (_endIndex == -1) { _endIndex = _startIndex; }
                OnItemUpdate?.Invoke(obj, _startIndex);

                FixItemObjectTransform(_startIndex, obj, prev, true);

#if UNITY_EDITOR
                TestUpdateTemplate(obj, _startIndex);
                obj.name = string.Format("item_{0}", _startIndex);
#endif
            }
        }

        //尾部移除屏幕外了
        if (NeedHideTail())
        {
            int endRow, endCell;
            CalcRowAndCell(_endIndex, out endRow, out endCell);
            for(int i=0; i <= (direction == ScrollDirection.Vertical ? endCell : endRow); ++i)
            {
                GameObject tailObj = _shownItems[_shownItems.Count - 1];
                RecycleObject(tailObj);
                _shownItems.RemoveAt(_shownItems.Count - 1);
                OnItemRemove?.Invoke(tailObj, _endIndex);
                _endIndex = _endIndex >= 0 ? _endIndex - 1 : -1;
            }
        }

        //尾部需要添加新的
        if (NeedAddTail())
        {
            GameObject obj = NewItemObject();
            obj.transform.SetAsLastSibling();
            obj.SetActive(true);
            GameObject prev = _shownItems.Count > 0 ? _shownItems[_shownItems.Count - 1] : null;
            _shownItems.Add(obj);
            _endIndex++;
            if (_startIndex == -1) { _startIndex = _endIndex; }
            OnItemUpdate?.Invoke(obj, _endIndex);

            FixItemObjectTransform(_endIndex, obj, prev, false);

#if UNITY_EDITOR
            TestUpdateTemplate(obj, _endIndex);
            obj.name = string.Format("item_{0}", _endIndex);
#endif
        }

        showCount = _shownItems.Count;
    }

    public int Length()
    {
        return itemCount;
    }
    
    public int ShowingLength()
    {
        return showCount;
    }

    public bool isEmpty()
    {
        return Length() == 0;
    }

    GameObject NewItemObject()
    {
        GameObject newObject = null;
        if(_unusedItems.Count > 0)
        {
            newObject = _unusedItems[0];
            _unusedItems.RemoveAt(0);
        }
        else
        {
            //无创建新的
            newObject = GameObject.Instantiate<GameObject>(scrollItemGo, contentTransform.transform);
            RectTransform cellRectTrans = newObject.GetComponent<RectTransform>();
 
            newObject.transform.localScale = Vector3.one;
            newObject.transform.localPosition = Vector3.zero;
                          
            cellRectTrans.pivot = new Vector2(0f, 1f);
            cellRectTrans.anchorMin = new Vector2(0, 1);
            cellRectTrans.anchorMax = new Vector2(0, 1);
            cellRectTrans.anchoredPosition = Vector2.zero;
        }
        return newObject;
    }

    void RecycleObject(GameObject obj)
    {
        obj.SetActive(false);
        _unusedItems.Add(obj);
#if UNITY_EDITOR
        obj.name = "_unused_";
#endif
    }

    void FixItemObjectTransform(int index, GameObject obj, GameObject prev, bool addFront = false)
    {
        int newRow, newCell;
        CalcRowAndCell(index, out newRow, out newCell);

        Vector2 contentSize = contentTransform.rect.size;
        float itemTotalW = (cellCount - 1) * (CellSize.x + itemPadding.x) + CellSize.x;
        float itemTotalH = (cellCount - 1) * (CellSize.y + itemPadding.y) + CellSize.y;
        double offsetX = contentSize.x * 0.5 - itemTotalW * 0.5;
        double offsetY = contentSize.y * 0.5 - itemTotalH * 0.5;

        if (prev != null)
        {
            int prevRow, prevCell;
            CalcRowAndCell(addFront ? index + 1 : index - 1, out prevRow, out prevCell);

            float width = prev.GetComponent<RectTransform>().sizeDelta.x;
            float height = prev.GetComponent<RectTransform>().sizeDelta.y;
            if (direction == ScrollDirection.Vertical)
            {
                int sign = addFront ? -1 : 1;
                if (newRow == prevRow) //同一行
                    obj.transform.localPosition = prev.transform.localPosition + sign * new Vector3(itemPadding.x + width, 0, 0);
                else //开新行
                    obj.transform.localPosition = prev.transform.localPosition - sign * new Vector3((itemPadding.x + width) * (cellCount - 1), itemPadding.y + height, 0);
            }
            else
            {
                int sign = addFront ? -1 : 1;
                if (newCell == prevCell) //同一列
                    obj.transform.localPosition = prev.transform.localPosition - sign* new Vector3(0, itemPadding.y + height, 0);
                else //开新列
                    obj.transform.localPosition = prev.transform.localPosition + sign * new Vector3(itemPadding.x + width, (itemPadding.y + height) * (cellCount - 1), 0);
            }
        }
        else
        {
            if (direction == ScrollDirection.Vertical)
            {
                obj.transform.localPosition = Vector3.zero + new Vector3((float)offsetX, 0, 0);
            }
            else
            {
                obj.transform.localPosition = Vector3.zero - new Vector3(0, (float)offsetY, 0);
            }
        }

        if (direction == ScrollDirection.Vertical)
            obj.GetComponent<RectTransform>().sizeDelta = new Vector2(CellSize.x, CellSize.y);
        else
            obj.GetComponent<RectTransform>().sizeDelta = new Vector2(CellSize.x, CellSize.y);

        int endRow, endCell;
        CalcRowAndCell(_endIndex, out endRow, out endCell);
        float w = obj.GetComponent<RectTransform>().sizeDelta.x;
        float h = obj.GetComponent<RectTransform>().sizeDelta.y;
        if (direction == ScrollDirection.Vertical)
            contentTransform.sizeDelta = new Vector2(0, (h + itemPadding.y) * endRow + h);
        else
            contentTransform.sizeDelta = new Vector2((w + itemPadding.x) * endCell + w, 0);
    }

    protected void RepairDirection()
    {
        float viewportH = rectViewportCorners[1].y - rectViewportCorners[0].y;
        float viewportW = rectViewportCorners[3].x - rectViewportCorners[0].x;
        if (direction == ScrollDirection.Horizontal)
        {
            scrollRectComp.vertical = false;
            scrollRectComp.horizontal = true;

            contentTransform.pivot = new Vector2(0f, 1f);
            contentTransform.anchorMin = new Vector2(0, 0);
            contentTransform.anchorMax = new Vector2(0, 1);
            contentTransform.anchoredPosition = Vector2.zero;
            contentTransform.sizeDelta = new Vector2(viewportW, 0);
        }
        else
        {
            scrollRectComp.vertical = true;
            scrollRectComp.horizontal = false;

            contentTransform.pivot = new Vector2(0f, 1f);
            contentTransform.anchorMin = new Vector2(0, 1);
            contentTransform.anchorMax = new Vector2(1, 1);
            contentTransform.anchoredPosition = Vector2.zero;
            contentTransform.sizeDelta = new Vector2(0, viewportH);
        }
    }

    /// <summary>
    /// 清理格子对象，不清理数据
    /// </summary>
    protected void ClearAllItem()
    {
        float viewportH = rectViewportCorners[1].y - rectViewportCorners[0].y;
        float viewportW = rectViewportCorners[3].x - rectViewportCorners[0].x;

        while (_shownItems.Count > 0)
        {
            GameObject tailObj = _shownItems[_shownItems.Count - 1];
            RecycleObject(tailObj);
            _shownItems.RemoveAt(_shownItems.Count - 1);
        }
        _startIndex = _endIndex = -1;
        if (direction == ScrollDirection.Vertical)
            contentTransform.sizeDelta = new Vector2(0, viewportH);
        else
            contentTransform.sizeDelta = new Vector2(viewportW, 0);
        contentTransform.anchoredPosition3D = new Vector3(0, 0, 0);
    }

    [ExecuteInEditMode()]
    public void Clear()
    {
        ClearAllItem();
        itemCount = 0;
    }

    void CalcRowAndCell(int index, out int row, out int cell)
    {
        row = -1;
        cell = -1;
        if (isEmpty()) return;

        if (direction == ScrollDirection.Vertical)
        {
            row = index / cellCount;
            cell = index % cellCount;
        }
        else
        {
            cell = index / cellCount;
            row = index % cellCount;
        }
    }

    float GetPerGridSize()
    {
        float gridWidth = 0f;
        float contentW = viewPortTransform.sizeDelta.x;
        float contentH = viewPortTransform.sizeDelta.y;
        if (direction == ScrollDirection.Vertical)
            gridWidth = (contentW + itemPadding.x) / cellCount - itemPadding.x;
        else
            gridWidth = (contentH + itemPadding.y) / cellCount - itemPadding.y;
        return gridWidth;
    }

    /*
        * C1-----C2
        * |      |
        * |      |
        * C0-----C3
    */
    bool NeedHideHead()
    {
        if (_startIndex == -1) return false;
        if (_shownItems.Count == 0) return false;

        GameObject headObj = _shownItems[0];
        Vector3[] rectCHead = new Vector3[4];
        headObj.GetComponent<RectTransform>().GetWorldCorners(rectCHead);
        float worldH = rectCHead[1].y - rectCHead[0].y;
        float worldW = rectCHead[3].x - rectCHead[0].x;
        if (direction == ScrollDirection.Vertical)
        {
            if (rectCHead[0].y > (rectViewportCorners[1].y + worldH)) //最上边的隐藏了
            {
                return true;
            }
        }
        else
        {
            if (rectCHead[3].x < (rectViewportCorners[0].x - worldW)) //最左边的隐藏了
            {
                return true;
            }
        }
        return false;
    }

    bool NeedAddHead()
    {
        if(isEmpty()) return false;

        bool bRet = false;

        if(_startIndex > 0)
        {
            int startRow, startCell;
            CalcRowAndCell(_startIndex, out startRow, out startCell);
            if ((direction == ScrollDirection.Vertical && startCell > 0) || (direction == ScrollDirection.Horizontal && startRow >0))//当前行还没填满
            {
                bRet = true;
            }
            else
            {
                GameObject headObj = _shownItems[0];
                GameObject tailObj = _shownItems[_shownItems.Count - 1];

                Vector3[] rectCHead = new Vector3[4];
                headObj.GetComponent<RectTransform>().GetWorldCorners(rectCHead);
                Vector3[] rectCTail = new Vector3[4];
                tailObj.GetComponent<RectTransform>().GetWorldCorners(rectCTail);

                if (direction == ScrollDirection.Vertical)
                {
                    if (rectCHead[1].y <= rectViewportCorners[1].y) //最上面Item显示过边界了，需要继续添加新的
                    {
                        bRet = true;
                    }
                }
                else
                {
                    if (rectCHead[0].x >= rectViewportCorners[0].x)
                    {
                        bRet = true;
                    }
                }
            }
        }


        return bRet;
    }

    bool NeedHideTail()
    {
        if (_endIndex == -1) return false;
        if (_shownItems.Count == 0) return false;
        GameObject tailObj = _shownItems[_shownItems.Count-1];
        Vector3[] rectCTail = new Vector3[4];
        tailObj.GetComponent<RectTransform>().GetWorldCorners(rectCTail);
        if (direction == ScrollDirection.Vertical)
        {
            float worldH = rectCTail[1].y - rectCTail[0].y;
            if (rectCTail[1].y < (rectViewportCorners[0].y - worldH)) //最下边的隐藏了
            {
                return true;
            }
        }
        else
        {
            float worldW = rectCTail[3].x - rectCTail[0].x;
            if (rectCTail[0].x > (rectViewportCorners[3].x + worldW)) //最右边的隐藏了
            {
                return true;
            }
        }
        return false;
    }

    bool NeedAddTail()
    {
        if (isEmpty()) return false;

        bool bRet = false;
        float viewportH = rectViewportCorners[1].y - rectViewportCorners[0].y;
        float viewportW = rectViewportCorners[3].x - rectViewportCorners[0].x;

        if (_endIndex == -1)
        {
            if (direction == ScrollDirection.Vertical)
                bRet = viewportH > 0;
            else
                bRet = viewportW > 0;
        }
        else if (_endIndex < Length() - 1)
        {
            int endRow, endCell;
            CalcRowAndCell(_endIndex, out endRow, out endCell);
            if ((direction == ScrollDirection.Vertical && endCell < cellCount - 1) || (direction== ScrollDirection.Horizontal && endRow < cellCount - 1))//当前行还没填满
            {
                bRet = true;
            }
            else
            {
                GameObject headObj = _shownItems[0];
                GameObject tailObj = _shownItems[_shownItems.Count - 1];

                Vector3[] rectCHead = new Vector3[4];
                headObj.GetComponent<RectTransform>().GetWorldCorners(rectCHead);
                Vector3[] rectCTail = new Vector3[4];
                tailObj.GetComponent<RectTransform>().GetWorldCorners(rectCTail);

                if (direction == ScrollDirection.Vertical)
                {
                    //最下面Item显示过边界了，需要继续添加新的
                    if (rectCTail[3].y >= rectViewportCorners[3].y)
                    {
                        bRet = true;
                    }
                }
                else
                {
                    if (rectCTail[3].x <= rectViewportCorners[3].x)
                    {
                        bRet = true;
                    }
                }
            }
        }


        return bRet;
    }

#if UNITY_EDITOR
    public void TestUpdateTemplate(GameObject obj, int index)
    {
        Transform tr = obj.transform.Find("#UserName");
        if (tr == null) return;
        Text nameT = tr.GetComponent<Text>();
        if (nameT == null) return;
        nameT.text = string.Format("{0}", index);
    }


#endif
}
