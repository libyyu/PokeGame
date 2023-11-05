using UnityEngine;
using System.Collections;
using System;
using DG.Tweening;

namespace UGUI
{
    [AddComponentMenu("UGUI/TweenPosition")]
    public class TweenPosition : ITween
    {
        public Vector3 from;
        public Vector3 to;

        protected override void UpdateTweenInfo()
        {
            tween = this.rectTransform.DOAnchorPos3D(to, duration, true)
                .SetAutoKill(false)
                .OnComplete(() =>
                {
                    OnFinished();
                })
                .OnStepComplete(() =>
                {
                    OnStepFinished();
                })
                .SetDelay(delay)
                .Pause();
            if (playType != PlayType.Once)
                tween.SetLoops(-1, playType == PlayType.Loop ? LoopType.Restart : LoopType.Yoyo);

            tween.ChangeStartValue(from);
        }


        // Use this for initialization
        void Start()
        {

        }
    }
}