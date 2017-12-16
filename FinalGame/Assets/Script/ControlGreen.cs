using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ControlGreen : MonoBehaviour {

	//private Vector3 _movement;
	private float x,y,z;
	//Rigidbody ballRig;

	// Use this for initialization
	void Start () {
		//ballRig = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
		//_movement = Vector3.zero;
		//rotation = Quaternion.Euler (0,0,0);
		x=0;
		y=0;
		z=0;
		//speed = 5;

		if( Input.GetKey( KeyCode.UpArrow ) )
		{
			z = 5*Time.deltaTime;
		}

		if( Input.GetKey( KeyCode.DownArrow ) )
		{
			z = -5*Time.deltaTime;
		}
		if( Input.GetKey( KeyCode.LeftArrow ) )
		{
			x = -5*Time.deltaTime;
		}

		if( Input.GetKey( KeyCode.RightArrow ) )
		{
			x = 5*Time.deltaTime;
		}
		transform.Translate (x,y,z);
		Debug.Log ("x:"+x);
		// follow this pattern
		//Movement();

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
