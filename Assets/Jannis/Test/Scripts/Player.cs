using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject spawn;

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
        rb.position = spawn.transform.position;
        rb.rotation = Quaternion.identity;
        rb.velocity = Vector3.zero;
    }

    /*void Jump()
    {
        rb.AddForce(5f * Vector3.up, ForceMode.Impulse);
    }*/

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hole"))
            Respawn();
        else if (other.CompareTag("Goal"))
            Respawn();
        else if (other.CompareTag("Trigger"))
            other.GetComponent<Trigger>().Enter();
        /*else if (other.CompareTag("Bounce"))
            Jump();*/
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Trigger"))
            other.GetComponent<Trigger>().Exit();
    }

    void Update()
    {
        if (rb.position.y <= -10f)
        {
            Respawn();
        }
    }
}
