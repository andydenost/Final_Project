using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

	//GameMaze gm;
	// Use this for initialization
	public GameObject trigger1;
	public GameObject trigger2;
	//public GameObject gb;
	//GameObject princess;
	void Start () {
		//gm = gameObject.GetComponents<GameMaze> ();
		//princess=GameObject.FindGameObjectWithTag("princess");
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (trigger1.GetComponent<Trigger1>().tri1);
		Debug.Log (trigger2.GetComponent<Trigger2>().tri2);
		if(trigger1.GetComponent<Trigger1>().tri1==true&&trigger2.GetComponent<Trigger2>().tri2==true){
			Destroy (this.gameObject);
		}
			
}
}
