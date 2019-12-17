using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MC : MonoBehaviour
{
    public float cordz;
    public float cordy;
     public static bool GM = false;
    public float speed;
    public float speedMoove;
    public float cordx;
     public float zzPOS;
    public float yyPOS;
    public float xxPOS;
         public float zzzPOS;
    public float yyyPOS;
    public float xxxPOS;
        public GameObject spawnpoint;
        public GameObject spawnpoint1;
    public GameObject spawnobject;
    public GameObject spawnobject1;
    // Start is called before the first frame update
    void Start()
    {
        speed = 3;
        speedMoove = 1;
        cordy = 3;
        xxPOS = 0f;
        zzPOS = 0f;
        yyPOS = 0f;
        xxxPOS = 1;
        yyyPOS = 0;
        zzzPOS = 5;
        
    }

    // Update is called once per frame
    void Update()
    {
     
      if(GM == !true)
      {
        
       if (cordz > zzPOS - 20)
            {
                zzPOS += 20f;
                Instantiate(spawnobject, spawnpoint.transform.position = new Vector3(xxPOS, yyPOS, zzPOS), Quaternion.identity);
            }
             if (cordz > zzzPOS)
            {
                xxxPOS = Random.Range (0, 2);
                zzzPOS = zzzPOS + Random.Range (4F, 8F);
                
                
                Instantiate(spawnobject1, spawnpoint1.transform.position = new Vector3(xxxPOS, yyyPOS, zzzPOS), Quaternion.identity);
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                Destroy (spawnobject);
                if(cordz > zzzPOS + 5)
                {
                    Destroy (spawnobject1);
                }

            }
      


      float moovehoriaontal =   Input.GetAxis("Horizontal");
        cordx = cordx += speedMoove * moovehoriaontal * Time.fixedDeltaTime;
        cordz = cordz += speed * Time.deltaTime;
        transform.position = new Vector3(cordx, transform.position.y, cordz);
        
        



        
    }
    }
}
