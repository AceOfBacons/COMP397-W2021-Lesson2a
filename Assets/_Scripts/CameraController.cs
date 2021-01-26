using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float mouseSensitivity = 1000.0f;
    public Transform playerBody;

    private float Xrotation = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        //make cursor invisible
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        Xrotation -= mouseY;
        Xrotation = Mathf.Clamp(Xrotation, -90.0f, 90.0f);

        transform.localRotation = Quaternion.Euler(Xrotation, 0.00f, 0.0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
