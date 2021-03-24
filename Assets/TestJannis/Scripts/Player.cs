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
    }

    void OnTriggerEnter(Collider other)
    {
        Respawn();
    }

    void Update()
    {
        if (gameObject.transform.position.x <= -10f)
        {
            Respawn();
        }
    }
}
