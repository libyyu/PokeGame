using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SLua;
using System.Text;

public class FTimerList
{
    static int _uniqueid = 1;
    public static int total_count = 0;

    public struct Timer
    {
        public int id;
        public float ttl;
        public float end_time;
        //public int callback;
        public LuaFunction callback;
        public int cbparam;
        public bool bOnce;
    }

    List<Timer> m_List = new List<Timer>();
    List<Timer> m_TempList = new List<Timer>();
    List<int> m_TempDelList = new List<int>();
    bool m_bTick = false;

    IntPtr getL()
    {
        if (!LuaSvr.inited || null == LuaSvr.mainState)
            return IntPtr.Zero;
        return LuaSvr.mainState.L;
    }

    public int GetEnableCount() { return m_List.Count + m_TempList.Count - m_TempDelList.Count; }

    public int AddTimer(float ttl, bool bOnce, int cb, int cbparam)
    {
        if (cb < 0)
        {
            throw new Exception("AddTimer, cb is wrong");
        }

        Timer tm;
        tm.id = _uniqueid++;
        tm.ttl = ttl;
        tm.end_time = Time.time + ttl;
        tm.callback = new LuaFunction(getL(), cb);
        tm.cbparam = cbparam;
        tm.bOnce = bOnce;
        if (m_bTick)
            m_TempList.Add(tm);
        else
        {
            m_List.Add(tm);
            total_count++;
        }
        return tm.id;
    }

    public void RemoveTimer(int id)
    {
        if (m_bTick)
            m_TempDelList.Add(id);
        else
        {
            IntPtr L = getL();
            if (L == IntPtr.Zero)
                return;

            for (int i = 0; i < m_List.Count; i++)
            {
                Timer tm = m_List[i];

                if (tm.id == id)
                {
                    tm.callback.Dispose();
                    //LuaDLL.luaL_unref(L, LuaIndexes.LUA_REGISTRYINDEX, tm.callback);
                    LuaDLL.luaL_unref(L, LuaIndexes.LUA_REGISTRYINDEX, tm.cbparam);
                    m_List.RemoveAt(i);
                    total_count--;
                    return;
                }
            }
        }
    }

    public void ResetTimer(int id)
    {
        for (int i = 0; i < m_List.Count; i++)
        {
            Timer tm = m_List[i];

            if (tm.id == id)
            {
                tm.end_time = Time.time + tm.ttl;
                m_List[i] = tm;
                return;
            }
        }
    }

    public void Tick()
    {
        if (m_List.Count == 0)
            return;

        float cur = EntryPoint.CurTime;
        int i = 0;
        m_bTick = true;

        while (i < m_List.Count)
        {
            Timer tm = m_List[i];

            if (tm.end_time <= cur)
            {
                IntPtr L = getL();
                if (tm.cbparam != LuaRefValue.LUA_NOREF)
                    LuaDLL.lua_rawgeti(L, LuaIndexes.LUA_REGISTRYINDEX, tm.cbparam); // cbparam
                else
                    LuaDLL.lua_pushnil(L);

                tm.callback.pcall(1, 0);

                if (tm.bOnce)
                {
                    tm.callback.Dispose();
                    //LuaDLL.luaL_unref(wLua.L.L, LuaIndexes.LUA_REGISTRYINDEX, tm.callback);
                    LuaDLL.luaL_unref(L, LuaIndexes.LUA_REGISTRYINDEX, tm.cbparam);
                    m_List.RemoveAt(i);
                    total_count--;
                }
                else
                {
                    tm.end_time = cur + tm.ttl;
                    m_List[i] = tm;
                    i++;
                }
            }
            else
                i++;
        }

        m_bTick = false;

        if (m_TempList.Count > 0)
        {
            for (int j = 0; j < m_TempList.Count; j++)
            {
                Timer tm = m_TempList[j];
                m_List.Add(tm);
            }

            total_count += m_TempList.Count;
            m_TempList.Clear();
        }

        if (m_TempDelList.Count > 0)
        {
            for (int j = 0; j < m_TempDelList.Count; j++)
            {
                int id = m_TempDelList[j];
                RemoveTimer(id);
            }

            m_TempDelList.Clear();
        }
    }

    public void Clear()
    {
        if (m_List.Count == 0)
            return;

        total_count -= m_List.Count;
        if (!LuaSvr.inited || null == LuaSvr.mainState)
        {
            m_List.Clear();
            return;
        }

        //IntPtr L = wLua.L.L;

        for (int i = 0; i < m_List.Count; i++)
        {
            m_List[i].callback.Dispose();
            LuaDLL.luaL_unref(getL(), LuaIndexes.LUA_REGISTRYINDEX, m_List[i].cbparam);
        }

        m_List.Clear();
    }

    //public String GetDebugInfo(GameObject obj, Dictionary<string, int> callbackCountMap)
    //{
    //    StringBuilder strBuilder = new StringBuilder();
    //    strBuilder.Append(UnityDebugHelper.FormatGameObjectPath(obj));
    //    strBuilder.AppendLine(": ");
    //    foreach (Timer timer in m_List)
    //    {
    //        String callback = wLua.L.GetRegistryFunctionInfo(timer.callback);
    //        int oldCount;
    //        if (callbackCountMap.TryGetValue(callback, out oldCount))
    //            callbackCountMap[callback] = oldCount + 1;
    //        else
    //            callbackCountMap[callback] = 1;

    //        strBuilder.Append("  ");
    //        var info = String.Format("id: {0}, ttl: {1}, end_time: {2}, once: {3}, cb: {4}", timer.id, timer.ttl, timer.end_time, timer.bOnce, wLua.L.GetRegistryFunctionInfo(timer.callback));
    //        strBuilder.AppendLine(info);
    //    }
    //    return strBuilder.ToString();
    //}

    //public static String GetAllDebugInfo()
    //{
    //    Dictionary<string, int> callbackCountMap = new Dictionary<string, int>();

    //    StringBuilder strBuilder = new StringBuilder();
    //    foreach (var item in s_instanceMap)
    //    {
    //        if (item.Value != null)
    //            strBuilder.Append(item.Key.GetDebugInfo(item.Value, callbackCountMap));
    //    }
    //    strBuilder.AppendLine("------------------------------");
    //    strBuilder.AppendLine("-- duplicated callbacks: ");
    //    foreach (var item in callbackCountMap)
    //    {
    //        if (item.Value >= 2)
    //        {
    //            strBuilder.Append("  ");
    //            strBuilder.Append(item.Key);
    //            strBuilder.Append(" = ");
    //            strBuilder.Append(item.Value);
    //            strBuilder.AppendLine();
    //        }
    //    }

    //    return strBuilder.ToString();
    //}

    static Dictionary<FTimerList, GameObject> s_instanceMap = new Dictionary<FTimerList, GameObject>();

    public static void RegisterTimerList(FTimerList timerList, GameObject obj)
    {
        s_instanceMap[timerList] = obj;
    }

    public static void UnregisterTimerList(FTimerList timerList)
    {
        s_instanceMap.Remove(timerList);
    }
}
