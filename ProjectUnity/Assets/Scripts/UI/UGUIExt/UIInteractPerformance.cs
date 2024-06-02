using Org.BouncyCastle.Asn1.Pkcs;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInteractPerformance : MonoBehaviour
{
    [Serializable]
    public struct AudioConfig
    {
        public AudioClip clip_Create;
        public AudioClip clip_Destroy;
        public AudioClip clip_Visible;
        public AudioClip clip_Hide;
        public AudioClip clip_Click;
    }
    [SerializeField]
    public AudioConfig audioConfig = new AudioConfig();

    protected Button button = null;
    void Awake()
    {

        button = gameObject.GetComponent<Button>();
        if(button != null) button.onClick.AddListener(OnClick);
        PlaySound(audioConfig.clip_Create);

        EventTriggerListener listener = EventTriggerListener.Get(gameObject);
        listener.onClick += OnClickFromPoint;
    }

    void Destroy()
    {
        if (button != null)
        {
            button.onClick.RemoveListener(OnClick);
        }
        PlaySound(audioConfig.clip_Destroy);

        EventTriggerListener listener = EventTriggerListener.Get(gameObject);
        listener.onClick -= OnClickFromPoint;
    }

    void OnBecameVisible()
    {
        PlaySound(audioConfig.clip_Visible);
    }
    void OnBecameInvisible()
    {
        PlaySound(audioConfig.clip_Hide);
    }


    void OnClick()
    {
        PlaySound(audioConfig.clip_Click);
    }

    void OnClickFromPoint(GameObject go)
    {
        if(button != null) { return; }
        PlaySound(audioConfig.clip_Click);
    }

    void PlaySound(AudioClip clip)
    {
        if(clip == null) return;
        FSoundManager.Instance.PlayUISound(clip);
    }
}
