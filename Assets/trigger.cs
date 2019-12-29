using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trigger : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Game over!");
            //GUI.Label(new Rect(330, 120, 100, 20), "Game over!");
            Debug.Log("trigger::OnTriggerEnter(); -- MC.GM:" + MC.GM);
            MC.GM = true;
            Debug.Log("trigger::OnTriggerEnter(); -- MC.GM:" + MC.GM);
        }
    }
    void OnTriggerStay(Collider other)
    {
 if (other.tag == "Player")
        {
            Debug.Log("Game over!");
            //GUI.Label(new Rect(330, 120, 100, 20), "Game over!");
            Debug.Log("trigger::OnTriggerEnter(); -- MC.GM:" + MC.GM);
            MC.GM = true;
            Debug.Log("trigger::OnTriggerEnter(); -- MC.GM:" + MC.GM);
        }
    }
    void OnTriggerExit(Collider other)
    {
         if (other.tag == "Player")
        {
            Debug.Log("Game over!");
            //GUI.Label(new Rect(330, 120, 100, 20), "Game over!");
            Debug.Log("trigger::OnTriggerEnter(); -- MC.GM:" + MC.GM);
            MC.GM = true;
            Debug.Log("trigger::OnTriggerEnter(); -- MC.GM:" + MC.GM);
        }
    }
}
