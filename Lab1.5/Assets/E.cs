using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E : MonoBehaviour
{
    public float amplitude = 45f;       // Maximum angular displacement (in degrees)
    public float period = 2f;            // Time taken for one complete cycle (in seconds)

    private float elapsedTime = 0f;      // Time elapsed since the start of simulation

    void Update()
    {
        // Update elapsed time
        elapsedTime += Time.deltaTime;

        // Calculate angular displacement using the equation of simple harmonic motion
        float angularDisplacement = amplitude * Mathf.Sin(2 * Mathf.PI * (elapsedTime / period));

        // Apply rotation around the z-axis
        transform.rotation = Quaternion.Euler(0f, 0f, angularDisplacement);
    }
}
