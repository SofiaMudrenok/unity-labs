using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingBall: MonoBehaviour
{
   
    void Start()
    {
        
    }
    public float speed = 20f;
    public float a = 1f;
    public float stepSize = 0.1f;

    void Update()
    {
        float t = Time.time;
        float x = a * (t - Mathf.Sin(t));
        float y = a * (1 - Mathf.Cos(t));

        transform.position = new Vector3(x, y, 0) * speed * stepSize;
    }
}
