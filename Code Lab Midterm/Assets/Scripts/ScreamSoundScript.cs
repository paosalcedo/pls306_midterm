using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreamSoundScript : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void PlaySound ()
	{
		Debug.Log ("Playing SCREAM NOW!");
		AudioSource scream;
		scream = GetComponent<AudioSource> ();
		if (!scream.isPlaying) {
			scream.Play ();
		}
	}
}
