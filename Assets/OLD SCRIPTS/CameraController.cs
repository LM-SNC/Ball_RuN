using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // For Android
    private Vector3 firstpoint;
    private Vector3 secondpoint;
    private float xAngle = 0.0f; //angle for axes x for rotation
    private float yAngle = 0.0f;
    private float xAngTemp = 0.0f; //temp variable for angle
    private float yAngTemp = 0.0f;
    private GameObject playRot;
    // For Android

    public float height = 1f;
    public float distance = 2f;
    private Vector3 offsetX;
    private Vector3 offsetY;

    public float turnSpeed = 4.0f;
    public Transform player;
    private Vector3 offset;

    void Start()
    {
        offsetX = new Vector3(0, height, distance);
        offsetY = new Vector3(0, 0, distance);

        player = GameObject.Find("Player").transform;
        offset = new Vector3(player.position.x, player.position.y + 8.0f, player.position.z + 7.0f);
    }

    private void Update()
    {
        // if (PlayerController.instance.TabletMode == 1)
        {
            if (Input.touchCount > 0)
            {
                if (Input.GetTouch(0).phase == TouchPhase.Began)
                {
                    firstpoint = Input.GetTouch(0).position;
                    xAngTemp = xAngle;
                    yAngTemp = yAngle;
                }
                if (Input.GetTouch(0).phase == TouchPhase.Moved)
                {
                    secondpoint = Input.GetTouch(0).position;
                    //Mainly, about rotate camera. For example, for Screen.width rotate on 180 degree
                    yAngle = yAngTemp - (secondpoint.y - firstpoint.y) * 90.0f / Screen.height;
                    if (yAngle < 0)
                        yAngle += 360;
                    if (yAngle > 360)
                        yAngle -= 360;
                    if (yAngle > 90 && yAngle < 270)
                        xAngle = xAngTemp - (secondpoint.x - firstpoint.x) * 180.0f / Screen.width;
                    else
                        xAngle = xAngTemp + (secondpoint.x - firstpoint.x) * 180.0f / Screen.width;
                    if (xAngle < 0)
                        xAngle += 360;
                    if (xAngle > 360)
                        xAngle -= 360;
                    transform.rotation = Quaternion.Euler(yAngle, xAngle, 0.0f);
                }
            }
        }
    }

    private void LateUpdate()
    {
        // Debug.Log("CameraController::LateUpdate(); -- Input.GetAxis(Mouse X):" + Input.GetAxis("Mouse X"));
        // offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offset;
        // Debug.Log("CameraController::LateUpdate(); -- offset:" + offset);
        // Debug.Log("CameraController::LateUpdate(); -- transform:" + transform);
        // Debug.Log("CameraController::LateUpdate(); -- transform.position:" + transform.position);
        // Debug.Log("CameraController::LateUpdate(); -- player:" + player);
        // Debug.Log("CameraController::LateUpdate(); -- player.position:" + player.position);
        // transform.position = player.position + offset;
        // transform.LookAt(player.position);

        offsetX = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offsetX;
        offsetY = Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * turnSpeed, Vector3.right) * offsetY;
        transform.position = player.position + offsetX + offsetY;
        transform.LookAt(player.position);

        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offset;
        transform.position = player.position + offset;
        transform.LookAt(player.position);
    }
}
