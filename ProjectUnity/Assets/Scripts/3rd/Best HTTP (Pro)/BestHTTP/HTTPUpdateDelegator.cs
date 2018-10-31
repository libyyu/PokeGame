/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。

插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using System;
using System.Collections.Generic;
using UnityEngine;

namespace BestHTTP
{
    /// <summary>
    /// Delegates some U3D calls to the HTTPManager.
    /// </summary>
    sealed class HTTPUpdateDelegator : MonoBehaviour
    {
        private static HTTPUpdateDelegator instance;
        private static bool IsCreated;

        public static void CheckInstance()
        {
            try
            {
                if (!IsCreated)
                {
                    instance = UnityEngine.Object.FindObjectOfType(typeof(HTTPUpdateDelegator)) as HTTPUpdateDelegator;

                    if (instance == null)
                    {
                        GameObject go = new GameObject("HTTP Update Delegator");
                        go.hideFlags = HideFlags.HideInInspector | HideFlags.HideInHierarchy;
                        UnityEngine.Object.DontDestroyOnLoad(go);

                        instance = go.AddComponent<HTTPUpdateDelegator>();
                    }
                    IsCreated = true;
                }
            }
            catch
            {
                HTTPManager.Logger.Error("HTTPUpdateDelegator", "Please call the BestHTTP.HTTPManager.Setup() from one of Unity's event(eg. awake, start) before you send any request!");
            }
        }

        void Awake()
        {
            Caching.HTTPCacheService.SetupCacheFolder();
            Cookies.CookieJar.SetupFolder();
            Cookies.CookieJar.Load();
        }

        void Update()
        {
            HTTPManager.OnUpdate();
        }

#if UNITY_EDITOR
        void OnDisable()
        {
            HTTPManager.OnQuit();
        }
#else
        void OnApplicationQuit()
        {
            HTTPManager.OnQuit();
        }
#endif
    }
}
