using UnityEngine;
using System.Collections;
using System.Collections.Generic;


namespace UGUI
{
    [ExecuteInEditMode]
    [AddComponentMenu("UGUI/UIPlayTween")]
#if !PEOJECT_ARTS //非美术工程
    [SLua.CustomLuaClass]
#endif
    public class UIPlayTween : MonoBehaviour
    {
        public bool includeChildren = false;
        List<ITween> EnumAllTween()
        {
            List<ITween> tweeners = new List<ITween>();
            ITween[] tweens = transform.GetComponents<ITween>();
            foreach(var t in tweens)
            {
                if(t.enabled)
                {
                    tweeners.Add(t);
                }
            }
            if(includeChildren)
            {
                tweens = transform.GetComponentsInChildren<ITween>(false);
                foreach (var t in tweens)
                {
                    if (t.enabled)
                    {
                        tweeners.Add(t);
                    }
                }
            }

            return tweeners;
        }

        void Start()
        {

        }

        public void Play(bool restart = true)
        {
            List<ITween> tweeners = EnumAllTween();
            foreach(var t in tweeners)
            {
                if (restart)
                    t.RePlay();
                else
                    t.Play();
            }
        }
#if UNITY_EDITOR
        [ContextMenu("Play All Tween")]
#endif//
        void ResetPlay()
        {
            List<ITween> tweeners = EnumAllTween();
            foreach (var t in tweeners)
            {
                t.RePlay();
            }
        }
    }
}
