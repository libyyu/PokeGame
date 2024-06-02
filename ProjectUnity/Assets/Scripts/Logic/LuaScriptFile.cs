using UnityEngine;
using System.Collections;
using SLua;
using System.Collections.Generic;
using UnityEngine.UI;
using UGUIEvent;
using System;

[CustomLuaClass]
public class LuaScriptFile : MonoBehaviour {

    LuaTable script = null;
    LuaTable script_inst = null;
    public string scriptFileName;
    public bool usingUpdate = false;
    public bool usingFixedUpdate = false;
    public bool usingLateUpdate = false;
    public bool forceUpdate = false;
    public bool requireMode = true;

    Dictionary<string, LuaFunction> luaFuncs = new Dictionary<string, LuaFunction>();

	LuaState env 
	{
		get { return LuaSvr.mainState; }
	}

    public LuaTable lua
    {
        get { return script_inst; }
    }
    
    void Awake()
    {
        DoScriptFile();
        CallMethod("Awake");
    }

    // Use this for initialization
    void Start () 
    {
        DoScriptFile();
        CallMethod("Start");
    }
	
	// Update is called once per frame
	void Update () {
		if(!usingUpdate && !forceUpdate)
			return;
		if(forceUpdate){
			forceUpdate = false;
		}
		CallMethod("Update",Time.deltaTime);
	}

	void FixedUpdate () {
		if(!usingFixedUpdate)
			return;
		CallMethod("FixedUpdate");
	}

	void LateUpdate () {
		if(!usingLateUpdate)
			return;
		CallMethod("LateUpdate");
	}

	void OnDestroy(){
		CallMethod("OnDestroy");
        Cleanup();
        DetachEventHandle();
    }

    private void OnDisable()
    {
        CallMethod("OnDisable");
    }
    private void OnEnable()
    {
        CallMethod("OnEnable");
    }

    void DoScriptFile()
    {
        if (!string.IsNullOrEmpty(scriptFileName) && env != null && script == null)
        {
            int top = env.Top;
            object obj = requireMode ? env.doString(string.Format("local M = require [[{0}]]\r\nreturn M", scriptFileName)) : env.doFile(scriptFileName);
            if (obj != null && obj is LuaTable)
            {
                script = (LuaTable)obj;
                script_inst = new LuaTable(env);
                var meta = new LuaTable(env);
                meta["__index"] = script;
                script_inst.setMeta(meta);
                script_inst["component"] = this;
                script_inst["transform"] = transform;
                script_inst["gameObject"] = gameObject;

                AttachEventHandle();
            }
            LuaDLL.lua_settop(env.L, top);
        }
    }

	void Cleanup()
    {
        if (script_inst != null)
        {
            script_inst.Dispose();
            script_inst = null;
        }

        if (script != null)
        {
            script.Dispose();
            script = null;
        }        
	}


	protected object CallMethod(string function, params object[] args)
    {
        if (script == null) 	return null;

        try
        {
            LuaFunction func;
            if(!luaFuncs.TryGetValue(function, out func))
            {
                func = script[function] as LuaFunction;
                if(func != null)
                    luaFuncs.Add(function, func);
                else
                {
                    luaFuncs.Add(function, null);
                    LogUtil.LogWarning("method`{0}` not found or not a valid function", function);
                }
            }
            if (func != null)
                return func.call(script_inst, args);
            return null;
        }
        catch (System.Exception e)
        {
            Debug.LogWarning(FormatException(e), gameObject);
        }
        return null;
    }

    protected object CallMethod(string function)
    {
        return CallMethod(function, null);
    }

    public static string FormatException(System.Exception e)
    {
        string source = (string.IsNullOrEmpty(e.Source)) ? "<no source>" : e.Source.Substring(0, e.Source.Length - 2);
        return string.Format("{0}\nLua (at {2})", e.Message, string.Empty, source);
    }

    public void OnInvokeLua(string method, UnityEngine.GameObject go)
    {
        CallMethod(method, go);
    }

    [ContextMenu("UnTouchEvent")]
    public void DetachEventHandle()
    {
        UnTouchButton();
        UnTouchInputField();
        UnTouchTweener();
        UnTouchScroll();
    }

    [ContextMenu("TouchEvent")]
    public void AttachEventHandle()
    {
        TouchButton();
        TouchInputField();
        TouchTweener();
        TouchScroll();
    }

