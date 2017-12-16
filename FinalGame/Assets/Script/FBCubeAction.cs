using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FBCubeAction : MonoBehaviour {
	public float z;
	float speed;
	// Use this for initialization
	void Start () {
		z = 7.50f;
		speed = 3.0f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (0,0,z);
		z -= speed * Time.deltaTime;
	}

	void OnCollisionEnter(Collision c){
		//Debug.Log ("???");
		if(c.collider.tag=="platform2"||c.collider.tag=="platform1"){
			speed = -speed;
		}
	}
}
