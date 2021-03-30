using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        
    }

    void Respawn()
    {
        rb.position = new Vector3(-4f, 0.75f, -4f);
        rb.rotation = Quaternion.identity;
        rb.velocity = Vector3.zero;
    }

    void Jump()
    {
        rb.AddForce(5f * Vector3.up, ForceMode.Impulse);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hole"))
            Respawn();
        else if (other.CompareTag("Bounce"))
            Jump();
    }

    void Update()
    {
        if (rb.position.y <= -10f)
        {
            Respawn();
        }
    }
}
