﻿using System.Collections.Generic;
using UnityEngine;

namespace FairyGUI
{
    /// <summary>
    /// 
    /// </summary>
    public class EventContext
    {
        /// <summary>
        /// 
        /// </summary>
        public EventDispatcher sender { get; internal set; }

        /// <summary>
        /// /
        /// </summary>
        public object initiator { get; internal set; }

        /// <summary>
        /// /
        /// </summary>
        public InputEvent inputEvent { get; internal set; }

        /// <summary>
        /// 
        /// </summary>
        public string type;

        /// <summary>
        /// 
        /// </summary>
        public object data;

        internal bool _defaultPrevented;
        internal bool _stopsPropagation;
        internal bool _touchCapture;

        internal List<EventBridge> callChain = new List<EventBridge>();

        /// <summary>
        /// 
        /// </summary>
        public void StopPropagation()
        {
            _stopsPropagation = true;
        }

        /// <summary>
        /// 
        /// </summary>
        public void PreventDefault()
        {
            _defaultPrevented = true;
        }

        /// <summary>
        /// 
        /// </summary>
        public void CaptureTouch()
        {
            _touchCapture = true;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool isDefaultPrevented
        {
            get { return _defaultPrevented; }
        }

        static Stack<EventContext> pool = new Stack<EventContext>();
        internal static EventContext Get()
        {
            if (pool.Count > 0)
            {
                EventContext context = pool.Pop();
                context._stopsPropagation = false;
                context._defaultPrevented = false;
                context._touchCapture = false;
                return context;
            }
            else
                return new EventContext();
        }

        internal static void Return(EventContext value)
        {
            pool.Push(value);
        }

        public override string ToString()
        {
            string bas = base.ToString();
            if(sender != null && sender is GObject)
                return bas + string.Format("(type:{0}, {1} {2})", type, ((GObject)sender).ToString(), ((GObject)sender).gameObjectName);
            return bas + string.Format("(type:{0}, {1})", type, sender != null ? sender.ToString() : "");
        }


#if UNITY_2019_3_OR_NEWER
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        static void InitializeOnLoad()
        {
            pool.Clear();
        }
#endif
    }

}
