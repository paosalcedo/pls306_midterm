using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeKeeper : MonoBehaviour {

	private float timer;

	public float Timer {
		get{ 
			return timer;
		}
		set{ 
			timer = value;
		}
	}

	public static TimeKeeper instance;

	// Use this for initialization
	void Start ()
	{
		if (instance == null) {
			instance = this;
			DontDestroyOnLoad (this);
		} else {
			Destroy(gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
}
