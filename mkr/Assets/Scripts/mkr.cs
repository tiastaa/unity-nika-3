using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mkr : MonoBehaviour
{
    public Rigidbody cylinderRigidbody;
    public float throwForce = 3f;
    public float throwAngle = 10f; // Кут кидання в градусах

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ThrowCylinder();
        }
    }

    void ThrowCylinder()
    {
        // Обчислюємо компоненти швидкості для кидання під кутом
        float throwAngleInRadians = throwAngle * Mathf.Deg2Rad;
        float throwX = Mathf.Cos(throwAngleInRadians);
        float throwY = Mathf.Sin(throwAngleInRadians);

        // Створюємо вектор швидкості для кидання під кутом
        Vector3 throwDirection = new Vector3(throwX, throwY, 0f).normalized;

        // Застосовуємо силу під кутом до циліндра
        cylinderRigidbody.AddForce(throwDirection * throwForce, ForceMode.Impulse);
    }
}
