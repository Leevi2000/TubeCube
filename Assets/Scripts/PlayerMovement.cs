using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float force = 15;
    public float jumpForce = 25;
    public float jumpCoolDown;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerWASD();
        PlayerJump();
        KeepInBoundaries();
        jumpCoolDown = jumpCoolDown - Time.deltaTime;
    }

    void PlayerWASD()
    {
        {
  
            if (Input.GetKey(KeyCode.W))
            {
                rb.AddTorque(new Vector3(force, 0, 0), ForceMode.Impulse);
            }
            if (Input.GetKey(KeyCode.A))
            {
                rb.AddTorque(new Vector3(0, 0, force), ForceMode.Impulse);
            }
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddTorque(new Vector3(0, 0, -force), ForceMode.Impulse); ;
            }
            if (Input.GetKey(KeyCode.S))
            {
                rb.AddTorque(new Vector3(-force, 0, 0), ForceMode.Impulse);
            }
        }
    }

    void PlayerJump()
    {
        if (jumpCoolDown <= 0)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.VelocityChange);
                jumpCoolDown = 3;
            }
        }
    }

    void KeepInBoundaries()
    {
        if (transform.position.z < -7) { transform.position = new Vector3(transform.position.x, transform.position.y, -7); }
        if (transform.position.z > 1) { transform.position = new Vector3(transform.position.x, transform.position.y, 1); }
    }
}
