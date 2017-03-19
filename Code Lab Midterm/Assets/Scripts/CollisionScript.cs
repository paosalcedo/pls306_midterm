using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionScript : MonoBehaviour {

	// Use this for initialization
	void PlayerIsDead(){
		Debug.Log ("Message received! Player is dead, we hear!");
		Invoke ("DelayedRestart", 3f);
	}

	void DelayedRestart()
	{
		SceneManager.LoadScene ("first");
	}
}
