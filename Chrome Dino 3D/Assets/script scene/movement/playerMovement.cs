using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float jumpForce = 60f;
    public float speed = 23f;
    private Rigidbody rb;
    static public bool canRun;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.forward * 70);
    }

    void Update()
    {
        if (rb.velocity.x == 0)
            transform.position += Vector3.forward * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (rb.velocity.y == 0)
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }
    }
}
