using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moover : MonoBehaviour {
	
	public float speed = 2f;
	public float zPOS;
	public float posX;

	// Use this for initialization
	void Start () {
		speed = 1;
	}
	
	// Update is called once per frame
	void Update () {
		zPOS += speed * Time.deltaTime;
		if (KeyCode.A) {
			posX += 1;
	}
		transform.position = new Vector3 (transform.position.x,transform.position.y, zPOS);



	}
}
