﻿using UnityEngine;
using System;

/// <summary>
/// Persistent humble singleton, basically a classic singleton but will destroy any other older components of the same type it finds on awake
/// </summary>
public class PersistentHumbleSingleton<T> : MonoBehaviour	where T : Component
{
    protected static T _instance;
	public float InitializationTime;
	
	/// <summary>
	/// Singleton design pattern
	/// </summary>
	/// <value>The instance.</value>
	public static T Instance 
	{
		get 
		{
			if (_instance == null) 
			{
				_instance = FindObjectOfType<T> ();
				if (_instance == null) 
				{
					GameObject obj = new GameObject ();
					obj.hideFlags = HideFlags.HideAndDontSave;
					_instance = obj.AddComponent<T> ();
				}
			}
			return _instance;
		}
	}

    /// <summary>
    /// On awake, we check if there's already a copy of the object in the scene. If there's one, we destroy it.
    /// </summary>
    protected virtual void Awake ()
	{
		InitializationTime=Time.time;

        if (transform.parent == null)
            DontDestroyOnLoad (this.gameObject);
        //else
        //    Debug.LogWarning(string.Format("Singleton not mark DontDestroyOnLoad, because it only works for root(none parent) object. {0}", typeof(T)));
        // we check for existing objects of the same type
        T[] check = FindObjectsOfType<T>();
		foreach (T searched in check)
		{
			if (searched!=this)
			{
				// if we find another object of the same type (not this), and if it's older than our current object, we destroy it.
				if (searched.GetComponent<PersistentHumbleSingleton<T>>().InitializationTime<InitializationTime)
				{
					Destroy (searched.gameObject);
				}
			}
		}		
		
		if (_instance == null) 
		{
			_instance = this as T;
		} 	
	}
}