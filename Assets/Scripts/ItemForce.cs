using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemForce : MonoBehaviour
{
    float speed;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        speed = Random.Range(5, 13);
        rb.AddForce(transform.forward * Random.Range(8, 22) * rb.mass, ForceMode.Impulse);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddTorque(new Vector3(-speed * rb.mass, 0, 0));

        if (transform.position.z < -10) { Destroy(this.gameObject); }
    }
}
