using UnityEngine;
using System.Collections;
using SLua;

public class FDelayCall : MonoBehaviour {

    public float delay = 0;
    public GameObject target;
    public LuaFunction func;
    bool bLastActive = false;
	// Use this for initialization
	void Awake () {
        if (null == target)
            target = gameObject;
    }

    void OnDisable()
    {
        StopDelay();
    }
    void LateUpdate()
    {
        if (null == func)
            return;
        if(target.activeInHierarchy == bLastActive)
            return;
        bLastActive = target.activeInHierarchy;
        Delay(func, delay, target);
    }

    void Delay(LuaFunction luafun, float time, object args = null)
    {
        StartCoroutine(DelayDo(luafun, args, time));
    }

    void StopDelay()
    {
        StopCoroutine("DelayDo");
    }

    private static IEnumerator DelayDo(LuaFunction luafun, object arg, float time)
    {
        yield return new WaitForSeconds(time);
        luafun.call(arg);
    }
}
