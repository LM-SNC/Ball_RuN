using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class r : MonoBehaviour {
	public float speed;
	public bool toGrov = false;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.R) && transform.position.y < 10){

			transform.Translate(Vector3.up * 5 * Time.deltaTime);
		}
		transform.Rotate (0f, 5f, 0f);


 }
}
