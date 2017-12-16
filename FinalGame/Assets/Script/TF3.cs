using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TF3 : MonoBehaviour {
	public float yAngle;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//changeY ();
		this.transform.eulerAngles = new Vector3(0,90-yAngle,0);
	}

	public void Angle(float i){
		yAngle = i;
	}
}
