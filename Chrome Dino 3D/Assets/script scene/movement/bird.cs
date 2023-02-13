using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    
    public float speed = 16f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.forward * -70);
    }

    void Update()
    {
        if (rb.velocity.x == 0)
            transform.position += Vector3.forward * speed * Time.deltaTime;

    }
}
