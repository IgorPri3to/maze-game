using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraLook : MonoBehaviour
{
    public float mouseSensivility = 1.5f;
    public float xRotation = 0;
    public Transform playerBody;

    void Start()
    {
        CursorManager.ToggleCursor(false);
    }

    void Update()
    {
        if (GameManager.Instance.IsPaused) return;
        float mouseX = Input.GetAxis("Mouse X") * mouseSensivility;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensivility;
        xRotation += mouseY;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(-xRotation, 0, 0);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}