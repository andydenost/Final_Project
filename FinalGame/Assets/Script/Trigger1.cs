using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger1 : MonoBehaviour {

	public bool tri1;
	// Use this for initialization
	void Start () {
		tri1 = false;
	}
	
	// Update is called once per frame
	void Update () {
		//tr1 = gm.door;
	}

	void OnTriggerEnter(Collider collider){
		if(collider.tag=="enemy"){
		tri1 = true;
		}
	}
}
