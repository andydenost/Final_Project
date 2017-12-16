using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour {

	Ray ray;
	RaycastHit hit;
	public GameObject gb;
	// Use this for initialization
	void Start () {
		
		//hit = new RaycastHit ();
	}
	
	// Update is called once per frame
	void Update () {
		ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		if(Physics.Raycast (ray,out hit)){
		if(hit.collider.tag=="plane"){
				if(Input.GetButtonDown("Fire1")==true){
					gb.transform.position = hit.point;
					//print (gb.transform.position);
					Instantiate(gb);
			        print ("Z");
				}
		}
		}
	}
}
