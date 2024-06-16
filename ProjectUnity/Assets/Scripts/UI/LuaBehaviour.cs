using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using SLua;
using UGUIEvent;


[CustomLuaClass]
public class LuaBehaviour : MonoBehaviour {
    private List<LuaFunction> buttons = new List<LuaFunction>();
    private LuaTable msgHandle = null;
    protected bool initialize = false;


    private bool __visible = false;

    protected void Awake() {
        initialize = true;
        CallMethod("onAwake", gameObject);
    }

    protected void Start() {
        CallMethod("onStart");

        if(!__visible && gameObject.activeSelf)
        {
            OnBecameVisible();
        }
    }

    protected void OnDestroy()
    {
        CallMethod("onDestroy");
        UnTouchGUIMsg();
        initialize = false;
    }

    protected void OnBecameVisible()
    {
        __visible = true;
        CallMethod("onBecameVisible");
    }
    protected void OnBecameInvisible()
    {
        __visible = false;
        CallMethod("onBecameInvisible");
    }

    /// <summary>
    /// 添加单击事件
    /// </summary>
    public void AddClick(GameObject go, LuaFunction luafunc) {
        if (go == null) return;
        buttons.Add(luafunc);
        go.GetComponent<Button>().onClick.AddListener(
            delegate() {
                luafunc.call(go);
            }
        );
    }

    /// <summary>
    /// 清除单击事件
    /// </summary>
    public void ClearClick() {
        for (int i = 0; i < buttons.Count; i++) {
            if (buttons[i] != null) {
                buttons[i].Dispose();
                buttons[i] = null;
            }
        }
    }

    public void UnTouchGUIMsg()
    {
        ClearClick();
        DetachEventHandle();
        msgHandle = null;
    }

    public void TouchGUIMsg(LuaTable luaMsgHandler)
    {
        UnTouchGUIMsg();
        msgHandle = luaMsgHandler;
        if (msgHandle != null)
        {
            LuaFunction fun = msgHandle["onClick"] as LuaFunction;
            if(fun != null)
            {
                TouchButton();
            }

            fun = msgHandle["onSubmit"] as LuaFunction;
            if (fun != null)
            {
                TouchInputField();
            }
            else
            {
                fun = msgHandle["onTextChange"] as LuaFunction;
                if(fun != null )
                {
                    TouchInputField();
                }
            }

            fun = msgHandle["onStepTweenFinish"] as LuaFunction;
            if (fun != null)
            {
                TouchTweener();
            }

            fun = msgHandle["onScroll"] as LuaFunction;
            if (fun != null)
            {
                TouchScroll();
            }
        }
    }

    [ContextMenu("UnTouchEvent")]
    public void DetachEventHandle()
    {
        UnTouchButton();
		UnTouchInputField ();
        UnTouchTweener();
        UnTouchScroll();
    }

    [ContextMenu("TouchEvent")]
    public void AttachEventHandle()
    {
        DetachEventHandle();
        TouchButton();
		TouchInputField ();
        TouchTweener();
        TouchScroll();
    }

    public void TouchButton()
    {
        var comps = gameObject.GetComponentsInChildren<Button>(true);
        int Length = comps.Length;
        for(int i=0;i<Length;++i)
        {
            Button button = comps[i];
            EventClick.Get(button.gameObject).onClick += onClick;
        }
    }
    public void UnTouchButton()
    {
        var comps = gameObject.GetComponentsInChildren<Button>(true);
        int Length = comps.Length;
        for (int i = 0; i < Length; ++i)
        {
            Button button = comps[i];
            EventClick.Get(button.gameObject).onClick -= onClick;
        }
    }
    public void TouchInputField()
	{
		var comps = gameObject.GetComponentsInChildren<InputField>(true);
		int Length = comps.Length;
		for(int i=0;i<Length;++i)
		{
			InputField inputfield = comps[i];
			EventEdit.Get(inputfield.gameObject).onSubmit += onSubmit;
            EventEdit.Get(inputfield.gameObject).onTextChange += onTextChange;
        }
	}
    public void UnTouchInputField()
	{
		var comps = gameObject.GetComponentsInChildren<InputField>(true);
		int Length = comps.Length;
		for(int i=0;i<Length;++i)
		{
			InputField inputfield = comps[i];
            EventEdit.Get(inputfield.gameObject).onSubmit -= onSubmit;
            EventEdit.Get(inputfield.gameObject).onTextChange -= onTextChange;
        }
	}
    public void TouchTweener()
    {
        var comps = gameObject.GetComponentsInChildren<UGUI.ITween>(true);
        int Length = comps.Length;
        for (int i = 0; i < Length; ++i)
        {
            UGUI.ITween tweener = comps[i];
            tweener.onTweenFinish += onTweenFinish;
            tweener.onStepTweenFinish += onStepTweenFinish;
        }
    }
    public void UnTouchTweener()
    {
        var comps = gameObject.GetComponentsInChildren<UGUI.ITween>(true);
        int Length = comps.Length;
        for (int i = 0; i < Length; ++i)
        {
            UGUI.ITween tweener = comps[i];
            tweener.onTweenFinish -= onTweenFinish;
            tweener.onStepTweenFinish -= onStepTweenFinish;
        }
    }

    void TouchScroll()
    {
        var comps = gameObject.GetComponentsInChildren<Slider>(true);
        int Length = comps.Length;
        for (int i = 0; i < Length; ++i)
        {
            Slider slider = comps[i];
            EventSlider.Get(slider.gameObject).onScroll += onScroll;
        }
    }
    void UnTouchScroll()
    {
        var comps = gameObject.GetComponentsInChildren<Slider>(true);
        int Length = comps.Length;
        for (int i = 0; i < Length; ++i)
        {
            Slider slider = comps[i];
            EventSlider.Get(slider.gameObject).onScroll -= onScroll;
        }
    }

    void onClick(GameObject go)
    {
        CallMethod("onClick",go);
    }

	void onSubmit(GameObject go,string str)
	{
		CallMethod("onSubmit",go,str);
	}

    void onTextChange(GameObject go,string str)
    {
        CallMethod("onTextChange", go, str);
    }

    void onTweenFinish(GameObject go)
    {
        CallMethod("onTweenFinish", go);
    }
    void onStepTweenFinish(GameObject go)
    {
        CallMethod("onStepTweenFinish", go);
    }
    void onScroll(GameObject go,float value)
    {
        CallMethod("onScroll", go,value);
    }

    /// <summary>
    /// 执行Lua方法
    /// </summary>
    object CallMethod(string func, params object[] args) {
        if (!initialize || null == msgHandle) return null;
            
		return msgHandle.safe_invoke (func, args);
    }

    //-----------------------------------------------------------------
}
