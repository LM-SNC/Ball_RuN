using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveController : MonoBehaviour
{
    public float speed = 100f;
    
    public float jump = 1f;
    public float zPOS;
    public float yPOS;
    public float xPOS;

    // Use this for initialization
    void Start()
    {
        speed = 7f;
    }

    // Update is called once per frame
    void Update()
    {
        //float moveHORIZONTAL = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(xPOS, yPOS, transform.position.z);
        if (Input.GetKey(KeyCode.A))
        {
            xPOS = xPOS -= speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            xPOS = xPOS += speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            zPOS = zPOS += speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            zPOS = zPOS -= speed * Time.deltaTime;
        }
                if (Input.GetKeyDown(KeyCode.Space))
        {
            yPOS = yPOS += jump * Time.deltaTime;
        }

        //zPOS += speed * Time.deltaTime;

        transform.position = new Vector3(xPOS, yPOS, zPOS);
    }
}