using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zavdvector : MonoBehaviour
{
    void Start()
    {
        // Задані вектори
        Vector3 vector1 = new Vector3(4, 0, 7);
        Vector3 vector2 = new Vector3(7, 1, 1);

        // Сума векторів
        Vector3 sumVector = vector1 + vector2;

        // Обчислення довжини суми векторів
        float sumLength = sumVector.magnitude;

        // Виведення результату
        Debug.Log("Довжина суми векторів: " + sumLength);
    }

}
