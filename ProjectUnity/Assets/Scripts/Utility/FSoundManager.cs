﻿using UnityEngine;
using System.Collections;
/// <summary>
/// This persistent singleton handles sound playing
/// </summary>

public class FSoundManager : PersistentSingleton<FSoundManager>
{	
	/// true if the music is enabled	
	public bool MusicOn=true;
	/// true if the sound fx are enabled
	public bool SfxOn=true;
	/// the music volume
	[Range(0,1)]
	public float MusicVolume=0.3f;
	/// the sound fx volume
	[Range(0,1)]
	public float SfxVolume=1f;

    [Range(0, 1)]
    public float UIVolume = 1f;

    protected AudioSource _backgroundMusic;	
		
	/// <summary>
	/// Plays a background music.
	/// Only one background music can be active at a time.
	/// </summary>
	/// <param name="Clip">Your audio clip.</param>
	public virtual void PlayBackgroundMusic(AudioSource Music)
	{
		// if the music's been turned off, we do nothing and exit
		if (!MusicOn)
			return;
		// if we already had a background music playing, we stop it
		if (_backgroundMusic!=null)
			_backgroundMusic.Stop();
		// we set the background music clip
		_backgroundMusic=Music;
		// we set the music's volume
		_backgroundMusic.volume=MusicVolume;
		// we set the loop setting to true, the music will loop forever
		_backgroundMusic.loop=true;
		// we start playing the background music
		_backgroundMusic.Play();		
	}	
	
	/// <summary>
	/// Plays a sound
	/// </summary>
	/// <returns>An audiosource</returns>
	/// <param name="Sfx">The sound clip you want to play.</param>
	/// <param name="Location">The location of the sound.</param>
	/// <param name="Volume">The volume of the sound.</param>
	public virtual AudioSource PlaySound(AudioClip Sfx, Vector3 Location)
	{
		if (!SfxOn)
			return null;
		// we create a temporary game object to host our audio source
		GameObject temporaryAudioHost = new GameObject("__TempAudio");
		// we set the temp audio's position
		temporaryAudioHost.transform.position = Location;
		// we add an audio source to that host
		AudioSource audioSource = temporaryAudioHost.AddComponent<AudioSource>() as AudioSource; 
		// we set that audio source clip to the one in paramaters
		audioSource.clip = Sfx; 
		// we set the audio source volume to the one in parameters
		audioSource.volume = SfxVolume;
		// we start playing the sound
		audioSource.Play(); 
		// we destroy the host after the clip has played
		Destroy(temporaryAudioHost, Sfx.length);
		// we return the audiosource reference
		return audioSource;
	}

    public virtual void PlayUISound(AudioSource sound)
	{
        if (!SfxOn)
            return;
		if(sound.isPlaying) sound.Stop();
        sound.volume = UIVolume;
        // we start playing the background music
        sound.Play();
    }

    public virtual void PlayUISound(AudioClip Sfx)
    {
        if (!SfxOn)
            return;
		PlaySound(Sfx, Vector3.zero);
    }

    void LateUpdate()
    {
        if (_backgroundMusic == null)
            return;
        if (_backgroundMusic.volume != MusicVolume)
            _backgroundMusic.volume = MusicVolume;
        if (_backgroundMusic.mute == MusicOn)
            _backgroundMusic.mute = !MusicOn;
    }
}
