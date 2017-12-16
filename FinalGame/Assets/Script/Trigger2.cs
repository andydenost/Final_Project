using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger2 : MonoBehaviour {
	public bool tri2;
	// Use this for initialization
	void Start () {
		tri2 = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider collider){
		if(collider.tag=="enemy"){
			tri2 = true;
		}
	}
}
