using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollectScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider coll)
	{
		if (coll.tag == "Player") {
			//Add to score.
			ScoreKeeper.instance.Score += 1;
			Debug.Log (ScoreKeeper.instance.Score);
			AudioSource pickupSound;
			pickupSound = GetComponent<AudioSource> ();
			
			if (pickupSound.isPlaying == false) {
				pickupSound.Play ();
			}
			
			this.GetComponent<MeshRenderer>().enabled = false;
			this.GetComponent<Collider>().enabled = false;	

			//play sound.
			
		}
	}
}
