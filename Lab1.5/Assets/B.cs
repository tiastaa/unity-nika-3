using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B : MonoBehaviour
{
    public float rotationSpeed = 50f; // Speed of rotation

    void Update()
    {
        // Calculate translation using rotation speed and time
        float translation = rotationSpeed * Time.deltaTime;

        // Get the center of the object
        Vector3 pivotPoint = transform.position;

        // Rotate the object around its center
        transform.RotateAround(pivotPoint, Vector3.down, translation);
    }
}
