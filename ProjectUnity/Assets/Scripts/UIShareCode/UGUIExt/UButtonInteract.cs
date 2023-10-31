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

    void Awake()
    {
        if (target == null)
            target = gameObject.GetComponent<Button>();

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

        AudioSource audioSource = gameObject.AddComponent<AudioSource>() as AudioSource;
        // we set that audio source clip to the one in paramaters
        audioSource.clip = clip;

        FSoundManager.Instance.PlayUISound(audioSource);
    }
}
