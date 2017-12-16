using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ControlRed : MonoBehaviour {

	//private Vector3 _movement;
	private float x,y,z;
	public GameObject gb;
	//Rigidbody ballRig;

	// Use this for initialization
	void Start () {
		//ballRig = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {
		//transform.position=Vector3.Lerp (transform.position,gb.transform.position,Time.deltaTime);
	}


	/*void Movement(){
		x = Input.GetAxisRaw ("Horizontal");
		z = Input.GetAxisRaw ("Vertical");

		Vector3 dir;
		dir = new Vector3 (x, y, z);
		dir = dir.normalized;
		ballRig.MovePosition(transform.position+dir*Time.deltaTime*speed);

	}*/
}
