using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data
{
    public string name;
    public string text;
    public float h;
}

public class ScrollData<T>
{
    public List<T> allDatas;
    public LinkedList<T> curDatas;
    public ScrollData()
    {
        allDatas = new List<T>();
        curDatas = new LinkedList<T>();
        //加载数据；
    }

    public int Length
    {
        get { return allDatas.Count; }
    }

    //获取头数据
    public T GetHeadData()
    {
        if (allDatas.Count == 0)
            return default(T);

        if (curDatas.Count == 0)
        {
            T head = allDatas[0];
            curDatas.AddFirst(head);
            return head;
        }

        T t = curDatas.First.Value;
        int index = allDatas.IndexOf(t);

        if (index != 0)
        {
            T head = allDatas[index - 1];
            curDatas.AddFirst(head);
            return head;
        }
        return default(T);
    }

    //移出头数据
    public bool RemoveHeadData()
    {
        if (curDatas.Count == 0 || curDatas.Count == 1)
            return false;
        curDatas.RemoveFirst();
        return true;
    }

    //获取尾部数据
    public T GetEndData()
    {
        if (allDatas.Count == 0)
            return default(T);

        if (curDatas.Count == 0)
        {
            T end = allDatas[0];
            curDatas.AddLast(end);
            return end;
        }

        T t = curDatas.Last.Value;
        int index = allDatas.IndexOf(t);
        
        if (index != allDatas.Count - 1)
        {
            T end = allDatas[index + 1];
            curDatas.AddLast(end);
            return end;
        }
         
        return default(T);
    }
    
    //移出尾部数据
    public bool RemoveEndData()
    {
        if (curDatas.Count == 0 || curDatas.Count == 1)
            return false;
        curDatas.RemoveLast();
        return true;
    }

    //添加数据,通过数组
    public void AddData(T[] t)
    {
        allDatas.AddRange(t);
    }

    //添加数据,通过链表
    public void AddData(List<T> t)
    {
        allDatas.AddRange(t.ToArray()); 
    }
    
    //添加单条数据
    public void AddFront(T t)
    {
        allDatas.Insert(0, t);
    }
    public void AddTail(T t)
    {
        allDatas.Add(t);
    }

    //情况当前显示节点
    public void ClearCurData()
    {
        curDatas.Clear();
    }

    //获取当前显示链表的第一个数据在总数据中的下标
    public int GetFirstIndex()
    {
        T t = curDatas.First.Value;
        return allDatas.IndexOf(t);
    }
}
