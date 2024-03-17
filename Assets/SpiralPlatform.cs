using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiralPlatform : MonoBehaviour
{
   
    void Start()
    {
        
    }

    public float speed = 5f;
    public float radius = 5f;
    public float height = 0.1f;
    public float spiralCoefficient = 2f;

    void Update()
    {
        float angle = Time.time * speed;
        float x = radius * spiralCoefficient * Mathf.Cos(angle);
        float y = height * angle;
        float z = radius * spiralCoefficient * Mathf.Sin(angle);

        transform.Translate(new Vector3(x, y, z) * Time.deltaTime);
    }
}
