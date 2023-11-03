using UnityEngine;
using System.Collections;
using SLua;
using System.Collections.Generic;

[CustomLuaClass]
public class LuaScriptFile : MonoBehaviour {

	LuaTable script = null;
    public string scriptFileName;
    public bool usingUpdate = false;
    public bool usingFixedUpdate = false;
    public bool usingLateUpdate = false;
    public bool forceUpdate = false;

    Dictionary<string, LuaFunction> luaFuncs = new Dictionary<string, LuaFunction>();

	LuaState env 
	{
		get { return LuaSvr.mainState; }
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
            object obj = env.doFile(scriptFileName);
            if (obj != null && obj is LuaTable)
            {
                var M = (LuaTable)obj;
                script = new LuaTable(env);
                var meta = new LuaTable(env);
                meta["__index"] = M;
                script.setMeta(meta);
                script["component"] = this;
                script["transform"] = transform;
                script["gameObject"] = gameObject;
            }
            LuaDLL.lua_settop(env.L, top);
        }
    }

	void Cleanup(){
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
                return func.call(script, args);
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
