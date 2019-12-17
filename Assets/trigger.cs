using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trigger : MonoBehaviour
{
       
void OnTriggerEnter (Collider other)
{
    if(other.tag == "Player")
    {
        Debug.Log ("Game over!");
        GUI.Label(new Rect(330, 120, 100, 20), "Game over!");
        MC.GM = true;
        
        

    }

}
void OnTriggerStay (Collider other)
{

}
void OnTriggerExit (Collider other)
{

}
}
