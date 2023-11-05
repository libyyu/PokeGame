using UnityEngine;
using System.Collections;
using DG.Tweening;
using System;

namespace UGUI
{
    [AddComponentMenu("UGUI/TweenAlpha")]
    [RequireComponent(typeof(CanvasGroup))]
    public class TweenAlpha : ITween
    {
        public float alpha = 1.0f;
        protected override void UpdateTweenInfo()
        {
            CanvasGroup c = this.GetComponent<CanvasGroup>();
            tween = c.DOFade(alpha, duration)
                 .SetDelay(delay)
                 .SetAutoKill(false)
                 .OnComplete(() =>
                 {
                     OnFinished();
                 })
                .OnStepComplete(() =>
                {
                    OnStepFinished();
                })
                 .Pause();

            if (playType != PlayType.Once)
                tween.SetLoops(-1, playType == PlayType.Loop ? LoopType.Restart : LoopType.Yoyo);
        }

        // Use this for initialization
        void Start()
        {

        }

    }
}
