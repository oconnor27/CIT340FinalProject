using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMouse : MonoBehaviour
{
    public float rotationSpeed = 5.0f; // Adjust this to control the rotation speed
    public float minRotation = -45.0f;
    public float maxRotation = 45.0f;

    private float currentRotation = 0.0f;

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");

        currentRotation += mouseX * rotationSpeed * Time.deltaTime;
        currentRotation = Mathf.Clamp(currentRotation, minRotation, maxRotation);

        transform.rotation = Quaternion.Euler(0, 0, currentRotation);
    }
       
}
