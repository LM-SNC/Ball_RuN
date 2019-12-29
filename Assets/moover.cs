using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moover : MonoBehaviour {
	
	public float speed = 70f;
	public float speedHorizont = 5f;
	public float zPOS;
	public float posX;
	public float posY;
	public float startZpos;
	public float amplitude = 10;

	public float zzPOS;
	public float yyPOS;
	public float xxPOS;
	public bool jump=false;
	public GameObject spawnobject;
	public GameObject spawnpoint;

	// Use this for initialization
	void Start () {
		speed = 3f;
		speedHorizont = 2f;


	}
	
	// Update is called once per frame
	void Update () {

		//TT 





		if (jump) {
			
			posY = 2.5f + Mathf.Sin ((transform.position.z - startZpos) / 2f * Mathf.PI / 2f) * amplitude;
		} else {
			posY = transform.position.y;
			gameObject.GetComponent<Rigidbody> ().useGravity = true;
		}

		transform.position = new Vector3 (posX,posY, zPOS);
		zPOS += speed * Time.deltaTime;
		if (Input.GetKeyDown (KeyCode.T)) {
			speed++;
		}
		if (Input.GetKeyDown (KeyCode.G)) {
			if (speed < 3) {
				speed++;
			}
			speed--;
		}

		Debug.Log (Input.GetAxis ("Horizontal"));
		Debug.Log (Input.GetAxis ("Mouse X"));
		Debug.Log (Input.GetMouseButton(1));
		posX += Input.GetAxis ("Horizontal") * speedHorizont * Time.fixedDeltaTime;
		if (zPOS > zzPOS - 20)
		{
			zzPOS += 20f;
			Instantiate(spawnobject, spawnpoint.transform.position = new Vector3(xxPOS, yyPOS, zzPOS + Random.Range(0,3)), Quaternion.identity);
		}
		if (Input.GetKeyDown (KeyCode.R)) {
			posX = 0f;
			zPOS = 0f;
		}








	}

	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.CompareTag ("cub")) {
			gameObject.SetActive (false);
		} else if (other.gameObject.CompareTag ("floor")) {
			jump = false;
			

		}
		//if (other.gameObject.CompareTag ("Finish")) {
		//	other.gameObject.GetComponent <Rigidbody> ().velocity =* 5f;
		//}
			
	}
}
