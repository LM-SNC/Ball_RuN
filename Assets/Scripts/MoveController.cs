using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveController : MonoBehaviour
{
    public float speedMove = 10000f;
    public float speedJump = 50f;
    public Text TextLabel;
    private GameObject textGameObject;

    void Start()
    {
        textGameObject = new GameObject("myTextGO");
        textGameObject.transform.SetParent(this.transform);
        textGameObject.transform.localPosition = Vector3.zero;
    }

    void FixedUpdate()
    {
        float moveHorizontal = -Input.GetAxis("Horizontal");
        float moveVertical = -Input.GetAxis("Vertical");
        // Debug.Log("MoveController::FixedUpdate(); -- moveHorizontal:" + moveHorizontal);
        // Debug.Log("MoveController::LateUpdate(); -- moveVertical:" + moveVertical);
        Vector3 movement = new Vector3(moveHorizontal * speedMove, 0.0f, moveVertical * speedMove);
        GetComponent<Rigidbody>().AddForce(movement * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 jump = new Vector3(0.0f, 100.0f * speedJump, 0.0f);
            GetComponent<Rigidbody>().AddForce(jump);
        }
    }

    void Update()
    {
        Vector3 namePose = Camera.main.WorldToScreenPoint(textGameObject.transform.position);
        TextLabel.transform.position = namePose;

        TextLabel.text = transform.position + "";
        // textGameObject.GetComponent<Text>().text = transform.position + "";
        // Debug.Log("MoveController::Update(); -- text:" + gameObject.GetComponentInChildren<Text>().text);
    }
}
