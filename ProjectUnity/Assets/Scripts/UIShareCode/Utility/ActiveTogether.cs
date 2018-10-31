using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ActiveTogether : MonoBehaviour {
	public List<GameObject> together = new List<GameObject>();

	private bool ListChanged = false;
	private bool NowActive = false;
	// Use this for initialization
	void Start () {
		
	}

	void OnEnable(){
		NowActive = true;
		foreach(var go in together){
			go.SetActive(true);
		}
	}

	void OnDisable(){
		NowActive = false;
		foreach(var go in together){
			go.SetActive(false);
		}
	}

	void Update(){
		
	}
}
