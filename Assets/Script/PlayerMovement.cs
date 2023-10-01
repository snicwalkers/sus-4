using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 10;
    public float speedMultiplier = 1.25f;
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddRelativeForce(-speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddRelativeForce(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddRelativeForce(0, 0, speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddRelativeForce(0, 0, -speed);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed *= speedMultiplier;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed /= speedMultiplier;
        }
    }
}
