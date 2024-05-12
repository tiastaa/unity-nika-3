using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mkr : MonoBehaviour
{
    public Rigidbody sphereRigidbody;
    public float throwForce = 10f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ThrowSphere();
        }
    }

    void ThrowSphere()
    {
        sphereRigidbody.AddForce(transform.forward * throwForce, ForceMode.Impulse);
    }
}


