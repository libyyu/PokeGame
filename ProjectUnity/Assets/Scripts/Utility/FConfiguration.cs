using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using SLua;


[CustomLuaClass]
public class FConfiguration : MonoBehaviour
{
    [DoNotToLua]
    [Serializable]
    public class TSerializableKeyValue<TKey, TValue>
    {
        [SerializeField]
        public TKey key;
        [SerializeField]
        public TValue value;
    }

    [SerializeField]
    private List<TSerializableKeyValue<string, string>> strConfig = new List<TSerializableKeyValue<string, string>>();
    [SerializeField]
    private List<TSerializableKeyValue<string, UnityEngine.Object>> objConfig = new List<TSerializableKeyValue<string, UnityEngine.Object>>();

    Dictionary<string, string> getConfig()
    {
        Dictionary<string, string> ret = new Dictionary<string, string>();
        foreach(var kv in strConfig)
        {
            if(!ret.ContainsKey(kv.key))
                ret.Add(kv.key, kv.value);
            else
                ret[kv.key] = kv.value;
        }
        return ret;
    }

    public Dictionary<string, string> Config
    {
        get { return getConfig(); }
    }

    Dictionary<string, UnityEngine.Object> getObjConfig()
    {
        Dictionary<string, UnityEngine.Object> ret = new Dictionary<string, UnityEngine.Object>();
        foreach (var kv in objConfig)
        {
            if (!ret.ContainsKey(kv.key))
                ret.Add(kv.key, kv.value);
            else
                ret[kv.key] = kv.value;
        }
        return ret;
    }

    public Dictionary<string, UnityEngine.Object> ObjConfig
    {
        get { return getObjConfig(); }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }
}
