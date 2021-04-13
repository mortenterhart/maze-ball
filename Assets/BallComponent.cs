using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallComponent : MonoBehaviour
{
    Vector3 _initialPos;
    Rigidbody _rb;
    
    // Start is called before the first frame update
    void Start()
    {
        Events.ObstacleTrigger += EventsOnObstacleTrigger;
        _initialPos = transform.position;
        _rb = GetComponent<Rigidbody>();
    }

    void EventsOnObstacleTrigger()
    {
        // Reset speed
        _rb.velocity = Vector3.zero;
        _rb.rotation = Quaternion.Euler(Vector3.zero);
        _rb.angularVelocity = Vector3.zero;
        
        gameObject.transform.position = _initialPos;
    }

    void OnDestroy()
    {
        Events.ObstacleTrigger -= EventsOnObstacleTrigger;
    }
}
