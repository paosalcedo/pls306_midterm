using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateOpenScript : MonoBehaviour {
	int startScore;
	// Use this for initialization
	void Start () {
		startScore = ScoreKeeper.instance.Score;
	}
	
	// Update is called once per frame
	void Update () {
		OpenGate();
	}
	
	void OpenGate ()
	{
		if (ScoreKeeper.instance.Score - startScore > 6) {
			Debug.Log("CONGRATS! Gate opening!");
			Destroy(gameObject);
		}
	}
}
