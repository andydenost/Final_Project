﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanAction : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate (0,0,60*Time.deltaTime);
	}
}