    void TouchButton()
    {
        {
            var comps = gameObject.GetComponentsInChildren<Button>(true);
            int Length = comps.Length;
            for (int i = 0; i < Length; ++i)
            {
                Button button = comps[i];
                EventClick.Get(button.gameObject).onClick += onClick;
            }
        }
    }
    void UnTouchButton()
    {
        {
            var comps = gameObject.GetComponentsInChildren<Button>(true);
            int Length = comps.Length;
            for (int i = 0; i < Length; ++i)
            {
                Button button = comps[i];
                EventClick.Get(button.gameObject).onClick -= onClick;
            }
        }
    }
    
    void TouchInputField()
    {
        {
            var comps = gameObject.GetComponentsInChildren<InputField>(true);
            int Length = comps.Length;
            for (int i = 0; i < Length; ++i)
            {
                InputField inputfield = comps[i];
                EventEdit.Get(inputfield.gameObject).onSubmit += onSubmit;
                EventEdit.Get(inputfield.gameObject).onTextChange += onTextChange;
            }
        }
    }
    void UnTouchInputField()
    {
        {
            var comps = gameObject.GetComponentsInChildren<InputField>(true);
            int Length = comps.Length;
            for (int i = 0; i < Length; ++i)
            {
                InputField inputfield = comps[i];
                EventEdit.Get(inputfield.gameObject).onSubmit -= onSubmit;
                EventEdit.Get(inputfield.gameObject).onTextChange -= onTextChange;
            }
        }
    }
    void TouchTweener()
    {
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
    }
    void UnTouchTweener()
    {
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
    }

    void TouchScroll()
    {
        {
            var comps = gameObject.GetComponentsInChildren<Slider>(true);
            int Length = comps.Length;
            for (int i = 0; i < Length; ++i)
            {
                Slider slider = comps[i];
                EventSlider.Get(slider.gameObject).onScroll += onScroll;
            }
        }
    }
    void UnTouchScroll()
    {
        {
            var comps = gameObject.GetComponentsInChildren<Slider>(true);
            int Length = comps.Length;
            for (int i = 0; i < Length; ++i)
            {
                Slider slider = comps[i];
                EventSlider.Get(slider.gameObject).onScroll -= onScroll;
            }
        }
    }

    void onClick(GameObject go)
    {
        CallMethod("onClick", go);
    }

    void onSubmit(GameObject go, string str)
    {
        CallMethod("onSubmit", go, str);
    }

    void onTextChange(GameObject go, string str)
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
    void onScroll(GameObject go, float value)
    {
        CallMethod("onScroll", go, value);
    }

    /////////////////////////////////////////////////////////////////////////////////////////////////////////////


    void OnTriggerEnter(Collider other)
    {
        CallMethod("OnTriggerEnter", other);
    }
    void OnTriggerStay(Collider other)
    {
        CallMethod("OnTriggerStay", other);
    }
    void OnTriggerExit(Collider other)
    {
        CallMethod("OnTriggerExit", other);
    }

    void OnCollisionEnter(Collision collision)
    {
        CallMethod("OnCollisionEnter", collision);
    }
    void OnCollisionStay(Collision collision)
    {
        CallMethod("OnCollisionStay", collision);
    }
    void OnCollisionExit(Collision collision)
    {
        CallMethod("OnCollisionExit", collision);
    }

    private void OnBecameVisible()
    {
        CallMethod("OnBecameVisible");
    }
    private void OnBecameInvisible()
    {
        CallMethod("OnBecameInvisible");
    }
    private void OnBeforeTransformParentChanged()
    {
        CallMethod("OnBeforeTransformParentChanged");
    }
    private void OnTransformParentChanged()
    {
        CallMethod("OnTransformParentChanged");
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        CallMethod("OnControllerColliderHit", hit);
    }
    private void OnPostRender()
    {
        CallMethod("OnPostRender");
    }
    private void OnAnimatorIK(int layerIndex)
    {
        CallMethod("OnAnimatorIK", layerIndex);
    }
    private void OnParticleCollision(GameObject other)
    {
        CallMethod("OnParticleCollision", other);
    }
    private void OnParticleTrigger()
    {
        CallMethod("OnParticleTrigger");
    }
    private void OnMouseDown()
    {
        CallMethod("OnMouseDown");
    }
    private void OnMouseDrag()
    {
        CallMethod("OnMouseDrag");
    }
    private void OnMouseEnter()
    {
        CallMethod("OnMouseEnter");
    }
    private void OnMouseExit()
    {
        CallMethod("OnMouseExit");
    }
    private void OnMouseOver()
    {
        CallMethod("OnMouseOver");
    }
    private void OnMouseUp()
    {
        CallMethod("OnMouseUp");
    }
    private void OnMouseUpAsButton()
    {
        CallMethod("OnMouseUpAsButton");
    }

}
