using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class rotate : MonoBehaviour
{
    public float rotationSpeed = 90f; // Speed of rotation in degrees per second

    void Update()
    {
        // Rotate the object around its Z-axis constantly
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }
   

}
