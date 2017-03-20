using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotateScript : MonoBehaviour {
	
	public float rotateSpeed = 10f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		RotateCoin();
	}

	void RotateCoin(){
		transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
	}
}
