using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GROVE : MonoBehaviour
{
    public bool toGrow = false;
    public static float growSpeed = 2f;
    bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {

        growSpeed = 4;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Pos:" + transform.position.y);
        if (transform.position.y < 2.4)
        {
            growSpeed += 0.01f;
            transform.Translate(Vector3.up * growSpeed * Time.deltaTime);

        }
    }
}