using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetOnFall : MonoBehaviour
{
    [SerializeField] private Vector3 resetPos;
    private Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Respawn")) return;
        
        // Reset speed
        _rb.velocity = Vector3.zero;
        _rb.rotation = Quaternion.Euler(Vector3.zero);
        _rb.angularVelocity = Vector3.zero;
        
        transform.position = resetPos;
    }
}
