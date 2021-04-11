using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSwitchTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        Events.OnRotateSwitchTriggered();
    }
}
