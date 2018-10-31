using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using SLua;
using System;

public class FHotKeyLogic : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        HandleKeyboardInput();
    }

    void HandleKeyboardInput()
    {
        InitKeyCodeMap();
        foreach(var obj in sKeyCodeMap)
        {
            if(Input.GetKeyDown(obj.Key))
            {
                CallMethod(obj.Key, true);
            }
            else if(Input.GetKeyUp(obj.Key))
            {
                CallMethod(obj.Key, false);
            }
        }
    }
    void CallMethod(KeyCode key,bool bDown)
    {
		if (!SLua.LuaSvr.inited || null == SLua.LuaSvr.mainState)
			return;
		SLua.LuaState l = SLua.LuaSvr.mainState;
        SLua.LuaFunction func = l.getFunction("OnHotKeyInput");
        if (null != func)
        {
            func.call(key,bDown);
            func.Dispose();
        }
    }

    private static Dictionary<KeyCode, bool> sKeyCodeMap = new Dictionary<KeyCode, bool>();
    private static bool bInited = false;

    void InitKeyCodeMap()
    {
        if (bInited) return;

		if (!SLua.LuaSvr.inited || null == SLua.LuaSvr.mainState)
			return;
		SLua.LuaState l = SLua.LuaSvr.mainState;
        bInited = true;
        SLua.LuaFunction func = l.getFunction("OnHotKeyCodeMap");
        if (null != func)
        {
            LuaTable ret = func.call() as LuaTable;
            foreach(var obj in ret)
            {
                object value = obj.value;
                int ival = Convert.ToInt32(value);
                KeyCode key = (KeyCode)Enum.ToObject(typeof(KeyCode), ival);

                if (!sKeyCodeMap.ContainsKey(key))
                    sKeyCodeMap.Add(key, true);
                else
                    sKeyCodeMap[key] = true;
            }
            
            func.Dispose();
        }
    }

}
