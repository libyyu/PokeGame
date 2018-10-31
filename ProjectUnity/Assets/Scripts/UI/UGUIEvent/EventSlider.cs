using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;

namespace UGUIEvent
{
    [RequireComponent(typeof(Slider))]
    public class EventSlider : MonoBehaviour
    {
        public delegate void FloatDelegate(GameObject go,float v);
        public FloatDelegate onScroll;

        Slider m_Slider;

        void Awake()
        {
            if (m_Slider == null)
                m_Slider = gameObject.GetComponent<Slider>();

            m_Slider.onValueChanged.AddListener(OnValueChange);
        }

        void Destroy()
        {
            if(m_Slider != null)
            {
                m_Slider.onValueChanged.RemoveListener(OnValueChange);
            }
        }

        void OnValueChange(float v)
        {
            if(onScroll != null)
            {
                onScroll(this.gameObject,v);
            }
        }

        static public EventSlider Get(GameObject go)
        {
            EventSlider listener = go.GetComponent<EventSlider>();
            if (listener == null) listener = go.AddComponent<EventSlider>();
            return listener;
        }
    }
}
