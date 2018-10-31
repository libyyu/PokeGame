using UnityEngine;
using System.Collections;
using DG.Tweening;
using System;
using UnityEngine.UI;

namespace UGUI
{
    [AddComponentMenu("UGUI/TweenColor")]
    [RequireComponent(typeof(Outline))]
    public class TweenColor : ITween
    {
        public Color col = new Color(1.0f, 1.0f, 1.0f,1);

        protected override void UpdateTweenInfo()
        {
            Outline c = this.GetComponent<Outline>();
            tween = c.DOColor(col, duration)
                 .SetDelay(delay)
                 .SetAutoKill(false)
                 .SetEase(Ease.Linear)
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