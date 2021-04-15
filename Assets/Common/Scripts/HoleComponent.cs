using UnityEngine;

namespace Common.Scripts
{
    public class HoleComponent : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (!other.CompareTag("Player")) return;

            Events.OnObstacleTrigger();
        }
    }
}
