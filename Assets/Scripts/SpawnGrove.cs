using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGrove : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject spawnpoint;
    public GameObject spawnobject;
    
    public float zPOS;
    void Start()
    {
        zPOS = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        zPOS +=20f;
         Vector3 movement = new Vector3(transform.position.x, transform.position.y, zPOS);
        //if(){
           // Instantiate(spawnobject,spawnpoint.transform.position = new Vector3(transform.position.x, transform.position.y, zPOS) ,Quaternion.identity);
            
      //  }
        
    }
}
