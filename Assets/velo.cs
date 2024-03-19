using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;

public class BicycleController : MonoBehaviour
{
    public float speed = 5f, rotationSpeed = 100f;

    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
    }
}