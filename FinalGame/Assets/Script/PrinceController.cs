using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinceController : MonoBehaviour {

	public float jumpForce,x,z;
	//private CharacterController controller;
	private Rigidbody rb;
	private bool onGround;
	//public FBCubeAction fb;
	//Vector3 posOffset;
	//float newZ;
	//bool b;
	//Vector3 cha;
	// Use this for initialization
	void Start () {
		//controller = GetComponent<CharacterController> ();
		rb = GetComponent<Rigidbody> ();
		onGround = false;
		//newZ = 0;
		//b = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (onGround) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				rb.velocity = new Vector3 (0,jumpForce,0);
				onGround = false;
			}
		}
		controlP ();
		if(transform.position.y<-5){
			transform.position = new Vector3 (0,1,0);
		}
	}

	void OnCollisionEnter(Collision c){
			onGround = true;
	}

	/*void OnCollisionStay(Collision c){
		if(c.collider.tag=="FBCube"){
			if(b=false){
				cha = transform.position - fb.transform.position;
				b = true;
			}
			newZ = newZ + posOffset.z;
			transform.position = new Vector3(transform.position.x, transform.position.y, fb.transform.position.z+cha.z+newZ);
			Debug.Log ("second:"+posOffset);
		}

	}*/

	void controlP(){
		//Vector3 lastPos = transform.position;
		if( Input.GetKey( KeyCode.W ) )
		{
			z = 5*Time.deltaTime;
		}

		if( Input.GetKey( KeyCode.S ) )
		{
			z = -5*Time.deltaTime;
		}
		if( Input.GetKey( KeyCode.A ) )
		{
			x = -5*Time.deltaTime;
		}

		if( Input.GetKey( KeyCode.D ) )
		{
			x = 5*Time.deltaTime;
		}
		transform.Translate (x,0,z);
		//posOffset = transform.position - lastPos;
		//Debug.Log ("first:"+posOffset);
		x = 0;
		z = 0;

	}
}
