using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateByInput : MonoBehaviour
{
    [SerializeField] private float angle;

    private Rigidbody _rb;
    
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    
    private void FixedUpdate()
    {
        if (!Input.GetMouseButton(0)) return;
        
        //var vel = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        var p = Input.mousePosition;
        //p.y *= -1f;
        //p.x = Mathf.Clamp(p.x, -angle, angle);
        //p.y = Mathf.Clamp(p.y, -angle, angle);
        p.z = p.y;
        p.y = 0f;
        var vel = Camera.main.ScreenToWorldPoint(p);
        var xTemp = vel.x / (Screen.height) - Screen.height * 0.5f;
        vel.x = vel.z / Screen.width;
        vel.z = xTemp;
        vel.y = 0f;
        Debug.Log(vel);
        _rb.MoveRotation(Quaternion.Euler(vel * angle));
    }
}
