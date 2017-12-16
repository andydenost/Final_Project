using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TF2 : MonoBehaviour {
	public float z;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//changeY ();
		this.transform.position = new Vector3(12,0,2-z);
	}

	public void Z(float i){
		z = i;
	}
}
