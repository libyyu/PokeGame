using UnityEngine;
using System.Collections;
using SLua;

[CustomLuaClass]
public class LuaScriptFile : MonoBehaviour {

	LuaTable script = null;
    public bool usingUpdate = false;
    public bool usingFixedUpdate = false;
    public bool usingLateUpdate = false;
    public bool forceUpdate = false;

	LuaState env 
	{
		get { return LuaSvr.mainState; }
	}
    public string scriptFileName;

    void Awake()
    {
        DoScriptFile();
        CallMethod("Awake");
    }

    // Use this for initialization
    void Start () {
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

	void DoScriptFile()
    {
        if (!string.IsNullOrEmpty(scriptFileName) && env != null)
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
        if (script == null)
        	return null;

        try
        {
			return script.safe_invoke_self(function, args);
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
}
