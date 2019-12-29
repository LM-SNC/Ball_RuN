using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b : MonoBehaviour {
	public bool toGrov = false;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.B) && transform.position.x < 10){
			
			transform.Translate(Vector3.right * 5 * Time.deltaTime);
				}
		transform.Rotate (5f, 0f, 0f);
		
	}
}
