using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	// Use this for initialization
	public Transform target;
	private Vector3 modiTargetPos;
	public Vector3 modi;
	public float smoothSpeed;
	public Vector3 offset;
	private Vector3 desiredPosition;
	private Vector3 smoothedPosition;
	public Transform modiTarget;
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		modiTargetPos = target.position + modi;
		modiTarget.position = modiTargetPos;
	}

	void FixedUpdate(){
		desiredPosition = target.position + offset;
		smoothedPosition = Vector3.Lerp (transform.position,desiredPosition,smoothSpeed);
		transform.position = smoothedPosition;
		transform.LookAt (modiTarget);
	}
}
