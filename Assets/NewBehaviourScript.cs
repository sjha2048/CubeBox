using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class NewBehaviourScript : MonoBehaviour {

	public Rigidbody rb;

	public float forward = 2000f;
	public float sideway = 500f;

	// Use this for initialization

	// Update is called once per frame
	void Update () {
		rb.AddForce(0, 0, forward * Time.deltaTime);

		if (Input.GetKey ("d")) {
			rb.AddForce (sideway * Time.deltaTime, 0, 0,ForceMode.VelocityChange);

		}

		if (Input.GetKey ("a")) {
			rb.AddForce (-sideway * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

		}



	
	}
}
