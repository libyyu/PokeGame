using UnityEngine;
using System.Collections;

#if !PEOJECT_ARTS //非美术工程
[SLua.CustomLuaClass]
#endif
[AddComponentMenu("Component/DelayDestroy")]
public class DelayDestroy : MonoBehaviour
{

    private double BornTime = 0;
    public double DelayTime = 1;
    // Use this for initialization
    void OnEnable()
    {
        BornTime = Time.realtimeSinceStartup;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.realtimeSinceStartup - BornTime > DelayTime)
        {
            GameObject.Destroy(this.gameObject);
        }
    }
}
