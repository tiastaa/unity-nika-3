using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C : MonoBehaviour
{
    public float angularSpeed = 1f; // Angular speed of rotation
    public float radiusIncrement = 0.1f; // Rate at which the radius increases
    public float heightIncrement = 1f; // Rate at which the height increases

    private float angle = 0f;
    private float radius = 1f;
    private float x = -4;

    void Update()
    {
        // Increment the angle based on time and speed
        angle += angularSpeed * Time.deltaTime;

        // Increase the radius and height based on increments
        radius += radiusIncrement * Time.deltaTime;
        x += heightIncrement * Time.deltaTime;

        // Calculate the new position in polar coordinates
        float y = 1.7f + (radius * Mathf.Cos(angle));
        float z = radius * Mathf.Sin(angle);

        // Translate the object's position
        //transform.Translate(new Vector3(0, y - transform.position.y, z - transform.position.z));

        // Update the object's position in x-axis
        //transform.position = new Vector3(x, transform.position.y, transform.position.z);
        transform.position = new Vector3( x,y, z);
    }
}
