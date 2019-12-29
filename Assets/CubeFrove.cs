using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFrove : MonoBehaviour {

	public float GSpeed;
	public bool toGrow = false;


	// Use this for initialization
	void Start () {
		GSpeed = 3;



	}
	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.CompareTag ("Screen")) {
			
			toGrow = true;

		}
	}

	// Update is called once per frame
	void Update () {
		if (transform.position.y < 2.5 && toGrow) {
			transform.Translate (Vector3.up * GSpeed * Time.deltaTime);



		}
	}
}
