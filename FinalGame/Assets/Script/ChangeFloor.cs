using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeFloor : MonoBehaviour {
	Ray ray;
	RaycastHit hit;
	bool[,] b= new bool[3,3]{{false,false,false},{false,false,false},{false,false,false}};
	float[,] floorAngle = new float[3,3]{{90,90,90},{90,90,90},{90,90,90}};
	void Start () {
		for (int i = 0; i < 3; i++) {
			for (int j = 0; j < 3; j++) {
				string s = i.ToString () + j.ToString ();
				GameObject.FindGameObjectWithTag (s).GetComponent<Renderer> ().material.color = Color.red;
				GameObject.FindGameObjectWithTag(s).transform.eulerAngles = new Vector3(0, 0, floorAngle[i,j]);
			}
		}
	}

	void Update () {
		ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		for (int i = 0; i < 3; i++) {
			for (int j = 0; j < 3; j++) {
				
				string s = i.ToString () + j.ToString ();
					if (b [i, j] == true) {
						if (floorAngle [i, j] >= 0) {
							GameObject.FindGameObjectWithTag (s).transform.eulerAngles = new Vector3 (0, 0, floorAngle [i, j]);
							floorAngle [i, j] -= 100 * Time.deltaTime;
						}
						if (floorAngle [i, j] < 0) {
							floorAngle [i, j] = 0;
						}
					} else {
						if (floorAngle [i, j] <= 90) {
							GameObject.FindGameObjectWithTag (s).transform.eulerAngles = new Vector3 (0, 0, floorAngle [i, j]);
							floorAngle [i, j] += 100 * Time.deltaTime;
						}
						if (floorAngle [i, j] > 90) {
							floorAngle [i, j] = 90;
						}
					}
			}
		}
		if(Physics.Raycast (ray,out hit)){
			if(Input.GetButtonDown("Fire1")==true){
				for(int i=0;i<3;i++){
					for(int j=0;j<3;j++){
						string s = i.ToString () + j.ToString ();
						if(hit.collider.tag.Equals(s)){
							b [i,j] = !b [i,j];
							if(j-1>=0){
								b [i,j-1] = !b [i,j-1];
							}
							if(j+1<3){
								b [i,j+1] = !b [i,j+1];
							}
							if(i-1>=0){
								b [i-1,j] = !b [i-1,j];
							}
							if(i+1<3){
								b [i+1,j] = !b [i+1,j];
							}
						}
					}
				}

			}
		}
		if(PassCondition()){
			for (int i = 0; i < 3; i++) {
				for (int j = 0; j < 3; j++) {
					string s = i.ToString () + j.ToString ();
					GameObject.FindGameObjectWithTag (s).GetComponent<Renderer> ().material.color = Color.green;
				}
			}
		}
	}
	public bool PassCondition(){
		for(int i=0;i<3;i++){
			for(int j=0;j<3;j++){
				if(floorAngle[i,j]!=0){
					return false;
				}
			}
		}
		return true;
	}	


}
