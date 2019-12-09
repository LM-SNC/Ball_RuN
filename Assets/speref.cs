using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speref : MonoBehaviour {
	public float speed = 2f;
	public float yPOS;
	public float posX;

	// Use this for initialization
	void Start () {
		speed = 2;
	}

	// Update is called once per frame
	void Update () {
		yPOS += speed * Time.deltaTime;
		//if (Key) {
		//	posX += 1;
		//}
		transform.position = new Vector3 (transform.position.x,yPOS,transform.position.z);
	}
}

