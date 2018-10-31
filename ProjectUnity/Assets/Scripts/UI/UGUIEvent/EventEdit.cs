using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;

namespace UGUIEvent
{
    [RequireComponent(typeof(InputField))]
    public class EventEdit : MonoBehaviour
    {
        public delegate void StringDelegate(GameObject go, string str);
        public StringDelegate onSubmit;
        public StringDelegate onTextChange;

        InputField m_Input;

        void Awake()
        {
            if (m_Input == null)
                m_Input = gameObject.GetComponent<InputField>();
            m_Input.onEndEdit.AddListener(OnEndEdit);
            m_Input.onValueChange.AddListener(OnValueChange);
        }

        void Destroy()
        {
            if(m_Input != null)
            {
                m_Input.onEndEdit.RemoveListener(OnEndEdit);
                m_Input.onValueChange.RemoveListener(OnValueChange);
            }
        }

        void OnEndEdit(string str)
        {
            if(onSubmit != null)
            {
                onSubmit(this.gameObject,str);
            }
        }

        void OnValueChange(string str)
        {
            if (onTextChange != null)
            {
                onTextChange(this.gameObject, str);
            }
        }

        static public EventEdit Get(GameObject go)
        {
            EventEdit listener = go.GetComponent<EventEdit>();
            if (listener == null) listener = go.AddComponent<EventEdit>();
            return listener;
        }
    }
}
