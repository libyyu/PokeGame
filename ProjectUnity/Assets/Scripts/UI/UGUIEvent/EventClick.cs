using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;

namespace UGUIEvent
{
    [RequireComponent(typeof(Button))]
    public class EventClick : MonoBehaviour
    {
        public delegate void VoidDelegate(GameObject go);
        public VoidDelegate onClick;

        Button m_Button;

        void Awake()
        {
            if (m_Button == null)
                m_Button = gameObject.GetComponent<Button>();

            m_Button.onClick.AddListener(OnClick);
        }

        void Destroy()
        {
            if(m_Button != null)
            {
                m_Button.onClick.RemoveListener(OnClick);
            }
        }

        void OnClick()
        {
            if(onClick != null)
            {
                onClick(this.gameObject);
            }
        }

        static public EventClick Get(GameObject go)
        {
            EventClick listener = go.GetComponent<EventClick>();
            if (listener == null) listener = go.AddComponent<EventClick>();
            return listener;
        }
    }
}
