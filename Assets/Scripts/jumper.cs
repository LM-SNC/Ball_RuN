using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumper : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter (Collider other){
		if (other.CompareTag ("Player")) {
			other.gameObject.GetComponent <Rigidbody> ().useGravity = false;
			other.gameObject.GetComponent <moover> ().startZpos = other.gameObject.transform.position.z;
			other.gameObject.GetComponent <moover> ().jump = true;



		}

	}
}
