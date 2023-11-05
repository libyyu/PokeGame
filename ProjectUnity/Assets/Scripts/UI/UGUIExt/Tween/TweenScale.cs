using UnityEngine;
using System.Collections;
using System;
using DG.Tweening;

namespace UGUI
{
    [AddComponentMenu("UGUI/TweenScale")]
    public class TweenScale : ITween
    {
        public float scale = 1.0f;
        
        protected override void UpdateTweenInfo()
        {
            tween = this.rectTransform.DOScale(scale, duration)
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
