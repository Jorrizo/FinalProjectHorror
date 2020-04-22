using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidingSpotCamera : MonoBehaviour
{
    //script à mettre sur les virtual camera sur les cachettes

    public float mouseSensitivity = 100f;

    public Transform hidingSpot;

    float xRotation = 0f;
    float yRotation = 0f;


    //remplir dans l'inspecteur avec des valeurs > à 0
    public float BottomLimit;
    public float TopLimit;
    public float LeftLimit;
    public float RightLimit;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("MouseX") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("MouseY") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -BottomLimit, TopLimit);

        yRotation -= mouseX;
        yRotation = Mathf.Clamp(yRotation, -RightLimit, LeftLimit);

        transform.localRotation = Quaternion.Euler(xRotation, -yRotation, 0f);
    }
}
