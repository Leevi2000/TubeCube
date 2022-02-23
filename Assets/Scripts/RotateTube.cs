using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotateTube : MonoBehaviour
{
    float maxAngle = 0.07f;
    public Quaternion x;
    public Rigidbody rb;

    public float forceMultiplier;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        x = transform.rotation;
        if (transform.rotation.z > maxAngle) 
        {
            forceMultiplier = 1 + (transform.rotation.z + maxAngle) * 20;
            rb.AddTorque(new Vector3(0, 0, -10 * forceMultiplier), ForceMode.Force);
            
        }
        if (transform.rotation.z < -maxAngle) 
        {
            forceMultiplier = 1 + (Mathf.Sqrt(transform.rotation.z * transform.rotation.z) + maxAngle) * 20;
            rb.AddTorque(new Vector3(0, 0, 10 * forceMultiplier), ForceMode.Force);
        }

        
    }

}
