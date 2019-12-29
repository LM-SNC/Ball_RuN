using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;
	Vector3 offset;

	void Start () {
		offset = player.transform.position - gameObject.transform.position;

		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position = player.transform.position - offset;
	}
}
