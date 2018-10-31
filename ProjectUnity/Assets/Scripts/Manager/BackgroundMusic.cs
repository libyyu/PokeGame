using UnityEngine;
using System.Collections;

/// <summary>
/// Add this class to a GameObject to have it play a background music when instanciated.
/// Careful : only one background music will be played at a time.
/// </summary>
public class BackgroundMusic : PersistentHumbleSingleton<BackgroundMusic>
{
	public AudioClip SoundClip ;
    protected AudioSource _source;

    /// <summary>
    /// Gets the AudioSource associated to that GameObject, and asks the GameManager to play it.
    /// </summary>
    protected virtual void Start () 
	{
		_source = gameObject.AddComponent<AudioSource>() as AudioSource;	
		PlayBackgroundMusic (SoundClip);

	}

	public void PlayBackgroundMusic(AudioClip clip)
	{
		if (clip == null)
			return;
		SoundClip = clip;

		_source.playOnAwake = false;
		_source.spatialBlend = 0;
		_source.rolloffMode = AudioRolloffMode.Logarithmic;
		_source.loop = true;	

		_source.clip = SoundClip;

		SoundManager.Instance.PlayBackgroundMusic(_source);
	}

    protected virtual void OnEnable()
    {
        if(_source != null)
            _source.enabled = true;
    }

    protected virtual void OnDisable()
    {
        if (_source != null)
            _source.enabled = false;
    }
}
