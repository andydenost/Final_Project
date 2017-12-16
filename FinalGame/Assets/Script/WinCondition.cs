using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinCondition : MonoBehaviour {
	
	public GameObject wt;
	public static Text wintext;
	// Use this for initialization
	void Start () {
		//wintext = "Find You!";
		wintext=wt.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision){
		//Debug.Log ("222222222222222222222");
		if(collision.collider.tag=="prince"){
			//Debug.Log ("in");
			wintext.text="Find you!";
		}
	}
}
