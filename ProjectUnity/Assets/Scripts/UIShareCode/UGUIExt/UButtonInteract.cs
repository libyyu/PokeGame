using Org.BouncyCastle.Asn1.Pkcs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class UButtonInteract : MonoBehaviour
{
    public Button target;
    public AudioClip clip = null;
    AudioSource audioSource = null;
    void Awake()
    {
        if (target == null)
            target = gameObject.GetComponent<Button>();
        audioSource = gameObject.GetComponent<AudioSource>();
        if(audioSource == null) audioSource = gameObject.AddComponent<AudioSource>() as AudioSource;

        target.onClick.AddListener(OnClick);
    }

    void Destroy()
    {
        if (target != null)
        {
            target.onClick.RemoveListener(OnClick);
        }
    }

    void OnClick()
    {
        if (clip == null) return;

        audioSource.clip = clip;
        FSoundManager.Instance.PlayUISound(audioSource);
    }
}
