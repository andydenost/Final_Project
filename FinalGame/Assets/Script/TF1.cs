using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TF1 : MonoBehaviour {
	public float y;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//changeY ();
		this.transform.position = new Vector3(10,-3+y,0);
	}

	public void Y(float i){
		y = i;
	}
}
