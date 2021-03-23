using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        rb.rotation = Quaternion.Euler(15f * Input.GetAxis("Vertical"), 0f, -15f * Input.GetAxis("Horizontal"));
    }

    void Update()
    {
        
    }
}
