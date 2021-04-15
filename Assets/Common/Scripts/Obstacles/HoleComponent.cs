using UnityEngine;

namespace Common.Scripts.Obstacles
{
    public class HoleComponent : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (!other.CompareTag("Player")) return;

            Events.Events.OnObstacleTrigger();
        }
    }
}
