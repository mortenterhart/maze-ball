using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    Rigidbody rb;

    float angle = 15f;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        // Edit->Project Settings->Input Manager->Axis->Horizontal/Vertical->Snap deaktivieren fuer fluessige Bewegung
        //rb.rotation = Quaternion.Euler(angle * Input.GetAxis("Vertical"), 0f, -angle * Input.GetAxis("Horizontal"));
        rb.rotation = Quaternion.Euler(angle * Input.GetAxis("Vertical"), 0f, -angle * Input.GetAxis("Horizontal"));
    }

    void Update()
    {

    }
}
