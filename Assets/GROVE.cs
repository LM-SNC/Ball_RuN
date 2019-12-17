using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GROVE : MonoBehaviour
{
    	public bool toGrow = false;
	public float growSpeed = 2f;
	bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        growSpeed = 3f;
        
    }

    // Update is called once per frame
    void Update()
    {
        	if (transform.position.y < 2.4f) {
			transform.Translate (Vector3.up * growSpeed * Time.deltaTime);
		}
    }
}
