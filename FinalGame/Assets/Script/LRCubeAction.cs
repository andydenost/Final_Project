using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LRCubeAction : MonoBehaviour {
	float x;
	float speed;
	// Use this for initialization
	void Start () {
		x = 0.0f;
		speed = 5.0f;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3 (x,this.transform.position.y,this.transform.position.z);
		x += speed * Time.deltaTime;
		if(x>5.0f||x<-5.0f){
			if(x>5.0f){
				x = 5.0f;
			}else{
				x = -5.0f;
			}
			speed = -speed;
		}
	}
}
