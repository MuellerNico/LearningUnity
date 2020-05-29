using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardSpeed = 200f;
    public float sideForce = 200f;

    // Update is called once per frame
    void Start()
    {
        rb.velocity = new Vector3(0, 0, forwardSpeed);
    }
    void Update()
    {
        rb.AddForce(0, 0, forwardSpeed, ForceMode.VelocityChange);

        if (Input.GetKey("a")) {
            rb.AddForce(-sideForce, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d")) {
            rb.AddForce(sideForce, 0, 0, ForceMode.VelocityChange);
        }
    }
}
