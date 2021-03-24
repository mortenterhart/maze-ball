using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateByInput : MonoBehaviour
{
    [SerializeField] private float speed;

    private Rigidbody _rb;
    
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    
    private void FixedUpdate()
    {
        var vel = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        _rb.MoveRotation(Quaternion.Euler(vel * speed * Time.deltaTime));
    }
}
