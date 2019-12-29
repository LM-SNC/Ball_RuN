using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moove : MonoBehaviour {

	// Use this for initialization
	public float x;
	float speed;

	void Start () {
		
		speed = 2;
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = new Vector3 (x,transform.position.y,transform.position.z);

		x += speed * Time.deltaTime;
		if(x > 5){
			speed = -2;
		}
		if(x < 0){
			speed = 2;
		}




	}
}
