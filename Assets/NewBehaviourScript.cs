using UnityEngine;

public class DominoController : MonoBehaviour
{
    private bool isFallen = false;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isFallen)
        {
            Fall();
        }
    }

    void Fall()
    {
        rb.useGravity = true;

        float rotateSpeed = 5f;
        rb.AddTorque(Vector3.left * rotateSpeed, ForceMode.VelocityChange);

        isFallen = true;
    }
}
