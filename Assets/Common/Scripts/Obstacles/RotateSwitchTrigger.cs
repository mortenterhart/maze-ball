using UnityEngine;

public class RotateSwitchTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        Events.OnRotateSwitchTriggered();
        Events.OnPlayRotateButtonSfx();
    }
}

