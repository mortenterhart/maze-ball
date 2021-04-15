using UnityEngine;

namespace Common.Scripts
{
    public class RotateSwitchTrigger : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (!other.CompareTag("Player")) return;
            Events.OnRotateSwitchTriggered();
        }
    }
}
