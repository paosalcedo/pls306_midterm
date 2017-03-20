using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotateScript : MonoBehaviour {
	Vector3 coinPos;
	public float rotateSpeed = 10f;
	public float floatSpeed = 1f;
	public float coinOffSetY = 0.1f;
	// Use this for initialization
	void Start () {
		coinPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		RotateCoin();
		FloatCoin();
	}

	void RotateCoin(){
		transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
	}

	void FloatCoin ()
	{
		transform.Translate (Vector3.forward * floatSpeed * Time.deltaTime);

		if (transform.position.y > coinPos.y + coinOffSetY || transform.position.y < coinPos.y - coinOffSetY) {
			floatSpeed *= -1;	
		}
	}
}
