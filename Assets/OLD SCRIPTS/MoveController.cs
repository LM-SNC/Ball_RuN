using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveController : MonoBehaviour
{
    public float speed = 100f;

    public float jump =1f;
    public float zPOS;
    public float zzPOS;
    public float yyPOS;
    public float xxPOS;
    public float yPOS;
    public float xPOS;

    public GameObject spawnpoint;
    public GameObject spawnobject;

    // Use this for initialization
    void Start()
    {
        speed = 7f;
        // xPOS = 0f;
        // yPOS = 2.419f;
      
        // zPOS = 0f;
        xxPOS = 0f;
        zzPOS = 0f;
        yyPOS = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        //float moveHORIZONTAL = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");
  Vector3 movement = new Vector3(xPOS, yPOS, zPOS);

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
            if (zPOS > zzPOS - 20)
            {
                zzPOS += 20f;
                Instantiate(spawnobject, spawnpoint.transform.position = new Vector3(xxPOS, yyPOS, zzPOS), Quaternion.identity);
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            zPOS = zPOS -= speed * Time.deltaTime;
        }
        if (xPOS > 3.67f)
        {
            xPOS -= 0.08F;
        }
        if (xPOS < -1.067)
        {
            xPOS += 0.08F;
        }
         if (Input.GetKey(KeyCode.Space))
        {
            yPOS = transform.position.y;
            transform.position = new Vector3(xPOS, yPOS += jump, zPOS);
        }
        transform.position = new Vector3(xPOS, transform.position.y, zPOS);
        //zPOS += speed * Time.deltaTime;


    }
}