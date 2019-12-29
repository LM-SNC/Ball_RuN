using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class g : MonoBehaviour {

	// Use this for initialization
	public bool toGrov;
	public float z;
	void Start () {
		z = 16.2732f;
	}

	// Update is called once per frame
	void Update () {
		


		if(Input.GetKey(KeyCode.G) && transform.position.z < 26){
			transform.position = new Vector3 (transform.position.x,transform.position.y, z += 2 * Time.deltaTime);
				}
		transform.Rotate (0f, 0f, 5f);
		
	}
}
