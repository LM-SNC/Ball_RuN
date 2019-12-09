using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caps : MonoBehaviour {

	public float speed = 4f;
	public float yPOS;
	public float posX;

	// Use this for initialization
	void Start () {
		speed = 4f;
	}

	// Update is called once per frame
	void Update () {
		posX += speed * Time.deltaTime;
		//if (Key) {
		//	posX += 1;
		//}
		transform.position = new Vector3 (posX,transform.position.y,transform.position.z);
	}
}

