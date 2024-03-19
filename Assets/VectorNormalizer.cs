using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class VectorNormalizer : MonoBehaviour
{
    void Start()
    {
        Vector3 vector1 = new Vector3(1, 8, -7);
        Vector3 vector2 = new Vector3(2, 0, -6);

        Vector3 sum = vector1 + vector2;

        Vector3 normalizedSum = sum.normalized;

        Debug.Log("Нормалізована сума векторів: " + normalizedSum);
    }
}