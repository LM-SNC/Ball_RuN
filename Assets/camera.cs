using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Vector3 offset;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - Player.transform.position;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Player.transform.position + offset;
        
    }
}
