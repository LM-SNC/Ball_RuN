using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MC : MonoBehaviour
{
    public float cordz;
    public float cordy;
    public static bool GM = false;
    public static float speed;
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
        speed = 5;
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

        Debug.Log("MC::Update(); -- GM:" + GM);
        if (GM == false)
        {

            if (cordz > zzPOS - 20)
            {
                zzPOS += 20f;
                Instantiate(spawnobject, spawnpoint.transform.position = new Vector3(xxPOS, yyPOS, zzPOS), Quaternion.identity);
                speed = speed + Random.Range(0.1f, 0.3f);
                speedMoove += 0.001f;
                
            }
            if(cordy < -1){
                cordy = 10;
                cordz = 0;
                cordx = 0;
                GM = true;
            }
            if (cordz > zzzPOS)
            {
                xxxPOS = Random.Range(0, 3);
                zzzPOS = zzzPOS + Random.Range(7F, 15F);


                Instantiate(spawnobject1, spawnpoint1.transform.position = new Vector3(Random.Range(-1, 2), Random.Range(-5f, -1f), zzzPOS + Random.Range(5F, 8F)), Quaternion.identity);
                Instantiate(spawnobject1, spawnpoint1.transform.position = new Vector3(Random.Range(3, 5f), Random.Range(-5f, -1f), zzzPOS + Random.Range(8F, 15F)), Quaternion.identity);

            }
           // if (Input.GetKeyDown(KeyCode.F))
           // {
           //     Destroy(spawnobject);
           //     if (cordz > zzzPOS + 5)
           //     {
                  //  Destroy(spawnobject1);
           //     }

         //   }

            if (GM == true){
                speed = 0;
                speedMoove = 0;
            }

            float moovehoriaontal = Input.GetAxis("Horizontal");
            cordx = cordx += speedMoove * moovehoriaontal * Time.fixedDeltaTime;
            cordz = cordz += speed * Time.deltaTime;
            transform.position = new Vector3(cordx, transform.position.y, cordz);






        }
    }
}
