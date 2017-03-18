using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketLauncher : MonoBehaviour {

	public float explosionRadius = 20.0f;
	public float explosionPower = 20f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			ShootRay ();
		}
	}
	void ShootRay(){

		//1. declare your raycast 
		Ray ray = new Ray (Camera.main.transform.position, Camera.main.transform.forward);
		//2. set up our raycast hit info variable too 

		RaycastHit rayHit = new RaycastHit ();

		//3. we're ready to shoot our raycast

		if (Physics.Raycast (ray, out rayHit, 100f)) {
			if (rayHit.transform.tag == "Ground" && rayHit.rigidbody != null || rayHit.transform.tag == "Wall" && rayHit.rigidbody != null) {
				Collider[] colliders = Physics.OverlapSphere (rayHit.point, explosionRadius);
				foreach (Collider hit in colliders) {
					Rigidbody rb = hit.GetComponent<Rigidbody> ();

					//apply explosion force on other objects.
					//apply explosion force on player.
					if(rb.tag == "Player"){
						Vector3 tossDir;
						tossDir = rb.transform.position - rayHit.point;
						rb.AddForce (tossDir.normalized * explosionPower, ForceMode.VelocityChange);							
					}
				}
			}
		}



	}
}
