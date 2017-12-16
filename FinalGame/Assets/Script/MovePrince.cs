using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePrince : MonoBehaviour {
	//GameObject gb;
	public ChangeFloor cf;
	public TF1 tf1;
	public TF2 tf2;
	public TF3 tf3;
	float speed;
	Vector3 stopPos1;
	Vector3 stopPos2;
	bool s,h;
	public SliderControl sc;
	// Use this for initialization
	void Start () {
		speed = 2.0f;
		stopPos1 = new Vector3 (-4.0f,1.0f,0.0f);
		stopPos2 = new Vector3 (8.0f,1.0f,0.0f);
		s = false;
		h = false;
	}
	
	// Update is called once per frame
	void Update () {
		//this.transform.Translate(speed*Time.deltaTime,0,0);

		if (cf.PassCondition ()) {//trick1 pass! go to trick2
			if (tf1.y == 3 && tf2.z == 2 && tf3.yAngle== 90) { //trick2 pass! go to next level pos
				this.transform.Translate (speed * Time.deltaTime, 0, 0);
				if(h==false){
					sc.Hide();
					h=true;
				}
			} else {
				if (this.transform.position.x >= stopPos2.x) {
					this.transform.position = stopPos2;
					if(s==false){
						sc.Show();
						s=true;
					}
				} else {
					this.transform.Translate (speed * Time.deltaTime, 0, 0);
				}
			}
		} else {
			if (this.transform.position.x >= stopPos1.x) {
				this.transform.position = stopPos1;
			} else {
				this.transform.Translate (speed * Time.deltaTime, 0, 0);
			}
		}
	}


}
