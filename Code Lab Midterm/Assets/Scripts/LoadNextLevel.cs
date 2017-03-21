using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNextLevel : MonoBehaviour {

	public float delay = 3.0f;
	public float keepTime;
	public static LoadNextLevel instance;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerExit(Collider coll){
		if (coll.tag == "Player") {
			Invoke ("SendLoadMessage", delay);
		}
	}

	void SendLoadMessage(){
		GameObject.Find ("Level Holder").SendMessage ("LoadNextLevel");
	}
}
